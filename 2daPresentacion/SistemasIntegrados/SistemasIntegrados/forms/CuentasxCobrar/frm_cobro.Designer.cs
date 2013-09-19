namespace forms.CuentasxCobrar
{
    partial class frm_cobro
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNuevo = new DevExpress.XtraBars.BarButtonItem();
            this.btnGrabar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dtFechaVen = new DevExpress.XtraEditors.DateEdit();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtModulo = new DevExpress.XtraEditors.TextEdit();
            this.lblModulo = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscaCtaxCobrar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoCtaCobro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.txtInteres = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoCobro = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.txtMora = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaldo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorCuota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtNumeroCuota = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIdCliente = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoFactura = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gluMedioPago = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMedioPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.grvCtaDet = new DevExpress.XtraGrid.GridControl();
            this.clsCuentaxCobrarDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCuentaxCobrar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_cuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_cuota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_interes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_mora = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_cobro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.txtValor = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsCuentaxCobrarDetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidCuentaxCobrar1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_cuota1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_cuota1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_interes1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_mora1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_cobro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_vencimiento1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gueBanco = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsBancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtNoComprobante = new DevExpress.XtraEditors.TextEdit();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVen.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCtaCobro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCobro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMora.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFactura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluMedioPago.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCtaDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaxCobrarDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaxCobrarDetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gueBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoComprobante.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dtFecha);
            this.panelControl1.Controls.Add(this.dtFechaVen);
            this.panelControl1.Controls.Add(this.cbxEstado);
            this.panelControl1.Controls.Add(this.txtModulo);
            this.panelControl1.Controls.Add(this.lblModulo);
            this.panelControl1.Controls.Add(this.btnBuscaCtaxCobrar);
            this.panelControl1.Controls.Add(this.labelControl8);
            this.panelControl1.Controls.Add(this.txtNoCtaCobro);
            this.panelControl1.Controls.Add(this.labelControl21);
            this.panelControl1.Controls.Add(this.txtInteres);
            this.panelControl1.Controls.Add(this.txtNombreCliente);
            this.panelControl1.Controls.Add(this.labelControl19);
            this.panelControl1.Controls.Add(this.txtNoCobro);
            this.panelControl1.Controls.Add(this.labelControl16);
            this.panelControl1.Controls.Add(this.txtMora);
            this.panelControl1.Controls.Add(this.labelControl15);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl17);
            this.panelControl1.Controls.Add(this.labelControl13);
            this.panelControl1.Controls.Add(this.txtSaldo);
            this.panelControl1.Controls.Add(this.labelControl10);
            this.panelControl1.Controls.Add(this.txtValorCuota);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txtNumeroCuota);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.txtIdCliente);
            this.panelControl1.Controls.Add(this.labelControl11);
            this.panelControl1.Controls.Add(this.txtNoFactura);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 57);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(651, 189);
            this.panelControl1.TabIndex = 5;
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(506, 78);
            this.dtFecha.MenuManager = this.barManager1;
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 106;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNuevo,
            this.btnGrabar,
            this.barButtonItem4,
            this.barButtonItem5});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnNuevo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGrabar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem5, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Caption = "Nuevo";
            this.btnNuevo.Glyph = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.Id = 0;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNuevo_ItemClick);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Caption = "Grabar";
            this.btnGrabar.Glyph = global::forms.Properties.Resources.guardar;
            this.btnGrabar.Id = 1;
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGrabar_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Anular";
            this.barButtonItem4.Glyph = global::forms.Properties.Resources._24_cancelar;
            this.barButtonItem4.Id = 3;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Salir";
            this.barButtonItem5.Glyph = global::forms.Properties.Resources.eliminar;
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(675, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 660);
            this.barDockControlBottom.Size = new System.Drawing.Size(675, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 628);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(675, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 628);
            // 
            // dtFechaVen
            // 
            this.dtFechaVen.EditValue = null;
            this.dtFechaVen.Location = new System.Drawing.Point(506, 112);
            this.dtFechaVen.MenuManager = this.barManager1;
            this.dtFechaVen.Name = "dtFechaVen";
            this.dtFechaVen.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaVen.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaVen.Size = new System.Drawing.Size(100, 20);
            this.dtFechaVen.TabIndex = 105;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(99, 146);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxEstado.TabIndex = 104;
            // 
            // txtModulo
            // 
            this.txtModulo.Enabled = false;
            this.txtModulo.Location = new System.Drawing.Point(104, 41);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(73, 20);
            this.txtModulo.TabIndex = 103;
            // 
            // lblModulo
            // 
            this.lblModulo.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblModulo.Location = new System.Drawing.Point(51, 43);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(41, 13);
            this.lblModulo.TabIndex = 101;
            this.lblModulo.Text = "Modulo";
            // 
            // btnBuscaCtaxCobrar
            // 
            this.btnBuscaCtaxCobrar.Location = new System.Drawing.Point(213, 15);
            this.btnBuscaCtaxCobrar.Name = "btnBuscaCtaxCobrar";
            this.btnBuscaCtaxCobrar.Size = new System.Drawing.Size(19, 19);
            this.btnBuscaCtaxCobrar.TabIndex = 100;
            this.btnBuscaCtaxCobrar.Text = "...";
            this.btnBuscaCtaxCobrar.Click += new System.EventHandler(this.btnBuscaCtaxCobrar_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl8.Location = new System.Drawing.Point(12, 17);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(84, 13);
            this.labelControl8.TabIndex = 98;
            this.labelControl8.Text = "No. CtaxCobrar";
            // 
            // txtNoCtaCobro
            // 
            this.txtNoCtaCobro.Location = new System.Drawing.Point(104, 14);
            this.txtNoCtaCobro.Name = "txtNoCtaCobro";
            this.txtNoCtaCobro.Size = new System.Drawing.Size(99, 20);
            this.txtNoCtaCobro.TabIndex = 99;
            // 
            // labelControl21
            // 
            this.labelControl21.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl21.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl21.Location = new System.Drawing.Point(51, 106);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(42, 13);
            this.labelControl21.TabIndex = 88;
            this.labelControl21.Text = "Interes";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(104, 103);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(56, 20);
            this.txtInteres.TabIndex = 89;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Location = new System.Drawing.Point(358, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(243, 20);
            this.txtNombreCliente.TabIndex = 87;
            // 
            // labelControl19
            // 
            this.labelControl19.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl19.Location = new System.Drawing.Point(251, 18);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(53, 13);
            this.labelControl19.TabIndex = 85;
            this.labelControl19.Text = "No. Cobro";
            // 
            // txtNoCobro
            // 
            this.txtNoCobro.Location = new System.Drawing.Point(313, 15);
            this.txtNoCobro.Name = "txtNoCobro";
            this.txtNoCobro.Size = new System.Drawing.Size(55, 20);
            this.txtNoCobro.TabIndex = 86;
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl16.Location = new System.Drawing.Point(191, 106);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(29, 13);
            this.labelControl16.TabIndex = 82;
            this.labelControl16.Text = "Mora";
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(232, 109);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(93, 20);
            this.txtMora.TabIndex = 83;
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl15.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl15.Location = new System.Drawing.Point(53, 149);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(38, 13);
            this.labelControl15.TabIndex = 78;
            this.labelControl15.Text = "Estado";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl4.Location = new System.Drawing.Point(586, 152);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(10, 19);
            this.labelControl4.TabIndex = 71;
            this.labelControl4.Text = "$";
            // 
            // labelControl17
            // 
            this.labelControl17.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl17.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl17.Location = new System.Drawing.Point(326, 76);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(10, 19);
            this.labelControl17.TabIndex = 63;
            this.labelControl17.Text = "$";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl13.Location = new System.Drawing.Point(412, 154);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(31, 13);
            this.labelControl13.TabIndex = 58;
            this.labelControl13.Text = "Saldo";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(452, 151);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(128, 20);
            this.txtSaldo.TabIndex = 59;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl10.Location = new System.Drawing.Point(139, 79);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(82, 13);
            this.labelControl10.TabIndex = 53;
            this.labelControl10.Text = "Valor de Cuota";
            // 
            // txtValorCuota
            // 
            this.txtValorCuota.Location = new System.Drawing.Point(227, 76);
            this.txtValorCuota.Name = "txtValorCuota";
            this.txtValorCuota.Size = new System.Drawing.Size(93, 20);
            this.txtValorCuota.TabIndex = 54;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl9.Location = new System.Drawing.Point(40, 79);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 13);
            this.labelControl9.TabIndex = 51;
            this.labelControl9.Text = "No. Cuota";
            // 
            // txtNumeroCuota
            // 
            this.txtNumeroCuota.Location = new System.Drawing.Point(104, 69);
            this.txtNumeroCuota.Name = "txtNumeroCuota";
            this.txtNumeroCuota.Size = new System.Drawing.Size(32, 20);
            this.txtNumeroCuota.TabIndex = 52;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(342, 110);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(106, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Fecha Vencimiento";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(212, 48);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(39, 13);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.Location = new System.Drawing.Point(263, 41);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(88, 20);
            this.txtIdCliente.TabIndex = 41;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl11.Location = new System.Drawing.Point(402, 17);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(63, 13);
            this.labelControl11.TabIndex = 31;
            this.labelControl11.Text = "No. Factura";
            // 
            // txtNoFactura
            // 
            this.txtNoFactura.Location = new System.Drawing.Point(472, 15);
            this.txtNoFactura.Name = "txtNoFactura";
            this.txtNoFactura.Size = new System.Drawing.Size(123, 20);
            this.txtNoFactura.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(362, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "Fecha de Cobro";
            // 
            // gluMedioPago
            // 
            this.gluMedioPago.Location = new System.Drawing.Point(98, 450);
            this.gluMedioPago.MenuManager = this.barManager1;
            this.gluMedioPago.Name = "gluMedioPago";
            this.gluMedioPago.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluMedioPago.Properties.DataSource = this.clsMedioPagoBindingSource;
            this.gluMedioPago.Properties.DisplayMember = "Descripcion";
            this.gluMedioPago.Properties.ValueMember = "IdMedioPago";
            this.gluMedioPago.Properties.View = this.gridLookUpEdit1View;
            this.gluMedioPago.Size = new System.Drawing.Size(100, 20);
            this.gluMedioPago.TabIndex = 105;
            // 
            // clsMedioPagoBindingSource
            // 
            this.clsMedioPagoBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsMedioPago);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(41, 444);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 26);
            this.labelControl3.TabIndex = 90;
            this.labelControl3.Text = "Medio\r\nde Pago";
            // 
            // grvCtaDet
            // 
            this.grvCtaDet.DataSource = this.clsCuentaxCobrarDetBindingSource;
            this.grvCtaDet.Location = new System.Drawing.Point(12, 265);
            this.grvCtaDet.MainView = this.gridView1;
            this.grvCtaDet.Name = "grvCtaDet";
            this.grvCtaDet.Size = new System.Drawing.Size(651, 145);
            this.grvCtaDet.TabIndex = 33;
            this.grvCtaDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsCuentaxCobrarDetBindingSource
            // 
            this.clsCuentaxCobrarDetBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsCuentaxCobrarDet);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCuentaxCobrar,
            this.colNumero,
            this.colnumero_cuota,
            this.colvalor_cuota,
            this.colvalor_interes,
            this.colvalor_mora,
            this.colfecha_cobro,
            this.colfecha_vencimiento,
            this.colFechaModificacion,
            this.colestado});
            this.gridView1.GridControl = this.grvCtaDet;
            this.gridView1.Name = "gridView1";
            // 
            // colidCuentaxCobrar
            // 
            this.colidCuentaxCobrar.FieldName = "idCuentaxCobrar";
            this.colidCuentaxCobrar.Name = "colidCuentaxCobrar";
            this.colidCuentaxCobrar.Visible = true;
            this.colidCuentaxCobrar.VisibleIndex = 0;
            this.colidCuentaxCobrar.Width = 63;
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 1;
            this.colNumero.Width = 63;
            // 
            // colnumero_cuota
            // 
            this.colnumero_cuota.FieldName = "numero_cuota";
            this.colnumero_cuota.Name = "colnumero_cuota";
            this.colnumero_cuota.Visible = true;
            this.colnumero_cuota.VisibleIndex = 2;
            this.colnumero_cuota.Width = 77;
            // 
            // colvalor_cuota
            // 
            this.colvalor_cuota.FieldName = "valor_cuota";
            this.colvalor_cuota.Name = "colvalor_cuota";
            this.colvalor_cuota.Visible = true;
            this.colvalor_cuota.VisibleIndex = 3;
            this.colvalor_cuota.Width = 61;
            // 
            // colvalor_interes
            // 
            this.colvalor_interes.FieldName = "valor_interes";
            this.colvalor_interes.Name = "colvalor_interes";
            this.colvalor_interes.Visible = true;
            this.colvalor_interes.VisibleIndex = 4;
            this.colvalor_interes.Width = 61;
            // 
            // colvalor_mora
            // 
            this.colvalor_mora.FieldName = "valor_mora";
            this.colvalor_mora.Name = "colvalor_mora";
            this.colvalor_mora.Visible = true;
            this.colvalor_mora.VisibleIndex = 5;
            this.colvalor_mora.Width = 61;
            // 
            // colfecha_cobro
            // 
            this.colfecha_cobro.FieldName = "fecha_cobro";
            this.colfecha_cobro.Name = "colfecha_cobro";
            this.colfecha_cobro.Visible = true;
            this.colfecha_cobro.VisibleIndex = 6;
            this.colfecha_cobro.Width = 61;
            // 
            // colfecha_vencimiento
            // 
            this.colfecha_vencimiento.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento.Name = "colfecha_vencimiento";
            this.colfecha_vencimiento.Visible = true;
            this.colfecha_vencimiento.VisibleIndex = 7;
            this.colfecha_vencimiento.Width = 61;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 8;
            this.colFechaModificacion.Width = 61;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 9;
            this.colestado.Width = 64;
            // 
            // labelControl18
            // 
            this.labelControl18.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl18.Location = new System.Drawing.Point(236, 550);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(10, 19);
            this.labelControl18.TabIndex = 92;
            this.labelControl18.Text = "$";
            // 
            // labelControl20
            // 
            this.labelControl20.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl20.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl20.Location = new System.Drawing.Point(57, 558);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(29, 13);
            this.labelControl20.TabIndex = 90;
            this.labelControl20.Text = "Total";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(98, 549);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(128, 20);
            this.txtValor.TabIndex = 91;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsCuentaxCobrarDetBindingSource1;
            this.gridControl1.Location = new System.Drawing.Point(304, 436);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(359, 161);
            this.gridControl1.TabIndex = 106;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // clsCuentaxCobrarDetBindingSource1
            // 
            this.clsCuentaxCobrarDetBindingSource1.DataSource = typeof(clases.CuentasxCobrar.clsCuentaxCobrarDet);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidCuentaxCobrar1,
            this.colNumero1,
            this.colnumero_cuota1,
            this.colvalor_cuota1,
            this.colvalor_interes1,
            this.colvalor_mora1,
            this.colfecha_cobro1,
            this.colfecha_vencimiento1,
            this.colFechaModificacion1,
            this.colestado1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colidCuentaxCobrar1
            // 
            this.colidCuentaxCobrar1.FieldName = "idCuentaxCobrar";
            this.colidCuentaxCobrar1.Name = "colidCuentaxCobrar1";
            this.colidCuentaxCobrar1.Visible = true;
            this.colidCuentaxCobrar1.VisibleIndex = 0;
            this.colidCuentaxCobrar1.Width = 44;
            // 
            // colNumero1
            // 
            this.colNumero1.FieldName = "Numero";
            this.colNumero1.Name = "colNumero1";
            this.colNumero1.Visible = true;
            this.colNumero1.VisibleIndex = 1;
            this.colNumero1.Width = 56;
            // 
            // colnumero_cuota1
            // 
            this.colnumero_cuota1.FieldName = "numero_cuota";
            this.colnumero_cuota1.Name = "colnumero_cuota1";
            this.colnumero_cuota1.Visible = true;
            this.colnumero_cuota1.VisibleIndex = 2;
            this.colnumero_cuota1.Width = 29;
            // 
            // colvalor_cuota1
            // 
            this.colvalor_cuota1.FieldName = "valor_cuota";
            this.colvalor_cuota1.Name = "colvalor_cuota1";
            this.colvalor_cuota1.Visible = true;
            this.colvalor_cuota1.VisibleIndex = 3;
            this.colvalor_cuota1.Width = 29;
            // 
            // colvalor_interes1
            // 
            this.colvalor_interes1.FieldName = "valor_interes";
            this.colvalor_interes1.Name = "colvalor_interes1";
            this.colvalor_interes1.Visible = true;
            this.colvalor_interes1.VisibleIndex = 4;
            this.colvalor_interes1.Width = 29;
            // 
            // colvalor_mora1
            // 
            this.colvalor_mora1.FieldName = "valor_mora";
            this.colvalor_mora1.Name = "colvalor_mora1";
            this.colvalor_mora1.Visible = true;
            this.colvalor_mora1.VisibleIndex = 5;
            this.colvalor_mora1.Width = 29;
            // 
            // colfecha_cobro1
            // 
            this.colfecha_cobro1.FieldName = "fecha_cobro";
            this.colfecha_cobro1.Name = "colfecha_cobro1";
            this.colfecha_cobro1.Visible = true;
            this.colfecha_cobro1.VisibleIndex = 6;
            this.colfecha_cobro1.Width = 29;
            // 
            // colfecha_vencimiento1
            // 
            this.colfecha_vencimiento1.FieldName = "fecha_vencimiento";
            this.colfecha_vencimiento1.Name = "colfecha_vencimiento1";
            this.colfecha_vencimiento1.Visible = true;
            this.colfecha_vencimiento1.VisibleIndex = 7;
            this.colfecha_vencimiento1.Width = 29;
            // 
            // colFechaModificacion1
            // 
            this.colFechaModificacion1.FieldName = "FechaModificacion";
            this.colFechaModificacion1.Name = "colFechaModificacion1";
            this.colFechaModificacion1.Visible = true;
            this.colFechaModificacion1.VisibleIndex = 8;
            this.colFechaModificacion1.Width = 29;
            // 
            // colestado1
            // 
            this.colestado1.FieldName = "estado";
            this.colestado1.Name = "colestado1";
            this.colestado1.Visible = true;
            this.colestado1.VisibleIndex = 9;
            this.colestado1.Width = 38;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(52, 483);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(34, 13);
            this.labelControl6.TabIndex = 107;
            this.labelControl6.Text = "Banco";
            // 
            // gueBanco
            // 
            this.gueBanco.Location = new System.Drawing.Point(98, 480);
            this.gueBanco.MenuManager = this.barManager1;
            this.gueBanco.Name = "gueBanco";
            this.gueBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gueBanco.Properties.DataSource = this.clsBancoBindingSource;
            this.gueBanco.Properties.DisplayMember = "Nombre";
            this.gueBanco.Properties.ValueMember = "idBanco";
            this.gueBanco.Properties.View = this.gridView3;
            this.gueBanco.Size = new System.Drawing.Size(100, 20);
            this.gueBanco.TabIndex = 108;
            // 
            // clsBancoBindingSource
            // 
            this.clsBancoBindingSource.DataSource = typeof(clases.CuentasxCobrar.clsBanco);
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(9, 511);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 26);
            this.labelControl7.TabIndex = 113;
            this.labelControl7.Text = "Numeo\r\nComprobante";
            // 
            // txtNoComprobante
            // 
            this.txtNoComprobante.Location = new System.Drawing.Point(98, 517);
            this.txtNoComprobante.Name = "txtNoComprobante";
            this.txtNoComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtNoComprobante.TabIndex = 114;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(225, 447);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 115;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(96, 591);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(196, 63);
            this.txtObservacion.TabIndex = 116;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl12.Location = new System.Drawing.Point(24, 618);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(70, 13);
            this.labelControl12.TabIndex = 117;
            this.labelControl12.Text = "Observacion";
            // 
            // frm_cobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 683);
            this.Controls.Add(this.labelControl12);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNoComprobante);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.gueBanco);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gluMedioPago);
            this.Controls.Add(this.labelControl18);
            this.Controls.Add(this.grvCtaDet);
            this.Controls.Add(this.labelControl20);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_cobro";
            this.Text = "Cobro";
            this.Load += new System.EventHandler(this.frm_cobro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVen.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaVen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtModulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCtaCobro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoCobro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMora.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaldo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroCuota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoFactura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluMedioPago.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMedioPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCtaDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaxCobrarDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaxCobrarDetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gueBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBancoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoComprobante.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtNoFactura;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNuevo;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnGrabar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtIdCliente;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtValorCuota;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtNumeroCuota;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.TextEdit txtSaldo;
        private DevExpress.XtraGrid.GridControl grvCtaDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit txtMora;
        private DevExpress.XtraEditors.TextEdit txtNombreCliente;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.TextEdit txtNoCobro;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.TextEdit txtInteres;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtModulo;
        private DevExpress.XtraEditors.LabelControl lblModulo;
        private DevExpress.XtraEditors.SimpleButton btnBuscaCtaxCobrar;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtNoCtaCobro;
        private DevExpress.XtraEditors.GridLookUpEdit gluMedioPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource clsMedioPagoBindingSource;
        private System.Windows.Forms.BindingSource clsCuentaxCobrarDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidCuentaxCobrar;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_cuota;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_cuota;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_interes;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_mora;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_cobro;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private DevExpress.XtraEditors.GridLookUpEdit gueBanco;
        private System.Windows.Forms.BindingSource clsBancoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource clsCuentaxCobrarDetBindingSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colidCuentaxCobrar1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero1;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_cuota1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_cuota1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_interes1;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_mora1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_cobro1;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_vencimiento1;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion1;
        private DevExpress.XtraGrid.Columns.GridColumn colestado1;
        private DevExpress.XtraEditors.TextEdit txtNoComprobante;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Button btnAgregar;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox txtObservacion;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.DateEdit dtFechaVen;
    }
}