namespace forms.Cuentasxpagar
{
    partial class frmConsultaPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPagos));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbMonto = new DevExpress.XtraEditors.RadioGroup();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHastaMonto = new DevExpress.XtraEditors.TextEdit();
            this.txtDesdeMonto = new DevExpress.XtraEditors.TextEdit();
            this.txtInferior = new DevExpress.XtraEditors.TextEdit();
            this.txtSuperior = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbfecha = new DevExpress.XtraEditors.RadioGroup();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHastaFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpDesdeFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpEspecifica = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHastaNro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxDesdeNro = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxBanco = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdbGeneral = new DevExpress.XtraEditors.RadioGroup();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultar = new System.Windows.Forms.ToolStripButton();
            this.tsbImprimir = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesdeMonto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInferior.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperior.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfecha.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHastaNro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDesdeNro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBanco.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbGeneral.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 372);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbMonto);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtHastaMonto);
            this.groupBox4.Controls.Add(this.txtDesdeMonto);
            this.groupBox4.Controls.Add(this.txtInferior);
            this.groupBox4.Controls.Add(this.txtSuperior);
            this.groupBox4.Location = new System.Drawing.Point(18, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(464, 110);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Por Monto Pagado";
            // 
            // rdbMonto
            // 
            this.rdbMonto.Location = new System.Drawing.Point(10, 19);
            this.rdbMonto.Name = "rdbMonto";
            this.rdbMonto.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Superior a:"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Inferior a:"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rango")});
            this.rdbMonto.Size = new System.Drawing.Size(125, 85);
            this.rdbMonto.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "-";
            // 
            // txtHastaMonto
            // 
            this.txtHastaMonto.Location = new System.Drawing.Point(308, 81);
            this.txtHastaMonto.Name = "txtHastaMonto";
            this.txtHastaMonto.Size = new System.Drawing.Size(123, 20);
            this.txtHastaMonto.TabIndex = 1;
            // 
            // txtDesdeMonto
            // 
            this.txtDesdeMonto.Location = new System.Drawing.Point(141, 81);
            this.txtDesdeMonto.Name = "txtDesdeMonto";
            this.txtDesdeMonto.Size = new System.Drawing.Size(123, 20);
            this.txtDesdeMonto.TabIndex = 1;
            // 
            // txtInferior
            // 
            this.txtInferior.Location = new System.Drawing.Point(141, 49);
            this.txtInferior.Name = "txtInferior";
            this.txtInferior.Size = new System.Drawing.Size(123, 20);
            this.txtInferior.TabIndex = 1;
            // 
            // txtSuperior
            // 
            this.txtSuperior.Location = new System.Drawing.Point(141, 18);
            this.txtSuperior.Name = "txtSuperior";
            this.txtSuperior.Size = new System.Drawing.Size(123, 20);
            this.txtSuperior.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbfecha);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpHastaFecha);
            this.groupBox3.Controls.Add(this.dtpDesdeFecha);
            this.groupBox3.Controls.Add(this.dtpEspecifica);
            this.groupBox3.Location = new System.Drawing.Point(18, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(464, 78);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Por Fecha";
            // 
            // rdbfecha
            // 
            this.rdbfecha.Location = new System.Drawing.Point(10, 15);
            this.rdbfecha.Name = "rdbfecha";
            this.rdbfecha.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Específica"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rango")});
            this.rdbfecha.Size = new System.Drawing.Size(125, 57);
            this.rdbfecha.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "-";
            // 
            // dtpHastaFecha
            // 
            this.dtpHastaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHastaFecha.Location = new System.Drawing.Point(308, 43);
            this.dtpHastaFecha.Name = "dtpHastaFecha";
            this.dtpHastaFecha.Size = new System.Drawing.Size(123, 20);
            this.dtpHastaFecha.TabIndex = 1;
            // 
            // dtpDesdeFecha
            // 
            this.dtpDesdeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesdeFecha.Location = new System.Drawing.Point(141, 43);
            this.dtpDesdeFecha.Name = "dtpDesdeFecha";
            this.dtpDesdeFecha.Size = new System.Drawing.Size(123, 20);
            this.dtpDesdeFecha.TabIndex = 1;
            // 
            // dtpEspecifica
            // 
            this.dtpEspecifica.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEspecifica.Location = new System.Drawing.Point(141, 15);
            this.dtpEspecifica.Name = "dtpEspecifica";
            this.dtpEspecifica.Size = new System.Drawing.Size(123, 20);
            this.dtpEspecifica.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbxHastaNro);
            this.groupBox2.Controls.Add(this.cbxDesdeNro);
            this.groupBox2.Controls.Add(this.cbxBanco);
            this.groupBox2.Controls.Add(this.rdbGeneral);
            this.groupBox2.Location = new System.Drawing.Point(18, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 116);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "-";
            // 
            // cbxHastaNro
            // 
            this.cbxHastaNro.Location = new System.Drawing.Point(308, 81);
            this.cbxHastaNro.Name = "cbxHastaNro";
            this.cbxHastaNro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxHastaNro.Properties.View = this.gridView2;
            this.cbxHastaNro.Size = new System.Drawing.Size(123, 20);
            this.cbxHastaNro.TabIndex = 16;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // cbxDesdeNro
            // 
            this.cbxDesdeNro.Location = new System.Drawing.Point(141, 81);
            this.cbxDesdeNro.Name = "cbxDesdeNro";
            this.cbxDesdeNro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDesdeNro.Properties.View = this.searchLookUpEdit1View;
            this.cbxDesdeNro.Size = new System.Drawing.Size(123, 20);
            this.cbxDesdeNro.TabIndex = 15;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbxBanco
            // 
            this.cbxBanco.Location = new System.Drawing.Point(141, 50);
            this.cbxBanco.Name = "cbxBanco";
            this.cbxBanco.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBanco.Properties.View = this.gridView3;
            this.cbxBanco.Size = new System.Drawing.Size(123, 20);
            this.cbxBanco.TabIndex = 14;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.Location = new System.Drawing.Point(10, 14);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Todos"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Banco"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Rango de Registros")});
            this.rdbGeneral.Size = new System.Drawing.Size(125, 96);
            this.rdbGeneral.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultar,
            this.tsbImprimir,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(523, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConsultar
            // 
            this.tsbConsultar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultar.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultar.Image = ((System.Drawing.Image)(resources.GetObject("tsbConsultar.Image")));
            this.tsbConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultar.Name = "tsbConsultar";
            this.tsbConsultar.Size = new System.Drawing.Size(78, 22);
            this.tsbConsultar.Text = "Consultar";
            // 
            // tsbImprimir
            // 
            this.tsbImprimir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbImprimir.ForeColor = System.Drawing.Color.Black;
            this.tsbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tsbImprimir.Image")));
            this.tsbImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImprimir.Name = "tsbImprimir";
            this.tsbImprimir.Size = new System.Drawing.Size(68, 22);
            this.tsbImprimir.Text = "Generar";
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            // 
            // frmConsultaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 405);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmConsultaPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Pagos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesdeMonto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInferior.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSuperior.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdbfecha.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxHastaNro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDesdeNro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBanco.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdbGeneral.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.TextEdit txtInferior;
        private DevExpress.XtraEditors.TextEdit txtSuperior;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpEspecifica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.RadioGroup rdbMonto;
        private DevExpress.XtraEditors.RadioGroup rdbfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxHastaNro;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxDesdeNro;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit cbxBanco;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.RadioGroup rdbGeneral;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultar;
        private System.Windows.Forms.ToolStripButton tsbImprimir;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.DateTimePicker dtpHastaFecha;
        private System.Windows.Forms.DateTimePicker dtpDesdeFecha;
        private DevExpress.XtraEditors.TextEdit txtHastaMonto;
        private DevExpress.XtraEditors.TextEdit txtDesdeMonto;
    }
}