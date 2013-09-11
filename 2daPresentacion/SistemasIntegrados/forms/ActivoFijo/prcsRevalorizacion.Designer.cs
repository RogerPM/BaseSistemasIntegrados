

namespace forms.ActivoFijo
{
    partial class prcsRevalorizacion
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
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorResidual = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtValorRevalorizado = new DevExpress.XtraEditors.TextEdit();
            this.lblValorRevalorizado = new DevExpress.XtraEditors.LabelControl();
            this.txtValorAdquisicion = new DevExpress.XtraEditors.TextEdit();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.TxtEmpresa = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorResidual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRevalorizado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorAdquisicion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnProcesar.Location = new System.Drawing.Point(368, 123);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(36, 23);
            this.btnProcesar.TabIndex = 294;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(209, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 293;
            this.labelControl3.Text = "V.Residual:";
            // 
            // txtValorResidual
            // 
            this.txtValorResidual.EditValue = "0";
            this.txtValorResidual.Enabled = false;
            this.txtValorResidual.Location = new System.Drawing.Point(276, 126);
            this.txtValorResidual.Name = "txtValorResidual";
            this.txtValorResidual.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValorResidual.Properties.Appearance.Options.UseBackColor = true;
            this.txtValorResidual.Size = new System.Drawing.Size(77, 20);
            this.txtValorResidual.TabIndex = 292;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 291;
            this.labelControl2.Text = "V.Adquisición:";
            // 
            // txtValorRevalorizado
            // 
            this.txtValorRevalorizado.EditValue = "0";
            this.txtValorRevalorizado.Enabled = false;
            this.txtValorRevalorizado.Location = new System.Drawing.Point(118, 140);
            this.txtValorRevalorizado.Name = "txtValorRevalorizado";
            this.txtValorRevalorizado.Size = new System.Drawing.Size(69, 20);
            this.txtValorRevalorizado.TabIndex = 290;
            // 
            // lblValorRevalorizado
            // 
            this.lblValorRevalorizado.Location = new System.Drawing.Point(33, 143);
            this.lblValorRevalorizado.Name = "lblValorRevalorizado";
            this.lblValorRevalorizado.Size = new System.Drawing.Size(76, 13);
            this.lblValorRevalorizado.TabIndex = 289;
            this.lblValorRevalorizado.Text = "V.Revalorizado:";
            // 
            // txtValorAdquisicion
            // 
            this.txtValorAdquisicion.Enabled = false;
            this.txtValorAdquisicion.Location = new System.Drawing.Point(119, 114);
            this.txtValorAdquisicion.Name = "txtValorAdquisicion";
            this.txtValorAdquisicion.Size = new System.Drawing.Size(68, 20);
            this.txtValorAdquisicion.TabIndex = 288;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(312, 85);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 284;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(383, 48);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 283;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(324, 51);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 282;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUsuario.EditValue = "Edwin Estacio Bermeo";
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(118, 78);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Properties.Appearance.Options.UseBackColor = true;
            this.txtUsuario.Size = new System.Drawing.Size(124, 20);
            this.txtUsuario.TabIndex = 281;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(34, 79);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 280;
            this.lblUsuario.Text = "Usuario:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnAnular,
            this.btnConsultar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(528, 25);
            this.toolStrip1.TabIndex = 279;
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
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Enabled = false;
            this.btnAnular.Image = global::forms.Properties.Resources.modificar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(62, 22);
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Image = global::forms.Properties.Resources.consultar;
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(78, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
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
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Location = new System.Drawing.Point(181, 47);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(36, 17);
            this.btnbuscar.TabIndex = 313;
            this.btnbuscar.Text = "...";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(118, 44);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 311;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(34, 47);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(66, 13);
            this.lblCodigoActivo.TabIndex = 312;
            this.lblCodigoActivo.Text = "Codigo Activo";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.EditValue = "TECA";
            this.TxtEmpresa.Enabled = false;
            this.TxtEmpresa.Location = new System.Drawing.Point(383, 82);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtEmpresa.Properties.Appearance.Options.UseBackColor = true;
            this.TxtEmpresa.Size = new System.Drawing.Size(111, 20);
            this.TxtEmpresa.TabIndex = 314;
            // 
            // prcsRevalorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 170);
            this.Controls.Add(this.TxtEmpresa);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtCodigoActivo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtValorResidual);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtValorRevalorizado);
            this.Controls.Add(this.lblValorRevalorizado);
            this.Controls.Add(this.txtValorAdquisicion);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.toolStrip1);
            this.Name = "prcsRevalorizacion";
            this.Text = "prcsRevalorizacion";
            this.Load += new System.EventHandler(this.prcsRevalorizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtValorResidual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorRevalorizado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValorAdquisicion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmpresa.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtValorResidual;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtValorRevalorizado;
        private DevExpress.XtraEditors.LabelControl lblValorRevalorizado;
        private DevExpress.XtraEditors.TextEdit txtValorAdquisicion;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private DevExpress.XtraEditors.TextEdit TxtEmpresa;
    }
}