namespace forms.Cuentasxpagar
{
    partial class frmConsultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.gdcConsulta = new DevExpress.XtraGrid.GridControl();
            this.clsEmpresaServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresaServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_RazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Website = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAceptar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsulta)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdcConsulta
            // 
            this.gdcConsulta.DataSource = this.clsEmpresaServicioBindingSource;
            this.gdcConsulta.Location = new System.Drawing.Point(0, 28);
            this.gdcConsulta.MainView = this.gdvConsulta;
            this.gdcConsulta.Name = "gdcConsulta";
            this.gdcConsulta.Size = new System.Drawing.Size(528, 235);
            this.gdcConsulta.TabIndex = 0;
            this.gdcConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvConsulta});
            // 
            // clsEmpresaServicioBindingSource
            // 
            this.clsEmpresaServicioBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsEmpresaServicio);
            // 
            // gdvConsulta
            // 
            this.gdvConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_IdEmpresa,
            this.col_IdEmpresaServicio,
            this.col_TipoPersona,
            this.col_RazonSocial,
            this.col_IdEstado,
            this.col_Direccion,
            this.col_Email,
            this.col_Website,
            this.col_IdUsuario,
            this.col_FechaRegistro});
            this.gdvConsulta.GridControl = this.gdcConsulta;
            this.gdvConsulta.Name = "gdvConsulta";
            this.gdvConsulta.OptionsBehavior.Editable = false;
            this.gdvConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gdvConsulta.OptionsView.ShowGroupPanel = false;
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.FieldName = "_IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            // 
            // col_IdEmpresaServicio
            // 
            this.col_IdEmpresaServicio.AppearanceHeader.Options.UseTextOptions = true;
            this.col_IdEmpresaServicio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_IdEmpresaServicio.Caption = "Código";
            this.col_IdEmpresaServicio.FieldName = "_IdEmpresaServicio";
            this.col_IdEmpresaServicio.Name = "col_IdEmpresaServicio";
            this.col_IdEmpresaServicio.Visible = true;
            this.col_IdEmpresaServicio.VisibleIndex = 0;
            this.col_IdEmpresaServicio.Width = 117;
            // 
            // col_TipoPersona
            // 
            this.col_TipoPersona.FieldName = "_TipoPersona";
            this.col_TipoPersona.Name = "col_TipoPersona";
            // 
            // col_RazonSocial
            // 
            this.col_RazonSocial.AppearanceHeader.Options.UseTextOptions = true;
            this.col_RazonSocial.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_RazonSocial.Caption = "Razón Social";
            this.col_RazonSocial.FieldName = "_RazonSocial";
            this.col_RazonSocial.Name = "col_RazonSocial";
            this.col_RazonSocial.Visible = true;
            this.col_RazonSocial.VisibleIndex = 1;
            this.col_RazonSocial.Width = 520;
            // 
            // col_IdEstado
            // 
            this.col_IdEstado.FieldName = "_IdEstado";
            this.col_IdEstado.Name = "col_IdEstado";
            // 
            // col_Direccion
            // 
            this.col_Direccion.FieldName = "_Direccion";
            this.col_Direccion.Name = "col_Direccion";
            // 
            // col_Email
            // 
            this.col_Email.FieldName = "_Email";
            this.col_Email.Name = "col_Email";
            // 
            // col_Website
            // 
            this.col_Website.FieldName = "_Website";
            this.col_Website.Name = "col_Website";
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.FieldName = "_IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // col_FechaRegistro
            // 
            this.col_FechaRegistro.FieldName = "_FechaRegistro";
            this.col_FechaRegistro.Name = "col_FechaRegistro";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAceptar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAceptar
            // 
            this.tsbAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAceptar.Image = ((System.Drawing.Image)(resources.GetObject("tsbAceptar.Image")));
            this.tsbAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAceptar.Name = "tsbAceptar";
            this.tsbAceptar.Size = new System.Drawing.Size(23, 22);
            this.tsbAceptar.Text = "Aceptar";
            this.tsbAceptar.Click += new System.EventHandler(this.tsbAceptar_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gdcConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaServicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsulta)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvConsulta;
        private System.Windows.Forms.BindingSource clsEmpresaServicioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresaServicio;
        private DevExpress.XtraGrid.Columns.GridColumn col_TipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn col_RazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn col_Direccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_Email;
        private DevExpress.XtraGrid.Columns.GridColumn col_Website;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaRegistro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAceptar;

    }
}