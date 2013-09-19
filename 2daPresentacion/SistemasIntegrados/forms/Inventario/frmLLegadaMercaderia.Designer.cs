namespace forms.Inventario
{
    partial class frmLLegadaMercaderia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLLegadaMercaderia));
            this.gcllegada = new DevExpress.XtraGrid.GridControl();
            this.clsLlegadaMercaderiaDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvllegada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNroMovimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnumero = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.colIdPercha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbPercha = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.clsPerchaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldivisiones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadPedida = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidadLlegada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorIVA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValorTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtOrden = new DevExpress.XtraEditors.TextEdit();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbBodega = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsBodegaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcapacidadm2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresponsable = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpercha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumeroFact = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.clsMotivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbxMotivo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcllegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLlegadaMercaderiaDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvllegada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPercha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPerchaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroFact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gcllegada
            // 
            this.gcllegada.DataSource = this.clsLlegadaMercaderiaDetBindingSource;
            this.gcllegada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gcllegada.Location = new System.Drawing.Point(0, 196);
            this.gcllegada.MainView = this.gvllegada;
            this.gcllegada.Name = "gcllegada";
            this.gcllegada.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbArticulo,
            this.cmbPercha});
            this.gcllegada.Size = new System.Drawing.Size(728, 194);
            this.gcllegada.TabIndex = 0;
            this.gcllegada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvllegada});
            // 
            // clsLlegadaMercaderiaDetBindingSource
            // 
            this.clsLlegadaMercaderiaDetBindingSource.DataSource = typeof(clases.Inventario.clsLlegadaMercaderiaDet);
            // 
            // gvllegada
            // 
            this.gvllegada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpresa,
            this.colNroMovimiento,
            this.colnumero,
            this.colIdArticulo,
            this.colIdPercha,
            this.colCantidadPedida,
            this.colCantidadLlegada,
            this.colPrecio,
            this.colSubtotal,
            this.colValorIVA,
            this.colValorTotal});
            this.gvllegada.GridControl = this.gcllegada;
            this.gvllegada.Name = "gvllegada";
            this.gvllegada.OptionsView.ShowGroupPanel = false;
            this.gvllegada.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvllegada_CellValueChanged);
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colNroMovimiento
            // 
            this.colNroMovimiento.FieldName = "NroMovimiento";
            this.colNroMovimiento.Name = "colNroMovimiento";
            // 
            // colnumero
            // 
            this.colnumero.FieldName = "numero";
            this.colnumero.Name = "colnumero";
            this.colnumero.Visible = true;
            this.colnumero.VisibleIndex = 0;
            // 
            // colIdArticulo
            // 
            this.colIdArticulo.ColumnEdit = this.cmbArticulo;
            this.colIdArticulo.FieldName = "IdArticulo";
            this.colIdArticulo.Name = "colIdArticulo";
            this.colIdArticulo.OptionsColumn.AllowEdit = false;
            this.colIdArticulo.Visible = true;
            this.colIdArticulo.VisibleIndex = 1;
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
            this.colEmpresaArt.Width = 86;
            // 
            // colIdArt
            // 
            this.colIdArt.FieldName = "IdArt";
            this.colIdArt.Name = "colIdArt";
            this.colIdArt.Visible = true;
            this.colIdArt.VisibleIndex = 0;
            this.colIdArt.Width = 108;
            // 
            // colDescArt
            // 
            this.colDescArt.FieldName = "DescArt";
            this.colDescArt.Name = "colDescArt";
            this.colDescArt.Visible = true;
            this.colDescArt.VisibleIndex = 1;
            this.colDescArt.Width = 497;
            // 
            // colFProduccion
            // 
            this.colFProduccion.FieldName = "FProduccion";
            this.colFProduccion.Name = "colFProduccion";
            this.colFProduccion.Width = 65;
            // 
            // colCantMinima
            // 
            this.colCantMinima.FieldName = "CantMinima";
            this.colCantMinima.Name = "colCantMinima";
            this.colCantMinima.Width = 20;
            // 
            // colCantMaxima
            // 
            this.colCantMaxima.FieldName = "CantMaxima";
            this.colCantMaxima.Name = "colCantMaxima";
            this.colCantMaxima.Width = 21;
            // 
            // colCantActual
            // 
            this.colCantActual.FieldName = "CantActual";
            this.colCantActual.Name = "colCantActual";
            this.colCantActual.Width = 35;
            // 
            // colUMed
            // 
            this.colUMed.FieldName = "UMed";
            this.colUMed.Name = "colUMed";
            this.colUMed.Width = 36;
            // 
            // colFCaducidad
            // 
            this.colFCaducidad.FieldName = "FCaducidad";
            this.colFCaducidad.Name = "colFCaducidad";
            this.colFCaducidad.Width = 20;
            // 
            // colTipoArt
            // 
            this.colTipoArt.FieldName = "TipoArt";
            this.colTipoArt.Name = "colTipoArt";
            this.colTipoArt.Width = 37;
            // 
            // colGrupoArt
            // 
            this.colGrupoArt.FieldName = "GrupoArt";
            this.colGrupoArt.Name = "colGrupoArt";
            this.colGrupoArt.Width = 20;
            // 
            // colTipoChasis
            // 
            this.colTipoChasis.FieldName = "TipoChasis";
            this.colTipoChasis.Name = "colTipoChasis";
            this.colTipoChasis.Width = 37;
            // 
            // colSChasis
            // 
            this.colSChasis.FieldName = "SChasis";
            this.colSChasis.Name = "colSChasis";
            this.colSChasis.Width = 37;
            // 
            // colTipoMotor
            // 
            this.colTipoMotor.FieldName = "TipoMotor";
            this.colTipoMotor.Name = "colTipoMotor";
            this.colTipoMotor.Width = 45;
            // 
            // colSMotor
            // 
            this.colSMotor.FieldName = "SMotor";
            this.colSMotor.Name = "colSMotor";
            this.colSMotor.Width = 34;
            // 
            // colNPlaca
            // 
            this.colNPlaca.FieldName = "NPlaca";
            this.colNPlaca.Name = "colNPlaca";
            this.colNPlaca.Width = 34;
            // 
            // colTipoComb
            // 
            this.colTipoComb.FieldName = "TipoComb";
            this.colTipoComb.Name = "colTipoComb";
            this.colTipoComb.Width = 32;
            // 
            // colColorArt
            // 
            this.colColorArt.FieldName = "ColorArt";
            this.colColorArt.Name = "colColorArt";
            this.colColorArt.Width = 20;
            // 
            // colMarcaArt
            // 
            this.colMarcaArt.FieldName = "MarcaArt";
            this.colMarcaArt.Name = "colMarcaArt";
            this.colMarcaArt.Width = 32;
            // 
            // colModeloArt
            // 
            this.colModeloArt.FieldName = "ModeloArt";
            this.colModeloArt.Name = "colModeloArt";
            this.colModeloArt.Width = 20;
            // 
            // colTipoMat
            // 
            this.colTipoMat.FieldName = "TipoMat";
            this.colTipoMat.Name = "colTipoMat";
            this.colTipoMat.Width = 20;
            // 
            // colObservArt
            // 
            this.colObservArt.FieldName = "ObservArt";
            this.colObservArt.Name = "colObservArt";
            this.colObservArt.Width = 44;
            // 
            // colEstArt
            // 
            this.colEstArt.FieldName = "EstArt";
            this.colEstArt.Name = "colEstArt";
            this.colEstArt.Width = 87;
            // 
            // colIdPercha
            // 
            this.colIdPercha.ColumnEdit = this.cmbPercha;
            this.colIdPercha.FieldName = "IdPercha";
            this.colIdPercha.Name = "colIdPercha";
            this.colIdPercha.Visible = true;
            this.colIdPercha.VisibleIndex = 2;
            // 
            // cmbPercha
            // 
            this.cmbPercha.AutoHeight = false;
            this.cmbPercha.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPercha.DataSource = this.clsPerchaBindingSource;
            this.cmbPercha.DisplayMember = "descripcion";
            this.cmbPercha.Name = "cmbPercha";
            this.cmbPercha.ValueMember = "codigo";
            this.cmbPercha.View = this.gridView1;
            // 
            // clsPerchaBindingSource
            // 
            this.clsPerchaBindingSource.DataSource = typeof(clases.Inventario.clsPercha);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colempresa,
            this.colcodigo,
            this.coldescripcion,
            this.coldivisiones,
            this.colbodega,
            this.colestado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.colcodigo.Width = 227;
            // 
            // coldescripcion
            // 
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 1;
            this.coldescripcion.Width = 378;
            // 
            // coldivisiones
            // 
            this.coldivisiones.FieldName = "divisiones";
            this.coldivisiones.Name = "coldivisiones";
            // 
            // colbodega
            // 
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            // 
            // colCantidadPedida
            // 
            this.colCantidadPedida.FieldName = "CantidadPedida";
            this.colCantidadPedida.Name = "colCantidadPedida";
            this.colCantidadPedida.OptionsColumn.AllowEdit = false;
            this.colCantidadPedida.Visible = true;
            this.colCantidadPedida.VisibleIndex = 3;
            // 
            // colCantidadLlegada
            // 
            this.colCantidadLlegada.FieldName = "CantidadLlegada";
            this.colCantidadLlegada.Name = "colCantidadLlegada";
            this.colCantidadLlegada.Visible = true;
            this.colCantidadLlegada.VisibleIndex = 4;
            // 
            // colPrecio
            // 
            this.colPrecio.FieldName = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.Visible = true;
            this.colPrecio.VisibleIndex = 5;
            // 
            // colSubtotal
            // 
            this.colSubtotal.FieldName = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.Visible = true;
            this.colSubtotal.VisibleIndex = 6;
            // 
            // colValorIVA
            // 
            this.colValorIVA.FieldName = "ValorIVA";
            this.colValorIVA.Name = "colValorIVA";
            this.colValorIVA.Visible = true;
            this.colValorIVA.VisibleIndex = 7;
            // 
            // colValorTotal
            // 
            this.colValorTotal.FieldName = "ValorTotal";
            this.colValorTotal.Name = "colValorTotal";
            this.colValorTotal.Visible = true;
            this.colValorTotal.VisibleIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpiar,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(728, 25);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::forms.Properties.Resources.limpiar1;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(58, 22);
            this.btnLimpiar.Tag = "";
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(66, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(112, 38);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Properties.Mask.EditMask = "\\d+";
            this.txtOrden.Properties.Mask.IgnoreMaskBlank = false;
            this.txtOrden.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtOrden.Properties.Mask.ShowPlaceHolders = false;
            this.txtOrden.Size = new System.Drawing.Size(97, 20);
            this.txtOrden.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(215, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbBodega
            // 
            this.cmbBodega.Location = new System.Drawing.Point(112, 71);
            this.cmbBodega.Name = "cmbBodega";
            this.cmbBodega.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBodega.Properties.DataSource = this.clsBodegaBindingSource;
            this.cmbBodega.Properties.DisplayMember = "descripcion";
            this.cmbBodega.Properties.ValueMember = "codigo";
            this.cmbBodega.Properties.View = this.gridLookUpEdit1View;
            this.cmbBodega.Size = new System.Drawing.Size(159, 20);
            this.cmbBodega.TabIndex = 16;
            // 
            // clsBodegaBindingSource
            // 
            this.clsBodegaBindingSource.DataSource = typeof(clases.Inventario.clsBodega);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.colcapacidadm2,
            this.colresponsable,
            this.colpercha,
            this.coldireccion,
            this.coltelefono,
            this.gridColumn4,
            this.colIdBodega});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.gridColumn2.Width = 244;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "descripcion";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 850;
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
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "estado";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // colIdBodega
            // 
            this.colIdBodega.FieldName = "IdBodega";
            this.colIdBodega.Name = "colIdBodega";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bodega";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(100, 144);
            this.txtObservacion.MaxLength = 150;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(616, 43);
            this.txtObservacion.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Observaciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Orden de Compra";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(608, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha";
            // 
            // txtNumeroFact
            // 
            this.txtNumeroFact.Location = new System.Drawing.Point(600, 106);
            this.txtNumeroFact.Name = "txtNumeroFact";
            this.txtNumeroFact.Properties.Mask.EditMask = "\\d+";
            this.txtNumeroFact.Properties.Mask.IgnoreMaskBlank = false;
            this.txtNumeroFact.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNumeroFact.Properties.Mask.ShowPlaceHolders = false;
            this.txtNumeroFact.Size = new System.Drawing.Size(116, 20);
            this.txtNumeroFact.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(498, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Numero de Factura";
            // 
            // clsMotivoBindingSource
            // 
            this.clsMotivoBindingSource.DataSource = typeof(clases.Inventario.clsMotivo);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 109;
            this.label6.Text = "Motivo: ";
            // 
            // cbxMotivo
            // 
            this.cbxMotivo.Location = new System.Drawing.Point(112, 110);
            this.cbxMotivo.Name = "cbxMotivo";
            this.cbxMotivo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxMotivo.Properties.DataSource = this.clsMotivoBindingSource;
            this.cbxMotivo.Properties.DisplayMember = "descripcion";
            this.cbxMotivo.Properties.NullText = "";
            this.cbxMotivo.Properties.PopupSizeable = false;
            this.cbxMotivo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxMotivo.Properties.ValueMember = "codigo";
            this.cbxMotivo.Properties.View = this.gridView2;
            this.cbxMotivo.Size = new System.Drawing.Size(159, 20);
            this.cbxMotivo.TabIndex = 110;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // frmLLegadaMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 390);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxMotivo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBodega);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNumeroFact);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gcllegada);
            this.Name = "frmLLegadaMercaderia";
            this.Text = "LLegada de Mercaderia";
            this.Load += new System.EventHandler(this.frmLLegadaMercaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcllegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsLlegadaMercaderiaDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvllegada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPercha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPerchaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrden.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBodega.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsBodegaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumeroFact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMotivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxMotivo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcllegada;
        private DevExpress.XtraGrid.Views.Grid.GridView gvllegada;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.BindingSource clsLlegadaMercaderiaDetBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colNroMovimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colnumero;
        private DevExpress.XtraGrid.Columns.GridColumn colIdArticulo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPercha;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadPedida;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidadLlegada;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecio;
        private DevExpress.XtraGrid.Columns.GridColumn colSubtotal;
        private DevExpress.XtraGrid.Columns.GridColumn colValorIVA;
        private DevExpress.XtraGrid.Columns.GridColumn colValorTotal;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit cmbPercha;
        private System.Windows.Forms.BindingSource clsPerchaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn coldivisiones;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
        private DevExpress.XtraEditors.TextEdit txtOrden;
        private System.Windows.Forms.Button btnBuscar;
        private DevExpress.XtraEditors.GridLookUpEdit cmbBodega;
        private System.Windows.Forms.BindingSource clsBodegaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colcapacidadm2;
        private DevExpress.XtraGrid.Columns.GridColumn colresponsable;
        private DevExpress.XtraGrid.Columns.GridColumn colpercha;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colIdBodega;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtNumeroFact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource clsMotivoBindingSource;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.GridLookUpEdit cbxMotivo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}