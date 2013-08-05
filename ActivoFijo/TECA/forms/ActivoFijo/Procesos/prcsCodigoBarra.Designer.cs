namespace forms.ActivoFijo.Procesos
{
    partial class prcsCodigoBarra
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
            this.cbxGrupo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblFormato = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.gbxBotones = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridResponsable = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCodigoActivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdCodigoBarra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemGridLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pictResponsable = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
            this.gbxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxGrupo
            // 
            this.cbxGrupo.EditValue = "SJ11-002";
            this.cbxGrupo.Enabled = false;
            this.cbxGrupo.Location = new System.Drawing.Point(295, 33);
            this.cbxGrupo.Name = "cbxGrupo";
            this.cbxGrupo.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxGrupo.Properties.Appearance.Options.UseBackColor = true;
            this.cbxGrupo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxGrupo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxGrupo.Size = new System.Drawing.Size(82, 20);
            this.cbxGrupo.TabIndex = 81;
            // 
            // lblFormato
            // 
            this.lblFormato.Location = new System.Drawing.Point(314, 14);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(44, 13);
            this.lblFormato.TabIndex = 82;
            this.lblFormato.Text = "Formato:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.EditValue = "Empresa-Grupo-SubGrupo-Código Activo";
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(80, 125);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodigo.Size = new System.Drawing.Size(198, 20);
            this.txtCodigo.TabIndex = 80;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(37, 128);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 79;
            this.lblCodigo.Text = "Código:";
            // 
            // gbxBotones
            // 
            this.gbxBotones.Controls.Add(this.btnImprimir);
            this.gbxBotones.Controls.Add(this.btnCancelar);
            this.gbxBotones.Controls.Add(this.btnGenerar);
            this.gbxBotones.Location = new System.Drawing.Point(409, 14);
            this.gbxBotones.Name = "gbxBotones";
            this.gbxBotones.Size = new System.Drawing.Size(133, 127);
            this.gbxBotones.TabIndex = 78;
            this.gbxBotones.TabStop = false;
            this.gbxBotones.Text = "Botones";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = global::forms.Properties.Resources.imprimir;
            this.btnImprimir.Location = new System.Drawing.Point(25, 98);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(84, 23);
            this.btnImprimir.TabIndex = 48;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::forms.Properties.Resources._24_cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(25, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 23);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Image = global::forms.Properties.Resources._24_aceptar;
            this.btnGenerar.Location = new System.Drawing.Point(25, 31);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(84, 23);
            this.btnGenerar.TabIndex = 46;
            this.btnGenerar.Text = "Generar";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(7, 151);
            this.gridControl1.MainView = this.gridResponsable;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemGridLookUpEdit2,
            this.repositoryItemSearchLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(540, 219);
            this.gridControl1.TabIndex = 77;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridResponsable});
            // 
            // gridResponsable
            // 
            this.gridResponsable.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grdNo,
            this.grdCodigoActivo,
            this.grdCodigoBarra});
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
            this.grdNo.Width = 96;
            // 
            // grdCodigoActivo
            // 
            this.grdCodigoActivo.Caption = "Codigo Activo";
            this.grdCodigoActivo.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.grdCodigoActivo.Name = "grdCodigoActivo";
            this.grdCodigoActivo.Visible = true;
            this.grdCodigoActivo.VisibleIndex = 1;
            this.grdCodigoActivo.Width = 212;
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
            // grdCodigoBarra
            // 
            this.grdCodigoBarra.Caption = "Codigo Barra";
            this.grdCodigoBarra.ColumnEdit = this.repositoryItemSearchLookUpEdit1;
            this.grdCodigoBarra.Name = "grdCodigoBarra";
            this.grdCodigoBarra.Visible = true;
            this.grdCodigoBarra.VisibleIndex = 2;
            this.grdCodigoBarra.Width = 214;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
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
            this.pictResponsable.EditValue = global::forms.Properties.Resources.Codigo_de_barras;
            this.pictResponsable.Location = new System.Drawing.Point(37, 7);
            this.pictResponsable.Name = "pictResponsable";
            this.pictResponsable.Size = new System.Drawing.Size(241, 111);
            this.pictResponsable.TabIndex = 76;
            // 
            // prcsCodigoBarra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 376);
            this.Controls.Add(this.cbxGrupo);
            this.Controls.Add(this.lblFormato);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.gbxBotones);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.pictResponsable);
            this.Name = "prcsCodigoBarra";
            this.Text = "prcsCodigoBarra";
            this.Load += new System.EventHandler(this.prcsCodigoBarra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxGrupo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            this.gbxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResponsable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictResponsable.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbxGrupo;
        private DevExpress.XtraEditors.LabelControl lblFormato;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private System.Windows.Forms.GroupBox gbxBotones;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGenerar;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridResponsable;
        private DevExpress.XtraGrid.Columns.GridColumn grdNo;
        private DevExpress.XtraGrid.Columns.GridColumn grdCodigoActivo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn grdCodigoBarra;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.PictureEdit pictResponsable;

    }
}