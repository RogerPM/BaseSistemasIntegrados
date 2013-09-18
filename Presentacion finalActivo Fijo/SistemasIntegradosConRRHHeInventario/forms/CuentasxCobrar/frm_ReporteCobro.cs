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
    public partial class frm_ReporteCobro : Form
    {
        public frm_ReporteCobro()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ConsultaReporteCobro fcr = new frm_ConsultaReporteCobro();
            fcr.ShowDialog();
        }
    }
}
