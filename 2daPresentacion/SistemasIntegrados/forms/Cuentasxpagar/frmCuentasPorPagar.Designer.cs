namespace forms.Cuentasxpagar
{
    partial class frmCuentasPorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCuentasPorPagar));
            this.label3 = new System.Windows.Forms.Label();
            this.grpDetallePagos = new System.Windows.Forms.GroupBox();
            this.btnGenerarPagos = new DevExpress.XtraEditors.SimpleButton();
            this.rdbFormaPago = new DevExpress.XtraEditors.RadioGroup();
            this.gpbDetCredito = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNroLetras = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorEntrada = new DevExpress.XtraEditors.TextEdit();
            this.txtDeuda = new DevExpress.XtraEditors.TextEdit();
            this.cbxFrecuencia = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsFrecuenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdFrecuenciaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.txtValorCadaLetra = new DevExpress.XtraEditors.TextEdit();
            this.txtNroCtaPag = new DevExpress.XtraEditors.TextEdit();
            this.gpbDetValores = new System.Windows.Forms.GroupBox();
            this.gpbImpuestos = new System.Windows.Forms.GroupBox();
            this.cbxImpuesto2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsImpuestosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sluImpuesto2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdImpuesto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxImpuesto1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.sluImpuesto1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdImpuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorcentaje = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtImpuesto2 = new DevExpress.XtraEditors.TextEdit();
            this.txtImpuesto1 = new DevExpress.XtraEditors.TextEdit();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.txtDescuento = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbDocumento = new System.Windows.Forms.GroupBox();
            this.dtpFechaTransaccion = new DevExpress.XtraEditors.DateEdit();
            this.txtDetalle = new DevExpress.XtraEditors.MemoEdit();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.txtNroFactura = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMotivo = new DevExpress.XtraEditors.TextEdit();
            this.txtRucProveedor = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxNroOrdenCompra = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.dtpFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.grpDetallePagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbFormaPago.Properties)).BeginInit();
            this.gpbDetCredito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroLetras.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeuda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFrecuencia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCadaLetra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCtaPag.Properties)).BeginInit();
            this.gpbDetValores.SuspendLayout();
            this.gpbImpuestos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImpuesto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluImpuesto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImpuesto1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluImpuesto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).BeginInit();
            this.gpbDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTransaccion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTransaccion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRucProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroOrdenCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nro de Cta. por Pag.:";
            // 
            // grpDetallePagos
            // 
            this.grpDetallePagos.Controls.Add(this.btnGenerarPagos);
            this.grpDetallePagos.Controls.Add(this.rdbFormaPago);
            this.grpDetallePagos.Controls.Add(this.gpbDetCredito);
            this.grpDetallePagos.Location = new System.Drawing.Point(9, 372);
            this.grpDetallePagos.Name = "grpDetallePagos";
            this.grpDetallePagos.Size = new System.Drawing.Size(1002, 152);
            this.grpDetallePagos.TabIndex = 28;
            this.grpDetallePagos.TabStop = false;
            this.grpDetallePagos.Text = "Detalle de Pagos";
            // 
            // btnGenerarPagos
            // 
            this.btnGenerarPagos.Enabled = false;
            this.btnGenerarPagos.Location = new System.Drawing.Point(789, 75);
            this.btnGenerarPagos.Name = "btnGenerarPagos";
            this.btnGenerarPagos.Size = new System.Drawing.Size(107, 23);
            this.btnGenerarPagos.TabIndex = 19;
            this.btnGenerarPagos.Text = "Generar pagos";
            this.btnGenerarPagos.Click += new System.EventHandler(this.btnGenerarPagos_Click);
            // 
            // rdbFormaPago
            // 
            this.rdbFormaPago.Location = new System.Drawing.Point(110, 37);
            this.rdbFormaPago.Name = "rdbFormaPago";
            this.rdbFormaPago.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Contado"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Crédito")});
            this.rdbFormaPago.Size = new System.Drawing.Size(198, 96);
            this.rdbFormaPago.TabIndex = 0;
            this.rdbFormaPago.SelectedIndexChanged += new System.EventHandler(this.rdbFormaPago_SelectedIndexChanged);
            // 
            // gpbDetCredito
            // 
            this.gpbDetCredito.Controls.Add(this.label15);
            this.gpbDetCredito.Controls.Add(this.txtNroLetras);
            this.gpbDetCredito.Controls.Add(this.label18);
            this.gpbDetCredito.Controls.Add(this.label14);
            this.gpbDetCredito.Controls.Add(this.txtValorEntrada);
            this.gpbDetCredito.Controls.Add(this.txtDeuda);
            this.gpbDetCredito.Controls.Add(this.cbxFrecuencia);
            this.gpbDetCredito.Controls.Add(this.label13);
            this.gpbDetCredito.Controls.Add(this.txtValorCadaLetra);
            this.gpbDetCredito.Enabled = false;
            this.gpbDetCredito.Location = new System.Drawing.Point(348, 19);
            this.gpbDetCredito.Name = "gpbDetCredito";
            this.gpbDetCredito.Size = new System.Drawing.Size(403, 127);
            this.gpbDetCredito.TabIndex = 18;
            this.gpbDetCredito.TabStop = false;
            this.gpbDetCredito.Text = "Detalle de Crédito";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nro. de Letras:";
            // 
            // txtNroLetras
            // 
            this.txtNroLetras.Location = new System.Drawing.Point(270, 69);
            this.txtNroLetras.Name = "txtNroLetras";
            this.txtNroLetras.Properties.Mask.EditMask = "###";
            this.txtNroLetras.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNroLetras.Size = new System.Drawing.Size(28, 20);
            this.txtNroLetras.TabIndex = 2;
            this.txtNroLetras.EditValueChanged += new System.EventHandler(this.txtNroLetras_EditValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(17, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Valor de entrada:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Deuda:";
            // 
            // txtValorEntrada
            // 
            this.txtValorEntrada.Location = new System.Drawing.Point(270, 17);
            this.txtValorEntrada.Name = "txtValorEntrada";
            this.txtValorEntrada.Properties.Mask.EditMask = "#############.##";
            this.txtValorEntrada.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorEntrada.Size = new System.Drawing.Size(124, 20);
            this.txtValorEntrada.TabIndex = 0;
            this.txtValorEntrada.EditValueChanged += new System.EventHandler(this.txtValorEntrada_EditValueChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Enabled = false;
            this.txtDeuda.Location = new System.Drawing.Point(270, 43);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Properties.Mask.EditMask = "d";
            this.txtDeuda.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDeuda.Size = new System.Drawing.Size(124, 20);
            this.txtDeuda.TabIndex = 1;
            // 
            // cbxFrecuencia
            // 
            this.cbxFrecuencia.EditValue = "";
            this.cbxFrecuencia.Location = new System.Drawing.Point(304, 69);
            this.cbxFrecuencia.Name = "cbxFrecuencia";
            this.cbxFrecuencia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFrecuencia.Properties.DataSource = this.clsFrecuenciaBindingSource;
            this.cbxFrecuencia.Properties.DisplayMember = "_Descripcion";
            this.cbxFrecuencia.Properties.ValueMember = "_IdFrecuenciaPago";
            this.cbxFrecuencia.Properties.View = this.gridView1;
            this.cbxFrecuencia.Size = new System.Drawing.Size(90, 20);
            this.cbxFrecuencia.TabIndex = 3;
            // 
            // clsFrecuenciaBindingSource
            // 
            this.clsFrecuenciaBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsFrecuencia);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdFrecuenciaPago,
            this.col_Descripcion,
            this.col_Estado,
            this.col_FechaActual,
            this.col_IdEmpresa,
            this.col_IdUsuario});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdFrecuenciaPago
            // 
            this.col_IdFrecuenciaPago.AppearanceHeader.Options.UseTextOptions = true;
            this.col_IdFrecuenciaPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_IdFrecuenciaPago.Caption = "Código";
            this.col_IdFrecuenciaPago.FieldName = "_IdFrecuenciaPago";
            this.col_IdFrecuenciaPago.Name = "col_IdFrecuenciaPago";
            this.col_IdFrecuenciaPago.Visible = true;
            this.col_IdFrecuenciaPago.VisibleIndex = 1;
            // 
            // col_Descripcion
            // 
            this.col_Descripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Descripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Descripcion.Caption = "Descripción";
            this.col_Descripcion.FieldName = "_Descripcion";
            this.col_Descripcion.Name = "col_Descripcion";
            this.col_Descripcion.Visible = true;
            this.col_Descripcion.VisibleIndex = 0;
            // 
            // col_Estado
            // 
            this.col_Estado.FieldName = "_Estado";
            this.col_Estado.Name = "col_Estado";
            // 
            // col_FechaActual
            // 
            this.col_FechaActual.FieldName = "_FechaActual";
            this.col_FechaActual.Name = "col_FechaActual";
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.FieldName = "_IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.FieldName = "_IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Valor de cada letra:";
            // 
            // txtValorCadaLetra
            // 
            this.txtValorCadaLetra.EditValue = "";
            this.txtValorCadaLetra.Enabled = false;
            this.txtValorCadaLetra.Location = new System.Drawing.Point(270, 96);
            this.txtValorCadaLetra.Name = "txtValorCadaLetra";
            this.txtValorCadaLetra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtValorCadaLetra.Properties.Appearance.Options.UseFont = true;
            this.txtValorCadaLetra.Properties.Mask.EditMask = "f0";
            this.txtValorCadaLetra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtValorCadaLetra.Size = new System.Drawing.Size(124, 20);
            this.txtValorCadaLetra.TabIndex = 4;
            // 
            // txtNroCtaPag
            // 
            this.txtNroCtaPag.Enabled = false;
            this.txtNroCtaPag.Location = new System.Drawing.Point(116, 32);
            this.txtNroCtaPag.Name = "txtNroCtaPag";
            this.txtNroCtaPag.Properties.Mask.EditMask = "c";
            this.txtNroCtaPag.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNroCtaPag.Size = new System.Drawing.Size(108, 20);
            this.txtNroCtaPag.TabIndex = 22;
            // 
            // gpbDetValores
            // 
            this.gpbDetValores.Controls.Add(this.gpbImpuestos);
            this.gpbDetValores.Controls.Add(this.txtTotal);
            this.gpbDetValores.Controls.Add(this.txtSubTotal);
            this.gpbDetValores.Controls.Add(this.txtDescuento);
            this.gpbDetValores.Controls.Add(this.label12);
            this.gpbDetValores.Controls.Add(this.label10);
            this.gpbDetValores.Controls.Add(this.label11);
            this.gpbDetValores.Enabled = false;
            this.gpbDetValores.Location = new System.Drawing.Point(10, 215);
            this.gpbDetValores.Name = "gpbDetValores";
            this.gpbDetValores.Size = new System.Drawing.Size(1002, 140);
            this.gpbDetValores.TabIndex = 29;
            this.gpbDetValores.TabStop = false;
            this.gpbDetValores.Text = "Detalle de Valores";
            // 
            // gpbImpuestos
            // 
            this.gpbImpuestos.Controls.Add(this.cbxImpuesto2);
            this.gpbImpuestos.Controls.Add(this.cbxImpuesto1);
            this.gpbImpuestos.Controls.Add(this.txtImpuesto2);
            this.gpbImpuestos.Controls.Add(this.txtImpuesto1);
            this.gpbImpuestos.Location = new System.Drawing.Point(347, 13);
            this.gpbImpuestos.Name = "gpbImpuestos";
            this.gpbImpuestos.Size = new System.Drawing.Size(369, 121);
            this.gpbImpuestos.TabIndex = 5;
            this.gpbImpuestos.TabStop = false;
            this.gpbImpuestos.Text = "Impuestos";
            // 
            // cbxImpuesto2
            // 
            this.cbxImpuesto2.EditValue = "";
            this.cbxImpuesto2.Enabled = false;
            this.cbxImpuesto2.Location = new System.Drawing.Point(16, 64);
            this.cbxImpuesto2.Name = "cbxImpuesto2";
            this.cbxImpuesto2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImpuesto2.Properties.DataSource = this.clsImpuestosBindingSource;
            this.cbxImpuesto2.Properties.DisplayMember = "Descripcion";
            this.cbxImpuesto2.Properties.ValueMember = "IdImpuesto";
            this.cbxImpuesto2.Properties.View = this.sluImpuesto2;
            this.cbxImpuesto2.Size = new System.Drawing.Size(145, 20);
            this.cbxImpuesto2.TabIndex = 0;
            this.cbxImpuesto2.EditValueChanged += new System.EventHandler(this.cbxImpuesto2_EditValueChanged);
            // 
            // clsImpuestosBindingSource
            // 
            this.clsImpuestosBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsImpuestos);
            // 
            // sluImpuesto2
            // 
            this.sluImpuesto2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdImpuesto1,
            this.colDescripcion1,
            this.colFechaRegistro1,
            this.colIdEmpresa1,
            this.colIdEstado1,
            this.colIdUsuario1,
            this.colPorcentaje1});
            this.sluImpuesto2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.sluImpuesto2.Name = "sluImpuesto2";
            this.sluImpuesto2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.sluImpuesto2.OptionsView.ShowGroupPanel = false;
            // 
            // colIdImpuesto1
            // 
            this.colIdImpuesto1.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdImpuesto1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdImpuesto1.Caption = "Código";
            this.colIdImpuesto1.FieldName = "IdImpuesto";
            this.colIdImpuesto1.Name = "colIdImpuesto1";
            this.colIdImpuesto1.Visible = true;
            this.colIdImpuesto1.VisibleIndex = 0;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion1.Caption = "Descripción";
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 1;
            // 
            // colFechaRegistro1
            // 
            this.colFechaRegistro1.FieldName = "FechaRegistro";
            this.colFechaRegistro1.Name = "colFechaRegistro1";
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            // 
            // colIdEstado1
            // 
            this.colIdEstado1.FieldName = "IdEstado";
            this.colIdEstado1.Name = "colIdEstado1";
            // 
            // colIdUsuario1
            // 
            this.colIdUsuario1.FieldName = "IdUsuario";
            this.colIdUsuario1.Name = "colIdUsuario1";
            // 
            // colPorcentaje1
            // 
            this.colPorcentaje1.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorcentaje1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPorcentaje1.Caption = "Porcentaje";
            this.colPorcentaje1.FieldName = "Porcentaje";
            this.colPorcentaje1.Name = "colPorcentaje1";
            this.colPorcentaje1.Visible = true;
            this.colPorcentaje1.VisibleIndex = 2;
            // 
            // cbxImpuesto1
            // 
            this.cbxImpuesto1.EditValue = "";
            this.cbxImpuesto1.Enabled = false;
            this.cbxImpuesto1.Location = new System.Drawing.Point(16, 30);
            this.cbxImpuesto1.Name = "cbxImpuesto1";
            this.cbxImpuesto1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxImpuesto1.Properties.DataSource = this.clsImpuestosBindingSource;
            this.cbxImpuesto1.Properties.DisplayMember = "Descripcion";
            this.cbxImpuesto1.Properties.ValueMember = "IdImpuesto";
            this.cbxImpuesto1.Properties.View = this.sluImpuesto1;
            this.cbxImpuesto1.Size = new System.Drawing.Size(145, 20);
            this.cbxImpuesto1.TabIndex = 0;
            this.cbxImpuesto1.EditValueChanged += new System.EventHandler(this.cbxImpuesto1_EditValueChanged);
            // 
            // sluImpuesto1
            // 
            this.sluImpuesto1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdImpuesto,
            this.colFechaRegistro,
            this.colDescripcion,
            this.colIdEmpresa,
            this.colIdEstado,
            this.colIdUsuario,
            this.colPorcentaje});
            this.sluImpuesto1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.sluImpuesto1.Name = "sluImpuesto1";
            this.sluImpuesto1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.sluImpuesto1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdImpuesto
            // 
            this.colIdImpuesto.AppearanceHeader.Options.UseTextOptions = true;
            this.colIdImpuesto.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIdImpuesto.Caption = "Código";
            this.colIdImpuesto.FieldName = "IdImpuesto";
            this.colIdImpuesto.Name = "colIdImpuesto";
            this.colIdImpuesto.Visible = true;
            this.colIdImpuesto.VisibleIndex = 1;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            // 
            // colDescripcion
            // 
            this.colDescripcion.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescripcion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescripcion.Caption = "Descripción";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colPorcentaje
            // 
            this.colPorcentaje.AppearanceHeader.Options.UseTextOptions = true;
            this.colPorcentaje.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPorcentaje.Caption = "Porcentaje";
            this.colPorcentaje.FieldName = "Porcentaje";
            this.colPorcentaje.Name = "colPorcentaje";
            this.colPorcentaje.Visible = true;
            this.colPorcentaje.VisibleIndex = 2;
            // 
            // txtImpuesto2
            // 
            this.txtImpuesto2.Enabled = false;
            this.txtImpuesto2.Location = new System.Drawing.Point(255, 65);
            this.txtImpuesto2.Name = "txtImpuesto2";
            this.txtImpuesto2.Properties.Mask.EditMask = "#############.##";
            this.txtImpuesto2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtImpuesto2.Size = new System.Drawing.Size(108, 20);
            this.txtImpuesto2.TabIndex = 0;
            this.txtImpuesto2.EditValueChanged += new System.EventHandler(this.txtImpuesto2_EditValueChanged);
            // 
            // txtImpuesto1
            // 
            this.txtImpuesto1.Enabled = false;
            this.txtImpuesto1.Location = new System.Drawing.Point(255, 30);
            this.txtImpuesto1.Name = "txtImpuesto1";
            this.txtImpuesto1.Properties.Mask.EditMask = "#############.##";
            this.txtImpuesto1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtImpuesto1.Size = new System.Drawing.Size(108, 20);
            this.txtImpuesto1.TabIndex = 0;
            this.txtImpuesto1.EditValueChanged += new System.EventHandler(this.txtImpuesto1_EditValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.EditValue = "";
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(883, 77);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Mask.EditMask = "c";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Size = new System.Drawing.Size(108, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(156, 43);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Properties.Mask.EditMask = "#############.##";
            this.txtSubTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSubTotal.Size = new System.Drawing.Size(108, 20);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.EditValueChanged += new System.EventHandler(this.txtSubTotal_EditValueChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Enabled = false;
            this.txtDescuento.Location = new System.Drawing.Point(156, 77);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Properties.Mask.EditMask = "#############.##";
            this.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDescuento.Size = new System.Drawing.Size(108, 20);
            this.txtDescuento.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(803, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Descuento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sub-Total:";
            // 
            // gpbDocumento
            // 
            this.gpbDocumento.Controls.Add(this.dtpFechaTransaccion);
            this.gpbDocumento.Controls.Add(this.txtDetalle);
            this.gpbDocumento.Controls.Add(this.btnBuscarProveedor);
            this.gpbDocumento.Controls.Add(this.txtNroFactura);
            this.gpbDocumento.Controls.Add(this.label8);
            this.gpbDocumento.Controls.Add(this.label16);
            this.gpbDocumento.Controls.Add(this.txtMotivo);
            this.gpbDocumento.Controls.Add(this.txtRucProveedor);
            this.gpbDocumento.Controls.Add(this.txtNombreProveedor);
            this.gpbDocumento.Controls.Add(this.label4);
            this.gpbDocumento.Controls.Add(this.label6);
            this.gpbDocumento.Controls.Add(this.label1);
            this.gpbDocumento.Enabled = false;
            this.gpbDocumento.Location = new System.Drawing.Point(9, 63);
            this.gpbDocumento.Name = "gpbDocumento";
            this.gpbDocumento.Size = new System.Drawing.Size(1002, 137);
            this.gpbDocumento.TabIndex = 30;
            this.gpbDocumento.TabStop = false;
            this.gpbDocumento.Text = "Documento";
            // 
            // dtpFechaTransaccion
            // 
            this.dtpFechaTransaccion.EditValue = null;
            this.dtpFechaTransaccion.Location = new System.Drawing.Point(789, 26);
            this.dtpFechaTransaccion.Name = "dtpFechaTransaccion";
            this.dtpFechaTransaccion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaTransaccion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaTransaccion.Size = new System.Drawing.Size(203, 20);
            this.dtpFechaTransaccion.TabIndex = 32;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(394, 88);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(598, 43);
            this.txtDetalle.TabIndex = 4;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Location = new System.Drawing.Point(965, 55);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(27, 23);
            this.btnBuscarProveedor.TabIndex = 2;
            this.btnBuscarProveedor.Text = "...";
            this.btnBuscarProveedor.UseVisualStyleBackColor = true;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(81, 26);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Properties.Mask.EditMask = "\\d?\\d?\\d?-\\d?\\d?\\d?-\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.txtNroFactura.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNroFactura.Size = new System.Drawing.Size(201, 20);
            this.txtNroFactura.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(345, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Detalle:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(670, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Fecha de transacción:";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(81, 88);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Properties.Mask.EditMask = "[a-zA-Z ]+";
            this.txtMotivo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMotivo.Size = new System.Drawing.Size(201, 20);
            this.txtMotivo.TabIndex = 2;
            // 
            // txtRucProveedor
            // 
            this.txtRucProveedor.Enabled = false;
            this.txtRucProveedor.Location = new System.Drawing.Point(81, 57);
            this.txtRucProveedor.Name = "txtRucProveedor";
            this.txtRucProveedor.Properties.Mask.EditMask = "c";
            this.txtRucProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRucProveedor.Size = new System.Drawing.Size(201, 20);
            this.txtRucProveedor.TabIndex = 2;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Location = new System.Drawing.Point(292, 57);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Properties.Mask.EditMask = "c";
            this.txtNombreProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNombreProveedor.Size = new System.Drawing.Size(667, 20);
            this.txtNombreProveedor.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nro. Factura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Motivo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Proveedor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(813, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fecha de ingreso:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(383, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Nro. Orden Compra:";
            // 
            // cbxNroOrdenCompra
            // 
            this.cbxNroOrdenCompra.Location = new System.Drawing.Point(486, 32);
            this.cbxNroOrdenCompra.Name = "cbxNroOrdenCompra";
            this.cbxNroOrdenCompra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNroOrdenCompra.Properties.View = this.gridView2;
            this.cbxNroOrdenCompra.Size = new System.Drawing.Size(137, 20);
            this.cbxNroOrdenCompra.TabIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.toolStrip1.Size = new System.Drawing.Size(1019, 25);
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
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            this.tsbConsultar.Click += new System.EventHandler(this.tsbConsultar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(62, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
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
            this.tsbAnular.Click += new System.EventHandler(this.tsbAnular_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(42, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.EditValue = null;
            this.dtpFechaIngreso.Enabled = false;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(911, 32);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaIngreso.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtpFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaIngreso.TabIndex = 32;
            // 
            // frmCuentasPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 536);
            this.Controls.Add(this.dtpFechaIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpDetallePagos);
            this.Controls.Add(this.txtNroCtaPag);
            this.Controls.Add(this.gpbDetValores);
            this.Controls.Add(this.gpbDocumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbxNroOrdenCompra);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmCuentasPorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Pagar";
            this.Load += new System.EventHandler(this.frmCuentasPorPagar_Load);
            this.grpDetallePagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdbFormaPago.Properties)).EndInit();
            this.gpbDetCredito.ResumeLayout(false);
            this.gpbDetCredito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroLetras.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeuda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFrecuencia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsFrecuenciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCadaLetra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroCtaPag.Properties)).EndInit();
            this.gpbDetValores.ResumeLayout(false);
            this.gpbDetValores.PerformLayout();
            this.gpbImpuestos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbxImpuesto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsImpuestosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluImpuesto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxImpuesto1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sluImpuesto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtImpuesto1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuento.Properties)).EndInit();
            this.gpbDocumento.ResumeLayout(false);
            this.gpbDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTransaccion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaTransaccion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRucProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroOrdenCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaIngreso.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpDetallePagos;
        private System.Windows.Forms.GroupBox gpbDetCredito;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txtNroLetras;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txtValorEntrada;
        private DevExpress.XtraEditors.TextEdit txtDeuda;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxFrecuencia;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtValorCadaLetra;
        private DevExpress.XtraEditors.TextEdit txtNroCtaPag;
        private System.Windows.Forms.GroupBox gpbDetValores;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.TextEdit txtDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbDocumento;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private DevExpress.XtraEditors.TextEdit txtNroFactura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txtRucProveedor;
        private DevExpress.XtraEditors.TextEdit txtNombreProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxNroOrdenCompra;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private DevExpress.XtraEditors.MemoEdit txtDetalle;
        private DevExpress.XtraEditors.RadioGroup rdbFormaPago;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.GroupBox gpbImpuestos;
        private DevExpress.XtraEditors.DateEdit dtpFechaTransaccion;
        private DevExpress.XtraEditors.DateEdit dtpFechaIngreso;
        private DevExpress.XtraEditors.TextEdit txtMotivo;
        private DevExpress.XtraEditors.SimpleButton btnGenerarPagos;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxImpuesto2;
        private System.Windows.Forms.BindingSource clsImpuestosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView sluImpuesto2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxImpuesto1;
        private DevExpress.XtraGrid.Views.Grid.GridView sluImpuesto1;
        private DevExpress.XtraEditors.TextEdit txtImpuesto2;
        private DevExpress.XtraEditors.TextEdit txtImpuesto1;
        private System.Windows.Forms.BindingSource clsFrecuenciaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdFrecuenciaPago;
        private DevExpress.XtraGrid.Columns.GridColumn col_Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaActual;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImpuesto1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario1;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImpuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colPorcentaje;
    }
}