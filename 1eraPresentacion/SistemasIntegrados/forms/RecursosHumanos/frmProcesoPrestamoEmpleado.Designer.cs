namespace forms.RecursosHumanos
{
    partial class frmProcesoPrestamoEmpleado
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
            this.lblTotalPrestamo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblValorPrestamo = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTipoPrestamo = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dateEdit3 = new DevExpress.XtraEditors.DateEdit();
            this.btnBuscarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.txtGenerarTabla = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gdcPrestamo = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chePeriodo = new DevExpress.XtraEditors.CheckEdit();
            this.cmbTipoPrestamo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnNumero = new DevExpress.XtraEditors.SimpleButton();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.txtPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.lblPUsuario = new DevExpress.XtraEditors.LabelControl();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPrestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalPrestamo
            // 
            this.lblTotalPrestamo.AutoSize = true;
            this.lblTotalPrestamo.Location = new System.Drawing.Point(511, 329);
            this.lblTotalPrestamo.Name = "lblTotalPrestamo";
            this.lblTotalPrestamo.Size = new System.Drawing.Size(95, 13);
            this.lblTotalPrestamo.TabIndex = 51;
            this.lblTotalPrestamo.Text = "Total del Prestamo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(555, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 46;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(69, 56);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 43;
            this.lblNumero.Text = "Número:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(511, 99);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(85, 13);
            this.lblRegistro.TabIndex = 42;
            this.lblRegistro.Text = "Estado Registro:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(31, 230);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(88, 13);
            this.lblPeriodo.TabIndex = 34;
            this.lblPeriodo.Text = "Cantidad Periodo";
            // 
            // lblValorPrestamo
            // 
            this.lblValorPrestamo.AutoSize = true;
            this.lblValorPrestamo.Location = new System.Drawing.Point(39, 204);
            this.lblValorPrestamo.Name = "lblValorPrestamo";
            this.lblValorPrestamo.Size = new System.Drawing.Size(78, 13);
            this.lblValorPrestamo.TabIndex = 33;
            this.lblValorPrestamo.Text = "Valor Prestamo";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(46, 149);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 32;
            this.lblObservacion.Text = "Observación:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(57, 118);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 13);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Empleado :";
            // 
            // lblTipoPrestamo
            // 
            this.lblTipoPrestamo.AutoSize = true;
            this.lblTipoPrestamo.Location = new System.Drawing.Point(23, 89);
            this.lblTipoPrestamo.Name = "lblTipoPrestamo";
            this.lblTipoPrestamo.Size = new System.Drawing.Size(93, 13);
            this.lblTipoPrestamo.TabIndex = 30;
            this.lblTipoPrestamo.Text = "Tipo de Prestamo:";
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
            this.tsMenu.Size = new System.Drawing.Size(757, 25);
            this.tsMenu.TabIndex = 53;
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
            // dateEdit3
            // 
            this.dateEdit3.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.dateEdit3.Location = new System.Drawing.Point(610, 65);
            this.dateEdit3.Name = "dateEdit3";
            this.dateEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit3.Size = new System.Drawing.Size(100, 20);
            this.dateEdit3.TabIndex = 75;
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscarEmpleado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(201, 118);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarEmpleado.TabIndex = 76;
            // 
            // txtGenerarTabla
            // 
            this.txtGenerarTabla.Location = new System.Drawing.Point(72, 291);
            this.txtGenerarTabla.Name = "txtGenerarTabla";
            this.txtGenerarTabla.Size = new System.Drawing.Size(122, 30);
            this.txtGenerarTabla.TabIndex = 79;
            this.txtGenerarTabla.Text = "Generar Tabla de Pago";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(225, 204);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(7, 13);
            this.labelControl9.TabIndex = 80;
            this.labelControl9.Text = "$";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(618, 329);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(7, 13);
            this.labelControl1.TabIndex = 82;
            this.labelControl1.Text = "$";
            // 
            // gdcPrestamo
            // 
            this.gdcPrestamo.Location = new System.Drawing.Point(250, 206);
            this.gdcPrestamo.MainView = this.gridView1;
            this.gdcPrestamo.Name = "gdcPrestamo";
            this.gdcPrestamo.Size = new System.Drawing.Size(481, 102);
            this.gdcPrestamo.TabIndex = 83;
            this.gdcPrestamo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdColumn1,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gdcPrestamo;
            this.gridView1.Name = "gridView1";
            // 
            // grdColumn1
            // 
            this.grdColumn1.Caption = "Número Periodo";
            this.grdColumn1.Name = "grdColumn1";
            this.grdColumn1.Visible = true;
            this.grdColumn1.VisibleIndex = 0;
            this.grdColumn1.Width = 88;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Fecha Cobro (DD/MM/AA)";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 137;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Valor";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 95;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado Proceso";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 143;
            // 
            // chePeriodo
            // 
            this.chePeriodo.EditValue = true;
            this.chePeriodo.Location = new System.Drawing.Point(26, 256);
            this.chePeriodo.Name = "chePeriodo";
            this.chePeriodo.Properties.Caption = "Periodo Anual";
            this.chePeriodo.Size = new System.Drawing.Size(100, 19);
            this.chePeriodo.TabIndex = 84;
            // 
            // cmbTipoPrestamo
            // 
            this.cmbTipoPrestamo.Location = new System.Drawing.Point(132, 86);
            this.cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            this.cmbTipoPrestamo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(127, 20);
            this.cmbTipoPrestamo.TabIndex = 85;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(610, 96);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(127, 20);
            this.comboBoxEdit1.TabIndex = 86;
            // 
            // btnNumero
            // 
            this.btnNumero.Image = global::forms.Properties.Resources.consultar;
            this.btnNumero.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNumero.Location = new System.Drawing.Point(238, 53);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(23, 20);
            this.btnNumero.TabIndex = 87;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(132, 53);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 20);
            this.txtNumero.TabIndex = 88;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(132, 119);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(64, 20);
            this.txtId.TabIndex = 89;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(249, 20);
            this.txtNombre.TabIndex = 90;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(132, 146);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(347, 49);
            this.txtObservacion.TabIndex = 91;
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(132, 201);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(84, 20);
            this.txtPrestamo.TabIndex = 92;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Location = new System.Drawing.Point(132, 227);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(84, 20);
            this.txtPeriodo.TabIndex = 93;
            // 
            // txtTotalPrestamo
            // 
            this.txtTotalPrestamo.Location = new System.Drawing.Point(639, 326);
            this.txtTotalPrestamo.Name = "txtTotalPrestamo";
            this.txtTotalPrestamo.Size = new System.Drawing.Size(92, 20);
            this.txtTotalPrestamo.TabIndex = 94;
            // 
            // teHora
            // 
            this.teHora.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teHora.Location = new System.Drawing.Point(631, 368);
            this.teHora.Name = "teHora";
            this.teHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHora.Size = new System.Drawing.Size(100, 20);
            this.teHora.TabIndex = 98;
            // 
            // lblHora
            // 
            this.lblHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(595, 371);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 97;
            this.lblHora.Text = "Hora:";
            // 
            // lblPUsuario
            // 
            this.lblPUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUsuario.Location = new System.Drawing.Point(72, 375);
            this.lblPUsuario.Name = "lblPUsuario";
            this.lblPUsuario.Size = new System.Drawing.Size(56, 13);
            this.lblPUsuario.TabIndex = 96;
            this.lblPUsuario.Text = "María Perez";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(18, 375);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 95;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmProcesoPrestamoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 410);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblPUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtTotalPrestamo);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.cmbTipoPrestamo);
            this.Controls.Add(this.chePeriodo);
            this.Controls.Add(this.gdcPrestamo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtGenerarTabla);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.dateEdit3);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.lblTotalPrestamo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblValorPrestamo);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTipoPrestamo);
            this.Controls.Add(this.txtObservacion);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(773, 448);
            this.MinimumSize = new System.Drawing.Size(773, 448);
            this.Name = "frmProcesoPrestamoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos Empleado";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPrestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chePeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalPrestamo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblValorPrestamo;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTipoPrestamo;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.DateEdit dateEdit3;
        private DevExpress.XtraEditors.SimpleButton btnBuscarEmpleado;
        private DevExpress.XtraEditors.SimpleButton txtGenerarTabla;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gdcPrestamo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.CheckEdit chePeriodo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoPrestamo;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btnNumero;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.TextEdit txtPrestamo;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.TextEdit txtTotalPrestamo;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private DevExpress.XtraEditors.LabelControl lblPUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
    }
}