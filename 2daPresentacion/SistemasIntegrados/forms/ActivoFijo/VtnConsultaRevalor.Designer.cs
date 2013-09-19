
namespace forms.ActivoFijo
{
    partial class VtnConsultaRevalor
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
            this.GridConsultaRevaloriza = new DevExpress.XtraGrid.GridControl();
            this.clsRevalorizacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colusuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_idActivoFijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValoAdquisicion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorRevalorizado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvalorResidual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaRevaloriza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsRevalorizacionBindingSource)).BeginInit();
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
            // GridConsultaRevaloriza
            // 
            this.GridConsultaRevaloriza.DataSource = this.clsRevalorizacionBindingSource;
            this.GridConsultaRevaloriza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridConsultaRevaloriza.Location = new System.Drawing.Point(0, 25);
            this.GridConsultaRevaloriza.MainView = this.gridView1;
            this.GridConsultaRevaloriza.Name = "GridConsultaRevaloriza";
            this.GridConsultaRevaloriza.Size = new System.Drawing.Size(607, 296);
            this.GridConsultaRevaloriza.TabIndex = 301;
            this.GridConsultaRevaloriza.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsRevalorizacionBindingSource
            // 
            this.clsRevalorizacionBindingSource.DataSource = typeof(clases.ActivoFijo.clsRevalorizacion);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodigo,
            this.colusuario,
            this.colFecha,
            this.col_idActivoFijo,
            this.colValoAdquisicion,
            this.colvalorRevalorizado,
            this.colvalorResidual,
            this.colnomActivo});
            this.gridView1.GridControl = this.GridConsultaRevaloriza;
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
            this.colCodigo.Width = 104;
            // 
            // colusuario
            // 
            this.colusuario.FieldName = "usuario";
            this.colusuario.Name = "colusuario";
            // 
            // colFecha
            // 
            this.colFecha.FieldName = "Fecha";
            this.colFecha.Name = "colFecha";
            this.colFecha.Visible = true;
            this.colFecha.VisibleIndex = 1;
            this.colFecha.Width = 81;
            // 
            // col_idActivoFijo
            // 
            this.col_idActivoFijo.FieldName = "_idActivoFijo";
            this.col_idActivoFijo.Name = "col_idActivoFijo";
            // 
            // colValoAdquisicion
            // 
            this.colValoAdquisicion.FieldName = "ValoAdquisicion";
            this.colValoAdquisicion.Name = "colValoAdquisicion";
            this.colValoAdquisicion.Visible = true;
            this.colValoAdquisicion.VisibleIndex = 3;
            this.colValoAdquisicion.Width = 95;
            // 
            // colvalorRevalorizado
            // 
            this.colvalorRevalorizado.FieldName = "valorRevalorizado";
            this.colvalorRevalorizado.Name = "colvalorRevalorizado";
            this.colvalorRevalorizado.Visible = true;
            this.colvalorRevalorizado.VisibleIndex = 4;
            this.colvalorRevalorizado.Width = 110;
            // 
            // colvalorResidual
            // 
            this.colvalorResidual.FieldName = "valorResidual";
            this.colvalorResidual.Name = "colvalorResidual";
            this.colvalorResidual.Visible = true;
            this.colvalorResidual.VisibleIndex = 5;
            this.colvalorResidual.Width = 125;
            // 
            // colnomActivo
            // 
            this.colnomActivo.FieldName = "nomActivo";
            this.colnomActivo.Name = "colnomActivo";
            this.colnomActivo.Visible = true;
            this.colnomActivo.VisibleIndex = 2;
            this.colnomActivo.Width = 74;
            // 
            // VtnConsultaRevalor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 321);
            this.ControlBox = false;
            this.Controls.Add(this.GridConsultaRevaloriza);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VtnConsultaRevalor";
            this.Text = "VtnConsultaRevalor";
            this.Load += new System.EventHandler(this.VtnConsultaRevalor_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsultaRevaloriza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsRevalorizacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraGrid.GridControl GridConsultaRevaloriza;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colusuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFecha;
        private DevExpress.XtraGrid.Columns.GridColumn col_idActivoFijo;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorRevalorizado;
        private DevExpress.XtraGrid.Columns.GridColumn colvalorResidual;
        private DevExpress.XtraGrid.Columns.GridColumn colnomActivo;
        private DevExpress.XtraGrid.Columns.GridColumn colValoAdquisicion;
        private System.Windows.Forms.BindingSource clsRevalorizacionBindingSource;
    }
}