

namespace forms.ActivoFijo
{
    partial class prcsActivoFijo
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
            this.txteCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarCodBarra = new DevExpress.XtraEditors.SimpleButton();
            this.btnAsignar = new DevExpress.XtraEditors.SimpleButton();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxEmpresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collogotipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicioSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsitioWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsSubgrupoActivoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlCargar = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSubgrupoActivoFijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCargar)).BeginInit();
            this.SuspendLayout();
            // 
            // txteCodigo
            // 
            this.txteCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteCodigo.EditValue = "000-001";
            this.txteCodigo.Enabled = false;
            this.txteCodigo.Location = new System.Drawing.Point(115, 40);
            this.txteCodigo.Name = "txteCodigo";
            this.txteCodigo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txteCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteCodigo.Size = new System.Drawing.Size(65, 20);
            this.txteCodigo.TabIndex = 99;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(31, 42);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoActivo.TabIndex = 98;
            this.lblCodigoActivo.Text = "Codigo Activo:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnConsultar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(532, 25);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
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
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 167);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(376, 20);
            this.txtDescripcion.TabIndex = 93;
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(380, 40);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 92;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(321, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 91;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(115, 107);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.Items.AddRange(new object[] {
            "Articulos/Suministros de Oficinas",
            "Vehiculos",
            "Muebles y Enseres",
            "Edificios",
            "Terrenos",
            "Equipos",
            "Maquinarias"});
            this.cbxGrupo.Size = new System.Drawing.Size(124, 20);
            this.cbxGrupo.TabIndex = 87;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(31, 170);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 86;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(31, 110);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 84;
            this.lblGrupo.Text = "Grupo:";
            // 
            // textEdit2
            // 
            this.textEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEdit2.EditValue = "Edwin Estacio Bermeo";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(115, 74);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Size = new System.Drawing.Size(124, 20);
            this.textEdit2.TabIndex = 83;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(31, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 82;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnGenerarCodBarra
            // 
            this.btnGenerarCodBarra.Location = new System.Drawing.Point(162, 636);
            this.btnGenerarCodBarra.Name = "btnGenerarCodBarra";
            this.btnGenerarCodBarra.Size = new System.Drawing.Size(111, 22);
            this.btnGenerarCodBarra.TabIndex = 101;
            this.btnGenerarCodBarra.Text = "Generar Cod.Barra";
            this.btnGenerarCodBarra.Click += new System.EventHandler(this.btnGenerarCodBarra_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(27, 636);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(111, 22);
            this.btnAsignar.TabIndex = 100;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(317, 77);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 89;
            this.lblEstado.Text = "Estado:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(309, 115);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 95;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(31, 140);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 85;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Location = new System.Drawing.Point(115, 137);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Properties.DataSource = this.clsSubgrupoActivoFijoBindingSource;
            this.cbxSubGrupo.Properties.DisplayMember = "descripcion";
            this.cbxSubGrupo.Properties.ValueMember = "descripcion";
            this.cbxSubGrupo.Properties.View = this.gridView3;
            this.cbxSubGrupo.Size = new System.Drawing.Size(111, 20);
            this.cbxSubGrupo.TabIndex = 319;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colGrupo,
            this.gridColumn2,
            this.colFecha,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            this.gridView3.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
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
            // cbxEmpresa
            // 
            this.cbxEmpresa.Location = new System.Drawing.Point(380, 112);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpresa.Properties.DataSource = this.clsEmpresaBindingSource;
            this.cbxEmpresa.Properties.DisplayMember = "nombreComercial";
            this.cbxEmpresa.Properties.ValueMember = "nombreComercial";
            this.cbxEmpresa.Properties.View = this.gridView5;
            this.cbxEmpresa.Size = new System.Drawing.Size(111, 20);
            this.cbxEmpresa.TabIndex = 322;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpresa,
            this.colrazonSocial,
            this.colnombreComercial,
            this.colruc,
            this.coldireccion,
            this.collogotipo,
            this.colfechaInicioSistema,
            this.colcorreo,
            this.colsitioWeb,
            this.colsector,
            this.gridColumn1,
            this.colidEstado});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            this.colidEmpresa.Visible = true;
            this.colidEmpresa.VisibleIndex = 0;
            this.colidEmpresa.Width = 74;
            // 
            // colrazonSocial
            // 
            this.colrazonSocial.FieldName = "razonSocial";
            this.colrazonSocial.Name = "colrazonSocial";
            this.colrazonSocial.Visible = true;
            this.colrazonSocial.VisibleIndex = 1;
            this.colrazonSocial.Width = 219;
            // 
            // colnombreComercial
            // 
            this.colnombreComercial.FieldName = "nombreComercial";
            this.colnombreComercial.Name = "colnombreComercial";
            this.colnombreComercial.Visible = true;
            this.colnombreComercial.VisibleIndex = 2;
            this.colnombreComercial.Width = 219;
            // 
            // colruc
            // 
            this.colruc.FieldName = "ruc";
            this.colruc.Name = "colruc";
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            // 
            // collogotipo
            // 
            this.collogotipo.FieldName = "logotipo";
            this.collogotipo.Name = "collogotipo";
            // 
            // colfechaInicioSistema
            // 
            this.colfechaInicioSistema.FieldName = "fechaInicioSistema";
            this.colfechaInicioSistema.Name = "colfechaInicioSistema";
            // 
            // colcorreo
            // 
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            // 
            // colsitioWeb
            // 
            this.colsitioWeb.FieldName = "sitioWeb";
            this.colsitioWeb.Name = "colsitioWeb";
            // 
            // colsector
            // 
            this.colsector.FieldName = "sector";
            this.colsector.Name = "colsector";
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 221;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Location = new System.Drawing.Point(380, 74);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridView4;
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 321;
            // 
            // gridView4
            // 
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // clsSubgrupoActivoFijoBindingSource
            // 
            this.clsSubgrupoActivoFijoBindingSource.DataSource = typeof(clases.ActivoFijo.clsSubgrupoActivoFijo);
            // 
            // clsGrupoBindingSource
            // 
            this.clsGrupoBindingSource.DataSource = typeof(clases.Inventario.clsGrupo);
            // 
            // clsEmpresaBindingSource
            // 
            this.clsEmpresaBindingSource.DataSource = typeof(clases.Seguridad.clsEmpresa);
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // pnlCargar
            // 
            this.pnlCargar.Location = new System.Drawing.Point(16, 204);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(494, 422);
            this.pnlCargar.TabIndex = 323;
            // 
            // prcsActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 670);
            this.Controls.Add(this.pnlCargar);
            this.Controls.Add(this.cbxEmpresa);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxSubGrupo);
            this.Controls.Add(this.btnGenerarCodBarra);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txteCodigo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.lblUsuario);
            this.Name = "prcsActivoFijo";
            this.Text = "prcsActivoFijo";
            this.Load += new System.EventHandler(this.prcsActivoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSubgrupoActivoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCargar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txteCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SimpleButton btnGenerarCodBarra;
        private DevExpress.XtraEditors.SimpleButton btnAsignar;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.GridLookUpEdit cbxSubGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colrazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colruc;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn collogotipo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicioSistema;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colsitioWeb;
        private DevExpress.XtraGrid.Columns.GridColumn colsector;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource clsSubgrupoActivoFijoBindingSource;
        private System.Windows.Forms.BindingSource clsGrupoBindingSource;
        private System.Windows.Forms.BindingSource clsEmpresaBindingSource;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraEditors.PanelControl pnlCargar;
    }
}