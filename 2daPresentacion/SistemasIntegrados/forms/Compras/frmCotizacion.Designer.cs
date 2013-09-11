namespace forms.Compras
{
    partial class frmCotizacion
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
            this.dtgCotizacionDet = new DevExpress.XtraGrid.GridControl();
            this.detalleCotDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnConsultarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuitarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnRevisarPedidos = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            this.btnaceptar = new System.Windows.Forms.ToolStripButton();
            this.btnProveedor = new DevExpress.XtraEditors.SimpleButton();
            this.txtProveedor1 = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedor2 = new DevExpress.XtraEditors.TextEdit();
            this.txtProveedor3 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotizacionDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCotDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCotizacionDet
            // 
            this.dtgCotizacionDet.Location = new System.Drawing.Point(8, 176);
            this.dtgCotizacionDet.MainView = this.detalleCotDatos;
            this.dtgCotizacionDet.Name = "dtgCotizacionDet";
            this.dtgCotizacionDet.Size = new System.Drawing.Size(629, 186);
            this.dtgCotizacionDet.TabIndex = 96;
            this.dtgCotizacionDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detalleCotDatos});
            // 
            // detalleCotDatos
            // 
            this.detalleCotDatos.GridControl = this.dtgCotizacionDet;
            this.detalleCotDatos.Name = "detalleCotDatos";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(431, 83);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 13);
            this.labelControl5.TabIndex = 94;
            this.labelControl5.Text = "Proveedor 3:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 13);
            this.labelControl4.TabIndex = 92;
            this.labelControl4.Text = "Proveedor 1:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(224, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 13);
            this.labelControl3.TabIndex = 91;
            this.labelControl3.Text = "Proveedor 2:";
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(251, 42);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarPedido.TabIndex = 89;
            this.btnConsultarPedido.Text = "...";
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // btnQuitarPedido
            // 
            this.btnQuitarPedido.Location = new System.Drawing.Point(145, 147);
            this.btnQuitarPedido.Name = "btnQuitarPedido";
            this.btnQuitarPedido.Size = new System.Drawing.Size(131, 23);
            this.btnQuitarPedido.TabIndex = 88;
            this.btnQuitarPedido.Text = "Quitar Pedido";
            // 
            // btnRevisarPedidos
            // 
            this.btnRevisarPedidos.Location = new System.Drawing.Point(8, 147);
            this.btnRevisarPedidos.Name = "btnRevisarPedidos";
            this.btnRevisarPedidos.Size = new System.Drawing.Size(131, 23);
            this.btnRevisarPedidos.TabIndex = 87;
            this.btnRevisarPedidos.Text = "Revisar Pedidos";
            this.btnRevisarPedidos.Click += new System.EventHandler(this.btnRevisarPedidos_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(500, 43);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Procesado"});
            this.cmbEstado.Size = new System.Drawing.Size(123, 20);
            this.cmbEstado.TabIndex = 86;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(100, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 85;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(431, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 84;
            this.labelControl2.Text = "Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "Numero:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnNuevo,
            this.btnSalir,
            this.lblFecha,
            this.btnaceptar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(649, 25);
            this.toolStrip1.TabIndex = 82;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "";
            this.btnGuardar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 22);
            this.btnGuardar.Text = "Enviar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblFecha.ForeColor = System.Drawing.Color.Red;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 22);
            this.lblFecha.Text = "lblFecha";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Image = global::forms.Properties.Resources.add_comment_blue1;
            this.btnaceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(69, 22);
            this.btnaceptar.Text = "Guardar";
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Location = new System.Drawing.Point(480, 133);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(143, 23);
            this.btnProveedor.TabIndex = 97;
            this.btnProveedor.Text = "Escoger Proveedores";
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // txtProveedor1
            // 
            this.txtProveedor1.Location = new System.Drawing.Point(85, 80);
            this.txtProveedor1.Name = "txtProveedor1";
            this.txtProveedor1.Size = new System.Drawing.Size(133, 20);
            this.txtProveedor1.TabIndex = 98;
            // 
            // txtProveedor2
            // 
            this.txtProveedor2.Location = new System.Drawing.Point(293, 80);
            this.txtProveedor2.Name = "txtProveedor2";
            this.txtProveedor2.Size = new System.Drawing.Size(133, 20);
            this.txtProveedor2.TabIndex = 99;
            // 
            // txtProveedor3
            // 
            this.txtProveedor3.Location = new System.Drawing.Point(504, 80);
            this.txtProveedor3.Name = "txtProveedor3";
            this.txtProveedor3.Size = new System.Drawing.Size(133, 20);
            this.txtProveedor3.TabIndex = 100;
            // 
            // frmCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 370);
            this.Controls.Add(this.txtProveedor3);
            this.Controls.Add(this.txtProveedor2);
            this.Controls.Add(this.txtProveedor1);
            this.Controls.Add(this.btnProveedor);
            this.Controls.Add(this.dtgCotizacionDet);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.btnQuitarPedido);
            this.Controls.Add(this.btnRevisarPedidos);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCotizacion";
            this.Text = "frmCotizacion";
            this.Load += new System.EventHandler(this.frmCotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotizacionDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleCotDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProveedor3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgCotizacionDet;
        private DevExpress.XtraGrid.Views.Grid.GridView detalleCotDatos;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnConsultarPedido;
        private DevExpress.XtraEditors.SimpleButton btnQuitarPedido;
        private DevExpress.XtraEditors.SimpleButton btnRevisarPedidos;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel lblFecha;
        private DevExpress.XtraEditors.SimpleButton btnProveedor;
        private DevExpress.XtraEditors.TextEdit txtProveedor1;
        private DevExpress.XtraEditors.TextEdit txtProveedor2;
        private DevExpress.XtraEditors.TextEdit txtProveedor3;
        private System.Windows.Forms.ToolStripButton btnaceptar;
    }
}