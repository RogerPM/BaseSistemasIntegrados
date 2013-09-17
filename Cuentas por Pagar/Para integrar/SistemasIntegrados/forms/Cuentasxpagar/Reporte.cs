using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Linq;
using System.Collections.Generic;

using System.Text;

namespace forms.Cuentasxpagar
{
    public partial class Reporte : DevExpress.XtraReports.UI.XtraReport
    {
        public Reporte()
        {
            InitializeComponent();
        }
        public void loadReport(List<clases.Cuentasxpagar.ReporteClase> datos)
        {
            try
            {
                this.DataSource = datos;
            }
            catch (Exception)
            {
            }

            //

        }
    }
}
