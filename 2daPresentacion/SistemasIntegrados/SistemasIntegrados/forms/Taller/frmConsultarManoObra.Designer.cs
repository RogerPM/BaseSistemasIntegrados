namespace forms.Taller
{
    partial class frmConsultarManoObra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarManoObra));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.grdManoObra = new DevExpress.XtraGrid.GridControl();
            this.clsManoObraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdManoObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsManoObraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(640, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelec
            // 
            this.btnSelec.Image = ((System.Drawing.Image)(resources.GetObject("btnSelec.Image")));
            this.btnSelec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(87, 22);
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(214, 22);
            this.toolStripLabel1.Text = "                                                                     ";
            // 
            // grdManoObra
            // 
            this.grdManoObra.DataSource = this.clsManoObraBindingSource;
            this.grdManoObra.Location = new System.Drawing.Point(0, 28);
            this.grdManoObra.MainView = this.gridView1;
            this.grdManoObra.Name = "grdManoObra";
            this.grdManoObra.Size = new System.Drawing.Size(640, 181);
            this.grdManoObra.TabIndex = 11;
            this.grdManoObra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsManoObraBindingSource
            // 
            this.clsManoObraBindingSource.DataSource = typeof(clases.Taller.clsManoObra);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdManoObra,
            this.colIdTipoTrabajo,
            this.colDescripcion,
            this.colNroHoras,
            this.colPrecioHora,
            this.colTotal,
            this.colObservacion,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.grdManoObra;
            this.gridView1.Name = "gridView1";
            // 
            // colIdManoObra
            // 
            this.colIdManoObra.FieldName = "IdManoObra";
            this.colIdManoObra.Name = "colIdManoObra";
            this.colIdManoObra.Visible = true;
            this.colIdManoObra.VisibleIndex = 0;
            this.colIdManoObra.Width = 70;
            // 
            // colIdTipoTrabajo
            // 
            this.colIdTipoTrabajo.FieldName = "IdTipoTrabajo";
            this.colIdTipoTrabajo.Name = "colIdTipoTrabajo";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            this.colDescripcion.Width = 137;
            // 
            // colNroHoras
            // 
            this.colNroHoras.FieldName = "NroHoras";
            this.colNroHoras.Name = "colNroHoras";
            this.colNroHoras.Visible = true;
            this.colNroHoras.VisibleIndex = 2;
            this.colNroHoras.Width = 80;
            // 
            // colPrecioHora
            // 
            this.colPrecioHora.FieldName = "PrecioHora";
            this.colPrecioHora.Name = "colPrecioHora";
            this.colPrecioHora.Visible = true;
            this.colPrecioHora.VisibleIndex = 3;
            this.colPrecioHora.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            this.colTotal.Width = 80;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 5;
            this.colObservacion.Width = 80;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 6;
            this.colIdEstado.Width = 95;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // frmConsultarManoObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 210);
            this.Controls.Add(this.grdManoObra);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarManoObra";
            this.Text = "frmConsultarManoObra";
            this.Load += new System.EventHandler(this.frmConsultarManoObra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsManoObraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl grdManoObra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsManoObraBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNroHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioHora;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}