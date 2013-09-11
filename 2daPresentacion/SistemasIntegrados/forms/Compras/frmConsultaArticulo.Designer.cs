namespace forms.Compras
{
    partial class frmConsultaArticulo
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
            DevExpress.XtraGrid.Views.Grid.GridView articulos_datos;
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipo_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.grpControl2 = new DevExpress.XtraEditors.GroupControl();
            this.cbxgrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clscomprasgrupoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbxSubgrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblsubgrupo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.clscomprasgrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clscomprasarticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clscomprasarticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dtg_articulo = new DevExpress.XtraGrid.GridControl();
            this.clscomprasarticulosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listaarticulo_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidarticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad_actual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_tipoarticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_grupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            articulos_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(articulos_datos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpControl2)).BeginInit();
            this.grpControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasgrupoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasgrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_articulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaarticulo_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // articulos_datos
            // 
            articulos_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpresa,
            this.colidGrupo,
            this.coldescripcion,
            this.colid_tipo_articulo,
            this.colidEstado});
            articulos_datos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            articulos_datos.Name = "articulos_datos";
            articulos_datos.OptionsSelection.EnableAppearanceFocusedCell = false;
            articulos_datos.OptionsView.ShowGroupPanel = false;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // colidGrupo
            // 
            this.colidGrupo.FieldName = "idGrupo";
            this.colidGrupo.Name = "colidGrupo";
            this.colidGrupo.Visible = true;
            this.colidGrupo.VisibleIndex = 0;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            // 
            // colid_tipo_articulo
            // 
            this.colid_tipo_articulo.FieldName = "id_tipo_articulo";
            this.colid_tipo_articulo.Name = "colid_tipo_articulo";
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBuscar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(654, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.buscar;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            // 
            // grpControl2
            // 
            this.grpControl2.Controls.Add(this.cbxgrupo);
            this.grpControl2.Controls.Add(this.cbxSubgrupo);
            this.grpControl2.Controls.Add(this.lblsubgrupo);
            this.grpControl2.Controls.Add(this.labelControl7);
            this.grpControl2.Location = new System.Drawing.Point(0, 28);
            this.grpControl2.Name = "grpControl2";
            this.grpControl2.Size = new System.Drawing.Size(647, 55);
            this.grpControl2.TabIndex = 31;
            this.grpControl2.Text = "Datos del Artículo";
            // 
            // cbxgrupo
            // 
            this.cbxgrupo.Location = new System.Drawing.Point(52, 27);
            this.cbxgrupo.Name = "cbxgrupo";
            this.cbxgrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxgrupo.Properties.DataSource = this.clscomprasgrupoBindingSource1;
            this.cbxgrupo.Properties.DisplayMember = "descripcion";
            this.cbxgrupo.Properties.ValueMember = "idGrupo";
            this.cbxgrupo.Properties.View = articulos_datos;
            this.cbxgrupo.Size = new System.Drawing.Size(163, 20);
            this.cbxgrupo.TabIndex = 8;
            this.cbxgrupo.EditValueChanged += new System.EventHandler(this.cbxgrupo_EditValueChanged);
            // 
            // clscomprasgrupoBindingSource1
            // 
            this.clscomprasgrupoBindingSource1.DataSource = typeof(clases.Compras.clscompras_grupo);
            // 
            // cbxSubgrupo
            // 
            this.cbxSubgrupo.Location = new System.Drawing.Point(293, 27);
            this.cbxSubgrupo.Name = "cbxSubgrupo";
            this.cbxSubgrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubgrupo.Properties.Items.AddRange(new object[] {
            "Artículos de Limpieza",
            "Artículos de Oficina",
            "Productos para la venta",
            "Activos Fijos"});
            this.cbxSubgrupo.Size = new System.Drawing.Size(158, 20);
            this.cbxSubgrupo.TabIndex = 7;
            // 
            // lblsubgrupo
            // 
            this.lblsubgrupo.Location = new System.Drawing.Point(236, 30);
            this.lblsubgrupo.Name = "lblsubgrupo";
            this.lblsubgrupo.Size = new System.Drawing.Size(51, 13);
            this.lblsubgrupo.TabIndex = 6;
            this.lblsubgrupo.Text = "SubGrupo:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(13, 30);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Grupo:";
            // 
            // clscomprasgrupoBindingSource
            // 
            this.clscomprasgrupoBindingSource.DataSource = typeof(clases.Compras.clscompras_grupo);
            // 
            // clscomprasarticulosBindingSource
            // 
            this.clscomprasarticulosBindingSource.DataSource = typeof(clases.Compras.clscompras_articulos);
            // 
            // clscomprasarticulosBindingSource1
            // 
            this.clscomprasarticulosBindingSource1.DataSource = typeof(clases.Compras.clscompras_articulos);
            // 
            // dtg_articulo
            // 
            this.dtg_articulo.DataSource = this.clscomprasarticulosBindingSource2;
            this.dtg_articulo.Location = new System.Drawing.Point(0, 103);
            this.dtg_articulo.MainView = this.listaarticulo_datos;
            this.dtg_articulo.Name = "dtg_articulo";
            this.dtg_articulo.Size = new System.Drawing.Size(654, 200);
            this.dtg_articulo.TabIndex = 32;
            this.dtg_articulo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listaarticulo_datos});
            this.dtg_articulo.Click += new System.EventHandler(this.dtg_articulo_Click);
            // 
            // clscomprasarticulosBindingSource2
            // 
            this.clscomprasarticulosBindingSource2.DataSource = typeof(clases.Compras.clscompras_articulos);
            // 
            // listaarticulo_datos
            // 
            this.listaarticulo_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidarticulo,
            this.coldescripcion1,
            this.colcantidad_actual,
            this.colid_tipoarticulo,
            this.coltipo_articulo,
            this.colid_grupo,
            this.colgrupo,
            this.colid_empresa,
            this.colNombreComercial,
            this.colid_estado,
            this.colestado});
            this.listaarticulo_datos.GridControl = this.dtg_articulo;
            this.listaarticulo_datos.Name = "listaarticulo_datos";
            // 
            // colidarticulo
            // 
            this.colidarticulo.FieldName = "idarticulo";
            this.colidarticulo.Name = "colidarticulo";
            this.colidarticulo.Visible = true;
            this.colidarticulo.VisibleIndex = 0;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 1;
            // 
            // colcantidad_actual
            // 
            this.colcantidad_actual.FieldName = "cantidad_actual";
            this.colcantidad_actual.Name = "colcantidad_actual";
            // 
            // colid_tipoarticulo
            // 
            this.colid_tipoarticulo.FieldName = "id_tipoarticulo";
            this.colid_tipoarticulo.Name = "colid_tipoarticulo";
            // 
            // coltipo_articulo
            // 
            this.coltipo_articulo.FieldName = "tipo_articulo";
            this.coltipo_articulo.Name = "coltipo_articulo";
            this.coltipo_articulo.Visible = true;
            this.coltipo_articulo.VisibleIndex = 2;
            // 
            // colid_grupo
            // 
            this.colid_grupo.FieldName = "id_grupo";
            this.colid_grupo.Name = "colid_grupo";
            // 
            // colgrupo
            // 
            this.colgrupo.FieldName = "grupo";
            this.colgrupo.Name = "colgrupo";
            this.colgrupo.Visible = true;
            this.colgrupo.VisibleIndex = 3;
            // 
            // colid_empresa
            // 
            this.colid_empresa.FieldName = "id_empresa";
            this.colid_empresa.Name = "colid_empresa";
            // 
            // colNombreComercial
            // 
            this.colNombreComercial.FieldName = "NombreComercial";
            this.colNombreComercial.Name = "colNombreComercial";
            this.colNombreComercial.Visible = true;
            this.colNombreComercial.VisibleIndex = 4;
            // 
            // colid_estado
            // 
            this.colid_estado.FieldName = "id_estado";
            this.colid_estado.Name = "colid_estado";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 5;
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 306);
            this.Controls.Add(this.dtg_articulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grpControl2);
            this.Name = "frmConsultaArticulo";
            this.Text = "frmConsultaArticulo";
            this.Load += new System.EventHandler(this.frmConsultaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(articulos_datos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpControl2)).EndInit();
            this.grpControl2.ResumeLayout(false);
            this.grpControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasgrupoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasgrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_articulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clscomprasarticulosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaarticulo_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.GroupControl grpControl2;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSubgrupo;
        private DevExpress.XtraEditors.LabelControl lblsubgrupo;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.BindingSource clscomprasgrupoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipo_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private System.Windows.Forms.BindingSource clscomprasgrupoBindingSource1;
        private System.Windows.Forms.BindingSource clscomprasarticulosBindingSource;
        private System.Windows.Forms.BindingSource clscomprasarticulosBindingSource1;
        private DevExpress.XtraGrid.GridControl dtg_articulo;
        private DevExpress.XtraGrid.Views.Grid.GridView listaarticulo_datos;
        private System.Windows.Forms.BindingSource clscomprasarticulosBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colidarticulo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad_actual;
        private DevExpress.XtraGrid.Columns.GridColumn colid_tipoarticulo;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_grupo;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colid_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colid_estado;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}