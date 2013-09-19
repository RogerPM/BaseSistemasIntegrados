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

        private bool noChild()
        {
            Form[] fcChild = MdiChildren;
            if (fcChild.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void bloqMenu()
        {
            if (ribbonControl1.Enabled == true)
            {
                ribbonControl1.Enabled = false;
                ribbonControl1.Minimized = true;
            }
            else
            {
                ribbonControl1.Enabled = true;
                ribbonControl1.Minimized = false;
            }
        }


        private void frmPrincipalTaller_MdiChildActivate(object sender, EventArgs e)
        {
            //evento sucede cuando un child es llamado y/o cerrado
            bloqMenu();
        }


        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {      
            frmPresupuesto f = new frmPresupuesto();
            f.MdiParent = this;
            f.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmClienteTaller ct = new frmClienteTaller();
                ct.MdiParent = this;
                ct.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulosTaller vt = new frmArticulosTaller();
            vt.MdiParent = this;
            vt.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmArticulosTaller r = new frmArticulosTaller();
            r.MdiParent = this;
            r.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManoObra mo = new frmManoObra();
            mo.MdiParent = this;
            mo.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTiposTrabajos tt = new frmTiposTrabajos();
            tt.MdiParent = this;
            tt.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdendeTrabajo ot = new frmOrdendeTrabajo();
            ot.MdiParent = this;
            ot.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLiquidacion sv = new frmLiquidacion();
            sv.MdiParent = this;
            sv.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptOrdenesdeTrabajo rot = new frmRptOrdenesdeTrabajo();
            rot.MdiParent = this;
            rot.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptHistorialdeReparaciones rh = new frmRptHistorialdeReparaciones();
            rh.MdiParent = this;
            rh.Show();
        }

        private void bbiManoObra_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmManoObra mo = new frmManoObra();
            mo.MdiParent = this;
            mo.Show();
        }

      
    }
}
