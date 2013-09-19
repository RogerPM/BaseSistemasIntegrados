namespace forms.ActivoFijo
{
    partial class RptInventarioDisponible
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
            this.btnCOnsultarGeneral = new DevExpress.XtraEditors.SimpleButton();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaRegistro = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaAdquisicion = new DevExpress.XtraEditors.LabelControl();
            this.btnCOnsultaEspecifica = new DevExpress.XtraEditors.SimpleButton();
            this.Buscar = new DevExpress.XtraEditors.SimpleButton();
            this.txtGrupo = new DevExpress.XtraEditors.TextEdit();
            this.txtSubGrupo = new DevExpress.XtraEditors.TextEdit();
            this.dtFechaAdquisicion = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAdquisicion.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAdquisicion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCOnsultarGeneral
            // 
            this.btnCOnsultarGeneral.Location = new System.Drawing.Point(344, 116);
            this.btnCOnsultarGeneral.Name = "btnCOnsultarGeneral";
            this.btnCOnsultarGeneral.Size = new System.Drawing.Size(111, 22);
            this.btnCOnsultarGeneral.TabIndex = 90;
            this.btnCOnsultarGeneral.Text = "Consultar General";
            this.btnCOnsultarGeneral.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(17, 91);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 87;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(16, 68);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 86;
            this.lblGrupo.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Inventario Disponible";
            // 
            // dtFechaRegistro
            // 
            this.dtFechaRegistro.EditValue = null;
            this.dtFechaRegistro.Location = new System.Drawing.Point(112, 136);
            this.dtFechaRegistro.Name = "dtFechaRegistro";
            this.dtFechaRegistro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaRegistro.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaRegistro.Size = new System.Drawing.Size(110, 20);
            this.dtFechaRegistro.TabIndex = 84;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 139);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 13);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "Fecha Registro:";
            // 
            // lblFechaAdquisicion
            // 
            this.lblFechaAdquisicion.Location = new System.Drawing.Point(17, 116);
            this.lblFechaAdquisicion.Name = "lblFechaAdquisicion";
            this.lblFechaAdquisicion.Size = new System.Drawing.Size(89, 13);
            this.lblFechaAdquisicion.TabIndex = 81;
            this.lblFechaAdquisicion.Text = "Fecha Adquisicion:";
            // 
            // btnCOnsultaEspecifica
            // 
            this.btnCOnsultaEspecifica.Location = new System.Drawing.Point(344, 80);
            this.btnCOnsultaEspecifica.Name = "btnCOnsultaEspecifica";
            this.btnCOnsultaEspecifica.Size = new System.Drawing.Size(111, 22);
            this.btnCOnsultaEspecifica.TabIndex = 91;
            this.btnCOnsultaEspecifica.Text = "ConsultaEspecifica";
            this.btnCOnsultaEspecifica.Click += new System.EventHandler(this.btnCOnsultaEspecifica_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(228, 63);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(57, 22);
            this.Buscar.TabIndex = 92;
            this.Buscar.Text = "...";
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(111, 65);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(111, 20);
            this.txtGrupo.TabIndex = 93;
           // this.txtGrupo.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // txtSubGrupo
            // 
            this.txtSubGrupo.Location = new System.Drawing.Point(112, 88);
            this.txtSubGrupo.Name = "txtSubGrupo";
            this.txtSubGrupo.Size = new System.Drawing.Size(111, 20);
            this.txtSubGrupo.TabIndex = 94;
            // 
            // dtFechaAdquisicion
            // 
            this.dtFechaAdquisicion.EditValue = null;
            this.dtFechaAdquisicion.Location = new System.Drawing.Point(112, 112);
            this.dtFechaAdquisicion.Name = "dtFechaAdquisicion";
            this.dtFechaAdquisicion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFechaAdquisicion.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFechaAdquisicion.Size = new System.Drawing.Size(110, 20);
            this.dtFechaAdquisicion.TabIndex = 96;
            // 
            // RptInventarioDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 172);
            this.Controls.Add(this.dtFechaAdquisicion);
            this.Controls.Add(this.txtSubGrupo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.btnCOnsultaEspecifica);
            this.Controls.Add(this.btnCOnsultarGeneral);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFechaRegistro);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblFechaAdquisicion);
            this.Name = "RptInventarioDisponible";
            this.Text = "InventarioDisponible";
            this.Load += new System.EventHandler(this.InventarioDisponible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAdquisicion.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFechaAdquisicion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCOnsultarGeneral;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtFechaRegistro;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblFechaAdquisicion;
        private DevExpress.XtraEditors.SimpleButton btnCOnsultaEspecifica;
        private DevExpress.XtraEditors.SimpleButton Buscar;
        private DevExpress.XtraEditors.TextEdit txtGrupo;
        private DevExpress.XtraEditors.TextEdit txtSubGrupo;
        private DevExpress.XtraEditors.DateEdit dtFechaAdquisicion;


    }
}