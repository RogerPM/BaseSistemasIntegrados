using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace forms.Cuentasxpagar
{
    public partial class frmMenuCuentasPorPagar : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public int usuario = 1, empresa = 1;
        public frmMenuCuentasPorPagar()
        {
            InitializeComponent();
        }

        private void btiCuentasPorPagar_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmCuentasPorPagar")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmCuentasPorPagar CtasXPagar = new frmCuentasPorPagar();
                CtasXPagar.MdiParent = this;
                CtasXPagar.Show();
            }
        }

        private void btiOrdenPago_ItemClick(object sender, ItemClickEventArgs e)
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
                frmOrdenPago OrdenPago = new frmOrdenPago();
                OrdenPago.MdiParent = this;
                OrdenPago.Show();
            }
        }

        private void btiPagos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmPagos")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmPagos Pagos = new frmPagos();
                Pagos.MdiParent = this;
                Pagos.Show();
            }
        }

        private void btiEmpresaServicio_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmEmpresaServicio")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmEmpresaServicio EmpresaServicio = new frmEmpresaServicio();
                EmpresaServicio.MdiParent = this;
                EmpresaServicio.Show();
            }
        }

        private void btiImpuestos_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmImpuestos")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmImpuestos Impuestos = new frmImpuestos();
                Impuestos.MdiParent = this;
                Impuestos.Show();
            }
        }

        private void btiMedioPago_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmMedioPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmMedioPago MedioPago = new frmMedioPago();
                MedioPago.MdiParent = this;
                MedioPago.Show();
            }
        }

        private void btiFrecuenciaPago_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmFrecuenciaPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmFrecuenciaPago FrecuenciaPago = new frmFrecuenciaPago();
                FrecuenciaPago.MdiParent = this;
                FrecuenciaPago.Show();
            }
        }

        private void btiCuentasPorPagarConsulta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmConsultaCuentasPagar")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaCuentasPagar CtasXPagar = new frmConsultaCuentasPagar();
                CtasXPagar.MdiParent = this;
                CtasXPagar.Show();
            }
        }

        private void btiOrdenesPagoConsulta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmConsultaOrdenPago")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaOrdenPago ConsultaOrdenPago = new frmConsultaOrdenPago();
                ConsultaOrdenPago.MdiParent = this;
                ConsultaOrdenPago.Show();
            }
        }

        private void btiPagoConsulta_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool open = false;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmConsultaPagos")
                {
                    frm.Focus();
                    open = true;
                }
            }

            if (open == false)
            {
                frmConsultaPagos ConsultaPagos = new frmConsultaPagos();
                ConsultaPagos.MdiParent = this;
                ConsultaPagos.Show();
            }
        }
    }
}