namespace forms.Inventario
{
    partial class frmConsultaIngresoEgresoCAB
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
            this.gdcConsultaIngresoEgreso = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NroMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FechaMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.OrdenCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaIngresoEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcConsultaIngresoEgreso
            // 
            this.gdcConsultaIngresoEgreso.Location = new System.Drawing.Point(1, 2);
            this.gdcConsultaIngresoEgreso.MainView = this.gridView1;
            this.gdcConsultaIngresoEgreso.Name = "gdcConsultaIngresoEgreso";
            this.gdcConsultaIngresoEgreso.Size = new System.Drawing.Size(621, 305);
            this.gdcConsultaIngresoEgreso.TabIndex = 0;
            this.gdcConsultaIngresoEgreso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Empresa,
            this.NroMovimiento,
            this.TipoMovimiento,
            this.FechaMovimiento,
            this.OrdenCompra,
            this.Factura,
            this.Motivo,
            this.Bodega,
            this.Responsable,
            this.TotalPagar,
            this.Observacion,
            this.Estado});
            this.gridView1.GridControl = this.gdcConsultaIngresoEgreso;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // Empresa
            // 
            this.Empresa.Caption = "Empresa";
            this.Empresa.FieldName = "empresa";
            this.Empresa.Name = "Empresa";
            // 
            // NroMovimiento
            // 
            this.NroMovimiento.Caption = "NroMovimiento";
            this.NroMovimiento.FieldName = "nroMovimiento";
            this.NroMovimiento.Name = "NroMovimiento";
            this.NroMovimiento.Visible = true;
            this.NroMovimiento.VisibleIndex = 0;
            // 
            // TipoMovimiento
            // 
            this.TipoMovimiento.Caption = "TipoMovimiento";
            this.TipoMovimiento.FieldName = "tipoMovimiento";
            this.TipoMovimiento.Name = "TipoMovimiento";
            this.TipoMovimiento.Visible = true;
            this.TipoMovimiento.VisibleIndex = 1;
            // 
            // FechaMovimiento
            // 
            this.FechaMovimiento.Caption = "Fecha Movimiento";
            this.FechaMovimiento.FieldName = "fechaMovimiento";
            this.FechaMovimiento.Name = "FechaMovimiento";
            this.FechaMovimiento.Visible = true;
            this.FechaMovimiento.VisibleIndex = 2;
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.Caption = "OrdenCompra";
            this.OrdenCompra.FieldName = "ordenCompra";
            this.OrdenCompra.Name = "OrdenCompra";
            this.OrdenCompra.Visible = true;
            this.OrdenCompra.VisibleIndex = 3;
            // 
            // Factura
            // 
            this.Factura.Caption = "Factura";
            this.Factura.FieldName = "factura";
            this.Factura.Name = "Factura";
            this.Factura.Visible = true;
            this.Factura.VisibleIndex = 4;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Motivo";
            this.Motivo.FieldName = "motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 5;
            // 
            // Bodega
            // 
            this.Bodega.Caption = "Bodega";
            this.Bodega.FieldName = "bodega";
            this.Bodega.Name = "Bodega";
            this.Bodega.Visible = true;
            this.Bodega.VisibleIndex = 6;
            // 
            // Responsable
            // 
            this.Responsable.Caption = "Responsable";
            this.Responsable.FieldName = "responsable";
            this.Responsable.Name = "Responsable";
            this.Responsable.Visible = true;
            this.Responsable.VisibleIndex = 7;
            // 
            // TotalPagar
            // 
            this.TotalPagar.Caption = "TotalPagar";
            this.TotalPagar.FieldName = "totalPagar";
            this.TotalPagar.Name = "TotalPagar";
            this.TotalPagar.Visible = true;
            this.TotalPagar.VisibleIndex = 8;
            // 
            // Observacion
            // 
            this.Observacion.Caption = "Observacion";
            this.Observacion.FieldName = "observacion";
            this.Observacion.Name = "Observacion";
            this.Observacion.Visible = true;
            this.Observacion.VisibleIndex = 9;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 10;
            // 
            // frmConsultaIngresoEgresoCAB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 331);
            this.Controls.Add(this.gdcConsultaIngresoEgreso);
            this.Name = "frmConsultaIngresoEgresoCAB";
            this.Text = "frmConsultaIngresoEgresoCAB";
            this.Load += new System.EventHandler(this.frmConsultaIngresoEgresoCAB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaIngresoEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaIngresoEgreso;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn NroMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn TipoMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn FechaMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn OrdenCompra;
        private DevExpress.XtraGrid.Columns.GridColumn Factura;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn Bodega;
        private DevExpress.XtraGrid.Columns.GridColumn Responsable;
        private DevExpress.XtraGrid.Columns.GridColumn TotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn Observacion;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
    }
}