namespace forms.Compras
{
    partial class frmConsolidacionPedidos
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
            this.btnConsultarPedido = new DevExpress.XtraEditors.SimpleButton();
            this.cmbTipoArticulo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnQuitarSolicitud = new DevExpress.XtraEditors.SimpleButton();
            this.btnRevisarSolicitudes = new DevExpress.XtraEditors.SimpleButton();
            this.dtgPedidoDetalle = new DevExpress.XtraGrid.GridControl();
            this.DatosPedidoDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNumero = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.lblFecha = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPedidoDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarPedido
            // 
            this.btnConsultarPedido.Location = new System.Drawing.Point(252, 39);
            this.btnConsultarPedido.Name = "btnConsultarPedido";
            this.btnConsultarPedido.Size = new System.Drawing.Size(36, 23);
            this.btnConsultarPedido.TabIndex = 74;
            this.btnConsultarPedido.Text = "...";
            this.btnConsultarPedido.Click += new System.EventHandler(this.btnConsultarPedido_Click);
            // 
            // cmbTipoArticulo
            // 
            this.cmbTipoArticulo.Location = new System.Drawing.Point(406, 36);
            this.cmbTipoArticulo.Name = "cmbTipoArticulo";
            this.cmbTipoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTipoArticulo.Properties.Items.AddRange(new object[] {
            "SuministrosdeOficina",
            "SuministrosdeLimpieza",
            "Mercaderia",
            "ActivoFijo"});
            this.cmbTipoArticulo.Size = new System.Drawing.Size(116, 20);
            this.cmbTipoArticulo.TabIndex = 72;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(322, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 13);
            this.labelControl8.TabIndex = 71;
            this.labelControl8.Text = "Tipo de Articulo:";
            // 
            // btnQuitarSolicitud
            // 
            this.btnQuitarSolicitud.Location = new System.Drawing.Point(144, 91);
            this.btnQuitarSolicitud.Name = "btnQuitarSolicitud";
            this.btnQuitarSolicitud.Size = new System.Drawing.Size(131, 23);
            this.btnQuitarSolicitud.TabIndex = 70;
            this.btnQuitarSolicitud.Text = "Quitar Solicitud";
            // 
            // btnRevisarSolicitudes
            // 
            this.btnRevisarSolicitudes.Location = new System.Drawing.Point(9, 91);
            this.btnRevisarSolicitudes.Name = "btnRevisarSolicitudes";
            this.btnRevisarSolicitudes.Size = new System.Drawing.Size(131, 23);
            this.btnRevisarSolicitudes.TabIndex = 69;
            this.btnRevisarSolicitudes.Text = "Revisar Solicitudes";
            this.btnRevisarSolicitudes.Click += new System.EventHandler(this.btnRevisarSolicitudes_Click);
            // 
            // dtgPedidoDetalle
            // 
            this.dtgPedidoDetalle.Location = new System.Drawing.Point(7, 132);
            this.dtgPedidoDetalle.MainView = this.DatosPedidoDetalle;
            this.dtgPedidoDetalle.Name = "dtgPedidoDetalle";
            this.dtgPedidoDetalle.Size = new System.Drawing.Size(517, 196);
            this.dtgPedidoDetalle.TabIndex = 68;
            this.dtgPedidoDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DatosPedidoDetalle,
            this.bandedGridView1});
            this.dtgPedidoDetalle.Click += new System.EventHandler(this.dtgPedidoDetalle_Click);
            // 
            // DatosPedidoDetalle
            // 
            this.DatosPedidoDetalle.GridControl = this.dtgPedidoDetalle;
            this.DatosPedidoDetalle.Name = "DatosPedidoDetalle";
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.GridControl = this.dtgPedidoDetalle;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(257, 182);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 23);
            this.btnBuscar.TabIndex = 67;
            this.btnBuscar.Text = "...";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(406, 65);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Activo",
            "Inactivo",
            "Procesado"});
            this.cmbEstado.Size = new System.Drawing.Size(116, 20);
            this.cmbEstado.TabIndex = 66;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(101, 40);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(145, 20);
            this.txtNumero.TabIndex = 65;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(322, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 64;
            this.labelControl2.Text = "Estado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 63;
            this.labelControl1.Text = "Numero:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnNuevo,
            this.btnAnular,
            this.btnSalir,
            this.btnModificar,
            this.lblFecha});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 25);
            this.toolStrip1.TabIndex = 62;
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
            // btnAnular
            // 
            this.btnAnular.Image = global::forms.Properties.Resources.eliminar1;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
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
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.edit_comment_blue;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblFecha.ForeColor = System.Drawing.Color.Red;
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(51, 22);
            this.lblFecha.Text = "lblFecha";
            // 
            // frmConsolidacionPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 341);
            this.Controls.Add(this.btnConsultarPedido);
            this.Controls.Add(this.cmbTipoArticulo);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnQuitarSolicitud);
            this.Controls.Add(this.btnRevisarSolicitudes);
            this.Controls.Add(this.dtgPedidoDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsolidacionPedidos";
            this.Text = "frmConsolidacionPedidos";
            this.Load += new System.EventHandler(this.frmConsolidacionPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbTipoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPedidoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPedidoDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnConsultarPedido;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipoArticulo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnQuitarSolicitud;
        private DevExpress.XtraEditors.SimpleButton btnRevisarSolicitudes;
        private DevExpress.XtraGrid.GridControl dtgPedidoDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView DatosPedidoDetalle;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TextEdit txtNumero;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripLabel lblFecha;
        private System.Windows.Forms.ToolStripButton btnModificar;
    }
}