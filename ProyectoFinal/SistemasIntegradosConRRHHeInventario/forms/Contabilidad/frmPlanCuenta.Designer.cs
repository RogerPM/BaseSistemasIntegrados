namespace forms.Contabilidad
{
    partial class frmPlanCuenta
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
            this.treePlanCuenta = new DevExpress.XtraTreeList.TreeList();
            this.colIdEmpresa = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdCuenta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colcodigo_padre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colnombre = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.coldescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdNivelCuenta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdTipoCuenta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colnaturaleza_cuenta = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIdUsuario = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFechaModficacion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.clsCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNaturaleza = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtnombre = new DevExpress.XtraEditors.TextEdit();
            this.cmbtipo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.cmbNaturaleza = new System.Windows.Forms.ComboBox();
            this.cmbPadre = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridViewCmbPadre = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldigitos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new DevExpress.XtraEditors.TextEdit();
            this.pnlControl = new DevExpress.XtraEditors.PanelControl();
            this.gcontrol = new DevExpress.XtraGrid.GridControl();
            this.gView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnExpandir = new System.Windows.Forms.Button();
            this.btnAcoplar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.treePlanCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtipo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPadre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCmbPadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView)).BeginInit();
            this.SuspendLayout();
            // 
            // treePlanCuenta
            // 
            this.treePlanCuenta.Appearance.CustomizationFormHint.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.CustomizationFormHint.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.CustomizationFormHint.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.CustomizationFormHint.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.CustomizationFormHint.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.Empty.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Empty.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Empty.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Empty.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.Empty.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.EvenRow.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.EvenRow.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.EvenRow.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.EvenRow.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.EvenRow.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.FilterPanel.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FilterPanel.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FilterPanel.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.FilterPanel.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.FixedLine.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FixedLine.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FixedLine.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FixedLine.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.FixedLine.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.FocusedCell.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedCell.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedCell.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.FocusedCell.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.FocusedRow.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedRow.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FocusedRow.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.FooterPanel.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FooterPanel.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.FooterPanel.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.GroupButton.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupButton.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupButton.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupButton.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.GroupButton.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.GroupFooter.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupFooter.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupFooter.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.GroupFooter.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.HideSelectionRow.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.HorzLine.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HorzLine.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HorzLine.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.HorzLine.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.HorzLine.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.OddRow.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.OddRow.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.OddRow.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Preview.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Preview.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Preview.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.Preview.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Row.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.Row.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.Row.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.SelectedRow.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.SelectedRow.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.SelectedRow.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.SelectedRow.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.TreeLine.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.TreeLine.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.TreeLine.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.TreeLine.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.TreeLine.Options.UseBorderColor = true;
            this.treePlanCuenta.Appearance.VertLine.BackColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.VertLine.BackColor2 = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.VertLine.BorderColor = System.Drawing.Color.White;
            this.treePlanCuenta.Appearance.VertLine.Options.UseBackColor = true;
            this.treePlanCuenta.Appearance.VertLine.Options.UseBorderColor = true;
            this.treePlanCuenta.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colIdEmpresa,
            this.colIdCuenta,
            this.colcodigo_padre,
            this.colnombre,
            this.coldescripcion,
            this.colIdNivelCuenta,
            this.colIdTipoCuenta,
            this.colnaturaleza_cuenta,
            this.colIdUsuario,
            this.colFechaModficacion});
            this.treePlanCuenta.DataSource = this.clsCuentaBindingSource;
            this.treePlanCuenta.KeyFieldName = "IdCuenta";
            this.treePlanCuenta.Location = new System.Drawing.Point(23, 43);
            this.treePlanCuenta.Name = "treePlanCuenta";
            this.treePlanCuenta.OptionsBehavior.Editable = false;
            this.treePlanCuenta.OptionsBehavior.PopulateServiceColumns = true;
            this.treePlanCuenta.OptionsPrint.UsePrintStyles = true;
            this.treePlanCuenta.OptionsView.ShowColumns = false;
            this.treePlanCuenta.OptionsView.ShowIndicator = false;
            this.treePlanCuenta.ParentFieldName = "codigo_padre";
            this.treePlanCuenta.Size = new System.Drawing.Size(320, 341);
            this.treePlanCuenta.TabIndex = 0;
            this.treePlanCuenta.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treePlanCuenta_AfterFocusNode);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            // 
            // colcodigo_padre
            // 
            this.colcodigo_padre.FieldName = "codigo_padre";
            this.colcodigo_padre.Name = "colcodigo_padre";
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colIdNivelCuenta
            // 
            this.colIdNivelCuenta.FieldName = "IdNivelCuenta";
            this.colIdNivelCuenta.Name = "colIdNivelCuenta";
            // 
            // colIdTipoCuenta
            // 
            this.colIdTipoCuenta.FieldName = "IdTipoCuenta";
            this.colIdTipoCuenta.Name = "colIdTipoCuenta";
            // 
            // colnaturaleza_cuenta
            // 
            this.colnaturaleza_cuenta.FieldName = "naturaleza_cuenta";
            this.colnaturaleza_cuenta.Name = "colnaturaleza_cuenta";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFechaModficacion
            // 
            this.colFechaModficacion.FieldName = "FechaModficacion";
            this.colFechaModficacion.Name = "colFechaModficacion";
            // 
            // clsCuentaBindingSource
            // 
            this.clsCuentaBindingSource.DataSource = typeof(clases.Contabilidad.clsCuenta);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(23, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNaturaleza
            // 
            this.lblNaturaleza.AutoSize = true;
            this.lblNaturaleza.Location = new System.Drawing.Point(23, 99);
            this.lblNaturaleza.Name = "lblNaturaleza";
            this.lblNaturaleza.Size = new System.Drawing.Size(58, 13);
            this.lblNaturaleza.TabIndex = 3;
            this.lblNaturaleza.Text = "Naturaleza";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 177);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(23, 139);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(104, 53);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Properties.MaxLength = 50;
            this.txtnombre.Size = new System.Drawing.Size(183, 20);
            this.txtnombre.TabIndex = 7;
            // 
            // cmbtipo
            // 
            this.cmbtipo.Location = new System.Drawing.Point(104, 136);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbtipo.Properties.DataSource = this.clsTipoCuentaBindingSource;
            this.cmbtipo.Properties.DisplayMember = "nombre";
            this.cmbtipo.Properties.ValueMember = "IdTipoCuenta";
            this.cmbtipo.Properties.View = this.gridView1;
            this.cmbtipo.Size = new System.Drawing.Size(183, 20);
            this.cmbtipo.TabIndex = 9;
            // 
            // clsTipoCuentaBindingSource
            // 
            this.clsTipoCuentaBindingSource.DataSource = typeof(clases.Contabilidad.clsTipoCuenta);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 177);
            this.txtDescripcion.MaxLength = 80;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(183, 45);
            this.txtDescripcion.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator2,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnModificar,
            this.toolStripLabel1,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 25);
            this.toolStrip1.TabIndex = 21;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(157, 22);
            this.toolStripLabel1.Text = "                                                  ";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // cmbNaturaleza
            // 
            this.cmbNaturaleza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNaturaleza.FormattingEnabled = true;
            this.cmbNaturaleza.Items.AddRange(new object[] {
            "Debe",
            "Haber"});
            this.cmbNaturaleza.Location = new System.Drawing.Point(104, 96);
            this.cmbNaturaleza.Name = "cmbNaturaleza";
            this.cmbNaturaleza.Size = new System.Drawing.Size(182, 21);
            this.cmbNaturaleza.TabIndex = 23;
            // 
            // cmbPadre
            // 
            this.cmbPadre.Location = new System.Drawing.Point(453, 48);
            this.cmbPadre.Name = "cmbPadre";
            this.cmbPadre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPadre.Properties.DataSource = this.clsCuentaBindingSource;
            this.cmbPadre.Properties.DisplayMember = "nombre";
            this.cmbPadre.Properties.ValueMember = "IdCuenta";
            this.cmbPadre.Properties.View = this.gridViewCmbPadre;
            this.cmbPadre.Size = new System.Drawing.Size(183, 20);
            this.cmbPadre.TabIndex = 9;
            this.cmbPadre.Visible = false;
            this.cmbPadre.EditValueChanged += new System.EventHandler(this.cmbPadre_EditValueChanged);
            // 
            // gridViewCmbPadre
            // 
            this.gridViewCmbPadre.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.tipoCuenta,
            this.nCuenta,
            this.gridColumn9,
            this.gridColumn10,
            this.coldigitos});
            this.gridViewCmbPadre.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridViewCmbPadre.Name = "gridViewCmbPadre";
            this.gridViewCmbPadre.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewCmbPadre.OptionsView.ShowGroupPanel = false;
            this.gridViewCmbPadre.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewCmbPadre_RowClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdCuenta";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "codigo_padre";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "descripcion";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IdNivelCuenta";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.FieldName = "IdTipoCuenta";
            this.tipoCuenta.Name = "tipoCuenta";
            // 
            // nCuenta
            // 
            this.nCuenta.FieldName = "naturaleza_cuenta";
            this.nCuenta.Name = "nCuenta";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "IdUsuario";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "FechaModficacion";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // coldigitos
            // 
            this.coldigitos.FieldName = "digitos";
            this.coldigitos.Name = "coldigitos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            this.label1.Visible = false;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(104, 15);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Properties.Mask.EditMask = "\\d+";
            this.txtcodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtcodigo.Properties.Mask.ShowPlaceHolders = false;
            this.txtcodigo.Size = new System.Drawing.Size(183, 20);
            this.txtcodigo.TabIndex = 24;
            // 
            // pnlControl
            // 
            this.pnlControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pnlControl.Appearance.Options.UseBackColor = true;
            this.pnlControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlControl.Controls.Add(this.txtDescripcion);
            this.pnlControl.Controls.Add(this.txtcodigo);
            this.pnlControl.Controls.Add(this.lblCodigo);
            this.pnlControl.Controls.Add(this.cmbNaturaleza);
            this.pnlControl.Controls.Add(this.lblNombre);
            this.pnlControl.Controls.Add(this.lblNaturaleza);
            this.pnlControl.Controls.Add(this.lblTipo);
            this.pnlControl.Controls.Add(this.lblDescripcion);
            this.pnlControl.Controls.Add(this.cmbtipo);
            this.pnlControl.Controls.Add(this.txtnombre);
            this.pnlControl.Location = new System.Drawing.Point(349, 74);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(294, 239);
            this.pnlControl.TabIndex = 25;
            // 
            // gcontrol
            // 
            this.gcontrol.Location = new System.Drawing.Point(616, 367);
            this.gcontrol.MainView = this.gView;
            this.gcontrol.Name = "gcontrol";
            this.gcontrol.Size = new System.Drawing.Size(45, 31);
            this.gcontrol.TabIndex = 26;
            this.gcontrol.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gView});
            this.gcontrol.Visible = false;
            // 
            // gView
            // 
            this.gView.GridControl = this.gcontrol;
            this.gView.Name = "gView";
            // 
            // btnExpandir
            // 
            this.btnExpandir.Location = new System.Drawing.Point(349, 340);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(19, 23);
            this.btnExpandir.TabIndex = 27;
            this.btnExpandir.UseVisualStyleBackColor = true;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // btnAcoplar
            // 
            this.btnAcoplar.Location = new System.Drawing.Point(349, 361);
            this.btnAcoplar.Name = "btnAcoplar";
            this.btnAcoplar.Size = new System.Drawing.Size(19, 23);
            this.btnAcoplar.TabIndex = 27;
            this.btnAcoplar.UseVisualStyleBackColor = true;
            this.btnAcoplar.Click += new System.EventHandler(this.btnAcoplar_Click);
            // 
            // frmPlanCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 410);
            this.Controls.Add(this.btnAcoplar);
            this.Controls.Add(this.btnExpandir);
            this.Controls.Add(this.gcontrol);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbPadre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treePlanCuenta);
            this.Name = "frmPlanCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Plan de Cuenta";
            this.Load += new System.EventHandler(this.frmPlanCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treePlanCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbtipo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPadre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCmbPadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlControl)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treePlanCuenta;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNaturaleza;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTipo;
        private DevExpress.XtraEditors.TextEdit txtnombre;
        private DevExpress.XtraEditors.GridLookUpEdit cmbtipo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.BindingSource clsCuentaBindingSource;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdEmpresa;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdCuenta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colcodigo_padre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnombre;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coldescripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdNivelCuenta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdTipoCuenta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colnaturaleza_cuenta;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIdUsuario;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFechaModficacion;
        private System.Windows.Forms.BindingSource clsTipoCuentaBindingSource;
        private System.Windows.Forms.ComboBox cmbNaturaleza;
        private DevExpress.XtraEditors.GridLookUpEdit cmbPadre;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCmbPadre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn tipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn nCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn coldigitos;
        private DevExpress.XtraEditors.TextEdit txtcodigo;
        private DevExpress.XtraEditors.PanelControl pnlControl;
        private DevExpress.XtraGrid.GridControl gcontrol;
        private DevExpress.XtraGrid.Views.Grid.GridView gView;
        private System.Windows.Forms.Button btnExpandir;
        private System.Windows.Forms.Button btnAcoplar;
    }
}