namespace forms.RecursosHumanos
{
    partial class frmProcesoAnticiposEmpleado
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
            this.tsbGenerar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblTotalAnticipo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblTipoAnticipo = new System.Windows.Forms.Label();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNomina = new DevExpress.XtraGrid.GridControl();
            this.btnGenerarNom = new DevExpress.XtraEditors.SimpleButton();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.cmbTipoAnticipo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalAnticipo = new DevExpress.XtraEditors.TextEdit();
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.lblPUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoAnticipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAnticipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGenerar,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(759, 25);
            this.tsMenu.TabIndex = 22;
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
            // tsbGenerar
            // 
            this.tsbGenerar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerar.Name = "tsbGenerar";
            this.tsbGenerar.Size = new System.Drawing.Size(116, 22);
            this.tsbGenerar.Text = "Generar Anticipo";
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
            // lblTotalAnticipo
            // 
            this.lblTotalAnticipo.AutoSize = true;
            this.lblTotalAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnticipo.Location = new System.Drawing.Point(550, 397);
            this.lblTotalAnticipo.Name = "lblTotalAnticipo";
            this.lblTotalAnticipo.Size = new System.Drawing.Size(92, 13);
            this.lblTotalAnticipo.TabIndex = 35;
            this.lblTotalAnticipo.Text = "Total Anticipos";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblEstado.Location = new System.Drawing.Point(437, 87);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(104, 13);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado del Registro:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblFecha.Location = new System.Drawing.Point(501, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 29;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblNumero.Location = new System.Drawing.Point(75, 54);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(48, 13);
            this.lblNumero.TabIndex = 27;
            this.lblNumero.Text = "Numero:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblObservacion.Location = new System.Drawing.Point(52, 124);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(71, 13);
            this.lblObservacion.TabIndex = 25;
            this.lblObservacion.Text = "Observación:";
            // 
            // lblTipoAnticipo
            // 
            this.lblTipoAnticipo.AutoSize = true;
            this.lblTipoAnticipo.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lblTipoAnticipo.Location = new System.Drawing.Point(51, 81);
            this.lblTipoAnticipo.Name = "lblTipoAnticipo";
            this.lblTipoAnticipo.Size = new System.Drawing.Size(72, 13);
            this.lblTipoAnticipo.TabIndex = 23;
            this.lblTipoAnticipo.Text = "Tipo Anticipo:";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColumn1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.gcNomina;
            this.gridView1.Name = "gridView1";
            // 
            // grdColumn1
            // 
            this.grdColumn1.Caption = "Codigo";
            this.grdColumn1.Name = "grdColumn1";
            this.grdColumn1.Visible = true;
            this.grdColumn1.VisibleIndex = 0;
            this.grdColumn1.Width = 69;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Nombres Empleado";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 102;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Observación";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 102;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha Cobro (DD/MM/AA)";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 137;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Total Anticipo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 91;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Valor Anticipo";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 91;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Estado Proceso";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 108;
            // 
            // gcNomina
            // 
            this.gcNomina.Location = new System.Drawing.Point(29, 217);
            this.gcNomina.MainView = this.gridView1;
            this.gcNomina.Name = "gcNomina";
            this.gcNomina.Size = new System.Drawing.Size(718, 158);
            this.gcNomina.TabIndex = 37;
            this.gcNomina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcNomina.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // btnGenerarNom
            // 
            this.btnGenerarNom.Location = new System.Drawing.Point(323, 181);
            this.btnGenerarNom.Name = "btnGenerarNom";
            this.btnGenerarNom.Size = new System.Drawing.Size(122, 30);
            this.btnGenerarNom.TabIndex = 71;
            this.btnGenerarNom.Text = "Generar Nómina";
            this.btnGenerarNom.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // deFecha
            // 
            this.deFecha.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFecha.Location = new System.Drawing.Point(575, 47);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(100, 20);
            this.deFecha.TabIndex = 75;
            this.deFecha.EditValueChanged += new System.EventHandler(this.dateEdit3_EditValueChanged);
            // 
            // cmbTipoAnticipo
            // 
            this.cmbTipoAnticipo.Location = new System.Drawing.Point(139, 84);
            this.cmbTipoAnticipo.Name = "cmbTipoAnticipo";
            this.cmbTipoAnticipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoAnticipo.Size = new System.Drawing.Size(127, 20);
            this.cmbTipoAnticipo.TabIndex = 76;
            this.cmbTipoAnticipo.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(139, 51);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(92, 20);
            this.txtCodigo.TabIndex = 77;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(139, 121);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(536, 54);
            this.txtObservacion.TabIndex = 78;
            this.txtObservacion.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(575, 84);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Size = new System.Drawing.Size(127, 20);
            this.cmbEstado.TabIndex = 79;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(243, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 80;
            // 
            // txtTotalAnticipo
            // 
            this.txtTotalAnticipo.Location = new System.Drawing.Point(655, 394);
            this.txtTotalAnticipo.Name = "txtTotalAnticipo";
            this.txtTotalAnticipo.Size = new System.Drawing.Size(92, 20);
            this.txtTotalAnticipo.TabIndex = 81;
            this.txtTotalAnticipo.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // teHora
            // 
            this.teHora.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teHora.Location = new System.Drawing.Point(647, 439);
            this.teHora.Name = "teHora";
            this.teHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHora.Size = new System.Drawing.Size(100, 20);
            this.teHora.TabIndex = 85;
            // 
            // lblHora
            // 
            this.lblHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(611, 442);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 84;
            this.lblHora.Text = "Hora:";
            // 
            // lblPUsuario
            // 
            this.lblPUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUsuario.Location = new System.Drawing.Point(55, 442);
            this.lblPUsuario.Name = "lblPUsuario";
            this.lblPUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblPUsuario.TabIndex = 83;
            this.lblPUsuario.Text = "María Perez";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1, 442);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 82;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmProcesoAnticiposEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 467);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtTotalAnticipo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbTipoAnticipo);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.btnGenerarNom);
            this.Controls.Add(this.gcNomina);
            this.Controls.Add(this.lblTotalAnticipo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblTipoAnticipo);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.txtObservacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(775, 505);
            this.MinimumSize = new System.Drawing.Size(775, 505);
            this.Name = "frmProcesoAnticiposEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anticipos Empleado";
            this.Load += new System.EventHandler(this.frmProcesoAnticiposEmpleado_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoAnticipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAnticipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGenerar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.Label lblTotalAnticipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblTipoAnticipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gcNomina;
        private DevExpress.XtraEditors.SimpleButton btnGenerarNom;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoAnticipo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtTotalAnticipo;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblPUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
    }
}