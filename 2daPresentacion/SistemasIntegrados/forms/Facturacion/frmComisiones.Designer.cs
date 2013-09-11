namespace forms.Facturacion
{
    partial class frmComisiones
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
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarComision = new System.Windows.Forms.Button();
            this.txtNumeroComision = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvComisionesPagar = new System.Windows.Forms.DataGridView();
            this.btnConsultarPorComision = new System.Windows.Forms.Button();
            this.txtNumeroPorComision = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxModelo = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.rdbMarcaModelo = new System.Windows.Forms.RadioButton();
            this.rdbFinalizacionPago = new System.Windows.Forms.RadioButton();
            this.dtpFechaFormaPagCom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnConsulta = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtMontoComision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsultarEmpleado = new System.Windows.Forms.Button();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMontoVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnConsultarFactura = new System.Windows.Forms.Button();
            this.txtFacturaDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisionesPagar)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(330, 35);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(146, 21);
            this.cmbestado.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Estado:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(555, 36);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(104, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // btnConsultarComision
            // 
            this.btnConsultarComision.Location = new System.Drawing.Point(238, 33);
            this.btnConsultarComision.Name = "btnConsultarComision";
            this.btnConsultarComision.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarComision.TabIndex = 2;
            this.btnConsultarComision.Text = "...";
            this.btnConsultarComision.UseVisualStyleBackColor = true;
            // 
            // txtNumeroComision
            // 
            this.txtNumeroComision.Location = new System.Drawing.Point(99, 34);
            this.txtNumeroComision.Name = "txtNumeroComision";
            this.txtNumeroComision.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroComision.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(487, 34);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(175, 20);
            this.dtpFechaHasta.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(101, 32);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(175, 20);
            this.dtpFechaDesde.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvComisionesPagar);
            this.groupBox3.Location = new System.Drawing.Point(12, 504);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 152);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comisiones por Pagar";
            // 
            // dgvComisionesPagar
            // 
            this.dgvComisionesPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisionesPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComisionesPagar.Location = new System.Drawing.Point(3, 16);
            this.dgvComisionesPagar.Name = "dgvComisionesPagar";
            this.dgvComisionesPagar.Size = new System.Drawing.Size(672, 133);
            this.dgvComisionesPagar.TabIndex = 0;
            // 
            // btnConsultarPorComision
            // 
            this.btnConsultarPorComision.Location = new System.Drawing.Point(232, 24);
            this.btnConsultarPorComision.Name = "btnConsultarPorComision";
            this.btnConsultarPorComision.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarPorComision.TabIndex = 7;
            this.btnConsultarPorComision.Text = "...";
            this.btnConsultarPorComision.UseVisualStyleBackColor = true;
            // 
            // txtNumeroPorComision
            // 
            this.txtNumeroPorComision.Location = new System.Drawing.Point(93, 25);
            this.txtNumeroPorComision.Name = "txtNumeroPorComision";
            this.txtNumeroPorComision.Size = new System.Drawing.Size(133, 20);
            this.txtNumeroPorComision.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Numero:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.cbxModelo);
            this.groupBox5.Controls.Add(this.cbxMarca);
            this.groupBox5.Location = new System.Drawing.Point(5, 77);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(666, 46);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Marca/Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Marca:";
            // 
            // cbxModelo
            // 
            this.cbxModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxModelo.FormattingEnabled = true;
            this.cbxModelo.Items.AddRange(new object[] {
            "spark"});
            this.cbxModelo.Location = new System.Drawing.Point(478, 19);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Size = new System.Drawing.Size(175, 21);
            this.cbxModelo.TabIndex = 1;
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Items.AddRange(new object[] {
            "aveo"});
            this.cbxMarca.Location = new System.Drawing.Point(92, 19);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(175, 21);
            this.cbxMarca.TabIndex = 0;
            // 
            // rdbMarcaModelo
            // 
            this.rdbMarcaModelo.AutoSize = true;
            this.rdbMarcaModelo.Location = new System.Drawing.Point(517, 53);
            this.rdbMarcaModelo.Name = "rdbMarcaModelo";
            this.rdbMarcaModelo.Size = new System.Drawing.Size(93, 17);
            this.rdbMarcaModelo.TabIndex = 3;
            this.rdbMarcaModelo.TabStop = true;
            this.rdbMarcaModelo.Text = "Marca Modelo";
            this.rdbMarcaModelo.UseVisualStyleBackColor = true;
            // 
            // rdbFinalizacionPago
            // 
            this.rdbFinalizacionPago.AutoSize = true;
            this.rdbFinalizacionPago.Location = new System.Drawing.Point(303, 53);
            this.rdbFinalizacionPago.Name = "rdbFinalizacionPago";
            this.rdbFinalizacionPago.Size = new System.Drawing.Size(167, 17);
            this.rdbFinalizacionPago.TabIndex = 2;
            this.rdbFinalizacionPago.TabStop = true;
            this.rdbFinalizacionPago.Text = "Finalizacion de Pago Vehiculo";
            this.rdbFinalizacionPago.UseVisualStyleBackColor = true;
            // 
            // dtpFechaFormaPagCom
            // 
            this.dtpFechaFormaPagCom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFormaPagCom.Location = new System.Drawing.Point(93, 53);
            this.dtpFechaFormaPagCom.Name = "dtpFechaFormaPagCom";
            this.dtpFechaFormaPagCom.Size = new System.Drawing.Size(175, 20);
            this.dtpFechaFormaPagCom.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fecha:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGenerar,
            this.btnConsulta,
            this.btnAnular,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(697, 25);
            this.toolStrip1.TabIndex = 32;
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
            this.btnGenerar.Image = global::forms.Properties.Resources.guardar;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(68, 22);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Image = global::forms.Properties.Resources.consultar;
            this.btnConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(78, 22);
            this.btnConsulta.Text = "Consultar";
            // 
            // btnAnular
            // 
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
            // txtMontoComision
            // 
            this.txtMontoComision.Location = new System.Drawing.Point(484, 52);
            this.txtMontoComision.Name = "txtMontoComision";
            this.txtMontoComision.Size = new System.Drawing.Size(173, 20);
            this.txtMontoComision.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(373, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Monto de Comision:";
            // 
            // btnConsultarEmpleado
            // 
            this.btnConsultarEmpleado.Location = new System.Drawing.Point(192, 26);
            this.btnConsultarEmpleado.Name = "btnConsultarEmpleado";
            this.btnConsultarEmpleado.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarEmpleado.TabIndex = 11;
            this.btnConsultarEmpleado.Text = "...";
            this.btnConsultarEmpleado.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(235, 26);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(422, 20);
            this.txtNombreEmpleado.TabIndex = 10;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(96, 26);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroEmpleado.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Numero:";
            // 
            // txtMontoVenta
            // 
            this.txtMontoVenta.Location = new System.Drawing.Point(96, 55);
            this.txtMontoVenta.Name = "txtMontoVenta";
            this.txtMontoVenta.Size = new System.Drawing.Size(173, 20);
            this.txtMontoVenta.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Monto de Venta:";
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(619, 56);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(40, 23);
            this.btnMenos.TabIndex = 39;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Location = new System.Drawing.Point(570, 56);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(40, 23);
            this.btnMas.TabIndex = 38;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnConsultarFactura
            // 
            this.btnConsultarFactura.Location = new System.Drawing.Point(193, 27);
            this.btnConsultarFactura.Name = "btnConsultarFactura";
            this.btnConsultarFactura.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarFactura.TabIndex = 7;
            this.btnConsultarFactura.Text = "...";
            this.btnConsultarFactura.UseVisualStyleBackColor = true;
            // 
            // txtFacturaDescripcion
            // 
            this.txtFacturaDescripcion.Location = new System.Drawing.Point(236, 27);
            this.txtFacturaDescripcion.Name = "txtFacturaDescripcion";
            this.txtFacturaDescripcion.Size = new System.Drawing.Size(423, 20);
            this.txtFacturaDescripcion.TabIndex = 6;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(98, 27);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(89, 20);
            this.txtNumeroFactura.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Numero:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbestado);
            this.groupControl1.Controls.Add(this.dtpFecha);
            this.groupControl1.Controls.Add(this.label17);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtNumeroComision);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.btnConsultarComision);
            this.groupControl1.Location = new System.Drawing.Point(12, 38);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(678, 67);
            this.groupControl1.TabIndex = 35;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dtpFechaHasta);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.dtpFechaDesde);
            this.groupControl2.Location = new System.Drawing.Point(12, 112);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(678, 63);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Ventas";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupBox5);
            this.groupControl3.Controls.Add(this.btnConsultarPorComision);
            this.groupControl3.Controls.Add(this.rdbMarcaModelo);
            this.groupControl3.Controls.Add(this.txtNumeroPorComision);
            this.groupControl3.Controls.Add(this.label5);
            this.groupControl3.Controls.Add(this.label12);
            this.groupControl3.Controls.Add(this.dtpFechaFormaPagCom);
            this.groupControl3.Controls.Add(this.rdbFinalizacionPago);
            this.groupControl3.Location = new System.Drawing.Point(12, 182);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(678, 131);
            this.groupControl3.TabIndex = 37;
            this.groupControl3.Text = "Forma Pago";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtMontoComision);
            this.groupControl4.Controls.Add(this.label9);
            this.groupControl4.Controls.Add(this.label11);
            this.groupControl4.Controls.Add(this.txtMontoVenta);
            this.groupControl4.Controls.Add(this.btnConsultarEmpleado);
            this.groupControl4.Controls.Add(this.label10);
            this.groupControl4.Controls.Add(this.txtNombreEmpleado);
            this.groupControl4.Controls.Add(this.txtNumeroEmpleado);
            this.groupControl4.Location = new System.Drawing.Point(12, 320);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(678, 84);
            this.groupControl4.TabIndex = 38;
            this.groupControl4.Text = "Empleado";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btnMenos);
            this.groupControl5.Controls.Add(this.btnMas);
            this.groupControl5.Controls.Add(this.label8);
            this.groupControl5.Controls.Add(this.btnConsultarFactura);
            this.groupControl5.Controls.Add(this.txtNumeroFactura);
            this.groupControl5.Controls.Add(this.txtFacturaDescripcion);
            this.groupControl5.Location = new System.Drawing.Point(12, 411);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(678, 87);
            this.groupControl5.TabIndex = 39;
            this.groupControl5.Text = "Factura";
            // 
            // frmComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(697, 657);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.frmComisiones_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisionesPagar)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvComisionesPagar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultarComision;
        private System.Windows.Forms.TextBox txtNumeroComision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxModelo;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.RadioButton rdbMarcaModelo;
        private System.Windows.Forms.RadioButton rdbFinalizacionPago;
        private System.Windows.Forms.DateTimePicker dtpFechaFormaPagCom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnConsulta;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtMontoVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConsultarEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnConsultarFactura;
        private System.Windows.Forms.TextBox txtFacturaDescripcion;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMontoComision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnConsultarPorComision;
        private System.Windows.Forms.TextBox txtNumeroPorComision;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
    }
}