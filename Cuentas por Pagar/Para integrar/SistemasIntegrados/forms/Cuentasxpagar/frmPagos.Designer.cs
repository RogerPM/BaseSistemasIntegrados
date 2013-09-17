namespace forms.Cuentasxpagar
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdcDetalleNomina = new DevExpress.XtraGrid.GridControl();
            this.clsPagoDetalleDosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMedioPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCuenta2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumComprobante1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNominaCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPago1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcdetalle = new DevExpress.XtraGrid.GridControl();
            this.clsPagoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMedioPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxcuenta = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsCuentaBancariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.cbxBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxMedioPago = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsMedioPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMonto = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new DevExpress.XtraEditors.TextEdit();
            this.tbcPagos = new System.Windows.Forms.TabControl();
            this.tbpProveedores = new System.Windows.Forms.TabPage();
            this.gdcDetalleOrdenPago = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenPagoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCuentaPorPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDetalleDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroPagosRealizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalito = new DevExpress.XtraEditors.TextEdit();
            this.tbpEmpleados = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalEmpleado = new DevExpress.XtraEditors.TextEdit();
            this.gdcNomina = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenPagoEmpleadoDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumOrdenPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizarPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSueldoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIngresoAdicional = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescuentoTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPagoNeto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tbpServicios = new System.Windows.Forms.TabPage();
            this.gdcDeudaServicio = new DevExpress.XtraGrid.GridControl();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumCuentaPorPagar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDetalleDeuda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoDeuda1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroPagosRealizar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumOrdenCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsNominaCabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNroOrdenPagoProveedores = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.clsOrdenPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.searchLookUpEdit4View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumPago = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.deFechaActual = new DevExpress.XtraEditors.DateEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnConsultar = new DevExpress.XtraEditors.SimpleButton();
            this.gdcConsultaBancaria = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCuentaBancaria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidBanco1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCuenta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.clsNominaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxEmpleado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxVarios = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleDosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcdetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcuenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBancariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMedioPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).BeginInit();
            this.tbcPagos.SuspendLayout();
            this.tbpProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleOrdenPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalito.Properties)).BeginInit();
            this.tbpEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoEmpleadoDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            this.tbpServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDeudaServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaCabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroOrdenPagoProveedores.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaBancaria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxVarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gdcDetalleNomina);
            this.groupBox1.Controls.Add(this.gdcdetalle);
            this.groupBox1.Controls.Add(this.cbxcuenta);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.cbxBanco);
            this.groupBox1.Controls.Add(this.cbxMedioPago);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(255, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 121);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medio de Pago";
            // 
            // gdcDetalleNomina
            // 
            this.gdcDetalleNomina.DataSource = this.clsPagoDetalleDosBindingSource;
            this.gdcDetalleNomina.Location = new System.Drawing.Point(388, 19);
            this.gdcDetalleNomina.MainView = this.gridView5;
            this.gdcDetalleNomina.Name = "gdcDetalleNomina";
            this.gdcDetalleNomina.Size = new System.Drawing.Size(340, 102);
            this.gdcDetalleNomina.TabIndex = 10;
            this.gdcDetalleNomina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            this.gdcDetalleNomina.Visible = false;
            // 
            // clsPagoDetalleDosBindingSource
            // 
            this.clsPagoDetalleDosBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsPagoDetalleDos);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea2,
            this.colIdMedioPago1,
            this.colMonto1,
            this.colNumeroCuenta2,
            this.colIdEmpresa,
            this.colIdBanco2,
            this.colNumComprobante1,
            this.colNumNominaCab,
            this.colNumPago1});
            this.gridView5.GridControl = this.gdcDetalleNomina;
            this.gridView5.Name = "gridView5";
            // 
            // colNumLinea2
            // 
            this.colNumLinea2.FieldName = "NumLinea";
            this.colNumLinea2.Name = "colNumLinea2";
            this.colNumLinea2.OptionsColumn.AllowEdit = false;
            this.colNumLinea2.Visible = true;
            this.colNumLinea2.VisibleIndex = 0;
            // 
            // colIdMedioPago1
            // 
            this.colIdMedioPago1.FieldName = "IdMedioPago";
            this.colIdMedioPago1.Name = "colIdMedioPago1";
            this.colIdMedioPago1.OptionsColumn.AllowEdit = false;
            this.colIdMedioPago1.Visible = true;
            this.colIdMedioPago1.VisibleIndex = 1;
            // 
            // colMonto1
            // 
            this.colMonto1.FieldName = "Monto";
            this.colMonto1.Name = "colMonto1";
            this.colMonto1.OptionsColumn.AllowEdit = false;
            this.colMonto1.Visible = true;
            this.colMonto1.VisibleIndex = 2;
            // 
            // colNumeroCuenta2
            // 
            this.colNumeroCuenta2.FieldName = "NumeroCuenta";
            this.colNumeroCuenta2.Name = "colNumeroCuenta2";
            this.colNumeroCuenta2.OptionsColumn.AllowEdit = false;
            this.colNumeroCuenta2.Visible = true;
            this.colNumeroCuenta2.VisibleIndex = 3;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.OptionsColumn.AllowEdit = false;
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 4;
            // 
            // colIdBanco2
            // 
            this.colIdBanco2.FieldName = "IdBanco";
            this.colIdBanco2.Name = "colIdBanco2";
            this.colIdBanco2.OptionsColumn.AllowEdit = false;
            this.colIdBanco2.Visible = true;
            this.colIdBanco2.VisibleIndex = 5;
            // 
            // colNumComprobante1
            // 
            this.colNumComprobante1.FieldName = "NumComprobante";
            this.colNumComprobante1.Name = "colNumComprobante1";
            this.colNumComprobante1.OptionsColumn.AllowEdit = false;
            this.colNumComprobante1.Visible = true;
            this.colNumComprobante1.VisibleIndex = 6;
            // 
            // colNumNominaCab
            // 
            this.colNumNominaCab.FieldName = "NumNominaCab";
            this.colNumNominaCab.Name = "colNumNominaCab";
            this.colNumNominaCab.OptionsColumn.AllowEdit = false;
            this.colNumNominaCab.Visible = true;
            this.colNumNominaCab.VisibleIndex = 7;
            // 
            // colNumPago1
            // 
            this.colNumPago1.FieldName = "NumPago";
            this.colNumPago1.Name = "colNumPago1";
            this.colNumPago1.OptionsColumn.AllowEdit = false;
            this.colNumPago1.Visible = true;
            this.colNumPago1.VisibleIndex = 8;
            // 
            // gdcdetalle
            // 
            this.gdcdetalle.DataSource = this.clsPagoDetalleBindingSource;
            this.gdcdetalle.Location = new System.Drawing.Point(388, 19);
            this.gdcdetalle.MainView = this.gridView1;
            this.gdcdetalle.Name = "gdcdetalle";
            this.gdcdetalle.Size = new System.Drawing.Size(340, 102);
            this.gdcdetalle.TabIndex = 9;
            this.gdcdetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsPagoDetalleBindingSource
            // 
            this.clsPagoDetalleBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsPagoDetalle);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea1,
            this.colIdMedioPago,
            this.colMonto,
            this.colNumeroCuenta,
            this.colIdEmpresa1,
            this.colIdBanco,
            this.colNumComprobante,
            this.colNumPago});
            this.gridView1.GridControl = this.gdcdetalle;
            this.gridView1.Name = "gridView1";
            // 
            // colNumLinea1
            // 
            this.colNumLinea1.FieldName = "NumLinea";
            this.colNumLinea1.Name = "colNumLinea1";
            this.colNumLinea1.Visible = true;
            this.colNumLinea1.VisibleIndex = 0;
            // 
            // colIdMedioPago
            // 
            this.colIdMedioPago.FieldName = "IdMedioPago";
            this.colIdMedioPago.Name = "colIdMedioPago";
            this.colIdMedioPago.Visible = true;
            this.colIdMedioPago.VisibleIndex = 1;
            // 
            // colMonto
            // 
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 2;
            // 
            // colNumeroCuenta
            // 
            this.colNumeroCuenta.FieldName = "NumeroCuenta";
            this.colNumeroCuenta.Name = "colNumeroCuenta";
            this.colNumeroCuenta.Visible = true;
            this.colNumeroCuenta.VisibleIndex = 3;
            // 
            // colIdEmpresa1
            // 
            this.colIdEmpresa1.FieldName = "IdEmpresa";
            this.colIdEmpresa1.Name = "colIdEmpresa1";
            this.colIdEmpresa1.Visible = true;
            this.colIdEmpresa1.VisibleIndex = 4;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 5;
            // 
            // colNumComprobante
            // 
            this.colNumComprobante.FieldName = "NumComprobante";
            this.colNumComprobante.Name = "colNumComprobante";
            this.colNumComprobante.Visible = true;
            this.colNumComprobante.VisibleIndex = 6;
            // 
            // colNumPago
            // 
            this.colNumPago.FieldName = "NumPago";
            this.colNumPago.Name = "colNumPago";
            this.colNumPago.Visible = true;
            this.colNumPago.VisibleIndex = 7;
            // 
            // cbxcuenta
            // 
            this.cbxcuenta.Location = new System.Drawing.Point(235, 59);
            this.cbxcuenta.Name = "cbxcuenta";
            this.cbxcuenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxcuenta.Properties.DataSource = this.clsCuentaBancariaBindingSource;
            this.cbxcuenta.Properties.DisplayMember = "NumeroCuenta";
            this.cbxcuenta.Properties.ValueMember = "idCuentaBancaria";
            this.cbxcuenta.Properties.View = this.gridView6;
            this.cbxcuenta.Size = new System.Drawing.Size(102, 20);
            this.cbxcuenta.TabIndex = 8;
            // 
            // clsCuentaBancariaBindingSource
            // 
            this.clsCuentaBancariaBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsCuentaBancaria);
            // 
            // gridView6
            // 
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(235, 89);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(41, 89);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(138, 89);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cbxBanco
            // 
            this.cbxBanco.Location = new System.Drawing.Point(49, 59);
            this.cbxBanco.Name = "cbxBanco";
            this.cbxBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBanco.Properties.DataSource = this.clsBancoBindingSource;
            this.cbxBanco.Properties.DisplayMember = "Nombre";
            this.cbxBanco.Properties.ValueMember = "idBanco";
            this.cbxBanco.Properties.View = this.gridView10;
            this.cbxBanco.Size = new System.Drawing.Size(87, 20);
            this.cbxBanco.TabIndex = 2;
            // 
            // clsBancoBindingSource
            // 
            this.clsBancoBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsBanco);
            // 
            // gridView10
            // 
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // cbxMedioPago
            // 
            this.cbxMedioPago.Location = new System.Drawing.Point(49, 23);
            this.cbxMedioPago.Name = "cbxMedioPago";
            this.cbxMedioPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMedioPago.Properties.DataSource = this.clsMedioPagoBindingSource;
            this.cbxMedioPago.Properties.DisplayMember = "Descripcion";
            this.cbxMedioPago.Properties.ValueMember = "IdMedioPago";
            this.cbxMedioPago.Properties.View = this.gridView9;
            this.cbxMedioPago.Size = new System.Drawing.Size(87, 20);
            this.cbxMedioPago.TabIndex = 0;
            // 
            // clsMedioPagoBindingSource
            // 
            this.clsMedioPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsMedioPago);
            // 
            // gridView9
            // 
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(231, 23);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Properties.Mask.EditMask = "d";
            this.txtMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtMonto.Size = new System.Drawing.Size(106, 20);
            this.txtMonto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nro. Cta. / Ch.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Banco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Medio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(709, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total a Pagar:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(797, 517);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(172, 20);
            this.txtTotalPagar.TabIndex = 24;
            // 
            // tbcPagos
            // 
            this.tbcPagos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcPagos.Controls.Add(this.tbpProveedores);
            this.tbcPagos.Controls.Add(this.tbpEmpleados);
            this.tbcPagos.Controls.Add(this.tbpServicios);
            this.tbcPagos.Location = new System.Drawing.Point(12, 116);
            this.tbcPagos.Multiline = true;
            this.tbcPagos.Name = "tbcPagos";
            this.tbcPagos.SelectedIndex = 0;
            this.tbcPagos.Size = new System.Drawing.Size(977, 262);
            this.tbcPagos.TabIndex = 22;
            this.tbcPagos.Tag = "";
            this.tbcPagos.SelectedIndexChanged += new System.EventHandler(this.frmPago_event_click);
            // 
            // tbpProveedores
            // 
            this.tbpProveedores.BackColor = System.Drawing.Color.Transparent;
            this.tbpProveedores.Controls.Add(this.gdcDetalleOrdenPago);
            this.tbpProveedores.Controls.Add(this.label8);
            this.tbpProveedores.Controls.Add(this.txtTotalito);
            this.tbpProveedores.Location = new System.Drawing.Point(23, 4);
            this.tbpProveedores.Name = "tbpProveedores";
            this.tbpProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProveedores.Size = new System.Drawing.Size(950, 254);
            this.tbpProveedores.TabIndex = 0;
            this.tbpProveedores.Text = "Proveedores";
            // 
            // gdcDetalleOrdenPago
            // 
            this.gdcDetalleOrdenPago.DataSource = this.clsOrdenPagoDetalleBindingSource;
            this.gdcDetalleOrdenPago.Location = new System.Drawing.Point(23, 14);
            this.gdcDetalleOrdenPago.MainView = this.gridView3;
            this.gdcDetalleOrdenPago.Name = "gdcDetalleOrdenPago";
            this.gdcDetalleOrdenPago.Size = new System.Drawing.Size(907, 191);
            this.gdcDetalleOrdenPago.TabIndex = 0;
            this.gdcDetalleOrdenPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // clsOrdenPagoDetalleBindingSource
            // 
            this.clsOrdenPagoDetalleBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsOrdenPagoDet);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea,
            this.colNumCuentaPorPagar,
            this.colNumDetalleDeuda,
            this.colSaldoDeuda,
            this.colNumeroPagosRealizar,
            this.colTotalPagar});
            this.gridView3.GridControl = this.gdcDetalleOrdenPago;
            this.gridView3.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalPagar", null, "")});
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowAutoFilterRow = true;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colNumLinea
            // 
            this.colNumLinea.FieldName = "NumLinea";
            this.colNumLinea.Name = "colNumLinea";
            this.colNumLinea.OptionsColumn.AllowEdit = false;
            this.colNumLinea.Visible = true;
            this.colNumLinea.VisibleIndex = 0;
            this.colNumLinea.Width = 48;
            // 
            // colNumCuentaPorPagar
            // 
            this.colNumCuentaPorPagar.FieldName = "NumCuentaPorPagar";
            this.colNumCuentaPorPagar.Name = "colNumCuentaPorPagar";
            this.colNumCuentaPorPagar.OptionsColumn.AllowEdit = false;
            this.colNumCuentaPorPagar.Visible = true;
            this.colNumCuentaPorPagar.VisibleIndex = 1;
            this.colNumCuentaPorPagar.Width = 119;
            // 
            // colNumDetalleDeuda
            // 
            this.colNumDetalleDeuda.FieldName = "NumDetalleDeuda";
            this.colNumDetalleDeuda.Name = "colNumDetalleDeuda";
            this.colNumDetalleDeuda.OptionsColumn.AllowEdit = false;
            this.colNumDetalleDeuda.Visible = true;
            this.colNumDetalleDeuda.VisibleIndex = 2;
            this.colNumDetalleDeuda.Width = 103;
            // 
            // colSaldoDeuda
            // 
            this.colSaldoDeuda.FieldName = "SaldoDeuda";
            this.colSaldoDeuda.Name = "colSaldoDeuda";
            this.colSaldoDeuda.OptionsColumn.AllowEdit = false;
            this.colSaldoDeuda.Visible = true;
            this.colSaldoDeuda.VisibleIndex = 3;
            this.colSaldoDeuda.Width = 86;
            // 
            // colNumeroPagosRealizar
            // 
            this.colNumeroPagosRealizar.FieldName = "NumeroPagosRealizar";
            this.colNumeroPagosRealizar.Name = "colNumeroPagosRealizar";
            this.colNumeroPagosRealizar.OptionsColumn.AllowEdit = false;
            this.colNumeroPagosRealizar.Visible = true;
            this.colNumeroPagosRealizar.VisibleIndex = 4;
            this.colNumeroPagosRealizar.Width = 122;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.FieldName = "TotalPagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.OptionsColumn.AllowEdit = false;
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 5;
            this.colTotalPagar.Width = 155;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(733, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total a Pagar:";
            // 
            // txtTotalito
            // 
            this.txtTotalito.Enabled = false;
            this.txtTotalito.Location = new System.Drawing.Point(813, 220);
            this.txtTotalito.Name = "txtTotalito";
            this.txtTotalito.Properties.Mask.EditMask = "c";
            this.txtTotalito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalito.Size = new System.Drawing.Size(117, 20);
            this.txtTotalito.TabIndex = 11;
            // 
            // tbpEmpleados
            // 
            this.tbpEmpleados.Controls.Add(this.label11);
            this.tbpEmpleados.Controls.Add(this.txtTotalEmpleado);
            this.tbpEmpleados.Controls.Add(this.gdcNomina);
            this.tbpEmpleados.Location = new System.Drawing.Point(23, 4);
            this.tbpEmpleados.Name = "tbpEmpleados";
            this.tbpEmpleados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEmpleados.Size = new System.Drawing.Size(950, 254);
            this.tbpEmpleados.TabIndex = 1;
            this.tbpEmpleados.Text = "Empleados";
            this.tbpEmpleados.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(733, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Total a Pagar:";
            // 
            // txtTotalEmpleado
            // 
            this.txtTotalEmpleado.Enabled = false;
            this.txtTotalEmpleado.Location = new System.Drawing.Point(813, 222);
            this.txtTotalEmpleado.Name = "txtTotalEmpleado";
            this.txtTotalEmpleado.Properties.Mask.EditMask = "c";
            this.txtTotalEmpleado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotalEmpleado.Size = new System.Drawing.Size(117, 20);
            this.txtTotalEmpleado.TabIndex = 13;
            // 
            // gdcNomina
            // 
            this.gdcNomina.DataSource = this.clsOrdenPagoEmpleadoDetBindingSource;
            this.gdcNomina.Location = new System.Drawing.Point(23, 15);
            this.gdcNomina.MainView = this.gridView4;
            this.gdcNomina.Name = "gdcNomina";
            this.gdcNomina.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit2});
            this.gdcNomina.Size = new System.Drawing.Size(907, 193);
            this.gdcNomina.TabIndex = 1;
            this.gdcNomina.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // clsOrdenPagoEmpleadoDetBindingSource
            // 
            this.clsOrdenPagoEmpleadoDetBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsOrdenPagoEmpleadoDet);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumOrdenPago,
            this.colIdEmpresa2,
            this.colAutorizarPago,
            this.colLinea,
            this.colIdPersona,
            this.colSueldoTotal,
            this.colIngresoAdicional,
            this.colDescuentoTotal,
            this.colPagoNeto});
            this.gridView4.GridControl = this.gdcNomina;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.ShowAutoFilterRow = true;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colNumOrdenPago
            // 
            this.colNumOrdenPago.FieldName = "NumOrdenPago";
            this.colNumOrdenPago.Name = "colNumOrdenPago";
            this.colNumOrdenPago.Visible = true;
            this.colNumOrdenPago.VisibleIndex = 0;
            // 
            // colIdEmpresa2
            // 
            this.colIdEmpresa2.FieldName = "IdEmpresa";
            this.colIdEmpresa2.Name = "colIdEmpresa2";
            this.colIdEmpresa2.Visible = true;
            this.colIdEmpresa2.VisibleIndex = 1;
            // 
            // colAutorizarPago
            // 
            this.colAutorizarPago.FieldName = "AutorizarPago";
            this.colAutorizarPago.Name = "colAutorizarPago";
            this.colAutorizarPago.Visible = true;
            this.colAutorizarPago.VisibleIndex = 2;
            // 
            // colLinea
            // 
            this.colLinea.FieldName = "Linea";
            this.colLinea.Name = "colLinea";
            this.colLinea.Visible = true;
            this.colLinea.VisibleIndex = 3;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 4;
            // 
            // colSueldoTotal
            // 
            this.colSueldoTotal.FieldName = "SueldoTotal";
            this.colSueldoTotal.Name = "colSueldoTotal";
            this.colSueldoTotal.Visible = true;
            this.colSueldoTotal.VisibleIndex = 5;
            // 
            // colIngresoAdicional
            // 
            this.colIngresoAdicional.FieldName = "IngresoAdicional";
            this.colIngresoAdicional.Name = "colIngresoAdicional";
            this.colIngresoAdicional.Visible = true;
            this.colIngresoAdicional.VisibleIndex = 6;
            // 
            // colDescuentoTotal
            // 
            this.colDescuentoTotal.FieldName = "DescuentoTotal";
            this.colDescuentoTotal.Name = "colDescuentoTotal";
            this.colDescuentoTotal.Visible = true;
            this.colDescuentoTotal.VisibleIndex = 7;
            // 
            // colPagoNeto
            // 
            this.colPagoNeto.FieldName = "PagoNeto";
            this.colPagoNeto.Name = "colPagoNeto";
            this.colPagoNeto.Visible = true;
            this.colPagoNeto.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // tbpServicios
            // 
            this.tbpServicios.Controls.Add(this.gdcDeudaServicio);
            this.tbpServicios.Location = new System.Drawing.Point(23, 4);
            this.tbpServicios.Name = "tbpServicios";
            this.tbpServicios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpServicios.Size = new System.Drawing.Size(950, 254);
            this.tbpServicios.TabIndex = 2;
            this.tbpServicios.Text = "Servic. Púb. / Otros";
            this.tbpServicios.UseVisualStyleBackColor = true;
            // 
            // gdcDeudaServicio
            // 
            this.gdcDeudaServicio.DataSource = this.clsOrdenPagoDetalleBindingSource;
            this.gdcDeudaServicio.Location = new System.Drawing.Point(14, 12);
            this.gdcDeudaServicio.MainView = this.gridView12;
            this.gdcDeudaServicio.Name = "gdcDeudaServicio";
            this.gdcDeudaServicio.Size = new System.Drawing.Size(920, 234);
            this.gdcDeudaServicio.TabIndex = 26;
            this.gdcDeudaServicio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView12});
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea3,
            this.colNumCuentaPorPagar1,
            this.colNumDetalleDeuda1,
            this.colSaldoDeuda1,
            this.colNumeroPagosRealizar1,
            this.colNumOrdenCab,
            this.colTotalPagar1,
            this.colIdEmpresa3});
            this.gridView12.GridControl = this.gdcDeudaServicio;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsView.ShowAutoFilterRow = true;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // colNumLinea3
            // 
            this.colNumLinea3.FieldName = "NumLinea";
            this.colNumLinea3.Name = "colNumLinea3";
            this.colNumLinea3.Visible = true;
            this.colNumLinea3.VisibleIndex = 0;
            // 
            // colNumCuentaPorPagar1
            // 
            this.colNumCuentaPorPagar1.FieldName = "NumCuentaPorPagar";
            this.colNumCuentaPorPagar1.Name = "colNumCuentaPorPagar1";
            this.colNumCuentaPorPagar1.Visible = true;
            this.colNumCuentaPorPagar1.VisibleIndex = 1;
            // 
            // colNumDetalleDeuda1
            // 
            this.colNumDetalleDeuda1.FieldName = "NumDetalleDeuda";
            this.colNumDetalleDeuda1.Name = "colNumDetalleDeuda1";
            this.colNumDetalleDeuda1.Visible = true;
            this.colNumDetalleDeuda1.VisibleIndex = 2;
            // 
            // colSaldoDeuda1
            // 
            this.colSaldoDeuda1.FieldName = "SaldoDeuda";
            this.colSaldoDeuda1.Name = "colSaldoDeuda1";
            this.colSaldoDeuda1.Visible = true;
            this.colSaldoDeuda1.VisibleIndex = 3;
            // 
            // colNumeroPagosRealizar1
            // 
            this.colNumeroPagosRealizar1.FieldName = "NumeroPagosRealizar";
            this.colNumeroPagosRealizar1.Name = "colNumeroPagosRealizar1";
            this.colNumeroPagosRealizar1.Visible = true;
            this.colNumeroPagosRealizar1.VisibleIndex = 4;
            // 
            // colNumOrdenCab
            // 
            this.colNumOrdenCab.FieldName = "NumOrdenCab";
            this.colNumOrdenCab.Name = "colNumOrdenCab";
            this.colNumOrdenCab.Visible = true;
            this.colNumOrdenCab.VisibleIndex = 5;
            // 
            // colTotalPagar1
            // 
            this.colTotalPagar1.FieldName = "TotalPagar";
            this.colTotalPagar1.Name = "colTotalPagar1";
            this.colTotalPagar1.Visible = true;
            this.colTotalPagar1.VisibleIndex = 6;
            // 
            // colIdEmpresa3
            // 
            this.colIdEmpresa3.FieldName = "IdEmpresa";
            this.colIdEmpresa3.Name = "colIdEmpresa3";
            this.colIdEmpresa3.Visible = true;
            this.colIdEmpresa3.VisibleIndex = 7;
            // 
            // cbxNroOrdenPagoProveedores
            // 
            this.cbxNroOrdenPagoProveedores.Location = new System.Drawing.Point(166, 79);
            this.cbxNroOrdenPagoProveedores.Name = "cbxNroOrdenPagoProveedores";
            this.cbxNroOrdenPagoProveedores.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxNroOrdenPagoProveedores.Properties.DataSource = this.clsOrdenPagoBindingSource;
            this.cbxNroOrdenPagoProveedores.Properties.DisplayMember = "NumOrdenPago";
            this.cbxNroOrdenPagoProveedores.Properties.ValueMember = "NumOrdenPago";
            this.cbxNroOrdenPagoProveedores.Properties.View = this.searchLookUpEdit4View;
            this.cbxNroOrdenPagoProveedores.Size = new System.Drawing.Size(117, 20);
            this.cbxNroOrdenPagoProveedores.TabIndex = 0;
            this.cbxNroOrdenPagoProveedores.EditValueChanged += new System.EventHandler(this.cbxNroOrdenPagoProveedores_EditValueChanged);
            // 
            // clsOrdenPagoBindingSource
            // 
            this.clsOrdenPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsOrdenPagoCab);
            // 
            // searchLookUpEdit4View
            // 
            this.searchLookUpEdit4View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit4View.Name = "searchLookUpEdit4View";
            this.searchLookUpEdit4View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit4View.OptionsView.ShowGroupPanel = false;
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(289, 79);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Properties.Mask.EditMask = "c";
            this.txtProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtProveedor.Size = new System.Drawing.Size(361, 20);
            this.txtProveedor.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nro. Orden de Pago:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbAnular,
            this.tsbSalir,
            this.tsbImprimir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1001, 25);
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
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbImprimir.ForeColor = System.Drawing.Color.Black;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(68, 22);
            this.tsbImprimir.Text = "Generar";
            this.tsbImprimir.Click += new System.EventHandler(this.tsbImprimir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro. Pago:";
            // 
            // txtNumPago
            // 
            this.txtNumPago.Enabled = false;
            this.txtNumPago.Location = new System.Drawing.Point(166, 41);
            this.txtNumPago.Name = "txtNumPago";
            this.txtNumPago.Properties.Mask.EditMask = "c";
            this.txtNumPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNumPago.Size = new System.Drawing.Size(117, 20);
            this.txtNumPago.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(757, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Fecha Ingreso:";
            // 
            // deFechaActual
            // 
            this.deFechaActual.EditValue = null;
            this.deFechaActual.Enabled = false;
            this.deFechaActual.Location = new System.Drawing.Point(865, 41);
            this.deFechaActual.Name = "deFechaActual";
            this.deFechaActual.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaActual.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaActual.Size = new System.Drawing.Size(104, 20);
            this.deFechaActual.TabIndex = 28;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(304, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(22, 17);
            this.btnConsultar.TabIndex = 30;
            this.btnConsultar.Text = "...";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gdcConsultaBancaria
            // 
            this.gdcConsultaBancaria.DataSource = this.clsCuentaBancariaBindingSource;
            this.gdcConsultaBancaria.Location = new System.Drawing.Point(25, 386);
            this.gdcConsultaBancaria.MainView = this.gridView2;
            this.gdcConsultaBancaria.Name = "gdcConsultaBancaria";
            this.gdcConsultaBancaria.Size = new System.Drawing.Size(224, 119);
            this.gdcConsultaBancaria.TabIndex = 32;
            this.gdcConsultaBancaria.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCuentaBancaria,
            this.colidBanco1,
            this.colNumeroCuenta1,
            this.colTipoCuenta,
            this.colSaldo});
            this.gridView2.GridControl = this.gdcConsultaBancaria;
            this.gridView2.Name = "gridView2";
            // 
            // colidCuentaBancaria
            // 
            this.colidCuentaBancaria.FieldName = "idCuentaBancaria";
            this.colidCuentaBancaria.Name = "colidCuentaBancaria";
            this.colidCuentaBancaria.OptionsColumn.AllowEdit = false;
            this.colidCuentaBancaria.Visible = true;
            this.colidCuentaBancaria.VisibleIndex = 0;
            // 
            // colidBanco1
            // 
            this.colidBanco1.FieldName = "idBanco";
            this.colidBanco1.Name = "colidBanco1";
            this.colidBanco1.OptionsColumn.AllowEdit = false;
            this.colidBanco1.Visible = true;
            this.colidBanco1.VisibleIndex = 1;
            // 
            // colNumeroCuenta1
            // 
            this.colNumeroCuenta1.FieldName = "NumeroCuenta";
            this.colNumeroCuenta1.Name = "colNumeroCuenta1";
            this.colNumeroCuenta1.OptionsColumn.AllowEdit = false;
            this.colNumeroCuenta1.Visible = true;
            this.colNumeroCuenta1.VisibleIndex = 2;
            // 
            // colTipoCuenta
            // 
            this.colTipoCuenta.FieldName = "TipoCuenta";
            this.colTipoCuenta.Name = "colTipoCuenta";
            this.colTipoCuenta.OptionsColumn.AllowEdit = false;
            this.colTipoCuenta.Visible = true;
            this.colTipoCuenta.VisibleIndex = 3;
            // 
            // colSaldo
            // 
            this.colSaldo.FieldName = "Saldo";
            this.colSaldo.Name = "colSaldo";
            this.colSaldo.OptionsColumn.AllowEdit = false;
            this.colSaldo.Visible = true;
            this.colSaldo.VisibleIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(760, 82);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 33;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Generada",
            "En Proceso",
            "Pagada"});
            this.cbxEstado.Location = new System.Drawing.Point(865, 82);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(104, 21);
            this.cbxEstado.TabIndex = 34;
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.Location = new System.Drawing.Point(166, 79);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpleado.Properties.DataSource = this.clsOrdenPagoBindingSource;
            this.cbxEmpleado.Properties.DisplayMember = "NumOrdenPago";
            this.cbxEmpleado.Properties.ValueMember = "NumOrdenPago";
            this.cbxEmpleado.Properties.View = this.searchLookUpEdit1View;
            this.cbxEmpleado.Size = new System.Drawing.Size(117, 20);
            this.cbxEmpleado.TabIndex = 35;
            this.cbxEmpleado.EditValueChanged += new System.EventHandler(this.cbxEmpleado_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbxVarios
            // 
            this.cbxVarios.Location = new System.Drawing.Point(166, 79);
            this.cbxVarios.Name = "cbxVarios";
            this.cbxVarios.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxVarios.Properties.DataSource = this.clsOrdenPagoBindingSource;
            this.cbxVarios.Properties.DisplayMember = "NumOrdenPago";
            this.cbxVarios.Properties.ValueMember = "NumOrdenPago";
            this.cbxVarios.Properties.View = this.gridView7;
            this.cbxVarios.Size = new System.Drawing.Size(117, 20);
            this.cbxVarios.TabIndex = 36;
            this.cbxVarios.EditValueChanged += new System.EventHandler(this.cbxVarios_EditValueChanged);
            // 
            // gridView7
            // 
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 546);
            this.Controls.Add(this.cbxVarios);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.gdcConsultaBancaria);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.deFechaActual);
            this.Controls.Add(this.cbxNroOrdenPagoProveedores);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumPago);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.tbcPagos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.frmPagos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleDosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcdetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxcuenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBancariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMedioPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).EndInit();
            this.tbcPagos.ResumeLayout(false);
            this.tbpProveedores.ResumeLayout(false);
            this.tbpProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDetalleOrdenPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalito.Properties)).EndInit();
            this.tbpEmpleados.ResumeLayout(false);
            this.tbpEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoEmpleadoDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            this.tbpServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcDeudaServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaCabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxNroOrdenPagoProveedores.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit4View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaBancaria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsNominaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxVarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxMedioPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraEditors.TextEdit txtMonto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtTotalPagar;
        private System.Windows.Forms.TabControl tbcPagos;
        private System.Windows.Forms.TabPage tbpProveedores;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxNroOrdenPagoProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit4View;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private DevExpress.XtraGrid.GridControl gdcDetalleOrdenPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tbpEmpleados;
        private DevExpress.XtraGrid.GridControl gdcNomina;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.TabPage tbpServicios;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraGrid.GridControl gdcDeudaServicio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtNumPago;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtTotalito;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.DateEdit deFechaActual;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtTotalEmpleado;
        private System.Windows.Forms.BindingSource clsMedioPagoBindingSource;
        private System.Windows.Forms.BindingSource clsOrdenPagoBindingSource;
        private System.Windows.Forms.BindingSource clsOrdenPagoDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCuentaPorPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDetalleDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroPagosRealizar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private System.Windows.Forms.BindingSource clsBancoBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxcuenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.BindingSource clsCuentaBancariaBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnConsultar;
        private DevExpress.XtraGrid.GridControl gdcdetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPagoDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedioPago;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPago;
        private DevExpress.XtraGrid.GridControl gdcConsultaBancaria;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colidCuentaBancaria;
        private DevExpress.XtraGrid.Columns.GridColumn colidBanco1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCuenta1;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldo;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.BindingSource clsNominaCabBindingSource;
        private System.Windows.Forms.BindingSource clsNominaDetBindingSource;
        private DevExpress.XtraGrid.GridControl gdcDetalleNomina;
        private System.Windows.Forms.BindingSource clsPagoDetalleDosBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedioPago1;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCuenta2;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco2;
        private DevExpress.XtraGrid.Columns.GridColumn colNumComprobante1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNominaCab;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPago1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxVarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.BindingSource clsOrdenPagoEmpleadoDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOrdenPago;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa2;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizarPago;
        private DevExpress.XtraGrid.Columns.GridColumn colLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colSueldoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colIngresoAdicional;
        private DevExpress.XtraGrid.Columns.GridColumn colDescuentoTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colPagoNeto;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea3;
        private DevExpress.XtraGrid.Columns.GridColumn colNumCuentaPorPagar1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDetalleDeuda1;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoDeuda1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroPagosRealizar1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumOrdenCab;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa3;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
    }
}