
namespace forms.ActivoFijo
{
    partial class prcsResponsables
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.gridResponsable = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictResponsable = new DevExpress.XtraEditors.PictureEdit();
            this.grdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsGridResponsablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GDDepartamento = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemSearchLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridResponsablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDDepartamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnNuevo);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnProcesar);
            this.gbxBotones.Location = new System.Drawing.Point(221, 45);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(333, 78);
            this.gbxBotones.TabIndex = 50;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Botones";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(17, 35);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 23);
            this.btnNuevo.TabIndex = 48;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(228, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnProcesar.Location = new System.Drawing.Point(117, 35);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(84, 23);
            this.btnProcesar.TabIndex = 46;
            this.btnProcesar.Text = "Procesar";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Image = global::forms.Properties.Resources.nuevo;
            this.btnCargarImagen.Location = new System.Drawing.Point(57, 129);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(96, 23);
            this.btnCargarImagen.TabIndex = 49;
            this.btnCargarImagen.Text = "Cargar Imagen";
            // 
            // gridResponsable
            // 
            this.gridResponsable.DataSource = this.clsGridResponsablesBindingSource;
            this.gridResponsable.Location = new System.Drawing.Point(12, 155);
            this.gridResponsable.MainView = this.gridView1;
            this.gridResponsable.Name = "gridResponsable";
            this.gridResponsable.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.GDDepartamento,
            this.repositoryItemSearchLookUpEdit2,
            this.repositoryItemGridLookUpEdit1});
            this.gridResponsable.Size = new System.Drawing.Size(540, 219);
            this.gridResponsable.TabIndex = 48;
            this.gridResponsable.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colCant,
            this.colDepartamento,
            this.colResponsable,
            this.colBodega});
            this.gridView1.GridControl = this.gridResponsable;
            this.gridView1.Name = "gridView1";
            // 
            // pictResponsable
            // 
            this.pictResponsable.Location = new System.Drawing.Point(22, 12);
            this.pictResponsable.Name = "pictResponsable";
            this.pictResponsable.Size = new System.Drawing.Size(191, 111);
            this.pictResponsable.TabIndex = 47;
            // 
            // grdBodega
            // 
            this.grdBodega.Caption = "Bodega";
            this.grdBodega.Name = "grdBodega";
            this.grdBodega.Width = 156;
            // 
            // grdResponsable
            // 
            this.grdResponsable.Caption = "Responsable";
            this.grdResponsable.Name = "grdResponsable";
            this.grdResponsable.Width = 129;
            // 
            // clsGridResponsablesBindingSource
            // 
            this.clsGridResponsablesBindingSource.DataSource = typeof(clases.ActivoFijo.clsGridResponsables);
            // 
            // colNo
            // 
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colCant
            // 
            this.colCant.FieldName = "Cant";
            this.colCant.Name = "colCant";
            this.colCant.Visible = true;
            this.colCant.VisibleIndex = 1;
            // 
            // colDepartamento
            // 
            this.colDepartamento.ColumnEdit = this.GDDepartamento;
            this.colDepartamento.FieldName = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.Visible = true;
            this.colDepartamento.VisibleIndex = 2;
            // 
            // colResponsable
            // 
            this.colResponsable.ColumnEdit = this.repositoryItemSearchLookUpEdit2;
            this.colResponsable.FieldName = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.Visible = true;
            this.colResponsable.VisibleIndex = 3;
            // 
            // colBodega
            // 
            this.colBodega.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.colBodega.FieldName = "Bodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.Visible = true;
            this.colBodega.VisibleIndex = 4;
            // 
            // GDDepartamento
            // 
            this.GDDepartamento.AutoHeight = false;
            this.GDDepartamento.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GDDepartamento.DataSource = this.clsDepartamentoBindingSource;
            this.GDDepartamento.DisplayMember = "Descripcion";
            this.GDDepartamento.Name = "GDDepartamento";
            this.GDDepartamento.ValueMember = "IdDepartamento";
            this.GDDepartamento.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDepartamento,
            this.colDescripcion,
            this.colIdEstado});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            this.repositoryItemSearchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIdDepartamento, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // repositoryItemSearchLookUpEdit2
            // 
            this.repositoryItemSearchLookUpEdit2.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2";
            this.repositoryItemSearchLookUpEdit2.View = this.repositoryItemSearchLookUpEdit2View;
            // 
            // repositoryItemSearchLookUpEdit2View
            // 
            this.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View";
            this.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // clsDepartamentoBindingSource
            // 
            this.clsDepartamentoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // colIdDepartamento
            // 
            this.colIdDepartamento.FieldName = "IdDepartamento";
            this.colIdDepartamento.Name = "colIdDepartamento";
            this.colIdDepartamento.Width = 170;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 0;
            this.colDescripcion.Width = 563;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // prcsResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 386);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.gridResponsable);
            this.Controls.Add(this.pictResponsable);
            this.Name = "prcsResponsables";
            this.Text = "prcsResponsables";
            this.Load += new System.EventHandler(this.prcsResponsables_Load);
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGridResponsablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GDDepartamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.SimpleButton btnCargarImagen;
        private DevExpress.XtraGrid.GridControl gridResponsable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PictureEdit pictResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn grdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn grdResponsable;
        private System.Windows.Forms.BindingSource clsGridResponsablesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCant;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartamento;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit GDDepartamento;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDepartamento;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colResponsable;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;

    }
}