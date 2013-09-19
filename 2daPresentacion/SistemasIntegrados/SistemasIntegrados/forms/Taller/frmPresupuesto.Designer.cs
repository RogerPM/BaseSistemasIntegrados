namespace forms.Taller
{
    partial class frmPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuesto));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarCliente = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxFecha = new DevExpress.XtraEditors.DateEdit();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtIva = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalPresupuesto = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscarMO = new DevExpress.XtraEditors.SimpleButton();
            this.btnBorrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotalTiempo = new DevExpress.XtraEditors.TextEdit();
            this.txtObservaciones = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
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
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cbxEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtModelo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtPlaca = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecha.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPresupuesto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTiempo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoMOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Número:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(78, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(170, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(78, 61);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(223, 20);
            this.txtCliente.TabIndex = 18;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(307, 59);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(28, 23);
            this.btnBuscarCliente.TabIndex = 21;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(360, 38);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 23;
            this.labelControl4.Text = "Fecha:";
            // 
            // cbxFecha
            // 
            this.cbxFecha.EditValue = null;
            this.cbxFecha.Location = new System.Drawing.Point(399, 35);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFecha.Size = new System.Drawing.Size(119, 20);
            this.cbxFecha.TabIndex = 24;
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
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(60, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
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
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(319, 324);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(44, 13);
            this.labelControl8.TabIndex = 33;
            this.labelControl8.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(416, 321);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(101, 20);
            this.txtSubTotal.TabIndex = 34;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(319, 350);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 13);
            this.labelControl9.TabIndex = 35;
            this.labelControl9.Text = "IVA 12%:";
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(416, 347);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(101, 20);
            this.txtIva.TabIndex = 36;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(319, 375);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(91, 13);
            this.labelControl10.TabIndex = 37;
            this.labelControl10.Text = "Total Presupuesto:";
            // 
            // txtTotalPresupuesto
            // 
            this.txtTotalPresupuesto.Enabled = false;
            this.txtTotalPresupuesto.Location = new System.Drawing.Point(416, 372);
            this.txtTotalPresupuesto.Name = "txtTotalPresupuesto";
            this.txtTotalPresupuesto.Size = new System.Drawing.Size(101, 20);
            this.txtTotalPresupuesto.TabIndex = 38;
            // 
            // btnBuscarMO
            // 
            this.btnBuscarMO.Image = global::forms.Properties.Resources._24_accesoUsuario;
            this.btnBuscarMO.Location = new System.Drawing.Point(13, 311);
            this.btnBuscarMO.Name = "btnBuscarMO";
            this.btnBuscarMO.Size = new System.Drawing.Size(37, 23);
            this.btnBuscarMO.TabIndex = 50;
            this.btnBuscarMO.Click += new System.EventHandler(this.btnBuscarMO_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnBorrar.Location = new System.Drawing.Point(57, 311);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(30, 23);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(16, 375);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(75, 13);
            this.labelControl14.TabIndex = 45;
            this.labelControl14.Text = "Observaciones:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(16, 350);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(120, 13);
            this.labelControl13.TabIndex = 43;
            this.labelControl13.Text = "Total Tiempo de Trabajo:";
            // 
            // txtTotalTiempo
            // 
            this.txtTotalTiempo.Enabled = false;
            this.txtTotalTiempo.Location = new System.Drawing.Point(173, 347);
            this.txtTotalTiempo.Name = "txtTotalTiempo";
            this.txtTotalTiempo.Size = new System.Drawing.Size(110, 20);
            this.txtTotalTiempo.TabIndex = 44;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(97, 375);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Properties.MaxLength = 100;
            this.txtObservaciones.Size = new System.Drawing.Size(186, 59);
            this.txtObservaciones.TabIndex = 52;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 119);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(506, 186);
            this.xtraTabControl1.TabIndex = 55;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(500, 158);
            this.xtraTabPage1.Text = "Trabajos";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsPresupuestoMOBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(494, 153);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(373, 417);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(37, 13);
            this.labelControl11.TabIndex = 56;
            this.labelControl11.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.EditValue = "Activo";
            this.cbxEstado.Location = new System.Drawing.Point(416, 414);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Incativo"});
            this.cbxEstado.Size = new System.Drawing.Size(102, 20);
            this.cbxEstado.TabIndex = 57;
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Location = new System.Drawing.Point(399, 86);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(119, 20);
            this.txtModelo.TabIndex = 64;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(355, 89);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(38, 13);
            this.labelControl15.TabIndex = 63;
            this.labelControl15.Text = "Modelo:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(196, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(235, 86);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 61;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(78, 86);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(85, 20);
            this.txtPlaca.TabIndex = 59;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 89);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 58;
            this.labelControl3.Text = "Placa:";
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 442);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.labelControl15);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.labelControl11);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnBuscarMO);
            this.Controls.Add(this.labelControl14);
            this.Controls.Add(this.txtTotalTiempo);
            this.Controls.Add(this.labelControl13);
            this.Controls.Add(this.txtTotalPresupuesto);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.cbxFecha);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPresupuesto";
            this.Text = "Presupuesto de Reparación";
            this.Load += new System.EventHandler(this.frmPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFecha.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPresupuesto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalTiempo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtObservaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPresupuestoMOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCliente;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit cbxFecha;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtIva;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtTotalPresupuesto;
        private DevExpress.XtraEditors.SimpleButton btnBuscarMO;
        private DevExpress.XtraEditors.SimpleButton btnBorrar;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtTotalTiempo;
        private DevExpress.XtraEditors.MemoEdit txtObservaciones;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEstado;
        private DevExpress.XtraEditors.TextEdit txtModelo;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtPlaca;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPresupuestoMOBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuestoMO;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPresupuesto;
        private DevExpress.XtraGrid.Columns.GridColumn colIdManoObra;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTrabajo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colNroHoras;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioHora;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.ToolStripButton btnModificar;
    }
}