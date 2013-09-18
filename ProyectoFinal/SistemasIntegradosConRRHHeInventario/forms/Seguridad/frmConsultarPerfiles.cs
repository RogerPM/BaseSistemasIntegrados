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
    public partial class frmConsultarPerfiles : Form
    {
        public frmConsultarPerfiles()
        {
            InitializeComponent();
            Event_frmConsultarPerfiles_FormClosing += new Delegate_frmConsultarPerfiles_FormClosing(frmConsultarPerfiles_Event_frmConsultarPerfiles_FormClosing);
        }

        void frmConsultarPerfiles_Event_frmConsultarPerfiles_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }

      
        private void frmConsultarPerfiles_Load(object sender, EventArgs e)
        {
            datPerfil oDat = new datPerfil();
            gridControl1.DataSource = oDat.Consulltar();
        }

        clsPerfil Info = new clsPerfil();
        public delegate void Delegate_frmConsultarPerfiles_FormClosing (object sender, FormClosingEventArgs e);
        public event Delegate_frmConsultarPerfiles_FormClosing Event_frmConsultarPerfiles_FormClosing;
        private void frmConsultarPerfiles_FormClosing(object sender, FormClosingEventArgs e)
        {

            Event_frmConsultarPerfiles_FormClosing(Info, e);
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Info = (clsPerfil)gridView1.GetFocusedRow();
            this.Close();
        }
    }
}
