
namespace forms.ActivoFijo
{
    partial class prcsDepreciacion
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.clsGridRevalorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsSubgrupoActivoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txteUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.GridDepreciacion = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPeriodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepreciacionAnual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepreciacionAcumulada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Perido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.rtbObservacion = new System.Windows.Forms.RichTextBox();
            this.lblObservacion = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicional = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridRevalorizacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSubgrupoActivoFijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnAnular,
            this.btnConsultar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
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
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::forms.Properties.Resources.modificar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(142, 22);
            this.tslEnBlanco.Text = "                                             ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clsGridRevalorizacionBindingSource
            // 
            this.clsGridRevalorizacionBindingSource.DataSource = typeof(clases.ActivoFijo.clsGridDepreciacion);
            // 
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.Location = new System.Drawing.Point(385, 73);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbxEstado.Properties.Appearance.Options.UseForeColor = true;
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridView4;
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 339;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(331, 80);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 338;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Enabled = false;
            this.cbxSubGrupo.Location = new System.Drawing.Point(125, 100);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxSubGrupo.Properties.Appearance.Options.UseForeColor = true;
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Properties.DataSource = this.clsSubgrupoActivoFijoBindingSource;
            this.cbxSubGrupo.Properties.DisplayMember = "descripcion";
            this.cbxSubGrupo.Properties.ValueMember = "descripcion";
            this.cbxSubGrupo.Properties.View = this.gridView5;
            this.cbxSubGrupo.Size = new System.Drawing.Size(147, 20);
            this.cbxSubGrupo.TabIndex = 337;
            // 
            // clsSubgrupoActivoFijoBindingSource
            // 
            this.clsSubgrupoActivoFijoBindingSource.DataSource = typeof(clases.ActivoFijo.clsSubgrupoActivoFijo);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colGrupo,
            this.gridColumn2,
            this.colFecha,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 268;
            // 
            // colGrupo
            // 
            this.colGrupo.FieldName = "Grupo";
            this.colGrupo.Name = "colGrupo";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "descripcion";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 465;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdEstado";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Width = 315;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Empresa";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Enabled = false;
            this.cbxGrupo.Location = new System.Drawing.Point(125, 73);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxGrupo.Properties.Appearance.Options.UseForeColor = true;
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.DataSource = this.clsGrupoBindingSource;
            this.cbxGrupo.Properties.DisplayMember = "Descripcion";
            this.cbxGrupo.Properties.ValueMember = "Descripcion";
            this.cbxGrupo.Properties.View = this.gridView6;
            this.cbxGrupo.Size = new System.Drawing.Size(147, 20);
            this.cbxGrupo.TabIndex = 336;
            // 
            // clsGrupoBindingSource
            // 
            this.clsGrupoBindingSource.DataSource = typeof(clases.Inventario.clsGrupo);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodGrupo,
            this.colEmpresa,
            this.colDescripcion,
            this.colTipoArticulo,
            this.colEstado,
            this.colUsuario});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colCodGrupo
            // 
            this.colCodGrupo.FieldName = "CodGrupo";
            this.colCodGrupo.Name = "colCodGrupo";
            this.colCodGrupo.Visible = true;
            this.colCodGrupo.VisibleIndex = 0;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colTipoArticulo
            // 
            this.colTipoArticulo.FieldName = "TipoArticulo";
            this.colTipoArticulo.Name = "colTipoArticulo";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(29, 103);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 335;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(29, 76);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 334;
            this.lblGrupo.Text = "Grupo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(188, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 17);
            this.btnBuscar.TabIndex = 333;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(125, 41);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigoActivo.Properties.Appearance.Options.UseForeColor = true;
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 332;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(29, 44);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoActivo.TabIndex = 331;
            this.lblCodigoActivo.Text = "Codigo Activo:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(397, 41);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 330;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(330, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 329;
            this.lblFecha.Text = "Fecha:";
            // 
            // txteUsuario
            // 
            this.txteUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteUsuario.EditValue = "Edwin Estacio Bermeo";
            this.txteUsuario.Enabled = false;
            this.txteUsuario.Location = new System.Drawing.Point(385, 107);
            this.txteUsuario.Name = "txteUsuario";
            this.txteUsuario.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteUsuario.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txteUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txteUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.txteUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteUsuario.Size = new System.Drawing.Size(112, 20);
            this.txteUsuario.TabIndex = 328;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(327, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 327;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(125, 133);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 20);
            this.txtDescripcion.TabIndex = 326;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(29, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 325;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // GridDepreciacion
            // 
            this.GridDepreciacion.DataSource = this.clsGridRevalorizacionBindingSource;
            this.GridDepreciacion.Location = new System.Drawing.Point(17, 215);
            this.GridDepreciacion.MainView = this.gridView1;
            this.GridDepreciacion.Name = "GridDepreciacion";
            this.GridDepreciacion.Size = new System.Drawing.Size(559, 163);
            this.GridDepreciacion.TabIndex = 341;
            this.GridDepreciacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPeriodo,
            this.colDepreciacionAnual,
            this.colDepreciacionAcumulada,
            this.coltotal,
            this.col_Perido});
            this.gridView1.GridControl = this.GridDepreciacion;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colPeriodo
            // 
            this.colPeriodo.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colPeriodo.AppearanceCell.Options.UseForeColor = true;
            this.colPeriodo.FieldName = "Periodo";
            this.colPeriodo.Name = "colPeriodo";
            this.colPeriodo.Visible = true;
            this.colPeriodo.VisibleIndex = 0;
            this.colPeriodo.Width = 92;
            // 
            // colDepreciacionAnual
            // 
            this.colDepreciacionAnual.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colDepreciacionAnual.AppearanceCell.Options.UseForeColor = true;
            this.colDepreciacionAnual.FieldName = "DepreciacionAnual";
            this.colDepreciacionAnual.Name = "colDepreciacionAnual";
            this.colDepreciacionAnual.Visible = true;
            this.colDepreciacionAnual.VisibleIndex = 1;
            this.colDepreciacionAnual.Width = 215;
            // 
            // colDepreciacionAcumulada
            // 
            this.colDepreciacionAcumulada.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.colDepreciacionAcumulada.AppearanceCell.Options.UseForeColor = true;
            this.colDepreciacionAcumulada.FieldName = "DepreciacionAcumulada";
            this.colDepreciacionAcumulada.Name = "colDepreciacionAcumulada";
            this.colDepreciacionAcumulada.Visible = true;
            this.colDepreciacionAcumulada.VisibleIndex = 2;
            this.colDepreciacionAcumulada.Width = 192;
            // 
            // coltotal
            // 
            this.coltotal.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.coltotal.AppearanceCell.Options.UseForeColor = true;
            this.coltotal.FieldName = "total";
            this.coltotal.Name = "coltotal";
            this.coltotal.Visible = true;
            this.coltotal.VisibleIndex = 3;
            this.coltotal.Width = 141;
            // 
            // col_Perido
            // 
            this.col_Perido.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.col_Perido.AppearanceCell.Options.UseForeColor = true;
            this.col_Perido.FieldName = "_Perido";
            this.col_Perido.Name = "col_Perido";
            this.col_Perido.Visible = true;
            this.col_Perido.VisibleIndex = 4;
            this.col_Perido.Width = 93;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Location = new System.Drawing.Point(16, 186);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 340;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click_1);
            // 
            // rtbObservacion
            // 
            this.rtbObservacion.BackColor = System.Drawing.Color.White;
            this.rtbObservacion.Enabled = false;
            this.rtbObservacion.Location = new System.Drawing.Point(93, 401);
            this.rtbObservacion.Name = "rtbObservacion";
            this.rtbObservacion.Size = new System.Drawing.Size(231, 27);
            this.rtbObservacion.TabIndex = 343;
            this.rtbObservacion.Text = "Ninguno";
            // 
            // lblObservacion
            // 
            this.lblObservacion.Location = new System.Drawing.Point(23, 404);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(64, 13);
            this.lblObservacion.TabIndex = 342;
            this.lblObservacion.Text = "Observación:";
            // 
            // btnAdicional
            // 
            this.btnAdicional.Image = global::forms.Properties.Resources._24_arrow_first;
            this.btnAdicional.Location = new System.Drawing.Point(347, 401);
            this.btnAdicional.Name = "btnAdicional";
            this.btnAdicional.Size = new System.Drawing.Size(84, 23);
            this.btnAdicional.TabIndex = 344;
            this.btnAdicional.Text = "Adicional";
            this.btnAdicional.Click += new System.EventHandler(this.btnAdicional_Click);
            // 
            // prcsDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 453);
            this.Controls.Add(this.btnAdicional);
            this.Controls.Add(this.rtbObservacion);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.GridDepreciacion);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxSubGrupo);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoActivo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txteUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.toolStrip1);
            this.Name = "prcsDepreciacion";
            this.Text = "prcsDepreciacion";
            this.Load += new System.EventHandler(this.prcsDepreciacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridRevalorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSubgrupoActivoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn colCodGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private System.Windows.Forms.BindingSource clsSubgrupoActivoFijoBindingSource;
        private System.Windows.Forms.BindingSource clsGrupoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.GridLookUpEdit cbxSubGrupo;
        private DevExpress.XtraEditors.GridLookUpEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txteUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private System.Windows.Forms.BindingSource clsGridRevalorizacionBindingSource;
        private DevExpress.XtraGrid.GridControl GridDepreciacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriodo;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciacionAnual;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciacionAcumulada;
        private DevExpress.XtraGrid.Columns.GridColumn coltotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_Perido;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        public System.Windows.Forms.RichTextBox rtbObservacion;
        public DevExpress.XtraEditors.LabelControl lblObservacion;
        public DevExpress.XtraEditors.SimpleButton btnAdicional;
    }
}