namespace forms.Cuentasxpagar
{
    partial class frmConsultaImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaImpuesto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaImpuesto = new DevExpress.XtraGrid.GridControl();
            this.clsImpuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(442, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click_1);
            // 
            // gdcConsultaImpuesto
            // 
            this.gdcConsultaImpuesto.DataSource = this.clsImpuestoBindingSource;
            this.gdcConsultaImpuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcConsultaImpuesto.Location = new System.Drawing.Point(0, 25);
            this.gdcConsultaImpuesto.MainView = this.gridView1;
            this.gdcConsultaImpuesto.Name = "gdcConsultaImpuesto";
            this.gdcConsultaImpuesto.Size = new System.Drawing.Size(442, 237);
            this.gdcConsultaImpuesto.TabIndex = 27;
            this.gdcConsultaImpuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsImpuestoBindingSource
            // 
            this.clsImpuestoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsImpuesto);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdImpuesto,
            this.colDescripcion,
            this.colPorcentaje,
            this.colFechaRegistro,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colIdUsuario});
            this.gridView1.GridControl = this.gdcConsultaImpuesto;
            this.gridView1.Name = "gridView1";
            // 
            // colIdImpuesto
            // 
            this.colIdImpuesto.FieldName = "IdImpuesto";
            this.colIdImpuesto.Name = "colIdImpuesto";
            this.colIdImpuesto.OptionsColumn.AllowEdit = false;
            this.colIdImpuesto.OptionsColumn.ReadOnly = true;
            this.colIdImpuesto.Visible = true;
            this.colIdImpuesto.VisibleIndex = 0;
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
            // colPorcentaje
            // 
            this.colPorcentaje.FieldName = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.OptionsColumn.AllowEdit = false;
            this.colPorcentaje.OptionsColumn.ReadOnly = true;
            this.colPorcentaje.Visible = true;
            this.colPorcentaje.VisibleIndex = 2;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.OptionsColumn.AllowEdit = false;
            this.colFechaRegistro.OptionsColumn.ReadOnly = true;
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 3;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "Estado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 4;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 5;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.OptionsColumn.AllowEdit = false;
            this.colIdUsuario.OptionsColumn.ReadOnly = true;
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 6;
            // 
            // frmConsultaImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 262);
            this.Controls.Add(this.gdcConsultaImpuesto);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "frmConsultaImpuesto";
            this.Text = "frmConsultaImpuesto";
            this.Load += new System.EventHandler(this.frmConsultaImpuesto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.GridControl gdcConsultaImpuesto;
        private System.Windows.Forms.BindingSource clsImpuestoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
    }
}