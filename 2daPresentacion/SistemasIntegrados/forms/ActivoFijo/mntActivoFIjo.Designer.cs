
namespace forms.ActivoFijo
{
    partial class mntActivoFIjo
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
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.txtSubgrupo = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.clsGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.cbxEmpresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(25, 61);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoActivo.TabIndex = 299;
            this.lblCodigoActivo.Text = "Codigo Subgrupo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 296;
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
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(127, 22);
            this.tslEnBlanco.Text = "                                        ";
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
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(313, 129);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 294;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(374, 58);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 292;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(325, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 291;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(321, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 289;
            this.lblEstado.Text = "Estado:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(25, 95);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 286;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(109, 58);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 3;
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.Enabled = false;
            this.txtSubgrupo.Location = new System.Drawing.Point(109, 126);
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(198, 20);
            this.txtSubgrupo.TabIndex = 309;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(25, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 288;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Location = new System.Drawing.Point(172, 61);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(36, 17);
            this.btnbuscar.TabIndex = 310;
            this.btnbuscar.Text = "...";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // clsGrupoBindingSource
            // 
            this.clsGrupoBindingSource.DataSource = typeof(clases.Inventario.clsGrupo);
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Enabled = false;
            this.cbxGrupo.Location = new System.Drawing.Point(109, 92);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.DataSource = this.clsGrupoBindingSource;
            this.cbxGrupo.Properties.DisplayMember = "Descripcion";
            this.cbxGrupo.Properties.ValueMember = "Descripcion";
            this.cbxGrupo.Properties.View = this.gridLookUpEdit1View;
            this.cbxGrupo.Size = new System.Drawing.Size(147, 20);
            this.cbxGrupo.TabIndex = 316;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodGrupo,
            this.colEmpresa,
            this.colDescripcion,
            this.colTipoArticulo,
            this.colEstado,
            this.colUsuario});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.Location = new System.Drawing.Point(374, 92);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridView1;
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 317;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clsEmpresaBindingSource
            // 
            this.clsEmpresaBindingSource.DataSource = typeof(clases.Seguridad.clsEmpresa);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            // cbxEmpresa
            // 
            this.cbxEmpresa.Enabled = false;
            this.cbxEmpresa.Location = new System.Drawing.Point(374, 126);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpresa.Properties.DataSource = this.clsEmpresaBindingSource;
            this.cbxEmpresa.Properties.DisplayMember = "nombreComercial";
            this.cbxEmpresa.Properties.ValueMember = "nombreComercial";
            this.cbxEmpresa.Properties.View = this.gridView2;
            this.cbxEmpresa.Size = new System.Drawing.Size(111, 20);
            this.cbxEmpresa.TabIndex = 318;
            // 
            // mntActivoFIjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 188);
            this.Controls.Add(this.cbxEmpresa);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtSubgrupo);
            this.Controls.Add(this.txtCodigoActivo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblGrupo);
            this.Name = "mntActivoFIjo";
            this.Text = "mntActivoFIjo";
            this.Load += new System.EventHandler(this.mntActivoFIjo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        private DevExpress.XtraEditors.TextEdit txtSubgrupo;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.BindingSource clsGrupoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colCodGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private System.Windows.Forms.BindingSource clsEmpresaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEmpresa;
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
    }
}