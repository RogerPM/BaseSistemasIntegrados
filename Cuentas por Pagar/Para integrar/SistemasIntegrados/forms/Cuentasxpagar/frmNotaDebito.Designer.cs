namespace forms.Cuentasxpagar
{
    partial class frmNotaDebito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotaDebito));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.gdcDetalleNotaDebito = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.txtFechaTransaccion = new DevExpress.XtraEditors.TextEdit();
            this.txtNroFactura = new DevExpress.XtraEditors.TextEdit();
            this.txtDireccion = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtRucProveedor = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbFormaPago = new DevExpress.XtraEditors.RadioGroup();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxNroNotaDebito = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxNroRegRecepcion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.btnGenerarComprobante = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleNotaDebito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRucProveedor.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbFormaPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroNotaDebito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroRegRecepcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtIva);
            this.groupBox3.Controls.Add(this.txtSubTotal);
            this.groupBox3.Controls.Add(this.gdcDetalleNotaDebito);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(11, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1015, 269);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(847, 234);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(150, 20);
            this.txtTotal.TabIndex = 38;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(847, 205);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(150, 20);
            this.txtIva.TabIndex = 38;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(847, 179);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(150, 20);
            this.txtSubTotal.TabIndex = 38;
            // 
            // gdcDetalleNotaDebito
            // 
            this.gdcDetalleNotaDebito.Location = new System.Drawing.Point(20, 19);
            this.gdcDetalleNotaDebito.MainView = this.gridView2;
            this.gdcDetalleNotaDebito.Name = "gdcDetalleNotaDebito";
            this.gdcDetalleNotaDebito.Size = new System.Drawing.Size(977, 153);
            this.gdcDetalleNotaDebito.TabIndex = 0;
            this.gdcDetalleNotaDebito.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCantidad,
            this.colArticulo,
            this.colPrecioUnitario,
            this.colTotal});
            this.gridView2.GridControl = this.gdcDetalleNotaDebito;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colCantidad
            // 
            this.colCantidad.AppearanceHeader.Options.UseTextOptions = true;
            this.colCantidad.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 0;
            this.colCantidad.Width = 70;
            // 
            // colArticulo
            // 
            this.colArticulo.AppearanceHeader.Options.UseTextOptions = true;
            this.colArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colArticulo.Caption = "Artículo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            this.colArticulo.Width = 609;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.AppearanceHeader.Options.UseTextOptions = true;
            this.colPrecioUnitario.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPrecioUnitario.Caption = "P. Unitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 2;
            this.colPrecioUnitario.Width = 138;
            // 
            // colTotal
            // 
            this.colTotal.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotal.Caption = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            this.colTotal.Width = 142;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(772, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(772, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "I.V.A.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(772, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Sub-Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.txtFechaTransaccion);
            this.groupBox1.Controls.Add(this.txtNroFactura);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtNombreProveedor);
            this.groupBox1.Controls.Add(this.txtRucProveedor);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1015, 106);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(614, 74);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 20);
            this.txtMonto.TabIndex = 38;
            // 
            // txtFechaTransaccion
            // 
            this.txtFechaTransaccion.Location = new System.Drawing.Point(356, 74);
            this.txtFechaTransaccion.Name = "txtFechaTransaccion";
            this.txtFechaTransaccion.Size = new System.Drawing.Size(206, 20);
            this.txtFechaTransaccion.TabIndex = 38;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(92, 74);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(150, 20);
            this.txtNroFactura.TabIndex = 38;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(309, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(455, 20);
            this.txtDireccion.TabIndex = 38;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(92, 45);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(150, 20);
            this.txtTelefono.TabIndex = 38;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Location = new System.Drawing.Point(251, 19);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(513, 20);
            this.txtNombreProveedor.TabIndex = 38;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Location = new System.Drawing.Point(92, 19);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Size = new System.Drawing.Size(150, 20);
            this.txtRucProveedor.TabIndex = 38;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbFormaPago);
            this.groupBox2.Location = new System.Drawing.Point(778, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 83);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formas de Pago";
            // 
            // rdbFormaPago
            // 
            this.rdbFormaPago.Location = new System.Drawing.Point(49, 20);
            this.rdbFormaPago.Name = "rdbFormaPago";
            this.rdbFormaPago.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Contado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Crédito")});
            this.rdbFormaPago.Size = new System.Drawing.Size(132, 55);
            this.rdbFormaPago.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Fecha Transacción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(248, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nro. Factura:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Enabled = false;
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(923, 36);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(103, 20);
            this.dtpFechaRegistro.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nro. Nota de Débito:";
            // 
            // cbxNroNotaDebito
            // 
            this.cbxNroNotaDebito.Location = new System.Drawing.Point(119, 39);
            this.cbxNroNotaDebito.Name = "cbxNroNotaDebito";
            this.cbxNroNotaDebito.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNroNotaDebito.Properties.View = this.gridView1;
            this.cbxNroNotaDebito.Size = new System.Drawing.Size(150, 20);
            this.cbxNroNotaDebito.TabIndex = 32;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Nro. Reg. Recepción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Fecha Registro:";
            // 
            // cbxNroRegRecepcion
            // 
            this.cbxNroRegRecepcion.Location = new System.Drawing.Point(527, 39);
            this.cbxNroRegRecepcion.Name = "cbxNroRegRecepcion";
            this.cbxNroRegRecepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNroRegRecepcion.Properties.View = this.searchLookUpEdit1View;
            this.cbxNroRegRecepcion.Size = new System.Drawing.Size(150, 20);
            this.cbxNroRegRecepcion.TabIndex = 29;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbConsultar,
            this.tsbModificar,
            this.tsbAnular,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1037, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbNuevo.ForeColor = System.Drawing.Color.Black;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbGuardar.ForeColor = System.Drawing.Color.Black;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultar.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultar.Image")));
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(78, 22);
            this.tsbConsultar.Text = "Consultar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbAnular.ForeColor = System.Drawing.Color.Black;
            this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Location = new System.Drawing.Point(438, 461);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(160, 30);
            this.btnGenerarComprobante.TabIndex = 39;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            // 
            // frmNotaDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 503);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxNroNotaDebito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxNroRegRecepcion);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmNotaDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNotaDebito";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleNotaDebito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFechaTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRucProveedor.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdbFormaPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroNotaDebito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroRegRecepcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraGrid.GridControl gdcDetalleNotaDebito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxNroNotaDebito;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxNroRegRecepcion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private DevExpress.XtraEditors.TextEdit txtFechaTransaccion;
        private DevExpress.XtraEditors.TextEdit txtNroFactura;
        private DevExpress.XtraEditors.TextEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private DevExpress.XtraEditors.TextEdit txtNombreProveedor;
        private DevExpress.XtraEditors.TextEdit txtRucProveedor;
        private DevExpress.XtraEditors.SimpleButton btnGenerarComprobante;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private DevExpress.XtraEditors.RadioGroup rdbFormaPago;
    }
}