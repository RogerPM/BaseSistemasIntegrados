namespace forms.Cuentasxpagar
{
    partial class frmOrdenPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrdenPago));
            this.gdcOrdenPago = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNúmeroRegistroCXP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaldoDeuda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcFechaVencimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorLetra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdcNumLetrasAPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroPagosRealizar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPagar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAutorizarPago = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtEfectivoDisponible = new DevExpress.XtraEditors.TextEdit();
            this.txtTotalPagar = new DevExpress.XtraEditors.TextEdit();
            this.cbxProveedor = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaEmisión = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbAnular = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.btnGenerarComprobante = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcOrdenPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoDisponible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gdcOrdenPago
            // 
            this.gdcOrdenPago.Location = new System.Drawing.Point(18, 72);
            this.gdcOrdenPago.MainView = this.gridView1;
            this.gdcOrdenPago.Name = "gdcOrdenPago";
            this.gdcOrdenPago.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gdcOrdenPago.Size = new System.Drawing.Size(969, 323);
            this.gdcOrdenPago.TabIndex = 36;
            this.gdcOrdenPago.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNúmeroRegistroCXP,
            this.colSaldoDeuda,
            this.gdcFechaVencimiento,
            this.colValorLetra,
            this.gdcNumLetrasAPagar,
            this.colNroPagosRealizar,
            this.colTotalPagar,
            this.colAutorizarPago});
            this.gridView1.GridControl = this.gdcOrdenPago;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colNúmeroRegistroCXP
            // 
            this.colNúmeroRegistroCXP.AppearanceHeader.Options.UseTextOptions = true;
            this.colNúmeroRegistroCXP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNúmeroRegistroCXP.Caption = "Nro. Cta. Por Pagar";
            this.colNúmeroRegistroCXP.Name = "colNúmeroRegistroCXP";
            this.colNúmeroRegistroCXP.Visible = true;
            this.colNúmeroRegistroCXP.VisibleIndex = 0;
            this.colNúmeroRegistroCXP.Width = 118;
            // 
            // colSaldoDeuda
            // 
            this.colSaldoDeuda.AppearanceHeader.Options.UseTextOptions = true;
            this.colSaldoDeuda.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSaldoDeuda.Caption = "Saldo Deuda";
            this.colSaldoDeuda.Name = "colSaldoDeuda";
            this.colSaldoDeuda.Visible = true;
            this.colSaldoDeuda.VisibleIndex = 1;
            this.colSaldoDeuda.Width = 118;
            // 
            // gdcFechaVencimiento
            // 
            this.gdcFechaVencimiento.AppearanceHeader.Options.UseTextOptions = true;
            this.gdcFechaVencimiento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gdcFechaVencimiento.Caption = "Fecha de Vencimiento";
            this.gdcFechaVencimiento.Name = "gdcFechaVencimiento";
            this.gdcFechaVencimiento.Visible = true;
            this.gdcFechaVencimiento.VisibleIndex = 2;
            this.gdcFechaVencimiento.Width = 118;
            // 
            // colValorLetra
            // 
            this.colValorLetra.AppearanceHeader.Options.UseTextOptions = true;
            this.colValorLetra.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colValorLetra.Caption = "Valor de Letra";
            this.colValorLetra.Name = "colValorLetra";
            this.colValorLetra.Visible = true;
            this.colValorLetra.VisibleIndex = 3;
            this.colValorLetra.Width = 118;
            // 
            // gdcNumLetrasAPagar
            // 
            this.gdcNumLetrasAPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.gdcNumLetrasAPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gdcNumLetrasAPagar.Caption = "Letras Pendientes de Pago";
            this.gdcNumLetrasAPagar.Name = "gdcNumLetrasAPagar";
            this.gdcNumLetrasAPagar.Visible = true;
            this.gdcNumLetrasAPagar.VisibleIndex = 4;
            this.gdcNumLetrasAPagar.Width = 138;
            // 
            // colNroPagosRealizar
            // 
            this.colNroPagosRealizar.AppearanceHeader.Options.UseTextOptions = true;
            this.colNroPagosRealizar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNroPagosRealizar.Caption = "Nro. Pagos a Realizar";
            this.colNroPagosRealizar.Name = "colNroPagosRealizar";
            this.colNroPagosRealizar.Visible = true;
            this.colNroPagosRealizar.VisibleIndex = 5;
            this.colNroPagosRealizar.Width = 110;
            // 
            // colTotalPagar
            // 
            this.colTotalPagar.AppearanceHeader.Options.UseTextOptions = true;
            this.colTotalPagar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colTotalPagar.Caption = "Total a Pagar";
            this.colTotalPagar.Name = "colTotalPagar";
            this.colTotalPagar.Visible = true;
            this.colTotalPagar.VisibleIndex = 6;
            this.colTotalPagar.Width = 110;
            // 
            // colAutorizarPago
            // 
            this.colAutorizarPago.AppearanceHeader.Options.UseTextOptions = true;
            this.colAutorizarPago.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAutorizarPago.Caption = "Autorizar Pago";
            this.colAutorizarPago.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colAutorizarPago.Name = "colAutorizarPago";
            this.colAutorizarPago.Visible = true;
            this.colAutorizarPago.VisibleIndex = 7;
            this.colAutorizarPago.Width = 121;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // txtEfectivoDisponible
            // 
            this.txtEfectivoDisponible.Enabled = false;
            this.txtEfectivoDisponible.Location = new System.Drawing.Point(626, 34);
            this.txtEfectivoDisponible.Name = "txtEfectivoDisponible";
            this.txtEfectivoDisponible.Size = new System.Drawing.Size(109, 20);
            this.txtEfectivoDisponible.TabIndex = 30;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(771, 413);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(216, 20);
            this.txtTotalPagar.TabIndex = 31;
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.Location = new System.Drawing.Point(332, 34);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxProveedor.Properties.View = this.gridView2;
            this.cbxProveedor.Size = new System.Drawing.Size(131, 20);
            this.cbxProveedor.TabIndex = 0;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Efectivo Disponible:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(667, 416);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Total a Pagar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(779, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Fecha de Emisión:";
            // 
            // dtpFechaEmisión
            // 
            this.dtpFechaEmisión.Enabled = false;
            this.dtpFechaEmisión.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmisión.Location = new System.Drawing.Point(888, 31);
            this.dtpFechaEmisión.Name = "dtpFechaEmisión";
            this.dtpFechaEmisión.Size = new System.Drawing.Size(99, 20);
            this.dtpFechaEmisión.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(779, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha de Emisión:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(888, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbConsultar,
            this.tsbModificar,
            this.tsbAnular,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1006, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbNuevo.ForeColor = System.Drawing.Color.Black;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbGuardar.ForeColor = System.Drawing.Color.Black;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultar.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultar.Image")));
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(78, 22);
            this.tsbConsultar.Text = "Consultar";
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            // 
            // tsbAnular
            // 
            this.tsbAnular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbAnular.ForeColor = System.Drawing.Color.Black;
            this.tsbAnular.Image = ((System.Drawing.Image)(resources.GetObject("tsbAnular.Image")));
            this.tsbAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnular.Name = "tsbAnular";
            this.tsbAnular.Size = new System.Drawing.Size(62, 22);
            this.tsbAnular.Text = "Anular";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // btnGenerarComprobante
            // 
            this.btnGenerarComprobante.Location = new System.Drawing.Point(423, 445);
            this.btnGenerarComprobante.Name = "btnGenerarComprobante";
            this.btnGenerarComprobante.Size = new System.Drawing.Size(160, 30);
            this.btnGenerarComprobante.TabIndex = 1;
            this.btnGenerarComprobante.Text = "Generar Comprobante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nro. Orden de Pago";
            // 
            // textEdit1
            // 
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(116, 34);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(109, 20);
            this.textEdit1.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estado:";
            // 
            // textEdit2
            // 
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(64, 413);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(109, 20);
            this.textEdit2.TabIndex = 30;
            // 
            // frmOrdenPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 482);
            this.Controls.Add(this.btnGenerarComprobante);
            this.Controls.Add(this.gdcOrdenPago);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.txtEfectivoDisponible);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaEmisión);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmOrdenPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden de Pago";
            ((System.ComponentModel.ISupportInitialize)(this.gdcOrdenPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEfectivoDisponible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPagar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxProveedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdcOrdenPago;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colNúmeroRegistroCXP;
        private DevExpress.XtraGrid.Columns.GridColumn colSaldoDeuda;
        private DevExpress.XtraGrid.Columns.GridColumn colValorLetra;
        private DevExpress.XtraGrid.Columns.GridColumn colNroPagosRealizar;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPagar;
        private DevExpress.XtraGrid.Columns.GridColumn colAutorizarPago;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.TextEdit txtEfectivoDisponible;
        private DevExpress.XtraEditors.TextEdit txtTotalPagar;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaEmisión;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripButton tsbAnular;
        private DevExpress.XtraEditors.SimpleButton btnGenerarComprobante;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gdcNumLetrasAPagar;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn gdcFechaVencimiento;
    }
}