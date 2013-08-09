namespace forms.Contabilidad
{
    partial class FrmModeloAsiento
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransaccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecuencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.txthaber = new System.Windows.Forms.TextBox();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaccion:";
            // 
            // txtTransaccion
            // 
            this.txtTransaccion.Location = new System.Drawing.Point(137, 72);
            this.txtTransaccion.Name = "txtTransaccion";
            this.txtTransaccion.Size = new System.Drawing.Size(45, 20);
            this.txtTransaccion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modulo:";
            // 
            // txtModulo
            // 
            this.txtModulo.Location = new System.Drawing.Point(137, 109);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(45, 20);
            this.txtModulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Secuencia:";
            // 
            // txtSecuencia
            // 
            this.txtSecuencia.Location = new System.Drawing.Point(137, 151);
            this.txtSecuencia.Name = "txtSecuencia";
            this.txtSecuencia.ReadOnly = true;
            this.txtSecuencia.Size = new System.Drawing.Size(45, 20);
            this.txtSecuencia.TabIndex = 5;
            this.txtSecuencia.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(137, 192);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(222, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Debe:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Haber:";
            // 
            // txtDebe
            // 
            this.txtDebe.Location = new System.Drawing.Point(137, 232);
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(45, 20);
            this.txtDebe.TabIndex = 10;
            // 
            // txthaber
            // 
            this.txthaber.Location = new System.Drawing.Point(137, 274);
            this.txthaber.Name = "txthaber";
            this.txthaber.Size = new System.Drawing.Size(45, 20);
            this.txthaber.TabIndex = 11;
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(36, 25);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnuevo.TabIndex = 12;
            this.btnuevo.Text = "Grabar";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(299, 25);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(75, 23);
            this.btsalir.TabIndex = 13;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // FrmModeloAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 322);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.txthaber);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSecuencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTransaccion);
            this.Controls.Add(this.label1);
            this.Name = "FrmModeloAsiento";
            this.Text = "Modelo de Asiento";
            this.Load += new System.EventHandler(this.FrmModeloAsiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btsalir;
        public System.Windows.Forms.TextBox txtTransaccion;
        public System.Windows.Forms.TextBox txtModulo;
        public System.Windows.Forms.TextBox txtSecuencia;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtDebe;
        public System.Windows.Forms.TextBox txthaber;
    }
}