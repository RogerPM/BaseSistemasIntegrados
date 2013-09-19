namespace forms.RecursosHumanos
{
    partial class frmConsultaDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDepartamento));
            this.tsConsultaDepartamento = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaDepartamento = new DevExpress.XtraGrid.GridControl();
            this.clsDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsConsultaDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsConsultaDepartamento
            // 
            this.tsConsultaDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.tsConsultaDepartamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.tsConsultaDepartamento.Location = new System.Drawing.Point(0, 0);
            this.tsConsultaDepartamento.Name = "tsConsultaDepartamento";
            this.tsConsultaDepartamento.Size = new System.Drawing.Size(448, 25);
            this.tsConsultaDepartamento.TabIndex = 27;
            this.tsConsultaDepartamento.Text = "toolStrip1";
            // 
            // tsbConsultado
            // 
            this.tsbConsultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultado.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultado.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultado.Image")));
            this.tsbConsultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultado.Name = "tsbConsultado";
            this.tsbConsultado.Size = new System.Drawing.Size(88, 22);
            this.tsbConsultado.Text = "Consultado";
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click);
            // 
            // gdcConsultaDepartamento
            // 
            this.gdcConsultaDepartamento.DataSource = this.clsDepartamentoBindingSource;
            this.gdcConsultaDepartamento.Location = new System.Drawing.Point(13, 29);
            this.gdcConsultaDepartamento.MainView = this.gridView1;
            this.gdcConsultaDepartamento.Name = "gdcConsultaDepartamento";
            this.gdcConsultaDepartamento.Size = new System.Drawing.Size(422, 200);
            this.gdcConsultaDepartamento.TabIndex = 28;
            this.gdcConsultaDepartamento.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsDepartamentoBindingSource
            // 
            this.clsDepartamentoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDepartamento,
            this.colDescripcion,
            this.colIdEstado});
            this.gridView1.GridControl = this.gdcConsultaDepartamento;
            this.gridView1.Name = "gridView1";
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.OptionsColumn.AllowEdit = false;
            this.colIdDepartamento.OptionsColumn.ReadOnly = true;
            this.colIdDepartamento.Visible = true;
            this.colIdDepartamento.VisibleIndex = 0;
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
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 2;
            // 
            // frmConsultaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 245);
            this.Controls.Add(this.gdcConsultaDepartamento);
            this.Controls.Add(this.tsConsultaDepartamento);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaDepartamento";
            this.Text = "Consulta Departamento";
            this.Load += new System.EventHandler(this.frmMConsultaDepartamento_Load);
            this.tsConsultaDepartamento.ResumeLayout(false);
            this.tsConsultaDepartamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsConsultaDepartamento;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gdcConsultaDepartamento;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}