namespace forms.Compras
{
    partial class frmConsultaEmpresa
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
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dtgEmpresa = new DevExpress.XtraGrid.GridControl();
            this.clsEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpresaDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colruc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcorreo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsector = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 79;
            this.toolStrip1.Text = "Generar Solicitud";

            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 22);
            this.btnSalir.Text = "Salir";
            // 
            // dtgEmpresa
            // 
            this.dtgEmpresa.DataSource = this.clsEmpresaBindingSource;
            this.dtgEmpresa.Location = new System.Drawing.Point(12, 38);
            this.dtgEmpresa.MainView = this.EmpresaDatos;
            this.dtgEmpresa.Name = "dtgEmpresa";
            this.dtgEmpresa.Size = new System.Drawing.Size(648, 200);
            this.dtgEmpresa.TabIndex = 80;
            this.dtgEmpresa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EmpresaDatos});
            this.dtgEmpresa.Click += new System.EventHandler(this.dtgEmpresa_Click);
            // 
            // clsEmpresaBindingSource
            // 
            this.clsEmpresaBindingSource.DataSource = typeof(clases.Seguridad.clsEmpresa);
            // 
            // EmpresaDatos
            // 
            this.EmpresaDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidEmpresa,
            this.colnombreComercial,
            this.colruc,
            this.coldireccion,
            this.colcorreo,
            this.colsector,
            this.coldescripcion,
            this.colidEstado});
            this.EmpresaDatos.GridControl = this.dtgEmpresa;
            this.EmpresaDatos.Name = "EmpresaDatos";
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            this.colidEmpresa.Visible = true;
            this.colidEmpresa.VisibleIndex = 0;
            this.colidEmpresa.Width = 73;
            // 
            // colnombreComercial
            // 
            this.colnombreComercial.FieldName = "nombreComercial";
            this.colnombreComercial.Name = "colnombreComercial";
            this.colnombreComercial.Visible = true;
            this.colnombreComercial.VisibleIndex = 1;
            this.colnombreComercial.Width = 171;
            // 
            // colruc
            // 
            this.colruc.FieldName = "ruc";
            this.colruc.Name = "colruc";
            this.colruc.Visible = true;
            this.colruc.VisibleIndex = 2;
            this.colruc.Width = 120;
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 3;
            this.coldireccion.Width = 137;
            // 
            // colcorreo
            // 
            this.colcorreo.FieldName = "correo";
            this.colcorreo.Name = "colcorreo";
            this.colcorreo.Visible = true;
            this.colcorreo.VisibleIndex = 4;
            this.colcorreo.Width = 142;
            // 
            // colsector
            // 
            this.colsector.FieldName = "sector";
            this.colsector.Name = "colsector";
            this.colsector.Visible = true;
            this.colsector.VisibleIndex = 5;
            this.colsector.Width = 104;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 6;
            this.coldescripcion.Width = 156;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 7;
            this.colidEstado.Width = 78;
            // 
            // frmConsultaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 261);
            this.Controls.Add(this.dtgEmpresa);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaEmpresa";
            this.Text = "frmConsultaEmpresa";
            this.Load += new System.EventHandler(this.frmConsultaEmpresa_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl dtgEmpresa;
        private System.Windows.Forms.BindingSource clsEmpresaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView EmpresaDatos;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colruc;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colcorreo;
        private DevExpress.XtraGrid.Columns.GridColumn colsector;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
    }
}