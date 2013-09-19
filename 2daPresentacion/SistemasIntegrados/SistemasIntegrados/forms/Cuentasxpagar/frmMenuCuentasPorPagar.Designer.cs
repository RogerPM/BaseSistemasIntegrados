namespace forms.Cuentasxpagar
{
    partial class frmMenuCuentasPorPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btiCuentasPorPagar = new DevExpress.XtraBars.BarButtonItem();
            this.btiOrdenPago = new DevExpress.XtraBars.BarButtonItem();
            this.btiPagos = new DevExpress.XtraBars.BarButtonItem();
            this.btiEmpresaServicio = new DevExpress.XtraBars.BarButtonItem();
            this.btiImpuestos = new DevExpress.XtraBars.BarButtonItem();
            this.btiMedioPago = new DevExpress.XtraBars.BarButtonItem();
            this.btiFrecuenciaPago = new DevExpress.XtraBars.BarButtonItem();
            this.btiCuentasPorPagarConsulta = new DevExpress.XtraBars.BarButtonItem();
            this.btiOrdenesPagoConsulta = new DevExpress.XtraBars.BarButtonItem();
            this.btiPagoConsulta = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btiCuentasPorPagar,
            this.btiOrdenPago,
            this.btiPagos,
            this.btiEmpresaServicio,
            this.btiImpuestos,
            this.btiMedioPago,
            this.btiFrecuenciaPago,
            this.btiCuentasPorPagarConsulta,
            this.btiOrdenesPagoConsulta,
            this.btiPagoConsulta});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(932, 145);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btiCuentasPorPagar
            // 
            this.btiCuentasPorPagar.Caption = "Registrar Cuentas por Pagar";
            this.btiCuentasPorPagar.Id = 1;
            this.btiCuentasPorPagar.Name = "btiCuentasPorPagar";
            this.btiCuentasPorPagar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiCuentasPorPagar_ItemClick);
            // 
            // btiOrdenPago
            // 
            this.btiOrdenPago.Caption = "Generar Orde de Pago";
            this.btiOrdenPago.Id = 2;
            this.btiOrdenPago.Name = "btiOrdenPago";
            this.btiOrdenPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiOrdenPago_ItemClick);
            // 
            // btiPagos
            // 
            this.btiPagos.Caption = "Realizar Pagos";
            this.btiPagos.Id = 3;
            this.btiPagos.Name = "btiPagos";
            this.btiPagos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiPagos_ItemClick);
            // 
            // btiEmpresaServicio
            // 
            this.btiEmpresaServicio.Caption = "Empresa de Servicio";
            this.btiEmpresaServicio.Id = 4;
            this.btiEmpresaServicio.Name = "btiEmpresaServicio";
            this.btiEmpresaServicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiEmpresaServicio_ItemClick);
            // 
            // btiImpuestos
            // 
            this.btiImpuestos.Caption = "Impuestos";
            this.btiImpuestos.Id = 5;
            this.btiImpuestos.Name = "btiImpuestos";
            this.btiImpuestos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiImpuestos_ItemClick);
            // 
            // btiMedioPago
            // 
            this.btiMedioPago.Caption = "Medios de Pago";
            this.btiMedioPago.Id = 6;
            this.btiMedioPago.Name = "btiMedioPago";
            this.btiMedioPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiMedioPago_ItemClick);
            // 
            // btiFrecuenciaPago
            // 
            this.btiFrecuenciaPago.Caption = "Frecuencias de Pago";
            this.btiFrecuenciaPago.Id = 7;
            this.btiFrecuenciaPago.Name = "btiFrecuenciaPago";
            this.btiFrecuenciaPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiFrecuenciaPago_ItemClick);
            // 
            // btiCuentasPorPagarConsulta
            // 
            this.btiCuentasPorPagarConsulta.Caption = "Cuentas por Pagar";
            this.btiCuentasPorPagarConsulta.Id = 8;
            this.btiCuentasPorPagarConsulta.Name = "btiCuentasPorPagarConsulta";
            this.btiCuentasPorPagarConsulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiCuentasPorPagarConsulta_ItemClick);
            // 
            // btiOrdenesPagoConsulta
            // 
            this.btiOrdenesPagoConsulta.Caption = "Órdenes de Pago";
            this.btiOrdenesPagoConsulta.Id = 9;
            this.btiOrdenesPagoConsulta.Name = "btiOrdenesPagoConsulta";
            this.btiOrdenesPagoConsulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiOrdenesPagoConsulta_ItemClick);
            // 
            // btiPagoConsulta
            // 
            this.btiPagoConsulta.Caption = "Pagos";
            this.btiPagoConsulta.Id = 10;
            this.btiPagoConsulta.Name = "btiPagoConsulta";
            this.btiPagoConsulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiPagoConsulta_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "PROCESOS";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btiCuentasPorPagar);
            this.ribbonPageGroup1.ItemLinks.Add(this.btiOrdenPago);
            this.ribbonPageGroup1.ItemLinks.Add(this.btiPagos);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Proceso de Pagos";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "MANTENIMIENTOS";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btiEmpresaServicio);
            this.ribbonPageGroup2.ItemLinks.Add(this.btiImpuestos);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Generales";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btiMedioPago);
            this.ribbonPageGroup3.ItemLinks.Add(this.btiFrecuenciaPago);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Pagos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "CONSULTAS / REPORTES";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btiCuentasPorPagarConsulta);
            this.ribbonPageGroup4.ItemLinks.Add(this.btiOrdenesPagoConsulta);
            this.ribbonPageGroup4.ItemLinks.Add(this.btiPagoConsulta);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Consultas";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 477);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(932, 32);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2010 Blue";
            // 
            // frmMenuCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 509);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMenuCuentasPorPagar";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Módulo Cuentas por Pagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.BarButtonItem btiCuentasPorPagar;
        private DevExpress.XtraBars.BarButtonItem btiOrdenPago;
        private DevExpress.XtraBars.BarButtonItem btiPagos;
        private DevExpress.XtraBars.BarButtonItem btiEmpresaServicio;
        private DevExpress.XtraBars.BarButtonItem btiImpuestos;
        private DevExpress.XtraBars.BarButtonItem btiMedioPago;
        private DevExpress.XtraBars.BarButtonItem btiFrecuenciaPago;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btiCuentasPorPagarConsulta;
        private DevExpress.XtraBars.BarButtonItem btiOrdenesPagoConsulta;
        private DevExpress.XtraBars.BarButtonItem btiPagoConsulta;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}