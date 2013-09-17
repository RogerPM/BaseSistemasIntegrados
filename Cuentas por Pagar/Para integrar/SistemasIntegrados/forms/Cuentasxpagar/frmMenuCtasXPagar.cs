using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Cuentasxpagar
{
    public partial class frmMenuCtasXPagar : Form
    {
        public frmMenuCtasXPagar()
        {
            InitializeComponent();
        }

        private void btiCuentasPorPagar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name=="frmCuentasPorPagar")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open==false)
            {
                frmCuentasPorPagar CtasXPagar = new frmCuentasPorPagar();
                CtasXPagar.MdiParent = this;
                CtasXPagar.Show();
            }
            
        }

        private void btiOrdenPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmOrdenPago ordenPago = new frmOrdenPago();
                ordenPago.MdiParent = this;
                ordenPago.Show();
            }
        }

        private void btiPagos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmPagos pago = new frmPagos();
                pago.MdiParent = this;
                pago.Show();
            }
        }

        private void btiEmpresaServicio_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmEmpresaServicio empresaServicio = new frmEmpresaServicio();
                empresaServicio.MdiParent = this;
                empresaServicio.Show();
            }
        }

        private void btiImpuestos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmImpuestos impuesto = new frmImpuestos();
                impuesto.MdiParent = this;
                impuesto.Show();
            }
        }

        private void btiMedioPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmMedioPago medioPago = new frmMedioPago();
                medioPago.MdiParent = this;
                medioPago.Show();
            }
        }

        private void btiFrecuenciaPago_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmFrecuenciaPago frecuenciaPago = new frmFrecuenciaPago();
                frecuenciaPago.MdiParent = this;
                frecuenciaPago.Show();
            }
        }

        private void btiCuentasPagarConsultas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaCuentasPagar consultaCtasXPagar = new frmConsultaCuentasPagar();
                consultaCtasXPagar.MdiParent = this;
                consultaCtasXPagar.Show();
            }
        }

        private void btiOrdenesPagoConsulta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaOrdenPago consultaOrdenPago = new frmConsultaOrdenPago();
                consultaOrdenPago.MdiParent = this;
                consultaOrdenPago.Show();
            }
        }

        private void btiPagosConsulta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaPagos consultaPago = new frmConsultaPagos();
                consultaPago.MdiParent = this;
                consultaPago.Show();
            }
        }

    }
}
