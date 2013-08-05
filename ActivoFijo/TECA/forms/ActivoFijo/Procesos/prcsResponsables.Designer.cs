namespace forms.ActivoFijo.Procesos
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
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnProcesar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCargarImagen = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridResponsable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdDepartamento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdResponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictResponsable = new DevExpress.XtraEditors.PictureEdit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).BeginInit();
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
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 155);
            this.gridControl1.MainView = this.gridResponsable;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(540, 219);
            this.gridControl1.TabIndex = 48;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridResponsable});
            // 
            // gridResponsable
            // 
            this.gridResponsable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdNo,
            this.grdCantidad,
            this.grdDepartamento,
            this.grdResponsable,
            this.grdBodega});
            this.gridResponsable.GridControl = this.gridControl1;
            this.gridResponsable.Name = "gridResponsable";
            // 
            // grdNo
            // 
            this.grdNo.Caption = "No";
            this.grdNo.FieldName = "grdPeriodo";
            this.grdNo.Name = "grdNo";
            this.grdNo.Visible = true;
            this.grdNo.VisibleIndex = 0;
            this.grdNo.Width = 78;
            // 
            // grdCantidad
            // 
            this.grdCantidad.Caption = "Cant";
            this.grdCantidad.Name = "grdCantidad";
            this.grdCantidad.Visible = true;
            this.grdCantidad.VisibleIndex = 1;
            // 
            // grdDepartamento
            // 
            this.grdDepartamento.Caption = "Departamento";
            this.grdDepartamento.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.grdDepartamento.Name = "grdDepartamento";
            this.grdDepartamento.Visible = true;
            this.grdDepartamento.VisibleIndex = 2;
            this.grdDepartamento.Width = 129;
            // 
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grdResponsable
            // 
            this.grdResponsable.Caption = "Responsable";
            this.grdResponsable.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.grdResponsable.Name = "grdResponsable";
            this.grdResponsable.Visible = true;
            this.grdResponsable.VisibleIndex = 3;
            this.grdResponsable.Width = 129;
            // 
            // repositoryItemSearchLookUpEdit1
            // 
            this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
            this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
            this.repositoryItemSearchLookUpEdit1.View = this.gridView2;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // grdBodega
            // 
            this.grdBodega.Caption = "Bodega";
            this.grdBodega.ColumnEdit = this.repositoryItemGridLookUpEdit1;
            this.grdBodega.Name = "grdBodega";
            this.grdBodega.Visible = true;
            this.grdBodega.VisibleIndex = 4;
            this.grdBodega.Width = 156;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // repositoryItemGridLookUpEdit2
            // 
            this.repositoryItemGridLookUpEdit2.AutoHeight = false;
            this.repositoryItemGridLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit2.Name = "repositoryItemGridLookUpEdit2";
            this.repositoryItemGridLookUpEdit2.View = this.gridView3;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // pictResponsable
            // 
            this.pictResponsable.Location = new System.Drawing.Point(22, 12);
            this.pictResponsable.Name = "pictResponsable";
            this.pictResponsable.Size = new System.Drawing.Size(191, 111);
            this.pictResponsable.TabIndex = 47;
            // 
            // prcsResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 386);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictResponsable);
            this.Name = "prcsResponsables";
            this.Text = "prcsResponsables";
            this.Load += new System.EventHandler(this.prcsResponsables_Load);
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBotones;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnProcesar;
        private DevExpress.XtraEditors.SimpleButton btnCargarImagen;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn grdNo;
        private DevExpress.XtraGrid.Columns.GridColumn grdCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn grdDepartamento;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grdResponsable;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn grdBodega;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.PictureEdit pictResponsable;

    }
}