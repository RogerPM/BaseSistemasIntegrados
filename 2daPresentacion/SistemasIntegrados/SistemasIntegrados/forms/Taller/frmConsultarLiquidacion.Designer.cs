namespace forms.Taller
{
    partial class frmConsultarLiquidacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarLiquidacion));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsLiquidacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdLiquidacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalTrabajos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRepuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdFormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCuotaMensual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCuotaMensual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicialPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFinalPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLiquidacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(932, 25);
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
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsLiquidacionBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(932, 261);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdLiquidacion,
            this.colIdOrdenTrabajo,
            this.colCliente,
            this.colFecha,
            this.colNroPlaca,
            this.colMarca,
            this.colModelo,
            this.colColor,
            this.colFechaIngreso,
            this.colFechaEntrega,
            this.colTotalTrabajos,
            this.colTotalRepuestos,
            this.colTotalOtros,
            this.colTotalPagar,
            this.colIdFormaPago,
            this.colNumeroCuotaMensual,
            this.colCuotaMensual,
            this.colFechaInicialPago,
            this.colFechaFinalPago,
            this.colObservacion,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // clsLiquidacionBindingSource
            // 
            this.clsLiquidacionBindingSource.DataSource = typeof(clases.Taller.clsLiquidacion);
            // 
            // colIdLiquidacion
            // 
            this.colIdLiquidacion.FieldName = "IdLiquidacion";
            this.colIdLiquidacion.Name = "colIdLiquidacion";
            this.colIdLiquidacion.Visible = true;
            this.colIdLiquidacion.VisibleIndex = 0;
            // 
            // colIdOrdenTrabajo
            // 
            this.colIdOrdenTrabajo.FieldName = "IdOrdenTrabajo";
            this.colIdOrdenTrabajo.Name = "colIdOrdenTrabajo";
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
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
            // colFechaIngreso
            // 
            this.colFechaIngreso.FieldName = "FechaIngreso";
            this.colFechaIngreso.Name = "colFechaIngreso";
            // 
            // colFechaEntrega
            // 
            this.colFechaEntrega.FieldName = "FechaEntrega";
            this.colFechaEntrega.Name = "colFechaEntrega";
            // 
            // colTotalTrabajos
            // 
            this.colTotalTrabajos.FieldName = "TotalTrabajos";
            this.colTotalTrabajos.Name = "colTotalTrabajos";
            this.colTotalTrabajos.Visible = true;
            this.colTotalTrabajos.VisibleIndex = 7;
            // 
            // colTotalRepuestos
            // 
            this.colTotalRepuestos.FieldName = "TotalRepuestos";
            this.colTotalRepuestos.Name = "colTotalRepuestos";
            this.colTotalRepuestos.Visible = true;
            this.colTotalRepuestos.VisibleIndex = 8;
            // 
            // colTotalOtros
            // 
            this.colTotalOtros.FieldName = "TotalOtros";
            this.colTotalOtros.Name = "colTotalOtros";
            this.colTotalOtros.Visible = true;
            this.colTotalOtros.VisibleIndex = 9;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 10;
            // 
            // colIdFormaPago
            // 
            this.colIdFormaPago.FieldName = "IdFormaPago";
            this.colIdFormaPago.Name = "colIdFormaPago";
            // 
            // colNumeroCuotaMensual
            // 
            this.colNumeroCuotaMensual.FieldName = "NumeroCuotaMensual";
            this.colNumeroCuotaMensual.Name = "colNumeroCuotaMensual";
            this.colNumeroCuotaMensual.Visible = true;
            this.colNumeroCuotaMensual.VisibleIndex = 11;
            // 
            // colCuotaMensual
            // 
            this.colCuotaMensual.FieldName = "CuotaMensual";
            this.colCuotaMensual.Name = "colCuotaMensual";
            this.colCuotaMensual.Visible = true;
            this.colCuotaMensual.VisibleIndex = 12;
            // 
            // colFechaInicialPago
            // 
            this.colFechaInicialPago.FieldName = "FechaInicialPago";
            this.colFechaInicialPago.Name = "colFechaInicialPago";
            this.colFechaInicialPago.Visible = true;
            this.colFechaInicialPago.VisibleIndex = 13;
            // 
            // colFechaFinalPago
            // 
            this.colFechaFinalPago.FieldName = "FechaFinalPago";
            this.colFechaFinalPago.Name = "colFechaFinalPago";
            this.colFechaFinalPago.Visible = true;
            this.colFechaFinalPago.VisibleIndex = 14;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
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
            // frmConsultarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 287);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarLiquidacion";
            this.Text = "frmConsultarLiquidacion";
            this.Load += new System.EventHandler(this.frmConsultarLiquidacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLiquidacionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsLiquidacionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdLiquidacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalTrabajos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRepuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdFormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCuotaMensual;
        private DevExpress.XtraGrid.Columns.GridColumn colCuotaMensual;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicialPago;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFinalPago;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}