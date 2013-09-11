namespace forms.Cuentasxpagar
{
    partial class frmConsultaEmpresaServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEmpresaServicio));
            this.gdcEmpresaServicio = new DevExpress.XtraGrid.GridControl();
            this.clsEmpresaServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresaServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colwebpage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpresaServicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcEmpresaServicio
            // 
            this.gdcEmpresaServicio.DataSource = this.clsEmpresaServicioBindingSource;
            this.gdcEmpresaServicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcEmpresaServicio.Location = new System.Drawing.Point(0, 0);
            this.gdcEmpresaServicio.MainView = this.gridView1;
            this.gdcEmpresaServicio.Name = "gdcEmpresaServicio";
            this.gdcEmpresaServicio.Size = new System.Drawing.Size(521, 262);
            this.gdcEmpresaServicio.TabIndex = 0;
            this.gdcEmpresaServicio.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsEmpresaServicioBindingSource
            // 
            this.clsEmpresaServicioBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsEmpresaServicio);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresaServicio,
            this.colfechaRegistro,
            this.colRazonSocial,
            this.colDireccion,
            this.colemail,
            this.colwebpage,
            this.colIdEstado,
            this.colIdTipoPersona,
            this.colIdEmpresa,
            this.colIdUsuario});
            this.gridView1.GridControl = this.gdcEmpresaServicio;
            this.gridView1.Name = "gridView1";
            // 
            // colIdEmpresaServicio
            // 
            this.colIdEmpresaServicio.FieldName = "IdEmpresaServicio";
            this.colIdEmpresaServicio.Name = "colIdEmpresaServicio";
            this.colIdEmpresaServicio.Visible = true;
            this.colIdEmpresaServicio.VisibleIndex = 0;
            // 
            // colfechaRegistro
            // 
            this.colfechaRegistro.FieldName = "fechaRegistro";
            this.colfechaRegistro.Name = "colfechaRegistro";
            this.colfechaRegistro.Visible = true;
            this.colfechaRegistro.VisibleIndex = 1;
            // 
            // colRazonSocial
            // 
            this.colRazonSocial.FieldName = "RazonSocial";
            this.colRazonSocial.Name = "colRazonSocial";
            this.colRazonSocial.Visible = true;
            this.colRazonSocial.VisibleIndex = 2;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 3;
            // 
            // colemail
            // 
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            // 
            // colwebpage
            // 
            this.colwebpage.FieldName = "webpage";
            this.colwebpage.Name = "colwebpage";
            this.colwebpage.Visible = true;
            this.colwebpage.VisibleIndex = 5;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "Estado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 6;
            // 
            // colIdTipoPersona
            // 
            this.colIdTipoPersona.FieldName = "IdTipoPersona";
            this.colIdTipoPersona.Name = "colIdTipoPersona";
            this.colIdTipoPersona.Visible = true;
            this.colIdTipoPersona.VisibleIndex = 7;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 8;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(521, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbOk.ForeColor = System.Drawing.Color.Black;
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(40, 22);
            this.tsbOk.Text = "ok";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // frmConsultaEmpresaServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcEmpresaServicio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConsultaEmpresaServicio";
            this.Text = "frmConsultaEmpresaServicio";
            this.Load += new System.EventHandler(this.frmConsultaEmpresaServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpresaServicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcEmpresaServicio;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.BindingSource clsEmpresaServicioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresaServicio;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colwebpage;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
    }
}