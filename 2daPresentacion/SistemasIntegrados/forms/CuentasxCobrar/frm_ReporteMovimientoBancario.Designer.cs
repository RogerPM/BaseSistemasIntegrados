namespace forms.CuentasxCobrar
{
    partial class frm_ReporteMovimientoBancario
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
            this.dataSetCuentasPorCobrar = new forms.CuentasxCobrar.DataSetCuentasPorCobrar();
            this.rpvMovimientoBancario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.movimientoBancarioTableAdapter = new forms.CuentasxCobrar.DataSetCuentasPorCobrarTableAdapters.MovimientoBancarioTableAdapter();
            this.movimientoBancarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBancarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetCuentasPorCobrar
            // 
            this.dataSetCuentasPorCobrar.DataSetName = "DataSetCuentasPorCobrar";
            this.dataSetCuentasPorCobrar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvMovimientoBancario
            // 
            this.rpvMovimientoBancario.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCuentasPorCobrar";
            reportDataSource1.Value = this.movimientoBancarioBindingSource;
            this.rpvMovimientoBancario.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvMovimientoBancario.LocalReport.ReportEmbeddedResource = "forms.CuentasxCobrar.ReportMovimientoBancario.rdlc";
            this.rpvMovimientoBancario.Location = new System.Drawing.Point(0, 0);
            this.rpvMovimientoBancario.Name = "rpvMovimientoBancario";
            this.rpvMovimientoBancario.Size = new System.Drawing.Size(768, 301);
            this.rpvMovimientoBancario.TabIndex = 0;
            // 
            // movimientoBancarioTableAdapter
            // 
            this.movimientoBancarioTableAdapter.ClearBeforeFill = true;
            // 
            // movimientoBancarioBindingSource
            // 
            this.movimientoBancarioBindingSource.DataMember = "MovimientoBancario";
            this.movimientoBancarioBindingSource.DataSource = this.dataSetCuentasPorCobrar;
            // 
            // frm_ReporteMovimientoBancario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 301);
            this.Controls.Add(this.rpvMovimientoBancario);
            this.Name = "frm_ReporteMovimientoBancario";
            this.Text = "Reporte de Movimiento Bancario";
            this.Load += new System.EventHandler(this.frm_ReporteMovimientoBancario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCuentasPorCobrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movimientoBancarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvMovimientoBancario;
        private DataSetCuentasPorCobrar dataSetCuentasPorCobrar;
        private DataSetCuentasPorCobrarTableAdapters.MovimientoBancarioTableAdapter movimientoBancarioTableAdapter;
        private System.Windows.Forms.BindingSource movimientoBancarioBindingSource;
    }
}