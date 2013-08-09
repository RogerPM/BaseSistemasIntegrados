using forms.Contabilidad;
namespace forms.Contabilidad
{
    partial class frmTipoTransaccion
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
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.clsModuloBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.clsModuloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clsModuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsModuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moduloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new forms.Contabilidad.DataSet1();
            this.lblModulo = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.moduloTableAdapter = new forms.Contabilidad.DataSet1TableAdapters.ModuloTableAdapter();
            this.tipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsTipoTransaccionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clsTipoTransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdTransaccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoDocumento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsTipoTransaccionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbModulo
            // 
            this.cmbModulo.DataSource = this.clsModuloBindingSource3;
            this.cmbModulo.DisplayMember = "Nombre";
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(217, 57);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(161, 21);
            this.cmbModulo.TabIndex = 30;
            this.cmbModulo.ValueMember = "IdModulo";
            this.cmbModulo.SelectedIndexChanged += new System.EventHandler(this.cmbModulo_SelectedIndexChanged);
            // 
            // clsModuloBindingSource3
            // 
            this.clsModuloBindingSource3.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // clsModuloBindingSource2
            // 
            this.clsModuloBindingSource2.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // clsModuloBindingSource
            // 
            this.clsModuloBindingSource.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // clsModuloBindingSource1
            // 
            this.clsModuloBindingSource1.DataSource = typeof(clases.Contabilidad.clsModulo);
            // 
            // moduloBindingSource
            // 
            this.moduloBindingSource.DataMember = "Modulo";
            this.moduloBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(159, 60);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(42, 13);
            this.lblModulo.TabIndex = 29;
            this.lblModulo.Text = "Modulo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(546, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::forms.Properties.Resources.buscar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(78, 22);
            this.toolStripButton1.Text = "Consultar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // moduloTableAdapter
            // 
            this.moduloTableAdapter.ClearBeforeFill = true;
            // 
            // tipoTransaccionBindingSource
            // 
            this.tipoTransaccionBindingSource.DataSource = typeof(datos.Contabilidad.TipoTransaccion);
            // 
            // clsTipoTransaccionBindingSource1
            // 
            this.clsTipoTransaccionBindingSource1.DataSource = typeof(clases.Contabilidad.clsTipoTransaccion);
            // 
            // clsTipoTransaccionBindingSource
            // 
            this.clsTipoTransaccionBindingSource.DataSource = typeof(clases.Contabilidad.clsTipoTransaccion);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.moduloBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 98);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 196);
            this.gridControl1.TabIndex = 33;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdTransaccion,
            this.colTipoDocumento,
            this.coldescripcion});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIdTransaccion
            // 
            this.colIdTransaccion.FieldName = "IdTransaccion";
            this.colIdTransaccion.Name = "colIdTransaccion";
            this.colIdTransaccion.OptionsColumn.AllowEdit = false;
            this.colIdTransaccion.Visible = true;
            this.colIdTransaccion.VisibleIndex = 0;
            // 
            // colTipoDocumento
            // 
            this.colTipoDocumento.FieldName = "TipoDocumento";
            this.colTipoDocumento.Name = "colTipoDocumento";
            this.colTipoDocumento.OptionsColumn.AllowEdit = false;
            this.colTipoDocumento.Visible = true;
            this.colTipoDocumento.VisibleIndex = 1;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.OptionsColumn.AllowEdit = false;
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 2;
            // 
            // clsTipoTransaccionBindingSource2
            // 
            this.clsTipoTransaccionBindingSource2.DataSource = typeof(clases.Contabilidad.clsTipoTransaccion);
            // 
            // frmTipoTransaccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 383);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.lblModulo);
            this.Name = "frmTipoTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tipo Transaccion";
            this.Load += new System.EventHandler(this.frmTipoTransaccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoTransaccionBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource moduloBindingSource;
        private DataSet1TableAdapters.ModuloTableAdapter moduloTableAdapter;
        private System.Windows.Forms.BindingSource tipoTransaccionBindingSource;
        private System.Windows.Forms.BindingSource clsModuloBindingSource;
        private System.Windows.Forms.BindingSource clsTipoTransaccionBindingSource;
        private System.Windows.Forms.BindingSource clsModuloBindingSource1;
        private System.Windows.Forms.BindingSource clsTipoTransaccionBindingSource1;
        private System.Windows.Forms.BindingSource clsModuloBindingSource2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource clsTipoTransaccionBindingSource2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTransaccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoDocumento;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private System.Windows.Forms.BindingSource clsModuloBindingSource3;

    }
}