using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Cuentasxpagar
{
    public partial class frmCuentasPorPagar : Form
    {
        public frmCuentasPorPagar()
        {
            InitializeComponent();
        }

        private void rdbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbFormaPago.SelectedIndex == 1 )
            {
                groupBox2.Enabled = true;
                txtValorEntrada.Enabled = false;
                txtDeuda.Enabled = false;
                txtNroLetras.Enabled = false;
                cbxFrecuencia.Enabled = false;
                txtValorCadaLetra.Enabled = false;
            }
            else
            {
                txtValorEntrada.Enabled = true ;
                txtDeuda.Enabled = true;
                txtNroLetras.Enabled = true;
                cbxFrecuencia.Enabled = true;
                txtValorCadaLetra.Enabled = true;


            }
        }
    }
}
