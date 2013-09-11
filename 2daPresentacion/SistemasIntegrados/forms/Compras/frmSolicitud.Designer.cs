namespace forms.Compras
{
    partial class frmSolicitud
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
            this.cmbTipoArticulo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnEliminarArticulos = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregarArticulo = new DevExpress.XtraEditors.SimpleButton();
            this.cmbDepartamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtnumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            this.dtgDetalle = new DevExpress.XtraGrid.GridControl();
            this.clsSolicitudDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Detalle_datos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoArticulo
            // 
            this.cmbTipoArticulo.Location = new System.Drawing.Point(419, 31);
            this.cmbTipoArticulo.Name = "cmbTipoArticulo";
            this.cmbTipoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoArticulo.Properties.Items.AddRange(new object[] {
            "Suministros de Oficina",
            "Suministros de Limpieza",
            "Mercadería",
            "Activos Fijos"});
            this.cmbTipoArticulo.Size = new System.Drawing.Size(116, 20);
            this.cmbTipoArticulo.TabIndex = 46;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(335, 34);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 45;
            this.labelControl8.Text = "Tipo de Articulo:";
            // 
            // btnEliminarArticulos
            // 
            this.btnEliminarArticulos.Location = new System.Drawing.Point(149, 96);
            this.btnEliminarArticulos.Name = "btnEliminarArticulos";
            this.btnEliminarArticulos.Size = new System.Drawing.Size(131, 23);
            this.btnEliminarArticulos.TabIndex = 44;
            this.btnEliminarArticulos.Text = "Quitar Articulo";
            this.btnEliminarArticulos.Click += new System.EventHandler(this.btnEliminarArticulos_Click);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(12, 96);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(131, 23);
            this.btnAgregarArticulo.TabIndex = 43;
            this.btnAgregarArticulo.Text = "Agregar Articulos";
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Location = new System.Drawing.Point(114, 65);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamento.Properties.Items.AddRange(new object[] {
            "Ventas",
            "Atencion al Cliente",
            "Contabilidad",
            "Recursos Humanos"});
            this.cmbDepartamento.Size = new System.Drawing.Size(145, 20);
            this.cmbDepartamento.TabIndex = 42;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(22, 68);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 13);
            this.labelControl9.TabIndex = 41;
            this.labelControl9.Text = "Departamento:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 23);
            this.btnBuscar.TabIndex = 39;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(419, 65);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Activo ",
            "Inactivo",
            "Procesado"});
            this.cmbEstado.Size = new System.Drawing.Size(116, 20);
            this.cmbEstado.TabIndex = 38;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(114, 35);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(145, 20);
            this.txtnumero.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(335, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Numero:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerar,
            this.btnNuevo,
            this.btnModificar,
            this.btnAnular,
            this.btnSalir,
            this.lblFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(587, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnGenerar
            // 
            this.btnGenerar.AccessibleName = "";
            this.btnGenerar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(69, 22);
            this.btnGenerar.Text = "Guardar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::forms.Properties.Resources.eliminar1;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
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
            // lblFecha
            // 
            this.lblFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblFecha.ForeColor = System.Drawing.Color.Red;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 22);
            this.lblFecha.Text = "lblFecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // dtgDetalle
            // 
            this.dtgDetalle.DataSource = this.clsSolicitudDetBindingSource;
            this.dtgDetalle.Location = new System.Drawing.Point(12, 138);
            this.dtgDetalle.MainView = this.Detalle_datos;
            this.dtgDetalle.Name = "dtgDetalle";
            this.dtgDetalle.Size = new System.Drawing.Size(563, 169);
            this.dtgDetalle.TabIndex = 47;
            this.dtgDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.Detalle_datos});
            this.dtgDetalle.Click += new System.EventHandler(this.dtgDetalle_Click);
            // 
            // clsSolicitudDetBindingSource
            // 
            this.clsSolicitudDetBindingSource.DataSource = typeof(clases.Compras.clsSolicitudDet);
            // 
            // Detalle_datos
            // 
            this.Detalle_datos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.collinea,
            this.colid_articulo,
            this.colArticulo,
            this.colCantidad,
            this.colId_empresa,
            this.colEmpresa});
            this.Detalle_datos.GridControl = this.dtgDetalle;
            this.Detalle_datos.Name = "Detalle_datos";
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            // 
            // collinea
            // 
            this.collinea.FieldName = "linea";
            this.collinea.Name = "collinea";
            this.collinea.Visible = true;
            this.collinea.VisibleIndex = 0;
            this.collinea.Width = 163;
            // 
            // colid_articulo
            // 
            this.colid_articulo.FieldName = "id_articulo";
            this.colid_articulo.Name = "colid_articulo";
            this.colid_articulo.Visible = true;
            this.colid_articulo.VisibleIndex = 1;
            this.colid_articulo.Width = 113;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 2;
            this.colArticulo.Width = 245;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 151;
            // 
            // colId_empresa
            // 
            this.colId_empresa.FieldName = "Id_empresa";
            this.colId_empresa.Name = "colId_empresa";
            this.colId_empresa.Visible = true;
            this.colId_empresa.VisibleIndex = 4;
            this.colId_empresa.Width = 151;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 5;
            this.colEmpresa.Width = 158;
            // 
            // frmSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 344);
            this.Controls.Add(this.dtgDetalle);
            this.Controls.Add(this.cmbTipoArticulo);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnEliminarArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSolicitud";
            this.Text = "Solicitud de Pedido";
            this.Load += new System.EventHandler(this.frmSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumero.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Detalle_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoArticulo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnEliminarArticulos;
        private DevExpress.XtraEditors.SimpleButton btnAgregarArticulo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDepartamento;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TextEdit txtnumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel lblFecha;
        private DevExpress.XtraGrid.GridControl dtgDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView Detalle_datos;
        private System.Windows.Forms.BindingSource clsSolicitudDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colId_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
    }
}