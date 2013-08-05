namespace forms.ActivoFijo.Mantenimiento
{
    partial class mntCodigoBarra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mntCodigoBarra));
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.btneCodigoInterno = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCodigoInterno = new DevExpress.XtraEditors.LabelControl();
            this.lblFormato = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.pictResponsable = new DevExpress.XtraEditors.PictureEdit();
            this.gbxSentidoLectura = new System.Windows.Forms.GroupBox();
            this.cbVertical = new System.Windows.Forms.RadioButton();
            this.rbHorizontal = new System.Windows.Forms.RadioButton();
            this.txtMargenInf = new DevExpress.XtraEditors.TextEdit();
            this.lblMargenInferior = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.lblMargenSuperior = new DevExpress.XtraEditors.LabelControl();
            this.txtAlto = new DevExpress.XtraEditors.TextEdit();
            this.lblAlto = new DevExpress.XtraEditors.LabelControl();
            this.txtAncho = new DevExpress.XtraEditors.TextEdit();
            this.lblAncho = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtFormato = new DevExpress.XtraEditors.TextEdit();
            this.dtFormato = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneCodigoInterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).BeginInit();
            this.gbxSentidoLectura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargenInf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAncho.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormato.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFormato.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFormato.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(289, 56);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 140;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(222, 59);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 139;
            this.lblFecha.Text = "Fecha:";
            // 
            // btneCodigoInterno
            // 
            this.btneCodigoInterno.EditValue = "00-001";
            this.btneCodigoInterno.Enabled = false;
            this.btneCodigoInterno.Location = new System.Drawing.Point(69, 56);
            this.btneCodigoInterno.Name = "btneCodigoInterno";
            this.btneCodigoInterno.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btneCodigoInterno.Properties.Appearance.Options.UseBackColor = true;
            this.btneCodigoInterno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneCodigoInterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btneCodigoInterno.Size = new System.Drawing.Size(80, 20);
            this.btneCodigoInterno.TabIndex = 138;
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.Location = new System.Drawing.Point(19, 59);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(37, 13);
            this.lblCodigoInterno.TabIndex = 137;
            this.lblCodigoInterno.Text = "Codigo:";
            // 
            // lblFormato
            // 
            this.lblFormato.Location = new System.Drawing.Point(19, 209);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(44, 13);
            this.lblFormato.TabIndex = 136;
            this.lblFormato.Text = "Formato:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGenerar.Location = new System.Drawing.Point(276, 282);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 23);
            this.btnGenerar.TabIndex = 125;
            this.btnGenerar.Text = "Cargar Formato";
            // 
            // pictResponsable
            // 
            this.pictResponsable.EditValue = ((object)(resources.GetObject("pictResponsable.EditValue")));
            this.pictResponsable.Location = new System.Drawing.Point(19, 232);
            this.pictResponsable.Name = "pictResponsable";
            this.pictResponsable.Size = new System.Drawing.Size(241, 111);
            this.pictResponsable.TabIndex = 135;
            // 
            // gbxSentidoLectura
            // 
            this.gbxSentidoLectura.Controls.Add(this.cbVertical);
            this.gbxSentidoLectura.Controls.Add(this.rbHorizontal);
            this.gbxSentidoLectura.Location = new System.Drawing.Point(19, 150);
            this.gbxSentidoLectura.Name = "gbxSentidoLectura";
            this.gbxSentidoLectura.Size = new System.Drawing.Size(371, 47);
            this.gbxSentidoLectura.TabIndex = 134;
            this.gbxSentidoLectura.TabStop = false;
            this.gbxSentidoLectura.Text = "Sentido Lectura";
            // 
            // cbVertical
            // 
            this.cbVertical.AutoSize = true;
            this.cbVertical.Location = new System.Drawing.Point(91, 19);
            this.cbVertical.Name = "cbVertical";
            this.cbVertical.Size = new System.Drawing.Size(60, 17);
            this.cbVertical.TabIndex = 110;
            this.cbVertical.TabStop = true;
            this.cbVertical.Text = "Vertical";
            this.cbVertical.UseVisualStyleBackColor = true;
            // 
            // rbHorizontal
            // 
            this.rbHorizontal.AutoSize = true;
            this.rbHorizontal.Location = new System.Drawing.Point(206, 19);
            this.rbHorizontal.Name = "rbHorizontal";
            this.rbHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rbHorizontal.TabIndex = 111;
            this.rbHorizontal.TabStop = true;
            this.rbHorizontal.Text = "Horizontal";
            this.rbHorizontal.UseVisualStyleBackColor = true;
            // 
            // txtMargenInf
            // 
            this.txtMargenInf.Location = new System.Drawing.Point(289, 115);
            this.txtMargenInf.Name = "txtMargenInf";
            this.txtMargenInf.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtMargenInf.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMargenInf.Properties.Appearance.Options.UseBackColor = true;
            this.txtMargenInf.Properties.Appearance.Options.UseForeColor = true;
            this.txtMargenInf.Size = new System.Drawing.Size(101, 20);
            this.txtMargenInf.TabIndex = 133;
            // 
            // lblMargenInferior
            // 
            this.lblMargenInferior.Location = new System.Drawing.Point(225, 118);
            this.lblMargenInferior.Name = "lblMargenInferior";
            this.lblMargenInferior.Size = new System.Drawing.Size(54, 13);
            this.lblMargenInferior.TabIndex = 132;
            this.lblMargenInferior.Text = "MargenInf:";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(289, 89);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Size = new System.Drawing.Size(101, 20);
            this.textEdit1.TabIndex = 131;
            // 
            // lblMargenSuperior
            // 
            this.lblMargenSuperior.Location = new System.Drawing.Point(225, 92);
            this.lblMargenSuperior.Name = "lblMargenSuperior";
            this.lblMargenSuperior.Size = new System.Drawing.Size(58, 13);
            this.lblMargenSuperior.TabIndex = 130;
            this.lblMargenSuperior.Text = "MargenSup:";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(69, 115);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAlto.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAlto.Properties.Appearance.Options.UseBackColor = true;
            this.txtAlto.Properties.Appearance.Options.UseForeColor = true;
            this.txtAlto.Size = new System.Drawing.Size(101, 20);
            this.txtAlto.TabIndex = 129;
            // 
            // lblAlto
            // 
            this.lblAlto.Location = new System.Drawing.Point(19, 118);
            this.lblAlto.Name = "lblAlto";
            this.lblAlto.Size = new System.Drawing.Size(23, 13);
            this.lblAlto.TabIndex = 128;
            this.lblAlto.Text = "Alto:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(69, 89);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtAncho.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAncho.Properties.Appearance.Options.UseBackColor = true;
            this.txtAncho.Properties.Appearance.Options.UseForeColor = true;
            this.txtAncho.Size = new System.Drawing.Size(101, 20);
            this.txtAncho.TabIndex = 127;
            // 
            // lblAncho
            // 
            this.lblAncho.Location = new System.Drawing.Point(19, 92);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(34, 13);
            this.lblAncho.TabIndex = 126;
            this.lblAncho.Text = "Ancho:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnConsultar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(404, 25);
            this.toolStrip1.TabIndex = 124;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtFormato
            // 
            this.txtFormato.Enabled = false;
            this.txtFormato.Location = new System.Drawing.Point(222, 206);
            this.txtFormato.Name = "txtFormato";
            this.txtFormato.Size = new System.Drawing.Size(122, 20);
            this.txtFormato.TabIndex = 142;
            // 
            // dtFormato
            // 
            this.dtFormato.EditValue = null;
            this.dtFormato.Location = new System.Drawing.Point(69, 206);
            this.dtFormato.Name = "dtFormato";
            this.dtFormato.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFormato.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFormato.Size = new System.Drawing.Size(116, 20);
            this.dtFormato.TabIndex = 141;
            this.dtFormato.EditValueChanged += new System.EventHandler(this.dtFormato_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = global::forms.Properties.Resources.nuevo;
            this.simpleButton1.Location = new System.Drawing.Point(191, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(25, 23);
            this.simpleButton1.TabIndex = 143;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // mntCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 367);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtFormato);
            this.Controls.Add(this.dtFormato);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btneCodigoInterno);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.pictResponsable);
            this.Controls.Add(this.gbxSentidoLectura);
            this.Controls.Add(this.txtMargenInf);
            this.Controls.Add(this.lblMargenInferior);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.lblMargenSuperior);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.lblAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.toolStrip1);
            this.Name = "mntCodigoBarra";
            this.Text = "mntCodigoBarra";
            this.Load += new System.EventHandler(this.mntCodigoBarra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneCodigoInterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).EndInit();
            this.gbxSentidoLectura.ResumeLayout(false);
            this.gbxSentidoLectura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMargenInf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAncho.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormato.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFormato.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFormato.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.ButtonEdit btneCodigoInterno;
        private DevExpress.XtraEditors.LabelControl lblCodigoInterno;
        private DevExpress.XtraEditors.LabelControl lblFormato;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraEditors.PictureEdit pictResponsable;
        private System.Windows.Forms.GroupBox gbxSentidoLectura;
        private System.Windows.Forms.RadioButton cbVertical;
        private System.Windows.Forms.RadioButton rbHorizontal;
        private DevExpress.XtraEditors.TextEdit txtMargenInf;
        private DevExpress.XtraEditors.LabelControl lblMargenInferior;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl lblMargenSuperior;
        private DevExpress.XtraEditors.TextEdit txtAlto;
        private DevExpress.XtraEditors.LabelControl lblAlto;
        private DevExpress.XtraEditors.TextEdit txtAncho;
        private DevExpress.XtraEditors.LabelControl lblAncho;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtFormato;
        private DevExpress.XtraEditors.DateEdit dtFormato;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}