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
    public partial class frmOrdencompra : Form
    {
        public frmOrdencompra()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            frmConsultarOrdenCompra f = new frmConsultarOrdenCompra();
            f.ShowDialog();
        }
    }
}
