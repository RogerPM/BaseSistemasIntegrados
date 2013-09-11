namespace forms.Seguridad
{
    partial class frmAsignarUsuariosAEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignarUsuariosAEmpresa));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.clsUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbEmpresa = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.colnombreComercial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.listBoxControl1);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Controls.Add(this.cmbEmpresa);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Location = new System.Drawing.Point(12, 30);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(799, 349);
            this.groupControl2.TabIndex = 23;
            this.groupControl2.Text = "Detalle";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(588, 82);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(186, 237);
            this.listBoxControl1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lista de Usuarios:";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsUsuarioBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(8, 82);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(559, 237);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsUsuarioBindingSource
            // 
            this.clsUsuarioBindingSource.DataSource = typeof(clases.Seguridad.clsUsuario);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colNombreUsuario,
            this.colContrasena,
            this.colIdEstado,
            this.colIdImagen,
            this.colIdPerfil});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.FieldName = "NombreUsuario";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 1;
            // 
            // colContrasena
            // 
            this.colContrasena.FieldName = "Contrasena";
            this.colContrasena.Name = "colContrasena";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colIdImagen
            // 
            this.colIdImagen.FieldName = "IdImagen";
            this.colIdImagen.Name = "colIdImagen";
            // 
            // colIdPerfil
            // 
            this.colIdPerfil.FieldName = "IdPerfil";
            this.colIdPerfil.Name = "colIdPerfil";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Location = new System.Drawing.Point(62, 24);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEmpresa.Properties.DataSource = this.clsEmpresaBindingSource;
            this.cmbEmpresa.Properties.DisplayMember = "razonSocial";
            this.cmbEmpresa.Properties.ValueMember = "idEmpresa";
            this.cmbEmpresa.Properties.View = this.gridLookUpEdit1View;
            this.cmbEmpresa.Size = new System.Drawing.Size(192, 20);
            this.cmbEmpresa.TabIndex = 12;
            // 
            // clsEmpresaBindingSource
            // 
            this.clsEmpresaBindingSource.DataSource = typeof(clases.Seguridad.clsEmpresa);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombreComercial,
            this.colidEmpresa});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Empresa:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGuardar,
            this.btnActualizar,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(823, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::forms.Properties.Resources.guardar;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(57, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(64, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::forms.Properties.Resources._24_cancelar;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton5.Text = "Salir";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // colnombreComercial
            // 
            this.colnombreComercial.Caption = "Nombre comercial ";
            this.colnombreComercial.FieldName = "nombreComercial";
            this.colnombreComercial.Name = "colnombreComercial";
            this.colnombreComercial.Visible = true;
            this.colnombreComercial.VisibleIndex = 0;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.Caption = "Código";
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            this.colidEmpresa.Visible = true;
            this.colidEmpresa.VisibleIndex = 1;
            // 
            // frmAsignarUsuariosAEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 391);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupControl2);
            this.Name = "frmAsignarUsuariosAEmpresa";
            this.Text = "Asignar usuarios a empresa";
            this.Load += new System.EventHandler(this.frmAsignarUsuariosAEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEmpresa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit cmbEmpresa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.BindingSource clsEmpresaBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clsUsuarioBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasena;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImagen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPerfil;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colnombreComercial;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
    }
}