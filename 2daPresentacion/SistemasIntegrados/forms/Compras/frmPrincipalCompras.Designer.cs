namespace forms.Compras
{
    partial class frmPrincipalCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCompras));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mniUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.mniSalir = new DevExpress.XtraBars.BarButtonItem();
            this.mniSolicitud = new DevExpress.XtraBars.BarButtonItem();
            this.mniConsolidar = new DevExpress.XtraBars.BarButtonItem();
            this.mniOrdenCompra = new DevExpress.XtraBars.BarButtonItem();
            this.mniEntregaProducto = new DevExpress.XtraBars.BarButtonItem();
            this.mniDevolucion = new DevExpress.XtraBars.BarButtonItem();
            this.mniProveedor = new DevExpress.XtraBars.BarButtonItem();
            this.mniCGenerales = new DevExpress.XtraBars.BarButtonItem();
            this.mniAceptarCotizacion = new DevExpress.XtraBars.BarButtonItem();
            this.btnCotizacion = new DevExpress.XtraBars.BarButtonItem();
            this.mnuInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnuProceso = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnuMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnuReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.mniUsuario,
            this.mniSalir,
            this.mniSolicitud,
            this.mniConsolidar,
            this.mniOrdenCompra,
            this.mniEntregaProducto,
            this.mniDevolucion,
            this.mniProveedor,
            this.mniCGenerales,
            this.mniAceptarCotizacion,
            this.btnCotizacion});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mnuInicio,
            this.mnuProceso,
            this.mnuMantenimiento,
            this.mnuReportes});
            this.ribbonControl1.Size = new System.Drawing.Size(703, 142);
            // 
            // mniUsuario
            // 
            this.mniUsuario.Caption = "Usuario";
            this.mniUsuario.Glyph = ((System.Drawing.Image)(resources.GetObject("mniUsuario.Glyph")));
            this.mniUsuario.Id = 1;
            this.mniUsuario.Name = "mniUsuario";
            // 
            // mniSalir
            // 
            this.mniSalir.Caption = "salir";
            this.mniSalir.Glyph = global::forms.Properties.Resources._24_cancelar;
            this.mniSalir.Id = 2;
            this.mniSalir.Name = "mniSalir";
            // 
            // mniSolicitud
            // 
            this.mniSolicitud.Caption = "Solicitud de Pedido";
            this.mniSolicitud.Glyph = ((System.Drawing.Image)(resources.GetObject("mniSolicitud.Glyph")));
            this.mniSolicitud.Id = 3;
            this.mniSolicitud.Name = "mniSolicitud";
            this.mniSolicitud.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mniSolicitud_ItemClick);
            // 
            // mniConsolidar
            // 
            this.mniConsolidar.Caption = "Consolidar Pedido";
            this.mniConsolidar.Glyph = ((System.Drawing.Image)(resources.GetObject("mniConsolidar.Glyph")));
            this.mniConsolidar.Id = 4;
            this.mniConsolidar.Name = "mniConsolidar";
            this.mniConsolidar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mniConsolidar_ItemClick);
            // 
            // mniOrdenCompra
            // 
            this.mniOrdenCompra.Caption = "Orden de Compra";
            this.mniOrdenCompra.Glyph = ((System.Drawing.Image)(resources.GetObject("mniOrdenCompra.Glyph")));
            this.mniOrdenCompra.Id = 6;
            this.mniOrdenCompra.Name = "mniOrdenCompra";
            this.mniOrdenCompra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mniOrdenCompra_ItemClick);
            // 
            // mniEntregaProducto
            // 
            this.mniEntregaProducto.Caption = "Entrega de Producto";
            this.mniEntregaProducto.Glyph = ((System.Drawing.Image)(resources.GetObject("mniEntregaProducto.Glyph")));
            this.mniEntregaProducto.Id = 7;
            this.mniEntregaProducto.Name = "mniEntregaProducto";
            this.mniEntregaProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mniEntregaProducto_ItemClick);
            // 
            // mniDevolucion
            // 
            this.mniDevolucion.Caption = "Devolucion";
            this.mniDevolucion.Glyph = ((System.Drawing.Image)(resources.GetObject("mniDevolucion.Glyph")));
            this.mniDevolucion.Id = 8;
            this.mniDevolucion.Name = "mniDevolucion";
            // 
            // mniProveedor
            // 
            this.mniProveedor.Caption = "Proveedor";
            this.mniProveedor.Glyph = global::forms.Properties.Resources._24_accesoUsuario;
            this.mniProveedor.Id = 9;
            this.mniProveedor.Name = "mniProveedor";
            this.mniProveedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mniProveedor_ItemClick);
            // 
            // mniCGenerales
            // 
            this.mniCGenerales.Caption = "Consultas Generales";
            this.mniCGenerales.Glyph = global::forms.Properties.Resources.consultar;
            this.mniCGenerales.Id = 16;
            this.mniCGenerales.Name = "mniCGenerales";
            // 
            // mniAceptarCotizacion
            // 
            this.mniAceptarCotizacion.Caption = "Enviar Cotizacion";
            this.mniAceptarCotizacion.Glyph = ((System.Drawing.Image)(resources.GetObject("mniAceptarCotizacion.Glyph")));
            this.mniAceptarCotizacion.Id = 19;
            this.mniAceptarCotizacion.Name = "mniAceptarCotizacion";
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Caption = "Cotizacion";
            this.btnCotizacion.Glyph = global::forms.Properties.Resources.contabilidad;
            this.btnCotizacion.Id = 21;
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCotizacion_ItemClick);
            // 
            // mnuInicio
            // 
            this.mnuInicio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.mnuInicio.Name = "mnuInicio";
            this.mnuInicio.Text = "Inicio";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.mniUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.mniSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Inicio";
            // 
            // mnuProceso
            // 
            this.mnuProceso.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.mnuProceso.Name = "mnuProceso";
            this.mnuProceso.Text = "Proceso";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.mniSolicitud);
            this.ribbonPageGroup2.ItemLinks.Add(this.mniConsolidar);
            this.ribbonPageGroup2.ItemLinks.Add(this.mniOrdenCompra);
            this.ribbonPageGroup2.ItemLinks.Add(this.mniEntregaProducto);
            this.ribbonPageGroup2.ItemLinks.Add(this.mniDevolucion);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCotizacion);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Procesos de Compras";
            // 
            // mnuMantenimiento
            // 
            this.mnuMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.mnuMantenimiento.Name = "mnuMantenimiento";
            this.mnuMantenimiento.Text = "Mantenimiento";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mniProveedor);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Opciones Mantenimiento";
            // 
            // mnuReportes
            // 
            this.mnuReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.mnuReportes.Name = "mnuReportes";
            this.mnuReportes.Text = "Reportes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.mniCGenerales);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Consultas y Reportes";
            // 
            // frmPrincipalCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 368);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmPrincipalCompras";
            this.Text = "frmPrincipalCompras";
            this.Load += new System.EventHandler(this.frmPrincipalCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem mniUsuario;
        private DevExpress.XtraBars.BarButtonItem mniSalir;
        private DevExpress.XtraBars.BarButtonItem mniSolicitud;
        private DevExpress.XtraBars.BarButtonItem mniConsolidar;
        private DevExpress.XtraBars.BarButtonItem mniOrdenCompra;
        private DevExpress.XtraBars.BarButtonItem mniEntregaProducto;
        private DevExpress.XtraBars.BarButtonItem mniDevolucion;
        private DevExpress.XtraBars.BarButtonItem mniProveedor;
        private DevExpress.XtraBars.BarButtonItem mniCGenerales;
        private DevExpress.XtraBars.BarButtonItem mniAceptarCotizacion;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuInicio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuProceso;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnCotizacion;
    }
}