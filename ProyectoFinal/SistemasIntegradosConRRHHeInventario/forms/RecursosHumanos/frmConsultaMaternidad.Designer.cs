namespace forms.RecursosHumanos
{
    partial class frmConsultaMaternidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaMaternidad));
            this.tsConsultaTitulo = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaMaternidad = new DevExpress.XtraGrid.GridControl();
            this.clsMaternidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumMaternidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaParto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tsConsultaTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaMaternidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMaternidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsConsultaTitulo
            // 
            this.tsConsultaTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.tsConsultaTitulo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.tsConsultaTitulo.Location = new System.Drawing.Point(0, 0);
            this.tsConsultaTitulo.Name = "tsConsultaTitulo";
            this.tsConsultaTitulo.Size = new System.Drawing.Size(725, 25);
            this.tsConsultaTitulo.TabIndex = 28;
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
            // gdcConsultaMaternidad
            // 
            this.gdcConsultaMaternidad.DataSource = this.clsMaternidadBindingSource;
            this.gdcConsultaMaternidad.Location = new System.Drawing.Point(13, 38);
            this.gdcConsultaMaternidad.MainView = this.gridView1;
            this.gdcConsultaMaternidad.Name = "gdcConsultaMaternidad";
            this.gdcConsultaMaternidad.Size = new System.Drawing.Size(700, 200);
            this.gdcConsultaMaternidad.TabIndex = 29;
            this.gdcConsultaMaternidad.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsMaternidadBindingSource
            // 
            this.clsMaternidadBindingSource.DataSource = typeof(clases.RecursosHumanos.clsMaternidad);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumMaternidad,
            this.colIdEmpleado,
            this.colIdEmpresa,
            this.colFechaParto,
            this.colFechaInicio,
            this.colFechaFin,
            this.colFechaModificacion,
            this.colIdEstado});
            this.gridView1.GridControl = this.gdcConsultaMaternidad;
            this.gridView1.Name = "gridView1";
            // 
            // colNumMaternidad
            // 
            this.colNumMaternidad.FieldName = "NumMaternidad";
            this.colNumMaternidad.Name = "colNumMaternidad";
            this.colNumMaternidad.OptionsColumn.AllowEdit = false;
            this.colNumMaternidad.OptionsColumn.ReadOnly = true;
            this.colNumMaternidad.Visible = true;
            this.colNumMaternidad.VisibleIndex = 0;
            this.colNumMaternidad.Width = 85;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.OptionsColumn.AllowEdit = false;
            this.colIdEmpleado.OptionsColumn.ReadOnly = true;
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 1;
            this.colIdEmpleado.Width = 70;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.OptionsColumn.ReadOnly = true;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 2;
            this.colIdEmpresa.Width = 64;
            // 
            // colFechaParto
            // 
            this.colFechaParto.FieldName = "FechaParto";
            this.colFechaParto.Name = "colFechaParto";
            this.colFechaParto.OptionsColumn.AllowEdit = false;
            this.colFechaParto.OptionsColumn.ReadOnly = true;
            this.colFechaParto.Visible = true;
            this.colFechaParto.VisibleIndex = 3;
            this.colFechaParto.Width = 91;
            // 
            // colFechaInicio
            // 
            this.colFechaInicio.FieldName = "FechaInicio";
            this.colFechaInicio.Name = "colFechaInicio";
            this.colFechaInicio.OptionsColumn.AllowEdit = false;
            this.colFechaInicio.OptionsColumn.ReadOnly = true;
            this.colFechaInicio.Visible = true;
            this.colFechaInicio.VisibleIndex = 4;
            this.colFechaInicio.Width = 91;
            // 
            // colFechaFin
            // 
            this.colFechaFin.FieldName = "FechaFin";
            this.colFechaFin.Name = "colFechaFin";
            this.colFechaFin.OptionsColumn.AllowEdit = false;
            this.colFechaFin.OptionsColumn.ReadOnly = true;
            this.colFechaFin.Visible = true;
            this.colFechaFin.VisibleIndex = 5;
            this.colFechaFin.Width = 68;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.OptionsColumn.AllowEdit = false;
            this.colFechaModificacion.OptionsColumn.ReadOnly = true;
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 6;
            this.colFechaModificacion.Width = 122;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.OptionsColumn.AllowEdit = false;
            this.colIdEstado.OptionsColumn.ReadOnly = true;
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 7;
            this.colIdEstado.Width = 91;
            // 
            // frmMConsultaMaternidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 262);
            this.Controls.Add(this.gdcConsultaMaternidad);
            this.Controls.Add(this.tsConsultaTitulo);
            this.MaximizeBox = false;
            this.Name = "frmMConsultaMaternidad";
            this.Text = "frmMConsultaMaternidad";
            this.Load += new System.EventHandler(this.frmMConsultaMaternidad_Load);
            this.tsConsultaTitulo.ResumeLayout(false);
            this.tsConsultaTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaMaternidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMaternidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsConsultaTitulo;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gdcConsultaMaternidad;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsMaternidadBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumMaternidad;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaParto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFin;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}