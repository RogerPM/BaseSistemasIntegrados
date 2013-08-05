namespace forms.ActivoFijo.Procesos
{
    partial class prcsTransferencia
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.gbxTransferencia = new System.Windows.Forms.GroupBox();
            this.gbxAsignacion = new System.Windows.Forms.GroupBox();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.cbxEmpresa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxDepartamento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btneResponsable = new DevExpress.XtraEditors.ButtonEdit();
            this.lblSucursal = new DevExpress.XtraEditors.LabelControl();
            this.cbxBodegaFutura = new DevExpress.XtraEditors.ComboBoxEdit();
            this.rtbxDetalle = new System.Windows.Forms.RichTextBox();
            this.lblObservacion = new DevExpress.XtraEditors.LabelControl();
            this.lblResponsable = new DevExpress.XtraEditors.LabelControl();
            this.lblDepartamento = new DevExpress.XtraEditors.LabelControl();
            this.cbxTraspaso = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblTraspaso = new DevExpress.XtraEditors.LabelControl();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1.SuspendLayout();
            this.gbxTransferencia.SuspendLayout();
            this.gbxAsignacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBodegaFutura.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTraspaso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnConsultar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(557, 25);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
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
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Anular";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(142, 22);
            this.tslEnBlanco.Text = "                                             ";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxTransferencia
            // 
            this.gbxTransferencia.Controls.Add(this.gbxAsignacion);
            this.gbxTransferencia.Location = new System.Drawing.Point(12, 220);
            this.gbxTransferencia.Name = "gbxTransferencia";
            this.gbxTransferencia.Size = new System.Drawing.Size(525, 179);
            this.gbxTransferencia.TabIndex = 51;
            this.gbxTransferencia.TabStop = false;
            // 
            // gbxAsignacion
            // 
            this.gbxAsignacion.Controls.Add(this.lblEmpresa);
            this.gbxAsignacion.Controls.Add(this.cbxEmpresa);
            this.gbxAsignacion.Controls.Add(this.cbxDepartamento);
            this.gbxAsignacion.Controls.Add(this.btneResponsable);
            this.gbxAsignacion.Controls.Add(this.lblSucursal);
            this.gbxAsignacion.Controls.Add(this.cbxBodegaFutura);
            this.gbxAsignacion.Controls.Add(this.rtbxDetalle);
            this.gbxAsignacion.Controls.Add(this.lblObservacion);
            this.gbxAsignacion.Controls.Add(this.lblResponsable);
            this.gbxAsignacion.Controls.Add(this.lblDepartamento);
            this.gbxAsignacion.Location = new System.Drawing.Point(6, 19);
            this.gbxAsignacion.Name = "gbxAsignacion";
            this.gbxAsignacion.Size = new System.Drawing.Size(493, 126);
            this.gbxAsignacion.TabIndex = 52;
            this.gbxAsignacion.TabStop = false;
            this.gbxAsignacion.Text = "Transfiriendo a";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(24, 22);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 60;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // cbxEmpresa
            // 
            this.cbxEmpresa.Enabled = false;
            this.cbxEmpresa.Location = new System.Drawing.Point(105, 19);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpresa.Size = new System.Drawing.Size(144, 20);
            this.cbxEmpresa.TabIndex = 61;
            // 
            // cbxDepartamento
            // 
            this.cbxDepartamento.Enabled = false;
            this.cbxDepartamento.Location = new System.Drawing.Point(350, 45);
            this.cbxDepartamento.Name = "cbxDepartamento";
            this.cbxDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartamento.Size = new System.Drawing.Size(131, 20);
            this.cbxDepartamento.TabIndex = 59;
            // 
            // btneResponsable
            // 
            this.btneResponsable.Enabled = false;
            this.btneResponsable.Location = new System.Drawing.Point(350, 19);
            this.btneResponsable.Name = "btneResponsable";
            this.btneResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btneResponsable.Size = new System.Drawing.Size(131, 20);
            this.btneResponsable.TabIndex = 58;
            // 
            // lblSucursal
            // 
            this.lblSucursal.Location = new System.Drawing.Point(24, 47);
            this.lblSucursal.Name = "lblSucursal";
            this.lblSucursal.Size = new System.Drawing.Size(75, 13);
            this.lblSucursal.TabIndex = 55;
            this.lblSucursal.Text = "Bodega Futura:";
            // 
            // cbxBodegaFutura
            // 
            this.cbxBodegaFutura.Enabled = false;
            this.cbxBodegaFutura.Location = new System.Drawing.Point(106, 45);
            this.cbxBodegaFutura.Name = "cbxBodegaFutura";
            this.cbxBodegaFutura.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBodegaFutura.Size = new System.Drawing.Size(144, 20);
            this.cbxBodegaFutura.TabIndex = 57;
            // 
            // rtbxDetalle
            // 
            this.rtbxDetalle.Enabled = false;
            this.rtbxDetalle.Location = new System.Drawing.Point(105, 70);
            this.rtbxDetalle.Name = "rtbxDetalle";
            this.rtbxDetalle.Size = new System.Drawing.Size(376, 50);
            this.rtbxDetalle.TabIndex = 56;
            this.rtbxDetalle.Text = "";
            // 
            // lblObservacion
            // 
            this.lblObservacion.Location = new System.Drawing.Point(24, 73);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(64, 13);
            this.lblObservacion.TabIndex = 55;
            this.lblObservacion.Text = "Observacion:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.Location = new System.Drawing.Point(279, 22);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(65, 13);
            this.lblResponsable.TabIndex = 38;
            this.lblResponsable.Text = "Responsable:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.Location = new System.Drawing.Point(271, 47);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(73, 13);
            this.lblDepartamento.TabIndex = 36;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cbxTraspaso
            // 
            this.cbxTraspaso.Location = new System.Drawing.Point(98, 197);
            this.cbxTraspaso.Name = "cbxTraspaso";
            this.cbxTraspaso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTraspaso.Properties.Items.AddRange(new object[] {
            "Bodega",
            "Departamento",
            "Empresa"});
            this.cbxTraspaso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxTraspaso.Size = new System.Drawing.Size(112, 20);
            this.cbxTraspaso.TabIndex = 50;
            this.cbxTraspaso.SelectedIndexChanged += new System.EventHandler(this.cbxTraspaso_SelectedIndexChanged);
            // 
            // lblTraspaso
            // 
            this.lblTraspaso.Location = new System.Drawing.Point(12, 200);
            this.lblTraspaso.Name = "lblTraspaso";
            this.lblTraspaso.Size = new System.Drawing.Size(71, 13);
            this.lblTraspaso.TabIndex = 49;
            this.lblTraspaso.Text = "Tipo Traspaso:";
            // 
            // pnlCargar
            // 
            this.pnlCargar.Location = new System.Drawing.Point(12, 53);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(529, 138);
            this.pnlCargar.TabIndex = 48;
            this.pnlCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCargar_Paint);
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(399, 197);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 135;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(347, 200);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 134;
            this.lblFecha.Text = "Fecha:";
            // 
            // prcsTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 407);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbxTransferencia);
            this.Controls.Add(this.cbxTraspaso);
            this.Controls.Add(this.lblTraspaso);
            this.Controls.Add(this.pnlCargar);
            this.Name = "prcsTransferencia";
            this.Text = "prcsTransferencia";
            this.Load += new System.EventHandler(this.prcsTransferencia_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbxTransferencia.ResumeLayout(false);
            this.gbxAsignacion.ResumeLayout(false);
            this.gbxAsignacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBodegaFutura.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTraspaso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.GroupBox gbxTransferencia;
        private System.Windows.Forms.GroupBox gbxAsignacion;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEmpresa;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDepartamento;
        private DevExpress.XtraEditors.ButtonEdit btneResponsable;
        private DevExpress.XtraEditors.LabelControl lblSucursal;
        private DevExpress.XtraEditors.ComboBoxEdit cbxBodegaFutura;
        private System.Windows.Forms.RichTextBox rtbxDetalle;
        private DevExpress.XtraEditors.LabelControl lblObservacion;
        private DevExpress.XtraEditors.LabelControl lblResponsable;
        private DevExpress.XtraEditors.LabelControl lblDepartamento;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTraspaso;
        private DevExpress.XtraEditors.LabelControl lblTraspaso;
        private System.Windows.Forms.Panel pnlCargar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
    }
}