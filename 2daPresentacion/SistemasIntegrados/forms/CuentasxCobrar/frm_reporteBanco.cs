using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace forms.CuentasxCobrar
{
    public partial class frm_ReporteBanco : Form
    {
        public frm_ReporteBanco()
        {
            InitializeComponent();
        }

        private void frm_ReporteBanco_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetCuentasPorCobrar.Banco' table. You can move, or remove it, as needed.
            this.bancoTableAdapter.Fill(this.dataSetCuentasPorCobrar.Banco);

            this.reportViewer1.RefreshReport();
        }

        private void btnConsultar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string varEstado;
            DataSetCuentasPorCobrarTableAdapters.BancoTableAdapter Adapter = new DataSetCuentasPorCobrarTableAdapters.BancoTableAdapter();
            DataSetCuentasPorCobrar.BancoDataTable Table = new DataSetCuentasPorCobrar.BancoDataTable();
            

            if (rbtnTodos.Checked)
            {
                varEstado = "*";
                Adapter.Fill(Table);
            }
            if (rbtnActivo.Checked)
            {
                varEstado = "A";
                Adapter.FillBy(Table, varEstado);
            }
            if (rbtnInactivo.Checked)
            {
                varEstado = "I";
                Adapter.FillBy(Table, varEstado);
            }
                        
            ReportDataSource MyNewDataSource = new ReportDataSource("DataSetCuentasPorCobrar", (DataTable)Table);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(MyNewDataSource);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
