namespace forms.ActivoFijo
{
    partial class prcsBajasActivos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.pictBajaActivo = new DevExpress.XtraEditors.PictureEdit();
            this.gbxAsignacion = new System.Windows.Forms.GroupBox();
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.llbMotivo = new DevExpress.XtraEditors.LabelControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDetalle = new DevExpress.XtraEditors.LabelControl();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBajaActivo.Properties)).BeginInit();
            this.gbxAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnConsultar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Anular";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(142, 22);
            this.tslEnBlanco.Text = "                                             ";
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
            // pictBajaActivo
            // 
            this.pictBajaActivo.Location = new System.Drawing.Point(345, 172);
            this.pictBajaActivo.Name = "pictBajaActivo";
            this.pictBajaActivo.Size = new System.Drawing.Size(169, 111);
            this.pictBajaActivo.TabIndex = 19;
            // 
            // gbxAsignacion
            // 
            this.gbxAsignacion.Controls.Add(this.cbxGrupo);
            this.gbxAsignacion.Controls.Add(this.llbMotivo);
            this.gbxAsignacion.Controls.Add(this.richTextBox1);
            this.gbxAsignacion.Controls.Add(this.lblDetalle);
            this.gbxAsignacion.Location = new System.Drawing.Point(12, 172);
            this.gbxAsignacion.Name = "gbxAsignacion";
            this.gbxAsignacion.Size = new System.Drawing.Size(305, 111);
            this.gbxAsignacion.TabIndex = 18;
            this.gbxAsignacion.TabStop = false;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(138, 23);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Size = new System.Drawing.Size(112, 20);
            this.cbxGrupo.TabIndex = 29;
            // 
            // llbMotivo
            // 
            this.llbMotivo.Location = new System.Drawing.Point(30, 26);
            this.llbMotivo.Name = "llbMotivo";
            this.llbMotivo.Size = new System.Drawing.Size(36, 13);
            this.llbMotivo.TabIndex = 30;
            this.llbMotivo.Text = "Motivo:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(138, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 43);
            this.richTextBox1.TabIndex = 26;
            this.richTextBox1.Text = "";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Location = new System.Drawing.Point(27, 57);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(64, 13);
            this.lblDetalle.TabIndex = 25;
            this.lblDetalle.Text = "Observación:";
            // 
            // pnlCargar
            // 
            this.pnlCargar.Location = new System.Drawing.Point(12, 28);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(529, 138);
            this.pnlCargar.TabIndex = 17;
            this.pnlCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCargar_Paint);
            // 
            // prcsBajasActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 302);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictBajaActivo);
            this.Controls.Add(this.gbxAsignacion);
            this.Controls.Add(this.pnlCargar);
            this.Name = "prcsBajasActivos";
            this.Text = "prcsBajasActivos";
            this.Load += new System.EventHandler(this.prcsBajasActivos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBajaActivo.Properties)).EndInit();
            this.gbxAsignacion.ResumeLayout(false);
            this.gbxAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.PictureEdit pictBajaActivo;
        private System.Windows.Forms.GroupBox gbxAsignacion;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl llbMotivo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.LabelControl lblDetalle;
        private System.Windows.Forms.Panel pnlCargar;
    }
}