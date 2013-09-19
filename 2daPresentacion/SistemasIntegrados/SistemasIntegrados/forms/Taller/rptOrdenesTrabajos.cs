using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace forms.Taller
{
    public partial class rptOrdenesTrabajos : Form
    {
        public rptOrdenesTrabajos(ReportDocument rpt)
        {
            InitializeComponent();
            crptMostrarOrdenes.ReportSource = rpt;
            crptMostrarOrdenes.Refresh();
        }
    }
}
