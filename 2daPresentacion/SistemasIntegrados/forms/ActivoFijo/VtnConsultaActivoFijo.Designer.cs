namespace forms.ActivoFijo
{
    partial class VtnConsultaActivoFijo
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
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gridConsultaActivoFijo = new DevExpress.XtraGrid.GridControl();
            this.clsActivoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArtBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltipo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsubgrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colarticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colproveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_EstadoProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_nominal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_residual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_actualserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha_Adquisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colano_vidautil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaActivoFijo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsActivoFijoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(607, 25);
            this.toolStrip1.TabIndex = 299;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(505, 22);
            this.tslEnBlanco.Text = "                                                                                 " +
                "                                                                                " +
                "     ";
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
            // gridConsultaActivoFijo
            // 
            this.gridConsultaActivoFijo.DataSource = this.clsActivoFijoBindingSource;
            this.gridConsultaActivoFijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaActivoFijo.Location = new System.Drawing.Point(0, 25);
            this.gridConsultaActivoFijo.MainView = this.gridView1;
            this.gridConsultaActivoFijo.Name = "gridConsultaActivoFijo";
            this.gridConsultaActivoFijo.Size = new System.Drawing.Size(607, 296);
            this.gridConsultaActivoFijo.TabIndex = 300;
            this.gridConsultaActivoFijo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsActivoFijoBindingSource
            // 
            this.clsActivoFijoBindingSource.DataSource = typeof(clases.ActivoFijo.clsActivoFijo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colCantidad,
            this.colEmpresa,
            this.coldepartamento,
            this.colresponsable,
            this.colusuario,
            this.colArtBodega,
            this.coltipo,
            this.colgrupo,
            this.colsubgrupo,
            this.colarticulo,
            this.colproveedor,
            this.col_EstadoProceso,
            this.coldescripcion,
            this.colvalor_nominal,
            this.colvalor_residual,
            this.colvalor_actualserie,
            this.colcodigo_barra,
            this.colFecha_Adquisicion,
            this.colano_vidautil,
            this.colestado,
            this.colfecha_registro});
            this.gridView1.GridControl = this.gridConsultaActivoFijo;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 62;
            // 
            // colCantidad
            // 
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 3;
            this.colCantidad.Width = 76;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 4;
            this.colEmpresa.Width = 69;
            // 
            // coldepartamento
            // 
            this.coldepartamento.FieldName = "departamento";
            this.coldepartamento.Name = "coldepartamento";
            // 
            // colresponsable
            // 
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colArtBodega
            // 
            this.colArtBodega.FieldName = "ArtBodega";
            this.colArtBodega.Name = "colArtBodega";
            // 
            // coltipo
            // 
            this.coltipo.FieldName = "tipo";
            this.coltipo.Name = "coltipo";
            // 
            // colgrupo
            // 
            this.colgrupo.FieldName = "grupo";
            this.colgrupo.Name = "colgrupo";
            // 
            // colsubgrupo
            // 
            this.colsubgrupo.FieldName = "subgrupo";
            this.colsubgrupo.Name = "colsubgrupo";
            // 
            // colarticulo
            // 
            this.colarticulo.FieldName = "articulo";
            this.colarticulo.Name = "colarticulo";
            // 
            // colproveedor
            // 
            this.colproveedor.FieldName = "proveedor";
            this.colproveedor.Name = "colproveedor";
            // 
            // col_EstadoProceso
            // 
            this.col_EstadoProceso.FieldName = "_EstadoProceso";
            this.col_EstadoProceso.Name = "col_EstadoProceso";
            this.col_EstadoProceso.Visible = true;
            this.col_EstadoProceso.VisibleIndex = 5;
            this.col_EstadoProceso.Width = 95;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            this.coldescripcion.Width = 184;
            // 
            // colvalor_nominal
            // 
            this.colvalor_nominal.FieldName = "valor_nominal";
            this.colvalor_nominal.Name = "colvalor_nominal";
            // 
            // colvalor_residual
            // 
            this.colvalor_residual.FieldName = "valor_residual";
            this.colvalor_residual.Name = "colvalor_residual";
            // 
            // colvalor_actualserie
            // 
            this.colvalor_actualserie.FieldName = "valor_actualserie";
            this.colvalor_actualserie.Name = "colvalor_actualserie";
            // 
            // colcodigo_barra
            // 
            this.colcodigo_barra.FieldName = "codigo_barra";
            this.colcodigo_barra.Name = "colcodigo_barra";
            this.colcodigo_barra.Width = 88;
            // 
            // colFecha_Adquisicion
            // 
            this.colFecha_Adquisicion.FieldName = "Fecha_Adquisicion";
            this.colFecha_Adquisicion.Name = "colFecha_Adquisicion";
            this.colFecha_Adquisicion.Visible = true;
            this.colFecha_Adquisicion.VisibleIndex = 1;
            this.colFecha_Adquisicion.Width = 113;
            // 
            // colano_vidautil
            // 
            this.colano_vidautil.FieldName = "ano_vidautil";
            this.colano_vidautil.Name = "colano_vidautil";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.Visible = true;
            this.colfecha_registro.VisibleIndex = 6;
            this.colfecha_registro.Width = 134;
            // 
            // VtnConsultaActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.ControlBox = false;
            this.Controls.Add(this.gridConsultaActivoFijo);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VtnConsultaActivoFijo";
            this.Text = "VtnConsultaActivoFijo";
            this.Load += new System.EventHandler(this.VtnConsultaActivoFijo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaActivoFijo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsActivoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl gridConsultaActivoFijo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsActivoFijoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn coldepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colArtBodega;
        private DevExpress.XtraGrid.Columns.GridColumn coltipo;
        private DevExpress.XtraGrid.Columns.GridColumn colgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colsubgrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colarticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colproveedor;
        private DevExpress.XtraGrid.Columns.GridColumn col_EstadoProceso;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_nominal;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_residual;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_actualserie;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha_Adquisicion;
        private DevExpress.XtraGrid.Columns.GridColumn colano_vidautil;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
    }
}