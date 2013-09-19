using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms._Otro;

namespace forms.Seguridad
{
    public partial class frmAsignarPantallaAPerfil : Form
    {
        public frmAsignarPantallaAPerfil()
        {
            InitializeComponent();
        }

        private void frmAsignarPantallaAPerfil_Load(object sender, EventArgs e)
        {
            UCMenuTreeLsto ucc=new UCMenuTreeLsto();
            ucc.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucc);
        }
    }
}
