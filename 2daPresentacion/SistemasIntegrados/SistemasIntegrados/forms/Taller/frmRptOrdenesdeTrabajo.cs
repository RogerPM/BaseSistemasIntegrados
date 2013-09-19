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
    public partial class frmRptOrdenesdeTrabajo : Form
    {

        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            btnGenerar.Visible = frmPrincipal.Lectura;
        }
        #endregion

        public frmRptOrdenesdeTrabajo()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (rbgTipoConsulta.SelectedIndex == 0)
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath+ "//Taller//crptOrdenesTrabajosG.rpt");
                rptOrdenesTrabajos report = new rptOrdenesTrabajos(rpt);
                report.ShowDialog();
            }
            if (rbgTipoConsulta.SelectedIndex == 1)
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath + "//Taller//crptOrdenesTrabajosC.rpt");
                rptOrdenesTrabajos report = new rptOrdenesTrabajos(rpt);
                report.ShowDialog();
            }
            if (rbgTipoConsulta.SelectedIndex == 2)
            {
                ReportDocument rpt = new ReportDocument();
                rpt.Load(Application.StartupPath + "//Taller//crptOrdenesTrabajosV.rpt");
                rpt.Load(@"C:\Users\Mario\Desktop\Proyecto\taller\SistemasIntegrados\datos\Taller\crptOrdenesTrabajosV.rpt");
                rptOrdenesTrabajos report = new rptOrdenesTrabajos(rpt);
                report.ShowDialog();
            }
        }

        private void frmRptOrdenesdeTrabajo_Load(object sender, EventArgs e)
        {
            cbxFechaInicio.Text = DateTime.Today.ToShortDateString();
            cbxFechaFin.Text = DateTime.Today.ToShortDateString();
            Seguridad();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
