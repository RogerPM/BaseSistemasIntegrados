
namespace forms.ActivoFijo
{
    partial class VtnCodigoBarra
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
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.GridConsultaCodigoBarra = new DevExpress.XtraGrid.GridControl();
            this.clsCodigoBarraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colancho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colalto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_seteoDesde = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha_seteoHasta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmargen_superior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmargen_inferior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsentido_Lectura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdformato = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCodigoBarraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(621, 25);
            this.toolStrip1.TabIndex = 125;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            // 
            // GridConsultaCodigoBarra
            // 
            this.GridConsultaCodigoBarra.DataSource = this.clsCodigoBarraBindingSource;
            this.GridConsultaCodigoBarra.Location = new System.Drawing.Point(0, 28);
            this.GridConsultaCodigoBarra.MainView = this.gridView1;
            this.GridConsultaCodigoBarra.Name = "GridConsultaCodigoBarra";
            this.GridConsultaCodigoBarra.Size = new System.Drawing.Size(621, 280);
            this.GridConsultaCodigoBarra.TabIndex = 126;
            this.GridConsultaCodigoBarra.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsCodigoBarraBindingSource
            // 
            this.clsCodigoBarraBindingSource.DataSource = typeof(clases.ActivoFijo.clsCodigoBarra);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colancho,
            this.colalto,
            this.colfecha,
            this.colfecha_seteoDesde,
            this.colfecha_seteoHasta,
            this.colmargen_superior,
            this.colmargen_inferior,
            this.colsentido_Lectura,
            this.colIdformato,
            this.colIdImagen});
            this.gridView1.GridControl = this.GridConsultaCodigoBarra;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdImagen, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 0;
            this.colCodigo.Width = 55;
            // 
            // colancho
            // 
            this.colancho.FieldName = "ancho";
            this.colancho.Name = "colancho";
            this.colancho.Visible = true;
            this.colancho.VisibleIndex = 1;
            this.colancho.Width = 66;
            // 
            // colalto
            // 
            this.colalto.FieldName = "alto";
            this.colalto.Name = "colalto";
            this.colalto.Visible = true;
            this.colalto.VisibleIndex = 2;
            this.colalto.Width = 58;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 3;
            this.colfecha.Width = 81;
            // 
            // colfecha_seteoDesde
            // 
            this.colfecha_seteoDesde.FieldName = "fecha_seteoDesde";
            this.colfecha_seteoDesde.Name = "colfecha_seteoDesde";
            // 
            // colfecha_seteoHasta
            // 
            this.colfecha_seteoHasta.FieldName = "fecha_seteoHasta";
            this.colfecha_seteoHasta.Name = "colfecha_seteoHasta";
            // 
            // colmargen_superior
            // 
            this.colmargen_superior.FieldName = "margen_superior";
            this.colmargen_superior.Name = "colmargen_superior";
            this.colmargen_superior.Visible = true;
            this.colmargen_superior.VisibleIndex = 4;
            this.colmargen_superior.Width = 81;
            // 
            // colmargen_inferior
            // 
            this.colmargen_inferior.FieldName = "margen_inferior";
            this.colmargen_inferior.Name = "colmargen_inferior";
            this.colmargen_inferior.Visible = true;
            this.colmargen_inferior.VisibleIndex = 5;
            this.colmargen_inferior.Width = 90;
            // 
            // colsentido_Lectura
            // 
            this.colsentido_Lectura.FieldName = "sentido_Lectura";
            this.colsentido_Lectura.Name = "colsentido_Lectura";
            this.colsentido_Lectura.Visible = true;
            this.colsentido_Lectura.VisibleIndex = 7;
            this.colsentido_Lectura.Width = 87;
            // 
            // colIdformato
            // 
            this.colIdformato.FieldName = "Idformato";
            this.colIdformato.Name = "colIdformato";
            this.colIdformato.Visible = true;
            this.colIdformato.VisibleIndex = 6;
            this.colIdformato.Width = 85;
            // 
            // colIdImagen
            // 
            this.colIdImagen.FieldName = "IdImagen";
            this.colIdImagen.Name = "colIdImagen";
            // 
            // VtnCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 307);
            this.Controls.Add(this.GridConsultaCodigoBarra);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VtnCodigoBarra";
            this.Text = "VtnCodigoBarra";
            this.Load += new System.EventHandler(this.VtnCodigoBarra_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCodigoBarraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl GridConsultaCodigoBarra;
        private System.Windows.Forms.BindingSource clsCodigoBarraBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colancho;
        private DevExpress.XtraGrid.Columns.GridColumn colalto;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_seteoDesde;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha_seteoHasta;
        private DevExpress.XtraGrid.Columns.GridColumn colmargen_superior;
        private DevExpress.XtraGrid.Columns.GridColumn colmargen_inferior;
        private DevExpress.XtraGrid.Columns.GridColumn colsentido_Lectura;
        private DevExpress.XtraGrid.Columns.GridColumn colIdformato;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImagen;
    }
}