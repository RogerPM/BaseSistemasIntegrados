namespace forms.Taller
{
    partial class frmConsultarOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarOrdenTrabajo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenTrabajoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOrdenTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKilometraje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeposito = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRecepcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInicioReparacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEntrega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaTrabajos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalTrabajos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaRepuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRepuestos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIvaOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenTrabajoBindingSource)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(851, 25);
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
            this.gridControl1.DataSource = this.clsOrdenTrabajoBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(851, 255);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsOrdenTrabajoBindingSource
            // 
            this.clsOrdenTrabajoBindingSource.DataSource = typeof(clases.Taller.clsOrdenTrabajo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOrdenTrabajo,
            this.colIdPresupuesto,
            this.colIdPersona,
            this.colCliente,
            this.colIdArticulo,
            this.colNroPlaca,
            this.colMarca,
            this.colModelo,
            this.colColor,
            this.colChasis,
            this.colKilometraje,
            this.colCombustible,
            this.colDeposito,
            this.colFechaRecepcion,
            this.colInicioReparacion,
            this.colFechaIngreso,
            this.colFechaEntrega,
            this.colIvaTrabajos,
            this.colTotalTrabajos,
            this.colIvaRepuestos,
            this.colTotalRepuestos,
            this.colIvaOtros,
            this.colTotalOtros,
            this.colObservacion,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdOrdenTrabajo
            // 
            this.colIdOrdenTrabajo.FieldName = "IdOrdenTrabajo";
            this.colIdOrdenTrabajo.Name = "colIdOrdenTrabajo";
            this.colIdOrdenTrabajo.Visible = true;
            this.colIdOrdenTrabajo.VisibleIndex = 0;
            // 
            // colIdPresupuesto
            // 
            this.colIdPresupuesto.FieldName = "IdPresupuesto";
            this.colIdPresupuesto.Name = "colIdPresupuesto";
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 1;
            // 
            // colCliente
            // 
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 2;
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
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
            // colChasis
            // 
            this.colChasis.FieldName = "Chasis";
            this.colChasis.Name = "colChasis";
            // 
            // colKilometraje
            // 
            this.colKilometraje.FieldName = "Kilometraje";
            this.colKilometraje.Name = "colKilometraje";
            // 
            // colCombustible
            // 
            this.colCombustible.FieldName = "Combustible";
            this.colCombustible.Name = "colCombustible";
            // 
            // colDeposito
            // 
            this.colDeposito.FieldName = "Deposito";
            this.colDeposito.Name = "colDeposito";
            // 
            // colFechaRecepcion
            // 
            this.colFechaRecepcion.FieldName = "FechaRecepcion";
            this.colFechaRecepcion.Name = "colFechaRecepcion";
            this.colFechaRecepcion.Visible = true;
            this.colFechaRecepcion.VisibleIndex = 7;
            // 
            // colInicioReparacion
            // 
            this.colInicioReparacion.FieldName = "InicioReparacion";
            this.colInicioReparacion.Name = "colInicioReparacion";
            this.colInicioReparacion.Visible = true;
            this.colInicioReparacion.VisibleIndex = 8;
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
            // colIvaTrabajos
            // 
            this.colIvaTrabajos.FieldName = "IvaTrabajos";
            this.colIvaTrabajos.Name = "colIvaTrabajos";
            // 
            // colTotalTrabajos
            // 
            this.colTotalTrabajos.FieldName = "TotalTrabajos";
            this.colTotalTrabajos.Name = "colTotalTrabajos";
            this.colTotalTrabajos.Visible = true;
            this.colTotalTrabajos.VisibleIndex = 9;
            // 
            // colIvaRepuestos
            // 
            this.colIvaRepuestos.FieldName = "IvaRepuestos";
            this.colIvaRepuestos.Name = "colIvaRepuestos";
            // 
            // colTotalRepuestos
            // 
            this.colTotalRepuestos.FieldName = "TotalRepuestos";
            this.colTotalRepuestos.Name = "colTotalRepuestos";
            this.colTotalRepuestos.Visible = true;
            this.colTotalRepuestos.VisibleIndex = 10;
            // 
            // colIvaOtros
            // 
            this.colIvaOtros.FieldName = "IvaOtros";
            this.colIvaOtros.Name = "colIvaOtros";
            // 
            // colTotalOtros
            // 
            this.colTotalOtros.FieldName = "TotalOtros";
            this.colTotalOtros.Name = "colTotalOtros";
            this.colTotalOtros.Visible = true;
            this.colTotalOtros.VisibleIndex = 11;
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
            this.colIdEstado.VisibleIndex = 12;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // frmConsultarOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 283);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarOrdenTrabajo";
            this.Text = "frmConsultarOrdenTrabajo";
            this.Load += new System.EventHandler(this.frmConsultarOrdenTrabajo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenTrabajoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsOrdenTrabajoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colColor;
        private DevExpress.XtraGrid.Columns.GridColumn colChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colKilometraje;
        private DevExpress.XtraGrid.Columns.GridColumn colCombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colDeposito;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRecepcion;
        private DevExpress.XtraGrid.Columns.GridColumn colInicioReparacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEntrega;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaTrabajos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalTrabajos;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaRepuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRepuestos;
        private DevExpress.XtraGrid.Columns.GridColumn colIvaOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}