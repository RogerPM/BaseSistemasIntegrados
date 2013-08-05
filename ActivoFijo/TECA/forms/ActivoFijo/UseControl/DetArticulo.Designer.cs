namespace forms.ActivoFijo.UseControl
{
    partial class DetArticulo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txteCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblFactura = new DevExpress.XtraEditors.LabelControl();
            this.btneProveedor = new DevExpress.XtraEditors.ButtonEdit();
            this.lblProveedor = new DevExpress.XtraEditors.LabelControl();
            this.gbxDetalleArticulosSuministros = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.lblCantidad = new DevExpress.XtraEditors.LabelControl();
            this.cbxColor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxMarca = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxMaterial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblMaterial = new DevExpress.XtraEditors.LabelControl();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            this.cbxModelo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblModelo = new DevExpress.XtraEditors.LabelControl();
            this.lblMarca = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneProveedor.Properties)).BeginInit();
            this.gbxDetalleArticulosSuministros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaterial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxModelo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txteCodigo
            // 
            this.txteCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteCodigo.EditValue = "000-001";
            this.txteCodigo.Enabled = false;
            this.txteCodigo.Location = new System.Drawing.Point(371, 26);
            this.txteCodigo.Name = "txteCodigo";
            this.txteCodigo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txteCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteCodigo.Size = new System.Drawing.Size(75, 20);
            this.txteCodigo.TabIndex = 97;
            // 
            // lblFactura
            // 
            this.lblFactura.Location = new System.Drawing.Point(301, 29);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(41, 13);
            this.lblFactura.TabIndex = 96;
            this.lblFactura.Text = "Factura:";
            // 
            // btneProveedor
            // 
            this.btneProveedor.Location = new System.Drawing.Point(99, 26);
            this.btneProveedor.Name = "btneProveedor";
            this.btneProveedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneProveedor.Size = new System.Drawing.Size(130, 20);
            this.btneProveedor.TabIndex = 95;
            // 
            // lblProveedor
            // 
            this.lblProveedor.Location = new System.Drawing.Point(18, 29);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(54, 13);
            this.lblProveedor.TabIndex = 94;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // gbxDetalleArticulosSuministros
            // 
            this.gbxDetalleArticulosSuministros.Controls.Add(this.txtCantidad);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.lblCantidad);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.cbxColor);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.cbxMarca);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.cbxMaterial);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.lblMaterial);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.lblColor);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.cbxModelo);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.lblModelo);
            this.gbxDetalleArticulosSuministros.Controls.Add(this.lblMarca);
            this.gbxDetalleArticulosSuministros.Location = new System.Drawing.Point(12, 58);
            this.gbxDetalleArticulosSuministros.Name = "gbxDetalleArticulosSuministros";
            this.gbxDetalleArticulosSuministros.Size = new System.Drawing.Size(489, 141);
            this.gbxDetalleArticulosSuministros.TabIndex = 93;
            this.gbxDetalleArticulosSuministros.TabStop = false;
            this.gbxDetalleArticulosSuministros.Text = "Detalle Articulos/Suministros";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(238, 27);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(79, 20);
            this.txtCantidad.TabIndex = 96;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(173, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(47, 13);
            this.lblCantidad.TabIndex = 95;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cbxColor
            // 
            this.cbxColor.Location = new System.Drawing.Point(326, 56);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxColor.Size = new System.Drawing.Size(111, 20);
            this.cbxColor.TabIndex = 94;
            // 
            // cbxMarca
            // 
            this.cbxMarca.Location = new System.Drawing.Point(87, 60);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMarca.Size = new System.Drawing.Size(111, 20);
            this.cbxMarca.TabIndex = 93;
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.Location = new System.Drawing.Point(326, 94);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMaterial.Size = new System.Drawing.Size(111, 20);
            this.cbxMaterial.TabIndex = 92;
            // 
            // lblMaterial
            // 
            this.lblMaterial.Location = new System.Drawing.Point(275, 101);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(42, 13);
            this.lblMaterial.TabIndex = 91;
            this.lblMaterial.Text = "Material:";
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(274, 63);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(29, 13);
            this.lblColor.TabIndex = 90;
            this.lblColor.Text = "Color:";
            // 
            // cbxModelo
            // 
            this.cbxModelo.Location = new System.Drawing.Point(87, 94);
            this.cbxModelo.Name = "cbxModelo";
            this.cbxModelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxModelo.Size = new System.Drawing.Size(111, 20);
            this.cbxModelo.TabIndex = 89;
            // 
            // lblModelo
            // 
            this.lblModelo.Location = new System.Drawing.Point(32, 101);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(38, 13);
            this.lblModelo.TabIndex = 85;
            this.lblModelo.Text = "Modelo:";
            // 
            // lblMarca
            // 
            this.lblMarca.Location = new System.Drawing.Point(32, 63);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(33, 13);
            this.lblMarca.TabIndex = 84;
            this.lblMarca.Text = "Marca:";
            // 
            // DetArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txteCodigo);
            this.Controls.Add(this.lblFactura);
            this.Controls.Add(this.btneProveedor);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.gbxDetalleArticulosSuministros);
            this.Name = "DetArticulo";
            this.Size = new System.Drawing.Size(512, 225);
            this.Load += new System.EventHandler(this.DetArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneProveedor.Properties)).EndInit();
            this.gbxDetalleArticulosSuministros.ResumeLayout(false);
            this.gbxDetalleArticulosSuministros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxColor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMaterial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxModelo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txteCodigo;
        private DevExpress.XtraEditors.LabelControl lblFactura;
        private DevExpress.XtraEditors.ButtonEdit btneProveedor;
        private DevExpress.XtraEditors.LabelControl lblProveedor;
        private System.Windows.Forms.GroupBox gbxDetalleArticulosSuministros;
        private DevExpress.XtraEditors.TextEdit txtCantidad;
        private DevExpress.XtraEditors.LabelControl lblCantidad;
        private DevExpress.XtraEditors.ComboBoxEdit cbxColor;
        private DevExpress.XtraEditors.ComboBoxEdit cbxMarca;
        private DevExpress.XtraEditors.ComboBoxEdit cbxMaterial;
        private DevExpress.XtraEditors.LabelControl lblMaterial;
        private DevExpress.XtraEditors.LabelControl lblColor;
        private DevExpress.XtraEditors.ComboBoxEdit cbxModelo;
        private DevExpress.XtraEditors.LabelControl lblModelo;
        private DevExpress.XtraEditors.LabelControl lblMarca;
    }
}
