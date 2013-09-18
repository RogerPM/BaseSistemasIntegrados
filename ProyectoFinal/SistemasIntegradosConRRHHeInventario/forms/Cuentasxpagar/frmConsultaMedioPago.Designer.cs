namespace forms.Cuentasxpagar
{
    partial class frmConsultaMedioPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMedioPago));
            this.gdcConsultaMedioPago = new DevExpress.XtraGrid.GridControl();
            this.clsMedioPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdMedioPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaMedioPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcConsultaMedioPago
            // 
            this.gdcConsultaMedioPago.DataSource = this.clsMedioPagoBindingSource;
            this.gdcConsultaMedioPago.Location = new System.Drawing.Point(0, 36);
            this.gdcConsultaMedioPago.MainView = this.gridView1;
            this.gdcConsultaMedioPago.Name = "gdcConsultaMedioPago";
            this.gdcConsultaMedioPago.Size = new System.Drawing.Size(395, 226);
            this.gdcConsultaMedioPago.TabIndex = 0;
            this.gdcConsultaMedioPago.UseEmbeddedNavigator = true;
            this.gdcConsultaMedioPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsMedioPagoBindingSource
            // 
            this.clsMedioPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsMedioPago);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdMedioPago,
            this.colDescripcion,
            this.colFechaRegistro,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colIdUsuario});
            this.gridView1.GridControl = this.gdcConsultaMedioPago;
            this.gridView1.Name = "gridView1";
            // 
            // colIdMedioPago
            // 
            this.colIdMedioPago.FieldName = "IdMedioPago";
            this.colIdMedioPago.Name = "colIdMedioPago";
            this.colIdMedioPago.OptionsColumn.AllowEdit = false;
            this.colIdMedioPago.OptionsColumn.ReadOnly = true;
            this.colIdMedioPago.Visible = true;
            this.colIdMedioPago.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.OptionsColumn.AllowEdit = false;
            this.colDescripcion.OptionsColumn.ReadOnly = true;
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.OptionsColumn.AllowEdit = false;
            this.colFechaRegistro.OptionsColumn.ReadOnly = true;
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 2;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "Estado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 3;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 4;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.AllowEdit = false;
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(395, 25);
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
            // frmConsultaMedioPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcConsultaMedioPago);
            this.Name = "frmConsultaMedioPago";
            this.Text = "Consulta Medio Pago";
            this.Load += new System.EventHandler(this.frmConsultaMedioPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaMedioPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaMedioPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedioPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.BindingSource clsMedioPagoBindingSource;
    }
}