namespace clases.Cuentasxpagar
{
    partial class frmConsultaCuentaPorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaCuentaPorPagar));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.gdcConsultaCtaxPag = new DevExpress.XtraGrid.GridControl();
            this.clsCuentaPorPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gdvConsultaCtaxPag = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_NumCuentaPorPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumIngresoEgreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaIngreso = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Factura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FechaTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresaServicio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Detalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Subtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Descuento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Total = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_FormaPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ValorEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NumeroLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdFrecuencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ValorLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_SaldoDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_IdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaCtaxPag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsultaCtaxPag)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOk});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbOk
            // 
            this.tsbOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOk.Image = ((System.Drawing.Image)(resources.GetObject("tsbOk.Image")));
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(23, 22);
            this.tsbOk.Text = "toolStripButton1";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // gdcConsultaCtaxPag
            // 
            this.gdcConsultaCtaxPag.DataSource = this.clsCuentaPorPagarBindingSource;
            this.gdcConsultaCtaxPag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcConsultaCtaxPag.Location = new System.Drawing.Point(0, 25);
            this.gdcConsultaCtaxPag.MainView = this.gdvConsultaCtaxPag;
            this.gdcConsultaCtaxPag.Name = "gdcConsultaCtaxPag";
            this.gdcConsultaCtaxPag.Size = new System.Drawing.Size(740, 387);
            this.gdcConsultaCtaxPag.TabIndex = 1;
            this.gdcConsultaCtaxPag.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvConsultaCtaxPag});
            // 
            // clsCuentaPorPagarBindingSource
            // 
            this.clsCuentaPorPagarBindingSource.DataSource = typeof(clases.Cuentasxpagar.clsCuentaPorPagar);
            // 
            // gdvConsultaCtaxPag
            // 
            this.gdvConsultaCtaxPag.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_NumCuentaPorPagar,
            this.col_NumIngresoEgreso,
            this.col_FechaIngreso,
            this.col_Factura,
            this.col_FechaTransaccion,
            this.col_IdProveedor,
            this.col_IdEmpresaServicio,
            this.col_Motivo,
            this.col_Detalle,
            this.col_Subtotal,
            this.col_Descuento,
            this.col_Total,
            this.col_FormaPago,
            this.col_ValorEntrada,
            this.col_NumeroLetra,
            this.col_IdFrecuencia,
            this.col_ValorLetra,
            this.col_SaldoDeuda,
            this.col_IdUsuario,
            this.col_IdEmpresa});
            this.gdvConsultaCtaxPag.GridControl = this.gdcConsultaCtaxPag;
            this.gdvConsultaCtaxPag.Name = "gdvConsultaCtaxPag";
            this.gdvConsultaCtaxPag.OptionsView.ShowAutoFilterRow = true;
            this.gdvConsultaCtaxPag.OptionsView.ShowGroupPanel = false;
            // 
            // col_NumCuentaPorPagar
            // 
            this.col_NumCuentaPorPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.col_NumCuentaPorPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_NumCuentaPorPagar.Caption = "Nro Cta. por Pagar";
            this.col_NumCuentaPorPagar.FieldName = "_NumCuentaPorPagar";
            this.col_NumCuentaPorPagar.Name = "col_NumCuentaPorPagar";
            this.col_NumCuentaPorPagar.OptionsColumn.AllowEdit = false;
            this.col_NumCuentaPorPagar.Visible = true;
            this.col_NumCuentaPorPagar.VisibleIndex = 0;
            this.col_NumCuentaPorPagar.Width = 119;
            // 
            // col_NumIngresoEgreso
            // 
            this.col_NumIngresoEgreso.AppearanceHeader.Options.UseTextOptions = true;
            this.col_NumIngresoEgreso.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_NumIngresoEgreso.FieldName = "_NumIngresoEgreso";
            this.col_NumIngresoEgreso.Name = "col_NumIngresoEgreso";
            // 
            // col_FechaIngreso
            // 
            this.col_FechaIngreso.FieldName = "_FechaIngreso";
            this.col_FechaIngreso.Name = "col_FechaIngreso";
            // 
            // col_Factura
            // 
            this.col_Factura.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Factura.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Factura.Caption = "Nro. Factura";
            this.col_Factura.FieldName = "_Factura";
            this.col_Factura.Name = "col_Factura";
            this.col_Factura.OptionsColumn.AllowEdit = false;
            this.col_Factura.Visible = true;
            this.col_Factura.VisibleIndex = 1;
            this.col_Factura.Width = 311;
            // 
            // col_FechaTransaccion
            // 
            this.col_FechaTransaccion.AppearanceHeader.Options.UseTextOptions = true;
            this.col_FechaTransaccion.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_FechaTransaccion.Caption = "Fecha Transacción";
            this.col_FechaTransaccion.FieldName = "_FechaTransaccion";
            this.col_FechaTransaccion.Name = "col_FechaTransaccion";
            this.col_FechaTransaccion.OptionsColumn.AllowEdit = false;
            this.col_FechaTransaccion.Visible = true;
            this.col_FechaTransaccion.VisibleIndex = 2;
            this.col_FechaTransaccion.Width = 119;
            // 
            // col_IdProveedor
            // 
            this.col_IdProveedor.FieldName = "_IdProveedor";
            this.col_IdProveedor.Name = "col_IdProveedor";
            // 
            // col_IdEmpresaServicio
            // 
            this.col_IdEmpresaServicio.FieldName = "_IdEmpresaServicio";
            this.col_IdEmpresaServicio.Name = "col_IdEmpresaServicio";
            // 
            // col_Motivo
            // 
            this.col_Motivo.FieldName = "_Motivo";
            this.col_Motivo.Name = "col_Motivo";
            // 
            // col_Detalle
            // 
            this.col_Detalle.FieldName = "_Detalle";
            this.col_Detalle.Name = "col_Detalle";
            // 
            // col_Subtotal
            // 
            this.col_Subtotal.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Subtotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Subtotal.Caption = "Subtotal";
            this.col_Subtotal.FieldName = "_Subtotal";
            this.col_Subtotal.Name = "col_Subtotal";
            this.col_Subtotal.OptionsColumn.AllowEdit = false;
            this.col_Subtotal.Visible = true;
            this.col_Subtotal.VisibleIndex = 3;
            this.col_Subtotal.Width = 105;
            // 
            // col_Descuento
            // 
            this.col_Descuento.FieldName = "_Descuento";
            this.col_Descuento.Name = "col_Descuento";
            // 
            // col_Total
            // 
            this.col_Total.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Total.Caption = "Total";
            this.col_Total.FieldName = "_Total";
            this.col_Total.Name = "col_Total";
            this.col_Total.OptionsColumn.AllowEdit = false;
            this.col_Total.Visible = true;
            this.col_Total.VisibleIndex = 4;
            this.col_Total.Width = 109;
            // 
            // col_FormaPago
            // 
            this.col_FormaPago.AppearanceHeader.Options.UseTextOptions = true;
            this.col_FormaPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_FormaPago.Caption = "Forma de Pago";
            this.col_FormaPago.FieldName = "_FormaPago";
            this.col_FormaPago.Name = "col_FormaPago";
            this.col_FormaPago.Width = 74;
            // 
            // col_ValorEntrada
            // 
            this.col_ValorEntrada.FieldName = "_ValorEntrada";
            this.col_ValorEntrada.Name = "col_ValorEntrada";
            // 
            // col_NumeroLetra
            // 
            this.col_NumeroLetra.FieldName = "_NumeroLetra";
            this.col_NumeroLetra.Name = "col_NumeroLetra";
            // 
            // col_IdFrecuencia
            // 
            this.col_IdFrecuencia.FieldName = "_IdFrecuencia";
            this.col_IdFrecuencia.Name = "col_IdFrecuencia";
            // 
            // col_ValorLetra
            // 
            this.col_ValorLetra.FieldName = "_ValorLetra";
            this.col_ValorLetra.Name = "col_ValorLetra";
            // 
            // col_SaldoDeuda
            // 
            this.col_SaldoDeuda.FieldName = "_SaldoDeuda";
            this.col_SaldoDeuda.Name = "col_SaldoDeuda";
            // 
            // col_IdUsuario
            // 
            this.col_IdUsuario.FieldName = "_IdUsuario";
            this.col_IdUsuario.Name = "col_IdUsuario";
            // 
            // col_IdEmpresa
            // 
            this.col_IdEmpresa.FieldName = "_IdEmpresa";
            this.col_IdEmpresa.Name = "col_IdEmpresa";
            // 
            // frmConsultaCuentaPorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 412);
            this.Controls.Add(this.gdcConsultaCtaxPag);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultaCuentaPorPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Cuentas por Pagar";
            this.Load += new System.EventHandler(this.frmConsultaCuentaPorPagar_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcConsultaCtaxPag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaPorPagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvConsultaCtaxPag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gdcConsultaCtaxPag;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvConsultaCtaxPag;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.BindingSource clsCuentaPorPagarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumCuentaPorPagar;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumIngresoEgreso;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaIngreso;
        private DevExpress.XtraGrid.Columns.GridColumn col_Factura;
        private DevExpress.XtraGrid.Columns.GridColumn col_FechaTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresaServicio;
        private DevExpress.XtraGrid.Columns.GridColumn col_Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn col_Detalle;
        private DevExpress.XtraGrid.Columns.GridColumn col_Subtotal;
        private DevExpress.XtraGrid.Columns.GridColumn col_Descuento;
        private DevExpress.XtraGrid.Columns.GridColumn col_Total;
        private DevExpress.XtraGrid.Columns.GridColumn col_FormaPago;
        private DevExpress.XtraGrid.Columns.GridColumn col_ValorEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn col_NumeroLetra;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdFrecuencia;
        private DevExpress.XtraGrid.Columns.GridColumn col_ValorLetra;
        private DevExpress.XtraGrid.Columns.GridColumn col_SaldoDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn col_IdEmpresa;
    }
}