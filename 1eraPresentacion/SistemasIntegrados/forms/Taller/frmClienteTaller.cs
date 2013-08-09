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

namespace forms.Taller
{
    public partial class frmClienteTaller : Form
    {
        clsMensajeSeguridad msj = new clsMensajeSeguridad();
        clsCliente oCliente = new clsCliente();
        datCliente oDatCliente = new datCliente();

        public frmClienteTaller()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getValores();
            if (oDatCliente.Guardar(oCliente))
            {
                MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK);
            }
        }

        public void getValores()
        {
            if (txtIdentificacion.Text == "")
            {
                oCliente.Identificacion = 0;//PK
            }
            else
            {
                oCliente.Identificacion = Convert.ToInt32(txtIdentificacion.Text);
            }
            oCliente.IdTipoPersona = oDatCliente.getIdSegunDescripcionTipoPersona(cbxTipoPersona.Text);
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.FechaNacimiento = Convert.ToDateTime(cbxFechaNacimiento.Text);
            oCliente.Genero = Convert.ToString(cbxGenero.SelectedItem);
            oCliente.TipoIdentificacion = oDatCliente.getIdSegunDescripcionTipoIdentificacion(cbxTipoIdentificacion.Text);
            oCliente.Direccion = txtDireccion.Text;
            oCliente.Telefono = Convert.ToInt32(txtTelefono.Text);
            oCliente.Mail = txtMail.Text;
            if (cbxEstado.SelectedItem == "Activa")
            {
                oCliente.idEstado = 1;
            }
            else
            {
                oCliente.idEstado = 2;
            }
            oCliente.idEmpresa = 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmConsultarCliente f = new frmConsultarCliente();
            f.ShowDialog();
            oCliente = f.e;
            txtIdentificacion.Text = Convert.ToString(oCliente.Identificacion);
            cbxTipoPersona.SelectedItem = oDatCliente.getDescripcionSegunIdTipoPersona(oCliente.IdTipoPersona);
            txtNombre.Text = oCliente.Nombre;
            txtApellido.Text = oCliente.Apellido;
            cbxFechaNacimiento.Text = Convert.ToString(oCliente.FechaNacimiento);
            cbxGenero.SelectedItem = oCliente.Genero;
            cbxTipoIdentificacion.SelectedItem = oDatCliente.getDescripcionSegunIdTipoIdentificacion(oCliente.TipoIdentificacion);
            txtDireccion.Text = oCliente.Direccion;
            txtTelefono.Text = Convert.ToString(oCliente.Telefono);
            txtMail.Text = Convert.ToString(oCliente.Mail);

            if (oCliente.idEstado == 1)
            {
                cbxEstado.SelectedItem = "Activa";
            }
            else
            {
                cbxEstado.SelectedItem = "Inactiva";
            }

            oCliente.idEmpresa = 1;
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
        }

        public void borrar()
        {
            txtIdentificacion.Text = "";
            cbxTipoPersona.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxFechaNacimiento.Text = "";
            cbxGenero.Text = "";
            cbxTipoIdentificacion.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtMail.Text = "";
            cbxEstado.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
        }
    }
}
