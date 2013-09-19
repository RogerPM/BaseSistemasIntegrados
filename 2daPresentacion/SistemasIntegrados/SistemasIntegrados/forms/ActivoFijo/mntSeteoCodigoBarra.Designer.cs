
namespace forms.ActivoFijo
{
    partial class mntSeteoCodigoBarra
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnSetear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btneCodigoInterno = new DevExpress.XtraEditors.ButtonEdit();
            this.lblCodigoInterno = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFormato = new DevExpress.XtraEditors.LabelControl();
            this.gbxFechaSeteo = new System.Windows.Forms.GroupBox();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.pictResponsable = new DevExpress.XtraEditors.PictureEdit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneCodigoInterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            this.gbxFechaSeteo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnSetear);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Location = new System.Drawing.Point(23, 128);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(133, 100);
            this.gbxBotones.TabIndex = 0;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Botones";
            // 
            // btnSetear
            // 
            this.btnSetear.Image = global::forms.Properties.Resources.modificar;
            this.btnSetear.Location = new System.Drawing.Point(25, 19);
            this.btnSetear.Name = "btnSetear";
            this.btnSetear.Size = new System.Drawing.Size(88, 25);
            this.btnSetear.TabIndex = 135;
            this.btnSetear.Text = "Setear";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(25, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btneCodigoInterno
            // 
            this.btneCodigoInterno.EditValue = "00-001";
            this.btneCodigoInterno.Enabled = false;
            this.btneCodigoInterno.Location = new System.Drawing.Point(90, 11);
            this.btneCodigoInterno.Name = "btneCodigoInterno";
            this.btneCodigoInterno.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.btneCodigoInterno.Properties.Appearance.Options.UseBackColor = true;
            this.btneCodigoInterno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneCodigoInterno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btneCodigoInterno.Size = new System.Drawing.Size(80, 20);
            this.btneCodigoInterno.TabIndex = 143;
            // 
            // lblCodigoInterno
            // 
            this.lblCodigoInterno.Location = new System.Drawing.Point(14, 14);
            this.lblCodigoInterno.Name = "lblCodigoInterno";
            this.lblCodigoInterno.Size = new System.Drawing.Size(37, 13);
            this.lblCodigoInterno.TabIndex = 142;
            this.lblCodigoInterno.Text = "Codigo:";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(311, 11);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 141;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(244, 14);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 140;
            this.labelControl2.Text = "Fecha:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.EditValue = "SJ11-002";
            this.cbxGrupo.Location = new System.Drawing.Point(90, 102);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.cbxGrupo.Properties.Appearance.Options.UseBackColor = true;
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGrupo.Size = new System.Drawing.Size(100, 20);
            this.cbxGrupo.TabIndex = 137;
            // 
            // lblFormato
            // 
            this.lblFormato.Location = new System.Drawing.Point(23, 109);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(44, 13);
            this.lblFormato.TabIndex = 138;
            this.lblFormato.Text = "Formato:";
            // 
            // gbxFechaSeteo
            // 
            this.gbxFechaSeteo.Controls.Add(this.dateEdit1);
            this.gbxFechaSeteo.Controls.Add(this.labelControl1);
            this.gbxFechaSeteo.Controls.Add(this.dtFecha);
            this.gbxFechaSeteo.Controls.Add(this.lblFecha);
            this.gbxFechaSeteo.Location = new System.Drawing.Point(12, 37);
            this.gbxFechaSeteo.Name = "gbxFechaSeteo";
            this.gbxFechaSeteo.Size = new System.Drawing.Size(433, 59);
            this.gbxFechaSeteo.TabIndex = 136;
            this.gbxFechaSeteo.TabStop = false;
            this.gbxFechaSeteo.Text = "FechaSeteo";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(78, 19);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 130;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 129;
            this.labelControl1.Text = "Desde:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(299, 19);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 128;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(232, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(32, 13);
            this.lblFecha.TabIndex = 127;
            this.lblFecha.Text = "Hasta:";
            // 
            // pictResponsable
            // 
            this.pictResponsable.EditValue = global::forms.Properties.Resources.Codigo_de_barras;
            this.pictResponsable.Location = new System.Drawing.Point(204, 102);
            this.pictResponsable.Name = "pictResponsable";
            this.pictResponsable.Size = new System.Drawing.Size(241, 111);
            this.pictResponsable.TabIndex = 139;
            // 
            // mntSeteoCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 238);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.btneCodigoInterno);
            this.Controls.Add(this.lblCodigoInterno);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictResponsable);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.gbxFechaSeteo);
            this.Name = "mntSeteoCodigoBarra";
            this.Text = "mntSeteoCodigoBarra";
            this.Load += new System.EventHandler(this.mntSeteoCodigoBarra_Load);
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btneCodigoInterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            this.gbxFechaSeteo.ResumeLayout(false);
            this.gbxFechaSeteo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private DevExpress.XtraEditors.SimpleButton btnSetear;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.ButtonEdit btneCodigoInterno;
        private DevExpress.XtraEditors.LabelControl lblCodigoInterno;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictResponsable;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblFormato;
        private System.Windows.Forms.GroupBox gbxFechaSeteo;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
    }
}