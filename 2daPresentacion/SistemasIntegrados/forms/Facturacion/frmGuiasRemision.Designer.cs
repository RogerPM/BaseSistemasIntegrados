namespace forms.Facturacion
{
    partial class frmGuiasRemision
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
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConsultarGuiaRemision = new System.Windows.Forms.Button();
            this.txtNumeroGuiaRemision = new System.Windows.Forms.TextBox();
            this.dtpInicioTraslado = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSitioLlegada = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSitioPartida = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreConductor = new System.Windows.Forms.TextBox();
            this.btnConsultarConductor = new System.Windows.Forms.Button();
            this.txtNumeroConductor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dgvVehiculoTransportar = new System.Windows.Forms.DataGridView();
            this.dtpfechallega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestiNombre = new System.Windows.Forms.TextBox();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnConsultFactura = new System.Windows.Forms.Button();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoTransportar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(584, 24);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(158, 21);
            this.cmbestado.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(535, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Estado:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(387, 24);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(85, 20);
            this.dtpFechaEmision.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha:";
            // 
            // btnConsultarGuiaRemision
            // 
            this.btnConsultarGuiaRemision.Location = new System.Drawing.Point(235, 25);
            this.btnConsultarGuiaRemision.Name = "btnConsultarGuiaRemision";
            this.btnConsultarGuiaRemision.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarGuiaRemision.TabIndex = 11;
            this.btnConsultarGuiaRemision.Text = "...";
            this.btnConsultarGuiaRemision.UseVisualStyleBackColor = true;
            this.btnConsultarGuiaRemision.Click += new System.EventHandler(this.btnConsultarGuiaRemision_Click);
            // 
            // txtNumeroGuiaRemision
            // 
            this.txtNumeroGuiaRemision.Location = new System.Drawing.Point(106, 28);
            this.txtNumeroGuiaRemision.Name = "txtNumeroGuiaRemision";
            this.txtNumeroGuiaRemision.ReadOnly = true;
            this.txtNumeroGuiaRemision.Size = new System.Drawing.Size(123, 20);
            this.txtNumeroGuiaRemision.TabIndex = 1;
            // 
            // dtpInicioTraslado
            // 
            this.dtpInicioTraslado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioTraslado.Location = new System.Drawing.Point(143, 28);
            this.dtpInicioTraslado.Name = "dtpInicioTraslado";
            this.dtpInicioTraslado.Size = new System.Drawing.Size(158, 20);
            this.dtpInicioTraslado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha Inicio de Traslado:";
            // 
            // txtSitioLlegada
            // 
            this.txtSitioLlegada.Location = new System.Drawing.Point(106, 55);
            this.txtSitioLlegada.Name = "txtSitioLlegada";
            this.txtSitioLlegada.Size = new System.Drawing.Size(637, 20);
            this.txtSitioLlegada.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sitio de Llegada:";
            // 
            // txtSitioPartida
            // 
            this.txtSitioPartida.Location = new System.Drawing.Point(106, 29);
            this.txtSitioPartida.Name = "txtSitioPartida";
            this.txtSitioPartida.Size = new System.Drawing.Size(637, 20);
            this.txtSitioPartida.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Sitio de Partida:";
            // 
            // txtNombreConductor
            // 
            this.txtNombreConductor.Location = new System.Drawing.Point(274, 37);
            this.txtNombreConductor.Name = "txtNombreConductor";
            this.txtNombreConductor.ReadOnly = true;
            this.txtNombreConductor.Size = new System.Drawing.Size(469, 20);
            this.txtNombreConductor.TabIndex = 18;
            // 
            // btnConsultarConductor
            // 
            this.btnConsultarConductor.Location = new System.Drawing.Point(232, 35);
            this.btnConsultarConductor.Name = "btnConsultarConductor";
            this.btnConsultarConductor.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarConductor.TabIndex = 17;
            this.btnConsultarConductor.Text = "...";
            this.btnConsultarConductor.UseVisualStyleBackColor = true;
            this.btnConsultarConductor.Click += new System.EventHandler(this.btnConsultarConductor_Click);
            // 
            // txtNumeroConductor
            // 
            this.txtNumeroConductor.Location = new System.Drawing.Point(102, 38);
            this.txtNumeroConductor.Name = "txtNumeroConductor";
            this.txtNumeroConductor.ReadOnly = true;
            this.txtNumeroConductor.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroConductor.TabIndex = 16;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 15;
            this.label18.Text = "Conductor:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dgvVehiculoTransportar);
            this.groupBox7.Location = new System.Drawing.Point(6, 458);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(748, 145);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Vehiculos a Transportar";
            // 
            // dgvVehiculoTransportar
            // 
            this.dgvVehiculoTransportar.AllowUserToAddRows = false;
            this.dgvVehiculoTransportar.AllowUserToDeleteRows = false;
            this.dgvVehiculoTransportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculoTransportar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVehiculoTransportar.Location = new System.Drawing.Point(3, 16);
            this.dgvVehiculoTransportar.Name = "dgvVehiculoTransportar";
            this.dgvVehiculoTransportar.ReadOnly = true;
            this.dgvVehiculoTransportar.Size = new System.Drawing.Size(742, 126);
            this.dgvVehiculoTransportar.TabIndex = 0;
            // 
            // dtpfechallega
            // 
            this.dtpfechallega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechallega.Location = new System.Drawing.Point(98, 59);
            this.dtpfechallega.Name = "dtpfechallega";
            this.dtpfechallega.Size = new System.Drawing.Size(166, 20);
            this.dtpfechallega.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 26);
            this.label2.TabIndex = 37;
            this.label2.Text = "Fecha Estimada de Llegada:";
            // 
            // txtDestiNombre
            // 
            this.txtDestiNombre.Location = new System.Drawing.Point(270, 36);
            this.txtDestiNombre.Name = "txtDestiNombre";
            this.txtDestiNombre.ReadOnly = true;
            this.txtDestiNombre.Size = new System.Drawing.Size(469, 20);
            this.txtDestiNombre.TabIndex = 36;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(699, 59);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 23);
            this.btnMenos.TabIndex = 35;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(650, 59);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 23);
            this.btnMas.TabIndex = 34;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnConsultFactura
            // 
            this.btnConsultFactura.Location = new System.Drawing.Point(228, 33);
            this.btnConsultFactura.Name = "btnConsultFactura";
            this.btnConsultFactura.Size = new System.Drawing.Size(36, 23);
            this.btnConsultFactura.TabIndex = 12;
            this.btnConsultFactura.Text = "...";
            this.btnConsultFactura.UseVisualStyleBackColor = true;
            this.btnConsultFactura.Click += new System.EventHandler(this.btnConsultFactura_Click);
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(98, 33);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(124, 20);
            this.txtNumeroFactura.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Factura:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGenerar,
            this.btnAnular,
            this.btnImprimir,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(766, 25);
            this.toolStrip1.TabIndex = 33;
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
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::forms.Properties.Resources.imprimir;
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(73, 22);
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.cmbestado);
            this.groupControl3.Controls.Add(this.label17);
            this.groupControl3.Controls.Add(this.label1);
            this.groupControl3.Controls.Add(this.dtpFechaEmision);
            this.groupControl3.Controls.Add(this.txtNumeroGuiaRemision);
            this.groupControl3.Controls.Add(this.label3);
            this.groupControl3.Controls.Add(this.btnConsultarGuiaRemision);
            this.groupControl3.Location = new System.Drawing.Point(6, 38);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(748, 60);
            this.groupControl3.TabIndex = 44;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dtpInicioTraslado);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Location = new System.Drawing.Point(6, 106);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(748, 59);
            this.groupControl1.TabIndex = 45;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.txtSitioLlegada);
            this.groupControl2.Controls.Add(this.txtSitioPartida);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Location = new System.Drawing.Point(6, 174);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(748, 87);
            this.groupControl2.TabIndex = 46;
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.txtNombreConductor);
            this.groupControl4.Controls.Add(this.btnConsultarConductor);
            this.groupControl4.Controls.Add(this.label18);
            this.groupControl4.Controls.Add(this.txtNumeroConductor);
            this.groupControl4.Location = new System.Drawing.Point(6, 270);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(748, 72);
            this.groupControl4.TabIndex = 47;
            this.groupControl4.Text = "Transportador";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.dtpfechallega);
            this.groupControl5.Controls.Add(this.btnMenos);
            this.groupControl5.Controls.Add(this.label2);
            this.groupControl5.Controls.Add(this.label16);
            this.groupControl5.Controls.Add(this.txtDestiNombre);
            this.groupControl5.Controls.Add(this.txtNumeroFactura);
            this.groupControl5.Controls.Add(this.btnConsultFactura);
            this.groupControl5.Controls.Add(this.btnMas);
            this.groupControl5.Location = new System.Drawing.Point(6, 351);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(748, 101);
            this.groupControl5.TabIndex = 48;
            this.groupControl5.Text = "Detalle Guia de Remision";
            // 
            // frmGuiasRemision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(766, 615);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox7);
            this.Name = "frmGuiasRemision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guias de Remision";
            this.Load += new System.EventHandler(this.frmGuiasRemision_Load);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculoTransportar)).EndInit();
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
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroGuiaRemision;
        private System.Windows.Forms.DateTimePicker dtpInicioTraslado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSitioLlegada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSitioPartida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgvVehiculoTransportar;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnImprimir;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Button btnConsultarGuiaRemision;
        private System.Windows.Forms.Button btnConsultFactura;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNombreConductor;
        private System.Windows.Forms.Button btnConsultarConductor;
        private System.Windows.Forms.TextBox txtNumeroConductor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDestiNombre;
        private System.Windows.Forms.DateTimePicker dtpfechallega;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
    }
}