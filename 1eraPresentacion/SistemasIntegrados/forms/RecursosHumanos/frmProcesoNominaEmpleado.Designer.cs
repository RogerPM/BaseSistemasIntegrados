namespace forms.RecursosHumanos
{
    partial class frmProcesoNominaEmpleado
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
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.lblTotalAnticipo = new System.Windows.Forms.Label();
            this.lblTotalIngreso = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGenerarNomina = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnGenerarNomina = new DevExpress.XtraEditors.SimpleButton();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNomina = new DevExpress.XtraGrid.GridControl();
            this.cmbEstado = new DevExpress.XtraEditors.DateEdit();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.txtTotalPagar = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalAnticipo = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalIngresos = new DevExpress.XtraEditors.TextEdit();
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.lblPUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.cmbPeriodo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAnticipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalIngresos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(68, 347);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(85, 13);
            this.lblTotalPagar.TabIndex = 67;
            this.lblTotalPagar.Text = "Total A Pagar";
            // 
            // lblTotalAnticipo
            // 
            this.lblTotalAnticipo.AutoSize = true;
            this.lblTotalAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnticipo.Location = new System.Drawing.Point(278, 347);
            this.lblTotalAnticipo.Name = "lblTotalAnticipo";
            this.lblTotalAnticipo.Size = new System.Drawing.Size(92, 13);
            this.lblTotalAnticipo.TabIndex = 65;
            this.lblTotalAnticipo.Text = "Total Anticipos";
            // 
            // lblTotalIngreso
            // 
            this.lblTotalIngreso.AutoSize = true;
            this.lblTotalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngreso.Location = new System.Drawing.Point(494, 347);
            this.lblTotalIngreso.Name = "lblTotalIngreso";
            this.lblTotalIngreso.Size = new System.Drawing.Size(82, 13);
            this.lblTotalIngreso.TabIndex = 63;
            this.lblTotalIngreso.Text = "Total Ingreso";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(494, 68);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(102, 13);
            this.lblEstado.TabIndex = 58;
            this.lblEstado.Text = "Estado del Proceso:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(553, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 55;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(52, 44);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 53;
            this.lblNumero.Text = "Número:";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(26, 93);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 51;
            this.lblObservacion.Text = "Observación:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(52, 68);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(46, 13);
            this.lblPeriodo.TabIndex = 46;
            this.lblPeriodo.Text = "Periodo:";
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGenerarNomina,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(721, 25);
            this.tsMenu.TabIndex = 69;
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
            // tsbGenerarNomina
            // 
            this.tsbGenerarNomina.Image = global::forms.Properties.Resources.guardar;
            this.tsbGenerarNomina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerarNomina.Name = "tsbGenerarNomina";
            this.tsbGenerarNomina.Size = new System.Drawing.Size(114, 22);
            this.tsbGenerarNomina.Text = "Generar Nomina";
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
            // btnGenerarNomina
            // 
            this.btnGenerarNomina.Location = new System.Drawing.Point(310, 152);
            this.btnGenerarNomina.Name = "btnGenerarNomina";
            this.btnGenerarNomina.Size = new System.Drawing.Size(122, 30);
            this.btnGenerarNomina.TabIndex = 70;
            this.btnGenerarNomina.Text = "Generar Nómina";
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
            this.gridColumn2.Caption = "Total a Recibir";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 77;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Valor Sueldo y Salario";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 114;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Valor Transporte";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 105;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Valor Fondo de Reserva";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 124;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Valor Adicional";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 109;
            // 
            // gcNomina
            // 
            this.gcNomina.Location = new System.Drawing.Point(12, 199);
            this.gcNomina.MainView = this.gridView1;
            this.gcNomina.Name = "gcNomina";
            this.gcNomina.Size = new System.Drawing.Size(693, 129);
            this.gcNomina.TabIndex = 71;
            this.gcNomina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cmbEstado
            // 
            this.cmbEstado.EditValue = null;
            this.cmbEstado.Location = new System.Drawing.Point(605, 66);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbEstado.Size = new System.Drawing.Size(100, 20);
            this.cmbEstado.TabIndex = 73;
            // 
            // deFecha
            // 
            this.deFecha.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFecha.Location = new System.Drawing.Point(605, 36);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(100, 20);
            this.deFecha.TabIndex = 74;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(222, 36);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 75;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(71, 20);
            this.txtCodigo.TabIndex = 76;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(120, 92);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(585, 54);
            this.txtObservacion.TabIndex = 77;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(174, 341);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(71, 20);
            this.txtTotalPagar.TabIndex = 78;
            // 
            // txtTotalAnticipo
            // 
            this.txtTotalAnticipo.Location = new System.Drawing.Point(376, 344);
            this.txtTotalAnticipo.Name = "txtTotalAnticipo";
            this.txtTotalAnticipo.Size = new System.Drawing.Size(71, 20);
            this.txtTotalAnticipo.TabIndex = 79;
            // 
            // txtTotalIngresos
            // 
            this.txtTotalIngresos.Location = new System.Drawing.Point(582, 344);
            this.txtTotalIngresos.Name = "txtTotalIngresos";
            this.txtTotalIngresos.Size = new System.Drawing.Size(71, 20);
            this.txtTotalIngresos.TabIndex = 80;
            // 
            // teHora
            // 
            this.teHora.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teHora.Location = new System.Drawing.Point(609, 389);
            this.teHora.Name = "teHora";
            this.teHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHora.Size = new System.Drawing.Size(100, 20);
            this.teHora.TabIndex = 84;
            // 
            // lblHora
            // 
            this.lblHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(573, 392);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 83;
            this.lblHora.Text = "Hora:";
            // 
            // lblPUsuario
            // 
            this.lblPUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUsuario.Location = new System.Drawing.Point(71, 396);
            this.lblPUsuario.Name = "lblPUsuario";
            this.lblPUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblPUsuario.TabIndex = 82;
            this.lblPUsuario.Text = "María Perez";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(17, 396);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 81;
            this.lblUsuario.Text = "Usuario:";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Location = new System.Drawing.Point(118, 63);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPeriodo.Size = new System.Drawing.Size(127, 20);
            this.cmbPeriodo.TabIndex = 85;
            // 
            // frmProcesoNominaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 414);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtTotalIngresos);
            this.Controls.Add(this.txtTotalAnticipo);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.gcNomina);
            this.Controls.Add(this.btnGenerarNomina);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblTotalAnticipo);
            this.Controls.Add(this.lblTotalIngreso);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.txtObservacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(737, 452);
            this.MinimumSize = new System.Drawing.Size(737, 452);
            this.Name = "frmProcesoNominaEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina Empleado";
            this.Load += new System.EventHandler(this.frmNominaEmpleado_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalAnticipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalIngresos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPeriodo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label lblTotalAnticipo;
        private System.Windows.Forms.Label lblTotalIngreso;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGenerarNomina;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.SimpleButton btnGenerarNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gcNomina;
        private DevExpress.XtraEditors.DateEdit cmbEstado;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.TextEdit txtTotalPagar;
        private DevExpress.XtraEditors.TextEdit txtTotalAnticipo;
        private DevExpress.XtraEditors.TextEdit txtTotalIngresos;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblPUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPeriodo;
    }
}