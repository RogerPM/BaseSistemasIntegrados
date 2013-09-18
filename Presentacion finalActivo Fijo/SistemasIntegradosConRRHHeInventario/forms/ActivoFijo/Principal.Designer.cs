namespace forms.ActivoFijo
{
    partial class userPrincipal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txteUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(387, 10);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 79;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(320, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 78;
            this.lblFecha.Text = "Fecha:";
            // 
            // txteUsuario
            // 
            this.txteUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteUsuario.EditValue = "Edwin Estacio Bermeo";
            this.txteUsuario.Enabled = false;
            this.txteUsuario.Location = new System.Drawing.Point(375, 76);
            this.txteUsuario.Name = "txteUsuario";
            this.txteUsuario.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txteUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteUsuario.Size = new System.Drawing.Size(112, 20);
            this.txteUsuario.TabIndex = 77;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(317, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 76;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(115, 102);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescripcion.Properties.Appearance.Options.UseBackColor = true;
            this.txtDescripcion.Size = new System.Drawing.Size(372, 20);
            this.txtDescripcion.TabIndex = 75;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(19, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 72;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(178, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 17);
            this.btnBuscar.TabIndex = 307;
            this.btnBuscar.Text = "...";
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(115, 10);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 306;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(19, 13);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoActivo.TabIndex = 305;
            this.lblCodigoActivo.Text = "Codigo Activo:";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Location = new System.Drawing.Point(115, 69);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Properties.DisplayMember = "descripcion";
            this.cbxSubGrupo.Properties.ValueMember = "descripcion";
            this.cbxSubGrupo.Properties.View = this.gridView3;
            this.cbxSubGrupo.Size = new System.Drawing.Size(111, 20);
            this.cbxSubGrupo.TabIndex = 322;
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
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(115, 42);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.DisplayMember = "Descripcion";
            this.cbxGrupo.Properties.ValueMember = "Descripcion";
            this.cbxGrupo.Properties.View = this.gridView2;
            this.cbxGrupo.Size = new System.Drawing.Size(111, 20);
            this.cbxGrupo.TabIndex = 321;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodGrupo,
            this.colEmpresa,
            this.colDescripcion,
            this.colTipoArticulo,
            this.colEstado,
            this.colUsuario});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
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
            this.lblSubGrupo.Location = new System.Drawing.Point(19, 72);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 320;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(19, 45);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 319;
            this.lblGrupo.Text = "Grupo:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.Location = new System.Drawing.Point(375, 42);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxEstado.Properties.Appearance.Options.UseBackColor = true;
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.ValueMember = "descripcion";
            this.cbxEstado.Properties.View = this.gridView4;
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 324;
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
            this.lblEstado.Location = new System.Drawing.Point(321, 49);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 323;
            this.lblEstado.Text = "Estado:";
            // 
            // userPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "userPrincipal";
            this.Size = new System.Drawing.Size(507, 132);
            this.Load += new System.EventHandler(this.userPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        public DevExpress.XtraEditors.DateEdit dtFecha;
        public DevExpress.XtraEditors.LabelControl lblFecha;
        public DevExpress.XtraEditors.TextEdit txteUsuario;
        public DevExpress.XtraEditors.LabelControl lblUsuario;
        public DevExpress.XtraEditors.TextEdit txtDescripcion;
        public DevExpress.XtraEditors.LabelControl lblDescripcion;
        public DevExpress.XtraEditors.SimpleButton btnBuscar;
        public DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        public DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        public DevExpress.XtraEditors.GridLookUpEdit cbxSubGrupo;
        public DevExpress.XtraEditors.GridLookUpEdit cbxGrupo;
        public DevExpress.XtraEditors.LabelControl lblSubGrupo;
        public DevExpress.XtraEditors.LabelControl lblGrupo;
        public DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        public DevExpress.XtraEditors.LabelControl lblEstado;
    }
}
