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

namespace forms.Taller
{
    public partial class frmTiposTrabajos : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsMensajesTaller msjtaller = new clsMensajesTaller();
        clsTiposTrabajos oTipoTrabajo = new clsTiposTrabajos();
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

        public frmTiposTrabajos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtObservacion.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if (oDatTipoTrabajo.Guardar(oTipoTrabajo))
                {
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                    txtCodigo.Text = Convert.ToString(oTipoTrabajo.idTipoTrabajo);
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
                oTipoTrabajo.idTipoTrabajo = 0;//PK
            }
            else
            {
                oTipoTrabajo.idTipoTrabajo = Convert.ToInt32(txtCodigo.Text);
            }
             
                oTipoTrabajo.Descripcion = txtDescripcion.Text;
                oTipoTrabajo.Observacion = txtObservacion.Text;
                if (cbxEstado.SelectedItem == "Activo")
                {
                    oTipoTrabajo.idEstado = 1;
                }
                else if (cbxEstado.SelectedItem == "Inactivo")
                {
                    oTipoTrabajo.idEstado = 2;
                }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void frmTiposTrabajos_Load(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            Seguridad();
        }

        public void borrar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtObservacion.Text = "";
            cbxEstado.SelectedIndex = 0;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtObservacion.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                getValores();
                if (oDatTipoTrabajo.Modificar(oTipoTrabajo))
                {
                    MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarTipoTrabajo f = new frmConsultarTipoTrabajo();
            f.ShowDialog();
            oTipoTrabajo = f.e;

            if (oTipoTrabajo.idTipoTrabajo == 0)
            {
                borrar();
            }
            else
            {
                txtCodigo.Text = Convert.ToString(oTipoTrabajo.idTipoTrabajo);
                txtDescripcion.Text = Convert.ToString(oTipoTrabajo.Descripcion);
                txtObservacion.Text = Convert.ToString(oTipoTrabajo.Observacion);
                if (oTipoTrabajo.idEstado == 1)
                {
                    cbxEstado.SelectedItem = "Activo";
                }
                else if (oTipoTrabajo.idEstado == 2)
                {
                    cbxEstado.SelectedItem = "Inactivo";
                }
                btnGuardar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            getValores();
            DialogResult r;
            r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                if (oDatTipoTrabajo.Eliminar(oTipoTrabajo))
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
    }
}
