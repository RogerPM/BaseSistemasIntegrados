using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_CajaCierre : Form
    {
        clsCierreCaja objCierreCaja = new clsCierreCaja();
        public frm_CajaCierre()
        {
            InitializeComponent();
        }

        private void frm_CajaCierre_Load(object sender, EventArgs e)
        {
           clsDatosCierreCaja objDatosCierreCaja = new clsDatosCierreCaja();
           dgvCierre.DataSource=objDatosCierreCaja.CerrarCaja();
            string Campo;
            decimal Total;
            for (int i = 0; i < dgvCierre.Rows.Count; i++)
           {
               Campo = Convert.ToString(dgvCierre.Rows[i].Cells[0].Value);
               Total = Convert.ToDecimal(dgvCierre.Rows[i].Cells[1].Value);
               MessageBox.Show(Campo);
               if (Campo == "Efectivo") { objCierreCaja.TotalEfectivo = Total; txtEfectivo.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo == "Cheque") { objCierreCaja.TotalBoucher = Total; txtBoucher.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo == "Tarjeta Credito") { objCierreCaja.TotalCheque = Total; txtCheque.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }
               if (Campo.Contains("Transferencia")) { objCierreCaja.TotalTransferencia = Total; txtTransferencia.Text = Convert.ToString(dgvCierre.Rows[i].Cells[1].Value); }

               
               
               
           }




        }

        private void dgvCierre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
