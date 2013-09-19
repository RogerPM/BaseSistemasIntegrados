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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPConsultaTrabajo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            this.gcTrabajoDiario = new DevExpress.XtraGrid.GridControl();
            this.gvTrabajoDiario = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsTrabajoDiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNumTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaDesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaHasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraEntrada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraSalida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraTrabajada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraExtraM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraExtraT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraRango = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTrabajoDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTrabajoDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioBindingSource)).BeginInit();
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
            this.tsbConsultado.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultado.Image")));
            this.tsbConsultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultado.Name = "tsbConsultado";
            this.tsbConsultado.Size = new System.Drawing.Size(88, 22);
            this.tsbConsultado.Text = "Consultado";
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click_1);
            // 
            // gcTrabajoDiario
            // 
            this.gcTrabajoDiario.DataSource = this.clsTrabajoDiarioBindingSource;
            this.gcTrabajoDiario.Location = new System.Drawing.Point(0, 46);
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
            this.colFechaDesde,
            this.colFechaHasta,
            this.colIdEstado,
            this.colIdEmpresa,
            this.colObservacion,
            this.colIdPersona,
            this.colIdentificacion,
            this.colApellido,
            this.colNombre,
            this.colHoraInicio,
            this.colHoraSalida,
            this.colHoraEntrada1,
            this.colHoraSalida2,
            this.colHoraTrabajada,
            this.colHoraExtraM,
            this.colHoraExtraT,
            this.colHoraRango});
            this.gvTrabajoDiario.GridControl = this.gcTrabajoDiario;
            this.gvTrabajoDiario.Name = "gvTrabajoDiario";
            // 
            // clsTrabajoDiarioBindingSource
            // 
            this.clsTrabajoDiarioBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTrabajoDiario);
            // 
            // colNumTrabajo
            // 
            this.colNumTrabajo.FieldName = "NumTrabajo";
            this.colNumTrabajo.Name = "colNumTrabajo";
            // 
            // colFechaDesde
            // 
            this.colFechaDesde.FieldName = "FechaDesde";
            this.colFechaDesde.Name = "colFechaDesde";
            this.colFechaDesde.Visible = true;
            this.colFechaDesde.VisibleIndex = 3;
            // 
            // colFechaHasta
            // 
            this.colFechaHasta.FieldName = "FechaHasta";
            this.colFechaHasta.Name = "colFechaHasta";
            this.colFechaHasta.Visible = true;
            this.colFechaHasta.VisibleIndex = 4;
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
            this.colObservacion.VisibleIndex = 7;
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
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colHoraInicio
            // 
            this.colHoraInicio.FieldName = "HoraInicio";
            this.colHoraInicio.Name = "colHoraInicio";
            // 
            // colHoraSalida
            // 
            this.colHoraSalida.FieldName = "HoraSalida";
            this.colHoraSalida.Name = "colHoraSalida";
            // 
            // colHoraEntrada1
            // 
            this.colHoraEntrada1.FieldName = "HoraEntrada1";
            this.colHoraEntrada1.Name = "colHoraEntrada1";
            this.colHoraEntrada1.Visible = true;
            this.colHoraEntrada1.VisibleIndex = 5;
            // 
            // colHoraSalida2
            // 
            this.colHoraSalida2.FieldName = "HoraSalida2";
            this.colHoraSalida2.Name = "colHoraSalida2";
            this.colHoraSalida2.Visible = true;
            this.colHoraSalida2.VisibleIndex = 6;
            // 
            // colHoraTrabajada
            // 
            this.colHoraTrabajada.FieldName = "HoraTrabajada";
            this.colHoraTrabajada.Name = "colHoraTrabajada";
            // 
            // colHoraExtraM
            // 
            this.colHoraExtraM.FieldName = "HoraExtraM";
            this.colHoraExtraM.Name = "colHoraExtraM";
            // 
            // colHoraExtraT
            // 
            this.colHoraExtraT.FieldName = "HoraExtraT";
            this.colHoraExtraT.Name = "colHoraExtraT";
            // 
            // colHoraRango
            // 
            this.colHoraRango.FieldName = "HoraRango";
            this.colHoraRango.Name = "colHoraRango";
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
            ((System.ComponentModel.ISupportInitialize)(this.gvTrabajoDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
        private DevExpress.XtraGrid.GridControl gcTrabajoDiario;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTrabajoDiario;
        private System.Windows.Forms.BindingSource clsTrabajoDiarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaHasta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraEntrada1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida2;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraTrabajada;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraExtraM;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraExtraT;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraRango;
    }
}