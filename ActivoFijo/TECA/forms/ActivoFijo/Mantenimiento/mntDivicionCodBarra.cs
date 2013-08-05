using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.ActivoFijo.Mantenimiento
{
    public partial class mntDivicionCodBarra : Form
    {
        public mntDivicionCodBarra()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            mntCodigoBarra frm = new mntCodigoBarra();
            frm.ShowDialog();
        }


        private void mntDivicionCodBarra_Load(object sender, EventArgs e)
        {

        }

        private void btnSetear_Click_1(object sender, EventArgs e)
        {
            mntSeteoCodigoBarra frm = new mntSeteoCodigoBarra();
            frm.ShowDialog();
        }
    }
}
