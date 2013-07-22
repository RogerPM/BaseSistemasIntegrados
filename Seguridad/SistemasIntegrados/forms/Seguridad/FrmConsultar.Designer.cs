namespace forms.Seguridad
{
    partial class FrmConsultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colrazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruc = new DevExpress.XtraGrid.Columns.GridColumn();
          //  this.colidTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
          //  this.colidImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collogo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfondo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaInicioSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsitioWeb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(690, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelec
            // 
            this.btnSelec.Image = ((System.Drawing.Image)(resources.GetObject("btnSelec.Image")));
            this.btnSelec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(70, 22);
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(143, 22);
            this.toolStripLabel1.Text = "                                                                     ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsEmpresaBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(690, 246);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpresa,
            this.colrazonSocial,
            this.colnombreComercial,
            this.colruc,
            //this.colidTelefono,
            this.coldireccion,
            //this.colidImagen,
            this.collogo,
            this.colfondo,
            this.colfechaInicioSistema,
            this.colcorreo,
            this.colsitioWeb,
            this.coldescripcion,
            this.colidEstado});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(clases.Class1);
            // 
            // clsEmpresaBindingSource
            // 
            this.clsEmpresaBindingSource.DataSource = typeof(clases.Seguridad.clsEmpresa);
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            this.colidEmpresa.Visible = true;
            this.colidEmpresa.VisibleIndex = 0;
            // 
            // colrazonSocial
            // 
            this.colrazonSocial.FieldName = "razonSocial";
            this.colrazonSocial.Name = "colrazonSocial";
            this.colrazonSocial.Visible = true;
            this.colrazonSocial.VisibleIndex = 1;
            // 
            // colnombreComercial
            // 
            this.colnombreComercial.FieldName = "nombreComercial";
            this.colnombreComercial.Name = "colnombreComercial";
            this.colnombreComercial.Visible = true;
            this.colnombreComercial.VisibleIndex = 2;
            // 
            // colruc
            // 
            this.colruc.FieldName = "ruc";
            this.colruc.Name = "colruc";
            this.colruc.Visible = true;
            this.colruc.VisibleIndex = 3;
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 4;
            // 
            // collogo
            // 
            this.collogo.FieldName = "logo";
            this.collogo.Name = "collogo";
            this.collogo.Visible = true;
            this.collogo.VisibleIndex = 5;
            // 
            // colfondo
            // 
            this.colfondo.FieldName = "fondo";
            this.colfondo.Name = "colfondo";
            this.colfondo.Visible = true;
            this.colfondo.VisibleIndex = 7;
            // 
            // colfechaInicioSistema
            // 
            this.colfechaInicioSistema.FieldName = "fechaInicioSistema";
            this.colfechaInicioSistema.Name = "colfechaInicioSistema";
            this.colfechaInicioSistema.Visible = true;
            this.colfechaInicioSistema.VisibleIndex = 8;
            // 
            // colcorreo
            // 
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 9;
            // 
            // colsitioWeb
            // 
            this.colsitioWeb.FieldName = "sitioWeb";
            this.colsitioWeb.Name = "colsitioWeb";
            this.colsitioWeb.Visible = true;
            this.colsitioWeb.VisibleIndex = 10;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 11;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 12;
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 271);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource class1BindingSource;
        private System.Windows.Forms.BindingSource clsEmpresaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colrazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colruc;
        private DevExpress.XtraGrid.Columns.GridColumn colidTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colidImagen;
        private DevExpress.XtraGrid.Columns.GridColumn collogo;
        private DevExpress.XtraGrid.Columns.GridColumn colfondo;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaInicioSistema;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colsitioWeb;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
    }
}