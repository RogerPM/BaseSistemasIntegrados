namespace forms.Cuentasxpagar
{
    partial class frmDetalleCuentasPorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCuentasPorPagar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsCuentaPorPagarDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvDetCtasxPagar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumCuentaPorPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumCuentaPorPagarDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ValorLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetCtasxPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(586, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsCuentaPorPagarDetalleBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gdvDetCtasxPagar;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(586, 303);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDetCtasxPagar});
            // 
            // clsCuentaPorPagarDetalleBindingSource
            // 
            this.clsCuentaPorPagarDetalleBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsCuentaPorPagarDetalle);
            // 
            // gdvDetCtasxPagar
            // 
            this.gdvDetCtasxPagar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdEmpresa,
            this.col_NumCuentaPorPagar,
            this.col_NumCuentaPorPagarDetalle,
            this.col_ValorLetra,
            this.col_FechaVencimiento,
            this.col_Estado});
            this.gdvDetCtasxPagar.GridControl = this.gridControl1;
            this.gdvDetCtasxPagar.Name = "gdvDetCtasxPagar";
            this.gdvDetCtasxPagar.OptionsView.ShowAutoFilterRow = true;
            this.gdvDetCtasxPagar.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.FieldName = "_IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            // 
            // col_NumCuentaPorPagar
            // 
            this.col_NumCuentaPorPagar.FieldName = "_NumCuentaPorPagar";
            this.col_NumCuentaPorPagar.Name = "col_NumCuentaPorPagar";
            // 
            // col_NumCuentaPorPagarDetalle
            // 
            this.col_NumCuentaPorPagarDetalle.AppearanceCell.Options.UseTextOptions = true;
            this.col_NumCuentaPorPagarDetalle.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_NumCuentaPorPagarDetalle.AppearanceHeader.Options.UseTextOptions = true;
            this.col_NumCuentaPorPagarDetalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_NumCuentaPorPagarDetalle.Caption = "Número";
            this.col_NumCuentaPorPagarDetalle.FieldName = "_NumCuentaPorPagarDetalle";
            this.col_NumCuentaPorPagarDetalle.Name = "col_NumCuentaPorPagarDetalle";
            this.col_NumCuentaPorPagarDetalle.Visible = true;
            this.col_NumCuentaPorPagarDetalle.VisibleIndex = 0;
            // 
            // col_ValorLetra
            // 
            this.col_ValorLetra.AppearanceCell.Options.UseTextOptions = true;
            this.col_ValorLetra.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.col_ValorLetra.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ValorLetra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ValorLetra.Caption = "Valor";
            this.col_ValorLetra.FieldName = "_ValorLetra";
            this.col_ValorLetra.Name = "col_ValorLetra";
            this.col_ValorLetra.Visible = true;
            this.col_ValorLetra.VisibleIndex = 1;
            // 
            // col_FechaVencimiento
            // 
            this.col_FechaVencimiento.AppearanceCell.Options.UseTextOptions = true;
            this.col_FechaVencimiento.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_FechaVencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.col_FechaVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_FechaVencimiento.Caption = "Fecha de vencimiento";
            this.col_FechaVencimiento.FieldName = "_FechaVencimiento";
            this.col_FechaVencimiento.Name = "col_FechaVencimiento";
            this.col_FechaVencimiento.Visible = true;
            this.col_FechaVencimiento.VisibleIndex = 2;
            // 
            // col_Estado
            // 
            this.col_Estado.AppearanceCell.Options.UseTextOptions = true;
            this.col_Estado.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Estado.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Estado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Estado.Caption = "Estado";
            this.col_Estado.FieldName = "_Estado";
            this.col_Estado.Name = "col_Estado";
            // 
            // frmDetalleCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 328);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDetalleCuentasPorPagar";
            this.Text = "Detalle de Cuentas Por Pagar";
            this.Load += new System.EventHandler(this.frmDetalleCuentasPorPagar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDetCtasxPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDetCtasxPagar;
        private System.Windows.Forms.BindingSource clsCuentaPorPagarDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumCuentaPorPagar;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumCuentaPorPagarDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn col_ValorLetra;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaVencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
    }
}