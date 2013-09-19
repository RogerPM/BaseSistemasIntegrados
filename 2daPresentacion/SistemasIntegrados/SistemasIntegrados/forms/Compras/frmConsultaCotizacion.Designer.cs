namespace forms.Compras
{
    partial class frmConsultaCotizacion
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
            this.dtgDetalleCotizacion = new DevExpress.XtraGrid.GridControl();
            this.DatosDetalleCot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPedido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dtgCabeceraCotizacion = new DevExpress.XtraGrid.GridControl();
            this.DatosCabeceraCot = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRuta = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDetalleCot)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCabeceraCotizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCabeceraCot)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDetalleCotizacion
            // 
            this.dtgDetalleCotizacion.Location = new System.Drawing.Point(12, 196);
            this.dtgDetalleCotizacion.MainView = this.DatosDetalleCot;
            this.dtgDetalleCotizacion.Name = "dtgDetalleCotizacion";
            this.dtgDetalleCotizacion.Size = new System.Drawing.Size(942, 126);
            this.dtgDetalleCotizacion.TabIndex = 36;
            this.dtgDetalleCotizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosDetalleCot});
            // 
            // DatosDetalleCot
            // 
            this.DatosDetalleCot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero1,
            this.collinea,
            this.colPedido,
            this.colidTipoArticulo,
            this.colTipoArticulo,
            this.colidUsuario1,
            this.colUsuario1,
            this.colFecha1,
            this.colIdEmpresa1,
            this.colEmpresa1});
            this.DatosDetalleCot.GridControl = this.dtgDetalleCotizacion;
            this.DatosDetalleCot.Name = "DatosDetalleCot";
            // 
            // colNumero1
            // 
            this.colNumero1.FieldName = "Numero";
            this.colNumero1.Name = "colNumero1";
            this.colNumero1.Visible = true;
            this.colNumero1.VisibleIndex = 0;
            // 
            // collinea
            // 
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 1;
            // 
            // colPedido
            // 
            this.colPedido.FieldName = "Pedido";
            this.colPedido.Name = "colPedido";
            this.colPedido.Visible = true;
            this.colPedido.VisibleIndex = 2;
            // 
            // colidTipoArticulo
            // 
            this.colidTipoArticulo.FieldName = "idTipoArticulo";
            this.colidTipoArticulo.Name = "colidTipoArticulo";
            this.colidTipoArticulo.Visible = true;
            this.colidTipoArticulo.VisibleIndex = 3;
            // 
            // colTipoArticulo
            // 
            this.colTipoArticulo.FieldName = "TipoArticulo";
            this.colTipoArticulo.Name = "colTipoArticulo";
            this.colTipoArticulo.Visible = true;
            this.colTipoArticulo.VisibleIndex = 4;
            // 
            // colidUsuario1
            // 
            this.colidUsuario1.FieldName = "idUsuario";
            this.colidUsuario1.Name = "colidUsuario1";
            this.colidUsuario1.Visible = true;
            this.colidUsuario1.VisibleIndex = 5;
            // 
            // colUsuario1
            // 
            this.colUsuario1.FieldName = "Usuario";
            this.colUsuario1.Name = "colUsuario1";
            this.colUsuario1.Visible = true;
            this.colUsuario1.VisibleIndex = 6;
            // 
            // colFecha1
            // 
            this.colFecha1.FieldName = "Fecha";
            this.colFecha1.Name = "colFecha1";
            this.colFecha1.Visible = true;
            this.colFecha1.VisibleIndex = 7;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.Visible = true;
            this.colIdEmpresa1.VisibleIndex = 8;
            // 
            // colEmpresa1
            // 
            this.colEmpresa1.FieldName = "Empresa";
            this.colEmpresa1.Name = "colEmpresa1";
            this.colEmpresa1.Visible = true;
            this.colEmpresa1.VisibleIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(966, 25);
            this.toolStrip1.TabIndex = 35;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 22);
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dtgCabeceraCotizacion
            // 
            this.dtgCabeceraCotizacion.Location = new System.Drawing.Point(12, 48);
            this.dtgCabeceraCotizacion.MainView = this.DatosCabeceraCot;
            this.dtgCabeceraCotizacion.Name = "dtgCabeceraCotizacion";
            this.dtgCabeceraCotizacion.Size = new System.Drawing.Size(942, 131);
            this.dtgCabeceraCotizacion.TabIndex = 34;
            this.dtgCabeceraCotizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosCabeceraCot});
            this.dtgCabeceraCotizacion.Click += new System.EventHandler(this.dtgCabeceraCotizacion_Click);
            // 
            // DatosCabeceraCot
            // 
            this.DatosCabeceraCot.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.colidProveedor,
            this.colProveedor,
            this.colFecha,
            this.colidEmpresa,
            this.colEmpresa,
            this.colidUsuario,
            this.colUsuario,
            this.colidEstado,
            this.colEstado,
            this.colRuta});
            this.DatosCabeceraCot.GridControl = this.dtgCabeceraCotizacion;
            this.DatosCabeceraCot.Name = "DatosCabeceraCot";
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 0;
            // 
            // colidProveedor
            // 
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 1;
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 2;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            this.colidEmpresa.Visible = true;
            this.colidEmpresa.VisibleIndex = 4;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 5;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Visible = true;
            this.colidUsuario.VisibleIndex = 6;
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 7;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 8;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 9;
            // 
            // colRuta
            // 
            this.colRuta.FieldName = "Ruta";
            this.colRuta.Name = "colRuta";
            this.colRuta.Visible = true;
            this.colRuta.VisibleIndex = 10;
            // 
            // frmConsultaCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 340);
            this.Controls.Add(this.dtgDetalleCotizacion);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dtgCabeceraCotizacion);
            this.Name = "frmConsultaCotizacion";
            this.Text = "frmConsultaCotizacion";
            this.Load += new System.EventHandler(this.frmConsultaCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalleCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDetalleCot)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCabeceraCotizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCabeceraCot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgDetalleCotizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosDetalleCot;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero1;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl dtgCabeceraCotizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosCabeceraCot;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colRuta;
    }
}