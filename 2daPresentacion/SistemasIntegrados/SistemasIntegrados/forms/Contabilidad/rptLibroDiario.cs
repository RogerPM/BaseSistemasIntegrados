using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using clases.Contabilidad;
namespace forms.Contabilidad
{
    public partial class rptLibroDiario : DevExpress.XtraReports.UI.XtraReport
    {
        public DateTime lbfechaini1;
        public DateTime lbfechafin1;

        public rptLibroDiario()
        {
            InitializeComponent();
        }
        public void loadData(clsReporteLB[] Data, clsvwlibrodiario[] listaReporte)
        {
            try
            {
                this.DataSource = Data;
                frmlibrodiario f = new  frmlibrodiario();
                this.txtfechaini.Text = lbfechaini1.ToString()  ; // Convert.ToString(f.lbfechaini1);
                this.txtfechafin.Text = lbfechafin1.ToString(); // Convert.ToString(f.lbfechaini1);
                f.gridControl1.DataSource = listaReporte;
            }
            catch (Exception ex)
            {
            }
        }



    }
}
