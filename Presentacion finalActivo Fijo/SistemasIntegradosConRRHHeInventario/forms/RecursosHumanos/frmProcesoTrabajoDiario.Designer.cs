namespace forms.RecursosHumanos
{
    partial class frmProcesoTrabajoDiario
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gcAsistencia = new DevExpress.XtraEditors.GroupControl();
            this.gcAsis = new DevExpress.XtraGrid.GridControl();
            this.clsTrabajoDiarioDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvAsistencia = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colHoraInicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoraSalida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Marcar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colHoraEntrada1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colHoraSalida2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.colHorasxDia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoraEntrada = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.HoraSalida = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.HoraEntrada1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.HoraSalida1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTimeEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsistencia)).BeginInit();
            this.gcAsistencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraSalida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraEntrada1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraSalida1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(757, 25);
            this.tsMenu.TabIndex = 23;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(58, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(66, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(588, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(36, 13);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(62, 47);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 55;
            this.lblNumero.Text = "Número:";
            // 
            // gcAsistencia
            // 
            this.gcAsistencia.Controls.Add(this.gcAsis);
            this.gcAsistencia.Location = new System.Drawing.Point(22, 172);
            this.gcAsistencia.Name = "gcAsistencia";
            this.gcAsistencia.Size = new System.Drawing.Size(713, 215);
            this.gcAsistencia.TabIndex = 58;
            this.gcAsistencia.Text = "Asistencia";
            // 
            // gcAsis
            // 
            this.gcAsis.DataSource = this.clsTrabajoDiarioDetBindingSource;
            this.gcAsis.Location = new System.Drawing.Point(5, 24);
            this.gcAsis.MainView = this.gvAsistencia;
            this.gcAsis.Name = "gcAsis";
            this.gcAsis.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.HoraEntrada,
            this.repositoryItemDateEdit1,
            this.HoraSalida,
            this.HoraEntrada1,
            this.HoraSalida1,
            this.repositoryItemTimeEdit1,
            this.repositoryItemTimeEdit2,
            this.repositoryItemTimeEdit3,
            this.repositoryItemTimeEdit4,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTimeEdit5,
            this.repositoryItemTextEdit3,
            this.repositoryItemButtonEdit1});
            this.gcAsis.Size = new System.Drawing.Size(694, 186);
            this.gcAsis.TabIndex = 0;
            this.gcAsis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAsistencia});
            // 
            // gvAsistencia
            // 
            this.gvAsistencia.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea,
            this.colNumTrabajo,
            this.colIdPersona,
            this.colIdentificacion,
            this.colCedula,
            this.colApellido,
            this.colNombre,
            this.colHoraInicio,
            this.colHoraSalida,
            this.Marcar,
            this.colHoraEntrada1,
            this.colHoraSalida2,
            this.colHorasxDia,
            this.colIdEmpresa});
            this.gvAsistencia.GridControl = this.gcAsis;
            this.gvAsistencia.Name = "gvAsistencia";
            // 
            // colNumLinea
            // 
            this.colNumLinea.FieldName = "NumLinea";
            this.colNumLinea.Name = "colNumLinea";
            // 
            // colNumTrabajo
            // 
            this.colNumTrabajo.FieldName = "NumTrabajo";
            this.colNumTrabajo.Name = "colNumTrabajo";
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.ColumnEdit = this.repositoryItemTextEdit1;
            this.colIdentificacion.FieldName = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.Visible = true;
            this.colIdentificacion.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            this.repositoryItemTextEdit1.ReadOnly = true;
            // 
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            // 
            // colApellido
            // 
            this.colApellido.ColumnEdit = this.repositoryItemTextEdit2;
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            this.repositoryItemTextEdit2.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.ColumnEdit = this.repositoryItemTextEdit3;
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.ReadOnly = true;
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
            // Marcar
            // 
            this.Marcar.Caption = "Marcar";
            this.Marcar.ColumnEdit = this.repositoryItemButtonEdit1;
            this.Marcar.Name = "Marcar";
            this.Marcar.Visible = true;
            this.Marcar.VisibleIndex = 5;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // colHoraEntrada1
            // 
            this.colHoraEntrada1.Caption = "Ingreso";
            this.colHoraEntrada1.ColumnEdit = this.repositoryItemTimeEdit3;
            this.colHoraEntrada1.FieldName = "HoraEntrada1";
            this.colHoraEntrada1.Name = "colHoraEntrada1";
            this.colHoraEntrada1.Visible = true;
            this.colHoraEntrada1.VisibleIndex = 3;
            // 
            // repositoryItemTimeEdit3
            // 
            this.repositoryItemTimeEdit3.AutoHeight = false;
            this.repositoryItemTimeEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit3.Mask.EditMask = "t";
            this.repositoryItemTimeEdit3.Name = "repositoryItemTimeEdit3";
            // 
            // colHoraSalida2
            // 
            this.colHoraSalida2.Caption = "Salida";
            this.colHoraSalida2.ColumnEdit = this.repositoryItemTimeEdit4;
            this.colHoraSalida2.FieldName = "HoraSalida2";
            this.colHoraSalida2.Name = "colHoraSalida2";
            this.colHoraSalida2.Visible = true;
            this.colHoraSalida2.VisibleIndex = 4;
            // 
            // repositoryItemTimeEdit4
            // 
            this.repositoryItemTimeEdit4.AutoHeight = false;
            this.repositoryItemTimeEdit4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit4.Mask.EditMask = "t";
            this.repositoryItemTimeEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.repositoryItemTimeEdit4.Name = "repositoryItemTimeEdit4";
            // 
            // colHorasxDia
            // 
            this.colHorasxDia.FieldName = "HorasxDia";
            this.colHorasxDia.Name = "colHorasxDia";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // HoraEntrada
            // 
            this.HoraEntrada.AutoHeight = false;
            this.HoraEntrada.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.HoraEntrada.Mask.EditMask = "t";
            this.HoraEntrada.Name = "HoraEntrada";
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.Mask.EditMask = "ttttt";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // HoraSalida
            // 
            this.HoraSalida.AutoHeight = false;
            this.HoraSalida.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.HoraSalida.Mask.EditMask = "t";
            this.HoraSalida.Name = "HoraSalida";
            // 
            // HoraEntrada1
            // 
            this.HoraEntrada1.AutoHeight = false;
            this.HoraEntrada1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.HoraEntrada1.Name = "HoraEntrada1";
            // 
            // HoraSalida1
            // 
            this.HoraSalida1.AutoHeight = false;
            this.HoraSalida1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.HoraSalida1.Name = "HoraSalida1";
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Mask.EditMask = "t";
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemTimeEdit2
            // 
            this.repositoryItemTimeEdit2.AutoHeight = false;
            this.repositoryItemTimeEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit2.Mask.EditMask = "t";
            this.repositoryItemTimeEdit2.Name = "repositoryItemTimeEdit2";
            // 
            // repositoryItemTimeEdit5
            // 
            this.repositoryItemTimeEdit5.AutoHeight = false;
            this.repositoryItemTimeEdit5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit5.Name = "repositoryItemTimeEdit5";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(39, 108);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 61;
            this.lblObservacion.Text = "Observación:";
            // 
            // deFecha
            // 
            this.deFecha.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFecha.Enabled = false;
            this.deFecha.Location = new System.Drawing.Point(630, 40);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(100, 20);
            this.deFecha.TabIndex = 75;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(115, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 20);
            this.txtNumero.TabIndex = 76;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(233, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(115, 105);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(606, 50);
            this.txtObservacion.TabIndex = 78;
            // 
            // teHora
            // 
            this.teHora.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teHora.Location = new System.Drawing.Point(637, 404);
            this.teHora.Name = "teHora";
            this.teHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHora.Size = new System.Drawing.Size(100, 20);
            this.teHora.TabIndex = 82;
            // 
            // lblHora
            // 
            this.lblHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(601, 407);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 81;
            this.lblHora.Text = "Hora:";
            // 
            // frmProcesoTrabajoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 447);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.gcAsistencia);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.txtObservacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 474);
            this.MinimumSize = new System.Drawing.Size(765, 474);
            this.Name = "frmProcesoTrabajoDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Diario";
            this.Load += new System.EventHandler(this.frmProcesoTrabajoDiario_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsistencia)).EndInit();
            this.gcAsistencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcAsis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTrabajoDiarioDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraSalida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraEntrada1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoraSalida1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private DevExpress.XtraEditors.GroupControl gcAsistencia;
        private System.Windows.Forms.Label lblObservacion;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraGrid.GridControl gcAsis;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAsistencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit HoraEntrada;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit HoraSalida;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit HoraEntrada1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit HoraSalida1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit2;
        private System.Windows.Forms.BindingSource clsTrabajoDiarioDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colNumTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraInicio;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraEntrada1;
        private DevExpress.XtraGrid.Columns.GridColumn colHoraSalida2;
        private DevExpress.XtraGrid.Columns.GridColumn colHorasxDia;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit5;
        private DevExpress.XtraGrid.Columns.GridColumn Marcar;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;


    }
}