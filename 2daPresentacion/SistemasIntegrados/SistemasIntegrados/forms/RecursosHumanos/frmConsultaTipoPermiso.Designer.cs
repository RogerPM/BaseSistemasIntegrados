namespace forms.RecursosHumanos
{
    partial class frmConsultaTipoPermiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTipoPermiso));
            this.tsConsultaTipoPermiso = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaTipoPermiso = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsTipoPermisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdTipoPermiso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsConsultaTipoPermiso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaTipoPermiso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoPermisoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsConsultaTipoPermiso
            // 
            this.tsConsultaTipoPermiso.BackColor = System.Drawing.SystemColors.Control;
            this.tsConsultaTipoPermiso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.tsConsultaTipoPermiso.Location = new System.Drawing.Point(0, 0);
            this.tsConsultaTipoPermiso.Name = "tsConsultaTipoPermiso";
            this.tsConsultaTipoPermiso.Size = new System.Drawing.Size(430, 25);
            this.tsConsultaTipoPermiso.TabIndex = 28;
            this.tsConsultaTipoPermiso.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsConsultaTipoPermiso_ItemClicked);
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
            // 
            // gdcConsultaTipoPermiso
            // 
            this.gdcConsultaTipoPermiso.DataSource = this.clsTipoPermisoBindingSource;
            this.gdcConsultaTipoPermiso.Location = new System.Drawing.Point(12, 37);
            this.gdcConsultaTipoPermiso.MainView = this.gridView1;
            this.gdcConsultaTipoPermiso.Name = "gdcConsultaTipoPermiso";
            this.gdcConsultaTipoPermiso.Size = new System.Drawing.Size(400, 200);
            this.gdcConsultaTipoPermiso.TabIndex = 29;
            this.gdcConsultaTipoPermiso.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTipoPermiso,
            this.colDescripcion,
            this.colIdEmpresa,
            this.colIdEstado});
            this.gridView1.GridControl = this.gdcConsultaTipoPermiso;
            this.gridView1.Name = "gridView1";
            // 
            // clsTipoPermisoBindingSource
            // 
            this.clsTipoPermisoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTipoPermiso);
            // 
            // colIdTipoPermiso
            // 
            this.colIdTipoPermiso.FieldName = "IdTipoPermiso";
            this.colIdTipoPermiso.Name = "colIdTipoPermiso";
            this.colIdTipoPermiso.Visible = true;
            this.colIdTipoPermiso.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 2;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 3;
            // 
            // frmConsultaTipoPermiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 253);
            this.Controls.Add(this.gdcConsultaTipoPermiso);
            this.Controls.Add(this.tsConsultaTipoPermiso);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaTipoPermiso";
            this.Text = "frmConsultaTipoPermiso";
            this.Load += new System.EventHandler(this.frmConsultaTipoPermiso_Load);
            this.tsConsultaTipoPermiso.ResumeLayout(false);
            this.tsConsultaTipoPermiso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaTipoPermiso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoPermisoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsConsultaTipoPermiso;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gdcConsultaTipoPermiso;
        private System.Windows.Forms.BindingSource clsTipoPermisoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPermiso;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}