namespace forms.Taller
{
    partial class frmRptHistorialdeReparaciones
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtPlaca = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCliente = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.cbxFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.cbxFechaFin = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaFin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Placa:";
            // 
            // txtPlaca
            // 
            this.txtPlaca.EditValue = "";
            this.txtPlaca.Enabled = false;
            this.txtPlaca.Location = new System.Drawing.Point(83, 39);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(70, 20);
            this.txtPlaca.TabIndex = 21;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(159, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(24, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "...";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(203, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 13);
            this.labelControl2.TabIndex = 26;
            this.labelControl2.Text = "Fecha Fin:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(16, 99);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Fecha Inicio:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 69);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(83, 66);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(184, 20);
            this.txtCliente.TabIndex = 28;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(379, 25);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::forms.Properties.Resources.imprimir;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(68, 22);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
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
            // cbxFechaInicio
            // 
            this.cbxFechaInicio.EditValue = null;
            this.cbxFechaInicio.Location = new System.Drawing.Point(83, 96);
            this.cbxFechaInicio.Name = "cbxFechaInicio";
            this.cbxFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.cbxFechaInicio.TabIndex = 30;
            // 
            // cbxFechaFin
            // 
            this.cbxFechaFin.EditValue = null;
            this.cbxFechaFin.Location = new System.Drawing.Point(259, 96);
            this.cbxFechaFin.Name = "cbxFechaFin";
            this.cbxFechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cbxFechaFin.Size = new System.Drawing.Size(100, 20);
            this.cbxFechaFin.TabIndex = 31;
            // 
            // frmRptHistorialdeReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 130);
            this.Controls.Add(this.cbxFechaFin);
            this.Controls.Add(this.cbxFechaInicio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmRptHistorialdeReparaciones";
            this.Text = "Reporte Historial de Reparaciones";
            this.Load += new System.EventHandler(this.frmRptHistorialdeReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPlaca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCliente.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxFechaFin.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPlaca;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCliente;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.DateEdit cbxFechaInicio;
        private DevExpress.XtraEditors.DateEdit cbxFechaFin;

    }
}