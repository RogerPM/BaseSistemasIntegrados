namespace forms.RecursosHumanos
{
    partial class frmConsultaCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCargo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaCargo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSueldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCargoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(399, 25);
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
            // gdcConsultaCargo
            // 
            this.gdcConsultaCargo.DataSource = this.clsCargoBindingSource;
            this.gdcConsultaCargo.Location = new System.Drawing.Point(0, 36);
            this.gdcConsultaCargo.MainView = this.gridView1;
            this.gdcConsultaCargo.Name = "gdcConsultaCargo";
            this.gdcConsultaCargo.Size = new System.Drawing.Size(395, 226);
            this.gdcConsultaCargo.TabIndex = 27;
            this.gdcConsultaCargo.UseEmbeddedNavigator = true;
            this.gdcConsultaCargo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCargo,
            this.colDescripcion,
            this.colSueldo,
            this.colIdEstado});
            this.gridView1.GridControl = this.gdcConsultaCargo;
            this.gridView1.Name = "gridView1";
            // 
            // colIdCargo
            // 
            this.colIdCargo.FieldName = "IdCargo";
            this.colIdCargo.Name = "colIdCargo";
            this.colIdCargo.OptionsColumn.AllowEdit = false;
            this.colIdCargo.OptionsColumn.ReadOnly = true;
            this.colIdCargo.Visible = true;
            this.colIdCargo.VisibleIndex = 0;
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
            this.colIdEstado.VisibleIndex = 3;
            // 
            // colSueldo
            // 
            this.colSueldo.FieldName = "Sueldo";
            this.colSueldo.Name = "colSueldo";
            this.colSueldo.OptionsColumn.AllowEdit = false;
            this.colSueldo.OptionsColumn.ReadOnly = true;
            this.colSueldo.Visible = true;
            this.colSueldo.VisibleIndex = 2;
            // 
            // clsCargoBindingSource
            // 
            this.clsCargoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsCargo);
            // 
            // frmConsultaCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcConsultaCargo);
            this.Name = "frmConsultaCargo";
            this.Text = "Consulta Cargo";
            this.Load += new System.EventHandler(this.frmConsultaCargo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCargoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private DevExpress.XtraGrid.GridControl gdcConsultaCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colSueldo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private System.Windows.Forms.BindingSource clsCargoBindingSource;
    }
}