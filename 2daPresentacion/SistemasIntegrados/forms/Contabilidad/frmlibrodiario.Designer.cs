namespace forms.Contabilidad
{
    partial class frmlibrodiario
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
            this.btnGenerar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnumero_comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colglosa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtfechafin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechaini = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGenerar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(672, 25);
            this.toolStrip1.TabIndex = 23;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::forms.Properties.Resources.imprimir;
            this.btnGenerar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(73, 22);
            this.btnGenerar.Text = "Imprimir";
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click_1);
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 80);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 300);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnumero_comprobante,
            this.colfecha,
            this.colglosa,
            this.colcuenta,
            this.colnombre,
            this.coldebe,
            this.colhaber});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // colnumero_comprobante
            // 
            this.colnumero_comprobante.FieldName = "numero_comprobante";
            this.colnumero_comprobante.Name = "colnumero_comprobante";
            this.colnumero_comprobante.Visible = true;
            this.colnumero_comprobante.VisibleIndex = 0;
            this.colnumero_comprobante.Width = 123;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 81;
            // 
            // colglosa
            // 
            this.colglosa.FieldName = "glosa";
            this.colglosa.Name = "colglosa";
            this.colglosa.Visible = true;
            this.colglosa.VisibleIndex = 2;
            this.colglosa.Width = 81;
            // 
            // colcuenta
            // 
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 3;
            this.colcuenta.Width = 81;
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 4;
            this.colnombre.Width = 81;
            // 
            // coldebe
            // 
            this.coldebe.FieldName = "debe";
            this.coldebe.Name = "coldebe";
            this.coldebe.Visible = true;
            this.coldebe.VisibleIndex = 5;
            this.coldebe.Width = 81;
            // 
            // colhaber
            // 
            this.colhaber.FieldName = "haber";
            this.colhaber.Name = "colhaber";
            this.colhaber.Visible = true;
            this.colhaber.VisibleIndex = 6;
            this.colhaber.Width = 93;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Visible = true;
            this.colIdEmpresa.VisibleIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtfechafin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtfechaini);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 39);
            this.panel1.TabIndex = 35;
            // 
            // txtfechafin
            // 
            this.txtfechafin.Location = new System.Drawing.Point(351, 11);
            this.txtfechafin.Name = "txtfechafin";
            this.txtfechafin.ReadOnly = true;
            this.txtfechafin.Size = new System.Drawing.Size(67, 20);
            this.txtfechafin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Final:";
            // 
            // txtfechaini
            // 
            this.txtfechaini.Location = new System.Drawing.Point(198, 11);
            this.txtfechaini.Name = "txtfechaini";
            this.txtfechaini.ReadOnly = true;
            this.txtfechaini.Size = new System.Drawing.Size(56, 20);
            this.txtfechaini.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-2, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango de Fecha:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmlibrodiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmlibrodiario";
            this.Text = "Reporte_Consulta Libro Diario";
            this.Load += new System.EventHandler(this.frmlibrodiario_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGenerar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colglosa;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldebe;
        private DevExpress.XtraGrid.Columns.GridColumn colhaber;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechaini;
        private System.Windows.Forms.TextBox txtfechafin;
        private System.Windows.Forms.Label label3;
    }
}