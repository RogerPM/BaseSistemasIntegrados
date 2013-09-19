namespace forms.CuentasxCobrar
{
    partial class Frm_ConsultaBanco
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcBanco = new DevExpress.XtraGrid.GridControl();
            this.clsBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsBancoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(477, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.Image = global::forms.Properties.Resources._24_aceptar;
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(43, 22);
            this.tsbOk.Text = "OK";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // gdcBanco
            // 
            this.gdcBanco.DataSource = this.clsBancoBindingSource1;
            this.gdcBanco.Location = new System.Drawing.Point(31, 38);
            this.gdcBanco.MainView = this.gridView1;
            this.gdcBanco.Name = "gdcBanco";
            this.gdcBanco.Size = new System.Drawing.Size(416, 200);
            this.gdcBanco.TabIndex = 2;
            this.gdcBanco.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsBancoBindingSource
            // 
            this.clsBancoBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsBanco);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colidBanco,
            this.colNombre,
            this.colEstado});
            this.gridView1.GridControl = this.gdcBanco;
            this.gridView1.Name = "gridView1";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            // 
            // colidBanco
            // 
            this.colidBanco.FieldName = "idBanco";
            this.colidBanco.Name = "colidBanco";
            this.colidBanco.Visible = true;
            this.colidBanco.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 3;
            // 
            // clsBancoBindingSource1
            // 
            this.clsBancoBindingSource1.DataSource = typeof(clases.CuentasxCobrar.clsBanco);
            // 
            // Frm_ConsultaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 250);
            this.Controls.Add(this.gdcBanco);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Frm_ConsultaBanco";
            this.Text = "Consulta Banco";
            this.Load += new System.EventHandler(this.Frm_ConsultaBanco_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.GridControl gdcBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.BindingSource clsBancoBindingSource;
        private System.Windows.Forms.BindingSource clsBancoBindingSource1;




    }
}