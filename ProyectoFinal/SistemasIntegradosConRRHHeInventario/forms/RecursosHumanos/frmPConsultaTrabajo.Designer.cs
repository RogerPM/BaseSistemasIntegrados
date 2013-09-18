namespace forms.RecursosHumanos
{
    partial class frmPConsultaTrabajo
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
            this.gcTrabajoDiario = new DevExpress.XtraGrid.GridControl();
            this.clsTrabajoDiarioCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvTrabajoDiario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrabajoDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrabajoDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 25);
            this.toolStrip1.TabIndex = 28;
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
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click_1);
            // 
            // gcTrabajoDiario
            // 
            this.gcTrabajoDiario.DataSource = this.clsTrabajoDiarioCabBindingSource;
            this.gcTrabajoDiario.Location = new System.Drawing.Point(12, 48);
            this.gcTrabajoDiario.MainView = this.gvTrabajoDiario;
            this.gcTrabajoDiario.Name = "gcTrabajoDiario";
            this.gcTrabajoDiario.Size = new System.Drawing.Size(617, 246);
            this.gcTrabajoDiario.TabIndex = 29;
            this.gcTrabajoDiario.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTrabajoDiario});
            // 
            // gvTrabajoDiario
            // 
            this.gvTrabajoDiario.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumTrabajo,
            this.colFecha,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colObservacion});
            this.gvTrabajoDiario.GridControl = this.gcTrabajoDiario;
            this.gvTrabajoDiario.Name = "gvTrabajoDiario";
            // 
            // colNumTrabajo
            // 
            this.colNumTrabajo.FieldName = "NumTrabajo";
            this.colNumTrabajo.Name = "colNumTrabajo";
            this.colNumTrabajo.Visible = true;
            this.colNumTrabajo.VisibleIndex = 0;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
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
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 2;
            // 
            // frmPConsultaTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 304);
            this.Controls.Add(this.gcTrabajoDiario);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPConsultaTrabajo";
            this.Text = "Consulta Trabajo Diario";
            this.Load += new System.EventHandler(this.frmPConsultaTrabajo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrabajoDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrabajoDiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gcTrabajoDiario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrabajoDiario;
        private System.Windows.Forms.BindingSource clsTrabajoDiarioCabBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
    }
}