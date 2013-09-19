namespace forms.Taller
{
    partial class frmOrdendeTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdendeTrabajo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.txtCombustible = new DevExpress.XtraEditors.TextEdit();
            this.txtObservacion = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.tbcDeposito = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.speKilometraje = new DevExpress.XtraEditors.SpinEdit();
            this.txtColor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtChasis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.txtPlaca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.cbxFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.cbxFechaEntrega = new DevExpress.XtraEditors.DateEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscarPresupuesto = new DevExpress.XtraEditors.CheckButton();
            this.txtNroPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabControl2 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.txtIvaTrabajos = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsPresupuestoMOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPresupuestoMO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPresupuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdManoObra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroHoras = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioHora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTotalTrabajos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubTotalTrabajos = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.btnBorrarRepuestos = new DevExpress.XtraEditors.SimpleButton();
            this.txtIvaRepuestos = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarRepuestos = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalRepuestos = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubtotalRepuestos = new DevExpress.XtraEditors.TextEdit();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenTrabajoRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdRepuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTrabajo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionRepuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalRepuesto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.btnBorrarOtro = new DevExpress.XtraEditors.SimpleButton();
            this.txtIvaOtros = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregarOtro = new DevExpress.XtraEditors.SimpleButton();
            this.txtTotalOtros = new DevExpress.XtraEditors.TextEdit();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubtotalOtros = new DevExpress.XtraEditors.TextEdit();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.clsOtrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOrdenTrabajo1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcionOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxFechaRecepcion = new DevExpress.XtraEditors.DateEdit();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.cbxInicioReparacion = new DevExpress.XtraEditors.DateEdit();
            this.cbxEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCombustible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcDeposito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcDeposito.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speKilometraje.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChasis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaIngreso.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaEntrega.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaEntrega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).BeginInit();
            this.xtraTabControl2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaTrabajos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTrabajos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalTrabajos.Properties)).BeginInit();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaRepuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRepuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalRepuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenTrabajoRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaOtros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOtros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalOtros.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOtrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaRecepcion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaRecepcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInicioReparacion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInicioReparacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(589, 25);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.txtCombustible);
            this.xtraTabPage2.Controls.Add(this.txtObservacion);
            this.xtraTabPage2.Controls.Add(this.labelControl14);
            this.xtraTabPage2.Controls.Add(this.tbcDeposito);
            this.xtraTabPage2.Controls.Add(this.labelControl13);
            this.xtraTabPage2.Controls.Add(this.speKilometraje);
            this.xtraTabPage2.Controls.Add(this.txtColor);
            this.xtraTabPage2.Controls.Add(this.labelControl12);
            this.xtraTabPage2.Controls.Add(this.labelControl11);
            this.xtraTabPage2.Controls.Add(this.txtChasis);
            this.xtraTabPage2.Controls.Add(this.labelControl9);
            this.xtraTabPage2.Controls.Add(this.labelControl6);
            this.xtraTabPage2.Controls.Add(this.txtModelo);
            this.xtraTabPage2.Controls.Add(this.labelControl15);
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.txtMarca);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(569, 332);
            this.xtraTabPage2.Text = "Mecánica";
            // 
            // txtCombustible
            // 
            this.txtCombustible.Enabled = false;
            this.txtCombustible.Location = new System.Drawing.Point(99, 89);
            this.txtCombustible.Name = "txtCombustible";
            this.txtCombustible.Size = new System.Drawing.Size(100, 20);
            this.txtCombustible.TabIndex = 94;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(99, 126);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(281, 78);
            this.txtObservacion.TabIndex = 91;
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(33, 129);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(64, 13);
            this.labelControl14.TabIndex = 90;
            this.labelControl14.Text = "Observación:";
            // 
            // tbcDeposito
            // 
            this.tbcDeposito.EditValue = null;
            this.tbcDeposito.Location = new System.Drawing.Point(280, 85);
            this.tbcDeposito.Name = "tbcDeposito";
            this.tbcDeposito.Size = new System.Drawing.Size(100, 45);
            this.tbcDeposito.TabIndex = 89;
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(222, 92);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(46, 13);
            this.labelControl13.TabIndex = 88;
            this.labelControl13.Text = "Depósito:";
            // 
            // speKilometraje
            // 
            this.speKilometraje.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.speKilometraje.Location = new System.Drawing.Point(99, 53);
            this.speKilometraje.Name = "speKilometraje";
            this.speKilometraje.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.speKilometraje.Size = new System.Drawing.Size(100, 20);
            this.speKilometraje.TabIndex = 87;
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(428, 20);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 86;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(392, 23);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(29, 13);
            this.labelControl12.TabIndex = 85;
            this.labelControl12.Text = "Color:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(33, 92);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(62, 13);
            this.labelControl11.TabIndex = 83;
            this.labelControl11.Text = "Combustible:";
            // 
            // txtChasis
            // 
            this.txtChasis.Enabled = false;
            this.txtChasis.Location = new System.Drawing.Point(280, 53);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(100, 20);
            this.txtChasis.TabIndex = 82;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(222, 56);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 81;
            this.labelControl9.Text = "N° Chasis:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(33, 56);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 79;
            this.labelControl6.Text = "Kilometraje:";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(280, 20);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 20);
            this.txtModelo.TabIndex = 78;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(222, 23);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(38, 13);
            this.labelControl15.TabIndex = 77;
            this.labelControl15.Text = "Modelo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 23);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 76;
            this.labelControl5.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(99, 20);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 75;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(8, 28);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(575, 360);
            this.xtraTabControl1.TabIndex = 80;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.txtPlaca);
            this.xtraTabPage1.Controls.Add(this.labelControl21);
            this.xtraTabPage1.Controls.Add(this.txtCliente);
            this.xtraTabPage1.Controls.Add(this.labelControl22);
            this.xtraTabPage1.Controls.Add(this.cbxFechaIngreso);
            this.xtraTabPage1.Controls.Add(this.labelControl17);
            this.xtraTabPage1.Controls.Add(this.cbxFechaEntrega);
            this.xtraTabPage1.Controls.Add(this.labelControl16);
            this.xtraTabPage1.Controls.Add(this.btnBuscarPresupuesto);
            this.xtraTabPage1.Controls.Add(this.txtNroPresupuesto);
            this.xtraTabPage1.Controls.Add(this.labelControl8);
            this.xtraTabPage1.Controls.Add(this.xtraTabControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.cbxFechaRecepcion);
            this.xtraTabPage1.Controls.Add(this.txtCodigo);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.btnBuscar);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.cbxInicioReparacion);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(569, 332);
            this.xtraTabPage1.Text = "Datos Generales";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(447, 45);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(107, 20);
            this.txtPlaca.TabIndex = 97;
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(412, 48);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(29, 13);
            this.labelControl21.TabIndex = 96;
            this.labelControl21.Text = "Placa:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(262, 45);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(123, 20);
            this.txtCliente.TabIndex = 94;
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(218, 48);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(37, 13);
            this.labelControl22.TabIndex = 93;
            this.labelControl22.Text = "Cliente:";
            // 
            // cbxFechaIngreso
            // 
            this.cbxFechaIngreso.EditValue = null;
            this.cbxFechaIngreso.Location = new System.Drawing.Point(162, 74);
            this.cbxFechaIngreso.Name = "cbxFechaIngreso";
            this.cbxFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFechaIngreso.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFechaIngreso.Size = new System.Drawing.Size(130, 20);
            this.cbxFechaIngreso.TabIndex = 92;
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(14, 77);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(142, 13);
            this.labelControl17.TabIndex = 88;
            this.labelControl17.Text = "Fecha/Hora Ingreso Vehículo:";
            // 
            // cbxFechaEntrega
            // 
            this.cbxFechaEntrega.EditValue = null;
            this.cbxFechaEntrega.Location = new System.Drawing.Point(447, 74);
            this.cbxFechaEntrega.Name = "cbxFechaEntrega";
            this.cbxFechaEntrega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFechaEntrega.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFechaEntrega.Size = new System.Drawing.Size(107, 20);
            this.cbxFechaEntrega.TabIndex = 87;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(321, 77);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(120, 13);
            this.labelControl16.TabIndex = 86;
            this.labelControl16.Text = "Fecha Estimada Entrega:";
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(170, 43);
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarPresupuesto.TabIndex = 85;
            this.btnBuscarPresupuesto.Text = "...";
            this.btnBuscarPresupuesto.CheckedChanged += new System.EventHandler(this.btnBuscarPresupuesto_CheckedChanged);
            // 
            // txtNroPresupuesto
            // 
            this.txtNroPresupuesto.Enabled = false;
            this.txtNroPresupuesto.Location = new System.Drawing.Point(99, 45);
            this.txtNroPresupuesto.Name = "txtNroPresupuesto";
            this.txtNroPresupuesto.Size = new System.Drawing.Size(66, 20);
            this.txtNroPresupuesto.TabIndex = 84;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 48);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 13);
            this.labelControl8.TabIndex = 83;
            this.labelControl8.Text = "N° Presupuesto:";
            // 
            // xtraTabControl2
            // 
            this.xtraTabControl2.Location = new System.Drawing.Point(15, 104);
            this.xtraTabControl2.Name = "xtraTabControl2";
            this.xtraTabControl2.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl2.Size = new System.Drawing.Size(542, 222);
            this.xtraTabControl2.TabIndex = 82;
            this.xtraTabControl2.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.txtIvaTrabajos);
            this.xtraTabPage3.Controls.Add(this.gridControl1);
            this.xtraTabPage3.Controls.Add(this.txtTotalTrabajos);
            this.xtraTabPage3.Controls.Add(this.labelControl2);
            this.xtraTabPage3.Controls.Add(this.labelControl10);
            this.xtraTabPage3.Controls.Add(this.labelControl3);
            this.xtraTabPage3.Controls.Add(this.txtSubTotalTrabajos);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(536, 194);
            this.xtraTabPage3.Text = "Trabajos";
            // 
            // txtIvaTrabajos
            // 
            this.txtIvaTrabajos.Enabled = false;
            this.txtIvaTrabajos.Location = new System.Drawing.Point(251, 166);
            this.txtIvaTrabajos.Name = "txtIvaTrabajos";
            this.txtIvaTrabajos.Size = new System.Drawing.Size(89, 20);
            this.txtIvaTrabajos.TabIndex = 89;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsPresupuestoMOBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(530, 153);
            this.gridControl1.TabIndex = 32;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView4});
            // 
            // clsPresupuestoMOBindingSource
            // 
            this.clsPresupuestoMOBindingSource.DataSource = typeof(clases.Taller.clsPresupuestoMO);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPresupuestoMO,
            this.colIdPresupuesto,
            this.colIdManoObra,
            this.colIdTrabajo,
            this.colDescripcion,
            this.colNroHoras,
            this.colPrecioHora,
            this.colTotal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdPresupuestoMO
            // 
            this.colIdPresupuestoMO.FieldName = "IdPresupuestoMO";
            this.colIdPresupuestoMO.Name = "colIdPresupuestoMO";
            this.colIdPresupuestoMO.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max)});
            // 
            // colIdPresupuesto
            // 
            this.colIdPresupuesto.FieldName = "IdPresupuesto";
            this.colIdPresupuesto.Name = "colIdPresupuesto";
            // 
            // colIdManoObra
            // 
            this.colIdManoObra.FieldName = "IdManoObra";
            this.colIdManoObra.Name = "colIdManoObra";
            this.colIdManoObra.Visible = true;
            this.colIdManoObra.VisibleIndex = 0;
            // 
            // colIdTrabajo
            // 
            this.colIdTrabajo.FieldName = "IdTrabajo";
            this.colIdTrabajo.Name = "colIdTrabajo";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colNroHoras
            // 
            this.colNroHoras.FieldName = "NroHoras";
            this.colNroHoras.Name = "colNroHoras";
            this.colNroHoras.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colNroHoras.Visible = true;
            this.colNroHoras.VisibleIndex = 2;
            // 
            // colPrecioHora
            // 
            this.colPrecioHora.FieldName = "PrecioHora";
            this.colPrecioHora.Name = "colPrecioHora";
            this.colPrecioHora.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPrecioHora.Visible = true;
            this.colPrecioHora.VisibleIndex = 3;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 4;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.gridControl1;
            this.gridView4.Name = "gridView4";
            // 
            // txtTotalTrabajos
            // 
            this.txtTotalTrabajos.Enabled = false;
            this.txtTotalTrabajos.Location = new System.Drawing.Point(388, 166);
            this.txtTotalTrabajos.Name = "txtTotalTrabajos";
            this.txtTotalTrabajos.Size = new System.Drawing.Size(97, 20);
            this.txtTotalTrabajos.TabIndex = 79;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(198, 169);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 13);
            this.labelControl2.TabIndex = 88;
            this.labelControl2.Text = "IVA 12%:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(349, 169);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(28, 13);
            this.labelControl10.TabIndex = 78;
            this.labelControl10.Text = "Total:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(50, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(44, 13);
            this.labelControl3.TabIndex = 86;
            this.labelControl3.Text = "Subtotal:";
            // 
            // txtSubTotalTrabajos
            // 
            this.txtSubTotalTrabajos.Enabled = false;
            this.txtSubTotalTrabajos.Location = new System.Drawing.Point(100, 166);
            this.txtSubTotalTrabajos.Name = "txtSubTotalTrabajos";
            this.txtSubTotalTrabajos.Size = new System.Drawing.Size(89, 20);
            this.txtSubTotalTrabajos.TabIndex = 87;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.btnBorrarRepuestos);
            this.xtraTabPage4.Controls.Add(this.txtIvaRepuestos);
            this.xtraTabPage4.Controls.Add(this.btnBuscarRepuestos);
            this.xtraTabPage4.Controls.Add(this.txtTotalRepuestos);
            this.xtraTabPage4.Controls.Add(this.labelControl18);
            this.xtraTabPage4.Controls.Add(this.labelControl19);
            this.xtraTabPage4.Controls.Add(this.labelControl20);
            this.xtraTabPage4.Controls.Add(this.txtSubtotalRepuestos);
            this.xtraTabPage4.Controls.Add(this.gridControl2);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(536, 194);
            this.xtraTabPage4.Text = "Respuestos";
            // 
            // btnBorrarRepuestos
            // 
            this.btnBorrarRepuestos.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnBorrarRepuestos.Location = new System.Drawing.Point(51, 163);
            this.btnBorrarRepuestos.Name = "btnBorrarRepuestos";
            this.btnBorrarRepuestos.Size = new System.Drawing.Size(30, 23);
            this.btnBorrarRepuestos.TabIndex = 95;
            this.btnBorrarRepuestos.Click += new System.EventHandler(this.btnBorrarRepuestos_Click);
            // 
            // txtIvaRepuestos
            // 
            this.txtIvaRepuestos.Enabled = false;
            this.txtIvaRepuestos.Location = new System.Drawing.Point(294, 166);
            this.txtIvaRepuestos.Name = "txtIvaRepuestos";
            this.txtIvaRepuestos.Size = new System.Drawing.Size(89, 20);
            this.txtIvaRepuestos.TabIndex = 97;
            // 
            // btnBuscarRepuestos
            // 
            this.btnBuscarRepuestos.Image = global::forms.Properties.Resources._24_accesoUsuario;
            this.btnBuscarRepuestos.Location = new System.Drawing.Point(8, 163);
            this.btnBuscarRepuestos.Name = "btnBuscarRepuestos";
            this.btnBuscarRepuestos.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarRepuestos.TabIndex = 92;
            this.btnBuscarRepuestos.Click += new System.EventHandler(this.btnBuscarRepuestos_Click);
            // 
            // txtTotalRepuestos
            // 
            this.txtTotalRepuestos.Enabled = false;
            this.txtTotalRepuestos.Location = new System.Drawing.Point(431, 166);
            this.txtTotalRepuestos.Name = "txtTotalRepuestos";
            this.txtTotalRepuestos.Size = new System.Drawing.Size(97, 20);
            this.txtTotalRepuestos.TabIndex = 91;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(241, 169);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(47, 13);
            this.labelControl18.TabIndex = 96;
            this.labelControl18.Text = "IVA 12%:";
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(392, 169);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(28, 13);
            this.labelControl19.TabIndex = 90;
            this.labelControl19.Text = "Total:";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(93, 169);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(44, 13);
            this.labelControl20.TabIndex = 93;
            this.labelControl20.Text = "Subtotal:";
            // 
            // txtSubtotalRepuestos
            // 
            this.txtSubtotalRepuestos.Enabled = false;
            this.txtSubtotalRepuestos.Location = new System.Drawing.Point(143, 166);
            this.txtSubtotalRepuestos.Name = "txtSubtotalRepuestos";
            this.txtSubtotalRepuestos.Size = new System.Drawing.Size(89, 20);
            this.txtSubtotalRepuestos.TabIndex = 94;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.clsOrdenTrabajoRBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 3);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(530, 154);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // clsOrdenTrabajoRBindingSource
            // 
            this.clsOrdenTrabajoRBindingSource.DataSource = typeof(clases.Taller.clsOrdenTrabajoR);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdRepuesto,
            this.colIdOrdenTrabajo,
            this.colIdArticulo,
            this.colDescripcionRepuesto,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colTotalRepuesto});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView2_CellValueChanged);
            // 
            // colIdRepuesto
            // 
            this.colIdRepuesto.FieldName = "IdRepuesto";
            this.colIdRepuesto.Name = "colIdRepuesto";
            this.colIdRepuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max)});
            this.colIdRepuesto.Visible = true;
            this.colIdRepuesto.VisibleIndex = 0;
            // 
            // colIdOrdenTrabajo
            // 
            this.colIdOrdenTrabajo.FieldName = "IdOrdenTrabajo";
            this.colIdOrdenTrabajo.Name = "colIdOrdenTrabajo";
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.Visible = true;
            this.colIdArticulo.VisibleIndex = 1;
            // 
            // colDescripcionRepuesto
            // 
            this.colDescripcionRepuesto.FieldName = "DescripcionRepuesto";
            this.colDescripcionRepuesto.Name = "colDescripcionRepuesto";
            this.colDescripcionRepuesto.Visible = true;
            this.colDescripcionRepuesto.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 4;
            // 
            // colTotalRepuesto
            // 
            this.colTotalRepuesto.FieldName = "TotalRepuesto";
            this.colTotalRepuesto.Name = "colTotalRepuesto";
            this.colTotalRepuesto.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colTotalRepuesto.Visible = true;
            this.colTotalRepuesto.VisibleIndex = 5;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.btnBorrarOtro);
            this.xtraTabPage5.Controls.Add(this.txtIvaOtros);
            this.xtraTabPage5.Controls.Add(this.btnAgregarOtro);
            this.xtraTabPage5.Controls.Add(this.txtTotalOtros);
            this.xtraTabPage5.Controls.Add(this.labelControl24);
            this.xtraTabPage5.Controls.Add(this.labelControl25);
            this.xtraTabPage5.Controls.Add(this.labelControl26);
            this.xtraTabPage5.Controls.Add(this.txtSubtotalOtros);
            this.xtraTabPage5.Controls.Add(this.gridControl3);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(536, 194);
            this.xtraTabPage5.Text = "Otros";
            // 
            // btnBorrarOtro
            // 
            this.btnBorrarOtro.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnBorrarOtro.Location = new System.Drawing.Point(51, 163);
            this.btnBorrarOtro.Name = "btnBorrarOtro";
            this.btnBorrarOtro.Size = new System.Drawing.Size(30, 23);
            this.btnBorrarOtro.TabIndex = 103;
            this.btnBorrarOtro.Click += new System.EventHandler(this.btnBorrarOtro_Click);
            // 
            // txtIvaOtros
            // 
            this.txtIvaOtros.Enabled = false;
            this.txtIvaOtros.Location = new System.Drawing.Point(294, 166);
            this.txtIvaOtros.Name = "txtIvaOtros";
            this.txtIvaOtros.Size = new System.Drawing.Size(89, 20);
            this.txtIvaOtros.TabIndex = 105;
            // 
            // btnAgregarOtro
            // 
            this.btnAgregarOtro.Image = global::forms.Properties.Resources._24_accesoUsuario;
            this.btnAgregarOtro.Location = new System.Drawing.Point(8, 163);
            this.btnAgregarOtro.Name = "btnAgregarOtro";
            this.btnAgregarOtro.Size = new System.Drawing.Size(37, 23);
            this.btnAgregarOtro.TabIndex = 100;
            this.btnAgregarOtro.Click += new System.EventHandler(this.btnAgregarOtro_Click);
            // 
            // txtTotalOtros
            // 
            this.txtTotalOtros.Enabled = false;
            this.txtTotalOtros.Location = new System.Drawing.Point(431, 166);
            this.txtTotalOtros.Name = "txtTotalOtros";
            this.txtTotalOtros.Size = new System.Drawing.Size(97, 20);
            this.txtTotalOtros.TabIndex = 99;
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(241, 169);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(47, 13);
            this.labelControl24.TabIndex = 104;
            this.labelControl24.Text = "IVA 12%:";
            // 
            // labelControl25
            // 
            this.labelControl25.Location = new System.Drawing.Point(392, 169);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(28, 13);
            this.labelControl25.TabIndex = 98;
            this.labelControl25.Text = "Total:";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(93, 169);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(44, 13);
            this.labelControl26.TabIndex = 101;
            this.labelControl26.Text = "Subtotal:";
            // 
            // txtSubtotalOtros
            // 
            this.txtSubtotalOtros.Enabled = false;
            this.txtSubtotalOtros.Location = new System.Drawing.Point(143, 166);
            this.txtSubtotalOtros.Name = "txtSubtotalOtros";
            this.txtSubtotalOtros.Size = new System.Drawing.Size(89, 20);
            this.txtSubtotalOtros.TabIndex = 102;
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.clsOtrosBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(3, 3);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(530, 154);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // clsOtrosBindingSource
            // 
            this.clsOtrosBindingSource.DataSource = typeof(clases.Taller.clsOtros);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOtros,
            this.colIdOrdenTrabajo1,
            this.colDescripcionOtros,
            this.colPrecio});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView3_CellValueChanged);
            // 
            // colIdOtros
            // 
            this.colIdOtros.FieldName = "IdOtros";
            this.colIdOtros.Name = "colIdOtros";
            this.colIdOtros.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Max)});
            this.colIdOtros.Visible = true;
            this.colIdOtros.VisibleIndex = 0;
            // 
            // colIdOrdenTrabajo1
            // 
            this.colIdOrdenTrabajo1.FieldName = "IdOrdenTrabajo";
            this.colIdOrdenTrabajo1.Name = "colIdOrdenTrabajo1";
            // 
            // colDescripcionOtros
            // 
            this.colDescripcionOtros.FieldName = "DescripcionOtros";
            this.colDescripcionOtros.Name = "colDescripcionOtros";
            this.colDescripcionOtros.Visible = true;
            this.colDescripcionOtros.VisibleIndex = 1;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(170, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(85, 13);
            this.labelControl4.TabIndex = 80;
            this.labelControl4.Text = "Fecha Recepción:";
            // 
            // cbxFechaRecepcion
            // 
            this.cbxFechaRecepcion.EditValue = null;
            this.cbxFechaRecepcion.Location = new System.Drawing.Point(262, 15);
            this.cbxFechaRecepcion.Name = "cbxFechaRecepcion";
            this.cbxFechaRecepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFechaRecepcion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFechaRecepcion.Size = new System.Drawing.Size(86, 20);
            this.cbxFechaRecepcion.TabIndex = 81;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(61, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(66, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 18);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "Número:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(132, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(355, 18);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(86, 13);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Inicio Reparación:";
            // 
            // cbxInicioReparacion
            // 
            this.cbxInicioReparacion.EditValue = null;
            this.cbxInicioReparacion.Location = new System.Drawing.Point(447, 16);
            this.cbxInicioReparacion.Name = "cbxInicioReparacion";
            this.cbxInicioReparacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxInicioReparacion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxInicioReparacion.Size = new System.Drawing.Size(107, 20);
            this.cbxInicioReparacion.TabIndex = 66;
            // 
            // cbxEstado
            // 
            this.cbxEstado.EditValue = "Activo";
            this.cbxEstado.Location = new System.Drawing.Point(466, 393);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Incativo"});
            this.cbxEstado.Size = new System.Drawing.Size(97, 20);
            this.cbxEstado.TabIndex = 85;
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(418, 396);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(37, 13);
            this.labelControl23.TabIndex = 84;
            this.labelControl23.Text = "Estado:";
            // 
            // frmOrdendeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 421);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelControl23);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "frmOrdendeTrabajo";
            this.Text = "Orden de Trabajo";
            this.Load += new System.EventHandler(this.frmOrdendeTrabajo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCombustible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcDeposito.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbcDeposito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speKilometraje.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChasis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaIngreso.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaEntrega.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaEntrega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl2)).EndInit();
            this.xtraTabControl2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaTrabajos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTrabajos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotalTrabajos.Properties)).EndInit();
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaRepuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalRepuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalRepuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenTrabajoRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIvaOtros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalOtros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubtotalOtros.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOtrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaRecepcion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaRecepcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInicioReparacion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxInicioReparacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.MemoEdit txtObservacion;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.TrackBarControl tbcDeposito;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.SpinEdit speKilometraje;
        private DevExpress.XtraEditors.TextEdit txtColor;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtChasis;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEstado;
        private DevExpress.XtraEditors.TextEdit txtPlaca;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.DateEdit cbxFechaIngreso;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.DateEdit cbxFechaEntrega;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.CheckButton btnBuscarPresupuesto;
        private DevExpress.XtraEditors.TextEdit txtNroPresupuesto;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTotalTrabajos;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit cbxFechaRecepcion;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit cbxInicioReparacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.TextEdit txtCombustible;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.TextEdit txtIvaTrabajos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtSubTotalTrabajos;
        private DevExpress.XtraEditors.SimpleButton btnBorrarRepuestos;
        private DevExpress.XtraEditors.TextEdit txtIvaRepuestos;
        private DevExpress.XtraEditors.SimpleButton btnBuscarRepuestos;
        private DevExpress.XtraEditors.TextEdit txtTotalRepuestos;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtSubtotalRepuestos;
        private DevExpress.XtraEditors.SimpleButton btnBorrarOtro;
        private DevExpress.XtraEditors.TextEdit txtIvaOtros;
        private DevExpress.XtraEditors.TextEdit txtTotalOtros;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.TextEdit txtSubtotalOtros;
        private System.Windows.Forms.BindingSource clsPresupuestoMOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuestoMO;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNroHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioHora;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.SimpleButton btnAgregarOtro;
        private System.Windows.Forms.BindingSource clsOrdenTrabajoRBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdRepuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionRepuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalRepuesto;
        private System.Windows.Forms.BindingSource clsOtrosBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOrdenTrabajo1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcionOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
    }
}