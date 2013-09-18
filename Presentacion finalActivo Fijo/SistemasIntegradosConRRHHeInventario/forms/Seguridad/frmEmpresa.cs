using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//otros
using clases.Seguridad;//copy
using datos.Seguridad;
using System.IO;
using System.Drawing.Imaging;
namespace forms.Seguridad
{
    public partial class frmEmpresa : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsEmpresa oEmpresa = new clsEmpresa();
        datEmpresa oDatEmpresa = new datEmpresa();
        public clsEstado oClsEstadoEmpresa = new clsEstado(); //se hace instancia generica para estado de la empresa
        datEstado oDatEstado = new datEstado();


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

        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
            btnModificar.Enabled = false;
            habilitar(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultar f = new FrmConsultar();
            f.ShowDialog();
            oEmpresa = f.cls;
            txtcodigo.Text = Convert.ToString(oEmpresa.idEmpresa);
            txtRazonSocial.Text = Convert.ToString(oEmpresa.razonSocial);
            txtNombreComercial.Text = Convert.ToString(oEmpresa.nombreComercial);
            txtRuc.Text = Convert.ToString(oEmpresa.ruc);
            txtDireccion.Text = Convert.ToString(oEmpresa.direccion);
            rdbSector.EditValue = Convert.ToString(oEmpresa.sector);
            txtDescripcion.Text = Convert.ToString(oEmpresa.descripcion);
            cbxEstado.EditValue = oDatEstado.getDescripcionSegunId(oEmpresa.idEstado);
            txtCorreoElectronico.Text = Convert.ToString(oEmpresa.correo);
            txtPaginaWeb.Text = Convert.ToString(oEmpresa.sitioWeb);
            txtFotoUrl.Text = "";
            if (oEmpresa.logotipo != null)
            {
                MemoryStream s = new MemoryStream(oEmpresa.logotipo);
                //pictureBox1.Image = Image.FromStream(s);
                pictureBox1.BackgroundImage = Image.FromStream(s);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
            habilitar(false);
            btnModificar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show(msj.Salir, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFotoUrl.Text = Convert.ToString(openFileDialog1.FileName);
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (getValores())
            {
                if (oEmpresa.idEmpresa == 0)
                {
                    if (oDatEmpresa.Guardar(oEmpresa))
                    {
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        habilitar(false);
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (oDatEmpresa.Modificar(oEmpresa))
                    {
                        MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        btnModificar.Enabled = false;
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void habilitar(bool valor)
        {
            txtRazonSocial.Enabled = valor;
            txtNombreComercial.Enabled = valor;
            txtNombreComercial.Enabled = valor;
            txtRuc.Enabled = valor;
            rdbSector.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtDescripcion.Enabled = valor;
            cbxEstado.Enabled = valor;
            txtTelefono.Enabled = valor;
            cbxtipotelefono.Enabled = valor;
            btnAdd.Enabled = valor;
            btnRemove.Enabled = valor;
            txtPaginaWeb.Enabled = valor;
            txtCorreoElectronico.Enabled = valor;
            simpleButton2.Enabled = valor;
        }

        public void borrar()
        {
            clsEmpresa e = new clsEmpresa();
            txtcodigo.Text = "";
            txtRazonSocial.Text = "";
            txtNombreComercial.Text = "";
            txtRuc.Text = "";
            txtDireccion.Text = "";
            txtDescripcion.Text = "";
            cbxEstado.EditValue = "";
            txtCorreoElectronico.Text = "";
            txtPaginaWeb.Text = "";
            txtFotoUrl.Text = "";
            txtTelefono.Text = "";
            // e.logotipo = null;
            pictureBox1.BackgroundImage = null;
        }

        public bool getValores()
        {
            if (txtcodigo.Text == "" || txtcodigo.Text == "0")
            {
                oEmpresa.idEmpresa = 0;//PK
            }
            else
            {
                oEmpresa.idEmpresa = Convert.ToInt32(txtcodigo.Text);
            }
            if ((txtRazonSocial.Text == null || txtRazonSocial.Text == "") ||
                (txtNombreComercial.Text == null || txtNombreComercial.Text == "") ||
                (txtRuc.Text == null || txtRuc.Text == "") ||
                (txtDireccion.Text == null || txtDireccion.Text == "") ||
                (pictureBox1.BackgroundImage == null) ||
                (txtCorreoElectronico.Text == null || txtCorreoElectronico.Text == "") ||
                (rdbSector.EditValue == null) ||
                (txtPaginaWeb.Text == null || txtPaginaWeb.Text == "") ||
                (txtDescripcion.Text == null || txtDescripcion.Text == "") ||
                cbxEstado.EditValue == null)
            {
                return false;
            }


            oEmpresa.razonSocial = txtRazonSocial.Text;
            oEmpresa.nombreComercial = txtNombreComercial.Text;
            oEmpresa.ruc = txtRuc.Text;
            oEmpresa.direccion = txtDireccion.Text;
            if (txtFotoUrl.Text != "")
            {
                MemoryStream ms = new MemoryStream();
                Image.FromFile(txtFotoUrl.Text).Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                oEmpresa.logotipo = ms.ToArray();//transformando de memory stream-->matriz de array-->arreglo de byte

            }
            //oEmpresa.fechaInicioSistema=null;
            oEmpresa.correo = txtCorreoElectronico.Text;
            oEmpresa.sitioWeb = txtPaginaWeb.Text;
            oEmpresa.descripcion = txtDescripcion.Text;
            oEmpresa.sector = Convert.ToString(rdbSector.EditValue);
            oClsEstadoEmpresa.descripcion = Convert.ToString(cbxEstado.EditValue);
            oEmpresa.idEstado = Convert.ToInt32(oDatEstado.getIdSegunDescripcion(oClsEstadoEmpresa.descripcion));//en caso q no exista idEstado=0
            return true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            btnModificar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatEmpresa.Eliminar(oEmpresa))
                {
                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    borrar();
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            this.cbxEstado.Properties.DataSource = oDatEstado.ConsultaTodos();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BackgroundImage = null;
            btnModificar.Enabled = false;
            Seguridad();//copy
        }
    }
}
