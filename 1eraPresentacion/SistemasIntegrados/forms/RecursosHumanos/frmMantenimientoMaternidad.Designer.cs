namespace forms.RecursosHumanos
{
    partial class frmMantenimientoMaternidad
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
            this.lblEmpleado = new DevExpress.XtraEditors.LabelControl();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.lblNumero = new DevExpress.XtraEditors.LabelControl();
            this.lblInicioLicencia = new DevExpress.XtraEditors.LabelControl();
            this.lblFParto = new DevExpress.XtraEditors.LabelControl();
            this.lblFiniLicencia = new DevExpress.XtraEditors.LabelControl();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.deFParto = new DevExpress.XtraEditors.DateEdit();
            this.deInicioLicencia = new DevExpress.XtraEditors.DateEdit();
            this.deFinLicencia = new DevExpress.XtraEditors.DateEdit();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscarNumero = new DevExpress.XtraEditors.SimpleButton();
            this.estadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.deFModificacion = new DevExpress.XtraEditors.DateEdit();
            this.lblFechaModificacion = new DevExpress.XtraEditors.LabelControl();
            this.gluEmpleado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Apellido = new DevExpress.XtraGrid.Columns.GridColumn();
            
            this.cbeEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFParto.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFParto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicioLicencia.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicioLicencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinLicencia.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinLicencia.Properties)).BeginInit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.deFModificacion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFModificacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.Location = new System.Drawing.Point(52, 73);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblEmpleado.TabIndex = 58;
            this.lblEmpleado.Text = "Empleado:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(123, 38);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(69, 20);
            this.txtNumero.TabIndex = 57;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(61, 41);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(41, 13);
            this.lblNumero.TabIndex = 56;
            this.lblNumero.Text = "Número:";
            // 
            // lblInicioLicencia
            // 
            this.lblInicioLicencia.Location = new System.Drawing.Point(33, 137);
            this.lblInicioLicencia.Name = "lblInicioLicencia";
            this.lblInicioLicencia.Size = new System.Drawing.Size(69, 13);
            this.lblInicioLicencia.TabIndex = 61;
            this.lblInicioLicencia.Text = "Inicio Licencia:";
            // 
            // lblFParto
            // 
            this.lblFParto.Location = new System.Drawing.Point(25, 104);
            this.lblFParto.Name = "lblFParto";
            this.lblFParto.Size = new System.Drawing.Size(77, 13);
            this.lblFParto.TabIndex = 62;
            this.lblFParto.Text = "Fecha de Parto:";
            // 
            // lblFiniLicencia
            // 
            this.lblFiniLicencia.Location = new System.Drawing.Point(44, 166);
            this.lblFiniLicencia.Name = "lblFiniLicencia";
            this.lblFiniLicencia.Size = new System.Drawing.Size(58, 13);
            this.lblFiniLicencia.TabIndex = 63;
            this.lblFiniLicencia.Text = "Fin Licencia:";
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(64, 218);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 64;
            this.lblEstado.Text = "Estado:";
            // 
            // deFParto
            // 
            this.deFParto.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFParto.Location = new System.Drawing.Point(123, 101);
            this.deFParto.Name = "deFParto";
            this.deFParto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFParto.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFParto.Size = new System.Drawing.Size(100, 20);
            this.deFParto.TabIndex = 76;
            // 
            // deInicioLicencia
            // 
            this.deInicioLicencia.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deInicioLicencia.Location = new System.Drawing.Point(123, 134);
            this.deInicioLicencia.Name = "deInicioLicencia";
            this.deInicioLicencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deInicioLicencia.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deInicioLicencia.Size = new System.Drawing.Size(100, 20);
            this.deInicioLicencia.TabIndex = 77;
            // 
            // deFinLicencia
            // 
            this.deFinLicencia.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFinLicencia.Location = new System.Drawing.Point(123, 163);
            this.deFinLicencia.Name = "deFinLicencia";
            this.deFinLicencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFinLicencia.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFinLicencia.Size = new System.Drawing.Size(100, 20);
            this.deFinLicencia.TabIndex = 78;
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
            this.tsMenu.Size = new System.Drawing.Size(325, 25);
            this.tsMenu.TabIndex = 85;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::forms.Properties.Resources.modificar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // btnBuscarNumero
            // 
            this.btnBuscarNumero.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscarNumero.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarNumero.Location = new System.Drawing.Point(199, 38);
            this.btnBuscarNumero.Name = "btnBuscarNumero";
            this.btnBuscarNumero.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarNumero.TabIndex = 79;
            this.btnBuscarNumero.Click += new System.EventHandler(this.btnBuscarNumero_Click_1);
            // 
            // estadoBindingSource
            // 
            this.estadoBindingSource.DataMember = "Estado";
            
            // 
            // tECADataSet3
            // 
            
            // 
            // deFModificacion
            // 
            this.deFModificacion.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFModificacion.Location = new System.Drawing.Point(123, 189);
            this.deFModificacion.Name = "deFModificacion";
            this.deFModificacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFModificacion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFModificacion.Size = new System.Drawing.Size(100, 20);
            this.deFModificacion.TabIndex = 88;
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.Location = new System.Drawing.Point(8, 192);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(94, 13);
            this.lblFechaModificacion.TabIndex = 87;
            this.lblFechaModificacion.Text = "Fecha Modificacion:";
            // 
            // gluEmpleado
            // 
            this.gluEmpleado.EditValue = "";
            this.gluEmpleado.Location = new System.Drawing.Point(123, 70);
            this.gluEmpleado.Name = "gluEmpleado";
            this.gluEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluEmpleado.Properties.DataSource = this.clsPersonaBindingSource;
            this.gluEmpleado.Properties.DisplayMember = "NombreRazonSocial";
            this.gluEmpleado.Properties.ValueMember = "IdPersona";
            this.gluEmpleado.Properties.View = this.gridView1;
            this.gluEmpleado.Size = new System.Drawing.Size(100, 20);
            this.gluEmpleado.TabIndex = 89;
            // 
            // clsPersonaBindingSource
            // 
            this.clsPersonaBindingSource.DataSource = typeof(clases.RecursosHumanos.clsPersona);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IdPersona,
            this.NombreRazonSocial,
            this.Apellido});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // IdPersona
            // 
            this.IdPersona.Caption = "IdPersona";
            this.IdPersona.FieldName = "IdPersona";
            this.IdPersona.Name = "IdPersona";
            this.IdPersona.Visible = true;
            this.IdPersona.VisibleIndex = 0;
            // 
            // NombreRazonSocial
            // 
            this.NombreRazonSocial.Caption = "NombreRazonSocial";
            this.NombreRazonSocial.FieldName = "NombreRazonSocial";
            this.NombreRazonSocial.Name = "NombreRazonSocial";
            this.NombreRazonSocial.Visible = true;
            this.NombreRazonSocial.VisibleIndex = 1;
            // 
            // Apellido
            // 
            this.Apellido.Caption = "Apellido";
            this.Apellido.FieldName = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.Visible = true;
            this.Apellido.VisibleIndex = 2;
            // 
            
            // 
            
            // 
            // estadoTableAdapter1
            // 
            
            // 
            // cbeEstado
            // 
            this.cbeEstado.Location = new System.Drawing.Point(123, 215);
            this.cbeEstado.Name = "cbeEstado";
            this.cbeEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEstado.Properties.Items.AddRange(new object[] {
            "Seleccionar Estado",
            "Activo",
            "Inactivo"});
            this.cbeEstado.Size = new System.Drawing.Size(100, 20);
            this.cbeEstado.TabIndex = 90;
            // 
            // frmMantenimientoMaternidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 274);
            this.Controls.Add(this.cbeEstado);
            this.Controls.Add(this.gluEmpleado);
            this.Controls.Add(this.deFModificacion);
            this.Controls.Add(this.lblFechaModificacion);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.btnBuscarNumero);
            this.Controls.Add(this.deFinLicencia);
            this.Controls.Add(this.deInicioLicencia);
            this.Controls.Add(this.deFParto);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFiniLicencia);
            this.Controls.Add(this.lblFParto);
            this.Controls.Add(this.lblInicioLicencia);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(341, 312);
            this.MinimumSize = new System.Drawing.Size(341, 312);
            this.Name = "frmMantenimientoMaternidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Maternidad";
            this.Load += new System.EventHandler(this.frmMantenimientoMaternidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFParto.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFParto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicioLicencia.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deInicioLicencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinLicencia.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFinLicencia.Properties)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoBindingSource)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.deFModificacion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFModificacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblEmpleado;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl lblNumero;
        private DevExpress.XtraEditors.LabelControl lblInicioLicencia;
        private DevExpress.XtraEditors.LabelControl lblFParto;
        private DevExpress.XtraEditors.LabelControl lblFiniLicencia;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.DateEdit deFParto;
        private DevExpress.XtraEditors.DateEdit deInicioLicencia;
        private DevExpress.XtraEditors.DateEdit deFinLicencia;
        private DevExpress.XtraEditors.SimpleButton btnBuscarNumero;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.DateEdit deFModificacion;
        private DevExpress.XtraEditors.LabelControl lblFechaModificacion;
        private DevExpress.XtraEditors.GridLookUpEdit gluEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn IdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn NombreRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn Apellido;
        
        private System.Windows.Forms.BindingSource estadoBindingSource;
        
        private System.Windows.Forms.BindingSource clsPersonaBindingSource;
        private DevExpress.XtraEditors.ComboBoxEdit cbeEstado;
    }
}