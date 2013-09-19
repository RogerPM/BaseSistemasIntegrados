namespace forms.Compras
{
    partial class frmConsultaOrden
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dtgOrdenCab = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenCompraCabeceraVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosOrdenCab = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.dtgOrdenDet = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenCompraDetalleVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosOrdenDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraCabeceraVistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraDetalleVistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(589, 25);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "Generar Solicitud";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // dtgOrdenCab
            // 
            this.dtgOrdenCab.DataSource = this.clsOrdenCompraCabeceraVistaBindingSource;
            this.dtgOrdenCab.Location = new System.Drawing.Point(0, 28);
            this.dtgOrdenCab.MainView = this.DatosOrdenCab;
            this.dtgOrdenCab.Name = "dtgOrdenCab";
            this.dtgOrdenCab.Size = new System.Drawing.Size(589, 134);
            this.dtgOrdenCab.TabIndex = 37;
            this.dtgOrdenCab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosOrdenCab});
            this.dtgOrdenCab.Click += new System.EventHandler(this.dtgOrdenCab_Click);
            // 
            // clsOrdenCompraCabeceraVistaBindingSource
            // 
            this.clsOrdenCompraCabeceraVistaBindingSource.DataSource = typeof(clases.Compras.clsOrdenCompraCabecera_Vista);
            // 
            // DatosOrdenCab
            // 
            this.DatosOrdenCab.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.colidProveedor,
            this.colProveedor,
            this.colFecha,
            this.colidEmpresa,
            this.colEmpresa,
            this.colidUsuario,
            this.colUsuario,
            this.colidEstado,
            this.colEstado});
            this.DatosOrdenCab.GridControl = this.dtgOrdenCab;
            this.DatosOrdenCab.Name = "DatosOrdenCab";
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
            // 
            // colProveedor
            // 
            this.colProveedor.FieldName = "Proveedor";
            this.colProveedor.Name = "colProveedor";
            this.colProveedor.Visible = true;
            this.colProveedor.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 3;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 4;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // dtgOrdenDet
            // 
            this.dtgOrdenDet.DataSource = this.clsOrdenCompraDetalleVistaBindingSource;
            this.dtgOrdenDet.Location = new System.Drawing.Point(0, 168);
            this.dtgOrdenDet.MainView = this.DatosOrdenDet;
            this.dtgOrdenDet.Name = "dtgOrdenDet";
            this.dtgOrdenDet.Size = new System.Drawing.Size(589, 153);
            this.dtgOrdenDet.TabIndex = 38;
            this.dtgOrdenDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosOrdenDet});
            // 
            // clsOrdenCompraDetalleVistaBindingSource
            // 
            this.clsOrdenCompraDetalleVistaBindingSource.DataSource = typeof(clases.Compras.clsOrdenCompraDetalle_Vista);
            // 
            // DatosOrdenDet
            // 
            this.DatosOrdenDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero1,
            this.collinea,
            this.colid_articulo,
            this.colArticulo,
            this.colCantidad,
            this.colPrecio,
            this.colId_empresa,
            this.colEmpresa1});
            this.DatosOrdenDet.GridControl = this.dtgOrdenDet;
            this.DatosOrdenDet.Name = "DatosOrdenDet";
            // 
            // colNumero1
            // 
            this.colNumero1.FieldName = "Numero";
            this.colNumero1.Name = "colNumero1";
            // 
            // collinea
            // 
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 0;
            // 
            // colid_articulo
            // 
            this.colid_articulo.FieldName = "id_articulo";
            this.colid_articulo.Name = "colid_articulo";
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            // 
            // colId_empresa
            // 
            this.colId_empresa.FieldName = "Id_empresa";
            this.colId_empresa.Name = "colId_empresa";
            // 
            // colEmpresa1
            // 
            this.colEmpresa1.FieldName = "Empresa";
            this.colEmpresa1.Name = "colEmpresa1";
            this.colEmpresa1.Visible = true;
            this.colEmpresa1.VisibleIndex = 4;
            // 
            // frmConsultaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 323);
            this.Controls.Add(this.dtgOrdenDet);
            this.Controls.Add(this.dtgOrdenCab);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaOrden";
            this.Text = "frmConsultaOrden";
            this.Load += new System.EventHandler(this.frmConsultaOrden_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraCabeceraVistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraDetalleVistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl dtgOrdenCab;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosOrdenCab;
        private System.Windows.Forms.BindingSource clsOrdenCompraCabeceraVistaBindingSource;
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
        private DevExpress.XtraGrid.GridControl dtgOrdenDet;
        private System.Windows.Forms.BindingSource clsOrdenCompraDetalleVistaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosOrdenDet;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero1;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colId_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa1;
    }
}