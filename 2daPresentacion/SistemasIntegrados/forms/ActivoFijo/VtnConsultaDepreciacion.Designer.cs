namespace forms.ActivoFijo
{
    partial class VtnConsultaDepreciacion
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
            this.GridDepreciacion = new DevExpress.XtraGrid.GridControl();
            this.clsDepreciacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodsecuenciaCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodsecuenciaDet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestadoProceso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colobservacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidCabecera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colperiodo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorNominal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorActuals = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepreciacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepreciacionBindingSource)).BeginInit();
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
            this.toolStrip1.TabIndex = 300;
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
            // GridDepreciacion
            // 
            this.GridDepreciacion.DataSource = this.clsDepreciacionBindingSource;
            this.GridDepreciacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDepreciacion.Location = new System.Drawing.Point(0, 25);
            this.GridDepreciacion.MainView = this.gridView1;
            this.GridDepreciacion.Name = "GridDepreciacion";
            this.GridDepreciacion.Size = new System.Drawing.Size(607, 296);
            this.GridDepreciacion.TabIndex = 301;
            this.GridDepreciacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsDepreciacionBindingSource
            // 
            this.clsDepreciacionBindingSource.DataSource = typeof(clases.ActivoFijo.clsDepreciacion);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodsecuenciaCab,
            this.colCodsecuenciaDet,
            this.colempresa,
            this.colusuario,
            this.colestadoProceso,
            this.colFechaRegistro,
            this.colFechaModificacion,
            this.colobservacion,
            this.colidCabecera,
            this.colActivoFijo,
            this.colperiodo,
            this.colvalorNominal,
            this.colvalorActuals});
            this.gridView1.GridControl = this.GridDepreciacion;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colCodsecuenciaCab
            // 
            this.colCodsecuenciaCab.FieldName = "CodsecuenciaCab";
            this.colCodsecuenciaCab.Name = "colCodsecuenciaCab";
            this.colCodsecuenciaCab.Visible = true;
            this.colCodsecuenciaCab.VisibleIndex = 0;
            // 
            // colCodsecuenciaDet
            // 
            this.colCodsecuenciaDet.FieldName = "CodsecuenciaDet";
            this.colCodsecuenciaDet.Name = "colCodsecuenciaDet";
            this.colCodsecuenciaDet.Visible = true;
            this.colCodsecuenciaDet.VisibleIndex = 1;
            // 
            // colempresa
            // 
            this.colempresa.FieldName = "empresa";
            this.colempresa.Name = "colempresa";
            this.colempresa.Visible = true;
            this.colempresa.VisibleIndex = 2;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            this.colusuario.Visible = true;
            this.colusuario.VisibleIndex = 3;
            // 
            // colestadoProceso
            // 
            this.colestadoProceso.FieldName = "estadoProceso";
            this.colestadoProceso.Name = "colestadoProceso";
            this.colestadoProceso.Visible = true;
            this.colestadoProceso.VisibleIndex = 4;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 5;
            // 
            // colFechaModificacion
            // 
            this.colFechaModificacion.FieldName = "FechaModificacion";
            this.colFechaModificacion.Name = "colFechaModificacion";
            this.colFechaModificacion.Visible = true;
            this.colFechaModificacion.VisibleIndex = 6;
            // 
            // colobservacion
            // 
            this.colobservacion.FieldName = "observacion";
            this.colobservacion.Name = "colobservacion";
            this.colobservacion.Visible = true;
            this.colobservacion.VisibleIndex = 7;
            // 
            // colidCabecera
            // 
            this.colidCabecera.FieldName = "idCabecera";
            this.colidCabecera.Name = "colidCabecera";
            this.colidCabecera.Visible = true;
            this.colidCabecera.VisibleIndex = 8;
            // 
            // colActivoFijo
            // 
            this.colActivoFijo.FieldName = "ActivoFijo";
            this.colActivoFijo.Name = "colActivoFijo";
            this.colActivoFijo.Visible = true;
            this.colActivoFijo.VisibleIndex = 9;
            // 
            // colperiodo
            // 
            this.colperiodo.FieldName = "periodo";
            this.colperiodo.Name = "colperiodo";
            this.colperiodo.Visible = true;
            this.colperiodo.VisibleIndex = 10;
            // 
            // colvalorNominal
            // 
            this.colvalorNominal.FieldName = "valorNominal";
            this.colvalorNominal.Name = "colvalorNominal";
            this.colvalorNominal.Visible = true;
            this.colvalorNominal.VisibleIndex = 11;
            // 
            // colvalorActuals
            // 
            this.colvalorActuals.FieldName = "valorActuals";
            this.colvalorActuals.Name = "colvalorActuals";
            this.colvalorActuals.Visible = true;
            this.colvalorActuals.VisibleIndex = 12;
            // 
            // VtnConsultaDepreciacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.Controls.Add(this.GridDepreciacion);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VtnConsultaDepreciacion";
            this.Text = "VtnConsultaDepreciacion";
            this.Load += new System.EventHandler(this.VtnConsultaDepreciacion_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDepreciacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepreciacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl GridDepreciacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsDepreciacionBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodsecuenciaCab;
        private DevExpress.XtraGrid.Columns.GridColumn colCodsecuenciaDet;
        private DevExpress.XtraGrid.Columns.GridColumn colempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colestadoProceso;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colobservacion;
        private DevExpress.XtraGrid.Columns.GridColumn colidCabecera;
        private DevExpress.XtraGrid.Columns.GridColumn colActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colperiodo;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorNominal;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorActuals;
    }
}