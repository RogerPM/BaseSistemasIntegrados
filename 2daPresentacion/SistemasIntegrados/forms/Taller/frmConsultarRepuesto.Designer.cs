namespace forms.Taller
{
    partial class frmConsultarRepuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarRepuesto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadMinima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUnidadMedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCombustible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdColor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdModelo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoMaterial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelec
            // 
            this.btnSelec.Image = ((System.Drawing.Image)(resources.GetObject("btnSelec.Image")));
            this.btnSelec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(87, 22);
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(214, 22);
            this.toolStripLabel1.Text = "                                                                     ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsArticuloBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 232);
            this.gridControl1.TabIndex = 11;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsArticuloBindingSource
            // 
            this.clsArticuloBindingSource.DataSource = typeof(clases.Taller.clsArticuloTaller);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colIdArticulo,
            this.colIdPersona,
            this.colDescripcion,
            this.colFechaProduccion,
            this.colCantidadMinima,
            this.colCantidadMaxima,
            this.colCantidadActual,
            this.colIdUnidadMedida,
            this.colIdGrupo,
            this.colIdChasis,
            this.colIdTipoMotor,
            this.colNroPlaca,
            this.colIdTipoCombustible,
            this.colIdColor,
            this.colIdMarca,
            this.colIdModelo,
            this.colIdTipoMaterial,
            this.colPrecioUnitario,
            this.colObservacion,
            this.colIdUsuario,
            this.colIdEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.Visible = true;
            this.colIdArticulo.VisibleIndex = 0;
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // colFechaProduccion
            // 
            this.colFechaProduccion.FieldName = "FechaProduccion";
            this.colFechaProduccion.Name = "colFechaProduccion";
            // 
            // colCantidadMinima
            // 
            this.colCantidadMinima.FieldName = "CantidadMinima";
            this.colCantidadMinima.Name = "colCantidadMinima";
            this.colCantidadMinima.Visible = true;
            this.colCantidadMinima.VisibleIndex = 2;
            // 
            // colCantidadMaxima
            // 
            this.colCantidadMaxima.FieldName = "CantidadMaxima";
            this.colCantidadMaxima.Name = "colCantidadMaxima";
            this.colCantidadMaxima.Visible = true;
            this.colCantidadMaxima.VisibleIndex = 3;
            // 
            // colCantidadActual
            // 
            this.colCantidadActual.FieldName = "CantidadActual";
            this.colCantidadActual.Name = "colCantidadActual";
            this.colCantidadActual.Visible = true;
            this.colCantidadActual.VisibleIndex = 4;
            // 
            // colIdUnidadMedida
            // 
            this.colIdUnidadMedida.FieldName = "IdUnidadMedida";
            this.colIdUnidadMedida.Name = "colIdUnidadMedida";
            this.colIdUnidadMedida.Visible = true;
            this.colIdUnidadMedida.VisibleIndex = 5;
            // 
            // colIdGrupo
            // 
            this.colIdGrupo.FieldName = "IdGrupo";
            this.colIdGrupo.Name = "colIdGrupo";
            // 
            // colIdChasis
            // 
            this.colIdChasis.FieldName = "IdChasis";
            this.colIdChasis.Name = "colIdChasis";
            // 
            // colIdTipoMotor
            // 
            this.colIdTipoMotor.FieldName = "IdTipoMotor";
            this.colIdTipoMotor.Name = "colIdTipoMotor";
            // 
            // colNroPlaca
            // 
            this.colNroPlaca.FieldName = "NroPlaca";
            this.colNroPlaca.Name = "colNroPlaca";
            // 
            // colIdTipoCombustible
            // 
            this.colIdTipoCombustible.FieldName = "IdTipoCombustible";
            this.colIdTipoCombustible.Name = "colIdTipoCombustible";
            // 
            // colIdColor
            // 
            this.colIdColor.FieldName = "IdColor";
            this.colIdColor.Name = "colIdColor";
            // 
            // colIdMarca
            // 
            this.colIdMarca.FieldName = "IdMarca";
            this.colIdMarca.Name = "colIdMarca";
            this.colIdMarca.Visible = true;
            this.colIdMarca.VisibleIndex = 6;
            // 
            // colIdModelo
            // 
            this.colIdModelo.FieldName = "IdModelo";
            this.colIdModelo.Name = "colIdModelo";
            // 
            // colIdTipoMaterial
            // 
            this.colIdTipoMaterial.FieldName = "IdTipoMaterial";
            this.colIdTipoMaterial.Name = "colIdTipoMaterial";
            this.colIdTipoMaterial.Visible = true;
            this.colIdTipoMaterial.VisibleIndex = 7;
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.FieldName = "PrecioUnitario";
            this.colPrecioUnitario.Name = "colPrecioUnitario";
            this.colPrecioUnitario.Visible = true;
            this.colPrecioUnitario.VisibleIndex = 8;
            // 
            // colObservacion
            // 
            this.colObservacion.FieldName = "Observacion";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.Visible = true;
            this.colObservacion.VisibleIndex = 9;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // frmConsultarRepuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 260);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarRepuesto";
            this.Text = "frmConsultarRepuesto";
            this.Load += new System.EventHandler(this.frmConsultarRepuesto_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsArticuloBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadMinima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadActual;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUnidadMedida;
        private DevExpress.XtraGrid.Columns.GridColumn colIdGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCombustible;
        private DevExpress.XtraGrid.Columns.GridColumn colIdColor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMarca;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModelo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colObservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}