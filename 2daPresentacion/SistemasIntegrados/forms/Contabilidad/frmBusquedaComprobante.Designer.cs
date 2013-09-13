namespace forms.Contabilidad
{
    partial class frmBusquedaComprobante
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
            this.gcConsulta = new DevExpress.XtraGrid.GridControl();
            this.clsConsultaComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvConsulta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colglosa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsConsultaComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gcConsulta
            // 
            this.gcConsulta.DataSource = this.clsConsultaComprobanteBindingSource;
            this.gcConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConsulta.Location = new System.Drawing.Point(0, 0);
            this.gcConsulta.MainView = this.gvConsulta;
            this.gcConsulta.Name = "gcConsulta";
            this.gcConsulta.Size = new System.Drawing.Size(599, 374);
            this.gcConsulta.TabIndex = 0;
            this.gcConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvConsulta});
            this.gcConsulta.Click += new System.EventHandler(this.gcConsulta_Click);
            // 
            // clsConsultaComprobanteBindingSource
            // 
            this.clsConsultaComprobanteBindingSource.DataSource = typeof(clases.Contabilidad.clsConsultaComprobante);
            // 
            // gvConsulta
            // 
            this.gvConsulta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colnumero_comprobante,
            this.colfecha,
            this.colglosa,
            this.coldebe,
            this.colhaber});
            this.gvConsulta.GridControl = this.gcConsulta;
            this.gvConsulta.Name = "gvConsulta";
            this.gvConsulta.OptionsBehavior.Editable = false;
            this.gvConsulta.OptionsFilter.ShowAllTableValuesInFilterPopup = true;
            this.gvConsulta.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvConsulta.OptionsFind.AlwaysVisible = true;
            this.gvConsulta.OptionsFind.SearchInPreview = true;
            this.gvConsulta.OptionsView.ShowAutoFilterRow = true;
            this.gvConsulta.OptionsView.ShowGroupPanel = false;
            this.gvConsulta.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvConsulta_RowClick);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            // 
            // colnumero_comprobante
            // 
            this.colnumero_comprobante.Caption = "# Comprobante";
            this.colnumero_comprobante.FieldName = "numero_comprobante";
            this.colnumero_comprobante.Name = "colnumero_comprobante";
            this.colnumero_comprobante.Visible = true;
            this.colnumero_comprobante.VisibleIndex = 1;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 2;
            // 
            // colglosa
            // 
            this.colglosa.FieldName = "glosa";
            this.colglosa.Name = "colglosa";
            this.colglosa.Visible = true;
            this.colglosa.VisibleIndex = 3;
            // 
            // coldebe
            // 
            this.coldebe.FieldName = "debe";
            this.coldebe.Name = "coldebe";
            this.coldebe.Visible = true;
            this.coldebe.VisibleIndex = 4;
            // 
            // colhaber
            // 
            this.colhaber.FieldName = "haber";
            this.colhaber.Name = "colhaber";
            this.colhaber.Visible = true;
            this.colhaber.VisibleIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(572, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmBusquedaComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 374);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gcConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBusquedaComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmBusquedaComprobante";
            this.Load += new System.EventHandler(this.frmBusquedaComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsConsultaComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gvConsulta;
        private System.Windows.Forms.BindingSource clsConsultaComprobanteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colglosa;
        private DevExpress.XtraGrid.Columns.GridColumn coldebe;
        private DevExpress.XtraGrid.Columns.GridColumn colhaber;
        private System.Windows.Forms.Button btnSalir;
    }
}