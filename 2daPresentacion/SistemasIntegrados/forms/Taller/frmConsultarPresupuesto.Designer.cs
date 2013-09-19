namespace forms.Taller
{
    partial class frmConsultarPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPresupuesto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsPresupuestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalTiempoTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1059, 25);
            this.toolStrip1.TabIndex = 9;
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsPresupuestoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1059, 244);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupuesto,
            this.colIdPersona,
            this.colCliente,
            this.colIdArticulo,
            this.colNroPlaca,
            this.colMarca,
            this.colModelo,
            this.colColor,
            this.colCombustible,
            this.colChasis,
            this.colFecha,
            this.colTotalTiempoTrabajo,
            this.colSubtotal,
            this.colIva,
            this.colTotalPresupuesto,
            this.colObservacion,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // clsPresupuestoBindingSource
            // 
            this.clsPresupuestoBindingSource.DataSource = typeof(clases.Taller.clsPresupuesto);
            // 
            // colIdPresupuesto
            // 
            this.colIdPresupuesto.FieldName = "IdPresupuesto";
            this.colIdPresupuesto.Name = "colIdPresupuesto";
            this.colIdPresupuesto.Visible = true;
            this.colIdPresupuesto.VisibleIndex = 0;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.Visible = true;
            this.colIdArticulo.VisibleIndex = 2;
            // 
            // colNroPlaca
            // 
            this.colNroPlaca.FieldName = "NroPlaca";
            this.colNroPlaca.Name = "colNroPlaca";
            this.colNroPlaca.Visible = true;
            this.colNroPlaca.VisibleIndex = 3;
            // 
            // colMarca
            // 
            this.colMarca.FieldName = "Marca";
            this.colMarca.Name = "colMarca";
            this.colMarca.Visible = true;
            this.colMarca.VisibleIndex = 4;
            // 
            // colModelo
            // 
            this.colModelo.FieldName = "Modelo";
            this.colModelo.Name = "colModelo";
            this.colModelo.Visible = true;
            this.colModelo.VisibleIndex = 5;
            // 
            // colColor
            // 
            this.colColor.FieldName = "Color";
            this.colColor.Name = "colColor";
            this.colColor.Visible = true;
            this.colColor.VisibleIndex = 6;
            // 
            // colCombustible
            // 
            this.colCombustible.FieldName = "Combustible";
            this.colCombustible.Name = "colCombustible";
            this.colCombustible.Visible = true;
            this.colCombustible.VisibleIndex = 7;
            // 
            // colChasis
            // 
            this.colChasis.FieldName = "Chasis";
            this.colChasis.Name = "colChasis";
            this.colChasis.Visible = true;
            this.colChasis.VisibleIndex = 8;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 9;
            // 
            // colTotalTiempoTrabajo
            // 
            this.colTotalTiempoTrabajo.FieldName = "TotalTiempoTrabajo";
            this.colTotalTiempoTrabajo.Name = "colTotalTiempoTrabajo";
            this.colTotalTiempoTrabajo.Visible = true;
            this.colTotalTiempoTrabajo.VisibleIndex = 10;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 11;
            // 
            // colIva
            // 
            this.colIva.FieldName = "Iva";
            this.colIva.Name = "colIva";
            this.colIva.Visible = true;
            this.colIva.VisibleIndex = 12;
            // 
            // colTotalPresupuesto
            // 
            this.colTotalPresupuesto.FieldName = "TotalPresupuesto";
            this.colTotalPresupuesto.Name = "colTotalPresupuesto";
            this.colTotalPresupuesto.Visible = true;
            this.colTotalPresupuesto.VisibleIndex = 13;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 14;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 15;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // frmConsultarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 273);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarPresupuesto";
            this.Text = "frmConsultarPresupuesto";
            this.Load += new System.EventHandler(this.frmConsultarPresupuesto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPresupuestoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colCombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalTiempoTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIva;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}