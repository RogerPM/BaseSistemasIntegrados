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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblNumero = new System.Windows.Forms.Label();
            this.gdcAsistencia = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Empleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Asistencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRadioGroup1 = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
            this.Atraso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Falta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gcAsistencia = new DevExpress.XtraEditors.GroupControl();
            this.dbDepartamento = new DevExpress.XtraEditors.DropDownButton();
            this.lbDepartamento = new DevExpress.XtraEditors.LabelControl();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.lblPUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsistencia)).BeginInit();
            this.gcAsistencia.SuspendLayout();
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
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(749, 25);
            this.tsMenu.TabIndex = 23;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::forms.Properties.Resources.modificar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
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
            // gdcAsistencia
            // 
            this.gdcAsistencia.Location = new System.Drawing.Point(5, 22);
            this.gdcAsistencia.MainView = this.gridView1;
            this.gdcAsistencia.Name = "gdcAsistencia";
            this.gdcAsistencia.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemRadioGroup1});
            this.gdcAsistencia.Size = new System.Drawing.Size(703, 188);
            this.gdcAsistencia.TabIndex = 0;
            this.gdcAsistencia.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.Empleado,
            this.Departamento,
            this.Cargo,
            this.Asistencia,
            this.Atraso,
            this.Falta});
            this.gridView1.GridControl = this.gdcAsistencia;
            this.gridView1.Name = "gridView1";
            // 
            // Id
            // 
            this.Id.Caption = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 0;
            this.Id.Width = 114;
            // 
            // Empleado
            // 
            this.Empleado.Caption = "Empleado";
            this.Empleado.Name = "Empleado";
            this.Empleado.Visible = true;
            this.Empleado.VisibleIndex = 1;
            this.Empleado.Width = 114;
            // 
            // Departamento
            // 
            this.Departamento.Caption = "Departamento";
            this.Departamento.Name = "Departamento";
            this.Departamento.Visible = true;
            this.Departamento.VisibleIndex = 2;
            this.Departamento.Width = 114;
            // 
            // Cargo
            // 
            this.Cargo.Caption = "Cargo";
            this.Cargo.Name = "Cargo";
            this.Cargo.Visible = true;
            this.Cargo.VisibleIndex = 3;
            this.Cargo.Width = 114;
            // 
            // Asistencia
            // 
            this.Asistencia.Caption = "Asistencia";
            this.Asistencia.ColumnEdit = this.repositoryItemRadioGroup1;
            this.Asistencia.FieldName = "Asistencia";
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.Asistencia.Visible = true;
            this.Asistencia.VisibleIndex = 4;
            // 
            // repositoryItemRadioGroup1
            // 
            this.repositoryItemRadioGroup1.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem()});
            this.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1";
            // 
            // Atraso
            // 
            this.Atraso.Caption = "Atraso";
            this.Atraso.ColumnEdit = this.repositoryItemRadioGroup1;
            this.Atraso.Name = "Atraso";
            this.Atraso.Visible = true;
            this.Atraso.VisibleIndex = 5;
            // 
            // Falta
            // 
            this.Falta.Caption = "Falta";
            this.Falta.ColumnEdit = this.repositoryItemRadioGroup1;
            this.Falta.Name = "Falta";
            this.Falta.Visible = true;
            this.Falta.VisibleIndex = 6;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gcAsistencia
            // 
            this.gcAsistencia.Controls.Add(this.gdcAsistencia);
            this.gcAsistencia.Location = new System.Drawing.Point(22, 172);
            this.gcAsistencia.Name = "gcAsistencia";
            this.gcAsistencia.Size = new System.Drawing.Size(713, 215);
            this.gcAsistencia.TabIndex = 58;
            this.gcAsistencia.Text = "Asistencia";
            // 
            // dbDepartamento
            // 
            this.dbDepartamento.Location = new System.Drawing.Point(115, 70);
            this.dbDepartamento.Name = "dbDepartamento";
            this.dbDepartamento.Size = new System.Drawing.Size(158, 23);
            this.dbDepartamento.TabIndex = 60;
            this.dbDepartamento.Text = "RRHH";
            // 
            // lbDepartamento
            // 
            this.lbDepartamento.Location = new System.Drawing.Point(31, 70);
            this.lbDepartamento.Name = "lbDepartamento";
            this.lbDepartamento.Size = new System.Drawing.Size(73, 13);
            this.lbDepartamento.TabIndex = 59;
            this.lbDepartamento.Text = "Departamento:";
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
            this.txtNumero.Location = new System.Drawing.Point(115, 44);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 20);
            this.txtNumero.TabIndex = 76;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(250, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 77;
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
            // lblPUsuario
            // 
            this.lblPUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUsuario.Location = new System.Drawing.Point(65, 411);
            this.lblPUsuario.Name = "lblPUsuario";
            this.lblPUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblPUsuario.TabIndex = 80;
            this.lblPUsuario.Text = "María Perez";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(11, 411);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 79;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmProcesoTrabajoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 436);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.dbDepartamento);
            this.Controls.Add(this.lbDepartamento);
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
            this.Text = "frmProcesoTrabajoDiario";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRadioGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcAsistencia)).EndInit();
            this.gcAsistencia.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private DevExpress.XtraGrid.GridControl gdcAsistencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn Empleado;
        private DevExpress.XtraGrid.Columns.GridColumn Departamento;
        private DevExpress.XtraGrid.Columns.GridColumn Cargo;
        private DevExpress.XtraEditors.GroupControl gcAsistencia;
        private DevExpress.XtraEditors.DropDownButton dbDepartamento;
        private DevExpress.XtraEditors.LabelControl lbDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn Asistencia;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup repositoryItemRadioGroup1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.Label lblObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn Atraso;
        private DevExpress.XtraGrid.Columns.GridColumn Falta;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblPUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;


    }
}