using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using clases.Contabilidad;
using System.Collections.Generic;

namespace forms.Contabilidad
{
    public partial class rptEstadoResultado : DevExpress.XtraReports.UI.XtraReport
    {
        public rptEstadoResultado()
        {
            InitializeComponent();
        }
        public void data(List<clsRPTEstadoResultado> datos)
        {
            this.DataSource = datos;
        }
    }
}
