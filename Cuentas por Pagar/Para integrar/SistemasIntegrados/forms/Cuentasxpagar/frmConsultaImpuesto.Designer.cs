namespace forms.Cuentasxpagar
{
    partial class frmConsultaImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaImpuesto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaImpuesto = new DevExpress.XtraGrid.GridControl();
            this.clsImpuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaImpuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(493, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(23, 22);
            this.tsbOk.Text = "toolStripButton1";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // gdcConsultaImpuesto
            // 
            this.gdcConsultaImpuesto.DataSource = this.clsImpuestosBindingSource;
            this.gdcConsultaImpuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcConsultaImpuesto.Location = new System.Drawing.Point(0, 25);
            this.gdcConsultaImpuesto.MainView = this.gridView1;
            this.gdcConsultaImpuesto.Name = "gdcConsultaImpuesto";
            this.gdcConsultaImpuesto.Size = new System.Drawing.Size(493, 275);
            this.gdcConsultaImpuesto.TabIndex = 1;
            this.gdcConsultaImpuesto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsImpuestosBindingSource
            // 
            this.clsImpuestosBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsImpuestos);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFechaRegistro,
            this.colIdImpuesto,
            this.colDescripcion,
            this.colPorcentaje,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colIdUsuario});
            this.gridView1.GridControl = this.gdcConsultaImpuesto;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            // 
            // colIdImpuesto
            // 
            this.colIdImpuesto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdImpuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdImpuesto.Caption = "Código";
            this.colIdImpuesto.FieldName = "IdImpuesto";
            this.colIdImpuesto.Name = "colIdImpuesto";
            this.colIdImpuesto.Visible = true;
            this.colIdImpuesto.VisibleIndex = 0;
            this.colIdImpuesto.Width = 133;
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 342;
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.FieldName = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // frmConsultaImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 300);
            this.Controls.Add(this.gdcConsultaImpuesto);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaImpuesto";
            this.Text = "frmConsultaImpuesto";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaImpuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gdcConsultaImpuesto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.BindingSource clsImpuestosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
    }
}