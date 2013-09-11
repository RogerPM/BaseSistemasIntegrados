namespace forms.Cuentasxpagar
{
    partial class frmConsultaPrueba
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
            this.gdclocura = new DevExpress.XtraGrid.GridControl();
            this.clsPagoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumLinea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdMedioPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumeroCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBanco = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumComprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumComision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumNominaCab = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumPago = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdclocura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gdclocura
            // 
            this.gdclocura.DataSource = this.clsPagoDetalleBindingSource;
            this.gdclocura.Location = new System.Drawing.Point(12, 50);
            this.gdclocura.MainView = this.gridView1;
            this.gdclocura.Name = "gdclocura";
            this.gdclocura.Size = new System.Drawing.Size(400, 200);
            this.gdclocura.TabIndex = 0;
            this.gdclocura.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsPagoDetalleBindingSource
            // 
            this.clsPagoDetalleBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsPagoDetalle);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumLinea,
            this.colIdMedioPago,
            this.colMonto,
            this.colNumeroCuenta,
            this.colIdEmpresa,
            this.colIdBanco,
            this.colNumComprobante,
            this.colNumComision,
            this.colNumNominaCab,
            this.colNumPago});
            this.gridView1.GridControl = this.gdclocura;
            this.gridView1.Name = "gridView1";
            // 
            // colNumLinea
            // 
            this.colNumLinea.FieldName = "NumLinea";
            this.colNumLinea.Name = "colNumLinea";
            this.colNumLinea.Visible = true;
            this.colNumLinea.VisibleIndex = 0;
            // 
            // colIdMedioPago
            // 
            this.colIdMedioPago.FieldName = "IdMedioPago";
            this.colIdMedioPago.Name = "colIdMedioPago";
            this.colIdMedioPago.Visible = true;
            this.colIdMedioPago.VisibleIndex = 1;
            // 
            // colMonto
            // 
            this.colMonto.FieldName = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.Visible = true;
            this.colMonto.VisibleIndex = 2;
            // 
            // colNumeroCuenta
            // 
            this.colNumeroCuenta.FieldName = "NumeroCuenta";
            this.colNumeroCuenta.Name = "colNumeroCuenta";
            this.colNumeroCuenta.Visible = true;
            this.colNumeroCuenta.VisibleIndex = 3;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 4;
            // 
            // colIdBanco
            // 
            this.colIdBanco.FieldName = "IdBanco";
            this.colIdBanco.Name = "colIdBanco";
            this.colIdBanco.Visible = true;
            this.colIdBanco.VisibleIndex = 5;
            // 
            // colNumComprobante
            // 
            this.colNumComprobante.FieldName = "NumComprobante";
            this.colNumComprobante.Name = "colNumComprobante";
            this.colNumComprobante.Visible = true;
            this.colNumComprobante.VisibleIndex = 6;
            // 
            // colNumComision
            // 
            this.colNumComision.FieldName = "NumComision";
            this.colNumComision.Name = "colNumComision";
            this.colNumComision.Visible = true;
            this.colNumComision.VisibleIndex = 7;
            // 
            // colNumNominaCab
            // 
            this.colNumNominaCab.FieldName = "NumNominaCab";
            this.colNumNominaCab.Name = "colNumNominaCab";
            this.colNumNominaCab.Visible = true;
            this.colNumNominaCab.VisibleIndex = 8;
            // 
            // colNumPago
            // 
            this.colNumPago.FieldName = "NumPago";
            this.colNumPago.Name = "colNumPago";
            this.colNumPago.Visible = true;
            this.colNumPago.VisibleIndex = 9;
            // 
            // frmConsultaPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 262);
            this.Controls.Add(this.gdclocura);
            this.Name = "frmConsultaPrueba";
            this.Text = "frmConsultaPrueba";
            this.Load += new System.EventHandler(this.frmConsultaPrueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdclocura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPagoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdclocura;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPagoDetalleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNumLinea;
        private DevExpress.XtraGrid.Columns.GridColumn colIdMedioPago;
        private DevExpress.XtraGrid.Columns.GridColumn colMonto;
        private DevExpress.XtraGrid.Columns.GridColumn colNumeroCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBanco;
        private DevExpress.XtraGrid.Columns.GridColumn colNumComprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colNumComision;
        private DevExpress.XtraGrid.Columns.GridColumn colNumNominaCab;
        private DevExpress.XtraGrid.Columns.GridColumn colNumPago;
    }
}