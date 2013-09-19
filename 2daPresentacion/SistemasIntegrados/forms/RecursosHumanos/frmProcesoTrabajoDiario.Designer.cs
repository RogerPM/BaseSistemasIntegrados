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
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarCedula = new DevExpress.XtraEditors.SimpleButton();
            this.txtNombres = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtApellidos = new DevExpress.XtraEditors.TextEdit();
            this.lblCedula = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.lblApellido = new DevExpress.XtraEditors.LabelControl();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.deDesde = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teIngreso = new DevExpress.XtraEditors.TimeEdit();
            this.teSalida = new DevExpress.XtraEditors.TimeEdit();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.deHasta = new DevExpress.XtraEditors.DateEdit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(367, 25);
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
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(77, 64);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 55;
            this.lblNumero.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(162, 64);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(110, 20);
            this.txtNumero.TabIndex = 76;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(314, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 77;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnBuscarCedula
            // 
            this.btnBuscarCedula.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscarCedula.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarCedula.Location = new System.Drawing.Point(314, 90);
            this.btnBuscarCedula.Name = "btnBuscarCedula";
            this.btnBuscarCedula.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarCedula.TabIndex = 89;
            this.btnBuscarCedula.Click += new System.EventHandler(this.btnBuscarCedula_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(159, 144);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(178, 20);
            this.txtNombres.TabIndex = 88;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(25, 151);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 87;
            this.lblNombre.Text = "Nombres Completos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(159, 118);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(178, 20);
            this.txtApellidos.TabIndex = 86;
            // 
            // lblCedula
            // 
            this.lblCedula.Location = new System.Drawing.Point(53, 97);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(70, 13);
            this.lblCedula.TabIndex = 85;
            this.lblCedula.Text = "Cédula o RUC:";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(159, 90);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(113, 20);
            this.txtCedula.TabIndex = 84;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(25, 125);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(99, 13);
            this.lblApellido.TabIndex = 83;
            this.lblApellido.Text = "Apellidos Completos:";
            // 
            // lblFecha
            // 
            this.lblFecha.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(195, 185);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 13);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Hasta :";
            // 
            // deDesde
            // 
            this.deDesde.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deDesde.Location = new System.Drawing.Point(73, 182);
            this.deDesde.Name = "deDesde";
            this.deDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDesde.Size = new System.Drawing.Size(100, 20);
            this.deDesde.TabIndex = 91;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(25, 185);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 90;
            this.labelControl1.Text = "Desde :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(16, 223);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 94;
            this.labelControl2.Text = "Ingreso :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(194, 223);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 13);
            this.labelControl3.TabIndex = 92;
            this.labelControl3.Text = "Salida :";
            // 
            // teIngreso
            // 
            this.teIngreso.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teIngreso.Location = new System.Drawing.Point(73, 220);
            this.teIngreso.Name = "teIngreso";
            this.teIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teIngreso.Size = new System.Drawing.Size(100, 20);
            this.teIngreso.TabIndex = 95;
            // 
            // teSalida
            // 
            this.teSalida.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teSalida.Location = new System.Drawing.Point(237, 216);
            this.teSalida.Name = "teSalida";
            this.teSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teSalida.Size = new System.Drawing.Size(100, 20);
            this.teSalida.TabIndex = 96;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(17, 259);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 97;
            this.lblObservacion.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(93, 256);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(244, 50);
            this.txtObservacion.TabIndex = 98;
            // 
            // deHasta
            // 
            this.deHasta.EditValue = null;
            this.deHasta.Location = new System.Drawing.Point(240, 182);
            this.deHasta.Name = "deHasta";
            this.deHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deHasta.Size = new System.Drawing.Size(100, 20);
            this.deHasta.TabIndex = 99;
            // 
            // frmProcesoTrabajoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 342);
            this.Controls.Add(this.deHasta);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.teSalida);
            this.Controls.Add(this.teIngreso);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.deDesde);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnBuscarCedula);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tsMenu);
            this.MaximizeBox = false;
            this.Name = "frmProcesoTrabajoDiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajo Diario";
            this.Load += new System.EventHandler(this.frmProcesoTrabajoDiario_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deHasta.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.Label lblNumero;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCedula;
        private DevExpress.XtraEditors.TextEdit txtNombres;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtApellidos;
        private DevExpress.XtraEditors.LabelControl lblCedula;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.LabelControl lblApellido;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.DateEdit deDesde;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TimeEdit teIngreso;
        private DevExpress.XtraEditors.TimeEdit teSalida;
        private System.Windows.Forms.Label lblObservacion;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.DateEdit deHasta;


    }
}