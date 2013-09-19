namespace forms
{
    partial class frmPConsultaContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPConsultaContrato));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gcContrato = new DevExpress.XtraGrid.GridControl();
            this.clsContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvContrato = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoContrato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemuneracion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdJornada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodoPrueba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDiscapacidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCarnet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(618, 25);
            this.toolStrip1.TabIndex = 27;
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
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click);
            // 
            // gcContrato
            // 
            this.gcContrato.DataSource = this.clsContratoBindingSource;
            this.gcContrato.Location = new System.Drawing.Point(12, 39);
            this.gcContrato.MainView = this.gvContrato;
            this.gcContrato.Name = "gcContrato";
            this.gcContrato.Size = new System.Drawing.Size(594, 236);
            this.gcContrato.TabIndex = 28;
            this.gcContrato.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvContrato});
            // 
            // clsContratoBindingSource
            // 
            this.clsContratoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsContrato);
            // 
            // gvContrato
            // 
            this.gvContrato.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumContrato,
            this.colIdPersona,
            this.colIdTipoContrato,
            this.colIdCargo,
            this.colIdEmpresa,
            this.colFecha,
            this.colFechaModificacion,
            this.colRemuneracion,
            this.colIdJornada,
            this.colPeriodoPrueba,
            this.colDiscapacidad,
            this.colgrado,
            this.colTipoDiscapacidad,
            this.colCarnet,
            this.colIdEstado});
            this.gvContrato.GridControl = this.gcContrato;
            this.gvContrato.Name = "gvContrato";
            // 
            // colNumContrato
            // 
            this.colNumContrato.FieldName = "NumContrato";
            this.colNumContrato.Name = "colNumContrato";
            this.colNumContrato.Visible = true;
            this.colNumContrato.VisibleIndex = 0;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colIdTipoContrato
            // 
            this.colIdTipoContrato.FieldName = "IdTipoContrato";
            this.colIdTipoContrato.Name = "colIdTipoContrato";
            // 
            // colIdCargo
            // 
            this.colIdCargo.FieldName = "IdCargo";
            this.colIdCargo.Name = "colIdCargo";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 2;
            // 
            // colRemuneracion
            // 
            this.colRemuneracion.FieldName = "Remuneracion";
            this.colRemuneracion.Name = "colRemuneracion";
            this.colRemuneracion.Visible = true;
            this.colRemuneracion.VisibleIndex = 3;
            // 
            // colIdJornada
            // 
            this.colIdJornada.FieldName = "IdJornada";
            this.colIdJornada.Name = "colIdJornada";
            // 
            // colPeriodoPrueba
            // 
            this.colPeriodoPrueba.FieldName = "PeriodoPrueba";
            this.colPeriodoPrueba.Name = "colPeriodoPrueba";
            this.colPeriodoPrueba.Visible = true;
            this.colPeriodoPrueba.VisibleIndex = 4;
            // 
            // colDiscapacidad
            // 
            this.colDiscapacidad.FieldName = "Discapacidad";
            this.colDiscapacidad.Name = "colDiscapacidad";
            this.colDiscapacidad.Visible = true;
            this.colDiscapacidad.VisibleIndex = 5;
            // 
            // colgrado
            // 
            this.colgrado.FieldName = "grado";
            this.colgrado.Name = "colgrado";
            this.colgrado.Visible = true;
            this.colgrado.VisibleIndex = 6;
            // 
            // colTipoDiscapacidad
            // 
            this.colTipoDiscapacidad.FieldName = "TipoDiscapacidad";
            this.colTipoDiscapacidad.Name = "colTipoDiscapacidad";
            this.colTipoDiscapacidad.Visible = true;
            this.colTipoDiscapacidad.VisibleIndex = 7;
            // 
            // colCarnet
            // 
            this.colCarnet.FieldName = "Carnet";
            this.colCarnet.Name = "colCarnet";
            this.colCarnet.Visible = true;
            this.colCarnet.VisibleIndex = 8;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // frmPConsultaContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 309);
            this.Controls.Add(this.gcContrato);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPConsultaContrato";
            this.Text = "Consultar Contrato";
            this.Load += new System.EventHandler(this.frmPConsultaContrato_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gcContrato;
        private System.Windows.Forms.BindingSource clsContratoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colNumContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoContrato;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colRemuneracion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdJornada;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodoPrueba;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colgrado;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDiscapacidad;
        private DevExpress.XtraGrid.Columns.GridColumn colCarnet;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}