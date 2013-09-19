namespace forms.RecursosHumanos
{
    partial class frmConsultaTitulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTitulo));
            this.tsConsultaTitulo = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaTitulo = new DevExpress.XtraGrid.GridControl();
            this.clsTituloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTitulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFinal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUniversidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsConsultaTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsConsultaTitulo
            // 
            this.tsConsultaTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.tsConsultaTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.tsConsultaTitulo.Location = new System.Drawing.Point(0, 0);
            this.tsConsultaTitulo.Name = "tsConsultaTitulo";
            this.tsConsultaTitulo.Size = new System.Drawing.Size(621, 25);
            this.tsConsultaTitulo.TabIndex = 27;
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
            // gdcConsultaTitulo
            // 
            this.gdcConsultaTitulo.DataSource = this.clsTituloBindingSource;
            this.gdcConsultaTitulo.Location = new System.Drawing.Point(13, 44);
            this.gdcConsultaTitulo.MainView = this.gridView1;
            this.gdcConsultaTitulo.Name = "gdcConsultaTitulo";
            this.gdcConsultaTitulo.Size = new System.Drawing.Size(594, 200);
            this.gdcConsultaTitulo.TabIndex = 28;
            this.gdcConsultaTitulo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsTituloBindingSource
            // 
            this.clsTituloBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTitulo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTitulo,
            this.colNombre,
            this.colFechaInicio,
            this.colFechaFinal,
            this.colIdEstado,
            this.colIdUniversidad,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gdcConsultaTitulo;
            this.gridView1.Name = "gridView1";
            // 
            // colIdTitulo
            // 
            this.colIdTitulo.FieldName = "IdTitulo";
            this.colIdTitulo.Name = "colIdTitulo";
            this.colIdTitulo.OptionsColumn.AllowEdit = false;
            this.colIdTitulo.OptionsColumn.ReadOnly = true;
            this.colIdTitulo.Visible = true;
            this.colIdTitulo.VisibleIndex = 0;
            this.colIdTitulo.Width = 51;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.OptionsColumn.AllowEdit = false;
            this.colNombre.OptionsColumn.ReadOnly = true;
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 123;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            this.colFechaInicio.OptionsColumn.ReadOnly = true;
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 2;
            this.colFechaInicio.Width = 78;
            // 
            // colFechaFinal
            // 
            this.colFechaFinal.FieldName = "FechaFinal";
            this.colFechaFinal.Name = "colFechaFinal";
            this.colFechaFinal.OptionsColumn.AllowEdit = false;
            this.colFechaFinal.OptionsColumn.ReadOnly = true;
            this.colFechaFinal.Visible = true;
            this.colFechaFinal.VisibleIndex = 3;
            this.colFechaFinal.Width = 78;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 4;
            this.colIdEstado.Width = 82;
            // 
            // colIdUniversidad
            // 
            this.colIdUniversidad.FieldName = "IdUniversidad";
            this.colIdUniversidad.Name = "colIdUniversidad";
            this.colIdUniversidad.OptionsColumn.AllowEdit = false;
            this.colIdUniversidad.OptionsColumn.ReadOnly = true;
            this.colIdUniversidad.Visible = true;
            this.colIdUniversidad.VisibleIndex = 5;
            this.colIdUniversidad.Width = 101;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 6;
            this.colIdEmpresa.Width = 63;
            // 
            // frmMConsultaTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 262);
            this.Controls.Add(this.gdcConsultaTitulo);
            this.Controls.Add(this.tsConsultaTitulo);
            this.MaximizeBox = false;
            this.Name = "frmMConsultaTitulo";
            this.Text = "Consulta Titulo";
            this.Load += new System.EventHandler(this.frmMConsultaTitulo_Load);
            this.tsConsultaTitulo.ResumeLayout(false);
            this.tsConsultaTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsConsultaTitulo;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gdcConsultaTitulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsTituloBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTitulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFinal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUniversidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}