using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.CuentasxCobrar
{
    public partial class frm_ReporteMovimientoBancario : Form
    {
        public frm_ReporteMovimientoBancario()
        {
            InitializeComponent();
        }

        private void frm_ReporteMovimientoBancario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCuentasPorCobrar.MovimientoBancario' table. You can move, or remove it, as needed.
            this.movimientoBancarioTableAdapter.Fill(this.dataSetCuentasPorCobrar.MovimientoBancario);

            this.rpvMovimientoBancario.RefreshReport();
        }
    }
}
