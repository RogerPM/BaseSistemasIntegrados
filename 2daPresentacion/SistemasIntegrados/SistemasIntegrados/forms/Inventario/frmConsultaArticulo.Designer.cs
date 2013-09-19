namespace forms.Inventario
{
    partial class frmConsultaArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaArticulo));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.btn_Actualizar = new System.Windows.Forms.ToolStripButton();
            this.colCantActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantMinima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpresaArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcaArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeloArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUMed = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsArticuloBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(657, 429);
            this.gridControl1.TabIndex = 64;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsArticuloBindingSource
            // 
            this.clsArticuloBindingSource.DataSource = typeof(clases.Inventario.clsArticulo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdArt,
            this.colDescArt,
            this.colGrupoArt,
            this.colObservArt,
            this.colCantActual,
            this.colCantMaxima,
            this.colCantMinima,
            this.colEmpresaArt,
            this.colColorArt,
            this.colFCaducidad,
            this.colEstArt,
            this.colFProduccion,
            this.colModeloArt,
            this.colNPlaca,
            this.colSChasis,
            this.colSMotor,
            this.colTipoArt,
            this.colTipoChasis,
            this.colTipoComb,
            this.colMarcaArt,
            this.colTipoMat,
            this.colTipoMotor,
            this.colUMed});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colIdArt
            // 
            this.colIdArt.FieldName = "IdArt";
            this.colIdArt.Name = "colIdArt";
            this.colIdArt.Visible = true;
            this.colIdArt.VisibleIndex = 0;
            this.colIdArt.Width = 30;
            // 
            // colDescArt
            // 
            this.colDescArt.FieldName = "DescArt";
            this.colDescArt.Name = "colDescArt";
            this.colDescArt.Visible = true;
            this.colDescArt.VisibleIndex = 1;
            this.colDescArt.Width = 32;
            // 
            // colGrupoArt
            // 
            this.colGrupoArt.FieldName = "GrupoArt";
            this.colGrupoArt.Name = "colGrupoArt";
            this.colGrupoArt.Visible = true;
            this.colGrupoArt.VisibleIndex = 2;
            this.colGrupoArt.Width = 34;
            // 
            // colObservArt
            // 
            this.colObservArt.FieldName = "ObservArt";
            this.colObservArt.Name = "colObservArt";
            this.colObservArt.Visible = true;
            this.colObservArt.VisibleIndex = 3;
            this.colObservArt.Width = 68;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnNuevo,
            this.btnModificar,
            this.toolStripSeparator3,
            this.btnEliminar,
            this.toolStripTextBox2,
            this.btn_Actualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 65;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.toolStripTextBox2.Enabled = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(300, 25);
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Image = global::forms.Properties.Resources.Actualizar;
            this.btn_Actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(79, 22);
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // colCantActual
            // 
            this.colCantActual.FieldName = "CantActual";
            this.colCantActual.Name = "colCantActual";
            this.colCantActual.Visible = true;
            this.colCantActual.VisibleIndex = 4;
            this.colCantActual.Width = 32;
            // 
            // colCantMaxima
            // 
            this.colCantMaxima.FieldName = "CantMaxima";
            this.colCantMaxima.Name = "colCantMaxima";
            this.colCantMaxima.Visible = true;
            this.colCantMaxima.VisibleIndex = 5;
            this.colCantMaxima.Width = 32;
            // 
            // colCantMinima
            // 
            this.colCantMinima.FieldName = "CantMinima";
            this.colCantMinima.Name = "colCantMinima";
            this.colCantMinima.Visible = true;
            this.colCantMinima.VisibleIndex = 6;
            this.colCantMinima.Width = 44;
            // 
            // colColorArt
            // 
            this.colColorArt.FieldName = "ColorArt";
            this.colColorArt.Name = "colColorArt";
            this.colColorArt.Visible = true;
            this.colColorArt.VisibleIndex = 8;
            this.colColorArt.Width = 34;
            // 
            // colEmpresaArt
            // 
            this.colEmpresaArt.FieldName = "EmpresaArt";
            this.colEmpresaArt.Name = "colEmpresaArt";
            this.colEmpresaArt.Visible = true;
            this.colEmpresaArt.VisibleIndex = 7;
            this.colEmpresaArt.Width = 34;
            // 
            // colEstArt
            // 
            this.colEstArt.FieldName = "EstArt";
            this.colEstArt.Name = "colEstArt";
            this.colEstArt.Visible = true;
            this.colEstArt.VisibleIndex = 10;
            this.colEstArt.Width = 31;
            // 
            // colFCaducidad
            // 
            this.colFCaducidad.FieldName = "FCaducidad";
            this.colFCaducidad.Name = "colFCaducidad";
            this.colFCaducidad.Visible = true;
            this.colFCaducidad.VisibleIndex = 9;
            this.colFCaducidad.Width = 26;
            // 
            // colFProduccion
            // 
            this.colFProduccion.FieldName = "FProduccion";
            this.colFProduccion.Name = "colFProduccion";
            this.colFProduccion.Visible = true;
            this.colFProduccion.VisibleIndex = 11;
            this.colFProduccion.Width = 34;
            // 
            // colMarcaArt
            // 
            this.colMarcaArt.FieldName = "MarcaArt";
            this.colMarcaArt.Name = "colMarcaArt";
            this.colMarcaArt.Visible = true;
            this.colMarcaArt.VisibleIndex = 19;
            this.colMarcaArt.Width = 20;
            // 
            // colModeloArt
            // 
            this.colModeloArt.FieldName = "ModeloArt";
            this.colModeloArt.Name = "colModeloArt";
            this.colModeloArt.Visible = true;
            this.colModeloArt.VisibleIndex = 12;
            this.colModeloArt.Width = 20;
            // 
            // colNPlaca
            // 
            this.colNPlaca.FieldName = "NPlaca";
            this.colNPlaca.Name = "colNPlaca";
            this.colNPlaca.Visible = true;
            this.colNPlaca.VisibleIndex = 13;
            this.colNPlaca.Width = 20;
            // 
            // colSChasis
            // 
            this.colSChasis.FieldName = "SChasis";
            this.colSChasis.Name = "colSChasis";
            this.colSChasis.Visible = true;
            this.colSChasis.VisibleIndex = 14;
            this.colSChasis.Width = 20;
            // 
            // colSMotor
            // 
            this.colSMotor.FieldName = "SMotor";
            this.colSMotor.Name = "colSMotor";
            this.colSMotor.Visible = true;
            this.colSMotor.VisibleIndex = 15;
            this.colSMotor.Width = 20;
            // 
            // colTipoArt
            // 
            this.colTipoArt.FieldName = "TipoArt";
            this.colTipoArt.Name = "colTipoArt";
            this.colTipoArt.Visible = true;
            this.colTipoArt.VisibleIndex = 16;
            this.colTipoArt.Width = 20;
            // 
            // colTipoChasis
            // 
            this.colTipoChasis.FieldName = "TipoChasis";
            this.colTipoChasis.Name = "colTipoChasis";
            this.colTipoChasis.Visible = true;
            this.colTipoChasis.VisibleIndex = 17;
            this.colTipoChasis.Width = 20;
            // 
            // colTipoComb
            // 
            this.colTipoComb.FieldName = "TipoComb";
            this.colTipoComb.Name = "colTipoComb";
            this.colTipoComb.Visible = true;
            this.colTipoComb.VisibleIndex = 18;
            this.colTipoComb.Width = 20;
            // 
            // colTipoMat
            // 
            this.colTipoMat.FieldName = "TipoMat";
            this.colTipoMat.Name = "colTipoMat";
            this.colTipoMat.Visible = true;
            this.colTipoMat.VisibleIndex = 20;
            this.colTipoMat.Width = 20;
            // 
            // colTipoMotor
            // 
            this.colTipoMotor.FieldName = "TipoMotor";
            this.colTipoMotor.Name = "colTipoMotor";
            this.colTipoMotor.Visible = true;
            this.colTipoMotor.VisibleIndex = 21;
            this.colTipoMotor.Width = 20;
            // 
            // colUMed
            // 
            this.colUMed.FieldName = "UMed";
            this.colUMed.Name = "colUMed";
            this.colUMed.Visible = true;
            this.colUMed.VisibleIndex = 22;
            this.colUMed.Width = 20;
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 429);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmConsultaArticulo";
            this.Text = "frmConsultaArticulo";
            this.Load += new System.EventHandler(this.frmConsultaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource clsArticuloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripButton btn_Actualizar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArt;
        private DevExpress.XtraGrid.Columns.GridColumn colDescArt;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoArt;
        private DevExpress.XtraGrid.Columns.GridColumn colObservArt;
        private DevExpress.XtraGrid.Columns.GridColumn colCantActual;
        private DevExpress.XtraGrid.Columns.GridColumn colCantMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantMinima;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaArt;
        private DevExpress.XtraGrid.Columns.GridColumn colColorArt;
        private DevExpress.XtraGrid.Columns.GridColumn colFCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colEstArt;
        private DevExpress.XtraGrid.Columns.GridColumn colFProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloArt;
        private DevExpress.XtraGrid.Columns.GridColumn colNPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colSChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colSMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArt;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComb;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaArt;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMat;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colUMed;
    }
}