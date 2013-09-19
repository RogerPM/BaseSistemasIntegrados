namespace forms.Inventario
{
    partial class frmTomaFisica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTomaFisica));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gdcTomaFisica = new DevExpress.XtraGrid.GridControl();
            this.clsTomaFisicaDETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroTomaFisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArticulo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbArticulo = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.clsArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmpresaArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFProduccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantMinima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantMaxima = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantActual = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUMed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFCaducidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupoArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSChasis = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSMotor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNPlaca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoComb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColorArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMarcaArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModeloArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoMat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObservArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstArt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaSistema = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistenciaFisica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadAjustada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaAjuste = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.boxBodega = new System.Windows.Forms.GroupBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarNroTF = new DevExpress.XtraEditors.SimpleButton();
            this.txtResponsable = new System.Windows.Forms.TextBox();
            this.txtTomaFisica = new System.Windows.Forms.TextBox();
            this.lblNTomaFisica = new System.Windows.Forms.Label();
            this.cbxMotivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMotivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxTipoArticulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxBodega = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapacidadm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpercha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcTomaFisica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTomaFisicaDETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.boxBodega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gdcTomaFisica);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 176);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            // 
            // gdcTomaFisica
            // 
            this.gdcTomaFisica.DataSource = this.clsTomaFisicaDETBindingSource;
            this.gdcTomaFisica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcTomaFisica.Location = new System.Drawing.Point(3, 16);
            this.gdcTomaFisica.MainView = this.gridView1;
            this.gdcTomaFisica.Name = "gdcTomaFisica";
            this.gdcTomaFisica.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbArticulo});
            this.gdcTomaFisica.Size = new System.Drawing.Size(476, 157);
            this.gdcTomaFisica.TabIndex = 0;
            this.gdcTomaFisica.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsTomaFisicaDETBindingSource
            // 
            this.clsTomaFisicaDETBindingSource.DataSource = typeof(clases.Inventario.clsTomaFisicaDET);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colNroTomaFisica,
            this.colIdArticulo,
            this.colExistenciaSistema,
            this.colExistenciaFisica,
            this.colCantidadAjustada,
            this.colFechaAjuste,
            this.colcheck});
            this.gridView1.GridControl = this.gdcTomaFisica;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colNroTomaFisica
            // 
            this.colNroTomaFisica.FieldName = "NroTomaFisica";
            this.colNroTomaFisica.Name = "colNroTomaFisica";
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.ColumnEdit = this.cmbArticulo;
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.Visible = true;
            this.colIdArticulo.VisibleIndex = 1;
            this.colIdArticulo.Width = 264;
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.AutoHeight = false;
            this.cmbArticulo.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbArticulo.DataSource = this.clsArticuloBindingSource;
            this.cmbArticulo.DisplayMember = "DescArt";
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.ValueMember = "IdArt";
            this.cmbArticulo.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // clsArticuloBindingSource
            // 
            this.clsArticuloBindingSource.DataSource = typeof(clases.Inventario.clsArticulo);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmpresaArt,
            this.colIdArt,
            this.colDescArt,
            this.colFProduccion,
            this.colCantMinima,
            this.colCantMaxima,
            this.colCantActual,
            this.colUMed,
            this.colFCaducidad,
            this.colTipoArt,
            this.colGrupoArt,
            this.colTipoChasis,
            this.colSChasis,
            this.colTipoMotor,
            this.colSMotor,
            this.colNPlaca,
            this.colTipoComb,
            this.colColorArt,
            this.colMarcaArt,
            this.colModeloArt,
            this.colTipoMat,
            this.colObservArt,
            this.colEstArt});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEmpresaArt
            // 
            this.colEmpresaArt.FieldName = "EmpresaArt";
            this.colEmpresaArt.Name = "colEmpresaArt";
            // 
            // colIdArt
            // 
            this.colIdArt.FieldName = "IdArt";
            this.colIdArt.Name = "colIdArt";
            this.colIdArt.Visible = true;
            this.colIdArt.VisibleIndex = 0;
            this.colIdArt.Width = 201;
            // 
            // colDescArt
            // 
            this.colDescArt.FieldName = "DescArt";
            this.colDescArt.Name = "colDescArt";
            this.colDescArt.Visible = true;
            this.colDescArt.VisibleIndex = 1;
            this.colDescArt.Width = 979;
            // 
            // colFProduccion
            // 
            this.colFProduccion.FieldName = "FProduccion";
            this.colFProduccion.Name = "colFProduccion";
            // 
            // colCantMinima
            // 
            this.colCantMinima.FieldName = "CantMinima";
            this.colCantMinima.Name = "colCantMinima";
            // 
            // colCantMaxima
            // 
            this.colCantMaxima.FieldName = "CantMaxima";
            this.colCantMaxima.Name = "colCantMaxima";
            // 
            // colCantActual
            // 
            this.colCantActual.FieldName = "CantActual";
            this.colCantActual.Name = "colCantActual";
            // 
            // colUMed
            // 
            this.colUMed.FieldName = "UMed";
            this.colUMed.Name = "colUMed";
            // 
            // colFCaducidad
            // 
            this.colFCaducidad.FieldName = "FCaducidad";
            this.colFCaducidad.Name = "colFCaducidad";
            // 
            // colTipoArt
            // 
            this.colTipoArt.FieldName = "TipoArt";
            this.colTipoArt.Name = "colTipoArt";
            // 
            // colGrupoArt
            // 
            this.colGrupoArt.FieldName = "GrupoArt";
            this.colGrupoArt.Name = "colGrupoArt";
            // 
            // colTipoChasis
            // 
            this.colTipoChasis.FieldName = "TipoChasis";
            this.colTipoChasis.Name = "colTipoChasis";
            // 
            // colSChasis
            // 
            this.colSChasis.FieldName = "SChasis";
            this.colSChasis.Name = "colSChasis";
            // 
            // colTipoMotor
            // 
            this.colTipoMotor.FieldName = "TipoMotor";
            this.colTipoMotor.Name = "colTipoMotor";
            // 
            // colSMotor
            // 
            this.colSMotor.FieldName = "SMotor";
            this.colSMotor.Name = "colSMotor";
            // 
            // colNPlaca
            // 
            this.colNPlaca.FieldName = "NPlaca";
            this.colNPlaca.Name = "colNPlaca";
            // 
            // colTipoComb
            // 
            this.colTipoComb.FieldName = "TipoComb";
            this.colTipoComb.Name = "colTipoComb";
            // 
            // colColorArt
            // 
            this.colColorArt.FieldName = "ColorArt";
            this.colColorArt.Name = "colColorArt";
            // 
            // colMarcaArt
            // 
            this.colMarcaArt.FieldName = "MarcaArt";
            this.colMarcaArt.Name = "colMarcaArt";
            // 
            // colModeloArt
            // 
            this.colModeloArt.FieldName = "ModeloArt";
            this.colModeloArt.Name = "colModeloArt";
            // 
            // colTipoMat
            // 
            this.colTipoMat.FieldName = "TipoMat";
            this.colTipoMat.Name = "colTipoMat";
            // 
            // colObservArt
            // 
            this.colObservArt.FieldName = "ObservArt";
            this.colObservArt.Name = "colObservArt";
            // 
            // colEstArt
            // 
            this.colEstArt.FieldName = "EstArt";
            this.colEstArt.Name = "colEstArt";
            // 
            // colExistenciaSistema
            // 
            this.colExistenciaSistema.FieldName = "ExistenciaSistema";
            this.colExistenciaSistema.Name = "colExistenciaSistema";
            this.colExistenciaSistema.Visible = true;
            this.colExistenciaSistema.VisibleIndex = 2;
            this.colExistenciaSistema.Width = 264;
            // 
            // colExistenciaFisica
            // 
            this.colExistenciaFisica.FieldName = "ExistenciaFisica";
            this.colExistenciaFisica.Name = "colExistenciaFisica";
            this.colExistenciaFisica.Visible = true;
            this.colExistenciaFisica.VisibleIndex = 3;
            this.colExistenciaFisica.Width = 264;
            // 
            // colCantidadAjustada
            // 
            this.colCantidadAjustada.FieldName = "CantidadAjustada";
            this.colCantidadAjustada.Name = "colCantidadAjustada";
            this.colCantidadAjustada.Visible = true;
            this.colCantidadAjustada.VisibleIndex = 4;
            this.colCantidadAjustada.Width = 272;
            // 
            // colFechaAjuste
            // 
            this.colFechaAjuste.FieldName = "FechaAjuste";
            this.colFechaAjuste.Name = "colFechaAjuste";
            // 
            // colcheck
            // 
            this.colcheck.Caption = "#";
            this.colcheck.FieldName = "check";
            this.colcheck.Name = "colcheck";
            this.colcheck.Visible = true;
            this.colcheck.VisibleIndex = 0;
            this.colcheck.Width = 30;
            // 
            // boxBodega
            // 
            this.boxBodega.Controls.Add(this.dtFecha);
            this.boxBodega.Controls.Add(this.labelControl2);
            this.boxBodega.Controls.Add(this.labelControl1);
            this.boxBodega.Controls.Add(this.label4);
            this.boxBodega.Controls.Add(this.label2);
            this.boxBodega.Controls.Add(this.label1);
            this.boxBodega.Controls.Add(this.btnBuscarNroTF);
            this.boxBodega.Controls.Add(this.txtResponsable);
            this.boxBodega.Controls.Add(this.txtTomaFisica);
            this.boxBodega.Controls.Add(this.lblNTomaFisica);
            this.boxBodega.Controls.Add(this.cbxMotivo);
            this.boxBodega.Controls.Add(this.cbxTipoArticulo);
            this.boxBodega.Controls.Add(this.cbxBodega);
            this.boxBodega.Location = new System.Drawing.Point(12, 27);
            this.boxBodega.Name = "boxBodega";
            this.boxBodega.Size = new System.Drawing.Size(476, 152);
            this.boxBodega.TabIndex = 107;
            this.boxBodega.TabStop = false;
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(291, 28);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(155, 20);
            this.dtFecha.TabIndex = 113;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(252, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 111;
            this.labelControl2.Text = "Fecha:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(22, 126);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 109;
            this.labelControl1.Text = "Responsable:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 102;
            this.label4.Text = "Tipo de Articulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 103;
            this.label2.Text = "Bodega: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Motivo: ";
            // 
            // btnBuscarNroTF
            // 
            this.btnBuscarNroTF.Location = new System.Drawing.Point(184, 28);
            this.btnBuscarNroTF.Name = "btnBuscarNroTF";
            this.btnBuscarNroTF.Size = new System.Drawing.Size(33, 20);
            this.btnBuscarNroTF.TabIndex = 100;
            this.btnBuscarNroTF.Text = "....";
            this.btnBuscarNroTF.Click += new System.EventHandler(this.btnBuscarNroTF_Click);
            // 
            // txtResponsable
            // 
            this.txtResponsable.Location = new System.Drawing.Point(109, 123);
            this.txtResponsable.MaxLength = 50;
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.Size = new System.Drawing.Size(337, 20);
            this.txtResponsable.TabIndex = 99;
            // 
            // txtTomaFisica
            // 
            this.txtTomaFisica.Location = new System.Drawing.Point(109, 28);
            this.txtTomaFisica.Name = "txtTomaFisica";
            this.txtTomaFisica.Size = new System.Drawing.Size(69, 20);
            this.txtTomaFisica.TabIndex = 99;
            this.txtTomaFisica.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTomaFisica_KeyPress);
            // 
            // lblNTomaFisica
            // 
            this.lblNTomaFisica.AutoSize = true;
            this.lblNTomaFisica.Location = new System.Drawing.Point(13, 31);
            this.lblNTomaFisica.Name = "lblNTomaFisica";
            this.lblNTomaFisica.Size = new System.Drawing.Size(90, 13);
            this.lblNTomaFisica.TabIndex = 98;
            this.lblNTomaFisica.Text = " No. Toma Fisica ";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.Location = new System.Drawing.Point(109, 54);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMotivo.Properties.DataSource = this.clsMotivoBindingSource;
            this.cbxMotivo.Properties.DisplayMember = "descripcion";
            this.cbxMotivo.Properties.NullText = "";
            this.cbxMotivo.Properties.PopupSizeable = false;
            this.cbxMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxMotivo.Properties.ValueMember = "codigo";
            this.cbxMotivo.Properties.View = this.gridLookUpEdit1View;
            this.cbxMotivo.Size = new System.Drawing.Size(337, 20);
            this.cbxMotivo.TabIndex = 108;
            // 
            // clsMotivoBindingSource
            // 
            this.clsMotivoBindingSource.DataSource = typeof(clases.Inventario.clsMotivo);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cbxTipoArticulo
            // 
            this.cbxTipoArticulo.Location = new System.Drawing.Point(109, 85);
            this.cbxTipoArticulo.Name = "cbxTipoArticulo";
            this.cbxTipoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTipoArticulo.Properties.DataSource = this.clsTipoArticuloBindingSource;
            this.cbxTipoArticulo.Properties.DisplayMember = "descripcion";
            this.cbxTipoArticulo.Properties.NullText = "";
            this.cbxTipoArticulo.Properties.PopupSizeable = false;
            this.cbxTipoArticulo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxTipoArticulo.Properties.ValueMember = "codigo";
            this.cbxTipoArticulo.Properties.View = this.gridView2;
            this.cbxTipoArticulo.Size = new System.Drawing.Size(134, 20);
            this.cbxTipoArticulo.TabIndex = 106;
            // 
            // clsTipoArticuloBindingSource
            // 
            this.clsTipoArticuloBindingSource.DataSource = typeof(clases.Inventario.clsTipoArticulo);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "empresa";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "codigo";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 270;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "descripcion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 910;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "estado";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // cbxBodega
            // 
            this.cbxBodega.Location = new System.Drawing.Point(296, 85);
            this.cbxBodega.Name = "cbxBodega";
            this.cbxBodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxBodega.Properties.DataSource = this.clsBodegaBindingSource;
            this.cbxBodega.Properties.DisplayMember = "descripcion";
            this.cbxBodega.Properties.NullText = "";
            this.cbxBodega.Properties.PopupSizeable = false;
            this.cbxBodega.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxBodega.Properties.ValueMember = "codigo";
            this.cbxBodega.Properties.View = this.gridView3;
            this.cbxBodega.Size = new System.Drawing.Size(150, 20);
            this.cbxBodega.TabIndex = 107;
            // 
            // clsBodegaBindingSource
            // 
            this.clsBodegaBindingSource.DataSource = typeof(clases.Inventario.clsBodega);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colempresa,
            this.colcodigo,
            this.coldescripcion,
            this.colcapacidadm2,
            this.colresponsable,
            this.colpercha,
            this.coldireccion,
            this.coltelefono,
            this.colestado,
            this.colIdBodega});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colempresa
            // 
            this.colempresa.FieldName = "empresa";
            this.colempresa.Name = "colempresa";
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 0;
            this.colcodigo.Width = 177;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 1003;
            // 
            // colcapacidadm2
            // 
            this.colcapacidadm2.FieldName = "capacidadm2";
            this.colcapacidadm2.Name = "colcapacidadm2";
            // 
            // colresponsable
            // 
            this.colresponsable.FieldName = "responsable";
            this.colresponsable.Name = "colresponsable";
            // 
            // colpercha
            // 
            this.colpercha.FieldName = "percha";
            this.colpercha.Name = "colpercha";
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            // 
            // coltelefono
            // 
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.Name = "coltelefono";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton5,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(502, 25);
            this.toolStrip1.TabIndex = 106;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "Nuevo";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton5.Text = "Guardar";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Enabled = false;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton3.Text = "Modificar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(42, 22);
            this.toolStripButton4.Text = "Salir";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // frmTomaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.boxBodega);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmTomaFisica";
            this.Text = "Toma Fisica";
            this.Load += new System.EventHandler(this.frmTomaFisica_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcTomaFisica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTomaFisicaDETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.boxBodega.ResumeLayout(false);
            this.boxBodega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTipoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gdcTomaFisica;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        internal System.Windows.Forms.GroupBox boxBodega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnBuscarNroTF;
        private System.Windows.Forms.TextBox txtTomaFisica;
        private System.Windows.Forms.Label lblNTomaFisica;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMotivo;
        private System.Windows.Forms.BindingSource clsMotivoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GridLookUpEdit cbxTipoArticulo;
        private System.Windows.Forms.BindingSource clsTipoArticuloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GridLookUpEdit cbxBodega;
        private System.Windows.Forms.BindingSource clsBodegaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource clsTomaFisicaDETBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNroTomaFisica;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmbArticulo;
        private System.Windows.Forms.BindingSource clsArticuloBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpresaArt;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArt;
        private DevExpress.XtraGrid.Columns.GridColumn colDescArt;
        private DevExpress.XtraGrid.Columns.GridColumn colFProduccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCantMinima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantMaxima;
        private DevExpress.XtraGrid.Columns.GridColumn colCantActual;
        private DevExpress.XtraGrid.Columns.GridColumn colUMed;
        private DevExpress.XtraGrid.Columns.GridColumn colFCaducidad;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoArt;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupoArt;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colSChasis;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colSMotor;
        private DevExpress.XtraGrid.Columns.GridColumn colNPlaca;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoComb;
        private DevExpress.XtraGrid.Columns.GridColumn colColorArt;
        private DevExpress.XtraGrid.Columns.GridColumn colMarcaArt;
        private DevExpress.XtraGrid.Columns.GridColumn colModeloArt;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoMat;
        private DevExpress.XtraGrid.Columns.GridColumn colObservArt;
        private DevExpress.XtraGrid.Columns.GridColumn colEstArt;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaSistema;
        private DevExpress.XtraGrid.Columns.GridColumn colExistenciaFisica;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadAjustada;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaAjuste;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colcapacidadm2;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colpercha;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colcheck;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.TextBox txtResponsable;
    }
}