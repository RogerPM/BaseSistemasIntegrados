namespace forms.Compras
{
    partial class frmConsultaProveedor
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
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dtgProveedor = new DevExpress.XtraGrid.GridControl();
            this.clsProveedorDescripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ProveedorDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombrerazonsocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazonsocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorDescripcionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(840, 25);
            this.toolStrip1.TabIndex = 78;
            this.toolStrip1.Text = "Generar Solicitud";
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
            // dtgProveedor
            // 
            this.dtgProveedor.DataSource = this.clsProveedorDescripcionBindingSource;
            this.dtgProveedor.Location = new System.Drawing.Point(0, 23);
            this.dtgProveedor.MainView = this.ProveedorDatos;
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.Size = new System.Drawing.Size(840, 324);
            this.dtgProveedor.TabIndex = 79;
            this.dtgProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ProveedorDatos});
            this.dtgProveedor.Click += new System.EventHandler(this.dtgProveedor_Click_1);
            // 
            // clsProveedorDescripcionBindingSource
            // 
            this.clsProveedorDescripcionBindingSource.DataSource = typeof(clases.Compras.clsProveedorDescripcion);
            // 
            // ProveedorDatos
            // 
            this.ProveedorDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProveedor,
            this.colnombrerazonsocial,
            this.colidentificacion,
            this.colrazonsocial,
            this.colidEmpresa,
            this.coldescripcion,
            this.colidTipoArticulo,
            this.colEstado});
            this.ProveedorDatos.GridControl = this.dtgProveedor;
            this.ProveedorDatos.Name = "ProveedorDatos";
            // 
            // colidProveedor
            // 
            this.colidProveedor.FieldName = "idProveedor";
            this.colidProveedor.Name = "colidProveedor";
            this.colidProveedor.Visible = true;
            this.colidProveedor.VisibleIndex = 0;
            // 
            // colnombrerazonsocial
            // 
            this.colnombrerazonsocial.FieldName = "nombrerazonsocial";
            this.colnombrerazonsocial.Name = "colnombrerazonsocial";
            this.colnombrerazonsocial.Visible = true;
            this.colnombrerazonsocial.VisibleIndex = 1;
            // 
            // colidentificacion
            // 
            this.colidentificacion.FieldName = "identificacion";
            this.colidentificacion.Name = "colidentificacion";
            // 
            // colrazonsocial
            // 
            this.colrazonsocial.FieldName = "razonsocial";
            this.colrazonsocial.Name = "colrazonsocial";
            this.colrazonsocial.Visible = true;
            this.colrazonsocial.VisibleIndex = 2;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 3;
            // 
            // colidTipoArticulo
            // 
            this.colidTipoArticulo.FieldName = "idTipoArticulo";
            this.colidTipoArticulo.Name = "colidTipoArticulo";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 4;
            // 
            // frmConsultaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(840, 345);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaProveedor";
            this.Text = "frmConsultaProveedor";
            this.Load += new System.EventHandler(this.frmConsultaProveedor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsProveedorDescripcionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl dtgProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView ProveedorDatos;
        private System.Windows.Forms.BindingSource clsProveedorDescripcionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colnombrerazonsocial;
        private DevExpress.XtraGrid.Columns.GridColumn colidentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colrazonsocial;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;

    }
}