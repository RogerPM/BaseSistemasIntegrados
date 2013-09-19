namespace forms.Facturacion
{
    partial class frmRptVentas
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
            this.cmbformapago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConsultaVendedor = new System.Windows.Forms.Button();
            this.txtDexcripVendedor = new System.Windows.Forms.TextBox();
            this.txtCodVendedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtphasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpdesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnnuevo = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.btnimprimir = new System.Windows.Forms.ToolStripButton();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbformapago
            // 
            this.cmbformapago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbformapago.FormattingEnabled = true;
            this.cmbformapago.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cmbformapago.Location = new System.Drawing.Point(108, 29);
            this.cmbformapago.Name = "cmbformapago";
            this.cmbformapago.Size = new System.Drawing.Size(565, 21);
            this.cmbformapago.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Codigo:";
            // 
            // btnConsultaVendedor
            // 
            this.btnConsultaVendedor.Location = new System.Drawing.Point(261, 31);
            this.btnConsultaVendedor.Name = "btnConsultaVendedor";
            this.btnConsultaVendedor.Size = new System.Drawing.Size(44, 23);
            this.btnConsultaVendedor.TabIndex = 11;
            this.btnConsultaVendedor.Text = "...";
            this.btnConsultaVendedor.UseVisualStyleBackColor = true;
            this.btnConsultaVendedor.Click += new System.EventHandler(this.btnConsultaVendedor_Click);
            // 
            // txtDexcripVendedor
            // 
            this.txtDexcripVendedor.Location = new System.Drawing.Point(311, 31);
            this.txtDexcripVendedor.Name = "txtDexcripVendedor";
            this.txtDexcripVendedor.ReadOnly = true;
            this.txtDexcripVendedor.Size = new System.Drawing.Size(362, 20);
            this.txtDexcripVendedor.TabIndex = 5;
            // 
            // txtCodVendedor
            // 
            this.txtCodVendedor.Location = new System.Drawing.Point(108, 33);
            this.txtCodVendedor.Name = "txtCodVendedor";
            this.txtCodVendedor.ReadOnly = true;
            this.txtCodVendedor.Size = new System.Drawing.Size(147, 20);
            this.txtCodVendedor.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Codigo:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(15, 272);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(685, 208);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consulta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 189);
            this.dataGridView1.TabIndex = 9;
            // 
            // dtphasta
            // 
            this.dtphasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtphasta.Location = new System.Drawing.Point(473, 33);
            this.dtphasta.Name = "dtphasta";
            this.dtphasta.Size = new System.Drawing.Size(200, 20);
            this.dtphasta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Final:";
            // 
            // dtpdesde
            // 
            this.dtpdesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdesde.Location = new System.Drawing.Point(108, 34);
            this.dtpdesde.Name = "dtpdesde";
            this.dtpdesde.Size = new System.Drawing.Size(200, 20);
            this.dtpdesde.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnnuevo,
            this.btnConsultar,
            this.btnimprimir,
            this.btnsalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(62, 22);
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::forms.Properties.Resources.imprimir;
            this.btnimprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(73, 22);
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(49, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dtphasta);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.dtpdesde);
            this.groupControl2.Location = new System.Drawing.Point(15, 39);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(685, 73);
            this.groupControl2.TabIndex = 48;
            this.groupControl2.Text = "Rango de Fechas de Factura";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnConsultaVendedor);
            this.groupControl1.Controls.Add(this.txtDexcripVendedor);
            this.groupControl1.Controls.Add(this.label8);
            this.groupControl1.Controls.Add(this.txtCodVendedor);
            this.groupControl1.Location = new System.Drawing.Point(15, 124);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(685, 67);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "Por Vendedor";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.cmbformapago);
            this.groupControl3.Controls.Add(this.label7);
            this.groupControl3.Location = new System.Drawing.Point(15, 203);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(685, 60);
            this.groupControl3.TabIndex = 50;
            this.groupControl3.Text = "Por Forma de Pago";
            // 
            // frmRptVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(715, 488);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmRptVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.frmRptVentas_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnConsultaVendedor;
        private System.Windows.Forms.TextBox txtDexcripVendedor;
        private System.Windows.Forms.TextBox txtCodVendedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtphasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpdesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripButton btnimprimir;
        private System.Windows.Forms.ComboBox cmbformapago;
        private System.Windows.Forms.ToolStripButton btnnuevo;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}