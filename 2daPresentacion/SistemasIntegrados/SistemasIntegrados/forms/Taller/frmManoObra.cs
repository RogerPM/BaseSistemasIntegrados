using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using clases.Taller;
using datos.Inventario;
using datos.Taller;

namespace forms.Taller
{
    public partial class frmManoObra : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsMensajesTaller msjtaller = new clsMensajesTaller();
        clsManoObra oManoObra = new clsManoObra();
        datManoObra oDatManoObra = new datManoObra();
        datTiposTrabajos oDatTipoTrabajo = new datTiposTrabajos();

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


        public frmManoObra()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxTipoTrabajo.Text == "" ||  txtPrecioHora.Text == "" || speNroHoras.Text == ""
                 || txtPrecioTotal.Text == "" || txtObservacion.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if (oDatManoObra.Guardar(oManoObra))
                {
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                    txtCodigo.Text = Convert.ToString(oManoObra.IdManoObra);
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

        public void getValores()
        {
            if (txtCodigo.Text == "")
            {
                oManoObra.IdManoObra = 0;//PK
            }
            else
            {
                oManoObra.IdManoObra = Convert.ToInt32(txtCodigo.Text);
            }

            oManoObra.IdTipoTrabajo = Convert.ToInt32(oDatManoObra.getIdSegunDescripcionManoObra(cbxTipoTrabajo.Text));
            oManoObra.NroHoras = Convert.ToInt32(speNroHoras.Text);
            oManoObra.PrecioHora = Convert.ToDecimal(txtPrecioHora.Text);
            oManoObra.Total = Convert.ToDecimal(txtPrecioTotal.Text);
            oManoObra.Observacion = txtObservacion.Text;

            if (cbxEstado.SelectedItem == "Activo")
            {
                oManoObra.IdEstado = 1;
            }
            else if (cbxEstado.SelectedItem == "Inactivo")
            {
                oManoObra.IdEstado = 2;
            }
            oManoObra.IdEmpresa = 1;
        }

        private void frmManoObra_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            this.cbxTipoTrabajo.Properties.DataSource = oDatTipoTrabajo.Consultar();
            Seguridad();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarManoObra f = new frmConsultarManoObra();
            f.ShowDialog();
            oManoObra = f.e;

            if (oManoObra.IdManoObra == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oManoObra.IdManoObra);
                cbxTipoTrabajo.EditValue = oDatManoObra.getDescripcionSegunIdTipoTrabajo(oManoObra.IdTipoTrabajo);
                speNroHoras.Text = Convert.ToString(oManoObra.NroHoras);
                txtPrecioHora.Text = Convert.ToString(oManoObra.PrecioHora);
                txtPrecioTotal.Text = Convert.ToString(oManoObra.Total);
                txtObservacion.Text = Convert.ToString(oManoObra.Observacion);
                if (oManoObra.IdEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oManoObra.IdEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbxTipoTrabajo.Text == "" || txtPrecioHora.Text == "" || speNroHoras.Text == ""
                 || txtPrecioTotal.Text == "" || txtObservacion.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if (oDatManoObra.Modificar(oManoObra))
                {
                    MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatManoObra.Eliminar(oManoObra))
                {

                    MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            borrar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        public void borrar()
        {
            txtCodigo.Text = "";
            cbxTipoTrabajo.Text = "";
            txtPrecioHora.Text = "0";
            speNroHoras.Text = "";
            txtPrecioTotal.Text = "0";
            txtObservacion.Text = "";
            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void txtPrecioHora_EditValueChanged(object sender, EventArgs e)
        {
            txtPrecioTotal.Text = Convert.ToString(Convert.ToDecimal(speNroHoras.Text) * Convert.ToDecimal(txtPrecioHora.Text));
        }

    }
}
