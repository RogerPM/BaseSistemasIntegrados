namespace forms.Facturacion
{
    partial class frmDevolucionVentas
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
            this.txtNumeroDevolucion = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultaFact = new System.Windows.Forms.Button();
            this.txtFacturaDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVehiculoDevolver = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listboxTipo = new System.Windows.Forms.CheckedListBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtdesarticulo = new System.Windows.Forms.TextBox();
            this.btnconsultarticulo = new System.Windows.Forms.Button();
            this.txtcodarticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoDevolver)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txtNumeroDevolucion
            // 
            this.txtNumeroDevolucion.Location = new System.Drawing.Point(74, 50);
            this.txtNumeroDevolucion.Name = "txtNumeroDevolucion";
            this.txtNumeroDevolucion.ReadOnly = true;
            this.txtNumeroDevolucion.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroDevolucion.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(169, 49);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(36, 23);
            this.btnConsulta.TabIndex = 2;
            this.btnConsulta.Text = "...";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(477, 50);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultaFact);
            this.groupBox1.Controls.Add(this.txtFacturaDescripcion);
            this.groupBox1.Controls.Add(this.txtNumeroFactura);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factura";
            // 
            // btnConsultaFact
            // 
            this.btnConsultaFact.Location = new System.Drawing.Point(152, 25);
            this.btnConsultaFact.Name = "btnConsultaFact";
            this.btnConsultaFact.Size = new System.Drawing.Size(36, 23);
            this.btnConsultaFact.TabIndex = 7;
            this.btnConsultaFact.Text = "...";
            this.btnConsultaFact.UseVisualStyleBackColor = true;
            this.btnConsultaFact.Click += new System.EventHandler(this.btnConsultaFact_Click);
            // 
            // txtFacturaDescripcion
            // 
            this.txtFacturaDescripcion.Location = new System.Drawing.Point(195, 25);
            this.txtFacturaDescripcion.Name = "txtFacturaDescripcion";
            this.txtFacturaDescripcion.ReadOnly = true;
            this.txtFacturaDescripcion.Size = new System.Drawing.Size(408, 20);
            this.txtFacturaDescripcion.TabIndex = 6;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(57, 25);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroFactura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVehiculoDevolver);
            this.groupBox3.Location = new System.Drawing.Point(17, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 241);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vehiculo a Devolver";
            // 
            // dgvVehiculoDevolver
            // 
            this.dgvVehiculoDevolver.AllowUserToAddRows = false;
            this.dgvVehiculoDevolver.AllowUserToDeleteRows = false;
            this.dgvVehiculoDevolver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculoDevolver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculoDevolver.Location = new System.Drawing.Point(3, 16);
            this.dgvVehiculoDevolver.Name = "dgvVehiculoDevolver";
            this.dgvVehiculoDevolver.ReadOnly = true;
            this.dgvVehiculoDevolver.Size = new System.Drawing.Size(603, 222);
            this.dgvVehiculoDevolver.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.listboxTipo);
            this.groupBox4.Controls.Add(this.txtObservaciones);
            this.groupBox4.Controls.Add(this.btnMenos);
            this.groupBox4.Controls.Add(this.btnMas);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(17, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(609, 115);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Motivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Observaciones:";
            // 
            // listboxTipo
            // 
            this.listboxTipo.FormattingEnabled = true;
            this.listboxTipo.Items.AddRange(new object[] {
            "No Pago de Cuotas",
            "Mal Estado",
            "Otros"});
            this.listboxTipo.Location = new System.Drawing.Point(57, 20);
            this.listboxTipo.Name = "listboxTipo";
            this.listboxTipo.Size = new System.Drawing.Size(120, 64);
            this.listboxTipo.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(274, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(329, 61);
            this.txtObservaciones.TabIndex = 6;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(563, 86);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 23);
            this.btnMenos.TabIndex = 37;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(514, 86);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 23);
            this.btnMas.TabIndex = 36;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tipo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGenerar,
            this.btnImprimir,
            this.btnAnular,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(639, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(269, 49);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(146, 21);
            this.cmbestado.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(220, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Estado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcantidad);
            this.groupBox2.Controls.Add(this.txtdesarticulo);
            this.groupBox2.Controls.Add(this.btnconsultarticulo);
            this.groupBox2.Controls.Add(this.txtcodarticulo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(17, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 50);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulo";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(505, 21);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(98, 20);
            this.txtcantidad.TabIndex = 40;
            // 
            // txtdesarticulo
            // 
            this.txtdesarticulo.Location = new System.Drawing.Point(195, 21);
            this.txtdesarticulo.Name = "txtdesarticulo";
            this.txtdesarticulo.ReadOnly = true;
            this.txtdesarticulo.Size = new System.Drawing.Size(304, 20);
            this.txtdesarticulo.TabIndex = 39;
            // 
            // btnconsultarticulo
            // 
            this.btnconsultarticulo.Location = new System.Drawing.Point(154, 19);
            this.btnconsultarticulo.Name = "btnconsultarticulo";
            this.btnconsultarticulo.Size = new System.Drawing.Size(34, 23);
            this.btnconsultarticulo.TabIndex = 38;
            this.btnconsultarticulo.Text = "...";
            this.btnconsultarticulo.UseVisualStyleBackColor = true;
            this.btnconsultarticulo.Click += new System.EventHandler(this.btnconsultarticulo_Click);
            // 
            // txtcodarticulo
            // 
            this.txtcodarticulo.Location = new System.Drawing.Point(55, 21);
            this.txtcodarticulo.Name = "txtcodarticulo";
            this.txtcodarticulo.ReadOnly = true;
            this.txtcodarticulo.Size = new System.Drawing.Size(91, 20);
            this.txtcodarticulo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Articulo";
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
            // btnGenerar
            // 
            this.btnGenerar.Enabled = false;
            this.btnGenerar.Image = global::forms.Properties.Resources.guardar;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(68, 22);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::forms.Properties.Resources.consultar;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.Image = global::forms.Properties.Resources.eliminar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDevolucionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(639, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbestado);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.txtNumeroDevolucion);
            this.Controls.Add(this.label1);
            this.Name = "frmDevolucionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevolucionVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoDevolver)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDevolucion;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFacturaDescripcion;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVehiculoDevolver;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox listboxTipo;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Button btnConsultaFact;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtdesarticulo;
        private System.Windows.Forms.Button btnconsultarticulo;
        private System.Windows.Forms.TextBox txtcodarticulo;
        private System.Windows.Forms.Label label4;
    }
}