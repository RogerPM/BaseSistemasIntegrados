namespace forms.RecursosHumanos
{
    partial class frmPConsultaNomina
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gcConsultaNomina = new DevExpress.XtraGrid.GridControl();
            this.clsNominaCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvConsultaNomina = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumNomina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultaNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsultaNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(645, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConsultado
            // 
            this.tsbConsultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultado.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultado.Image = global::forms.Properties.Resources._24_aceptar;
            this.tsbConsultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultado.Name = "tsbConsultado";
            this.tsbConsultado.Size = new System.Drawing.Size(88, 22);
            this.tsbConsultado.Text = "Consultado";
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click);
            // 
            // gcConsultaNomina
            // 
            this.gcConsultaNomina.DataSource = this.clsNominaCabBindingSource;
            this.gcConsultaNomina.Location = new System.Drawing.Point(0, 28);
            this.gcConsultaNomina.MainView = this.gvConsultaNomina;
            this.gcConsultaNomina.Name = "gcConsultaNomina";
            this.gcConsultaNomina.Size = new System.Drawing.Size(645, 203);
            this.gcConsultaNomina.TabIndex = 30;
            this.gcConsultaNomina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConsultaNomina});
            // 
            // gvConsultaNomina
            // 
            this.gvConsultaNomina.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumNomina,
            this.colFecha,
            this.colFechaModificacion,
            this.colPeriodo,
            this.colTotal,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colObservacion});
            this.gvConsultaNomina.GridControl = this.gcConsultaNomina;
            this.gvConsultaNomina.Name = "gvConsultaNomina";
            // 
            // colNumNomina
            // 
            this.colNumNomina.FieldName = "NumNomina";
            this.colNumNomina.Name = "colNumNomina";
            this.colNumNomina.Visible = true;
            this.colNumNomina.VisibleIndex = 0;
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
            // colPeriodo
            // 
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.Visible = true;
            this.colPeriodo.VisibleIndex = 3;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 5;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 6;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 7;
            // 
            // frmPConsultaNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 232);
            this.Controls.Add(this.gcConsultaNomina);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPConsultaNomina";
            this.Text = "Consulta Nomina";
            this.Load += new System.EventHandler(this.frmPConsultaNomina_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultaNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsultaNomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gcConsultaNomina;
        private System.Windows.Forms.BindingSource clsNominaCabBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsultaNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNomina;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
    }
}