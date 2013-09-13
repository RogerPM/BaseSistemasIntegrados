using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmDetalleCuentasPorPagar : Form
    {
        List<clsCuentaPorPagarDetalle> DetCtasxPagar = new List<clsCuentaPorPagarDetalle>();

        public frmDetalleCuentasPorPagar(List<clsCuentaPorPagarDetalle> detCtasxPag)
        {
            InitializeComponent();
            DetCtasxPagar = detCtasxPag;
            gridControl1.DataSource = DetCtasxPagar;
        }

        private void frmDetalleCuentasPorPagar_Load(object sender, EventArgs e)
        {
           // gdvDetCtasxPagar.DataSource = DetCtasxPagar;
        }
    }
}
