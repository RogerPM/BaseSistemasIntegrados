using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.ActivoFijo;

namespace forms.ActivoFijo
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnActivoFijo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsActivoFijo frm = new prcsActivoFijo();
            frm.ShowDialog();

        }

        private void btnBajasActivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsBajasActivos frm = new prcsBajasActivos();
            frm.ShowDialog();
        }

        private void btnTransferencias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsTransferencia frm = new prcsTransferencia();
            frm.ShowDialog();
        }

        private void btnDeprecicion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsDepreciacion frm = new prcsDepreciacion();
            frm.ShowDialog();

        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();

        }

        private void btnVentasActivos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsVentaGaraje frm = new prcsVentaGaraje();
            frm.ShowDialog();
        }

        private void btnCodigoBarra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntDivicionCodBarra frm = new mntDivicionCodBarra();
            frm.ShowDialog();
        }

        private void btnBajaActivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntTipoBaja frm = new mntTipoBaja();
            frm.ShowDialog();
        }

        private void btnActivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntActivoFIjo frm = new mntActivoFIjo();
            frm.ShowDialog();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void RptInventarioDisponible_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptInventarioDisponible frm = new RptInventarioDisponible();
            frm.ShowDialog();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptDepreciacionActual frm = new RptDepreciacionActual();
            frm.ShowDialog();
        }

        private void BajaActivo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptBajaActivo frm = new RptBajaActivo();
            frm.ShowDialog();
        }

        private void btnRevalorizacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnIngresoSesion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Prueba frm = new Prueba();
            //frm.ShowDialog();
        }

        private void btnSalir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnDeprecicion_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsDepreciacion frm = new prcsDepreciacion();
            frm.ShowDialog();
        }

        private void btnTransferencias_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsTransferencia frm = new prcsTransferencia();
            frm.ShowDialog();
        }

        private void btnBajasActivos_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsBajasActivos  frm = new prcsBajasActivos();
            frm.ShowDialog();
        }

        private void btnVentasActivos_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsVentaGaraje frm = new prcsVentaGaraje();
            frm.ShowDialog();
        }

        private void btnCodigoBarra_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntDivicionCodBarra frm = new mntDivicionCodBarra();
            frm.ShowDialog();
        }

        private void btnBajaActivo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntTipoBaja frm = new mntTipoBaja();
            frm.ShowDialog();
        }

        private void btnActivo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mntActivoFIjo frm = new mntActivoFIjo();
            frm.ShowDialog();
        }

        private void RptInventarioDisponible_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptInventarioDisponible frm = new RptInventarioDisponible();
            frm.ShowDialog();
        }

        private void barButtonItem3_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptDepreciacionActual frm = new RptDepreciacionActual();
            frm.ShowDialog();
        }

        private void BajaActivo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RptBajaActivo frm = new RptBajaActivo();
            frm.ShowDialog();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnRevalorizacion_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            prcsRevalorizacion frm = new prcsRevalorizacion();
            frm.ShowDialog();
        }
    }
}
