using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Seguridad;
using clases.Seguridad;
using forms._Otro;

namespace forms.Seguridad
{
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }
        public clsUsuario usuario = new clsUsuario();
        public void obtener()
        {
            //usuario.IdUsuario = Convert.ToInt32(txtCedula.Text);
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contrasena = Validador.encriptarCadena(txtContrasenia.Text);
            //usuario.Contrasena = txtContrasenia.Text;
            //usuario.IdEstado = Convert.ToInt32(Convert.ToString(cbxEstado.SelectedValue));
            //usuario.IdImagen = Convert.ToInt32(cuadroCombinadoGrafico1.SelectedValue);
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Validador.ContraseñaValidad(txtNueva))
            {
                if (txtNueva.Text == txtConfirmar.Text)
                {
                    obtener();
                    if (datUsuario.CambiarClave(usuario, Validador.encriptarCadena(txtNueva.Text)))
                        MessageBox.Show("Cambio exitoso", "Correcto", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("No se ha podido Cambiar Clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Contraseña y Confirmación de Contraseña deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Contraseña Nueva Debe Poseer Mayúsculas,Minúsculas,Números y Caracteres Especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
