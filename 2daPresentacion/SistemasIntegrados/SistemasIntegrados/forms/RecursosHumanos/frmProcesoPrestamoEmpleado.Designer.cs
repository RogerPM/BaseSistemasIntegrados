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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtInteres = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtTotalPrestamo = new DevExpress.XtraEditors.TextEdit();
            this.txtPeriodo = new DevExpress.XtraEditors.TextEdit();
            this.txtPagos = new DevExpress.XtraEditors.TextEdit();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.btnNumero = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscarEmpleado = new DevExpress.XtraEditors.SimpleButton();
            this.deFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblTotalPrestamo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblct = new System.Windows.Forms.Label();
            this.lblde = new System.Windows.Forms.Label();
            this.lblcp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPagado = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrestamo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(594, 25);
            this.tsMenu.TabIndex = 53;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Enabled = false;
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
            this.tsbModificar.Enabled = false;
            this.tsbModificar.Image = global::forms.Properties.Resources.modificar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(133, 251);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 155;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Enabled = false;
            this.labelControl3.Location = new System.Drawing.Point(239, 183);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(13, 13);
            this.labelControl3.TabIndex = 154;
            this.labelControl3.Text = "%";
            // 
            // txtInteres
            // 
            this.txtInteres.EditValue = "";
            this.txtInteres.Location = new System.Drawing.Point(133, 180);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(92, 20);
            this.txtInteres.TabIndex = 153;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 152;
            this.label1.Text = "Interes :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Enabled = false;
            this.labelControl2.Location = new System.Drawing.Point(239, 151);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(7, 13);
            this.labelControl2.TabIndex = 151;
            this.labelControl2.Text = "$";
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.Location = new System.Drawing.Point(133, 148);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(92, 20);
            this.txtPrestamo.TabIndex = 150;
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(59, 155);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(57, 13);
            this.lblPrestamo.TabIndex = 149;
            this.lblPrestamo.Text = "Prestamo :";
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(70, 93);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(46, 13);
            this.lblCedula.TabIndex = 148;
            this.lblCedula.Text = "Cedula :";
            // 
            // txtTotalPrestamo
            // 
            this.txtTotalPrestamo.Enabled = false;
            this.txtTotalPrestamo.Location = new System.Drawing.Point(419, 180);
            this.txtTotalPrestamo.Name = "txtTotalPrestamo";
            this.txtTotalPrestamo.Size = new System.Drawing.Size(84, 20);
            this.txtTotalPrestamo.TabIndex = 147;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.EditValue = "";
            this.txtPeriodo.Location = new System.Drawing.Point(133, 208);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(108, 20);
            this.txtPeriodo.TabIndex = 146;
            // 
            // txtPagos
            // 
            this.txtPagos.Enabled = false;
            this.txtPagos.Location = new System.Drawing.Point(419, 152);
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.Size = new System.Drawing.Size(84, 20);
            this.txtPagos.TabIndex = 145;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(133, 92);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(129, 20);
            this.txtCedula.TabIndex = 144;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(133, 122);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(394, 20);
            this.txtNombre.TabIndex = 143;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(133, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(92, 20);
            this.txtNumero.TabIndex = 142;
            // 
            // btnNumero
            // 
            this.btnNumero.Image = global::forms.Properties.Resources.consultar;
            this.btnNumero.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnNumero.Location = new System.Drawing.Point(239, 66);
            this.btnNumero.Name = "btnNumero";
            this.btnNumero.Size = new System.Drawing.Size(23, 20);
            this.btnNumero.TabIndex = 141;
            this.btnNumero.Click += new System.EventHandler(this.btnNumero_Click_1);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(407, 94);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "--Seleccione un estado",
            "Aprobado",
            "Espera",
            "Finalizado",
            "Anulado"});
            this.cmbEstado.Size = new System.Drawing.Size(120, 20);
            this.cmbEstado.TabIndex = 140;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Enabled = false;
            this.labelControl1.Location = new System.Drawing.Point(520, 183);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(7, 13);
            this.labelControl1.TabIndex = 139;
            this.labelControl1.Text = "$";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Enabled = false;
            this.labelControl9.Location = new System.Drawing.Point(515, 155);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(7, 13);
            this.labelControl9.TabIndex = 138;
            this.labelControl9.Text = "$";
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscarEmpleado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(277, 90);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarEmpleado.TabIndex = 137;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // deFecha
            // 
            this.deFecha.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFecha.Enabled = false;
            this.deFecha.Location = new System.Drawing.Point(407, 66);
            this.deFecha.Name = "deFecha";
            this.deFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFecha.Size = new System.Drawing.Size(120, 20);
            this.deFecha.TabIndex = 136;
            // 
            // lblTotalPrestamo
            // 
            this.lblTotalPrestamo.AutoSize = true;
            this.lblTotalPrestamo.Location = new System.Drawing.Point(327, 187);
            this.lblTotalPrestamo.Name = "lblTotalPrestamo";
            this.lblTotalPrestamo.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPrestamo.TabIndex = 135;
            this.lblTotalPrestamo.Text = "Total a Pagar:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(361, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 134;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(70, 69);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 133;
            this.lblNumero.Text = "Número:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(316, 97);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(85, 13);
            this.lblEstado.TabIndex = 132;
            this.lblEstado.Text = "Estado Registro:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(30, 211);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(89, 13);
            this.lblPeriodo.TabIndex = 131;
            this.lblPeriodo.Text = "PeriodoMensual :";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(358, 155);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(43, 13);
            this.lblPagos.TabIndex = 130;
            this.lblPagos.Text = "Pagos :";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(56, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(60, 13);
            this.lblNombre.TabIndex = 129;
            this.lblNombre.Text = "Empleado :";
            // 
            // lblct
            // 
            this.lblct.AutoSize = true;
            this.lblct.Location = new System.Drawing.Point(458, 240);
            this.lblct.Name = "lblct";
            this.lblct.Size = new System.Drawing.Size(13, 13);
            this.lblct.TabIndex = 163;
            this.lblct.Text = "0";
            // 
            // lblde
            // 
            this.lblde.AutoSize = true;
            this.lblde.Location = new System.Drawing.Point(440, 240);
            this.lblde.Name = "lblde";
            this.lblde.Size = new System.Drawing.Size(12, 13);
            this.lblde.TabIndex = 162;
            this.lblde.Text = "/";
            // 
            // lblcp
            // 
            this.lblcp.AutoSize = true;
            this.lblcp.Location = new System.Drawing.Point(421, 240);
            this.lblcp.Name = "lblcp";
            this.lblcp.Size = new System.Drawing.Size(13, 13);
            this.lblcp.TabIndex = 161;
            this.lblcp.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 160;
            this.label2.Text = "Numero de Cuotas :";
            // 
            // txtTotalPagado
            // 
            this.txtTotalPagado.Enabled = false;
            this.txtTotalPagado.Location = new System.Drawing.Point(419, 206);
            this.txtTotalPagado.Name = "txtTotalPagado";
            this.txtTotalPagado.Size = new System.Drawing.Size(84, 20);
            this.txtTotalPagado.TabIndex = 166;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Enabled = false;
            this.labelControl4.Location = new System.Drawing.Point(520, 209);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(7, 13);
            this.labelControl4.TabIndex = 165;
            this.labelControl4.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 164;
            this.label3.Text = "Total Pagado :";
            // 
            // frmProcesoPrestamoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.txtTotalPagado);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblct);
            this.Controls.Add(this.lblde);
            this.Controls.Add(this.lblcp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtTotalPrestamo);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.txtPagos);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnNumero);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.deFecha);
            this.Controls.Add(this.lblTotalPrestamo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblPagos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tsMenu);
            this.MaximizeBox = false;
            this.Name = "frmProcesoPrestamoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos Empleado";
            this.Load += new System.EventHandler(this.frmProcesoPrestamoEmpleado_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrestamo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPagos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.Button btnCalcular;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtInteres;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPrestamo;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblCedula;
        private DevExpress.XtraEditors.TextEdit txtTotalPrestamo;
        private DevExpress.XtraEditors.TextEdit txtPeriodo;
        private DevExpress.XtraEditors.TextEdit txtPagos;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.SimpleButton btnNumero;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnBuscarEmpleado;
        private DevExpress.XtraEditors.DateEdit deFecha;
        private System.Windows.Forms.Label lblTotalPrestamo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblct;
        private System.Windows.Forms.Label lblde;
        private System.Windows.Forms.Label lblcp;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTotalPagado;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.Label label3;
    }
}