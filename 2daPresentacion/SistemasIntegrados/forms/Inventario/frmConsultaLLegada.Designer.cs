namespace forms.Inventario
{
    partial class frmConsultaLLegada
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
            this.gdcConsultaIngresoEgreso = new DevExpress.XtraGrid.GridControl();
            this.clsLlegadaMercaderiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaIngresoEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLlegadaMercaderiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcConsultaIngresoEgreso
            // 
            this.gdcConsultaIngresoEgreso.DataSource = this.clsLlegadaMercaderiaBindingSource;
            this.gdcConsultaIngresoEgreso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcConsultaIngresoEgreso.Location = new System.Drawing.Point(0, 0);
            this.gdcConsultaIngresoEgreso.MainView = this.gridView1;
            this.gdcConsultaIngresoEgreso.Name = "gdcConsultaIngresoEgreso";
            this.gdcConsultaIngresoEgreso.Size = new System.Drawing.Size(489, 244);
            this.gdcConsultaIngresoEgreso.TabIndex = 1;
            this.gdcConsultaIngresoEgreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsLlegadaMercaderiaBindingSource
            // 
            this.clsLlegadaMercaderiaBindingSource.DataSource = typeof(clases.Inventario.clsLlegadaMercaderia);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colNroMovimiento,
            this.colIdTipoMovimiento,
            this.colIdOrdenCompra,
            this.colIdProveedor,
            this.colFactura,
            this.colFechaMovimiento,
            this.colIdMotivo,
            this.colIdBodega,
            this.colIdResponsable,
            this.colObservacion,
            this.colIdUsuario,
            this.colIdEstado});
            this.gridView1.GridControl = this.gdcConsultaIngresoEgreso;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colNroMovimiento
            // 
            this.colNroMovimiento.FieldName = "NroMovimiento";
            this.colNroMovimiento.Name = "colNroMovimiento";
            // 
            // colIdTipoMovimiento
            // 
            this.colIdTipoMovimiento.FieldName = "IdTipoMovimiento";
            this.colIdTipoMovimiento.Name = "colIdTipoMovimiento";
            // 
            // colIdOrdenCompra
            // 
            this.colIdOrdenCompra.FieldName = "IdOrdenCompra";
            this.colIdOrdenCompra.Name = "colIdOrdenCompra";
            this.colIdOrdenCompra.Visible = true;
            this.colIdOrdenCompra.VisibleIndex = 0;
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 1;
            // 
            // colFactura
            // 
            this.colFactura.FieldName = "Factura";
            this.colFactura.Name = "colFactura";
            // 
            // colFechaMovimiento
            // 
            this.colFechaMovimiento.FieldName = "FechaMovimiento";
            this.colFechaMovimiento.Name = "colFechaMovimiento";
            // 
            // colIdMotivo
            // 
            this.colIdMotivo.FieldName = "IdMotivo";
            this.colIdMotivo.Name = "colIdMotivo";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // colIdResponsable
            // 
            this.colIdResponsable.FieldName = "IdResponsable";
            this.colIdResponsable.Name = "colIdResponsable";
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 2;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // frmConsultaLLegada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 244);
            this.Controls.Add(this.gdcConsultaIngresoEgreso);
            this.Name = "frmConsultaLLegada";
            this.Text = "frmConsultaLLegada";
            this.Load += new System.EventHandler(this.frmConsultaLLegada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaIngresoEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLlegadaMercaderiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaIngresoEgreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsLlegadaMercaderiaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNroMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colIdResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}