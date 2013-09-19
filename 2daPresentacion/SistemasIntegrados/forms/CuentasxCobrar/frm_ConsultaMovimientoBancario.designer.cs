namespace forms.CuentasxCobrar
{
    partial class frm_ConsultaMovimientoBancario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ConsultaMovimientoBancario));
            this.gdcMovimientoBancario = new DevExpress.XtraGrid.GridControl();
            this.clsMovimientobancarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdmovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsusario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcMovimientoBancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMovimientobancarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcMovimientoBancario
            // 
            this.gdcMovimientoBancario.DataSource = this.clsMovimientobancarioBindingSource;
            this.gdcMovimientoBancario.Location = new System.Drawing.Point(12, 48);
            this.gdcMovimientoBancario.MainView = this.gridView1;
            this.gdcMovimientoBancario.Name = "gdcMovimientoBancario";
            this.gdcMovimientoBancario.Size = new System.Drawing.Size(440, 205);
            this.gdcMovimientoBancario.TabIndex = 0;
            this.gdcMovimientoBancario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsMovimientobancarioBindingSource
            // 
            this.clsMovimientobancarioBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsMovimientobancario);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdmovimiento,
            this.colnumero,
            this.colobservacion,
            this.colFecha,
            this.colValor,
            this.colFechaModificacion,
            this.colIdEstado,
            this.colIdBanco,
            this.colIdEmpresa,
            this.colIdUsusario,
            this.colIdTransaccion});
            this.gridView1.GridControl = this.gdcMovimientoBancario;
            this.gridView1.Name = "gridView1";
            // 
            // colIdmovimiento
            // 
            this.colIdmovimiento.FieldName = "idMovimientoBancario";
            this.colIdmovimiento.Name = "colIdmovimiento";
            this.colIdmovimiento.Visible = true;
            this.colIdmovimiento.VisibleIndex = 0;
            // 
            // colnumero
            // 
            this.colnumero.FieldName = "NumeroDocumento";
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 1;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "Observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 2;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 3;
            // 
            // colValor
            // 
            this.colValor.FieldName = "Valor";
            this.colValor.Name = "colValor";
            this.colValor.Visible = true;
            this.colValor.VisibleIndex = 4;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 5;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "idEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 6;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "idBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 7;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "idEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 8;
            // 
            // colIdUsusario
            // 
            this.colIdUsusario.FieldName = "idUsuario";
            this.colIdUsusario.Name = "colIdUsusario";
            this.colIdUsusario.Visible = true;
            this.colIdUsusario.VisibleIndex = 9;
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.FieldName = "idTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            this.colIdTransaccion.Visible = true;
            this.colIdTransaccion.VisibleIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOK,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(464, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOK
            // 
            this.tsbOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOK.Name = "tsbOK";
            this.tsbOK.Size = new System.Drawing.Size(26, 22);
            this.tsbOK.Text = "Ok";
            this.tsbOK.Click += new System.EventHandler(this.tsbOK_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmConsultaMovimientoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 304);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcMovimientoBancario);
            this.Name = "FrmConsultaMovimientoBancario";
            this.Text = "FrmConsultaMovimientoBancario";
            this.Load += new System.EventHandler(this.FrmConsultaMovimientoBancario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcMovimientoBancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMovimientobancarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcMovimientoBancario;
        private System.Windows.Forms.BindingSource clsMovimientobancarioBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdmovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOK;
        private DevExpress.XtraGrid.Columns.GridColumn colValor;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsusario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}