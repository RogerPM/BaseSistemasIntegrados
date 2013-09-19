namespace forms.CuentasxCobrar
{
    partial class frm_ReporteBanco
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rbtnInactivo = new System.Windows.Forms.RadioButton();
            this.rbtnActivo = new System.Windows.Forms.RadioButton();
            this.rbtnTodos = new System.Windows.Forms.RadioButton();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnConsultar = new DevExpress.XtraBars.BarButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dataSetCuentasPorCobrar = new forms.CuentasxCobrar.DataSetCuentasPorCobrar();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoTableAdapter = new forms.CuentasxCobrar.DataSetCuentasPorCobrarTableAdapters.BancoTableAdapter();
            this.gbEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetCuentasPorCobrar";
            reportDataSource1.Value = this.bancoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "forms.CuentasxCobrar.ReportBanco.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(579, 270);
            this.reportViewer1.TabIndex = 0;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rbtnInactivo);
            this.gbEstado.Controls.Add(this.rbtnActivo);
            this.gbEstado.Controls.Add(this.rbtnTodos);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(12, 39);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Size = new System.Drawing.Size(201, 67);
            this.gbEstado.TabIndex = 1;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Filtro de Estado";
            // 
            // rbtnInactivo
            // 
            this.rbtnInactivo.AutoSize = true;
            this.rbtnInactivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInactivo.Location = new System.Drawing.Point(129, 20);
            this.rbtnInactivo.Name = "rbtnInactivo";
            this.rbtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactivo.TabIndex = 2;
            this.rbtnInactivo.TabStop = true;
            this.rbtnInactivo.Text = "Inactivo";
            this.rbtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtnActivo
            // 
            this.rbtnActivo.AutoSize = true;
            this.rbtnActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnActivo.Location = new System.Drawing.Point(68, 20);
            this.rbtnActivo.Name = "rbtnActivo";
            this.rbtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtnActivo.TabIndex = 1;
            this.rbtnActivo.TabStop = true;
            this.rbtnActivo.Text = "Activo";
            this.rbtnActivo.UseVisualStyleBackColor = true;
            // 
            // rbtnTodos
            // 
            this.rbtnTodos.AutoSize = true;
            this.rbtnTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTodos.Location = new System.Drawing.Point(7, 20);
            this.rbtnTodos.Name = "rbtnTodos";
            this.rbtnTodos.Size = new System.Drawing.Size(55, 17);
            this.rbtnTodos.TabIndex = 0;
            this.rbtnTodos.TabStop = true;
            this.rbtnTodos.Text = "Todos";
            this.rbtnTodos.UseVisualStyleBackColor = true;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnConsultar,
            this.btnSalir});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 2;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnConsultar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSalir, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Caption = "Consultar";
            this.btnConsultar.Glyph = global::forms.Properties.Resources.consultar;
            this.btnConsultar.Id = 0;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnConsultar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Glyph = global::forms.Properties.Resources.eliminar;
            this.btnSalir.Id = 1;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSalir_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(603, 22);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 394);
            this.barDockControlBottom.Size = new System.Drawing.Size(603, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 22);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 372);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(603, 22);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 372);
            // 
            // dataSetCuentasPorCobrar
            // 
            this.dataSetCuentasPorCobrar.DataSetName = "DataSetCuentasPorCobrar";
            this.dataSetCuentasPorCobrar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataMember = "Banco";
            this.bancoBindingSource.DataSource = this.dataSetCuentasPorCobrar;
            // 
            // bancoTableAdapter
            // 
            this.bancoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReporteBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(603, 394);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frm_ReporteBanco";
            this.Text = "frm_ReporteBanco";
            this.Load += new System.EventHandler(this.frm_ReporteBanco_Load);
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rbtnInactivo;
        private System.Windows.Forms.RadioButton rbtnActivo;
        private System.Windows.Forms.RadioButton rbtnTodos;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnConsultar;
        private DevExpress.XtraBars.BarButtonItem btnSalir;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DataSetCuentasPorCobrar dataSetCuentasPorCobrar;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private DataSetCuentasPorCobrarTableAdapters.BancoTableAdapter bancoTableAdapter;
    }
}