namespace forms.RecursosHumanos
{
    partial class frmPConsultaPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPConsultaPrestamo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gcPrestramo = new DevExpress.XtraGrid.GridControl();
            this.gvPrestamo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsPrestamoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdPrestamo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInteres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestramo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPrestamoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
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
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click_1);
            // 
            // gcPrestramo
            // 
            this.gcPrestramo.DataSource = this.clsPrestamoBindingSource;
            this.gcPrestramo.Location = new System.Drawing.Point(0, 28);
            this.gcPrestramo.MainView = this.gvPrestamo;
            this.gcPrestramo.Name = "gcPrestramo";
            this.gcPrestramo.Size = new System.Drawing.Size(614, 215);
            this.gcPrestramo.TabIndex = 29;
            this.gcPrestramo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPrestamo});
            // 
            // gvPrestamo
            // 
            this.gvPrestamo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPrestamo,
            this.colIdPersona,
            this.colIdentificacion,
            this.colNombre,
            this.colApellido,
            this.colFechaModificacion,
            this.colMonto,
            this.colPago,
            this.colTotal,
            this.colInteres,
            this.colTotalPagado,
            this.colPeriodos,
            this.colIdEstado,
            this.colIdEmpresa});
            this.gvPrestamo.GridControl = this.gcPrestramo;
            this.gvPrestamo.Name = "gvPrestamo";
            // 
            // clsPrestamoBindingSource
            // 
            this.clsPrestamoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsPrestamo);
            // 
            // colIdPrestamo
            // 
            this.colIdPrestamo.FieldName = "IdPrestamo";
            this.colIdPrestamo.Name = "colIdPrestamo";
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.FieldName = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.Visible = true;
            this.colIdentificacion.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 3;
            // 
            // colMonto
            // 
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 4;
            // 
            // colPago
            // 
            this.colPago.FieldName = "Pago";
            this.colPago.Name = "colPago";
            this.colPago.Visible = true;
            this.colPago.VisibleIndex = 5;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            // 
            // colInteres
            // 
            this.colInteres.FieldName = "Interes";
            this.colInteres.Name = "colInteres";
            this.colInteres.Visible = true;
            this.colInteres.VisibleIndex = 7;
            // 
            // colTotalPagado
            // 
            this.colTotalPagado.FieldName = "TotalPagado";
            this.colTotalPagado.Name = "colTotalPagado";
            this.colTotalPagado.Visible = true;
            this.colTotalPagado.VisibleIndex = 8;
            // 
            // colPeriodos
            // 
            this.colPeriodos.FieldName = "Periodos";
            this.colPeriodos.Name = "colPeriodos";
            this.colPeriodos.Visible = true;
            this.colPeriodos.VisibleIndex = 9;
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
            // frmPConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 244);
            this.Controls.Add(this.gcPrestramo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPConsultaPrestamo";
            this.Text = "Consultar Prestamo";
            this.Load += new System.EventHandler(this.frmPConsultaPrestamo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrestramo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPrestamoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gcPrestramo;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPrestamo;
        private System.Windows.Forms.BindingSource clsPrestamoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPrestamo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colPago;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInteres;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagado;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
    }
}