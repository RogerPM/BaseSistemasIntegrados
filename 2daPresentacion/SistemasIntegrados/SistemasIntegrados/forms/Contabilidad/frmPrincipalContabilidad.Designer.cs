namespace forms.Contabilidad
{
    partial class frmPrincipalContabilidad
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
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnPlanCuenta = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstadosFinancieros = new DevExpress.XtraBars.BarButtonItem();
            this.btnCrearAsiento = new DevExpress.XtraBars.BarButtonItem();
            this.btnMayorizar = new DevExpress.XtraBars.BarButtonItem();
            this.btnModeloAsiento = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransaccion = new DevExpress.XtraBars.BarButtonItem();
            this.btnAperturaCierre = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.Inicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageProcesos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupProcesos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.groupReportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnPlanCuenta,
            this.btnEstadosFinancieros,
            this.btnCrearAsiento,
            this.btnMayorizar,
            this.btnModeloAsiento,
            this.btnTransaccion,
            this.btnAperturaCierre,
            this.btnSalir});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Inicio,
            this.pageProcesos,
            this.pageMantenimiento,
            this.pageReportes});
            this.ribbonControl1.Size = new System.Drawing.Size(713, 142);
            // 
            // btnPlanCuenta
            // 
            this.btnPlanCuenta.Caption = "Plan de Cuentas";
            this.btnPlanCuenta.Glyph = global::forms.Properties.Resources.sitemap_blue;
            this.btnPlanCuenta.Id = 1;
            this.btnPlanCuenta.Name = "btnPlanCuenta";
            this.btnPlanCuenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPlanCuenta_ItemClick);
            // 
            // btnEstadosFinancieros
            // 
            this.btnEstadosFinancieros.Caption = "Estados Financieros";
            this.btnEstadosFinancieros.Glyph = global::forms.Properties.Resources.stats2;
            this.btnEstadosFinancieros.Id = 2;
            this.btnEstadosFinancieros.Name = "btnEstadosFinancieros";
            this.btnEstadosFinancieros.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstadosFinancieros_ItemClick);
            // 
            // btnCrearAsiento
            // 
            this.btnCrearAsiento.Caption = "Crear Asiento";
            this.btnCrearAsiento.Glyph = global::forms.Properties.Resources.add_comment_blue;
            this.btnCrearAsiento.Id = 9;
            this.btnCrearAsiento.Name = "btnCrearAsiento";
            this.btnCrearAsiento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCrearAsiento_ItemClick);
            // 
            // btnMayorizar
            // 
            this.btnMayorizar.Caption = "Mayorizar";
            this.btnMayorizar.Glyph = global::forms.Properties.Resources.edit_comment_blue;
            this.btnMayorizar.Id = 10;
            this.btnMayorizar.Name = "btnMayorizar";
            this.btnMayorizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMayorizar_ItemClick);
            // 
            // btnModeloAsiento
            // 
            this.btnModeloAsiento.Caption = "Modelo de Asiento";
            this.btnModeloAsiento.Glyph = global::forms.Properties.Resources._24_sidebar;
            this.btnModeloAsiento.Id = 12;
            this.btnModeloAsiento.Name = "btnModeloAsiento";
            this.btnModeloAsiento.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnModeloAsiento_ItemClick);
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.Caption = "Tipo Transaccion";
            this.btnTransaccion.Glyph = global::forms.Properties.Resources._24_book_blue;
            this.btnTransaccion.Id = 13;
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransaccion_ItemClick);
            // 
            // btnAperturaCierre
            // 
            this.btnAperturaCierre.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.btnAperturaCierre.Caption = "Aperturar / Cerrar";
            this.btnAperturaCierre.Glyph = global::forms.Properties.Resources.checkout2_blue;
            this.btnAperturaCierre.Id = 14;
            this.btnAperturaCierre.Name = "btnAperturaCierre";
            this.btnAperturaCierre.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAperturaCierre_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Glyph = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.Id = 16;
            this.btnSalir.Name = "btnSalir";
            // 
            // Inicio
            // 
            this.Inicio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.Inicio.Name = "Inicio";
            this.Inicio.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // pageProcesos
            // 
            this.pageProcesos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupProcesos});
            this.pageProcesos.Name = "pageProcesos";
            this.pageProcesos.Text = "Procesos";
            // 
            // groupProcesos
            // 
            this.groupProcesos.ItemLinks.Add(this.btnCrearAsiento);
            this.groupProcesos.ItemLinks.Add(this.btnMayorizar);
            this.groupProcesos.ItemLinks.Add(this.btnAperturaCierre);
            this.groupProcesos.Name = "groupProcesos";
            // 
            // pageMantenimiento
            // 
            this.pageMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupMantenimiento});
            this.pageMantenimiento.Name = "pageMantenimiento";
            this.pageMantenimiento.Text = "Mantenimiento";
            // 
            // groupMantenimiento
            // 
            this.groupMantenimiento.ItemLinks.Add(this.btnPlanCuenta);
            this.groupMantenimiento.ItemLinks.Add(this.btnTransaccion);
            this.groupMantenimiento.ItemLinks.Add(this.btnModeloAsiento);
            this.groupMantenimiento.Name = "groupMantenimiento";
            // 
            // pageReportes
            // 
            this.pageReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupReportes});
            this.pageReportes.Name = "pageReportes";
            this.pageReportes.Text = "Reportes";
            // 
            // groupReportes
            // 
            this.groupReportes.ItemLinks.Add(this.btnEstadosFinancieros);
            this.groupReportes.Name = "groupReportes";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 389);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipalContabilidad";
            this.Text = "Contabilidad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.frmPrincipalContabilidad_MdiChildActivate);
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnPlanCuenta;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageProcesos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupProcesos;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupReportes;
        private DevExpress.XtraBars.BarButtonItem btnEstadosFinancieros;
        private DevExpress.XtraBars.BarButtonItem btnCrearAsiento;
        private DevExpress.XtraBars.BarButtonItem btnMayorizar;
        private DevExpress.XtraBars.BarButtonItem btnModeloAsiento;
        private DevExpress.XtraBars.BarButtonItem btnTransaccion;
        private DevExpress.XtraBars.BarButtonItem btnAperturaCierre;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.Ribbon.RibbonPage Inicio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}