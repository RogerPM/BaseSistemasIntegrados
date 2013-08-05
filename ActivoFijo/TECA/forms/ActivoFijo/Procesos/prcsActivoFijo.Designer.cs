namespace forms.ActivoFijo.Procesos
{
    partial class prcsActivoFijo
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
            this.txteCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.cbxEmpresa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.pnlCargar = new System.Windows.Forms.Panel();
            this.txtDescripcion = new DevExpress.XtraEditors.TextEdit();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.cbxEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.lblUsuario = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerarCodBarra = new DevExpress.XtraEditors.SimpleButton();
            this.btnAsignar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txteCodigo
            // 
            this.txteCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txteCodigo.EditValue = "000-001";
            this.txteCodigo.Enabled = false;
            this.txteCodigo.Location = new System.Drawing.Point(115, 40);
            this.txteCodigo.Name = "txteCodigo";
            this.txteCodigo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txteCodigo.Properties.Appearance.Options.UseBackColor = true;
            this.txteCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txteCodigo.Size = new System.Drawing.Size(65, 20);
            this.txteCodigo.TabIndex = 99;
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(31, 42);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(70, 13);
            this.lblCodigoActivo.TabIndex = 98;
            this.lblCodigoActivo.Text = "Codigo Activo:";
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
            this.toolStrip1.Size = new System.Drawing.Size(532, 25);
            this.toolStrip1.TabIndex = 97;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
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
            // cbxEmpresa
            // 
            this.cbxEmpresa.Location = new System.Drawing.Point(380, 112);
            this.cbxEmpresa.Name = "cbxEmpresa";
            this.cbxEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEmpresa.Size = new System.Drawing.Size(111, 20);
            this.cbxEmpresa.TabIndex = 96;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(309, 115);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 95;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // pnlCargar
            // 
            this.pnlCargar.Location = new System.Drawing.Point(11, 193);
            this.pnlCargar.Name = "pnlCargar";
            this.pnlCargar.Size = new System.Drawing.Size(497, 428);
            this.pnlCargar.TabIndex = 94;
            this.pnlCargar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCargar_Paint);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(115, 167);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(376, 20);
            this.txtDescripcion.TabIndex = 93;
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(380, 40);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 92;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(321, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 91;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Location = new System.Drawing.Point(380, 74);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 90;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(317, 77);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 89;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Location = new System.Drawing.Point(115, 141);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Size = new System.Drawing.Size(124, 20);
            this.cbxSubGrupo.TabIndex = 88;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(115, 107);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.Properties.Items.AddRange(new object[] {
            "Articulos/Suministros de Oficinas",
            "Vehiculos",
            "Muebles y Enseres",
            "Edificios",
            "Terrenos",
            "Equipos",
            "Maquinarias"});
            this.cbxGrupo.Size = new System.Drawing.Size(124, 20);
            this.cbxGrupo.TabIndex = 87;
            this.cbxGrupo.SelectedIndexChanged += new System.EventHandler(this.cbxGrupo_SelectedIndexChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(31, 170);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 86;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(31, 144);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 85;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(31, 110);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 84;
            this.lblGrupo.Text = "Grupo:";
            // 
            // textEdit2
            // 
            this.textEdit2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textEdit2.EditValue = "Edwin Estacio Bermeo";
            this.textEdit2.Enabled = false;
            this.textEdit2.Location = new System.Drawing.Point(115, 74);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit2.Size = new System.Drawing.Size(124, 20);
            this.textEdit2.TabIndex = 83;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(31, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 13);
            this.lblUsuario.TabIndex = 82;
            this.lblUsuario.Text = "Usuario:";
            // 
            // btnGenerarCodBarra
            // 
            this.btnGenerarCodBarra.Location = new System.Drawing.Point(162, 636);
            this.btnGenerarCodBarra.Name = "btnGenerarCodBarra";
            this.btnGenerarCodBarra.Size = new System.Drawing.Size(111, 22);
            this.btnGenerarCodBarra.TabIndex = 101;
            this.btnGenerarCodBarra.Text = "Generar Cod.Barra";
            this.btnGenerarCodBarra.Click += new System.EventHandler(this.btnGenerarCodBarra_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(27, 636);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(111, 22);
            this.btnAsignar.TabIndex = 100;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // prcsActivoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 670);
            this.Controls.Add(this.btnGenerarCodBarra);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.txteCodigo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbxEmpresa);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.pnlCargar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbxSubGrupo);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.lblUsuario);
            this.Name = "prcsActivoFijo";
            this.Text = "prcsActivoFijo";
            this.Load += new System.EventHandler(this.prcsActivoFijo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txteCodigo.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txteCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEmpresa;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private System.Windows.Forms.Panel pnlCargar;
        private DevExpress.XtraEditors.TextEdit txtDescripcion;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEstado;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSubGrupo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl lblUsuario;
        private DevExpress.XtraEditors.SimpleButton btnGenerarCodBarra;
        private DevExpress.XtraEditors.SimpleButton btnAsignar;
    }
}