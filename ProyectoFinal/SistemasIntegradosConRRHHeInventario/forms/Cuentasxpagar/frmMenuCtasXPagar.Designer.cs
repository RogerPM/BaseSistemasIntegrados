namespace forms.Cuentasxpagar
{
    partial class frmMenuCtasXPagar
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btiCuentasPorPagar = new DevExpress.XtraBars.BarButtonItem();
            this.btiOrdenPago = new DevExpress.XtraBars.BarButtonItem();
            this.btiPagos = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btiEmpresaServicio = new DevExpress.XtraBars.BarButtonItem();
            this.btiImpuestos = new DevExpress.XtraBars.BarButtonItem();
            this.btiMedioPago = new DevExpress.XtraBars.BarButtonItem();
            this.btiCuentasPagarConsultas = new DevExpress.XtraBars.BarButtonItem();
            this.btiOrdenesPagoConsulta = new DevExpress.XtraBars.BarButtonItem();
            this.btiPagosConsulta = new DevExpress.XtraBars.BarButtonItem();
            this.btiFrecuenciaPago = new DevExpress.XtraBars.BarButtonItem();
            this.rbpProcesos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpMantenimientos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpConsultas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btiCuentasPorPagar,
            this.btiOrdenPago,
            this.btiPagos,
            this.barButtonItem9,
            this.btiEmpresaServicio,
            this.btiImpuestos,
            this.btiMedioPago,
            this.btiCuentasPagarConsultas,
            this.btiOrdenesPagoConsulta,
            this.btiPagosConsulta,
            this.btiFrecuenciaPago});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpProcesos,
            this.rbpMantenimientos,
            this.rbpConsultas});
            this.ribbonControl1.Size = new System.Drawing.Size(939, 142);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Iniciar Sesión";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Preferencias de Usuario";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Cerrar Sesión";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Minimizar";
            this.barButtonItem4.Id = 5;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Salir";
            this.barButtonItem5.Id = 6;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btiCuentasPorPagar
            // 
            this.btiCuentasPorPagar.Caption = "Registrar Cuentas por Pagar";
            this.btiCuentasPorPagar.Id = 7;
            this.btiCuentasPorPagar.Name = "btiCuentasPorPagar";
            this.btiCuentasPorPagar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiCuentasPorPagar_ItemClick);
            // 
            // btiOrdenPago
            // 
            this.btiOrdenPago.Caption = "Generar Orden de Pago";
            this.btiOrdenPago.Id = 8;
            this.btiOrdenPago.Name = "btiOrdenPago";
            this.btiOrdenPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiOrdenPago_ItemClick);
            // 
            // btiPagos
            // 
            this.btiPagos.Caption = "Realizar Pagos";
            this.btiPagos.Id = 9;
            this.btiPagos.Name = "btiPagos";
            this.btiPagos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiPagos_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Registrar Nota de Débito";
            this.barButtonItem9.Id = 10;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // btiEmpresaServicio
            // 
            this.btiEmpresaServicio.AccessibleName = "btnEmpresaServicio";
            this.btiEmpresaServicio.Caption = "Empresas de Servicio";
            this.btiEmpresaServicio.Id = 11;
            this.btiEmpresaServicio.Name = "btiEmpresaServicio";
            this.btiEmpresaServicio.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiEmpresaServicio_ItemClick);
            // 
            // btiImpuestos
            // 
            this.btiImpuestos.AccessibleName = "btnImpuesto";
            this.btiImpuestos.Caption = "Impuestos";
            this.btiImpuestos.Id = 12;
            this.btiImpuestos.Name = "btiImpuestos";
            this.btiImpuestos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiImpuestos_ItemClick);
            // 
            // btiMedioPago
            // 
            this.btiMedioPago.AccessibleName = "btnFormasMediosPAgo";
            this.btiMedioPago.Caption = "Medios de Pago";
            this.btiMedioPago.Id = 13;
            this.btiMedioPago.Name = "btiMedioPago";
            this.btiMedioPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiMedioPago_ItemClick);
            // 
            // btiCuentasPagarConsultas
            // 
            this.btiCuentasPagarConsultas.Caption = "Cuentas por Pagar";
            this.btiCuentasPagarConsultas.Id = 14;
            this.btiCuentasPagarConsultas.Name = "btiCuentasPagarConsultas";
            this.btiCuentasPagarConsultas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiCuentasPagarConsultas_ItemClick);
            // 
            // btiOrdenesPagoConsulta
            // 
            this.btiOrdenesPagoConsulta.Caption = "Órdenes de Pago";
            this.btiOrdenesPagoConsulta.Id = 15;
            this.btiOrdenesPagoConsulta.Name = "btiOrdenesPagoConsulta";
            this.btiOrdenesPagoConsulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiOrdenesPagoConsulta_ItemClick);
            // 
            // btiPagosConsulta
            // 
            this.btiPagosConsulta.Caption = "Pagos";
            this.btiPagosConsulta.Id = 16;
            this.btiPagosConsulta.Name = "btiPagosConsulta";
            this.btiPagosConsulta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiPagosConsulta_ItemClick);
            // 
            // btiFrecuenciaPago
            // 
            this.btiFrecuenciaPago.AccessibleName = "btnFrecuenciaPago";
            this.btiFrecuenciaPago.Caption = "Frecuencia de Pago";
            this.btiFrecuenciaPago.Id = 17;
            this.btiFrecuenciaPago.Name = "btiFrecuenciaPago";
            this.btiFrecuenciaPago.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btiFrecuenciaPago_ItemClick);
            // 
            // rbpProcesos
            // 
            this.rbpProcesos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpProcesos.Name = "rbpProcesos";
            this.rbpProcesos.Text = "PROCESOS";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btiCuentasPorPagar);
            this.ribbonPageGroup3.ItemLinks.Add(this.btiOrdenPago);
            this.ribbonPageGroup3.ItemLinks.Add(this.btiPagos);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Proceso de pagos";
            // 
            // rbpMantenimientos
            // 
            this.rbpMantenimientos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup7});
            this.rbpMantenimientos.Name = "rbpMantenimientos";
            this.rbpMantenimientos.Text = "MANTENIMIENTOS";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btiEmpresaServicio);
            this.ribbonPageGroup5.ItemLinks.Add(this.btiImpuestos);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Generales";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btiMedioPago);
            this.ribbonPageGroup7.ItemLinks.Add(this.btiFrecuenciaPago);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Pagos";
            // 
            // rbpConsultas
            // 
            this.rbpConsultas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.rbpConsultas.Name = "rbpConsultas";
            this.rbpConsultas.Text = "CONSULTAS / REPORTES";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btiCuentasPagarConsultas);
            this.ribbonPageGroup6.ItemLinks.Add(this.btiOrdenesPagoConsulta);
            this.ribbonPageGroup6.ItemLinks.Add(this.btiPagosConsulta);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Consultas";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 17);
            this.lblUsuario.Text = "Usuario";
            // 
            // frmMenuCtasXPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 487);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmMenuCtasXPagar";
            this.Text = "Módulo Cuentas por Pagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpProcesos;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpMantenimientos;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpConsultas;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private DevExpress.XtraBars.BarButtonItem btiCuentasPorPagar;
        private DevExpress.XtraBars.BarButtonItem btiOrdenPago;
        private DevExpress.XtraBars.BarButtonItem btiPagos;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem btiEmpresaServicio;
        private DevExpress.XtraBars.BarButtonItem btiImpuestos;
        private DevExpress.XtraBars.BarButtonItem btiMedioPago;
        private DevExpress.XtraBars.BarButtonItem btiCuentasPagarConsultas;
        private DevExpress.XtraBars.BarButtonItem btiOrdenesPagoConsulta;
        private DevExpress.XtraBars.BarButtonItem btiPagosConsulta;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btiFrecuenciaPago;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
    }
}