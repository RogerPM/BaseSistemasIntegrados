using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using clases.Compras;

namespace forms.Compras
{
    public partial class rptSolicitud : DevExpress.XtraReports.UI.XtraReport
    {
        public rptSolicitud()
        {
            InitializeComponent();
        }
        public void datos(List<clsRptSolicitud1> datos)
        {
            this.DataSource = datos;
        }

    }
}
