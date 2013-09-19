namespace forms.Inventario
{
    partial class frmReporteIngreso
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbEspecifico = new System.Windows.Forms.RadioButton();
            this.btnBuscarMovmiento = new DevExpress.XtraEditors.SimpleButton();
            this.txtNoMovimiento = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMovimiento.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(170, 88);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(59, 23);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Checked = true;
            this.rbGeneral.Location = new System.Drawing.Point(66, 31);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbGeneral.TabIndex = 2;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // rbEspecifico
            // 
            this.rbEspecifico.AutoSize = true;
            this.rbEspecifico.Location = new System.Drawing.Point(66, 54);
            this.rbEspecifico.Name = "rbEspecifico";
            this.rbEspecifico.Size = new System.Drawing.Size(74, 17);
            this.rbEspecifico.TabIndex = 2;
            this.rbEspecifico.TabStop = true;
            this.rbEspecifico.Text = "Especifico";
            this.rbEspecifico.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMovmiento
            // 
            this.btnBuscarMovmiento.Appearance.Options.UseImage = true;
            this.btnBuscarMovmiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarMovmiento.Location = new System.Drawing.Point(216, 51);
            this.btnBuscarMovmiento.Name = "btnBuscarMovmiento";
            this.btnBuscarMovmiento.Size = new System.Drawing.Size(33, 23);
            this.btnBuscarMovmiento.TabIndex = 86;
            this.btnBuscarMovmiento.Text = "...";
            this.btnBuscarMovmiento.Click += new System.EventHandler(this.btnBuscarMovmiento_Click);
            // 
            // txtNoMovimiento
            // 
            this.txtNoMovimiento.Location = new System.Drawing.Point(146, 53);
            this.txtNoMovimiento.Name = "txtNoMovimiento";
            this.txtNoMovimiento.Size = new System.Drawing.Size(64, 20);
            this.txtNoMovimiento.TabIndex = 85;
            // 
            // frmReporteIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 160);
            this.Controls.Add(this.btnBuscarMovmiento);
            this.Controls.Add(this.txtNoMovimiento);
            this.Controls.Add(this.rbEspecifico);
            this.Controls.Add(this.rbGeneral);
            this.Controls.Add(this.btnImprimir);
            this.Name = "frmReporteIngreso";
            this.Text = "Reporte Ingreso";
            ((System.ComponentModel.ISupportInitialize)(this.txtNoMovimiento.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbEspecifico;
        private DevExpress.XtraEditors.SimpleButton btnBuscarMovmiento;
        private DevExpress.XtraEditors.TextEdit txtNoMovimiento;
    }
}