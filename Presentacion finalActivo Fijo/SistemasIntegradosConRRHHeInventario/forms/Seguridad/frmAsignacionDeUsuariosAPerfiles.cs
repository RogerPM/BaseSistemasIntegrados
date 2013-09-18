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

namespace forms.Seguridad
{
    public partial class frmAsignacionDeUsuariosAPerfiles : Form
    {
        public frmAsignacionDeUsuariosAPerfiles()
        {
            InitializeComponent();

        }
        datPerfil DataPerfil = new datPerfil();
        datUsuario DataUsuario = new datUsuario();
        BindingList<Usuario> DataSource;
        private void frmAsignacionDeUsuariosAPerfiles_Load(object sender, EventArgs e)
        {
            cmbPerfil.DataSource = DataPerfil.Consulltar();
            DataSource = new BindingList<Usuario>(DataUsuario.ConsultarUsuarios());
            gridControl1.DataSource = DataSource;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (var item in DataSource)
            {
                DataUsuario.ModificaruSUARIO(item);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
