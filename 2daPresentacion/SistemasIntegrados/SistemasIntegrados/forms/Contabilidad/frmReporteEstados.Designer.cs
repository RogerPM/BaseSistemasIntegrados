namespace forms.Contabilidad
{
    partial class frmReporteEstados
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
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnoFiscal = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Desde = new System.Windows.Forms.Label();
            this.dateDesde = new DevExpress.XtraEditors.DateEdit();
            this.dateHasta = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTipoBalance = new System.Windows.Forms.GroupBox();
            this.rdlibrodiario = new System.Windows.Forms.RadioButton();
            this.rdbEstadoResultados = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNivel = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsvwlibrodiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vwlibrodiarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnoFiscal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).BeginInit();
            this.grpTipoBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsvwlibrodiarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwlibrodiarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(513, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::forms.Properties.Resources.generarReporte;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(57, 22);
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Año Fiscal";
            // 
            // cmbAnoFiscal
            // 
            this.cmbAnoFiscal.Location = new System.Drawing.Point(366, 54);
            this.cmbAnoFiscal.Name = "cmbAnoFiscal";
            this.cmbAnoFiscal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbAnoFiscal.Properties.View = this.gridLookUpEdit1View;
            this.cmbAnoFiscal.Size = new System.Drawing.Size(111, 20);
            this.cmbAnoFiscal.TabIndex = 24;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Desde
            // 
            this.Desde.AutoSize = true;
            this.Desde.Location = new System.Drawing.Point(290, 101);
            this.Desde.Name = "Desde";
            this.Desde.Size = new System.Drawing.Size(38, 13);
            this.Desde.TabIndex = 25;
            this.Desde.Text = "Desde";
            // 
            // dateDesde
            // 
            this.dateDesde.EditValue = null;
            this.dateDesde.Location = new System.Drawing.Point(366, 98);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateDesde.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateDesde.Size = new System.Drawing.Size(111, 20);
            this.dateDesde.TabIndex = 26;
            // 
            // dateHasta
            // 
            this.dateHasta.EditValue = null;
            this.dateHasta.Location = new System.Drawing.Point(366, 137);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateHasta.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateHasta.Size = new System.Drawing.Size(111, 20);
            this.dateHasta.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Hasta";
            // 
            // grpTipoBalance
            // 
            this.grpTipoBalance.Controls.Add(this.rdlibrodiario);
            this.grpTipoBalance.Controls.Add(this.rdbEstadoResultados);
            this.grpTipoBalance.Location = new System.Drawing.Point(35, 53);
            this.grpTipoBalance.Name = "grpTipoBalance";
            this.grpTipoBalance.Size = new System.Drawing.Size(228, 104);
            this.grpTipoBalance.TabIndex = 30;
            this.grpTipoBalance.TabStop = false;
            this.grpTipoBalance.Text = "Tipo de Balance";
            // 
            // rdlibrodiario
            // 
            this.rdlibrodiario.AutoSize = true;
            this.rdlibrodiario.Location = new System.Drawing.Point(40, 29);
            this.rdlibrodiario.Name = "rdlibrodiario";
            this.rdlibrodiario.Size = new System.Drawing.Size(78, 17);
            this.rdlibrodiario.TabIndex = 32;
            this.rdlibrodiario.TabStop = true;
            this.rdlibrodiario.Text = "Libro Diario";
            this.rdlibrodiario.UseVisualStyleBackColor = true;
            // 
            // rdbEstadoResultados
            // 
            this.rdbEstadoResultados.AutoSize = true;
            this.rdbEstadoResultados.Location = new System.Drawing.Point(40, 68);
            this.rdbEstadoResultados.Name = "rdbEstadoResultados";
            this.rdbEstadoResultados.Size = new System.Drawing.Size(129, 17);
            this.rdbEstadoResultados.TabIndex = 1;
            this.rdbEstadoResultados.TabStop = true;
            this.rdbEstadoResultados.Text = "Estado de Resultados";
            this.rdbEstadoResultados.UseVisualStyleBackColor = true;
            this.rdbEstadoResultados.CheckedChanged += new System.EventHandler(this.rdbEstadoResultados_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nivel Cuenta";
            // 
            // cmbNivel
            // 
            this.cmbNivel.Location = new System.Drawing.Point(366, 182);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNivel.Properties.View = this.gridView1;
            this.cmbNivel.Size = new System.Drawing.Size(111, 20);
            this.cmbNivel.TabIndex = 32;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // clsvwlibrodiarioBindingSource
            // 
            this.clsvwlibrodiarioBindingSource.DataSource = typeof(clases.Contabilidad.clsvwlibrodiario);
            // 
            // vwlibrodiarioBindingSource
            // 
            this.vwlibrodiarioBindingSource.DataSource = typeof(datos.Contabilidad.vwlibrodiario);
            // 
            // frmReporteEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 244);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpTipoBalance);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.Desde);
            this.Controls.Add(this.cmbAnoFiscal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmReporteEstados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.frmReporteEstados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAnoFiscal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateDesde.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateHasta.Properties)).EndInit();
            this.grpTipoBalance.ResumeLayout(false);
            this.grpTipoBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNivel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsvwlibrodiarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwlibrodiarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cmbAnoFiscal;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label Desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpTipoBalance;
        private System.Windows.Forms.RadioButton rdbEstadoResultados;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit cmbNivel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.RadioButton rdlibrodiario;
        private System.Windows.Forms.BindingSource vwlibrodiarioBindingSource;
        private System.Windows.Forms.BindingSource clsvwlibrodiarioBindingSource;
        public DevExpress.XtraEditors.DateEdit dateDesde;
        public DevExpress.XtraEditors.DateEdit dateHasta;
    }
}