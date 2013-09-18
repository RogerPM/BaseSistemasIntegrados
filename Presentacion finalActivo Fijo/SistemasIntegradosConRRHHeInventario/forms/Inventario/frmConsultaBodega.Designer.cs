namespace forms.Inventario
{
    partial class frmConsultaBodega
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
            this.gdcConsultaBodega = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Capacidadm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Responsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Percha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaBodega)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcConsultaBodega
            // 
            this.gdcConsultaBodega.Location = new System.Drawing.Point(0, -1);
            this.gdcConsultaBodega.MainView = this.gridView1;
            this.gdcConsultaBodega.Name = "gdcConsultaBodega";
            this.gdcConsultaBodega.Size = new System.Drawing.Size(611, 243);
            this.gdcConsultaBodega.TabIndex = 60;
            this.gdcConsultaBodega.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gdcConsultaBodega.Click += new System.EventHandler(this.gdcConsultaBodega_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Empresa,
            this.Codigo,
            this.Descripcion,
            this.Capacidadm2,
            this.Responsable,
            this.Percha,
            this.Direccion,
            this.Telefono,
            this.Estado});
            this.gridView1.GridControl = this.gdcConsultaBodega;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
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
            // Capacidadm2
            // 
            this.Capacidadm2.Caption = "Capacidadm2";
            this.Capacidadm2.FieldName = "capacidadm2";
            this.Capacidadm2.Name = "Capacidadm2";
            this.Capacidadm2.Visible = true;
            this.Capacidadm2.VisibleIndex = 5;
            // 
            // Responsable
            // 
            this.Responsable.Caption = "Responsable";
            this.Responsable.FieldName = "responsable";
            this.Responsable.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.Responsable.Name = "Responsable";
            this.Responsable.Visible = true;
            this.Responsable.VisibleIndex = 6;
            // 
            // Percha
            // 
            this.Percha.Caption = "Percha";
            this.Percha.FieldName = "percha";
            this.Percha.Name = "Percha";
            this.Percha.Visible = true;
            this.Percha.VisibleIndex = 7;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Direccion";
            this.Direccion.FieldName = "direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 3;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Telefono";
            this.Telefono.FieldName = "telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 8;
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 4;
            // 
            // frmConsultaBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 300);
            this.Controls.Add(this.gdcConsultaBodega);
            this.Name = "frmConsultaBodega";
            this.Text = "frmConsultaBodega";
            this.Load += new System.EventHandler(this.frmConsultaBodega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaBodega)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaBodega;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Capacidadm2;
        private DevExpress.XtraGrid.Columns.GridColumn Responsable;
        private DevExpress.XtraGrid.Columns.GridColumn Percha;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
    }
}