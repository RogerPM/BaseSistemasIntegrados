namespace forms.ActivoFijo.Mantenimiento
{
    partial class mntDivicionCodBarra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetear = new DevExpress.XtraEditors.SimpleButton();
            this.btnCrear = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetear);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CodigoBarra";
            // 
            // btnSetear
            // 
            this.btnSetear.Image = global::forms.Properties.Resources.modificar;
            this.btnSetear.Location = new System.Drawing.Point(151, 42);
            this.btnSetear.Name = "btnSetear";
            this.btnSetear.Size = new System.Drawing.Size(88, 23);
            this.btnSetear.TabIndex = 48;
            this.btnSetear.Text = "Setear";
            this.btnSetear.Click += new System.EventHandler(this.btnSetear_Click_1);
            // 
            // btnCrear
            // 
            this.btnCrear.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnCrear.Location = new System.Drawing.Point(6, 42);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(98, 23);
            this.btnCrear.TabIndex = 47;
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // mntDivicionCodBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.groupBox1);
            this.Name = "mntDivicionCodBarra";
            this.Text = "mntDivicionCodBarra";
            this.Load += new System.EventHandler(this.mntDivicionCodBarra_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnSetear;
        private DevExpress.XtraEditors.SimpleButton btnCrear;
    }
}