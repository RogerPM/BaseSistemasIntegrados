namespace forms.Compras
{
    partial class frmComprasConsultaPersona
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
            this.dtgPersona = new DevExpress.XtraGrid.GridControl();
            this.clsComprasPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PersonaDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsComprasPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(678, 25);
            this.toolStrip1.TabIndex = 80;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            // 
            // dtgPersona
            // 
            this.dtgPersona.DataSource = this.clsComprasPersonaBindingSource;
            this.dtgPersona.Location = new System.Drawing.Point(13, 28);
            this.dtgPersona.MainView = this.PersonaDatos;
            this.dtgPersona.Name = "dtgPersona";
            this.dtgPersona.Size = new System.Drawing.Size(653, 200);
            this.dtgPersona.TabIndex = 81;
            this.dtgPersona.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PersonaDatos});
            this.dtgPersona.Click += new System.EventHandler(this.dtgPersona_Click);
            // 
            // clsComprasPersonaBindingSource
            // 
            this.clsComprasPersonaBindingSource.DataSource = typeof(clases.Compras.clsComprasPersona);
            // 
            // PersonaDatos
            // 
            this.PersonaDatos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colIdentificacion,
            this.colIdTipoPersona,
            this.colNombreRazonSocial,
            this.colApellido,
            this.colTipoIdentificacion,
            this.colmail,
            this.colIdEmpresa,
            this.colIdEstado});
            this.PersonaDatos.GridControl = this.dtgPersona;
            this.PersonaDatos.Name = "PersonaDatos";
            this.PersonaDatos.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colApellido, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Width = 74;
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.FieldName = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.Visible = true;
            this.colIdentificacion.VisibleIndex = 2;
            this.colIdentificacion.Width = 167;
            // 
            // colIdTipoPersona
            // 
            this.colIdTipoPersona.FieldName = "IdTipoPersona";
            this.colIdTipoPersona.Name = "colIdTipoPersona";
            this.colIdTipoPersona.Width = 132;
            // 
            // colNombreRazonSocial
            // 
            this.colNombreRazonSocial.FieldName = "NombreRazonSocial";
            this.colNombreRazonSocial.Name = "colNombreRazonSocial";
            this.colNombreRazonSocial.Visible = true;
            this.colNombreRazonSocial.VisibleIndex = 0;
            this.colNombreRazonSocial.Width = 246;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 1;
            this.colApellido.Width = 286;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.FieldName = "TipoIdentificacion";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            this.colTipoIdentificacion.Width = 171;
            // 
            // colmail
            // 
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 3;
            this.colmail.Width = 283;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 63;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 4;
            this.colIdEstado.Width = 192;
            // 
            // frmComprasConsultaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 240);
            this.Controls.Add(this.dtgPersona);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmComprasConsultaPersona";
            this.Text = "frmComprasConsultaPersona";
            this.Load += new System.EventHandler(this.frmComprasConsultaPersona_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsComprasPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraGrid.GridControl dtgPersona;
        private System.Windows.Forms.BindingSource clsComprasPersonaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView PersonaDatos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}