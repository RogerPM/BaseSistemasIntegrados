namespace forms.Inventario
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnConsultar = new System.Windows.Forms.ToolStripButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_observacion = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_codigo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_tipoArticulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_grupoArticulo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsGrupoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabControl_Art = new DevExpress.XtraTab.XtraTabControl();
            this.Vehiculos = new DevExpress.XtraTab.XtraTabPage();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_serieMotor = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_NroChasis = new DevExpress.XtraEditors.TextEdit();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Placa = new DevExpress.XtraEditors.TextEdit();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_cantActual = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cantMaxima = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cantMinima = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_marca = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_Modelo = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsModeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_Color = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsColorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_TipoMotor = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoMotorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_TipoCombustible = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoCombustibleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_TipoChasis = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsTipoChasisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_estado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView22 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Accesorios = new DevExpress.XtraTab.XtraTabPage();
            this.label43 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_DescripAcc = new DevExpress.XtraEditors.TextEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.txt_cantActAcc = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_cantMaxAcc = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantMinAcc = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.cbx_MarcaAcc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_tipoMatAcc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView9 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_UMedAcc = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView10 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sum_Oficina = new DevExpress.XtraTab.XtraTabPage();
            this.label47 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_DescripSO = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_cantActSO = new DevExpress.XtraEditors.TextEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_cantMaxSO = new DevExpress.XtraEditors.TextEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_cantMinSO = new DevExpress.XtraEditors.TextEdit();
            this.label18 = new System.Windows.Forms.Label();
            this.cbx_tMatSO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView11 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_UMedSO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView12 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_MarcaSO = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView13 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Art_Limpieza = new DevExpress.XtraTab.XtraTabPage();
            this.dtp_fechaCaducidad = new System.Windows.Forms.DateTimePicker();
            this.label48 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_DescripcionAL = new DevExpress.XtraEditors.TextEdit();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_cantActAL = new DevExpress.XtraEditors.TextEdit();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_cantMaxAL = new DevExpress.XtraEditors.TextEdit();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_cantMinAL = new DevExpress.XtraEditors.TextEdit();
            this.label35 = new System.Windows.Forms.Label();
            this.cbx_tMaterialAL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView14 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_uMedAL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView15 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_MarcaAL = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView16 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Art_Act_Fij = new DevExpress.XtraTab.XtraTabPage();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txt_DescripcionAF = new DevExpress.XtraEditors.TextEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_cantActAF = new DevExpress.XtraEditors.TextEdit();
            this.label39 = new System.Windows.Forms.Label();
            this.txt_cantMaxAF = new DevExpress.XtraEditors.TextEdit();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_cantMinAF = new DevExpress.XtraEditors.TextEdit();
            this.label41 = new System.Windows.Forms.Label();
            this.cbx_tMatAF = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView17 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_uMedidaAF = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView18 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_MarcaAF = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView19 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_ModeloAF = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView20 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion22 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbx_ColorAF = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridView21 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion23 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tipoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_grupoArticulo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Art)).BeginInit();
            this.TabControl_Art.SuspendLayout();
            this.Vehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serieMotor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NroChasis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Placa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActual.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinima.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_marca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Modelo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Color.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsColorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoMotor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoMotorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoCombustible.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoCombustibleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoChasis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoChasisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).BeginInit();
            this.Accesorios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tipoMatAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_UMedAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).BeginInit();
            this.Sum_Oficina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMatSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_UMedSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaSO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).BeginInit();
            this.Art_Limpieza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMaterialAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_uMedAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).BeginInit();
            this.Art_Act_Fij.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMatAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_uMedidaAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ModeloAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ColorAF.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLimpiar,
            this.toolStripSeparator1,
            this.btnGuardar,
            this.toolStripSeparator2,
            this.btnModificar,
            this.toolStripSeparator3,
            this.btnEliminar,
            this.btnConsultar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(788, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::forms.Properties.Resources.limpiar1;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 22);
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
            this.btnGuardar.Size = new System.Drawing.Size(57, 22);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(62, 22);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(57, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(63, 22);
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtp_fecha);
            this.groupControl1.Controls.Add(this.txt_observacion);
            this.groupControl1.Controls.Add(this.label10);
            this.groupControl1.Controls.Add(this.txt_codigo);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.cbx_tipoArticulo);
            this.groupControl1.Controls.Add(this.cbx_grupoArticulo);
            this.groupControl1.Location = new System.Drawing.Point(7, 28);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(774, 169);
            this.groupControl1.TabIndex = 42;
            this.groupControl1.Text = "Datos Generales :";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(576, 38);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(167, 20);
            this.dtp_fecha.TabIndex = 39;
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(5, 126);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(739, 20);
            this.txt_observacion.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(7, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Observación :";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(576, 77);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(87, 20);
            this.txt_codigo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(5, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo de Artículo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(578, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Código :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(196, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grupo de Artículo :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(578, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha :";
            // 
            // cbx_tipoArticulo
            // 
            this.cbx_tipoArticulo.EditValue = "";
            this.cbx_tipoArticulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbx_tipoArticulo.Location = new System.Drawing.Point(5, 76);
            this.cbx_tipoArticulo.Name = "cbx_tipoArticulo";
            this.cbx_tipoArticulo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbx_tipoArticulo.Properties.Appearance.Options.UseBackColor = true;
            this.cbx_tipoArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbx_tipoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_tipoArticulo.Properties.DataSource = this.clsTipoArticuloBindingSource;
            this.cbx_tipoArticulo.Properties.DisplayMember = "descripcion";
            this.cbx_tipoArticulo.Properties.NullText = "";
            this.cbx_tipoArticulo.Properties.PopupSizeable = false;
            this.cbx_tipoArticulo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_tipoArticulo.Properties.ValueMember = "codigo";
            this.cbx_tipoArticulo.Properties.View = this.gridLookUpEdit1View;
            this.cbx_tipoArticulo.Size = new System.Drawing.Size(167, 22);
            this.cbx_tipoArticulo.TabIndex = 36;
            // 
            // clsTipoArticuloBindingSource
            // 
            this.clsTipoArticuloBindingSource.DataSource = typeof(clases.Inventario.clsTipoArticulo);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            this.coldescripcion.Width = 499;
            // 
            // cbx_grupoArticulo
            // 
            this.cbx_grupoArticulo.Location = new System.Drawing.Point(199, 76);
            this.cbx_grupoArticulo.Name = "cbx_grupoArticulo";
            this.cbx_grupoArticulo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.cbx_grupoArticulo.Properties.Appearance.Options.UseBackColor = true;
            this.cbx_grupoArticulo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.cbx_grupoArticulo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_grupoArticulo.Properties.DataSource = this.clsGrupoBindingSource;
            this.cbx_grupoArticulo.Properties.DisplayMember = "descripcion";
            this.cbx_grupoArticulo.Properties.NullText = "";
            this.cbx_grupoArticulo.Properties.PopupSizeable = false;
            this.cbx_grupoArticulo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_grupoArticulo.Properties.ValueMember = "codigo";
            this.cbx_grupoArticulo.Properties.View = this.gridView1;
            this.cbx_grupoArticulo.Size = new System.Drawing.Size(182, 22);
            this.cbx_grupoArticulo.TabIndex = 37;
            this.cbx_grupoArticulo.EditValueChanged += new System.EventHandler(this.cbx_grupoArticulo_EditValueChanged_1);
            // 
            // clsGrupoBindingSource
            // 
            this.clsGrupoBindingSource.DataSource = typeof(clases.Inventario.clsGrupo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion3});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion3
            // 
            this.coldescripcion3.FieldName = "descripcion";
            this.coldescripcion3.Name = "coldescripcion3";
            this.coldescripcion3.Visible = true;
            this.coldescripcion3.VisibleIndex = 0;
            // 
            // TabControl_Art
            // 
            this.TabControl_Art.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.TabControl_Art.Appearance.Options.UseBackColor = true;
            this.TabControl_Art.Appearance.Options.UseImage = true;
            this.TabControl_Art.BackgroundImage = global::forms.Properties.Resources.VEHICULOS;
            this.TabControl_Art.Location = new System.Drawing.Point(8, 203);
            this.TabControl_Art.Name = "TabControl_Art";
            this.TabControl_Art.SelectedTabPage = this.Vehiculos;
            this.TabControl_Art.Size = new System.Drawing.Size(773, 345);
            this.TabControl_Art.TabIndex = 43;
            this.TabControl_Art.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.Vehiculos,
            this.Accesorios,
            this.Sum_Oficina,
            this.Art_Limpieza,
            this.Art_Act_Fij});
            this.TabControl_Art.Visible = false;
            // 
            // Vehiculos
            // 
            this.Vehiculos.Appearance.Header.BackColor = System.Drawing.Color.White;
            this.Vehiculos.Appearance.Header.Options.UseBackColor = true;
            this.Vehiculos.Appearance.PageClient.BackColor = System.Drawing.Color.Black;
            this.Vehiculos.Appearance.PageClient.BackColor2 = System.Drawing.Color.White;
            this.Vehiculos.Appearance.PageClient.Options.UseBackColor = true;
            this.Vehiculos.AutoScroll = true;
            this.Vehiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vehiculos.Controls.Add(this.txt_descripcion);
            this.Vehiculos.Controls.Add(this.labelControl2);
            this.Vehiculos.Controls.Add(this.labelControl1);
            this.Vehiculos.Controls.Add(this.txt_serieMotor);
            this.Vehiculos.Controls.Add(this.label4);
            this.Vehiculos.Controls.Add(this.label29);
            this.Vehiculos.Controls.Add(this.label28);
            this.Vehiculos.Controls.Add(this.txt_NroChasis);
            this.Vehiculos.Controls.Add(this.label27);
            this.Vehiculos.Controls.Add(this.label26);
            this.Vehiculos.Controls.Add(this.label25);
            this.Vehiculos.Controls.Add(this.label24);
            this.Vehiculos.Controls.Add(this.label23);
            this.Vehiculos.Controls.Add(this.txt_Placa);
            this.Vehiculos.Controls.Add(this.label22);
            this.Vehiculos.Controls.Add(this.txt_cantActual);
            this.Vehiculos.Controls.Add(this.label8);
            this.Vehiculos.Controls.Add(this.txt_cantMaxima);
            this.Vehiculos.Controls.Add(this.label6);
            this.Vehiculos.Controls.Add(this.txt_cantMinima);
            this.Vehiculos.Controls.Add(this.label5);
            this.Vehiculos.Controls.Add(this.cbx_marca);
            this.Vehiculos.Controls.Add(this.cbx_Modelo);
            this.Vehiculos.Controls.Add(this.cbx_Color);
            this.Vehiculos.Controls.Add(this.cbx_TipoMotor);
            this.Vehiculos.Controls.Add(this.cbx_TipoCombustible);
            this.Vehiculos.Controls.Add(this.cbx_TipoChasis);
            this.Vehiculos.Controls.Add(this.txt_estado);
            this.Vehiculos.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vehiculos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Vehiculos.Name = "Vehiculos";
            this.Vehiculos.Size = new System.Drawing.Size(767, 305);
            this.Vehiculos.Text = "Vehículos";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(14, 146);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(526, 54);
            this.txt_descripcion.TabIndex = 31;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(295, 51);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 13);
            this.labelControl2.TabIndex = 30;
            this.labelControl2.Text = "Tipo de Chasis :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 91);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Serie de Motor :";
            // 
            // txt_serieMotor
            // 
            this.txt_serieMotor.Location = new System.Drawing.Point(14, 107);
            this.txt_serieMotor.Name = "txt_serieMotor";
            this.txt_serieMotor.Size = new System.Drawing.Size(231, 20);
            this.txt_serieMotor.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Estado :";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(11, 130);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "Descripción :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(577, 130);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(39, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Placa :";
            // 
            // txt_NroChasis
            // 
            this.txt_NroChasis.Location = new System.Drawing.Point(295, 107);
            this.txt_NroChasis.Name = "txt_NroChasis";
            this.txt_NroChasis.Size = new System.Drawing.Size(237, 20);
            this.txt_NroChasis.TabIndex = 21;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(13, 48);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 13);
            this.label27.TabIndex = 18;
            this.label27.Text = "Tipo de Motor :";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(577, 51);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(110, 13);
            this.label26.TabIndex = 17;
            this.label26.Text = "Tipo de Combustible :";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(295, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(87, 13);
            this.label25.TabIndex = 16;
            this.label25.Text = "Serie de Chasis :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(577, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(39, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Color :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(295, 6);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(48, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Modelo :";
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(574, 146);
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Properties.MaxLength = 8;
            this.txt_Placa.Size = new System.Drawing.Size(103, 20);
            this.txt_Placa.TabIndex = 10;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "Marca :";
            // 
            // txt_cantActual
            // 
            this.txt_cantActual.Location = new System.Drawing.Point(258, 220);
            this.txt_cantActual.Name = "txt_cantActual";
            this.txt_cantActual.Size = new System.Drawing.Size(108, 20);
            this.txt_cantActual.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Unidades Actual :";
            // 
            // txt_cantMaxima
            // 
            this.txt_cantMaxima.Location = new System.Drawing.Point(131, 220);
            this.txt_cantMaxima.Name = "txt_cantMaxima";
            this.txt_cantMaxima.Size = new System.Drawing.Size(93, 20);
            this.txt_cantMaxima.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unidades máxima :";
            // 
            // txt_cantMinima
            // 
            this.txt_cantMinima.Location = new System.Drawing.Point(17, 220);
            this.txt_cantMinima.Name = "txt_cantMinima";
            this.txt_cantMinima.Size = new System.Drawing.Size(89, 20);
            this.txt_cantMinima.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Unidades mínima :";
            // 
            // cbx_marca
            // 
            this.cbx_marca.Location = new System.Drawing.Point(11, 22);
            this.cbx_marca.Name = "cbx_marca";
            this.cbx_marca.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_marca.Properties.DataSource = this.clsMarcaBindingSource;
            this.cbx_marca.Properties.DisplayMember = "descripcion";
            this.cbx_marca.Properties.NullText = "";
            this.cbx_marca.Properties.PopupSizeable = false;
            this.cbx_marca.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_marca.Properties.ValueMember = "codigo";
            this.cbx_marca.Properties.View = this.gridView2;
            this.cbx_marca.Size = new System.Drawing.Size(231, 20);
            this.cbx_marca.TabIndex = 11;
            // 
            // clsMarcaBindingSource
            // 
            this.clsMarcaBindingSource.DataSource = typeof(clases.Inventario.clsMarca);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion4});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion4
            // 
            this.coldescripcion4.FieldName = "descripcion";
            this.coldescripcion4.Name = "coldescripcion4";
            this.coldescripcion4.Visible = true;
            this.coldescripcion4.VisibleIndex = 0;
            // 
            // cbx_Modelo
            // 
            this.cbx_Modelo.Location = new System.Drawing.Point(292, 22);
            this.cbx_Modelo.Name = "cbx_Modelo";
            this.cbx_Modelo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Modelo.Properties.DataSource = this.clsModeloBindingSource;
            this.cbx_Modelo.Properties.DisplayMember = "descripcion";
            this.cbx_Modelo.Properties.NullText = "";
            this.cbx_Modelo.Properties.PopupSizeable = false;
            this.cbx_Modelo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_Modelo.Properties.ValueMember = "codigo";
            this.cbx_Modelo.Properties.View = this.gridView3;
            this.cbx_Modelo.Size = new System.Drawing.Size(237, 20);
            this.cbx_Modelo.TabIndex = 13;
            // 
            // clsModeloBindingSource
            // 
            this.clsModeloBindingSource.DataSource = typeof(clases.Inventario.clsModelo);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion6});
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion6
            // 
            this.coldescripcion6.FieldName = "descripcion";
            this.coldescripcion6.Name = "coldescripcion6";
            this.coldescripcion6.Visible = true;
            this.coldescripcion6.VisibleIndex = 0;
            // 
            // cbx_Color
            // 
            this.cbx_Color.Location = new System.Drawing.Point(574, 22);
            this.cbx_Color.Name = "cbx_Color";
            this.cbx_Color.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_Color.Properties.DataSource = this.clsColorBindingSource;
            this.cbx_Color.Properties.DisplayMember = "descripcion";
            this.cbx_Color.Properties.NullText = "";
            this.cbx_Color.Properties.PopupSizeable = false;
            this.cbx_Color.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_Color.Properties.ValueMember = "codigo";
            this.cbx_Color.Properties.View = this.gridView4;
            this.cbx_Color.Size = new System.Drawing.Size(165, 20);
            this.cbx_Color.TabIndex = 15;
            // 
            // clsColorBindingSource
            // 
            this.clsColorBindingSource.DataSource = typeof(clases.Inventario.clsColor);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion7});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion7
            // 
            this.coldescripcion7.FieldName = "descripcion";
            this.coldescripcion7.Name = "coldescripcion7";
            this.coldescripcion7.Visible = true;
            this.coldescripcion7.VisibleIndex = 0;
            // 
            // cbx_TipoMotor
            // 
            this.cbx_TipoMotor.Location = new System.Drawing.Point(11, 64);
            this.cbx_TipoMotor.Name = "cbx_TipoMotor";
            this.cbx_TipoMotor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_TipoMotor.Properties.DataSource = this.clsTipoMotorBindingSource;
            this.cbx_TipoMotor.Properties.DisplayMember = "descripcion";
            this.cbx_TipoMotor.Properties.NullText = "";
            this.cbx_TipoMotor.Properties.PopupSizeable = false;
            this.cbx_TipoMotor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_TipoMotor.Properties.ValueMember = "codigo";
            this.cbx_TipoMotor.Properties.View = this.gridView5;
            this.cbx_TipoMotor.Size = new System.Drawing.Size(231, 20);
            this.cbx_TipoMotor.TabIndex = 19;
            // 
            // clsTipoMotorBindingSource
            // 
            this.clsTipoMotorBindingSource.DataSource = typeof(clases.Inventario.clsTipoMotor);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion5});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion5
            // 
            this.coldescripcion5.FieldName = "descripcion";
            this.coldescripcion5.Name = "coldescripcion5";
            this.coldescripcion5.Visible = true;
            this.coldescripcion5.VisibleIndex = 0;
            // 
            // cbx_TipoCombustible
            // 
            this.cbx_TipoCombustible.Location = new System.Drawing.Point(574, 67);
            this.cbx_TipoCombustible.Name = "cbx_TipoCombustible";
            this.cbx_TipoCombustible.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_TipoCombustible.Properties.DataSource = this.clsTipoCombustibleBindingSource;
            this.cbx_TipoCombustible.Properties.DisplayMember = "descripcion";
            this.cbx_TipoCombustible.Properties.NullText = "";
            this.cbx_TipoCombustible.Properties.PopupSizeable = false;
            this.cbx_TipoCombustible.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_TipoCombustible.Properties.ValueMember = "codigo";
            this.cbx_TipoCombustible.Properties.View = this.gridView6;
            this.cbx_TipoCombustible.Size = new System.Drawing.Size(165, 20);
            this.cbx_TipoCombustible.TabIndex = 20;
            // 
            // clsTipoCombustibleBindingSource
            // 
            this.clsTipoCombustibleBindingSource.DataSource = typeof(clases.Inventario.clsTipoCombustible);
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion8});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion8
            // 
            this.coldescripcion8.FieldName = "descripcion";
            this.coldescripcion8.Name = "coldescripcion8";
            this.coldescripcion8.Visible = true;
            this.coldescripcion8.VisibleIndex = 0;
            // 
            // cbx_TipoChasis
            // 
            this.cbx_TipoChasis.Location = new System.Drawing.Point(292, 67);
            this.cbx_TipoChasis.Name = "cbx_TipoChasis";
            this.cbx_TipoChasis.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_TipoChasis.Properties.DataSource = this.clsTipoChasisBindingSource;
            this.cbx_TipoChasis.Properties.DisplayMember = "descripcion";
            this.cbx_TipoChasis.Properties.NullText = "";
            this.cbx_TipoChasis.Properties.PopupSizeable = false;
            this.cbx_TipoChasis.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_TipoChasis.Properties.ValueMember = "codigo";
            this.cbx_TipoChasis.Properties.View = this.gridView7;
            this.cbx_TipoChasis.Size = new System.Drawing.Size(237, 20);
            this.cbx_TipoChasis.TabIndex = 29;
            // 
            // clsTipoChasisBindingSource
            // 
            this.clsTipoChasisBindingSource.DataSource = typeof(clases.Inventario.clsTipoChasis);
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion9});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion9
            // 
            this.coldescripcion9.FieldName = "descripcion";
            this.coldescripcion9.Name = "coldescripcion9";
            this.coldescripcion9.Visible = true;
            this.coldescripcion9.VisibleIndex = 0;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(577, 107);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_estado.Properties.DataSource = this.clsEstadoBindingSource;
            this.txt_estado.Properties.DisplayMember = "descripcion";
            this.txt_estado.Properties.NullText = "";
            this.txt_estado.Properties.ValueMember = "codigo";
            this.txt_estado.Properties.View = this.gridView22;
            this.txt_estado.Size = new System.Drawing.Size(165, 20);
            this.txt_estado.TabIndex = 25;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridView22
            // 
            this.gridView22.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion2});
            this.gridView22.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView22.Name = "gridView22";
            this.gridView22.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView22.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion2
            // 
            this.coldescripcion2.Caption = "Descripcion";
            this.coldescripcion2.FieldName = "descripcion";
            this.coldescripcion2.Name = "coldescripcion2";
            this.coldescripcion2.Visible = true;
            this.coldescripcion2.VisibleIndex = 0;
            // 
            // Accesorios
            // 
            this.Accesorios.Controls.Add(this.label43);
            this.Accesorios.Controls.Add(this.label32);
            this.Accesorios.Controls.Add(this.label31);
            this.Accesorios.Controls.Add(this.txt_DescripAcc);
            this.Accesorios.Controls.Add(this.label30);
            this.Accesorios.Controls.Add(this.txt_cantActAcc);
            this.Accesorios.Controls.Add(this.label9);
            this.Accesorios.Controls.Add(this.txt_cantMaxAcc);
            this.Accesorios.Controls.Add(this.label11);
            this.Accesorios.Controls.Add(this.txt_cantMinAcc);
            this.Accesorios.Controls.Add(this.label12);
            this.Accesorios.Controls.Add(this.cbx_MarcaAcc);
            this.Accesorios.Controls.Add(this.cbx_tipoMatAcc);
            this.Accesorios.Controls.Add(this.cbx_UMedAcc);
            this.Accesorios.Image = global::forms.Properties.Resources.llanta_qind_27_8_121;
            this.Accesorios.Name = "Accesorios";
            this.Accesorios.Size = new System.Drawing.Size(767, 305);
            this.Accesorios.Text = "Accesorios";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(42, 101);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(43, 13);
            this.label43.TabIndex = 33;
            this.label43.Text = "Marca :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(512, 101);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 31;
            this.label32.Text = "Unidad de medida :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(274, 101);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(89, 13);
            this.label31.TabIndex = 29;
            this.label31.Text = "Tipo de Material .";
            // 
            // txt_DescripAcc
            // 
            this.txt_DescripAcc.Location = new System.Drawing.Point(45, 180);
            this.txt_DescripAcc.Name = "txt_DescripAcc";
            this.txt_DescripAcc.Size = new System.Drawing.Size(673, 20);
            this.txt_DescripAcc.TabIndex = 28;
            this.txt_DescripAcc.EditValueChanged += new System.EventHandler(this.txt_DescripAcc_EditValueChanged);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(42, 163);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 13);
            this.label30.TabIndex = 27;
            this.label30.Text = "Descripción :";
            // 
            // txt_cantActAcc
            // 
            this.txt_cantActAcc.Location = new System.Drawing.Point(511, 68);
            this.txt_cantActAcc.Name = "txt_cantActAcc";
            this.txt_cantActAcc.Size = new System.Drawing.Size(207, 20);
            this.txt_cantActAcc.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cantidad Actual :";
            // 
            // txt_cantMaxAcc
            // 
            this.txt_cantMaxAcc.Location = new System.Drawing.Point(277, 68);
            this.txt_cantMaxAcc.Name = "txt_cantMaxAcc";
            this.txt_cantMaxAcc.Size = new System.Drawing.Size(186, 20);
            this.txt_cantMaxAcc.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cantidad máxima :";
            // 
            // txt_cantMinAcc
            // 
            this.txt_cantMinAcc.Location = new System.Drawing.Point(45, 68);
            this.txt_cantMinAcc.Name = "txt_cantMinAcc";
            this.txt_cantMinAcc.Size = new System.Drawing.Size(168, 20);
            this.txt_cantMinAcc.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Cantidad mínima :";
            // 
            // cbx_MarcaAcc
            // 
            this.cbx_MarcaAcc.Location = new System.Drawing.Point(45, 118);
            this.cbx_MarcaAcc.Name = "cbx_MarcaAcc";
            this.cbx_MarcaAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_MarcaAcc.Properties.DisplayMember = "descripcion";
            this.cbx_MarcaAcc.Properties.NullText = "";
            this.cbx_MarcaAcc.Properties.PopupSizeable = false;
            this.cbx_MarcaAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_MarcaAcc.Properties.ValueMember = "codigo";
            this.cbx_MarcaAcc.Properties.View = this.gridView8;
            this.cbx_MarcaAcc.Size = new System.Drawing.Size(168, 20);
            this.cbx_MarcaAcc.TabIndex = 34;
            // 
            // gridView8
            // 
            this.gridView8.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion10});
            this.gridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView8.Name = "gridView8";
            this.gridView8.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView8.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion10
            // 
            this.coldescripcion10.FieldName = "descripcion";
            this.coldescripcion10.Name = "coldescripcion10";
            this.coldescripcion10.Visible = true;
            this.coldescripcion10.VisibleIndex = 0;
            // 
            // cbx_tipoMatAcc
            // 
            this.cbx_tipoMatAcc.Location = new System.Drawing.Point(277, 118);
            this.cbx_tipoMatAcc.Name = "cbx_tipoMatAcc";
            this.cbx_tipoMatAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_tipoMatAcc.Properties.DisplayMember = "descripcion";
            this.cbx_tipoMatAcc.Properties.NullText = "";
            this.cbx_tipoMatAcc.Properties.PopupSizeable = false;
            this.cbx_tipoMatAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_tipoMatAcc.Properties.ValueMember = "codigo";
            this.cbx_tipoMatAcc.Properties.View = this.gridView9;
            this.cbx_tipoMatAcc.Size = new System.Drawing.Size(168, 20);
            this.cbx_tipoMatAcc.TabIndex = 30;
            // 
            // gridView9
            // 
            this.gridView9.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion11});
            this.gridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView9.Name = "gridView9";
            this.gridView9.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView9.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion11
            // 
            this.coldescripcion11.FieldName = "descripcion";
            this.coldescripcion11.Name = "coldescripcion11";
            this.coldescripcion11.Visible = true;
            this.coldescripcion11.VisibleIndex = 0;
            // 
            // cbx_UMedAcc
            // 
            this.cbx_UMedAcc.Location = new System.Drawing.Point(511, 121);
            this.cbx_UMedAcc.Name = "cbx_UMedAcc";
            this.cbx_UMedAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_UMedAcc.Properties.DisplayMember = "descripcion";
            this.cbx_UMedAcc.Properties.NullText = "";
            this.cbx_UMedAcc.Properties.PopupSizeable = false;
            this.cbx_UMedAcc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_UMedAcc.Properties.ValueMember = "codigo";
            this.cbx_UMedAcc.Properties.View = this.gridView10;
            this.cbx_UMedAcc.Size = new System.Drawing.Size(186, 20);
            this.cbx_UMedAcc.TabIndex = 32;
            // 
            // gridView10
            // 
            this.gridView10.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion12});
            this.gridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView10.Name = "gridView10";
            this.gridView10.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView10.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion12
            // 
            this.coldescripcion12.FieldName = "descripcion";
            this.coldescripcion12.Name = "coldescripcion12";
            this.coldescripcion12.Visible = true;
            this.coldescripcion12.VisibleIndex = 0;
            // 
            // Sum_Oficina
            // 
            this.Sum_Oficina.Controls.Add(this.label47);
            this.Sum_Oficina.Controls.Add(this.label13);
            this.Sum_Oficina.Controls.Add(this.label14);
            this.Sum_Oficina.Controls.Add(this.txt_DescripSO);
            this.Sum_Oficina.Controls.Add(this.label15);
            this.Sum_Oficina.Controls.Add(this.txt_cantActSO);
            this.Sum_Oficina.Controls.Add(this.label16);
            this.Sum_Oficina.Controls.Add(this.txt_cantMaxSO);
            this.Sum_Oficina.Controls.Add(this.label17);
            this.Sum_Oficina.Controls.Add(this.txt_cantMinSO);
            this.Sum_Oficina.Controls.Add(this.label18);
            this.Sum_Oficina.Controls.Add(this.cbx_tMatSO);
            this.Sum_Oficina.Controls.Add(this.cbx_UMedSO);
            this.Sum_Oficina.Controls.Add(this.cbx_MarcaSO);
            this.Sum_Oficina.Image = global::forms.Properties.Resources.Suministros;
            this.Sum_Oficina.Name = "Sum_Oficina";
            this.Sum_Oficina.Size = new System.Drawing.Size(767, 305);
            this.Sum_Oficina.Text = "Suministros de Oficina";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(508, 104);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(43, 13);
            this.label47.TabIndex = 35;
            this.label47.Text = "Marca :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(278, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Unidad de medida :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Tipo de Material .";
            // 
            // txt_DescripSO
            // 
            this.txt_DescripSO.Location = new System.Drawing.Point(45, 180);
            this.txt_DescripSO.Name = "txt_DescripSO";
            this.txt_DescripSO.Size = new System.Drawing.Size(673, 20);
            this.txt_DescripSO.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Descripción :";
            // 
            // txt_cantActSO
            // 
            this.txt_cantActSO.Location = new System.Drawing.Point(511, 68);
            this.txt_cantActSO.Name = "txt_cantActSO";
            this.txt_cantActSO.Size = new System.Drawing.Size(207, 20);
            this.txt_cantActSO.TabIndex = 26;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Cantidad Actual :";
            // 
            // txt_cantMaxSO
            // 
            this.txt_cantMaxSO.Location = new System.Drawing.Point(277, 68);
            this.txt_cantMaxSO.Name = "txt_cantMaxSO";
            this.txt_cantMaxSO.Size = new System.Drawing.Size(186, 20);
            this.txt_cantMaxSO.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(274, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Cantidad máxima :";
            // 
            // txt_cantMinSO
            // 
            this.txt_cantMinSO.Location = new System.Drawing.Point(45, 68);
            this.txt_cantMinSO.Name = "txt_cantMinSO";
            this.txt_cantMinSO.Size = new System.Drawing.Size(168, 20);
            this.txt_cantMinSO.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(42, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Cantidad mínima :";
            // 
            // cbx_tMatSO
            // 
            this.cbx_tMatSO.Location = new System.Drawing.Point(45, 121);
            this.cbx_tMatSO.Name = "cbx_tMatSO";
            this.cbx_tMatSO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_tMatSO.Properties.DisplayMember = "descripcion";
            this.cbx_tMatSO.Properties.NullText = "";
            this.cbx_tMatSO.Properties.PopupSizeable = false;
            this.cbx_tMatSO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_tMatSO.Properties.ValueMember = "codigo";
            this.cbx_tMatSO.Properties.View = this.gridView11;
            this.cbx_tMatSO.Size = new System.Drawing.Size(168, 20);
            this.cbx_tMatSO.TabIndex = 30;
            // 
            // gridView11
            // 
            this.gridView11.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion13});
            this.gridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView11.Name = "gridView11";
            this.gridView11.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView11.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion13
            // 
            this.coldescripcion13.FieldName = "descripcion";
            this.coldescripcion13.Name = "coldescripcion13";
            this.coldescripcion13.Visible = true;
            this.coldescripcion13.VisibleIndex = 0;
            // 
            // cbx_UMedSO
            // 
            this.cbx_UMedSO.Location = new System.Drawing.Point(277, 124);
            this.cbx_UMedSO.Name = "cbx_UMedSO";
            this.cbx_UMedSO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_UMedSO.Properties.DisplayMember = "descripcion";
            this.cbx_UMedSO.Properties.NullText = "";
            this.cbx_UMedSO.Properties.PopupSizeable = false;
            this.cbx_UMedSO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_UMedSO.Properties.ValueMember = "codigo";
            this.cbx_UMedSO.Properties.View = this.gridView12;
            this.cbx_UMedSO.Size = new System.Drawing.Size(186, 20);
            this.cbx_UMedSO.TabIndex = 32;
            // 
            // gridView12
            // 
            this.gridView12.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion14});
            this.gridView12.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView12.Name = "gridView12";
            this.gridView12.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView12.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion14
            // 
            this.coldescripcion14.FieldName = "descripcion";
            this.coldescripcion14.Name = "coldescripcion14";
            this.coldescripcion14.Visible = true;
            this.coldescripcion14.VisibleIndex = 0;
            // 
            // cbx_MarcaSO
            // 
            this.cbx_MarcaSO.Location = new System.Drawing.Point(511, 121);
            this.cbx_MarcaSO.Name = "cbx_MarcaSO";
            this.cbx_MarcaSO.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_MarcaSO.Properties.DisplayMember = "descripcion";
            this.cbx_MarcaSO.Properties.NullText = "";
            this.cbx_MarcaSO.Properties.PopupSizeable = false;
            this.cbx_MarcaSO.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_MarcaSO.Properties.ValueMember = "codigo";
            this.cbx_MarcaSO.Properties.View = this.gridView13;
            this.cbx_MarcaSO.Size = new System.Drawing.Size(207, 20);
            this.cbx_MarcaSO.TabIndex = 36;
            // 
            // gridView13
            // 
            this.gridView13.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion15});
            this.gridView13.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView13.Name = "gridView13";
            this.gridView13.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView13.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion15
            // 
            this.coldescripcion15.FieldName = "descripcion";
            this.coldescripcion15.Name = "coldescripcion15";
            this.coldescripcion15.Visible = true;
            this.coldescripcion15.VisibleIndex = 0;
            // 
            // Art_Limpieza
            // 
            this.Art_Limpieza.Controls.Add(this.dtp_fechaCaducidad);
            this.Art_Limpieza.Controls.Add(this.label48);
            this.Art_Limpieza.Controls.Add(this.label42);
            this.Art_Limpieza.Controls.Add(this.label19);
            this.Art_Limpieza.Controls.Add(this.label20);
            this.Art_Limpieza.Controls.Add(this.txt_DescripcionAL);
            this.Art_Limpieza.Controls.Add(this.label21);
            this.Art_Limpieza.Controls.Add(this.txt_cantActAL);
            this.Art_Limpieza.Controls.Add(this.label33);
            this.Art_Limpieza.Controls.Add(this.txt_cantMaxAL);
            this.Art_Limpieza.Controls.Add(this.label34);
            this.Art_Limpieza.Controls.Add(this.txt_cantMinAL);
            this.Art_Limpieza.Controls.Add(this.label35);
            this.Art_Limpieza.Controls.Add(this.cbx_tMaterialAL);
            this.Art_Limpieza.Controls.Add(this.cbx_uMedAL);
            this.Art_Limpieza.Controls.Add(this.cbx_MarcaAL);
            this.Art_Limpieza.Image = global::forms.Properties.Resources.articulos_de_limpieza_en_genera;
            this.Art_Limpieza.Name = "Art_Limpieza";
            this.Art_Limpieza.Size = new System.Drawing.Size(767, 305);
            this.Art_Limpieza.Text = "Articulos de Limpieza";
            // 
            // dtp_fechaCaducidad
            // 
            this.dtp_fechaCaducidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fechaCaducidad.Location = new System.Drawing.Point(505, 89);
            this.dtp_fechaCaducidad.Name = "dtp_fechaCaducidad";
            this.dtp_fechaCaducidad.Size = new System.Drawing.Size(207, 20);
            this.dtp_fechaCaducidad.TabIndex = 39;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(36, 124);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(43, 13);
            this.label48.TabIndex = 37;
            this.label48.Text = "Marca :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(502, 69);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(112, 13);
            this.label42.TabIndex = 33;
            this.label42.Text = "Fecha de Caducidad :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(272, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Unidad de medida :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(36, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "Tipo de Material .";
            // 
            // txt_DescripcionAL
            // 
            this.txt_DescripcionAL.Location = new System.Drawing.Point(39, 205);
            this.txt_DescripcionAL.Name = "txt_DescripcionAL";
            this.txt_DescripcionAL.Size = new System.Drawing.Size(673, 20);
            this.txt_DescripcionAL.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Descripción :";
            // 
            // txt_cantActAL
            // 
            this.txt_cantActAL.Location = new System.Drawing.Point(505, 33);
            this.txt_cantActAL.Name = "txt_cantActAL";
            this.txt_cantActAL.Size = new System.Drawing.Size(207, 20);
            this.txt_cantActAL.TabIndex = 26;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(502, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(88, 13);
            this.label33.TabIndex = 25;
            this.label33.Text = "Cantidad Actual :";
            // 
            // txt_cantMaxAL
            // 
            this.txt_cantMaxAL.Location = new System.Drawing.Point(271, 33);
            this.txt_cantMaxAL.Name = "txt_cantMaxAL";
            this.txt_cantMaxAL.Size = new System.Drawing.Size(186, 20);
            this.txt_cantMaxAL.TabIndex = 24;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(268, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(93, 13);
            this.label34.TabIndex = 23;
            this.label34.Text = "Cantidad máxima :";
            // 
            // txt_cantMinAL
            // 
            this.txt_cantMinAL.Location = new System.Drawing.Point(39, 33);
            this.txt_cantMinAL.Name = "txt_cantMinAL";
            this.txt_cantMinAL.Size = new System.Drawing.Size(168, 20);
            this.txt_cantMinAL.TabIndex = 22;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(36, 17);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 13);
            this.label35.TabIndex = 21;
            this.label35.Text = "Cantidad mínima :";
            // 
            // cbx_tMaterialAL
            // 
            this.cbx_tMaterialAL.Location = new System.Drawing.Point(39, 86);
            this.cbx_tMaterialAL.Name = "cbx_tMaterialAL";
            this.cbx_tMaterialAL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_tMaterialAL.Properties.DisplayMember = "descripcion";
            this.cbx_tMaterialAL.Properties.NullText = "";
            this.cbx_tMaterialAL.Properties.PopupSizeable = false;
            this.cbx_tMaterialAL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_tMaterialAL.Properties.ValueMember = "codigo";
            this.cbx_tMaterialAL.Properties.View = this.gridView14;
            this.cbx_tMaterialAL.Size = new System.Drawing.Size(168, 20);
            this.cbx_tMaterialAL.TabIndex = 30;
            // 
            // gridView14
            // 
            this.gridView14.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion16});
            this.gridView14.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView14.Name = "gridView14";
            this.gridView14.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView14.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion16
            // 
            this.coldescripcion16.FieldName = "descripcion";
            this.coldescripcion16.Name = "coldescripcion16";
            this.coldescripcion16.Visible = true;
            this.coldescripcion16.VisibleIndex = 0;
            // 
            // cbx_uMedAL
            // 
            this.cbx_uMedAL.Location = new System.Drawing.Point(271, 89);
            this.cbx_uMedAL.Name = "cbx_uMedAL";
            this.cbx_uMedAL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_uMedAL.Properties.DisplayMember = "descripcion";
            this.cbx_uMedAL.Properties.NullText = "";
            this.cbx_uMedAL.Properties.PopupSizeable = false;
            this.cbx_uMedAL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_uMedAL.Properties.ValueMember = "codigo";
            this.cbx_uMedAL.Properties.View = this.gridView15;
            this.cbx_uMedAL.Size = new System.Drawing.Size(186, 20);
            this.cbx_uMedAL.TabIndex = 32;
            // 
            // gridView15
            // 
            this.gridView15.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion17});
            this.gridView15.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView15.Name = "gridView15";
            this.gridView15.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView15.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion17
            // 
            this.coldescripcion17.FieldName = "descripcion";
            this.coldescripcion17.Name = "coldescripcion17";
            this.coldescripcion17.Visible = true;
            this.coldescripcion17.VisibleIndex = 0;
            // 
            // cbx_MarcaAL
            // 
            this.cbx_MarcaAL.Location = new System.Drawing.Point(39, 141);
            this.cbx_MarcaAL.Name = "cbx_MarcaAL";
            this.cbx_MarcaAL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_MarcaAL.Properties.DisplayMember = "descripcion";
            this.cbx_MarcaAL.Properties.NullText = "";
            this.cbx_MarcaAL.Properties.PopupSizeable = false;
            this.cbx_MarcaAL.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_MarcaAL.Properties.ValueMember = "codigo";
            this.cbx_MarcaAL.Properties.View = this.gridView16;
            this.cbx_MarcaAL.Size = new System.Drawing.Size(168, 20);
            this.cbx_MarcaAL.TabIndex = 38;
            // 
            // gridView16
            // 
            this.gridView16.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion18});
            this.gridView16.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView16.Name = "gridView16";
            this.gridView16.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView16.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion18
            // 
            this.coldescripcion18.FieldName = "descripcion";
            this.coldescripcion18.Name = "coldescripcion18";
            this.coldescripcion18.Visible = true;
            this.coldescripcion18.VisibleIndex = 0;
            // 
            // Art_Act_Fij
            // 
            this.Art_Act_Fij.Controls.Add(this.label44);
            this.Art_Act_Fij.Controls.Add(this.label45);
            this.Art_Act_Fij.Controls.Add(this.label46);
            this.Art_Act_Fij.Controls.Add(this.label36);
            this.Art_Act_Fij.Controls.Add(this.label37);
            this.Art_Act_Fij.Controls.Add(this.txt_DescripcionAF);
            this.Art_Act_Fij.Controls.Add(this.label38);
            this.Art_Act_Fij.Controls.Add(this.txt_cantActAF);
            this.Art_Act_Fij.Controls.Add(this.label39);
            this.Art_Act_Fij.Controls.Add(this.txt_cantMaxAF);
            this.Art_Act_Fij.Controls.Add(this.label40);
            this.Art_Act_Fij.Controls.Add(this.txt_cantMinAF);
            this.Art_Act_Fij.Controls.Add(this.label41);
            this.Art_Act_Fij.Controls.Add(this.cbx_tMatAF);
            this.Art_Act_Fij.Controls.Add(this.cbx_uMedidaAF);
            this.Art_Act_Fij.Controls.Add(this.cbx_MarcaAF);
            this.Art_Act_Fij.Controls.Add(this.cbx_ModeloAF);
            this.Art_Act_Fij.Controls.Add(this.cbx_ColorAF);
            this.Art_Act_Fij.Image = global::forms.Properties.Resources.actfijo;
            this.Art_Act_Fij.Name = "Art_Act_Fij";
            this.Art_Act_Fij.Size = new System.Drawing.Size(767, 305);
            this.Art_Act_Fij.Text = "Artículos de Activos Fijos";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(504, 119);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(37, 13);
            this.label44.TabIndex = 37;
            this.label44.Text = "Color :";
            this.label44.UseWaitCursor = true;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(270, 119);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(48, 13);
            this.label45.TabIndex = 35;
            this.label45.Text = "Modelo :";
            this.label45.UseWaitCursor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(38, 119);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(43, 13);
            this.label46.TabIndex = 33;
            this.label46.Text = "Marca :";
            this.label46.UseWaitCursor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(274, 69);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(99, 13);
            this.label36.TabIndex = 31;
            this.label36.Text = "Unidad de medida :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(38, 69);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(89, 13);
            this.label37.TabIndex = 29;
            this.label37.Text = "Tipo de Material .";
            // 
            // txt_DescripcionAF
            // 
            this.txt_DescripcionAF.Location = new System.Drawing.Point(41, 206);
            this.txt_DescripcionAF.Name = "txt_DescripcionAF";
            this.txt_DescripcionAF.Size = new System.Drawing.Size(673, 20);
            this.txt_DescripcionAF.TabIndex = 28;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(38, 189);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 13);
            this.label38.TabIndex = 27;
            this.label38.Text = "Descripción :";
            // 
            // txt_cantActAF
            // 
            this.txt_cantActAF.Location = new System.Drawing.Point(507, 33);
            this.txt_cantActAF.Name = "txt_cantActAF";
            this.txt_cantActAF.Size = new System.Drawing.Size(207, 20);
            this.txt_cantActAF.TabIndex = 26;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(504, 17);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(88, 13);
            this.label39.TabIndex = 25;
            this.label39.Text = "Cantidad Actual :";
            // 
            // txt_cantMaxAF
            // 
            this.txt_cantMaxAF.Location = new System.Drawing.Point(273, 33);
            this.txt_cantMaxAF.Name = "txt_cantMaxAF";
            this.txt_cantMaxAF.Size = new System.Drawing.Size(186, 20);
            this.txt_cantMaxAF.TabIndex = 24;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(270, 17);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(93, 13);
            this.label40.TabIndex = 23;
            this.label40.Text = "Cantidad máxima :";
            // 
            // txt_cantMinAF
            // 
            this.txt_cantMinAF.Location = new System.Drawing.Point(41, 33);
            this.txt_cantMinAF.Name = "txt_cantMinAF";
            this.txt_cantMinAF.Size = new System.Drawing.Size(168, 20);
            this.txt_cantMinAF.TabIndex = 22;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(38, 17);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(92, 13);
            this.label41.TabIndex = 21;
            this.label41.Text = "Cantidad mínima :";
            // 
            // cbx_tMatAF
            // 
            this.cbx_tMatAF.Location = new System.Drawing.Point(41, 86);
            this.cbx_tMatAF.Name = "cbx_tMatAF";
            this.cbx_tMatAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_tMatAF.Properties.DisplayMember = "descripcion";
            this.cbx_tMatAF.Properties.NullText = "";
            this.cbx_tMatAF.Properties.PopupSizeable = false;
            this.cbx_tMatAF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_tMatAF.Properties.ValueMember = "codigo";
            this.cbx_tMatAF.Properties.View = this.gridView17;
            this.cbx_tMatAF.Size = new System.Drawing.Size(168, 20);
            this.cbx_tMatAF.TabIndex = 30;
            // 
            // gridView17
            // 
            this.gridView17.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion19});
            this.gridView17.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView17.Name = "gridView17";
            this.gridView17.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView17.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion19
            // 
            this.coldescripcion19.FieldName = "descripcion";
            this.coldescripcion19.Name = "coldescripcion19";
            this.coldescripcion19.Visible = true;
            this.coldescripcion19.VisibleIndex = 0;
            // 
            // cbx_uMedidaAF
            // 
            this.cbx_uMedidaAF.Location = new System.Drawing.Point(273, 89);
            this.cbx_uMedidaAF.Name = "cbx_uMedidaAF";
            this.cbx_uMedidaAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_uMedidaAF.Properties.DisplayMember = "descripcion";
            this.cbx_uMedidaAF.Properties.NullText = "";
            this.cbx_uMedidaAF.Properties.PopupSizeable = false;
            this.cbx_uMedidaAF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_uMedidaAF.Properties.ValueMember = "codigo";
            this.cbx_uMedidaAF.Properties.View = this.gridView18;
            this.cbx_uMedidaAF.Size = new System.Drawing.Size(186, 20);
            this.cbx_uMedidaAF.TabIndex = 32;
            // 
            // gridView18
            // 
            this.gridView18.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion20});
            this.gridView18.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView18.Name = "gridView18";
            this.gridView18.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView18.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion20
            // 
            this.coldescripcion20.FieldName = "descripcion";
            this.coldescripcion20.Name = "coldescripcion20";
            this.coldescripcion20.Visible = true;
            this.coldescripcion20.VisibleIndex = 0;
            // 
            // cbx_MarcaAF
            // 
            this.cbx_MarcaAF.Location = new System.Drawing.Point(41, 136);
            this.cbx_MarcaAF.Name = "cbx_MarcaAF";
            this.cbx_MarcaAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_MarcaAF.Properties.DisplayMember = "descripcion";
            this.cbx_MarcaAF.Properties.NullText = "";
            this.cbx_MarcaAF.Properties.PopupSizeable = false;
            this.cbx_MarcaAF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_MarcaAF.Properties.ValueMember = "codigo";
            this.cbx_MarcaAF.Properties.View = this.gridView19;
            this.cbx_MarcaAF.Size = new System.Drawing.Size(168, 20);
            this.cbx_MarcaAF.TabIndex = 34;
            this.cbx_MarcaAF.UseWaitCursor = true;
            // 
            // gridView19
            // 
            this.gridView19.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion21});
            this.gridView19.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView19.Name = "gridView19";
            this.gridView19.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView19.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion21
            // 
            this.coldescripcion21.FieldName = "descripcion";
            this.coldescripcion21.Name = "coldescripcion21";
            this.coldescripcion21.Visible = true;
            this.coldescripcion21.VisibleIndex = 0;
            // 
            // cbx_ModeloAF
            // 
            this.cbx_ModeloAF.Location = new System.Drawing.Point(273, 138);
            this.cbx_ModeloAF.Name = "cbx_ModeloAF";
            this.cbx_ModeloAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_ModeloAF.Properties.DisplayMember = "descripcion";
            this.cbx_ModeloAF.Properties.NullText = "";
            this.cbx_ModeloAF.Properties.PopupSizeable = false;
            this.cbx_ModeloAF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_ModeloAF.Properties.ValueMember = "codigo";
            this.cbx_ModeloAF.Properties.View = this.gridView20;
            this.cbx_ModeloAF.Size = new System.Drawing.Size(186, 20);
            this.cbx_ModeloAF.TabIndex = 36;
            this.cbx_ModeloAF.UseWaitCursor = true;
            // 
            // gridView20
            // 
            this.gridView20.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion22});
            this.gridView20.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView20.Name = "gridView20";
            this.gridView20.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView20.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion22
            // 
            this.coldescripcion22.FieldName = "descripcion";
            this.coldescripcion22.Name = "coldescripcion22";
            this.coldescripcion22.Visible = true;
            this.coldescripcion22.VisibleIndex = 0;
            // 
            // cbx_ColorAF
            // 
            this.cbx_ColorAF.Location = new System.Drawing.Point(507, 138);
            this.cbx_ColorAF.Name = "cbx_ColorAF";
            this.cbx_ColorAF.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbx_ColorAF.Properties.DisplayMember = "descripcion";
            this.cbx_ColorAF.Properties.NullText = "";
            this.cbx_ColorAF.Properties.PopupSizeable = false;
            this.cbx_ColorAF.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbx_ColorAF.Properties.ValueMember = "codigo";
            this.cbx_ColorAF.Properties.View = this.gridView21;
            this.cbx_ColorAF.Size = new System.Drawing.Size(207, 20);
            this.cbx_ColorAF.TabIndex = 38;
            this.cbx_ColorAF.UseWaitCursor = true;
            // 
            // gridView21
            // 
            this.gridView21.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion23});
            this.gridView21.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView21.Name = "gridView21";
            this.gridView21.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView21.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion23
            // 
            this.coldescripcion23.FieldName = "descripcion";
            this.coldescripcion23.Name = "coldescripcion23";
            this.coldescripcion23.Visible = true;
            this.coldescripcion23.VisibleIndex = 0;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 0;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::forms.Properties.Resources.VEHICULOS;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 496);
            this.Controls.Add(this.TabControl_Art);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "frmArticulo";
            this.Text = "frmArticulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_observacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_codigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tipoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_grupoArticulo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsGrupoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl_Art)).EndInit();
            this.TabControl_Art.ResumeLayout(false);
            this.Vehiculos.ResumeLayout(false);
            this.Vehiculos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_serieMotor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NroChasis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Placa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActual.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinima.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_marca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Modelo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsModeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_Color.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsColorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoMotor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoMotorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoCombustible.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoCombustibleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_TipoChasis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTipoChasisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView22)).EndInit();
            this.Accesorios.ResumeLayout(false);
            this.Accesorios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tipoMatAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_UMedAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView10)).EndInit();
            this.Sum_Oficina.ResumeLayout(false);
            this.Sum_Oficina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMatSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_UMedSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaSO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView13)).EndInit();
            this.Art_Limpieza.ResumeLayout(false);
            this.Art_Limpieza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMaterialAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_uMedAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView16)).EndInit();
            this.Art_Act_Fij.ResumeLayout(false);
            this.Art_Act_Fij.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantActAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMaxAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantMinAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_tMatAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_uMedidaAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_MarcaAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ModeloAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbx_ColorAF.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnConsultar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private DevExpress.XtraEditors.TextEdit txt_observacion;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_tipoArticulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_grupoArticulo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion3;
        private DevExpress.XtraTab.XtraTabControl TabControl_Art;
        private DevExpress.XtraTab.XtraTabPage Vehiculos;
        private System.Windows.Forms.TextBox txt_descripcion;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_serieMotor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private DevExpress.XtraEditors.TextEdit txt_NroChasis;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private DevExpress.XtraEditors.TextEdit txt_Placa;
        private System.Windows.Forms.Label label22;
        private DevExpress.XtraEditors.TextEdit txt_cantActual;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txt_cantMaxima;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txt_cantMinima;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_marca;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion4;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_Modelo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion6;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_Color;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion7;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_TipoMotor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion5;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_TipoCombustible;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion8;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_TipoChasis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion9;
        private DevExpress.XtraTab.XtraTabPage Accesorios;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.TextEdit txt_DescripAcc;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.TextEdit txt_cantActAcc;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txt_cantMaxAcc;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txt_cantMinAcc;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_MarcaAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion10;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_tipoMatAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView9;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion11;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_UMedAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView10;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion12;
        private DevExpress.XtraTab.XtraTabPage Sum_Oficina;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.TextEdit txt_DescripSO;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txt_cantActSO;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.TextEdit txt_cantMaxSO;
        private System.Windows.Forms.Label label17;
        private DevExpress.XtraEditors.TextEdit txt_cantMinSO;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_tMatSO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView11;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion13;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_UMedSO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView12;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion14;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_MarcaSO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView13;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion15;
        private DevExpress.XtraTab.XtraTabPage Art_Limpieza;
        private System.Windows.Forms.DateTimePicker dtp_fechaCaducidad;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.TextEdit txt_DescripcionAL;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.TextEdit txt_cantActAL;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.TextEdit txt_cantMaxAL;
        private System.Windows.Forms.Label label34;
        private DevExpress.XtraEditors.TextEdit txt_cantMinAL;
        private System.Windows.Forms.Label label35;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_tMaterialAL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView14;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion16;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_uMedAL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView15;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion17;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_MarcaAL;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView16;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion18;
        private DevExpress.XtraTab.XtraTabPage Art_Act_Fij;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private DevExpress.XtraEditors.TextEdit txt_DescripcionAF;
        private System.Windows.Forms.Label label38;
        private DevExpress.XtraEditors.TextEdit txt_cantActAF;
        private System.Windows.Forms.Label label39;
        private DevExpress.XtraEditors.TextEdit txt_cantMaxAF;
        private System.Windows.Forms.Label label40;
        private DevExpress.XtraEditors.TextEdit txt_cantMinAF;
        private System.Windows.Forms.Label label41;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_tMatAF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView17;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion19;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_uMedidaAF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView18;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion20;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_MarcaAF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView19;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion21;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_ModeloAF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView20;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion22;
        private DevExpress.XtraEditors.GridLookUpEdit cbx_ColorAF;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView21;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion23;
        private System.Windows.Forms.BindingSource clsTipoArticuloBindingSource;
        private System.Windows.Forms.BindingSource clsGrupoBindingSource;
        private System.Windows.Forms.BindingSource clsMarcaBindingSource;
        private System.Windows.Forms.BindingSource clsModeloBindingSource;
        private System.Windows.Forms.BindingSource clsColorBindingSource;
        private System.Windows.Forms.BindingSource clsTipoMotorBindingSource;
        private System.Windows.Forms.BindingSource clsTipoCombustibleBindingSource;
        private System.Windows.Forms.BindingSource clsTipoChasisBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit txt_estado;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView22;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion2;
    }
}