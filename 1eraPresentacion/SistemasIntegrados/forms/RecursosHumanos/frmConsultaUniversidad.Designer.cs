namespace forms.RecursosHumanos
{
    partial class frmConsultaUniversidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaUniversidad));
            this.tsConsultaUniversidad = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.clsUniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdcUniversidad = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUniversidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsConsultaUniversidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUniversidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsConsultaUniversidad
            // 
            this.tsConsultaUniversidad.BackColor = System.Drawing.SystemColors.Control;
            this.tsConsultaUniversidad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.tsConsultaUniversidad.Location = new System.Drawing.Point(0, 0);
            this.tsConsultaUniversidad.Name = "tsConsultaUniversidad";
            this.tsConsultaUniversidad.Size = new System.Drawing.Size(425, 25);
            this.tsConsultaUniversidad.TabIndex = 26;
            this.tsConsultaUniversidad.Text = "toolStrip1";
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
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click_1);
            // 
            // clsUniversidadBindingSource
            // 
            this.clsUniversidadBindingSource.DataSource = typeof(clases.RecursosHumanos.clsUniversidad);
            // 
            // gdcUniversidad
            // 
            this.gdcUniversidad.DataSource = this.clsUniversidadBindingSource;
            this.gdcUniversidad.Location = new System.Drawing.Point(13, 29);
            this.gdcUniversidad.MainView = this.gridView1;
            this.gdcUniversidad.Name = "gdcUniversidad";
            this.gdcUniversidad.Size = new System.Drawing.Size(400, 208);
            this.gdcUniversidad.TabIndex = 27;
            this.gdcUniversidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gdcUniversidad.Click += new System.EventHandler(this.gdcUniversidad_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUniversidad,
            this.colIdEmpresa,
            this.colNombre});
            this.gridView1.GridControl = this.gdcUniversidad;
            this.gridView1.Name = "gridView1";
            // 
            // colIdUniversidad
            // 
            this.colIdUniversidad.FieldName = "IdUniversidad";
            this.colIdUniversidad.Name = "colIdUniversidad";
            this.colIdUniversidad.OptionsColumn.AllowEdit = false;
            this.colIdUniversidad.OptionsColumn.ReadOnly = true;
            this.colIdUniversidad.Visible = true;
            this.colIdUniversidad.VisibleIndex = 0;
            this.colIdUniversidad.Width = 82;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 1;
            this.colIdEmpresa.Width = 148;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            this.colNombre.Width = 152;
            // 
            // frmConsultaUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 246);
            this.Controls.Add(this.gdcUniversidad);
            this.Controls.Add(this.tsConsultaUniversidad);
            this.MaximizeBox = false;
            this.Name = "frmConsultaUniversidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Universidad";
            this.Load += new System.EventHandler(this.frmMConsultaUniversidad_Load);
            this.tsConsultaUniversidad.ResumeLayout(false);
            this.tsConsultaUniversidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUniversidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsConsultaUniversidad;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private System.Windows.Forms.BindingSource clsUniversidadBindingSource;
        private DevExpress.XtraGrid.GridControl gdcUniversidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUniversidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
    }
}