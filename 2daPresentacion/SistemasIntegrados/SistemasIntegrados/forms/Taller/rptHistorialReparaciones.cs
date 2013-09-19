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
    public partial class rptHistorialReparaciones : Form
    {
        public rptHistorialReparaciones(ReportDocument rpt)
        {
            InitializeComponent();
            crptMostrarHistorial.ReportSource = rpt;
            crptMostrarHistorial.Refresh();
        }
    }
}
