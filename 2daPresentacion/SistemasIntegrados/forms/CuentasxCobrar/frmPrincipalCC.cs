using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.CuentasxCobrar
{
    public partial class frmPrincipalCC : Form
    {
        public frmPrincipalCC()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoTarjetaCredito fm = new frm_MantenimientoTarjetaCredito();
            fm.ShowDialog();
        }

        private void frmPrincipalCC_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_cobro fm = new frm_cobro();
            fm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            frm_CajaApertura ca = new frm_CajaApertura();
            ca.ShowDialog();

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_CajaCierre fm = new frm_CajaCierre();
            fm.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Inversion fm = new frm_Inversion();
            fm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_conciliacionBancaria fm = new frm_conciliacionBancaria();
            fm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MovimientoBancario fm = new frm_MovimientoBancario();
            fm.ShowDialog();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoTipoInversion mi = new frm_MantenimientoTipoInversion();
            mi.ShowDialog();

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ReporteEstadoCuenta mi = new frm_ReporteEstadoCuenta();
            mi.ShowDialog();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_reporteBanco mi = new frm_reporteBanco();
            mi.ShowDialog();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ReporteCobro mi = new frm_ReporteCobro();
            mi.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoBanco mi = new frm_MantenimientoBanco();
            mi.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_ReporteEstadoCuenta mi = new frm_ReporteEstadoCuenta ();
            mi.ShowDialog();

        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoUnidadTiempo mi = new frm_MantenimientoUnidadTiempo();
            mi.ShowDialog();
        }

        private void barButtonItem9_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoCuentaBancaria mi = new frm_MantenimientoCuentaBancaria();
            mi.ShowDialog();
        }

        private void barButtonItem5_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_MantenimientoDetalleMonetario mi = new frm_MantenimientoDetalleMonetario();
            mi.ShowDialog();
        }
    }
}
