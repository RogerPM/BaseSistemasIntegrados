namespace forms.Compras
{
    partial class frmRptSolicitudes
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.grpControl2 = new DevExpress.XtraEditors.GroupControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.grpControl2)).BeginInit();
            this.grpControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(78, 167);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(129, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Generar Reporte";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // grpControl2
            // 
            this.grpControl2.Controls.Add(this.radioGroup1);
            this.grpControl2.Location = new System.Drawing.Point(31, 31);
            this.grpControl2.Name = "grpControl2";
            this.grpControl2.Size = new System.Drawing.Size(208, 110);
            this.grpControl2.TabIndex = 82;
            this.grpControl2.Text = "Seleccione el Reporte";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(5, 24);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Solicitudes"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Consolidaciones"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Cotizaciones"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Orden de Compra")});
            this.radioGroup1.Size = new System.Drawing.Size(198, 73);
            this.radioGroup1.TabIndex = 0;
            // 
            // frmRptSolicitudes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 217);
            this.Controls.Add(this.grpControl2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "frmRptSolicitudes";
            this.Text = "Consulta Generales";
            this.Load += new System.EventHandler(this.frmRptSolicitudes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpControl2)).EndInit();
            this.grpControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl grpControl2;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
    }
}