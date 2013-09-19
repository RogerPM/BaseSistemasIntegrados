using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using clases.ActivoFijo;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace forms.ActivoFijo
{
    public partial class rpActivoFijoEspecifico : DevExpress.XtraReports.UI.XtraReport
    {
        public rpActivoFijoEspecifico()
        {
            InitializeComponent();
        }

        public void loadReport(List<clsReporte> datos)
        {
            try
            {
                this.DataSource = datos;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
