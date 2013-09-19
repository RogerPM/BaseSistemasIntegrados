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
            this.btnConsultaFact = new System.Windows.Forms.Button();
            this.txtFacturaDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvVehiculoDevolver = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.listboxTipo = new System.Windows.Forms.CheckedListBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtdesarticulo = new System.Windows.Forms.TextBox();
            this.btnconsultarticulo = new System.Windows.Forms.Button();
            this.txtcodarticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoDevolver)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // txtNumeroDevolucion
            // 
            this.txtNumeroDevolucion.Location = new System.Drawing.Point(70, 34);
            this.txtNumeroDevolucion.Name = "txtNumeroDevolucion";
            this.txtNumeroDevolucion.ReadOnly = true;
            this.txtNumeroDevolucion.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroDevolucion.TabIndex = 1;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(165, 33);
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
            this.label2.Location = new System.Drawing.Point(430, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(473, 34);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // btnConsultaFact
            // 
            this.btnConsultaFact.Location = new System.Drawing.Point(165, 24);
            this.btnConsultaFact.Name = "btnConsultaFact";
            this.btnConsultaFact.Size = new System.Drawing.Size(36, 23);
            this.btnConsultaFact.TabIndex = 7;
            this.btnConsultaFact.Text = "...";
            this.btnConsultaFact.UseVisualStyleBackColor = true;
            this.btnConsultaFact.Click += new System.EventHandler(this.btnConsultaFact_Click);
            // 
            // txtFacturaDescripcion
            // 
            this.txtFacturaDescripcion.Location = new System.Drawing.Point(208, 24);
            this.txtFacturaDescripcion.Name = "txtFacturaDescripcion";
            this.txtFacturaDescripcion.ReadOnly = true;
            this.txtFacturaDescripcion.Size = new System.Drawing.Size(408, 20);
            this.txtFacturaDescripcion.TabIndex = 6;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(70, 24);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroFactura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVehiculoDevolver);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 111);
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
            this.dgvVehiculoDevolver.Size = new System.Drawing.Size(621, 92);
            this.dgvVehiculoDevolver.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(205, 40);
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
            this.listboxTipo.Location = new System.Drawing.Point(70, 32);
            this.listboxTipo.Name = "listboxTipo";
            this.listboxTipo.Size = new System.Drawing.Size(120, 64);
            this.listboxTipo.TabIndex = 7;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(287, 31);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(329, 61);
            this.txtObservaciones.TabIndex = 6;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(576, 108);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 23);
            this.btnMenos.TabIndex = 37;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(527, 108);
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
            this.label5.Location = new System.Drawing.Point(21, 40);
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
            this.toolStrip1.Size = new System.Drawing.Size(661, 25);
            this.toolStrip1.TabIndex = 12;
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
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.Image = global::forms.Properties.Resources.eliminar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(265, 33);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(146, 21);
            this.cmbestado.TabIndex = 39;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(216, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Estado:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(518, 29);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(98, 20);
            this.txtcantidad.TabIndex = 40;
            // 
            // txtdesarticulo
            // 
            this.txtdesarticulo.Location = new System.Drawing.Point(208, 29);
            this.txtdesarticulo.Name = "txtdesarticulo";
            this.txtdesarticulo.ReadOnly = true;
            this.txtdesarticulo.Size = new System.Drawing.Size(304, 20);
            this.txtdesarticulo.TabIndex = 39;
            // 
            // btnconsultarticulo
            // 
            this.btnconsultarticulo.Location = new System.Drawing.Point(167, 27);
            this.btnconsultarticulo.Name = "btnconsultarticulo";
            this.btnconsultarticulo.Size = new System.Drawing.Size(34, 23);
            this.btnconsultarticulo.TabIndex = 38;
            this.btnconsultarticulo.Text = "...";
            this.btnconsultarticulo.UseVisualStyleBackColor = true;
            this.btnconsultarticulo.Click += new System.EventHandler(this.btnconsultarticulo_Click);
            // 
            // txtcodarticulo
            // 
            this.txtcodarticulo.Location = new System.Drawing.Point(68, 29);
            this.txtcodarticulo.Name = "txtcodarticulo";
            this.txtcodarticulo.ReadOnly = true;
            this.txtcodarticulo.Size = new System.Drawing.Size(91, 20);
            this.txtcodarticulo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Articulo";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dtpFecha);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtNumeroDevolucion);
            this.groupControl1.Controls.Add(this.cmbestado);
            this.groupControl1.Controls.Add(this.btnConsulta);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Location = new System.Drawing.Point(17, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(627, 83);
            this.groupControl1.TabIndex = 46;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.btnConsultaFact);
            this.groupControl2.Controls.Add(this.txtFacturaDescripcion);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.txtNumeroFactura);
            this.groupControl2.Location = new System.Drawing.Point(17, 130);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(627, 60);
            this.groupControl2.TabIndex = 47;
            this.groupControl2.Text = "Factura";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.txtcantidad);
            this.groupControl3.Controls.Add(this.txtdesarticulo);
            this.groupControl3.Controls.Add(this.label4);
            this.groupControl3.Controls.Add(this.btnconsultarticulo);
            this.groupControl3.Controls.Add(this.txtcodarticulo);
            this.groupControl3.Location = new System.Drawing.Point(17, 199);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(627, 63);
            this.groupControl3.TabIndex = 48;
            this.groupControl3.Text = "Articulo";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.btnMenos);
            this.groupControl4.Controls.Add(this.btnMas);
            this.groupControl4.Controls.Add(this.label6);
            this.groupControl4.Controls.Add(this.txtObservaciones);
            this.groupControl4.Controls.Add(this.listboxTipo);
            this.groupControl4.Controls.Add(this.label5);
            this.groupControl4.Location = new System.Drawing.Point(17, 271);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(627, 138);
            this.groupControl4.TabIndex = 49;
            this.groupControl4.Text = "Motivo";
            // 
            // frmDevolucionVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(661, 538);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmDevolucionVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.frmDevolucionVentas_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoDevolver)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroDevolucion;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtFacturaDescripcion;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvVehiculoDevolver;
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
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtdesarticulo;
        private System.Windows.Forms.Button btnconsultarticulo;
        private System.Windows.Forms.TextBox txtcodarticulo;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}