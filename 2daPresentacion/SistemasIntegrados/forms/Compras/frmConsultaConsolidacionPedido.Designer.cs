namespace forms.Compras
{
    partial class frmConsultaConsolidacionPedido
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
            this.dtgDetallePedido = new DevExpress.XtraGrid.GridControl();
            this.datosDetallePedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colid_articulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId_empresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtgCabeceraPedido = new DevExpress.XtraGrid.GridControl();
            this.datosCabPedido = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDetallePedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCabeceraPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCabPedido)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgDetallePedido
            // 
            this.dtgDetallePedido.Location = new System.Drawing.Point(12, 238);
            this.dtgDetallePedido.MainView = this.datosDetallePedido;
            this.dtgDetallePedido.Name = "dtgDetallePedido";
            this.dtgDetallePedido.Size = new System.Drawing.Size(575, 177);
            this.dtgDetallePedido.TabIndex = 36;
            this.dtgDetallePedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.datosDetallePedido});
            // 
            // datosDetallePedido
            // 
            this.datosDetallePedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero1,
            this.collinea,
            this.colid_articulo,
            this.colArticulo,
            this.colCantidad,
            this.colId_empresa,
            this.colEmpresa1});
            this.datosDetallePedido.GridControl = this.dtgDetallePedido;
            this.datosDetallePedido.Name = "datosDetallePedido";
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
            // colId_empresa
            // 
            this.colId_empresa.FieldName = "Id_empresa";
            this.colId_empresa.Name = "colId_empresa";
            // 
            // colEmpresa1
            // 
            this.colEmpresa1.FieldName = "Empresa";
            this.colEmpresa1.Name = "colEmpresa1";
            this.colEmpresa1.Visible = true;
            this.colEmpresa1.VisibleIndex = 3;
            // 
            // dtgCabeceraPedido
            // 
            this.dtgCabeceraPedido.Location = new System.Drawing.Point(12, 40);
            this.dtgCabeceraPedido.MainView = this.datosCabPedido;
            this.dtgCabeceraPedido.Name = "dtgCabeceraPedido";
            this.dtgCabeceraPedido.Size = new System.Drawing.Size(575, 175);
            this.dtgCabeceraPedido.TabIndex = 35;
            this.dtgCabeceraPedido.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.datosCabPedido});
            this.dtgCabeceraPedido.Click += new System.EventHandler(this.dtgCabeceraPedido_Click_1);
            // 
            // datosCabPedido
            // 
            this.datosCabPedido.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumero,
            this.colidTipoArticulo,
            this.colTipoArticulo,
            this.colFecha,
            this.colidEmpresa,
            this.colEmpresa,
            this.colidUsuario,
            this.colUsuario,
            this.colidEstado,
            this.colEstado});
            this.datosCabPedido.GridControl = this.dtgCabeceraPedido;
            this.datosCabPedido.Name = "datosCabPedido";
            // 
            // colNumero
            // 
            this.colNumero.FieldName = "Numero";
            this.colNumero.Name = "colNumero";
            this.colNumero.Visible = true;
            this.colNumero.VisibleIndex = 0;
            // 
            // colidTipoArticulo
            // 
            this.colidTipoArticulo.FieldName = "idTipoArticulo";
            this.colidTipoArticulo.Name = "colidTipoArticulo";
            // 
            // colTipoArticulo
            // 
            this.colTipoArticulo.FieldName = "TipoArticulo";
            this.colTipoArticulo.Name = "colTipoArticulo";
            this.colTipoArticulo.Visible = true;
            this.colTipoArticulo.VisibleIndex = 1;
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 2;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 3;
            // 
            // colidUsuario
            // 
            this.colidUsuario.FieldName = "idUsuario";
            this.colidUsuario.Name = "colidUsuario";
            // 
            // colUsuario
            // 
            this.colUsuario.FieldName = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.Visible = true;
            this.colUsuario.VisibleIndex = 4;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            // 
            // colEstado
            // 
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(602, 25);
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
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
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
            // frmConsultaConsolidacionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 424);
            this.Controls.Add(this.dtgDetallePedido);
            this.Controls.Add(this.dtgCabeceraPedido);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaConsolidacionPedido";
            this.Text = "frmConsultaConsolidacionPedido";
            this.Load += new System.EventHandler(this.frmConsultaConsolidacionPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosDetallePedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCabeceraPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosCabPedido)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgDetallePedido;
        private DevExpress.XtraGrid.Views.Grid.GridView datosDetallePedido;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero1;
        private DevExpress.XtraGrid.Columns.GridColumn collinea;
        private DevExpress.XtraGrid.Columns.GridColumn colid_articulo;
        private DevExpress.XtraGrid.Columns.GridColumn colArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colId_empresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa1;
        private DevExpress.XtraGrid.GridControl dtgCabeceraPedido;
        private DevExpress.XtraGrid.Views.Grid.GridView datosCabPedido;
        private DevExpress.XtraGrid.Columns.GridColumn colNumero;
        private DevExpress.XtraGrid.Columns.GridColumn colidTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colidUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargar;
        private System.Windows.Forms.ToolStripButton btnSalir;
    }
}