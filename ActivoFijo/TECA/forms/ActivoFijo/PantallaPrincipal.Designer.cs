namespace forms.ActivoFijo
{
    partial class PantallaPrincipal
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
            this.btnIngresoSesion = new DevExpress.XtraBars.BarButtonItem();
            this.btnCerrarSesion = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.btnActivoFijo = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeprecicion = new DevExpress.XtraBars.BarButtonItem();
            this.btnRevalorizacion = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransferencias = new DevExpress.XtraBars.BarButtonItem();
            this.btnBajasActivos = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasActivos = new DevExpress.XtraBars.BarButtonItem();
            this.btnCodigoBarra = new DevExpress.XtraBars.BarButtonItem();
            this.btnActivo = new DevExpress.XtraBars.BarButtonItem();
            this.btnBajaActivo = new DevExpress.XtraBars.BarButtonItem();
            this.RptInventarioDisponible = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.BajaActivo = new DevExpress.XtraBars.BarButtonItem();
            this.mnuInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.mnuProcesos = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.menuMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
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
            this.btnIngresoSesion,
            this.btnCerrarSesion,
            this.btnSalir,
            this.btnActivoFijo,
            this.btnDeprecicion,
            this.btnRevalorizacion,
            this.btnTransferencias,
            this.btnBajasActivos,
            this.btnVentasActivos,
            this.btnCodigoBarra,
            this.btnActivo,
            this.btnBajaActivo,
            this.RptInventarioDisponible,
            this.barButtonItem3,
            this.BajaActivo});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 34;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.mnuInicio,
            this.mnuProcesos,
            this.menuMantenimiento,
            this.ribbonPage4});
            this.ribbonControl1.Size = new System.Drawing.Size(1528, 142);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // btnIngresoSesion
            // 
            this.btnIngresoSesion.Caption = "Ingreso Sesion";
            this.btnIngresoSesion.Glyph = global::forms.Properties.Resources._24_accesoUsuario;
            this.btnIngresoSesion.Id = 1;
            this.btnIngresoSesion.Name = "btnIngresoSesion";
            this.btnIngresoSesion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIngresoSesion_ItemClick);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Caption = "Cerrar Sesion";
            this.btnCerrarSesion.Glyph = global::forms.Properties.Resources.eliminar1;
            this.btnCerrarSesion.Id = 2;
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 3;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick_1);
            // 
            // btnActivoFijo
            // 
            this.btnActivoFijo.Caption = "Activo Fijo";
            this.btnActivoFijo.Id = 4;
            this.btnActivoFijo.Name = "btnActivoFijo";
            this.btnActivoFijo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActivoFijo_ItemClick);
            // 
            // btnDeprecicion
            // 
            this.btnDeprecicion.Caption = "Depreciación";
            this.btnDeprecicion.Id = 5;
            this.btnDeprecicion.Name = "btnDeprecicion";
            this.btnDeprecicion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeprecicion_ItemClick_1);
            // 
            // btnRevalorizacion
            // 
            this.btnRevalorizacion.Caption = "Revalorización";
            this.btnRevalorizacion.Id = 6;
            this.btnRevalorizacion.Name = "btnRevalorizacion";
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.Caption = "Transferencias";
            this.btnTransferencias.Id = 7;
            this.btnTransferencias.Name = "btnTransferencias";
            this.btnTransferencias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransferencias_ItemClick_1);
            // 
            // btnBajasActivos
            // 
            this.btnBajasActivos.Caption = "Dar de Baja";
            this.btnBajasActivos.Id = 8;
            this.btnBajasActivos.Name = "btnBajasActivos";
            this.btnBajasActivos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBajasActivos_ItemClick_1);
            // 
            // btnVentasActivos
            // 
            this.btnVentasActivos.Caption = "Ventas Activos";
            this.btnVentasActivos.Id = 9;
            this.btnVentasActivos.Name = "btnVentasActivos";
            this.btnVentasActivos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasActivos_ItemClick_1);
            // 
            // btnCodigoBarra
            // 
            this.btnCodigoBarra.Caption = "Código Barra";
            this.btnCodigoBarra.Id = 20;
            this.btnCodigoBarra.Name = "btnCodigoBarra";
            this.btnCodigoBarra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCodigoBarra_ItemClick_1);
            // 
            // btnActivo
            // 
            this.btnActivo.Caption = "Activo Fijo";
            this.btnActivo.Id = 24;
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnActivo_ItemClick_1);
            // 
            // btnBajaActivo
            // 
            this.btnBajaActivo.Caption = "BajaActivo";
            this.btnBajaActivo.Id = 27;
            this.btnBajaActivo.Name = "btnBajaActivo";
            this.btnBajaActivo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBajaActivo_ItemClick_1);
            // 
            // RptInventarioDisponible
            // 
            this.RptInventarioDisponible.Caption = "Inventario Disponible";
            this.RptInventarioDisponible.Id = 30;
            this.RptInventarioDisponible.Name = "RptInventarioDisponible";
            this.RptInventarioDisponible.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RptInventarioDisponible_ItemClick_1);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Depreciacion Actual";
            this.barButtonItem3.Id = 31;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick_1);
            // 
            // BajaActivo
            // 
            this.BajaActivo.Caption = "Baja de Activo";
            this.BajaActivo.Id = 32;
            this.BajaActivo.Name = "BajaActivo";
            this.BajaActivo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BajaActivo_ItemClick_1);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.btnIngresoSesion);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCerrarSesion);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSalir);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // mnuProcesos
            // 
            this.mnuProcesos.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.mnuProcesos.Name = "mnuProcesos";
            this.mnuProcesos.Text = "Procesos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnActivoFijo);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDeprecicion);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRevalorizacion);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTransferencias);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBajasActivos);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnVentasActivos);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // menuMantenimiento
            // 
            this.menuMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.menuMantenimiento.Name = "menuMantenimiento";
            this.menuMantenimiento.Text = "Mantenimiento";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCodigoBarra);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBajaActivo);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnActivo);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Consultas/Reporte";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.RptInventarioDisponible);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.BajaActivo);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 813);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.Load += new System.EventHandler(this.PantallaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnIngresoSesion;
        private DevExpress.XtraBars.BarButtonItem btnCerrarSesion;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarButtonItem btnActivoFijo;
        private DevExpress.XtraBars.BarButtonItem btnDeprecicion;
        private DevExpress.XtraBars.BarButtonItem btnRevalorizacion;
        private DevExpress.XtraBars.BarButtonItem btnTransferencias;
        private DevExpress.XtraBars.BarButtonItem btnBajasActivos;
        private DevExpress.XtraBars.BarButtonItem btnVentasActivos;
        private DevExpress.XtraBars.BarButtonItem btnCodigoBarra;
        private DevExpress.XtraBars.BarButtonItem btnActivo;
        private DevExpress.XtraBars.BarButtonItem btnBajaActivo;
        private DevExpress.XtraBars.BarButtonItem RptInventarioDisponible;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem BajaActivo;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuInicio;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage mnuProcesos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage menuMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}