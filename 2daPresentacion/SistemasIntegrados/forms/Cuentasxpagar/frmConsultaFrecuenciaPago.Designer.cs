namespace forms.Cuentasxpagar
{
    partial class frmConsultaFrecuenciaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaFrecuenciaPago));
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.clsFrecuenciaPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gcdFrecuenciaPago = new DevExpress.XtraGrid.GridControl();
            this.clsFrecuenciaPagoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdFrecuenciaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdFrecuenciaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaPagoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // clsFrecuenciaPagoBindingSource
            // 
            this.clsFrecuenciaPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsFrecuenciaPago);
            // 
            // gcdFrecuenciaPago
            // 
            this.gcdFrecuenciaPago.DataSource = this.clsFrecuenciaPagoBindingSource1;
            this.gcdFrecuenciaPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcdFrecuenciaPago.Location = new System.Drawing.Point(0, 25);
            this.gcdFrecuenciaPago.MainView = this.gridView1;
            this.gcdFrecuenciaPago.Name = "gcdFrecuenciaPago";
            this.gcdFrecuenciaPago.Size = new System.Drawing.Size(379, 237);
            this.gcdFrecuenciaPago.TabIndex = 26;
            this.gcdFrecuenciaPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcdFrecuenciaPago.Click += new System.EventHandler(this.gcdFrecuenciaPago_Click);
            // 
            // clsFrecuenciaPagoBindingSource1
            // 
            this.clsFrecuenciaPagoBindingSource1.DataSource = typeof(clases.Cuentasxpagar.clsFrecuenciaPago);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdFrecuenciaPago,
            this.colDescripcion,
            this.colFechaActual,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colIdUsuario});
            this.gridView1.GridControl = this.gcdFrecuenciaPago;
            this.gridView1.Name = "gridView1";
            // 
            // colIdFrecuenciaPago
            // 
            this.colIdFrecuenciaPago.FieldName = "IdFrecuenciaPago";
            this.colIdFrecuenciaPago.Name = "colIdFrecuenciaPago";
            this.colIdFrecuenciaPago.OptionsColumn.AllowEdit = false;
            this.colIdFrecuenciaPago.OptionsColumn.ReadOnly = true;
            this.colIdFrecuenciaPago.Visible = true;
            this.colIdFrecuenciaPago.VisibleIndex = 0;
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
            // colFechaActual
            // 
            this.colFechaActual.FieldName = "FechaActual";
            this.colFechaActual.Name = "colFechaActual";
            this.colFechaActual.OptionsColumn.AllowEdit = false;
            this.colFechaActual.OptionsColumn.ReadOnly = true;
            this.colFechaActual.Visible = true;
            this.colFechaActual.VisibleIndex = 2;
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
            // frmConsultaFrecuenciaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 262);
            this.Controls.Add(this.gcdFrecuenciaPago);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "frmConsultaFrecuenciaPago";
            this.Text = "Consulta Frecuencia Pago";
            this.Load += new System.EventHandler(this.frmConsultaFrecuenciaPago_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcdFrecuenciaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaPagoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource clsFrecuenciaPagoBindingSource;
        private DevExpress.XtraGrid.GridControl gcdFrecuenciaPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsFrecuenciaPagoBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFrecuenciaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaActual;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
    }
}