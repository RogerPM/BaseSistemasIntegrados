namespace forms.Cuentasxpagar
{
    partial class frmOrdenPago
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenPago));
            this.gdcOrdenPago = new DevExpress.XtraGrid.GridControl();
            this.clsCuentaPorPagarDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvOrden = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNúmeroRegistroCXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcNumLetrasAPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPagosRealizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizarPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colNumCuentaPorPagarDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsOrdenPagoDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtEfectivoDisponible = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPagar = new DevExpress.XtraEditors.TextEdit();
            this.clsEmpresaServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new DevExpress.XtraEditors.TextEdit();
            this.deFechaActual = new DevExpress.XtraEditors.DateEdit();
            this.cbxProveed = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsCuentaPorPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresaServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdFrecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumCuentaPorPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumeroLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumIngresoEgreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SaldoDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ValorEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ValorLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnGenerarComprobante = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcOrdenPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcOrdenPago
            // 
            this.gdcOrdenPago.DataSource = this.clsCuentaPorPagarDetalleBindingSource;
            this.gdcOrdenPago.Location = new System.Drawing.Point(18, 72);
            this.gdcOrdenPago.MainView = this.gvOrden;
            this.gdcOrdenPago.Name = "gdcOrdenPago";
            this.gdcOrdenPago.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gdcOrdenPago.Size = new System.Drawing.Size(969, 323);
            this.gdcOrdenPago.TabIndex = 36;
            this.gdcOrdenPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrden});
            this.gdcOrdenPago.Click += new System.EventHandler(this.gdcOrdenPago_Click);
            // 
            // clsCuentaPorPagarDetalleBindingSource
            // 
            this.clsCuentaPorPagarDetalleBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsCuentaPorPagarDetalle);
            // 
            // gvOrden
            // 
            this.gvOrden.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNúmeroRegistroCXP,
            this.colSaldoDeuda,
            this.gdcFechaVencimiento,
            this.colValorLetra,
            this.gdcNumLetrasAPagar,
            this.colNroPagosRealizar,
            this.colTotalPagar,
            this.colAutorizarPago,
            this.colNumCuentaPorPagarDetalle});
            this.gvOrden.GridControl = this.gdcOrdenPago;
            this.gvOrden.Name = "gvOrden";
            this.gvOrden.OptionsView.ShowAutoFilterRow = true;
            this.gvOrden.OptionsView.ShowGroupPanel = false;
            this.gvOrden.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            this.gvOrden.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gridView1_ValidatingEditor);
            // 
            // colNúmeroRegistroCXP
            // 
            this.colNúmeroRegistroCXP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNúmeroRegistroCXP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNúmeroRegistroCXP.Caption = "Nro. Cta. Por Pagar";
            this.colNúmeroRegistroCXP.FieldName = "_NumCuentaPorPagar";
            this.colNúmeroRegistroCXP.Name = "colNúmeroRegistroCXP";
            this.colNúmeroRegistroCXP.OptionsColumn.AllowEdit = false;
            this.colNúmeroRegistroCXP.Visible = true;
            this.colNúmeroRegistroCXP.VisibleIndex = 0;
            this.colNúmeroRegistroCXP.Width = 118;
            // 
            // colSaldoDeuda
            // 
            this.colSaldoDeuda.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoDeuda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaldoDeuda.Caption = "Saldo Deuda";
            this.colSaldoDeuda.FieldName = "_SaldoDeuda";
            this.colSaldoDeuda.Name = "colSaldoDeuda";
            this.colSaldoDeuda.OptionsColumn.AllowEdit = false;
            this.colSaldoDeuda.Visible = true;
            this.colSaldoDeuda.VisibleIndex = 1;
            this.colSaldoDeuda.Width = 118;
            // 
            // gdcFechaVencimiento
            // 
            this.gdcFechaVencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.gdcFechaVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gdcFechaVencimiento.Caption = "Fecha de Vencimiento";
            this.gdcFechaVencimiento.FieldName = "_FechaVencimiento";
            this.gdcFechaVencimiento.Name = "gdcFechaVencimiento";
            this.gdcFechaVencimiento.OptionsColumn.AllowEdit = false;
            this.gdcFechaVencimiento.Visible = true;
            this.gdcFechaVencimiento.VisibleIndex = 2;
            this.gdcFechaVencimiento.Width = 118;
            // 
            // colValorLetra
            // 
            this.colValorLetra.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLetra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorLetra.Caption = "Valor de Letra";
            this.colValorLetra.FieldName = "_ValorLetra";
            this.colValorLetra.Name = "colValorLetra";
            this.colValorLetra.OptionsColumn.AllowEdit = false;
            this.colValorLetra.Visible = true;
            this.colValorLetra.VisibleIndex = 3;
            this.colValorLetra.Width = 118;
            // 
            // gdcNumLetrasAPagar
            // 
            this.gdcNumLetrasAPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.gdcNumLetrasAPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gdcNumLetrasAPagar.Caption = "Letras Pendientes de Pago";
            this.gdcNumLetrasAPagar.Name = "gdcNumLetrasAPagar";
            this.gdcNumLetrasAPagar.OptionsColumn.AllowEdit = false;
            this.gdcNumLetrasAPagar.Visible = true;
            this.gdcNumLetrasAPagar.VisibleIndex = 4;
            this.gdcNumLetrasAPagar.Width = 138;
            // 
            // colNroPagosRealizar
            // 
            this.colNroPagosRealizar.AppearanceHeader.Options.UseTextOptions = true;
            this.colNroPagosRealizar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNroPagosRealizar.Caption = "Nro. Pagos a Realizar";
            this.colNroPagosRealizar.FieldName = "_numeroPagos";
            this.colNroPagosRealizar.Name = "colNroPagosRealizar";
            this.colNroPagosRealizar.Visible = true;
            this.colNroPagosRealizar.VisibleIndex = 5;
            this.colNroPagosRealizar.Width = 110;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPagar.Caption = "Total a Pagar";
            this.colTotalPagar.FieldName = "_totalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.OptionsColumn.AllowEdit = false;
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 6;
            this.colTotalPagar.Width = 110;
            // 
            // colAutorizarPago
            // 
            this.colAutorizarPago.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutorizarPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutorizarPago.Caption = "Autorizar Pago";
            this.colAutorizarPago.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAutorizarPago.FieldName = "_AutorizarPago";
            this.colAutorizarPago.Name = "colAutorizarPago";
            this.colAutorizarPago.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "_totalPagar", "")});
            this.colAutorizarPago.Visible = true;
            this.colAutorizarPago.VisibleIndex = 7;
            this.colAutorizarPago.Width = 121;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // colNumCuentaPorPagarDetalle
            // 
            this.colNumCuentaPorPagarDetalle.Caption = "Num Cuenta po Pagar Detalle";
            this.colNumCuentaPorPagarDetalle.FieldName = "_NumCuentaPorPagarDetalle";
            this.colNumCuentaPorPagarDetalle.Name = "colNumCuentaPorPagarDetalle";
            // 
            // clsOrdenPagoDetBindingSource
            // 
            this.clsOrdenPagoDetBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsOrdenPagoDet);
            // 
            // txtEfectivoDisponible
            // 
            this.txtEfectivoDisponible.Enabled = false;
            this.txtEfectivoDisponible.Location = new System.Drawing.Point(626, 34);
            this.txtEfectivoDisponible.Name = "txtEfectivoDisponible";
            this.txtEfectivoDisponible.Properties.Mask.EditMask = "#############.##";
            this.txtEfectivoDisponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEfectivoDisponible.Size = new System.Drawing.Size(109, 20);
            this.txtEfectivoDisponible.TabIndex = 30;
            this.txtEfectivoDisponible.EditValueChanged += new System.EventHandler(this.txtEfectivoDisponible_EditValueChanged);
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(856, 413);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(131, 20);
            this.txtTotalPagar.TabIndex = 31;
            this.txtTotalPagar.EditValueChanged += new System.EventHandler(this.txtTotalPagar_EditValueChanged);
            // 
            // clsEmpresaServicioBindingSource
            // 
            this.clsEmpresaServicioBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsEmpresaServicio);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Efectivo Disponible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(781, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Total a Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha de Emisión:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha de Emisión:";
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
            this.toolStrip1.Size = new System.Drawing.Size(1006, 25);
            this.toolStrip1.TabIndex = 21;
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
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
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
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nro. Orden de Pago";
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(116, 34);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(109, 20);
            this.textEdit1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(64, 413);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(109, 20);
            this.txtEstado.TabIndex = 30;
            // 
            // deFechaActual
            // 
            this.deFechaActual.EditValue = null;
            this.deFechaActual.Enabled = false;
            this.deFechaActual.Location = new System.Drawing.Point(883, 34);
            this.deFechaActual.Name = "deFechaActual";
            this.deFechaActual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaActual.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaActual.Size = new System.Drawing.Size(104, 20);
            this.deFechaActual.TabIndex = 37;
            // 
            // cbxProveed
            // 
            this.cbxProveed.Location = new System.Drawing.Point(333, 37);
            this.cbxProveed.Name = "cbxProveed";
            this.cbxProveed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxProveed.Properties.DataSource = this.clsCuentaPorPagarBindingSource;
            this.cbxProveed.Properties.DisplayMember = "_NumCuentaPorPagar";
            this.cbxProveed.Properties.ValueMember = "_IdProveedor";
            this.cbxProveed.Properties.View = this.searchLookUpEdit1View;
            this.cbxProveed.Size = new System.Drawing.Size(100, 20);
            this.cbxProveed.TabIndex = 38;
            this.cbxProveed.EditValueChanged += new System.EventHandler(this.cbxProveed_EditValueChanged);
            // 
            // clsCuentaPorPagarBindingSource
            // 
            this.clsCuentaPorPagarBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsCuentaPorPagar);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Descuento,
            this.col_Detalle,
            this.col_Factura,
            this.col_FechaIngreso,
            this.col_FechaTransaccion,
            this.col_FormaPago,
            this.col_IdEmpresa,
            this.col_IdEmpresaServicio,
            this.col_IdFrecuencia,
            this.col_IdProveedor,
            this.col_IdUsuario,
            this.col_Motivo,
            this.col_NumCuentaPorPagar,
            this.col_NumeroLetra,
            this.col_NumIngresoEgreso,
            this.col_SaldoDeuda,
            this.col_Subtotal,
            this.col_Total,
            this.col_ValorEntrada,
            this.col_ValorLetra});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_Descuento
            // 
            this.col_Descuento.FieldName = "_Descuento";
            this.col_Descuento.Name = "col_Descuento";
            // 
            // col_Detalle
            // 
            this.col_Detalle.FieldName = "_Detalle";
            this.col_Detalle.Name = "col_Detalle";
            // 
            // col_Factura
            // 
            this.col_Factura.FieldName = "_Factura";
            this.col_Factura.Name = "col_Factura";
            // 
            // col_FechaIngreso
            // 
            this.col_FechaIngreso.FieldName = "_FechaIngreso";
            this.col_FechaIngreso.Name = "col_FechaIngreso";
            // 
            // col_FechaTransaccion
            // 
            this.col_FechaTransaccion.FieldName = "_FechaTransaccion";
            this.col_FechaTransaccion.Name = "col_FechaTransaccion";
            // 
            // col_FormaPago
            // 
            this.col_FormaPago.FieldName = "_FormaPago";
            this.col_FormaPago.Name = "col_FormaPago";
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.FieldName = "_IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            // 
            // col_IdEmpresaServicio
            // 
            this.col_IdEmpresaServicio.FieldName = "_IdEmpresaServicio";
            this.col_IdEmpresaServicio.Name = "col_IdEmpresaServicio";
            // 
            // col_IdFrecuencia
            // 
            this.col_IdFrecuencia.FieldName = "_IdFrecuencia";
            this.col_IdFrecuencia.Name = "col_IdFrecuencia";
            // 
            // col_IdProveedor
            // 
            this.col_IdProveedor.Caption = "Proveedor";
            this.col_IdProveedor.FieldName = "_NumCuentaPorPagar";
            this.col_IdProveedor.Name = "col_IdProveedor";
            this.col_IdProveedor.Visible = true;
            this.col_IdProveedor.VisibleIndex = 0;
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.FieldName = "_IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // col_Motivo
            // 
            this.col_Motivo.FieldName = "_Motivo";
            this.col_Motivo.Name = "col_Motivo";
            // 
            // col_NumCuentaPorPagar
            // 
            this.col_NumCuentaPorPagar.Caption = "Numero Cuenta Por Pagar";
            this.col_NumCuentaPorPagar.FieldName = "_NumCuentaPorPagar";
            this.col_NumCuentaPorPagar.Name = "col_NumCuentaPorPagar";
            // 
            // col_NumeroLetra
            // 
            this.col_NumeroLetra.FieldName = "_NumeroLetra";
            this.col_NumeroLetra.Name = "col_NumeroLetra";
            // 
            // col_NumIngresoEgreso
            // 
            this.col_NumIngresoEgreso.FieldName = "_NumIngresoEgreso";
            this.col_NumIngresoEgreso.Name = "col_NumIngresoEgreso";
            // 
            // col_SaldoDeuda
            // 
            this.col_SaldoDeuda.FieldName = "_SaldoDeuda";
            this.col_SaldoDeuda.Name = "col_SaldoDeuda";
            // 
            // col_Subtotal
            // 
            this.col_Subtotal.FieldName = "_Subtotal";
            this.col_Subtotal.Name = "col_Subtotal";
            // 
            // col_Total
            // 
            this.col_Total.FieldName = "_Total";
            this.col_Total.Name = "col_Total";
            // 
            // col_ValorEntrada
            // 
            this.col_ValorEntrada.FieldName = "_ValorEntrada";
            this.col_ValorEntrada.Name = "col_ValorEntrada";
            // 
            // col_ValorLetra
            // 
            this.col_ValorLetra.FieldName = "_ValorLetra";
            this.col_ValorLetra.Name = "col_ValorLetra";
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Location = new System.Drawing.Point(440, 416);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(160, 30);
            this.btnGenerarComprobante.TabIndex = 40;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            this.btnGenerarComprobante.Click += new System.EventHandler(this.btnGenerarComprobante_Click);
            // 
            // frmOrdenPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 482);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.cbxProveed);
            this.Controls.Add(this.deFechaActual);
            this.Controls.Add(this.gdcOrdenPago);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtEfectivoDisponible);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmOrdenPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Pago";
            this.Load += new System.EventHandler(this.frmOrdenPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcOrdenPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcOrdenPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrden;
        private DevExpress.XtraGrid.Columns.GridColumn colNúmeroRegistroCXP;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPagosRealizar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizarPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.TextEdit txtEfectivoDisponible;
        private DevExpress.XtraEditors.TextEdit txtTotalPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gdcNumLetrasAPagar;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gdcFechaVencimiento;
        private System.Windows.Forms.BindingSource clsEmpresaServicioBindingSource;
        private System.Windows.Forms.BindingSource clsCuentaPorPagarDetalleBindingSource;
        private System.Windows.Forms.BindingSource clsOrdenPagoDetBindingSource;
        private DevExpress.XtraEditors.DateEdit deFechaActual;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxProveed;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.BindingSource clsCuentaPorPagarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCuentaPorPagarDetalle;
        private DevExpress.XtraEditors.SimpleButton btnGenerarComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn col_Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn col_Detalle;
        private DevExpress.XtraGrid.Columns.GridColumn col_Factura;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresaServicio;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdFrecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumCuentaPorPagar;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumeroLetra;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumIngresoEgreso;
        private DevExpress.XtraGrid.Columns.GridColumn col_SaldoDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn col_Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_Total;
        private DevExpress.XtraGrid.Columns.GridColumn col_ValorEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn col_ValorLetra;
    }
}