namespace forms.RecursosHumanos
{
    partial class frmMantenimientoEmpleado
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition2 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblCedula = new DevExpress.XtraEditors.LabelControl();
            this.tbcEmpleado = new System.Windows.Forms.TabControl();
            this.tpGenerales = new System.Windows.Forms.TabPage();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.rgGenero = new DevExpress.XtraEditors.RadioGroup();
            this.deFNacimiento = new DevExpress.XtraEditors.DateEdit();
            this.btnImagen = new DevExpress.XtraEditors.SimpleButton();
            this.btnBuscarCedula = new DevExpress.XtraEditors.SimpleButton();
            this.lblFecha = new DevExpress.XtraEditors.LabelControl();
            this.lblGenero = new DevExpress.XtraEditors.LabelControl();
            this.peFoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblApellido = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtCedula = new DevExpress.XtraEditors.TextEdit();
            this.tpContrato = new System.Windows.Forms.TabPage();
            this.gcTelefono = new DevExpress.XtraEditors.GroupControl();
            this.txtOtro = new DevExpress.XtraEditors.TextEdit();
            this.lblOtro = new DevExpress.XtraEditors.LabelControl();
            this.txtCasa = new DevExpress.XtraEditors.TextEdit();
            this.lblCasa = new DevExpress.XtraEditors.LabelControl();
            this.txtMovil = new DevExpress.XtraEditors.TextEdit();
            this.lblMovil = new DevExpress.XtraEditors.LabelControl();
            this.txtGeneral = new DevExpress.XtraEditors.TextEdit();
            this.lblGeneral = new DevExpress.XtraEditors.LabelControl();
            this.txtCorreo = new DevExpress.XtraEditors.TextEdit();
            this.lblCorreo = new DevExpress.XtraEditors.LabelControl();
            this.lblDireccion = new DevExpress.XtraEditors.LabelControl();
            this.txtDireccion = new DevExpress.XtraEditors.MemoEdit();
            this.tpAcademico = new System.Windows.Forms.TabPage();
            this.dgvAcademico = new System.Windows.Forms.DataGridView();
            this.cmbTitulo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clsTituloBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbInstitucion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clsUniversidadBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tpLaborales = new System.Windows.Forms.TabPage();
            this.cmbDepartamento = new DevExpress.XtraEditors.LookUpEdit();
            this.clsDepartamentoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.deFechaIngreso = new DevExpress.XtraEditors.DateEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblCargo = new DevExpress.XtraEditors.LabelControl();
            this.lblDpartamento = new DevExpress.XtraEditors.LabelControl();
            this.lblFIngreso = new DevExpress.XtraEditors.LabelControl();
            this.cmbCargo = new DevExpress.XtraEditors.LookUpEdit();
            this.clsCargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpFamiliar = new System.Windows.Forms.TabPage();
            this.gcCargaFamiliar = new DevExpress.XtraGrid.GridControl();
            this.gvCargaFamiliar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clsTituloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clsUniversidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clsEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsTituloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsUniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tituloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cargoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsDepartamentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.clsDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clsDatosDepartamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.titulo1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teHora = new DevExpress.XtraEditors.TimeEdit();
            this.lblHora = new DevExpress.XtraEditors.LabelControl();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.clsDepartamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.universidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            this.tbcEmpleado.SuspendLayout();
            this.tpGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgGenero.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFNacimiento.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peFoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).BeginInit();
            this.tpContrato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefono)).BeginInit();
            this.gcTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCasa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeneral.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).BeginInit();
            this.tpAcademico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource2)).BeginInit();
            this.tpLaborales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIngreso.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIngreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCargoBindingSource)).BeginInit();
            this.tpFamiliar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCargaFamiliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCargaFamiliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpleadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDatosDepartamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).BeginInit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // lblCedula
            // 
            this.lblCedula.Location = new System.Drawing.Point(79, 20);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(37, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula:";
            // 
            // tbcEmpleado
            // 
            this.tbcEmpleado.Controls.Add(this.tpGenerales);
            this.tbcEmpleado.Controls.Add(this.tpContrato);
            this.tbcEmpleado.Controls.Add(this.tpAcademico);
            this.tbcEmpleado.Controls.Add(this.tpLaborales);
            this.tbcEmpleado.Controls.Add(this.tpFamiliar);
            this.tbcEmpleado.Location = new System.Drawing.Point(0, 28);
            this.tbcEmpleado.Name = "tbcEmpleado";
            this.tbcEmpleado.SelectedIndex = 0;
            this.tbcEmpleado.Size = new System.Drawing.Size(520, 297);
            this.tbcEmpleado.TabIndex = 16;
            // 
            // tpGenerales
            // 
            this.tpGenerales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpGenerales.Controls.Add(this.txtid);
            this.tpGenerales.Controls.Add(this.rgGenero);
            this.tpGenerales.Controls.Add(this.deFNacimiento);
            this.tpGenerales.Controls.Add(this.btnImagen);
            this.tpGenerales.Controls.Add(this.btnBuscarCedula);
            this.tpGenerales.Controls.Add(this.lblFecha);
            this.tpGenerales.Controls.Add(this.lblGenero);
            this.tpGenerales.Controls.Add(this.peFoto);
            this.tpGenerales.Controls.Add(this.lblApellido);
            this.tpGenerales.Controls.Add(this.txtApellido);
            this.tpGenerales.Controls.Add(this.lblNombre);
            this.tpGenerales.Controls.Add(this.txtCedula);
            this.tpGenerales.Controls.Add(this.lblCedula);
            this.tpGenerales.Controls.Add(this.txtNombre);
            this.tpGenerales.Location = new System.Drawing.Point(4, 22);
            this.tpGenerales.Name = "tpGenerales";
            this.tpGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerales.Size = new System.Drawing.Size(512, 271);
            this.tpGenerales.TabIndex = 0;
            this.tpGenerales.Text = "Datos Generales";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(23, 17);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(29, 20);
            this.txtid.TabIndex = 78;
            this.txtid.Visible = false;
            this.txtid.EditValueChanged += new System.EventHandler(this.txtid_EditValueChanged);
            // 
            // rgGenero
            // 
            this.rgGenero.Location = new System.Drawing.Point(122, 152);
            this.rgGenero.Name = "rgGenero";
            this.rgGenero.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgGenero.Properties.Appearance.Options.UseBackColor = true;
            this.rgGenero.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Maculino"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Femenino")});
            this.rgGenero.Size = new System.Drawing.Size(197, 31);
            this.rgGenero.TabIndex = 77;
            // 
            // deFNacimiento
            // 
            this.deFNacimiento.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFNacimiento.Location = new System.Drawing.Point(122, 199);
            this.deFNacimiento.Name = "deFNacimiento";
            this.deFNacimiento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFNacimiento.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFNacimiento.Size = new System.Drawing.Size(100, 20);
            this.deFNacimiento.TabIndex = 76;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(415, 105);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(75, 23);
            this.btnImagen.TabIndex = 66;
            this.btnImagen.Text = "Editar foto";
            // 
            // btnBuscarCedula
            // 
            this.btnBuscarCedula.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscarCedula.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscarCedula.Location = new System.Drawing.Point(347, 17);
            this.btnBuscarCedula.Name = "btnBuscarCedula";
            this.btnBuscarCedula.Size = new System.Drawing.Size(23, 20);
            this.btnBuscarCedula.TabIndex = 65;
            this.btnBuscarCedula.Click += new System.EventHandler(this.btnBuscarCedula_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(13, 202);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(103, 13);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha de Nacimiento:";
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(77, 157);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(39, 13);
            this.lblGenero.TabIndex = 17;
            this.lblGenero.Text = "Género:";
            // 
            // peFoto
            // 
            this.peFoto.Location = new System.Drawing.Point(401, 3);
            this.peFoto.Name = "peFoto";
            this.peFoto.Size = new System.Drawing.Size(100, 96);
            this.peFoto.TabIndex = 15;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(70, 111);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(46, 13);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellidos:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 108);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(248, 20);
            this.txtApellido.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(70, 71);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 13);
            this.lblNombre.TabIndex = 12;
            this.lblNombre.Text = "Nombres:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(122, 17);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(176, 20);
            this.txtCedula.TabIndex = 4;
            // 
            // tpContrato
            // 
            this.tpContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpContrato.Controls.Add(this.gcTelefono);
            this.tpContrato.Controls.Add(this.txtCorreo);
            this.tpContrato.Controls.Add(this.lblCorreo);
            this.tpContrato.Controls.Add(this.lblDireccion);
            this.tpContrato.Controls.Add(this.txtDireccion);
            this.tpContrato.Location = new System.Drawing.Point(4, 22);
            this.tpContrato.Name = "tpContrato";
            this.tpContrato.Padding = new System.Windows.Forms.Padding(3);
            this.tpContrato.Size = new System.Drawing.Size(512, 271);
            this.tpContrato.TabIndex = 1;
            this.tpContrato.Text = "Datos de Contacto";
            // 
            // gcTelefono
            // 
            this.gcTelefono.Controls.Add(this.txtOtro);
            this.gcTelefono.Controls.Add(this.lblOtro);
            this.gcTelefono.Controls.Add(this.txtCasa);
            this.gcTelefono.Controls.Add(this.lblCasa);
            this.gcTelefono.Controls.Add(this.txtMovil);
            this.gcTelefono.Controls.Add(this.lblMovil);
            this.gcTelefono.Controls.Add(this.txtGeneral);
            this.gcTelefono.Controls.Add(this.lblGeneral);
            this.gcTelefono.Location = new System.Drawing.Point(47, 115);
            this.gcTelefono.Name = "gcTelefono";
            this.gcTelefono.Size = new System.Drawing.Size(366, 150);
            this.gcTelefono.TabIndex = 25;
            this.gcTelefono.Text = "Teléfono";
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(110, 119);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(113, 20);
            this.txtOtro.TabIndex = 32;
            // 
            // lblOtro
            // 
            this.lblOtro.Location = new System.Drawing.Point(75, 122);
            this.lblOtro.Name = "lblOtro";
            this.lblOtro.Size = new System.Drawing.Size(29, 13);
            this.lblOtro.TabIndex = 31;
            this.lblOtro.Text = "Otro :";
            // 
            // txtCasa
            // 
            this.txtCasa.Location = new System.Drawing.Point(110, 82);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(113, 20);
            this.txtCasa.TabIndex = 30;
            // 
            // lblCasa
            // 
            this.lblCasa.Location = new System.Drawing.Point(73, 85);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(31, 13);
            this.lblCasa.TabIndex = 29;
            this.lblCasa.Text = "Casa :";
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(110, 48);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(113, 20);
            this.txtMovil.TabIndex = 28;
            // 
            // lblMovil
            // 
            this.lblMovil.Location = new System.Drawing.Point(73, 51);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(31, 13);
            this.lblMovil.TabIndex = 27;
            this.lblMovil.Text = "Movil :";
            // 
            // txtGeneral
            // 
            this.txtGeneral.Location = new System.Drawing.Point(110, 22);
            this.txtGeneral.Name = "txtGeneral";
            this.txtGeneral.Size = new System.Drawing.Size(113, 20);
            this.txtGeneral.TabIndex = 26;
            // 
            // lblGeneral
            // 
            this.lblGeneral.Location = new System.Drawing.Point(60, 25);
            this.lblGeneral.Name = "lblGeneral";
            this.lblGeneral.Size = new System.Drawing.Size(44, 13);
            this.lblGeneral.TabIndex = 25;
            this.lblGeneral.Text = "General :";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(148, 70);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(248, 20);
            this.txtCorreo.TabIndex = 16;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(47, 77);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(95, 13);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo electrónico :";
            // 
            // lblDireccion
            // 
            this.lblDireccion.Location = new System.Drawing.Point(92, 18);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(50, 13);
            this.lblDireccion.TabIndex = 13;
            this.lblDireccion.Text = "Dirección :";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(148, 15);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 47);
            this.txtDireccion.TabIndex = 14;
            // 
            // tpAcademico
            // 
            this.tpAcademico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpAcademico.Controls.Add(this.dgvAcademico);
            this.tpAcademico.Location = new System.Drawing.Point(4, 22);
            this.tpAcademico.Name = "tpAcademico";
            this.tpAcademico.Padding = new System.Windows.Forms.Padding(3);
            this.tpAcademico.Size = new System.Drawing.Size(512, 271);
            this.tpAcademico.TabIndex = 2;
            this.tpAcademico.Text = "Datos Académicos";
            // 
            // dgvAcademico
            // 
            this.dgvAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcademico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbTitulo,
            this.cmbInstitucion});
            this.dgvAcademico.Location = new System.Drawing.Point(23, 6);
            this.dgvAcademico.Name = "dgvAcademico";
            this.dgvAcademico.Size = new System.Drawing.Size(452, 235);
            this.dgvAcademico.TabIndex = 0;
            // 
            // cmbTitulo
            // 
            this.cmbTitulo.DataSource = this.clsTituloBindingSource2;
            this.cmbTitulo.DisplayMember = "Nombre";
            this.cmbTitulo.HeaderText = "Titulo";
            this.cmbTitulo.Name = "cmbTitulo";
            this.cmbTitulo.ValueMember = "IdTitulo";
            // 
            // clsTituloBindingSource2
            // 
            this.clsTituloBindingSource2.DataSource = typeof(clases.RecursosHumanos.clsTitulo);
            // 
            // cmbInstitucion
            // 
            this.cmbInstitucion.DataSource = this.clsUniversidadBindingSource2;
            this.cmbInstitucion.DisplayMember = "Nombre";
            this.cmbInstitucion.HeaderText = "Institucion";
            this.cmbInstitucion.Name = "cmbInstitucion";
            this.cmbInstitucion.ValueMember = "IdUniversidad";
            // 
            // clsUniversidadBindingSource2
            // 
            this.clsUniversidadBindingSource2.DataSource = typeof(clases.RecursosHumanos.clsUniversidad);
            // 
            // tpLaborales
            // 
            this.tpLaborales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpLaborales.Controls.Add(this.cmbDepartamento);
            this.tpLaborales.Controls.Add(this.cmbEstado);
            this.tpLaborales.Controls.Add(this.deFechaIngreso);
            this.tpLaborales.Controls.Add(this.lblEstado);
            this.tpLaborales.Controls.Add(this.lblCargo);
            this.tpLaborales.Controls.Add(this.lblDpartamento);
            this.tpLaborales.Controls.Add(this.lblFIngreso);
            this.tpLaborales.Controls.Add(this.cmbCargo);
            this.tpLaborales.Location = new System.Drawing.Point(4, 22);
            this.tpLaborales.Name = "tpLaborales";
            this.tpLaborales.Padding = new System.Windows.Forms.Padding(3);
            this.tpLaborales.Size = new System.Drawing.Size(512, 271);
            this.tpLaborales.TabIndex = 3;
            this.tpLaborales.Text = "Datos Laborales";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.Location = new System.Drawing.Point(209, 99);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartamento.Properties.DataSource = this.clsDepartamentoBindingSource3;
            this.cmbDepartamento.Properties.DisplayMember = "Descripcion";
            this.cmbDepartamento.Properties.ValueMember = "IdDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(151, 20);
            this.cmbDepartamento.TabIndex = 80;
            // 
            // clsDepartamentoBindingSource3
            // 
            this.clsDepartamentoBindingSource3.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // cmbEstado
            // 
            this.cmbEstado.Location = new System.Drawing.Point(209, 170);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEstado.Properties.Items.AddRange(new object[] {
            "Seleccione estado",
            "Activo",
            "Inactivo"});
            this.cmbEstado.Size = new System.Drawing.Size(151, 20);
            this.cmbEstado.TabIndex = 79;
            // 
            // deFechaIngreso
            // 
            this.deFechaIngreso.EditValue = new System.DateTime(2013, 7, 11, 21, 20, 29, 313);
            this.deFechaIngreso.Location = new System.Drawing.Point(209, 65);
            this.deFechaIngreso.Name = "deFechaIngreso";
            this.deFechaIngreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaIngreso.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaIngreso.Size = new System.Drawing.Size(108, 20);
            this.deFechaIngreso.TabIndex = 76;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(166, 173);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 28;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCargo
            // 
            this.lblCargo.Location = new System.Drawing.Point(170, 135);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(33, 13);
            this.lblCargo.TabIndex = 26;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblDpartamento
            // 
            this.lblDpartamento.Location = new System.Drawing.Point(130, 102);
            this.lblDpartamento.Name = "lblDpartamento";
            this.lblDpartamento.Size = new System.Drawing.Size(73, 13);
            this.lblDpartamento.TabIndex = 24;
            this.lblDpartamento.Text = "Departamento:";
            // 
            // lblFIngreso
            // 
            this.lblFIngreso.Location = new System.Drawing.Point(115, 72);
            this.lblFIngreso.Name = "lblFIngreso";
            this.lblFIngreso.Size = new System.Drawing.Size(88, 13);
            this.lblFIngreso.TabIndex = 22;
            this.lblFIngreso.Text = "Fecha de Ingreso:";
            // 
            // cmbCargo
            // 
            this.cmbCargo.Location = new System.Drawing.Point(209, 132);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCargo.Properties.DataSource = this.clsCargoBindingSource;
            this.cmbCargo.Properties.DisplayMember = "Descripcion";
            this.cmbCargo.Properties.NullText = "";
            this.cmbCargo.Properties.PopupSizeable = false;
            this.cmbCargo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbCargo.Properties.ValueMember = "IdCargo";
            this.cmbCargo.Size = new System.Drawing.Size(151, 20);
            this.cmbCargo.TabIndex = 78;
            // 
            // clsCargoBindingSource
            // 
            this.clsCargoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsCargo);
            // 
            // tpFamiliar
            // 
            this.tpFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpFamiliar.Controls.Add(this.gcCargaFamiliar);
            this.tpFamiliar.Location = new System.Drawing.Point(4, 22);
            this.tpFamiliar.Name = "tpFamiliar";
            this.tpFamiliar.Padding = new System.Windows.Forms.Padding(3);
            this.tpFamiliar.Size = new System.Drawing.Size(512, 271);
            this.tpFamiliar.TabIndex = 4;
            this.tpFamiliar.Text = "Carga Familiar";
            // 
            // gcCargaFamiliar
            // 
            this.gcCargaFamiliar.Location = new System.Drawing.Point(0, 6);
            this.gcCargaFamiliar.MainView = this.gvCargaFamiliar;
            this.gcCargaFamiliar.Name = "gcCargaFamiliar";
            this.gcCargaFamiliar.Size = new System.Drawing.Size(506, 230);
            this.gcCargaFamiliar.TabIndex = 3;
            this.gcCargaFamiliar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCargaFamiliar});
            // 
            // gvCargaFamiliar
            // 
            this.gvCargaFamiliar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gvCargaFamiliar.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition2});
            this.gvCargaFamiliar.GridControl = this.gcCargaFamiliar;
            this.gvCargaFamiliar.Name = "gvCargaFamiliar";
            this.gvCargaFamiliar.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gvCargaFamiliar.OptionsBehavior.SummariesIgnoreNullValues = true;
            this.gvCargaFamiliar.OptionsNavigation.AutoFocusNewRow = true;
            this.gvCargaFamiliar.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cedula";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 97;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nombres";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 97;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Apellidos";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 97;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Fecha de Nacimiento";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 111;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Parentesco";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 86;
            // 
            // clsTituloBindingSource1
            // 
            this.clsTituloBindingSource1.DataSource = typeof(clases.RecursosHumanos.clsTitulo);
            // 
            // clsUniversidadBindingSource1
            // 
            this.clsUniversidadBindingSource1.DataSource = typeof(clases.RecursosHumanos.clsUniversidad);
            // 
            // clsTituloBindingSource
            // 
            this.clsTituloBindingSource.DataSource = typeof(clases.RecursosHumanos.clsTitulo);
            // 
            // clsUniversidadBindingSource
            // 
            this.clsUniversidadBindingSource.DataSource = typeof(clases.RecursosHumanos.clsUniversidad);
            // 
            // clsDepartamentoBindingSource2
            // 
            this.clsDepartamentoBindingSource2.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // clsDepartamentoBindingSource
            // 
            this.clsDepartamentoBindingSource.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // clsDatosDepartamentoBindingSource
            // 
            this.clsDatosDepartamentoBindingSource.DataSource = typeof(datos.RecursosHumanos.clsDatosDepartamento);
            // 
            // teHora
            // 
            this.teHora.EditValue = new System.DateTime(2013, 6, 20, 0, 0, 0, 0);
            this.teHora.Location = new System.Drawing.Point(416, 347);
            this.teHora.Name = "teHora";
            this.teHora.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.teHora.Size = new System.Drawing.Size(100, 20);
            this.teHora.TabIndex = 81;
            // 
            // lblHora
            // 
            this.lblHora.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(363, 350);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 80;
            this.lblHora.Text = "Hora:";
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(524, 25);
            this.tsMenu.TabIndex = 82;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(51, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click_1);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(57, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::forms.Properties.Resources.modificar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(62, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(57, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // clsDepartamentoBindingSource1
            // 
            this.clsDepartamentoBindingSource1.DataSource = typeof(clases.RecursosHumanos.clsDepartamento);
            // 
            // frmMantenimientoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.teHora);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.tbcEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 399);
            this.MinimumSize = new System.Drawing.Size(530, 399);
            this.Name = "frmMantenimientoEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento empleado";
            this.Load += new System.EventHandler(this.frmMantenimientoEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            this.tbcEmpleado.ResumeLayout(false);
            this.tpGenerales.ResumeLayout(false);
            this.tpGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgGenero.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFNacimiento.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peFoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCedula.Properties)).EndInit();
            this.tpContrato.ResumeLayout(false);
            this.tpContrato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTelefono)).EndInit();
            this.gcTelefono.ResumeLayout(false);
            this.gcTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCasa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMovil.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGeneral.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCorreo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDireccion.Properties)).EndInit();
            this.tpAcademico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcademico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource2)).EndInit();
            this.tpLaborales.ResumeLayout(false);
            this.tpLaborales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartamento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIngreso.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaIngreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsCargoBindingSource)).EndInit();
            this.tpFamiliar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCargaFamiliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCargaFamiliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEmpleadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsTituloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tituloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cargoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsDatosDepartamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulo1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHora.Properties)).EndInit();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clsDepartamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universidadBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblCedula;
        private System.Windows.Forms.TabControl tbcEmpleado;
        private System.Windows.Forms.TabPage tpGenerales;
        private DevExpress.XtraEditors.LabelControl lblGenero;
        private DevExpress.XtraEditors.PictureEdit peFoto;
        private DevExpress.XtraEditors.LabelControl lblApellido;
        private DevExpress.XtraEditors.TextEdit txtApellido;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtCedula;
        private System.Windows.Forms.TabPage tpContrato;
        private DevExpress.XtraEditors.LabelControl lblFecha;
        private DevExpress.XtraEditors.LabelControl lblCorreo;
        private DevExpress.XtraEditors.LabelControl lblDireccion;
        private DevExpress.XtraEditors.MemoEdit txtDireccion;
        private DevExpress.XtraEditors.TextEdit txtCorreo;
        private System.Windows.Forms.TabPage tpAcademico;
        private System.Windows.Forms.TabPage tpLaborales;
        private DevExpress.XtraEditors.LabelControl lblCargo;
        private DevExpress.XtraEditors.LabelControl lblDpartamento;
        private DevExpress.XtraEditors.LabelControl lblFIngreso;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private System.Windows.Forms.TabPage tpFamiliar;
        private DevExpress.XtraGrid.GridControl gcCargaFamiliar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.SimpleButton btnImagen;
        private DevExpress.XtraEditors.SimpleButton btnBuscarCedula;
        private DevExpress.XtraEditors.DateEdit deFNacimiento;
        private DevExpress.XtraEditors.DateEdit deFechaIngreso;
        private DevExpress.XtraEditors.RadioGroup rgGenero;
        private DevExpress.XtraEditors.ComboBoxEdit cmbEstado;
        private DevExpress.XtraEditors.TimeEdit teHora;
        private DevExpress.XtraEditors.LabelControl lblHora;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.GroupControl gcTelefono;
        private DevExpress.XtraEditors.TextEdit txtOtro;
        private DevExpress.XtraEditors.LabelControl lblOtro;
        private DevExpress.XtraEditors.TextEdit txtCasa;
        private DevExpress.XtraEditors.LabelControl lblCasa;
        private DevExpress.XtraEditors.TextEdit txtMovil;
        private DevExpress.XtraEditors.LabelControl lblMovil;
        private DevExpress.XtraEditors.TextEdit txtGeneral;
        private DevExpress.XtraEditors.LabelControl lblGeneral;
        private DevExpress.XtraEditors.TextEdit txtid;
        //private TECADataSet tECADataSet;
        //private TECADataSet1 tECADataSet1;
        //private TECADataSet1TableAdapters.DepartamentoTableAdapter departamentoTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit cmbCargo;
        //private TECADataSet2 tECADataSet2;
        private System.Windows.Forms.BindingSource cargoBindingSource;
        //private TECADataSet2TableAdapters.CargoTableAdapter cargoTableAdapter;
        private System.Windows.Forms.BindingSource titulo1BindingSource;
        //private Titulo titulo1;
        private System.Windows.Forms.BindingSource tituloBindingSource;
        //private TituloTableAdapters.TituloTableAdapter tituloTableAdapter;
        private System.Windows.Forms.BindingSource tituloBindingSource1;
        //private Universidad universidad;
        //private UniversidadTableAdapters.UniversidadTableAdapter universidadTableAdapter;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCargaFamiliar;
        private System.Windows.Forms.BindingSource departamentoBindingSource2;
        private System.Windows.Forms.BindingSource clsDatosDepartamentoBindingSource;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource2;
        private DevExpress.XtraEditors.LookUpEdit cmbDepartamento;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource3;
        private System.Windows.Forms.BindingSource clsCargoBindingSource;
        private System.Windows.Forms.BindingSource clsTituloBindingSource;
        private System.Windows.Forms.BindingSource clsUniversidadBindingSource;
        private System.Windows.Forms.BindingSource clsEmpleadoBindingSource;
        private System.Windows.Forms.DataGridView dgvAcademico;
        private System.Windows.Forms.BindingSource clsDepartamentoBindingSource1;
        private System.Windows.Forms.BindingSource universidadBindingSource;
        private System.Windows.Forms.BindingSource clsTituloBindingSource1;
        private System.Windows.Forms.BindingSource clsUniversidadBindingSource1;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbTitulo;
        private System.Windows.Forms.BindingSource clsTituloBindingSource2;
        private System.Windows.Forms.DataGridViewComboBoxColumn cmbInstitucion;
        private System.Windows.Forms.BindingSource clsUniversidadBindingSource2;
    }
}