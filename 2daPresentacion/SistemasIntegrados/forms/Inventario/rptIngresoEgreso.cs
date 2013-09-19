using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using clases.Inventario;

namespace forms.Inventario
{
    public partial class rptIngresoEgreso : DevExpress.XtraReports.UI.XtraReport
    {
        public rptIngresoEgreso()
        {
            InitializeComponent();
        }

        public void dato(List<clsrptIngreso> datos) {
            this.DataSource = datos;
        }

    }
}
