namespace forms._Otro
{
    partial class UCMenuTreeLsto
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trlPerfil = new DevExpress.XtraTreeList.TreeList();
            this.colDescripcion = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPosicionMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHabilitadoMenu = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colFormularioAsociado = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colIndexIcono = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNombreFormulario = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colNombreAssembly = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tbMenuInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxModulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsModuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdModulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Modulo = new System.Windows.Forms.Label();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cbxPerfil = new DevExpress.XtraEditors.GridLookUpEdit();
            this.perfilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trlPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenuInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxModulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPerfil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // trlPerfil
            // 
            this.trlPerfil.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colDescripcion,
            this.colPosicionMenu,
            this.colHabilitadoMenu,
            this.colFormularioAsociado,
            this.colIndexIcono,
            this.colNombreFormulario,
            this.colNombreAssembly});
            this.trlPerfil.DataSource = this.tbMenuInfoBindingSource;
            this.trlPerfil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.trlPerfil.KeyFieldName = "IdMenu";
            this.trlPerfil.Location = new System.Drawing.Point(0, 32);
            this.trlPerfil.Name = "trlPerfil";
            this.trlPerfil.OptionsBehavior.PopulateServiceColumns = true;
            this.trlPerfil.OptionsPrint.UsePrintStyles = true;
            this.trlPerfil.OptionsView.ShowCheckBoxes = true;
            this.trlPerfil.ParentFieldName = "IdPadre";
            this.trlPerfil.Size = new System.Drawing.Size(618, 357);
            this.trlPerfil.TabIndex = 0;
            this.trlPerfil.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeList1_AfterCheckNode);
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.MinWidth = 32;
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 55;
            // 
            // colPosicionMenu
            // 
            this.colPosicionMenu.FieldName = "PosicionMenu";
            this.colPosicionMenu.Name = "colPosicionMenu";
            this.colPosicionMenu.Width = 55;
            // 
            // colHabilitadoMenu
            // 
            this.colHabilitadoMenu.FieldName = "HabilitadoMenu";
            this.colHabilitadoMenu.Name = "colHabilitadoMenu";
            this.colHabilitadoMenu.Width = 55;
            // 
            // colFormularioAsociado
            // 
            this.colFormularioAsociado.FieldName = "FormularioAsociado";
            this.colFormularioAsociado.Name = "colFormularioAsociado";
            this.colFormularioAsociado.Visible = true;
            this.colFormularioAsociado.VisibleIndex = 1;
            this.colFormularioAsociado.Width = 55;
            // 
            // colIndexIcono
            // 
            this.colIndexIcono.FieldName = "IndexIcono";
            this.colIndexIcono.Name = "colIndexIcono";
            this.colIndexIcono.Visible = true;
            this.colIndexIcono.VisibleIndex = 2;
            this.colIndexIcono.Width = 55;
            // 
            // colNombreFormulario
            // 
            this.colNombreFormulario.FieldName = "NombreFormulario";
            this.colNombreFormulario.Name = "colNombreFormulario";
            this.colNombreFormulario.Visible = true;
            this.colNombreFormulario.VisibleIndex = 3;
            this.colNombreFormulario.Width = 55;
            // 
            // colNombreAssembly
            // 
            this.colNombreAssembly.FieldName = "NombreAssembly";
            this.colNombreAssembly.Name = "colNombreAssembly";
            this.colNombreAssembly.Visible = true;
            this.colNombreAssembly.VisibleIndex = 4;
            this.colNombreAssembly.Width = 55;
            // 
            // tbMenuInfoBindingSource
            // 
            this.tbMenuInfoBindingSource.DataSource = typeof(Core.Erp.Info.Seguridad.clsMenu);
            // 
            // cbxModulo
            // 
            this.cbxModulo.Location = new System.Drawing.Point(407, 6);
            this.cbxModulo.Name = "cbxModulo";
            this.cbxModulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxModulo.Properties.DataSource = this.clsModuloBindingSource;
            this.cbxModulo.Properties.DisplayMember = "Nombre";
            this.cbxModulo.Properties.ValueMember = "IdModulo";
            this.cbxModulo.Properties.View = this.gridLookUpEdit1View;
            this.cbxModulo.Size = new System.Drawing.Size(150, 20);
            this.cbxModulo.TabIndex = 1;
            this.cbxModulo.EditValueChanged += new System.EventHandler(this.cmbModulo_EditValueChanged);
            // 
            // clsModuloBindingSource
            // 
            this.clsModuloBindingSource.DataSource = typeof(clases.Seguridad.clsModulo);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdModulo,
            this.colNombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colIdModulo
            // 
            this.colIdModulo.FieldName = "IdModulo";
            this.colIdModulo.Name = "colIdModulo";
            this.colIdModulo.Visible = true;
            this.colIdModulo.VisibleIndex = 1;
            this.colIdModulo.Width = 91;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 0;
            this.colNombre.Width = 1040;
            // 
            // Modulo
            // 
            this.Modulo.AutoSize = true;
            this.Modulo.Location = new System.Drawing.Point(359, 9);
            this.Modulo.Name = "Modulo";
            this.Modulo.Size = new System.Drawing.Size(42, 13);
            this.Modulo.TabIndex = 2;
            this.Modulo.Text = "Modulo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(3, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cbxPerfil
            // 
            this.cbxPerfil.Location = new System.Drawing.Point(206, 6);
            this.cbxPerfil.Name = "cbxPerfil";
            this.cbxPerfil.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPerfil.Properties.DataSource = this.perfilBindingSource;
            this.cbxPerfil.Properties.DisplayMember = "Descripcion";
            this.cbxPerfil.Properties.ValueMember = "IdPerfil";
            this.cbxPerfil.Properties.View = this.gridView1;
            this.cbxPerfil.Size = new System.Drawing.Size(136, 20);
            this.cbxPerfil.TabIndex = 1;
            this.cbxPerfil.EditValueChanged += new System.EventHandler(this.cmbPerfil_EditValueChanged);
            // 
            // perfilBindingSource
            // 
            this.perfilBindingSource.DataSource = typeof(datos.Seguridad.Perfil);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescripcion1});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDescripcion1
            // 
            this.colDescripcion1.FieldName = "Descripcion";
            this.colDescripcion1.Name = "colDescripcion1";
            this.colDescripcion1.Visible = true;
            this.colDescripcion1.VisibleIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Perfil";
            // 
            // UCMenuTreeLsto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modulo);
            this.Controls.Add(this.cbxPerfil);
            this.Controls.Add(this.cbxModulo);
            this.Controls.Add(this.trlPerfil);
            this.Name = "UCMenuTreeLsto";
            this.Size = new System.Drawing.Size(618, 389);
            this.Load += new System.EventHandler(this.UCMenuTreeLsto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trlPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMenuInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxModulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPerfil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList trlPerfil;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDescripcion;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPosicionMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHabilitadoMenu;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colFormularioAsociado;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colIndexIcono;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNombreFormulario;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNombreAssembly;
        private System.Windows.Forms.BindingSource tbMenuInfoBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit cbxModulo;
        private System.Windows.Forms.BindingSource clsModuloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModulo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private System.Windows.Forms.Label Modulo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.GridLookUpEdit cbxPerfil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource perfilBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion1;
    }
}
