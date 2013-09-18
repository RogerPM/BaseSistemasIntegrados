using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Compras
{
    public partial class frmPrincipalCompras : Form
    {
        public frmPrincipalCompras()
        {
            InitializeComponent();
        }

        private void mniProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProveedor f = new frmProveedor();
            f.ShowDialog();
        }
    }
}
