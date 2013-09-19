namespace forms.RecursosHumanos
{
    partial class frmConsultaTipoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoPrestamo));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcTipoPrestamo = new DevExpress.XtraGrid.GridControl();
            this.clsTipoPrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTipoPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoPrestamoBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 28;
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
            // gdcTipoPrestamo
            // 
            this.gdcTipoPrestamo.DataSource = this.clsTipoPrestamoBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gdcTipoPrestamo.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gdcTipoPrestamo.Location = new System.Drawing.Point(0, 36);
            this.gdcTipoPrestamo.MainView = this.gridView1;
            this.gdcTipoPrestamo.Name = "gdcTipoPrestamo";
            this.gdcTipoPrestamo.Size = new System.Drawing.Size(395, 226);
            this.gdcTipoPrestamo.TabIndex = 27;
            this.gdcTipoPrestamo.UseEmbeddedNavigator = true;
            this.gdcTipoPrestamo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsTipoPrestamoBindingSource
            // 
            this.clsTipoPrestamoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTipoPrestamo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPrestamo,
            this.colNombre,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gdcTipoPrestamo;
            this.gridView1.Name = "gridView1";
            // 
            // colIdTipoPrestamo
            // 
            this.colIdTipoPrestamo.FieldName = "IdTipoPrestamo";
            this.colIdTipoPrestamo.Name = "colIdTipoPrestamo";
            this.colIdTipoPrestamo.OptionsColumn.AllowEdit = false;
            this.colIdTipoPrestamo.OptionsColumn.ReadOnly = true;
            this.colIdTipoPrestamo.Visible = true;
            this.colIdTipoPrestamo.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 2;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 3;
            // 
            // frmConsultaTipoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcTipoPrestamo);
            this.Name = "frmConsultaTipoPrestamo";
            this.Text = "Consulta Tipo Prestamo";
            this.Load += new System.EventHandler(this.frmConsultaTipoPrestamo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTipoPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoPrestamoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.GridControl gdcTipoPrestamo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private System.Windows.Forms.BindingSource clsTipoPrestamoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}