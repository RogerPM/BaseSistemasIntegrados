namespace forms.Inventario
{
    partial class frmConsultaGrupo
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
            this.gdcConsultaGrupo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcConsultaGrupo
            // 
            this.gdcConsultaGrupo.Location = new System.Drawing.Point(3, 2);
            this.gdcConsultaGrupo.MainView = this.gridView1;
            this.gdcConsultaGrupo.Name = "gdcConsultaGrupo";
            this.gdcConsultaGrupo.Size = new System.Drawing.Size(535, 254);
            this.gdcConsultaGrupo.TabIndex = 55;
            this.gdcConsultaGrupo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Empresa,
            this.Codigo,
            this.Descripcion,
            this.TipoArticulo,
            this.Estado});
            this.gridView1.GridControl = this.gdcConsultaGrupo;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // Empresa
            // 
            this.Empresa.Caption = "Empresa";
            this.Empresa.FieldName = "empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Visible = true;
            this.Empresa.VisibleIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = true;
            this.Codigo.VisibleIndex = 1;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            // 
            // TipoArticulo
            // 
            this.TipoArticulo.Caption = "TipoArticulo";
            this.TipoArticulo.FieldName = "tipoarticulo";
            this.TipoArticulo.Name = "TipoArticulo";
            this.TipoArticulo.Visible = true;
            this.TipoArticulo.VisibleIndex = 4;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 3;
            // 
            // frmConsultaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 309);
            this.Controls.Add(this.gdcConsultaGrupo);
            this.Name = "frmConsultaGrupo";
            this.Text = "frmConsultaGrupo";
            this.Load += new System.EventHandler(this.frmConsultaGrupo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn TipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
    }
}