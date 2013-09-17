using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Cuentasxpagar;

namespace forms
{
    public partial class frmSesion : Form
    {
        

        public frmSesion()
        {
            InitializeComponent();
        }

        /*private void toolStripButton1_Click(object sender, EventArgs e, int a)
        {
            frmMenuCtasXPagar f = new frmMenuCtasXPagar();
            f.ShowDialog();
        }
        */
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmMenuCuentasPorPagar f = new frmMenuCuentasPorPagar();
            f.ShowDialog();
        }
    }
}
