using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Taller;
using clases.Seguridad;
using datos.Taller;
using System.IO;
using System.Text.RegularExpressions;

namespace forms.Taller
{
    public partial class frmClienteTaller : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsMensajesTaller msjT = new clsMensajesTaller();
        clsCliente oCliente = new clsCliente();
        datCliente oDatCliente = new datCliente();

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnBuscar.Visible = frmPrincipal.Lectura;
            //escrituras
            btnNuevo.Visible = frmPrincipal.Escritura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion


        public frmClienteTaller()
        {
            InitializeComponent();
        }


        private bool VeríficaCedu1a()
        {
            string ced = txtIdentificacion.Text;
            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedu1a = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;

            if (int.TryParse(ced, out isNumeric) && ced.Length == tamanoLongitudCedu1a)
            {
                var provincia = Convert.ToInt32(string.Concat(ced[0], ced[1], string.Empty));
                var digitoTres = Convert.ToInt32(ced[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres < tercerDigito)
                {
                    var digitoverificadorRecibido = Convert.ToInt32(ced[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty)*
                                    Convert.ToInt32(ced[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoverificadorobtenido = total >= 10 ? (total%10) != 0 ?
                                                            10 - (total%10) : (total%10) : total;
                    if (digitoverificadorobtenido == digitoverificadorRecibido)
                    {
                        return true;
                    }
                }
                return false;
            }
            return false;
        }

        private bool valemail()
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(txtMail.Text, expresion))
            {
                if (Regex.Replace(txtMail.Text, expresion, String.Empty).Length == 0)
                { return true; }
                else
                { return false; }
            }
            else
            {
                return false;
            }
        }

        private bool valetel()
        {
            string phoneNum = txtTelefono.Text;
            Regex regex = new Regex(@"^(?!411|911)\d{10}$");
            Regex regex2 = new Regex(@"^(?!411|911)\d{9}$");
            Match match = regex.Match(phoneNum);
            Match match2 = regex2.Match(phoneNum);
            if (!match.Success && !match2.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDireccion.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
            else
            {
                if (cbxTipoIdentificacion.SelectedText == "Cedula" && VeríficaCedu1a() == false)
                {
                    MessageBox.Show(msjT.valecedula, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    if (valetel() == false)
                    {
                        MessageBox.Show(msjT.valetel, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (valemail() == false)
                        {
                            MessageBox.Show(msjT.valemail, msj.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            getValores();
                            if (oDatCliente.Guardar(oCliente))
                            {
                                MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                                txtCodigo.Text = Convert.ToString(oCliente.IdPersona);
                                btnModificar.Enabled = true;
                                btnEliminar.Enabled = true;
                                btnGuardar.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
                            }
                        }
                    }
                }
            }
        }

        public void getValores()
        {
            if (txtCodigo.Text == "")
            {
                oCliente.IdPersona = 0;//PK
            }
            else
            {
                oCliente.IdPersona = Convert.ToInt32(txtCodigo.Text);
            }
            oCliente.Identificacion = txtIdentificacion.Text;
            oCliente.IdTipoPersona = oDatCliente.getIdSegunDescripcionTipoPersona(cbxTipoPersona.Text);
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.FechaNacimiento = Convert.ToDateTime(cbxFechaNacimiento.Text);
            oCliente.Genero = Convert.ToString(cbxGenero.SelectedItem);
            oCliente.TipoIdentificacion = oDatCliente.getIdSegunDescripcionTipoIdentificacion(cbxTipoIdentificacion.Text);
            oCliente.Direccion = txtDireccion.Text;
            oCliente.Telefono = txtTelefono.Text;
            oCliente.Mail = txtMail.Text;
            if (cbxEstado.SelectedItem == "Activo")
            {
                oCliente.idEstado = 1;
            }
            else if (cbxEstado.SelectedItem == "Inactivo")
            {
                oCliente.idEstado = 2;
            }
            oCliente.idEmpresa = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text == "" || txtNombre.Text == "" || txtApellido.Text == "" ||
                txtDireccion.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cbxTipoIdentificacion.SelectedText == "Cedula" && VeríficaCedu1a() == false)
                {
                    MessageBox.Show(msjT.valecedula, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    if (valetel() == false)
                    {
                        MessageBox.Show(msjT.valetel, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (valemail() == false)
                        {
                            MessageBox.Show(msjT.valemail, msj.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            getValores();
                            if (oDatCliente.Modificar(oCliente))
                            {
                                MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarCliente f = new frmConsultarCliente();
            f.ShowDialog();
            oCliente = f.e;

            if (oCliente.IdPersona == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oCliente.IdPersona);
                txtIdentificacion.Text = oCliente.Identificacion;
                cbxTipoPersona.EditValue = oDatCliente.getDescripcionSegunIdTipoPersona(oCliente.IdTipoPersona);
                txtNombre.Text = oCliente.Nombre;
                txtApellido.Text = oCliente.Apellido;
                cbxFechaNacimiento.Text = Convert.ToString(oCliente.FechaNacimiento.ToShortDateString());
                cbxGenero.SelectedItem = oCliente.Genero;
                cbxTipoIdentificacion.EditValue = oDatCliente.getDescripcionSegunIdTipoIdentificacion(oCliente.TipoIdentificacion);
                txtDireccion.Text = oCliente.Direccion;
                txtTelefono.Text = oCliente.Telefono;
                txtMail.Text = Convert.ToString(oCliente.Mail);

                if (oCliente.idEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oCliente.idEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }

                oCliente.idEmpresa = 1;

                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatCliente.Eliminar(oCliente))
                {

                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            borrar();
        }

        public void borrar()
        {
            txtCodigo.Text = "";
            txtIdentificacion.Text = "";
            cbxTipoPersona.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxFechaNacimiento.Text = DateTime.Today.ToShortDateString();
            cbxGenero.Text = "";
            cbxTipoIdentificacion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar(); 
        }

        private void frmClienteTaller_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            this.cbxTipoIdentificacion.Properties.DataSource = oDatCliente.ConsultarTipoIdentificacion();
            this.cbxTipoPersona.Properties.DataSource = oDatCliente.ConsultarTipoPersona();
            cbxFechaNacimiento.Text = DateTime.Today.ToShortDateString();
            Seguridad();
        }
    }
}
