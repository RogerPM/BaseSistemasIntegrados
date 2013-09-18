namespace forms.Contabilidad
{
    partial class frmPeriodo
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
            this.lblUsuario = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button1 = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAperturar = new System.Windows.Forms.ToolStripButton();
            this.btnCerrar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dataSet1 = new forms.Contabilidad.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduloTableAdapter = new forms.Contabilidad.DataSet1TableAdapters.ModuloTableAdapter();
            this.dtlista = new System.Windows.Forms.DataGridView();
            this.periodoContableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsPeriodoContableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmperiodo = new System.Windows.Forms.ComboBox();
            this.idEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPeriodoContableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoContableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPeriodoContableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(337, 355);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuario";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmperiodo);
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(508, 63);
            this.panelControl1.TabIndex = 26;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Genera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(19, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Año Fiscal";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAperturar,
            this.btnCerrar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(615, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnAperturar
            // 
            this.btnAperturar.Image = global::forms.Properties.Resources.add_comment_blue1;
            this.btnAperturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(77, 22);
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = global::forms.Properties.Resources.eliminar;
            this.btnCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 22);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // moduloBindingSource
            // 
            this.moduloBindingSource.DataMember = "Modulo";
            this.moduloBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // moduloTableAdapter
            // 
            this.moduloTableAdapter.ClearBeforeFill = true;
            // 
            // dtlista
            // 
            this.dtlista.AutoGenerateColumns = false;
            this.dtlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpresaDataGridViewTextBoxColumn,
            this.idPeriodoContableDataGridViewTextBoxColumn,
            this.idUsuarioDataGridViewTextBoxColumn,
            this.idAFiscalDataGridViewTextBoxColumn,
            this.fechaInicioDataGridViewTextBoxColumn,
            this.fechaFinDataGridViewTextBoxColumn,
            this.idEstadoDataGridViewTextBoxColumn,
            this.fechaModificacionDataGridViewTextBoxColumn,
            this.anoFiscalDataGridViewTextBoxColumn});
            this.dtlista.DataSource = this.periodoContableBindingSource;
            this.dtlista.Location = new System.Drawing.Point(12, 108);
            this.dtlista.Name = "dtlista";
            this.dtlista.Size = new System.Drawing.Size(591, 244);
            this.dtlista.TabIndex = 28;
            this.dtlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlista_CellContentClick);
            // 
            // periodoContableBindingSource
            // 
            this.periodoContableBindingSource.DataSource = typeof(datos.Contabilidad.PeriodoContable);
            // 
            // clsPeriodoContableBindingSource
            // 
            this.clsPeriodoContableBindingSource.DataSource = typeof(clases.Contabilidad.clsPeriodoContable);
            // 
            // cmperiodo
            // 
            this.cmperiodo.DataSource = this.clsPeriodoContableBindingSource;
            this.cmperiodo.DisplayMember = "IdPeriodoContable";
            this.cmperiodo.FormattingEnabled = true;
            this.cmperiodo.Location = new System.Drawing.Point(98, 11);
            this.cmperiodo.Name = "cmperiodo";
            this.cmperiodo.Size = new System.Drawing.Size(121, 21);
            this.cmperiodo.TabIndex = 3;
            this.cmperiodo.ValueMember = "IdPeriodoContable";
            this.cmperiodo.SelectedIndexChanged += new System.EventHandler(this.cmperiodo_SelectedIndexChanged);
            // 
            // idEmpresaDataGridViewTextBoxColumn
            // 
            this.idEmpresaDataGridViewTextBoxColumn.DataPropertyName = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.HeaderText = "IdEmpresa";
            this.idEmpresaDataGridViewTextBoxColumn.Name = "idEmpresaDataGridViewTextBoxColumn";
            // 
            // idPeriodoContableDataGridViewTextBoxColumn
            // 
            this.idPeriodoContableDataGridViewTextBoxColumn.DataPropertyName = "IdPeriodoContable";
            this.idPeriodoContableDataGridViewTextBoxColumn.HeaderText = "IdPeriodoContable";
            this.idPeriodoContableDataGridViewTextBoxColumn.Name = "idPeriodoContableDataGridViewTextBoxColumn";
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            // 
            // idAFiscalDataGridViewTextBoxColumn
            // 
            this.idAFiscalDataGridViewTextBoxColumn.DataPropertyName = "IdAFiscal";
            this.idAFiscalDataGridViewTextBoxColumn.HeaderText = "IdAFiscal";
            this.idAFiscalDataGridViewTextBoxColumn.Name = "idAFiscalDataGridViewTextBoxColumn";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "FechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "FechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // idEstadoDataGridViewTextBoxColumn
            // 
            this.idEstadoDataGridViewTextBoxColumn.DataPropertyName = "IdEstado";
            this.idEstadoDataGridViewTextBoxColumn.HeaderText = "IdEstado";
            this.idEstadoDataGridViewTextBoxColumn.Name = "idEstadoDataGridViewTextBoxColumn";
            // 
            // fechaModificacionDataGridViewTextBoxColumn
            // 
            this.fechaModificacionDataGridViewTextBoxColumn.DataPropertyName = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.HeaderText = "FechaModificacion";
            this.fechaModificacionDataGridViewTextBoxColumn.Name = "fechaModificacionDataGridViewTextBoxColumn";
            // 
            // anoFiscalDataGridViewTextBoxColumn
            // 
            this.anoFiscalDataGridViewTextBoxColumn.DataPropertyName = "AnoFiscal";
            this.anoFiscalDataGridViewTextBoxColumn.HeaderText = "AnoFiscal";
            this.anoFiscalDataGridViewTextBoxColumn.Name = "anoFiscalDataGridViewTextBoxColumn";
            // 
            // frmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 377);
            this.Controls.Add(this.dtlista);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmPeriodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Periodo Contable";
            this.Load += new System.EventHandler(this.frmPeriodo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodoContableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPeriodoContableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAperturar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnCerrar;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource moduloBindingSource;
        private DataSet1TableAdapters.ModuloTableAdapter moduloTableAdapter;
        private System.Windows.Forms.DataGridView dtlista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource periodoContableBindingSource;
        private System.Windows.Forms.BindingSource clsPeriodoContableBindingSource;
        private System.Windows.Forms.ComboBox cmperiodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodoContableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAFiscalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEstadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoFiscalDataGridViewTextBoxColumn;
    }
}