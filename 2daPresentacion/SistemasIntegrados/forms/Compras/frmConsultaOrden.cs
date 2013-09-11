using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using datos.Compras;

namespace forms.Compras
{
    public partial class frmConsultaOrden : Form
    {
        public frmConsultaOrden()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmConsultaOrden_Load(object sender, EventArgs e)
        {
            datOrdenCompra odatOrden = new datOrdenCompra();
            dtgOrdenCab.DataSource = odatOrden.ConsultarOrdenCompraCab();
        }
    }
}
