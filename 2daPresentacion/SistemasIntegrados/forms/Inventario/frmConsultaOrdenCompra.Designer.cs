namespace forms.Inventario
{
    partial class frmConsultaOrdenCompra
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
            this.gdcConsultaOrdenCompra = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Numero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Linea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaOrdenCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcConsultaOrdenCompra
            // 
            this.gdcConsultaOrdenCompra.Location = new System.Drawing.Point(6, 8);
            this.gdcConsultaOrdenCompra.MainView = this.gridView1;
            this.gdcConsultaOrdenCompra.Name = "gdcConsultaOrdenCompra";
            this.gdcConsultaOrdenCompra.Size = new System.Drawing.Size(518, 257);
            this.gdcConsultaOrdenCompra.TabIndex = 0;
            this.gdcConsultaOrdenCompra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Numero,
            this.Empresa,
            this.Linea,
            this.Articulo,
            this.Cantidad,
            this.Precio});
            this.gridView1.GridControl = this.gdcConsultaOrdenCompra;
            this.gridView1.Name = "gridView1";
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // Numero
            // 
            this.Numero.Caption = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.Visible = true;
            this.Numero.VisibleIndex = 0;
            // 
            // Empresa
            // 
            this.Empresa.Caption = "Empresa";
            this.Empresa.Name = "Empresa";
            this.Empresa.Visible = true;
            this.Empresa.VisibleIndex = 1;
            // 
            // Linea
            // 
            this.Linea.Caption = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.Visible = true;
            this.Linea.VisibleIndex = 2;
            // 
            // Articulo
            // 
            this.Articulo.Caption = "Articulo";
            this.Articulo.Name = "Articulo";
            this.Articulo.Visible = true;
            this.Articulo.VisibleIndex = 3;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 4;
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 5;
            // 
            // frmConsultaOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 269);
            this.Controls.Add(this.gdcConsultaOrdenCompra);
            this.Name = "frmConsultaOrdenCompra";
            this.Text = "frmConsultaOrdenCompra";
            this.Load += new System.EventHandler(this.frmConsultaOrdenCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaOrdenCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsultaOrdenCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Numero;
        private DevExpress.XtraGrid.Columns.GridColumn Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn Linea;
        private DevExpress.XtraGrid.Columns.GridColumn Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
    }
}