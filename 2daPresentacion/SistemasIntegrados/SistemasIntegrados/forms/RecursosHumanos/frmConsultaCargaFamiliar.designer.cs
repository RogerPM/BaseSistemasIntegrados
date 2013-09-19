namespace forms.RecursosHumanos
{
    partial class frmConsultaCargaFamiliar
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
            this.gcEmpeladi = new DevExpress.XtraEditors.GroupControl();
            this.btnMenos = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.meEmpleado = new DevExpress.XtraEditors.MemoEdit();
            this.meEmpleado2 = new DevExpress.XtraEditors.MemoEdit();
            this.rgCriterio = new DevExpress.XtraEditors.RadioGroup();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbGenerar = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpeladi)).BeginInit();
            this.gcEmpeladi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meEmpleado2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriterio.Properties)).BeginInit();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcEmpeladi
            // 
            this.gcEmpeladi.Controls.Add(this.btnMenos);
            this.gcEmpeladi.Controls.Add(this.btnadd);
            this.gcEmpeladi.Controls.Add(this.meEmpleado);
            this.gcEmpeladi.Controls.Add(this.meEmpleado2);
            this.gcEmpeladi.Location = new System.Drawing.Point(13, 106);
            this.gcEmpeladi.Name = "gcEmpeladi";
            this.gcEmpeladi.Size = new System.Drawing.Size(402, 125);
            this.gcEmpeladi.TabIndex = 38;
            this.gcEmpeladi.Text = "Empleados";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(181, 65);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 23);
            this.btnMenos.TabIndex = 5;
            this.btnMenos.Text = "<<";
            this.btnMenos.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(181, 36);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(40, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = ">>";
            // 
            // meEmpleado
            // 
            this.meEmpleado.Location = new System.Drawing.Point(14, 24);
            this.meEmpleado.Name = "meEmpleado";
            this.meEmpleado.Size = new System.Drawing.Size(145, 95);
            this.meEmpleado.TabIndex = 3;
            // 
            // meEmpleado2
            // 
            this.meEmpleado2.Location = new System.Drawing.Point(244, 24);
            this.meEmpleado2.Name = "meEmpleado2";
            this.meEmpleado2.Size = new System.Drawing.Size(145, 95);
            this.meEmpleado2.TabIndex = 2;
            // 
            // rgCriterio
            // 
            this.rgCriterio.Location = new System.Drawing.Point(12, 34);
            this.rgCriterio.Name = "rgCriterio";
            this.rgCriterio.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Empleado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todos")});
            this.rgCriterio.Size = new System.Drawing.Size(403, 59);
            this.rgCriterio.TabIndex = 36;
            this.rgCriterio.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGenerar,
            this.tsbGuardar,
            this.tsbSalir});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(427, 25);
            this.tsMenu.TabIndex = 37;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbGenerar
            // 
            this.tsbGenerar.Image = global::forms.Properties.Resources.imprimir;
            this.tsbGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGenerar.Name = "tsbGenerar";
            this.tsbGenerar.Size = new System.Drawing.Size(68, 22);
            this.tsbGenerar.Text = "Generar";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Location = new System.Drawing.Point(267, 44);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 23);
            this.dropDownButton1.TabIndex = 39;
            // 
            // frmConsultaCargaFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 248);
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.gcEmpeladi);
            this.Controls.Add(this.rgCriterio);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmConsultaCargaFamiliar";
            this.Text = "Consulta de Cargas Familiares";
            this.Load += new System.EventHandler(this.frmConsultaCargaFamiliar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmpeladi)).EndInit();
            this.gcEmpeladi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meEmpleado2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgCriterio.Properties)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcEmpeladi;
        private DevExpress.XtraEditors.SimpleButton btnMenos;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.MemoEdit meEmpleado;
        private DevExpress.XtraEditors.MemoEdit meEmpleado2;
        private DevExpress.XtraEditors.RadioGroup rgCriterio;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbGenerar;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}