namespace forms.Contabilidad
{
    partial class frmComprobante
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
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumCom = new DevExpress.XtraEditors.TextEdit();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGlosa = new System.Windows.Forms.TextBox();
            this.gridControlComprobante = new DevExpress.XtraGrid.GridControl();
            this.clsDetalleComprobanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewComprobante = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collinea_comprobante = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comboCuenta = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.clsCuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboCuentaGrid = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo_padre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdNivelCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoCuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnaturaleza_cuenta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaModficacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldigitos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldebe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DebeHaber = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colhaber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblDebe = new System.Windows.Forms.Label();
            this.txtD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDetalleComprobanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebeHaber)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.toolStripSeparator2,
            this.btnGuardar,
            this.toolStripLabel1,
            this.btnEliminar,
            this.toolStripSeparator3,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(249, 22);
            this.toolStripLabel1.Text = "                                                                                 " +
    "                                         ";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(55, 22);
            this.btnEliminar.Text = "Revertir";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnBuscar);
            this.panelControl1.Controls.Add(this.txtNumCom);
            this.panelControl1.Controls.Add(this.dtFecha);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(797, 56);
            this.panelControl1.TabIndex = 23;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::forms.Properties.Resources.buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.Location = new System.Drawing.Point(217, 14);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumCom
            // 
            this.txtNumCom.Location = new System.Drawing.Point(137, 16);
            this.txtNumCom.Name = "txtNumCom";
            this.txtNumCom.Properties.Mask.EditMask = "\\d{0,5}";
            this.txtNumCom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumCom.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumCom.Size = new System.Drawing.Size(74, 20);
            this.txtNumCom.TabIndex = 3;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(690, 13);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(95, 20);
            this.dtFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Numero Comprobante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Glosa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGlosa
            // 
            this.txtGlosa.Location = new System.Drawing.Point(61, 339);
            this.txtGlosa.MaxLength = 200;
            this.txtGlosa.Multiline = true;
            this.txtGlosa.Name = "txtGlosa";
            this.txtGlosa.Size = new System.Drawing.Size(231, 43);
            this.txtGlosa.TabIndex = 0;
            this.txtGlosa.TextChanged += new System.EventHandler(this.txtGlosa_TextChanged);
            // 
            // gridControlComprobante
            // 
            this.gridControlComprobante.DataSource = this.clsDetalleComprobanteBindingSource;
            this.gridControlComprobante.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlComprobante.Location = new System.Drawing.Point(0, 81);
            this.gridControlComprobante.MainView = this.gridViewComprobante;
            this.gridControlComprobante.Name = "gridControlComprobante";
            this.gridControlComprobante.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.comboCuenta,
            this.DebeHaber});
            this.gridControlComprobante.Size = new System.Drawing.Size(797, 233);
            this.gridControlComprobante.TabIndex = 24;
            this.gridControlComprobante.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComprobante});
            // 
            // clsDetalleComprobanteBindingSource
            // 
            this.clsDetalleComprobanteBindingSource.DataSource = typeof(clases.Contabilidad.clsDetalleComprobante);
            // 
            // gridViewComprobante
            // 
            this.gridViewComprobante.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.collinea_comprobante,
            this.colcuenta,
            this.coldebe,
            this.colhaber});
            this.gridViewComprobante.GridControl = this.gridControlComprobante;
            this.gridViewComprobante.Name = "gridViewComprobante";
            this.gridViewComprobante.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridViewComprobante.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewComprobante.OptionsView.ShowGroupPanel = false;
            this.gridViewComprobante.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridViewComprobante_RowUpdated);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // collinea_comprobante
            // 
            this.collinea_comprobante.FieldName = "linea_comprobante";
            this.collinea_comprobante.Name = "collinea_comprobante";
            // 
            // colcuenta
            // 
            this.colcuenta.ColumnEdit = this.comboCuenta;
            this.colcuenta.FieldName = "cuenta";
            this.colcuenta.Name = "colcuenta";
            this.colcuenta.Visible = true;
            this.colcuenta.VisibleIndex = 0;
            // 
            // comboCuenta
            // 
            this.comboCuenta.AutoHeight = false;
            this.comboCuenta.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboCuenta.DataSource = this.clsCuentaBindingSource;
            this.comboCuenta.DisplayMember = "nombre";
            this.comboCuenta.Name = "comboCuenta";
            this.comboCuenta.ValueMember = "IdCuenta";
            this.comboCuenta.View = this.comboCuentaGrid;
            // 
            // clsCuentaBindingSource
            // 
            this.clsCuentaBindingSource.DataSource = typeof(clases.Contabilidad.clsCuenta);
            // 
            // comboCuentaGrid
            // 
            this.comboCuentaGrid.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colIdCuenta,
            this.colcodigo_padre,
            this.colnombre,
            this.coldescripcion,
            this.colIdNivelCuenta,
            this.colIdTipoCuenta,
            this.colnaturaleza_cuenta,
            this.colIdUsuario,
            this.colFechaModficacion,
            this.coldigitos});
            this.comboCuentaGrid.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.comboCuentaGrid.Name = "comboCuentaGrid";
            this.comboCuentaGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.comboCuentaGrid.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colIdCuenta
            // 
            this.colIdCuenta.FieldName = "IdCuenta";
            this.colIdCuenta.Name = "colIdCuenta";
            this.colIdCuenta.Visible = true;
            this.colIdCuenta.VisibleIndex = 0;
            this.colIdCuenta.Width = 455;
            // 
            // colcodigo_padre
            // 
            this.colcodigo_padre.FieldName = "codigo_padre";
            this.colcodigo_padre.Name = "colcodigo_padre";
            // 
            // colnombre
            // 
            this.colnombre.FieldName = "nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 1;
            this.colnombre.Width = 725;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            // 
            // colIdNivelCuenta
            // 
            this.colIdNivelCuenta.FieldName = "IdNivelCuenta";
            this.colIdNivelCuenta.Name = "colIdNivelCuenta";
            // 
            // colIdTipoCuenta
            // 
            this.colIdTipoCuenta.FieldName = "IdTipoCuenta";
            this.colIdTipoCuenta.Name = "colIdTipoCuenta";
            // 
            // colnaturaleza_cuenta
            // 
            this.colnaturaleza_cuenta.FieldName = "naturaleza_cuenta";
            this.colnaturaleza_cuenta.Name = "colnaturaleza_cuenta";
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            // 
            // colFechaModficacion
            // 
            this.colFechaModficacion.FieldName = "FechaModficacion";
            this.colFechaModficacion.Name = "colFechaModficacion";
            // 
            // coldigitos
            // 
            this.coldigitos.FieldName = "digitos";
            this.coldigitos.Name = "coldigitos";
            // 
            // coldebe
            // 
            this.coldebe.ColumnEdit = this.DebeHaber;
            this.coldebe.FieldName = "debe";
            this.coldebe.Name = "coldebe";
            this.coldebe.Visible = true;
            this.coldebe.VisibleIndex = 1;
            // 
            // DebeHaber
            // 
            this.DebeHaber.AutoHeight = false;
            this.DebeHaber.Mask.EditMask = "c";
            this.DebeHaber.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.DebeHaber.Name = "DebeHaber";
            // 
            // colhaber
            // 
            this.colhaber.ColumnEdit = this.DebeHaber;
            this.colhaber.FieldName = "haber";
            this.colhaber.Name = "colhaber";
            this.colhaber.Visible = true;
            this.colhaber.VisibleIndex = 2;
            // 
            // lblDebe
            // 
            this.lblDebe.AutoSize = true;
            this.lblDebe.Location = new System.Drawing.Point(322, 368);
            this.lblDebe.Name = "lblDebe";
            this.lblDebe.Size = new System.Drawing.Size(60, 13);
            this.lblDebe.TabIndex = 25;
            this.lblDebe.Text = "Total Debe";
            // 
            // txtD
            // 
            this.txtD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtD.Location = new System.Drawing.Point(388, 365);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total Haber";
            // 
            // txtH
            // 
            this.txtH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtH.Location = new System.Drawing.Point(675, 365);
            this.txtH.Name = "txtH";
            this.txtH.ReadOnly = true;
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 26;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(712, 402);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 25;
            this.lblUsuario.Text = "Usuario";
            // 
            // frmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 437);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.lblDebe);
            this.Controls.Add(this.gridControlComprobante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.txtGlosa);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmComprobante";
            this.Text = "Comprobantes Contables";
            this.Load += new System.EventHandler(this.frmComprobante_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumCom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDetalleComprobanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCuentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboCuentaGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebeHaber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlComprobante;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComprobante;
        private System.Windows.Forms.BindingSource clsDetalleComprobanteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn collinea_comprobante;
        private DevExpress.XtraGrid.Columns.GridColumn colcuenta;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit comboCuenta;
        private System.Windows.Forms.BindingSource clsCuentaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView comboCuentaGrid;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo_padre;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNivelCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoCuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colnaturaleza_cuenta;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaModficacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldigitos;
        private DevExpress.XtraGrid.Columns.GridColumn coldebe;
        private DevExpress.XtraGrid.Columns.GridColumn colhaber;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit DebeHaber;
        private System.Windows.Forms.Label lblDebe;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGlosa;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.TextEdit txtNumCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUsuario;

    }
}