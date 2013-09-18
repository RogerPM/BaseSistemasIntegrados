using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Taller
{
    public partial class frmPrincipalTaller : Form
    {
        public frmPrincipalTaller()
        {
            InitializeComponent();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {      
            frmPresupuesto f = new frmPresupuesto();
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmClienteTaller ct = new frmClienteTaller();
            ct.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulosTaller vt = new frmArticulosTaller();
            vt.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmpleadoTaller mt = new frmEmpleadoTaller();
            mt.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulosTaller r = new frmArticulosTaller();
            r.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManodeObra mo = new frmManodeObra();
            mo.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTiposTrabajos tt = new frmTiposTrabajos();
            tt.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdendeTrabajo ot = new frmOrdendeTrabajo();
            ot.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLiquidacion sv = new frmLiquidacion();
            sv.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptOrdenesdeTrabajo rot = new frmRptOrdenesdeTrabajo();
            rot.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptHistorialdeReparaciones rh = new frmRptHistorialdeReparaciones();
            rh.Show();
        }
    }
}
