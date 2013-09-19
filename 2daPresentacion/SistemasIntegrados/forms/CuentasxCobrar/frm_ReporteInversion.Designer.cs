namespace forms.CuentasxCobrar
{
    partial class frm_ReporteInversion
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
            this.inversionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCuentasPorCobrar = new forms.CuentasxCobrar.DataSetCuentasPorCobrar();
            this.rpvInversion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inversionTableAdapter = new forms.CuentasxCobrar.DataSetCuentasPorCobrarTableAdapters.InversionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inversionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).BeginInit();
            this.SuspendLayout();
            // 
            // inversionBindingSource
            // 
            this.inversionBindingSource.DataMember = "Inversion";
            this.inversionBindingSource.DataSource = this.dataSetCuentasPorCobrar;
            // 
            // dataSetCuentasPorCobrar
            // 
            this.dataSetCuentasPorCobrar.DataSetName = "DataSetCuentasPorCobrar";
            this.dataSetCuentasPorCobrar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvInversion
            // 
            this.rpvInversion.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCuentasPorCobrar";
            reportDataSource1.Value = this.inversionBindingSource;
            this.rpvInversion.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvInversion.LocalReport.ReportEmbeddedResource = "forms.CuentasxCobrar.ReportInversion.rdlc";
            this.rpvInversion.Location = new System.Drawing.Point(0, 0);
            this.rpvInversion.Name = "rpvInversion";
            this.rpvInversion.Size = new System.Drawing.Size(730, 264);
            this.rpvInversion.TabIndex = 0;
            // 
            // inversionTableAdapter
            // 
            this.inversionTableAdapter.ClearBeforeFill = true;
            // 
            // frm_ReporteInversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 264);
            this.Controls.Add(this.rpvInversion);
            this.Name = "frm_ReporteInversion";
            this.Text = "Reporte de Inversion";
            this.Load += new System.EventHandler(this.frm_ReporteInversion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inversionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvInversion;
        private DataSetCuentasPorCobrar dataSetCuentasPorCobrar;
        private DataSetCuentasPorCobrarTableAdapters.InversionTableAdapter inversionTableAdapter;
        private System.Windows.Forms.BindingSource inversionBindingSource;
    }
}