namespace forms.RecursosHumanos
{
    partial class frmConsultaTipoContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoContrato));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcTipoContrato = new DevExpress.XtraGrid.GridControl();
            this.clsTipoContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTipoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTipoContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoContratoBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(417, 25);
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
            // gdcTipoContrato
            // 
            this.gdcTipoContrato.DataSource = this.clsTipoContratoBindingSource;
            this.gdcTipoContrato.Location = new System.Drawing.Point(10, 29);
            this.gdcTipoContrato.MainView = this.gridView1;
            this.gdcTipoContrato.Name = "gdcTipoContrato";
            this.gdcTipoContrato.Size = new System.Drawing.Size(395, 226);
            this.gdcTipoContrato.TabIndex = 27;
            this.gdcTipoContrato.UseEmbeddedNavigator = true;
            this.gdcTipoContrato.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsTipoContratoBindingSource
            // 
            this.clsTipoContratoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTipoContrato);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoContrato,
            this.colDescripcion,
            this.colPeriodo,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gdcTipoContrato;
            this.gridView1.Name = "gridView1";
            // 
            // colIdTipoContrato
            // 
            this.colIdTipoContrato.FieldName = "IdTipoContrato";
            this.colIdTipoContrato.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colIdTipoContrato.Name = "colIdTipoContrato";
            this.colIdTipoContrato.OptionsColumn.AllowEdit = false;
            this.colIdTipoContrato.OptionsColumn.ReadOnly = true;
            this.colIdTipoContrato.Visible = true;
            this.colIdTipoContrato.VisibleIndex = 0;
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
            // colPeriodo
            // 
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.OptionsColumn.AllowEdit = false;
            this.colPeriodo.OptionsColumn.ReadOnly = true;
            this.colPeriodo.Visible = true;
            this.colPeriodo.VisibleIndex = 4;
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
            // frmConsultaTipoContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcTipoContrato);
            this.Name = "frmConsultaTipoContrato";
            this.Text = "Consulta Tipo Contrato";
            this.Load += new System.EventHandler(this.frmConsultaTipoContrato_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTipoContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.GridControl gdcTipoContrato;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private System.Windows.Forms.BindingSource clsTipoContratoBindingSource;
    }
}