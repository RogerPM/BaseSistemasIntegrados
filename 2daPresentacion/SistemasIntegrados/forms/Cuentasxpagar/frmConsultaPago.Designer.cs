namespace forms.Cuentasxpagar
{
    partial class frmConsultaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPago));
            this.gcdConsultaPago = new DevExpress.XtraGrid.GridControl();
            this.clsPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcdConsultaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcdConsultaPago
            // 
            this.gcdConsultaPago.DataSource = this.clsPagoBindingSource;
            this.gcdConsultaPago.Location = new System.Drawing.Point(12, 29);
            this.gcdConsultaPago.MainView = this.gridView1;
            this.gcdConsultaPago.Name = "gcdConsultaPago";
            this.gcdConsultaPago.Size = new System.Drawing.Size(566, 221);
            this.gcdConsultaPago.TabIndex = 0;
            this.gcdConsultaPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcdConsultaPago.Click += new System.EventHandler(this.gcdConsultaPago_Click);
            // 
            // clsPagoBindingSource
            // 
            this.clsPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsPago);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumPago,
            this.colFechaIngreso,
            this.colNumOrdenPago,
            this.colTipoPago,
            this.colTotalPagar,
            this.colIdUsuario,
            this.colIdEmpresa,
            this.colIdEstado,
            this.colNumComprobante});
            this.gridView1.GridControl = this.gcdConsultaPago;
            this.gridView1.Name = "gridView1";
            // 
            // colNumPago
            // 
            this.colNumPago.FieldName = "NumPago";
            this.colNumPago.Name = "colNumPago";
            this.colNumPago.Visible = true;
            this.colNumPago.VisibleIndex = 0;
            // 
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            this.colFechaIngreso.Visible = true;
            this.colFechaIngreso.VisibleIndex = 1;
            // 
            // colNumOrdenPago
            // 
            this.colNumOrdenPago.FieldName = "NumOrdenPago";
            this.colNumOrdenPago.Name = "colNumOrdenPago";
            this.colNumOrdenPago.Visible = true;
            this.colNumOrdenPago.VisibleIndex = 2;
            // 
            // colTipoPago
            // 
            this.colTipoPago.FieldName = "TipoPago";
            this.colTipoPago.Name = "colTipoPago";
            this.colTipoPago.Visible = true;
            this.colTipoPago.VisibleIndex = 3;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 4;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 5;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 6;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 7;
            // 
            // colNumComprobante
            // 
            this.colNumComprobante.FieldName = "NumComprobante";
            this.colNumComprobante.Name = "colNumComprobante";
            this.colNumComprobante.Visible = true;
            this.colNumComprobante.VisibleIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(590, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbOk.ForeColor = System.Drawing.Color.Black;
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(40, 22);
            this.tsbOk.Text = "ok";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // frmConsultaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gcdConsultaPago);
            this.Name = "frmConsultaPago";
            this.Text = "frmConsultaPago";
            this.Load += new System.EventHandler(this.frmConsultaPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcdConsultaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcdConsultaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPagoBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colNumComprobante;
    }
}