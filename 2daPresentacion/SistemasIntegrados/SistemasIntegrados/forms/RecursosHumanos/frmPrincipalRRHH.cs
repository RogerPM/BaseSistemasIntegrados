using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using forms.RecursosHumanos;

namespace forms
{
    public partial class frmPrincipalRRHH : Form
    {
        public frmPrincipalRRHH()
        {
            InitializeComponent();
        }

     
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoDepartamento f = new frmMantenimientoDepartamento();
            f.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoNominaEmpleado f = new frmProcesoNominaEmpleado();
            f.ShowDialog();
        }

       
        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoCargo f = new frmMantenimientoCargo();
            f.ShowDialog();
        }

       

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoAnticiposEmpleado f = new frmProcesoAnticiposEmpleado();
            f.ShowDialog();
        }

    

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoPrestamoEmpleado f = new frmProcesoPrestamoEmpleado();
            f.ShowDialog();
        }

        private void barButtonItem22_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoVacaciones f = new frmProcesoVacaciones();
            f.ShowDialog();
        }

      
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoPermisos f = new frmProcesoPermisos();
            f.ShowDialog();
        }

        private void barButtonItem21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoTrabajoDiario f = new frmProcesoTrabajoDiario();
            f.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoRubros f = new frmMantenimientoRubros();
            f.ShowDialog();
        }

        private void frmPrincipalRRHH_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoTitulo f = new frmMantenimientoTitulo();
            f.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoContratos f = new frmProcesoContratos();
            f.ShowDialog();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProcesoLiquidacion f = new frmProcesoLiquidacion();
            f.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoMulta f = new frmMantenimientoMulta();
            f.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoEmpleado f = new frmMantenimientoEmpleado();
            f.ShowDialog();
         }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoMaternidad f = new frmMantenimientoMaternidad();
            f.ShowDialog();

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoTipoPrestamo f = new frmMantenimientoTipoPrestamo();
            f.ShowDialog();

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoTipoPermiso f = new frmMantenimientoTipoPermiso();
            f.ShowDialog();

        }

        private void biContrato_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoTipoContrato f = new frmMantenimientoTipoContrato();
            f.ShowDialog();

        }


        private void biUniversidad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMantenimientoUniversidad f = new frmMantenimientoUniversidad();
            f.ShowDialog();

        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmConsultaReporteEmpleado f = new frmConsultaReporteEmpleado();
            f.ShowDialog();
        }

        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmConsultaReporteRol f = new frmConsultaReporteRol();
            f.ShowDialog();
        }

    

     
    }
}
