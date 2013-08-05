namespace forms.ActivoFijo.Mantenimiento
{
    partial class mntActivoFIjo
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
            this.lblCodigoActivo = new DevExpress.XtraEditors.LabelControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslEnBlanco = new System.Windows.Forms.ToolStripLabel();
            this.lblEmpresa = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.cbxEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblGrupo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigoActivo = new DevExpress.XtraEditors.TextEdit();
            this.txtSubgrupo = new DevExpress.XtraEditors.TextEdit();
            this.lblDescripcion = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.ComboGrupo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodGrupo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtEmpresa = new DevExpress.XtraEditors.TextEdit();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.clsGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubgrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoActivo
            // 
            this.lblCodigoActivo.Location = new System.Drawing.Point(25, 61);
            this.lblCodigoActivo.Name = "lblCodigoActivo";
            this.lblCodigoActivo.Size = new System.Drawing.Size(82, 13);
            this.lblCodigoActivo.TabIndex = 299;
            this.lblCodigoActivo.Text = "Codigo Subgrupo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnModificar,
            this.btnEliminar,
            this.tslEnBlanco,
            this.btnCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
            this.toolStrip1.TabIndex = 296;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslEnBlanco
            // 
            this.tslEnBlanco.Name = "tslEnBlanco";
            this.tslEnBlanco.Size = new System.Drawing.Size(127, 22);
            this.tslEnBlanco.Text = "                                        ";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Location = new System.Drawing.Point(313, 129);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(45, 13);
            this.lblEmpresa.TabIndex = 294;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Enabled = false;
            this.dtFecha.Location = new System.Drawing.Point(374, 58);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtFecha.Size = new System.Drawing.Size(111, 20);
            this.dtFecha.TabIndex = 292;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(325, 61);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(33, 13);
            this.lblFecha.TabIndex = 291;
            this.lblFecha.Text = "Fecha:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Enabled = false;
            this.cbxEstado.Location = new System.Drawing.Point(374, 92);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Size = new System.Drawing.Size(111, 20);
            this.cbxEstado.TabIndex = 290;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(321, 95);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 289;
            this.lblEstado.Text = "Estado:";
            // 
            // lblGrupo
            // 
            this.lblGrupo.Location = new System.Drawing.Point(25, 95);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(33, 13);
            this.lblGrupo.TabIndex = 286;
            this.lblGrupo.Text = "Grupo:";
            // 
            // txtCodigoActivo
            // 
            this.txtCodigoActivo.Enabled = false;
            this.txtCodigoActivo.Location = new System.Drawing.Point(109, 58);
            this.txtCodigoActivo.Name = "txtCodigoActivo";
            this.txtCodigoActivo.Size = new System.Drawing.Size(57, 20);
            this.txtCodigoActivo.TabIndex = 301;
            // 
            // txtSubgrupo
            // 
            this.txtSubgrupo.Enabled = false;
            this.txtSubgrupo.Location = new System.Drawing.Point(109, 126);
            this.txtSubgrupo.Name = "txtSubgrupo";
            this.txtSubgrupo.Size = new System.Drawing.Size(198, 20);
            this.txtSubgrupo.TabIndex = 309;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(25, 129);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(58, 13);
            this.lblDescripcion.TabIndex = 288;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Location = new System.Drawing.Point(172, 61);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(36, 17);
            this.btnbuscar.TabIndex = 310;
            this.btnbuscar.Text = "...";
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // ComboGrupo
            // 
            this.ComboGrupo.EditValue = "editar";
            this.ComboGrupo.Enabled = false;
            this.ComboGrupo.Location = new System.Drawing.Point(108, 92);
            this.ComboGrupo.Name = "ComboGrupo";
            this.ComboGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboGrupo.Properties.DataSource = this.clsGrupoBindingSource;
            this.ComboGrupo.Properties.DisplayMember = "Decripcion";
            this.ComboGrupo.Properties.ValueMember = "Grupo";
            this.ComboGrupo.Properties.View = this.gridLookUpEdit1View;
            this.ComboGrupo.Size = new System.Drawing.Size(100, 20);
            this.ComboGrupo.TabIndex = 312;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodGrupo,
            this.colDescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colCodGrupo
            // 
            this.colCodGrupo.Caption = "Codigo";
            this.colCodGrupo.FieldName = "CodGrupo";
            this.colCodGrupo.Name = "colCodGrupo";
            this.colCodGrupo.Visible = true;
            this.colCodGrupo.VisibleIndex = 0;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Caption = "Descripcion";
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 1;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Location = new System.Drawing.Point(374, 126);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(111, 20);
            this.txtEmpresa.TabIndex = 314;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::forms.Properties.Resources.modificar;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(78, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::forms.Properties.Resources.eliminar;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // clsGrupoBindingSource
            // 
            this.clsGrupoBindingSource.DataSource = typeof(clases.Inventario.clsGrupo);
            // 
            // mntActivoFIjo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 188);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.ComboGrupo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtSubgrupo);
            this.Controls.Add(this.txtCodigoActivo);
            this.Controls.Add(this.lblCodigoActivo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblGrupo);
            this.Name = "mntActivoFIjo";
            this.Text = "mntActivoFIjo";
            this.Load += new System.EventHandler(this.mntActivoFIjo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigoActivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubgrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblCodigoActivo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripLabel tslEnBlanco;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private DevExpress.XtraEditors.LabelControl lblEmpresa;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.ComboBoxEdit cbxEstado;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl lblGrupo;
        private DevExpress.XtraEditors.TextEdit txtCodigoActivo;
        private DevExpress.XtraEditors.TextEdit txtSubgrupo;
        private DevExpress.XtraEditors.LabelControl lblDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private DevExpress.XtraEditors.GridLookUpEdit ComboGrupo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource clsGrupoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCodGrupo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraEditors.TextEdit txtEmpresa;
    }
}