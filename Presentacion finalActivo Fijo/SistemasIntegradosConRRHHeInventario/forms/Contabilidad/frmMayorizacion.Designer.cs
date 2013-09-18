namespace forms.Contabilidad
{
    partial class frmMayorizacion
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dateFin = new DevExpress.XtraEditors.DateEdit();
            this.dateInicio = new DevExpress.XtraEditors.DateEdit();
            this.lblFinal = new DevExpress.XtraEditors.LabelControl();
            this.lblInicio = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.gcMayorizacion = new DevExpress.XtraGrid.GridControl();
            this.clsvwComprobanteMayorizarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvMayorizacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero_comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colglosa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInicio.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayorizacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsvwComprobanteMayorizarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayorizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(535, 406);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(36, 13);
            this.labelControl6.TabIndex = 29;
            this.labelControl6.Text = "Usuario";
            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl2.Controls.Add(this.dateFin);
            this.panelControl2.Controls.Add(this.dateInicio);
            this.panelControl2.Controls.Add(this.lblFinal);
            this.panelControl2.Controls.Add(this.lblInicio);
            this.panelControl2.Location = new System.Drawing.Point(31, 39);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(512, 100);
            this.panelControl2.TabIndex = 28;
            // 
            // dateFin
            // 
            this.dateFin.EditValue = null;
            this.dateFin.Location = new System.Drawing.Point(341, 39);
            this.dateFin.Name = "dateFin";
            this.dateFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFin.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateFin.Size = new System.Drawing.Size(100, 20);
            this.dateFin.TabIndex = 5;
            this.dateFin.EditValueChanged += new System.EventHandler(this.dateFin_EditValueChanged);
            // 
            // dateInicio
            // 
            this.dateInicio.EditValue = null;
            this.dateInicio.Location = new System.Drawing.Point(138, 39);
            this.dateInicio.Name = "dateInicio";
            this.dateInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateInicio.Size = new System.Drawing.Size(100, 20);
            this.dateInicio.TabIndex = 4;
            this.dateInicio.EditValueChanged += new System.EventHandler(this.dateFin_EditValueChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.Location = new System.Drawing.Point(268, 42);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(58, 13);
            this.lblFinal.TabIndex = 1;
            this.lblFinal.Text = "Fecha Final:";
            // 
            // lblInicio
            // 
            this.lblInicio.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(67, 42);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(63, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Fecha Inicial:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnAnular,
            this.btnModificar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 25);
            this.toolStrip1.TabIndex = 26;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(59, 22);
            this.btnGuardar.Text = "Procesar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::forms.Properties.Resources.eliminar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(42, 22);
            this.btnAnular.Text = "Salir";
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Modificar";
            // 
            // gcMayorizacion
            // 
            this.gcMayorizacion.DataSource = this.clsvwComprobanteMayorizarBindingSource;
            this.gcMayorizacion.Location = new System.Drawing.Point(12, 159);
            this.gcMayorizacion.MainView = this.gvMayorizacion;
            this.gcMayorizacion.Name = "gcMayorizacion";
            this.gcMayorizacion.Size = new System.Drawing.Size(559, 241);
            this.gcMayorizacion.TabIndex = 30;
            this.gcMayorizacion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvMayorizacion});
            // 
            // clsvwComprobanteMayorizarBindingSource
            // 
            this.clsvwComprobanteMayorizarBindingSource.DataSource = typeof(clases.Contabilidad.clsvwComprobanteMayorizar);
            // 
            // gvMayorizacion
            // 
            this.gvMayorizacion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colnumero_comprobante,
            this.colfecha,
            this.coldebe,
            this.colhaber,
            this.colglosa,
            this.colcheck});
            this.gvMayorizacion.GridControl = this.gcMayorizacion;
            this.gvMayorizacion.Name = "gvMayorizacion";
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colnumero_comprobante
            // 
            this.colnumero_comprobante.FieldName = "numero_comprobante";
            this.colnumero_comprobante.Name = "colnumero_comprobante";
            this.colnumero_comprobante.Visible = true;
            this.colnumero_comprobante.VisibleIndex = 1;
            this.colnumero_comprobante.Width = 278;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.Name = "colfecha";
            // 
            // coldebe
            // 
            this.coldebe.FieldName = "debe";
            this.coldebe.Name = "coldebe";
            this.coldebe.OptionsColumn.AllowEdit = false;
            this.coldebe.Visible = true;
            this.coldebe.VisibleIndex = 3;
            this.coldebe.Width = 278;
            // 
            // colhaber
            // 
            this.colhaber.FieldName = "haber";
            this.colhaber.Name = "colhaber";
            this.colhaber.OptionsColumn.AllowEdit = false;
            this.colhaber.Visible = true;
            this.colhaber.VisibleIndex = 4;
            this.colhaber.Width = 279;
            // 
            // colglosa
            // 
            this.colglosa.FieldName = "glosa";
            this.colglosa.Name = "colglosa";
            this.colglosa.OptionsColumn.AllowEdit = false;
            this.colglosa.Visible = true;
            this.colglosa.VisibleIndex = 2;
            this.colglosa.Width = 278;
            // 
            // colcheck
            // 
            this.colcheck.Caption = "#";
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 67;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(559, -31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // frmMayorizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 445);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gcMayorizacion);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMayorizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mayorizar";
            this.Load += new System.EventHandler(this.frmMayorizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInicio.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMayorizacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsvwComprobanteMayorizarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvMayorizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.DateEdit dateFin;
        private DevExpress.XtraEditors.DateEdit dateInicio;
        private DevExpress.XtraEditors.LabelControl lblFinal;
        private DevExpress.XtraEditors.LabelControl lblInicio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private DevExpress.XtraGrid.GridControl gcMayorizacion;
        private DevExpress.XtraGrid.Views.Grid.GridView gvMayorizacion;
        private System.Windows.Forms.BindingSource clsvwComprobanteMayorizarBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero_comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn coldebe;
        private DevExpress.XtraGrid.Columns.GridColumn colhaber;
        private DevExpress.XtraGrid.Columns.GridColumn colglosa;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private System.Windows.Forms.TextBox textBox1;
    }
}