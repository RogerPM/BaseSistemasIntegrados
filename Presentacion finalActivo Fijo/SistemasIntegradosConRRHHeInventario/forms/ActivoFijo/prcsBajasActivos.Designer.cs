namespace forms.ActivoFijo
{
    partial class prcsBajasActivos
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
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.pictBajaActivo = new DevExpress.XtraEditors.PictureEdit();
            this.gbxAsignacion = new System.Windows.Forms.GroupBox();
            this.cbxMotivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMotivoBajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.llbMotivo = new DevExpress.XtraEditors.LabelControl();
            this.rtObservacion = new System.Windows.Forms.RichTextBox();
            this.lblDetalle = new DevExpress.XtraEditors.LabelControl();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.txteUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.cbxGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsGrupoAFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBajaActivo.Properties)).BeginInit();
            this.gbxAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoAFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(556, 25);
            this.toolStrip1.TabIndex = 20;
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
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Anular";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            // pictBajaActivo
            // 
            this.pictBajaActivo.Location = new System.Drawing.Point(345, 172);
            this.pictBajaActivo.Name = "pictBajaActivo";
            this.pictBajaActivo.Size = new System.Drawing.Size(169, 111);
            this.pictBajaActivo.TabIndex = 19;
            // 
            // gbxAsignacion
            // 
            this.gbxAsignacion.Controls.Add(this.cbxMotivo);
            this.gbxAsignacion.Controls.Add(this.llbMotivo);
            this.gbxAsignacion.Controls.Add(this.rtObservacion);
            this.gbxAsignacion.Controls.Add(this.lblDetalle);
            this.gbxAsignacion.Location = new System.Drawing.Point(12, 172);
            this.gbxAsignacion.Name = "gbxAsignacion";
            this.gbxAsignacion.Size = new System.Drawing.Size(305, 111);
            this.gbxAsignacion.TabIndex = 18;
            this.gbxAsignacion.TabStop = false;
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.Location = new System.Drawing.Point(138, 23);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMotivo.Properties.DataSource = this.clsMotivoBajaBindingSource;
            this.cbxMotivo.Properties.DisplayMember = "descripcion";
            this.cbxMotivo.Properties.ValueMember = "descripcion";
            this.cbxMotivo.Properties.View = this.gridView1;
            this.cbxMotivo.Size = new System.Drawing.Size(100, 20);
            this.cbxMotivo.TabIndex = 371;
            this.cbxMotivo.EditValueChanged += new System.EventHandler(this.cbxMotivo_EditValueChanged);
            // 
            // clsMotivoBajaBindingSource
            // 
            this.clsMotivoBajaBindingSource.DataSource = typeof(clases.ActivoFijo.clsMotivoBaja);
            this.clsMotivoBajaBindingSource.CurrentChanged += new System.EventHandler(this.clsMotivoBajaBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // llbMotivo
            // 
            this.llbMotivo.Location = new System.Drawing.Point(30, 26);
            this.llbMotivo.Name = "llbMotivo";
            this.llbMotivo.Size = new System.Drawing.Size(36, 13);
            this.llbMotivo.TabIndex = 30;
            this.llbMotivo.Text = "Motivo:";
            // 
            // rtObservacion
            // 
            this.rtObservacion.Location = new System.Drawing.Point(138, 54);
            this.rtObservacion.Name = "rtObservacion";
            this.rtObservacion.Size = new System.Drawing.Size(161, 43);
            this.rtObservacion.TabIndex = 26;
            this.rtObservacion.Text = "";
            // 
            // lblDetalle
            // 
            this.lblDetalle.Location = new System.Drawing.Point(27, 57);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(64, 13);
            this.lblDetalle.TabIndex = 25;
            this.lblDetalle.Text = "Observación:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.Location = new System.Drawing.Point(399, 71);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbxEstado.Properties.Appearance.Options.UseForeColor = true;
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridView4;
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 369;
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
            this.lblEstado.Location = new System.Drawing.Point(345, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 368;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Enabled = false;
            this.cbxSubGrupo.Location = new System.Drawing.Point(139, 98);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbxSubGrupo.Properties.Appearance.Options.UseForeColor = true;
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Properties.DisplayMember = "descripcion";
            this.cbxSubGrupo.Properties.ValueMember = "descripcion";
            this.cbxSubGrupo.Properties.View = this.gridView5;
            this.cbxSubGrupo.Size = new System.Drawing.Size(147, 20);
            this.cbxSubGrupo.TabIndex = 367;
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
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(43, 101);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 365;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(43, 74);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 364;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(139, 39);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigoActivo.Properties.Appearance.Options.UseForeColor = true;
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 362;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(43, 42);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoActivo.TabIndex = 361;
            this.lblCodigoActivo.Text = "Codigo Activo:";
            // 
            // txteUsuario
            // 
            this.txteUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteUsuario.EditValue = "Edwin Estacio Bermeo";
            this.txteUsuario.Enabled = false;
            this.txteUsuario.Location = new System.Drawing.Point(399, 105);
            this.txteUsuario.Name = "txteUsuario";
            this.txteUsuario.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteUsuario.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txteUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txteUsuario.Properties.Appearance.Options.UseForeColor = true;
            this.txteUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteUsuario.Size = new System.Drawing.Size(112, 20);
            this.txteUsuario.TabIndex = 360;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(341, 108);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 359;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(139, 131);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtDescripcion.Properties.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Properties.Appearance.Options.UseForeColor = true;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 20);
            this.txtDescripcion.TabIndex = 358;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(43, 134);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 357;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(398, 39);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 356;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(346, 42);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 355;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(139, 71);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.DataSource = this.clsGrupoAFBindingSource;
            this.cbxGrupo.Properties.DisplayMember = "Descripcion";
            this.cbxGrupo.Properties.ValueMember = "Descripcion";
            this.cbxGrupo.Properties.View = this.gridLookUpEdit1View;
            this.cbxGrupo.Size = new System.Drawing.Size(100, 20);
            this.cbxGrupo.TabIndex = 370;
            this.cbxGrupo.EditValueChanged += new System.EventHandler(this.cbxGrupo_EditValueChanged_1);
            // 
            // clsGrupoAFBindingSource
            // 
            this.clsGrupoAFBindingSource.DataSource = typeof(clases.Inventario.clsGrupoAF);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(202, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 17);
            this.btnBuscar.TabIndex = 371;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // prcsBajasActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 302);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxSubGrupo);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.txtCodigoActivo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.txteUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictBajaActivo);
            this.Controls.Add(this.gbxAsignacion);
            this.Name = "prcsBajasActivos";
            this.Text = "prcsBajasActivos";
            this.Load += new System.EventHandler(this.prcsBajasActivos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBajaActivo.Properties)).EndInit();
            this.gbxAsignacion.ResumeLayout(false);
            this.gbxAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoAFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.PictureEdit pictBajaActivo;
        private System.Windows.Forms.GroupBox gbxAsignacion;
        private DevExpress.XtraEditors.LabelControl llbMotivo;
        private System.Windows.Forms.RichTextBox rtObservacion;
        private DevExpress.XtraEditors.LabelControl lblDetalle;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.GridLookUpEdit cbxSubGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private DevExpress.XtraEditors.TextEdit txteUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private System.Windows.Forms.BindingSource clsGrupoAFBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private System.Windows.Forms.BindingSource clsMotivoBajaBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMotivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}