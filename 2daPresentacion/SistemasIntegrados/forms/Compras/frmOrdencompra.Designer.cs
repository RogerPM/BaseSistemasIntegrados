namespace forms.Compras
{
    partial class frmOrdencompra
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
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnConsultarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.btnRevisarCotizaciones = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotizacionDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCotizacionDet
            // 
            this.dtgCotizacionDet.Location = new System.Drawing.Point(11, 108);
            this.dtgCotizacionDet.MainView = this.gridView3;
            this.dtgCotizacionDet.Name = "dtgCotizacionDet";
            this.dtgCotizacionDet.Size = new System.Drawing.Size(609, 180);
            this.dtgCotizacionDet.TabIndex = 105;
            this.dtgCotizacionDet.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.dtgCotizacionDet;
            this.gridView3.Name = "gridView3";
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(243, 42);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarPedido.TabIndex = 104;
            this.btnConsultarPedido.Text = "...";
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // btnRevisarCotizaciones
            // 
            this.btnRevisarCotizaciones.Location = new System.Drawing.Point(30, 79);
            this.btnRevisarCotizaciones.Name = "btnRevisarCotizaciones";
            this.btnRevisarCotizaciones.Size = new System.Drawing.Size(131, 23);
            this.btnRevisarCotizaciones.TabIndex = 102;
            this.btnRevisarCotizaciones.Text = "Revisar Cotizacion";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(474, 43);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Procesado"});
            this.cmbEstado.Size = new System.Drawing.Size(123, 20);
            this.cmbEstado.TabIndex = 101;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(92, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 100;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(405, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 99;
            this.labelControl2.Text = "Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 98;
            this.labelControl1.Text = "Numero:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnNuevo,
            this.btnModificar,
            this.btnSalir,
            this.lblFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(632, 25);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "Generar Solicitud";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleName = "";
            this.btnGuardar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
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
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 22);
            this.lblFecha.Text = "lblFecha";
            // 
            // frmOrdencompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 306);
            this.Controls.Add(this.dtgCotizacionDet);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.btnRevisarCotizaciones);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmOrdencompra";
            this.Text = "frmOrdencompra";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCotizacionDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dtgCotizacionDet;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton btnConsultarPedido;
        private DevExpress.XtraEditors.SimpleButton btnRevisarCotizaciones;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel lblFecha;
    }
}