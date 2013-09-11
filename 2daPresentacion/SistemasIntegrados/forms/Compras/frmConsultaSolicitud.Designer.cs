namespace forms.Compras
{
    partial class frmConsultaSolicitud
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtgSolDet = new DevExpress.XtraGrid.GridControl();
            this.clsSolicitudDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgDatosSolDet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_empresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.clsSolicitudBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clsSolicitudBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgSolCab = new DevExpress.XtraGrid.GridControl();
            this.clsSolicitudBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.SolCabDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Tipo_Articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipo_Artículo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Departamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosSolDet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolCabDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Solicitudes";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 216);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 37;
            this.labelControl1.Text = "Detalle";
            // 
            // dtgSolDet
            // 
            this.dtgSolDet.DataSource = this.clsSolicitudDetBindingSource;
            this.dtgSolDet.Location = new System.Drawing.Point(0, 241);
            this.dtgSolDet.MainView = this.dtgDatosSolDet;
            this.dtgSolDet.Name = "dtgSolDet";
            this.dtgSolDet.Size = new System.Drawing.Size(628, 175);
            this.dtgSolDet.TabIndex = 36;
            this.dtgSolDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgDatosSolDet});
            // 
            // clsSolicitudDetBindingSource
            // 
            this.clsSolicitudDetBindingSource.DataSource = typeof(clases.Compras.clsSolicitudDet);
            // 
            // dtgDatosSolDet
            // 
            this.dtgDatosSolDet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero1,
            this.collinea,
            this.colid_articulo,
            this.colArticulo,
            this.colCantidad,
            this.colId_empresa1,
            this.colEmpresa1});
            this.dtgDatosSolDet.GridControl = this.dtgSolDet;
            this.dtgDatosSolDet.Name = "dtgDatosSolDet";
            // 
            // colNumero1
            // 
            this.colNumero1.FieldName = "Numero";
            this.colNumero1.Name = "colNumero1";
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
            this.colid_articulo.Visible = true;
            this.colid_articulo.VisibleIndex = 1;
            // 
            // colArticulo
            // 
            this.colArticulo.FieldName = "Articulo";
            this.colArticulo.Name = "colArticulo";
            this.colArticulo.Visible = true;
            this.colArticulo.VisibleIndex = 2;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            // 
            // colId_empresa1
            // 
            this.colId_empresa1.FieldName = "Id_empresa";
            this.colId_empresa1.Name = "colId_empresa1";
            this.colId_empresa1.Visible = true;
            this.colId_empresa1.VisibleIndex = 4;
            // 
            // colEmpresa1
            // 
            this.colEmpresa1.FieldName = "Empresa";
            this.colEmpresa1.Name = "colEmpresa1";
            this.colEmpresa1.Visible = true;
            this.colEmpresa1.VisibleIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(635, 25);
            this.toolStrip1.TabIndex = 34;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnCargar
            // 
            this.btnCargar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnCargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(62, 22);
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
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
            // clsSolicitudBindingSource1
            // 
            this.clsSolicitudBindingSource1.DataSource = typeof(clases.Compras.clsSolicitud);
            // 
            // clsSolicitudBindingSource
            // 
            this.clsSolicitudBindingSource.DataSource = typeof(clases.Compras.clsSolicitud);
            // 
            // dtgSolCab
            // 
            this.dtgSolCab.DataSource = this.clsSolicitudBindingSource2;
            this.dtgSolCab.Location = new System.Drawing.Point(0, 35);
            this.dtgSolCab.MainView = this.SolCabDatos;
            this.dtgSolCab.Name = "dtgSolCab";
            this.dtgSolCab.Size = new System.Drawing.Size(635, 175);
            this.dtgSolCab.TabIndex = 39;
            this.dtgSolCab.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SolCabDatos});
            //this.dtgSolCab.Click += new System.EventHandler(this.dtgSolCab_Click_1);
            
            // 
            // clsSolicitudBindingSource2
            // 
            this.clsSolicitudBindingSource2.DataSource = typeof(clases.Compras.clsSolicitud);
            // 
            // SolCabDatos
            // 
            this.SolCabDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.colId_Empresa,
            this.colEmpresa,
            this.colId_Tipo_Articulo,
            this.colTipo_Artículo,
            this.colId_Usuario,
            this.colUsuario,
            this.colId_Departamento,
            this.colDepartamento,
            this.colFecha,
            this.colId_Estado,
            this.colEstado});
            this.SolCabDatos.GridControl = this.dtgSolCab;
            this.SolCabDatos.Name = "SolCabDatos";
            this.SolCabDatos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.SolCabDatos_RowClick);
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 0;
            // 
            // colId_Empresa
            // 
            this.colId_Empresa.FieldName = "Id_Empresa";
            this.colId_Empresa.Name = "colId_Empresa";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 1;
            // 
            // colId_Tipo_Articulo
            // 
            this.colId_Tipo_Articulo.FieldName = "Id_Tipo_Articulo";
            this.colId_Tipo_Articulo.Name = "colId_Tipo_Articulo";
            // 
            // colTipo_Artículo
            // 
            this.colTipo_Artículo.FieldName = "Tipo_Artículo";
            this.colTipo_Artículo.Name = "colTipo_Artículo";
            this.colTipo_Artículo.Visible = true;
            this.colTipo_Artículo.VisibleIndex = 2;
            // 
            // colId_Usuario
            // 
            this.colId_Usuario.FieldName = "Id_Usuario";
            this.colId_Usuario.Name = "colId_Usuario";
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 3;
            // 
            // colId_Departamento
            // 
            this.colId_Departamento.FieldName = "Id_Departamento";
            this.colId_Departamento.Name = "colId_Departamento";
            // 
            // colDepartamento
            // 
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 4;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 5;
            // 
            // colId_Estado
            // 
            this.colId_Estado.FieldName = "Id_Estado";
            this.colId_Estado.Name = "colId_Estado";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 6;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // frmConsultaSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 422);
            this.Controls.Add(this.dtgSolCab);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtgSolDet);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaSolicitud";
            this.Text = "frmConsultaSolicitud";
            this.Load += new System.EventHandler(this.frmConsultaSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosSolDet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSolCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsSolicitudBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolCabDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl dtgSolDet;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgDatosSolDet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.BindingSource clsSolicitudBindingSource;
        private System.Windows.Forms.BindingSource clsSolicitudBindingSource1;
        private DevExpress.XtraGrid.GridControl dtgSolCab;
        private DevExpress.XtraGrid.Views.Grid.GridView SolCabDatos;
        private System.Windows.Forms.BindingSource clsSolicitudBindingSource2;
        private System.Windows.Forms.BindingSource clsSolicitudDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero1;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colId_empresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Tipo_Articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipo_Artículo;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Departamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colId_Estado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}