
namespace forms.ActivoFijo
{
    partial class VtnConsultaTipoBaja
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
            this.gridConsultaTipoBaja = new DevExpress.XtraGrid.GridControl();
            this.clsActivoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_nominal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_residual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalor_actualserie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_barra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_deprecioacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colano_vidautil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_registro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTipoBaja)).BeginInit();
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
            // gridConsultaTipoBaja
            // 
            this.gridConsultaTipoBaja.DataSource = this.clsActivoFijoBindingSource;
            this.gridConsultaTipoBaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsultaTipoBaja.Location = new System.Drawing.Point(0, 25);
            this.gridConsultaTipoBaja.MainView = this.gridView1;
            this.gridConsultaTipoBaja.Name = "gridConsultaTipoBaja";
            this.gridConsultaTipoBaja.Size = new System.Drawing.Size(607, 296);
            this.gridConsultaTipoBaja.TabIndex = 0;
            this.gridConsultaTipoBaja.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.coldescripcion,
            this.colvalor_nominal,
            this.colvalor_residual,
            this.colvalor_actualserie,
            this.colcodigo_barra,
            this.colfecha_deprecioacion,
            this.colano_vidautil,
            this.colestado,
            this.colfecha_registro});
            this.gridView1.GridControl = this.gridConsultaTipoBaja;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colfecha_registro, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 105;
            // 
            // colEmpresa
            // 
            this.colEmpresa.FieldName = "Empresa";
            this.colEmpresa.Name = "colEmpresa";
            this.colEmpresa.Visible = true;
            this.colEmpresa.VisibleIndex = 3;
            this.colEmpresa.Width = 168;
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
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 208;
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
            // 
            // colfecha_deprecioacion
            // 
            this.colfecha_deprecioacion.FieldName = "fecha_deprecioacion";
            this.colfecha_deprecioacion.Name = "colfecha_deprecioacion";
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
            this.colestado.Width = 50;
            // 
            // colfecha_registro
            // 
            this.colfecha_registro.FieldName = "fecha_registro";
            this.colfecha_registro.Name = "colfecha_registro";
            this.colfecha_registro.Visible = true;
            this.colfecha_registro.VisibleIndex = 2;
            this.colfecha_registro.Width = 252;
            // 
            // VtnConsultaTipoBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.Controls.Add(this.gridConsultaTipoBaja);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VtnConsultaTipoBaja";
            this.Text = "VtnConsultaTipoBaja";
            this.Load += new System.EventHandler(this.VtnConsultaTipoBaja_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaTipoBaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsActivoFijoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl gridConsultaTipoBaja;
        private System.Windows.Forms.BindingSource clsActivoFijoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
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
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_nominal;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_residual;
        private DevExpress.XtraGrid.Columns.GridColumn colvalor_actualserie;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_barra;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_deprecioacion;
        private DevExpress.XtraGrid.Columns.GridColumn colano_vidautil;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_registro;
    }
}