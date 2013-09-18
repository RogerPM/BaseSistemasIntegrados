using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Contabilidad
{
    public partial class frmPrincipalContabilidad : Form
    {
        public frmPrincipalContabilidad()
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



        private void btnLibroDiario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCrearAsiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmComprobante pantallaAsiento = new frmComprobante();
            pantallaAsiento.ShowDialog();
        }

        private void btnModeloAsiento_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormListaModeloAsientos pantallaModelo = new FormListaModeloAsientos();
            pantallaModelo.ShowDialog();
        }

        private void btnPlanCuenta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (noChild() == true)
            {
                frmPlanCuenta pantallaPlanCta = new frmPlanCuenta();
                pantallaPlanCta.MdiParent = this;
                pantallaPlanCta.Show();
            }
        }

        private void btnTransaccion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmTipoTransaccion pantallaTransaccion = new frmTipoTransaccion();
            pantallaTransaccion.ShowDialog();
        }

        private void btnMayorizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMayorizacion pantallaMayorizacion = new frmMayorizacion();
            pantallaMayorizacion.ShowDialog();
        }

        private void btnEstadosFinancieros_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReporteEstados pantallaReportes = new frmReporteEstados();
            pantallaReportes.ShowDialog();
        }

        private void btnAperturaCierre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPeriodo pantallaPeriodo = new frmPeriodo();
            pantallaPeriodo.ShowDialog();
        }

        private void frmPrincipalContabilidad_MdiChildActivate(object sender, EventArgs e)
        {
            //evento sucede cuando un child es llamado y/o cerrado
            bloqMenu();
        }
    }
}
