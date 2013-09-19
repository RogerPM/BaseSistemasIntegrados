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
    public partial class frm_ReporteInversion : Form
    {
        public frm_ReporteInversion()
        {
            InitializeComponent();
        }

        private void frm_ReporteInversion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCuentasPorCobrar.Inversion' table. You can move, or remove it, as needed.
            this.inversionTableAdapter.Fill(this.dataSetCuentasPorCobrar.Inversion);

            this.rpvInversion.RefreshReport();
        }
    }
}
