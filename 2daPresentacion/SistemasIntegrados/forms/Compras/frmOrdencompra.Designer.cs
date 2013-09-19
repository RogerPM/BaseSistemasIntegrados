namespace forms.Compras
{
    partial class frmOrdencompra
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
            this.dtgOrdenDet = new DevExpress.XtraGrid.GridControl();
            this.clsOrdenCompraDetalleVistaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DatosOrdenDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnConsultarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.txtProveedor = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraDetalleVistaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOrdenDet
            // 
            this.dtgOrdenDet.DataSource = this.clsOrdenCompraDetalleVistaBindingSource;
            this.dtgOrdenDet.Location = new System.Drawing.Point(11, 108);
            this.dtgOrdenDet.MainView = this.DatosOrdenDet;
            this.dtgOrdenDet.Name = "dtgOrdenDet";
            this.dtgOrdenDet.Size = new System.Drawing.Size(609, 174);
            this.dtgOrdenDet.TabIndex = 105;
            this.dtgOrdenDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosOrdenDet});
            // 
            // clsOrdenCompraDetalleVistaBindingSource
            // 
            this.clsOrdenCompraDetalleVistaBindingSource.DataSource = typeof(clases.Compras.clsOrdenCompraDetalle_Vista);
            // 
            // DatosOrdenDet
            // 
            this.DatosOrdenDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.collinea,
            this.colid_articulo,
            this.colArticulo,
            this.colCantidad,
            this.colPrecio,
            this.colId_empresa,
            this.colEmpresa});
            this.DatosOrdenDet.GridControl = this.dtgOrdenDet;
            this.DatosOrdenDet.Name = "DatosOrdenDet";
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
            // 
            // colid_articulo
            // 
            this.colid_articulo.FieldName = "id_articulo";
            this.colid_articulo.Name = "colid_articulo";
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 1;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 3;
            // 
            // colId_empresa
            // 
            this.colId_empresa.FieldName = "Id_empresa";
            this.colId_empresa.Name = "colId_empresa";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 4;
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(225, 34);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarPedido.TabIndex = 104;
            this.btnConsultarPedido.Text = "...";
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(497, 35);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Procesado"});
            this.cmbEstado.Size = new System.Drawing.Size(123, 20);
            this.cmbEstado.TabIndex = 101;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(74, 35);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 100;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(428, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "Numero:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnNuevo,
            this.btnSalir,
            this.lblFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "";
            this.btnGuardar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
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
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(428, 66);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(54, 13);
            this.lblProveedor.TabIndex = 106;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(497, 63);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(123, 20);
            this.txtProveedor.TabIndex = 107;
            // 
            // frmOrdencompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 306);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.dtgOrdenDet);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOrdencompra";
            this.Text = "frmOrdencompra";
            this.Load += new System.EventHandler(this.frmOrdencompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrdenDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsOrdenCompraDetalleVistaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosOrdenDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgOrdenDet;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosOrdenDet;
        private DevExpress.XtraEditors.SimpleButton btnConsultarPedido;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel lblFecha;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private DevExpress.XtraEditors.TextEdit txtProveedor;
        private System.Windows.Forms.BindingSource clsOrdenCompraDetalleVistaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colId_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
    }
}