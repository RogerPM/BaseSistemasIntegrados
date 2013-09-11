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
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnAsignar = new DevExpress.XtraEditors.SimpleButton();
            this.cbxSubGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblSubGrupo = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Enabled = false;
            this.dateEdit2.Location = new System.Drawing.Point(350, 60);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(111, 20);
            this.dateEdit2.TabIndex = 92;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(311, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 91;
            this.labelControl2.Text = "Fecha:";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(167, 186);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(111, 22);
            this.btnAsignar.TabIndex = 90;
            this.btnAsignar.Text = "Consultar";
            // 
            // cbxSubGrupo
            // 
            this.cbxSubGrupo.Location = new System.Drawing.Point(99, 82);
            this.cbxSubGrupo.Name = "cbxSubGrupo";
            this.cbxSubGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubGrupo.Size = new System.Drawing.Size(112, 20);
            this.cbxSubGrupo.TabIndex = 89;
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.Location = new System.Drawing.Point(99, 60);
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
            this.cbxGrupo.Size = new System.Drawing.Size(112, 20);
            this.cbxGrupo.TabIndex = 88;
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.Location = new System.Drawing.Point(15, 85);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(51, 13);
            this.lblSubGrupo.TabIndex = 87;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(15, 63);
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
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(350, 137);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(111, 20);
            this.dateEdit1.TabIndex = 84;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(267, 140);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 83;
            this.labelControl1.Text = "Fecha Hasta:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(100, 137);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 82;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(17, 140);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 13);
            this.lblFecha.TabIndex = 81;
            this.lblFecha.Text = "Fecha Desde:";
            // 
            // RptInventarioDisponible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 224);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.cbxSubGrupo);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblSubGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Name = "RptInventarioDisponible";
            this.Text = "InventarioDisponible";
            this.Load += new System.EventHandler(this.InventarioDisponible_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnAsignar;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSubGrupo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblSubGrupo;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;


    }
}