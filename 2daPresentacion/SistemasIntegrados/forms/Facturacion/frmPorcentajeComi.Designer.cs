namespace forms.Facturacion
{
    partial class frmPorcentajeComi
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvporcomision = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFormaPago = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnguardar = new System.Windows.Forms.ToolStripButton();
            this.btnconsultar = new System.Windows.Forms.ToolStripButton();
            this.btnmodificar = new System.Windows.Forms.ToolStripButton();
            this.btneliminar = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtporcomision = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontoventa = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvporcomision)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(92, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 16;
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(266, 27);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(130, 21);
            this.cmbestado.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Estado:";
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(443, 29);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(104, 20);
            this.dtfecha.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvporcomision);
            this.groupBox4.Location = new System.Drawing.Point(9, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(559, 133);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // dgvporcomision
            // 
            this.dgvporcomision.AllowUserToAddRows = false;
            this.dgvporcomision.AllowUserToDeleteRows = false;
            this.dgvporcomision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvporcomision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvporcomision.Location = new System.Drawing.Point(3, 16);
            this.dgvporcomision.Name = "dgvporcomision";
            this.dgvporcomision.ReadOnly = true;
            this.dgvporcomision.Size = new System.Drawing.Size(553, 114);
            this.dgvporcomision.TabIndex = 0;
            this.dgvporcomision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvporcomision_CellContentClick);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(13, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Forma de Pago:";
            // 
            // cmbFormaPago
            // 
            this.cmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaPago.FormattingEnabled = true;
            this.cmbFormaPago.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.cmbFormaPago.Location = new System.Drawing.Point(91, 24);
            this.cmbFormaPago.Name = "cmbFormaPago";
            this.cmbFormaPago.Size = new System.Drawing.Size(455, 21);
            this.cmbFormaPago.TabIndex = 25;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnguardar,
            this.btnconsultar,
            this.btnmodificar,
            this.btneliminar,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(62, 22);
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = global::forms.Properties.Resources.guardar;
            this.btnguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(69, 22);
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnconsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(78, 22);
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Enabled = false;
            this.btnmodificar.Image = global::forms.Properties.Resources.modificar;
            this.btnmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(78, 22);
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btneliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 22);
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Descripcion:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(90, 24);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(455, 20);
            this.txtdescripcion.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "% Comision:";
            // 
            // txtporcomision
            // 
            this.txtporcomision.Location = new System.Drawing.Point(91, 27);
            this.txtporcomision.Name = "txtporcomision";
            this.txtporcomision.Size = new System.Drawing.Size(100, 20);
            this.txtporcomision.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Monto de Venta:";
            // 
            // txtmontoventa
            // 
            this.txtmontoventa.Location = new System.Drawing.Point(324, 27);
            this.txtmontoventa.Name = "txtmontoventa";
            this.txtmontoventa.Size = new System.Drawing.Size(222, 20);
            this.txtmontoventa.TabIndex = 36;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.txtNumero);
            this.groupControl3.Controls.Add(this.dtfecha);
            this.groupControl3.Controls.Add(this.cmbestado);
            this.groupControl3.Controls.Add(this.label2);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Controls.Add(this.button1);
            this.groupControl3.Controls.Add(this.label6);
            this.groupControl3.Location = new System.Drawing.Point(9, 37);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(556, 60);
            this.groupControl3.TabIndex = 45;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.txtdescripcion);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(9, 106);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(556, 60);
            this.groupControl1.TabIndex = 46;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.cmbFormaPago);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Location = new System.Drawing.Point(10, 175);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(556, 60);
            this.groupControl2.TabIndex = 47;
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.txtmontoventa);
            this.groupControl4.Controls.Add(this.txtporcomision);
            this.groupControl4.Controls.Add(this.label3);
            this.groupControl4.Controls.Add(this.label4);
            this.groupControl4.Location = new System.Drawing.Point(10, 244);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(556, 60);
            this.groupControl4.TabIndex = 48;
            // 
            // frmPorcentajeComi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 456);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmPorcentajeComi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Porcentaje de Comisiones";
            this.Load += new System.EventHandler(this.frmPorcentajeComi_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvporcomision)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvporcomision;
        private System.Windows.Forms.DateTimePicker dtfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnguardar;
        private System.Windows.Forms.ToolStripButton btnconsultar;
        private System.Windows.Forms.ToolStripButton btnmodificar;
        private System.Windows.Forms.ToolStripButton btneliminar;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtporcomision;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmontoventa;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ComboBox cmbFormaPago;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}