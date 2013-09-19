namespace forms.Inventario
{
    partial class frmBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodega));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultaCodigo = new DevExpress.XtraEditors.SimpleButton();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefono = new DevExpress.XtraEditors.TextEdit();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCapacidadm2 = new System.Windows.Forms.TextBox();
            this.lblCapacidadm2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPercha = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.cbxEstado = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsEstadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coldescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbxResponsable = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cbxPercha = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsPerchaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescripcion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldivisiones = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colempresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colestado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPercha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPerchaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(557, 25);
            this.toolStrip1.TabIndex = 132;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(51, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(57, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = ((System.Drawing.Image)(resources.GetObject("tsbModificar.Image")));
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(62, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
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
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(42, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnConsultaCodigo);
            this.GroupBox1.Controls.Add(this.lblEstado);
            this.GroupBox1.Controls.Add(this.txtTelefono);
            this.GroupBox1.Controls.Add(this.lblTelefono);
            this.GroupBox1.Controls.Add(this.txtCapacidadm2);
            this.GroupBox1.Controls.Add(this.lblCapacidadm2);
            this.GroupBox1.Controls.Add(this.txtDireccion);
            this.GroupBox1.Controls.Add(this.lblDireccion);
            this.GroupBox1.Controls.Add(this.lblPercha);
            this.GroupBox1.Controls.Add(this.lblResponsable);
            this.GroupBox1.Controls.Add(this.txtCodigo);
            this.GroupBox1.Controls.Add(this.txtDescripcion);
            this.GroupBox1.Controls.Add(this.lblCodigo);
            this.GroupBox1.Controls.Add(this.lblDescripcion);
            this.GroupBox1.Controls.Add(this.cbxEstado);
            this.GroupBox1.Controls.Add(this.cbxResponsable);
            this.GroupBox1.Controls.Add(this.cbxPercha);
            this.GroupBox1.Location = new System.Drawing.Point(12, 40);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(524, 177);
            this.GroupBox1.TabIndex = 131;
            this.GroupBox1.TabStop = false;
            // 
            // btnConsultaCodigo
            // 
            this.btnConsultaCodigo.Location = new System.Drawing.Point(197, 19);
            this.btnConsultaCodigo.Name = "btnConsultaCodigo";
            this.btnConsultaCodigo.Size = new System.Drawing.Size(35, 23);
            this.btnConsultaCodigo.TabIndex = 50;
            this.btnConsultaCodigo.Text = ".....";
            this.btnConsultaCodigo.Click += new System.EventHandler(this.btnConsultaCodigo_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(320, 137);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 48;
            this.lblEstado.Text = "Estado:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(371, 102);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 47;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(311, 102);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 46;
            this.lblTelefono.Text = "Telefono:";
            // 
            // txtCapacidadm2
            // 
            this.txtCapacidadm2.Location = new System.Drawing.Point(108, 99);
            this.txtCapacidadm2.Name = "txtCapacidadm2";
            this.txtCapacidadm2.Size = new System.Drawing.Size(150, 20);
            this.txtCapacidadm2.TabIndex = 45;
            // 
            // lblCapacidadm2
            // 
            this.lblCapacidadm2.AutoSize = true;
            this.lblCapacidadm2.Location = new System.Drawing.Point(9, 102);
            this.lblCapacidadm2.Name = "lblCapacidadm2";
            this.lblCapacidadm2.Size = new System.Drawing.Size(93, 13);
            this.lblCapacidadm2.TabIndex = 44;
            this.lblCapacidadm2.Text = "Capacidad en m2:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(371, 60);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccion.Size = new System.Drawing.Size(150, 24);
            this.txtDireccion.TabIndex = 43;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(311, 60);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 42;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblPercha
            // 
            this.lblPercha.AutoSize = true;
            this.lblPercha.Location = new System.Drawing.Point(322, 25);
            this.lblPercha.Name = "lblPercha";
            this.lblPercha.Size = new System.Drawing.Size(44, 13);
            this.lblPercha.TabIndex = 39;
            this.lblPercha.Text = "Percha:";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(9, 140);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(72, 13);
            this.lblResponsable.TabIndex = 36;
            this.lblResponsable.Text = "Responsable:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(108, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(83, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 57);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(189, 24);
            this.txtDescripcion.TabIndex = 30;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(38, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 60);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.Location = new System.Drawing.Point(371, 137);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxEstado.Properties.DataSource = this.clsEstadoBindingSource;
            this.cbxEstado.Properties.DisplayMember = "descripcion";
            this.cbxEstado.Properties.NullText = "";
            this.cbxEstado.Properties.PopupSizeable = false;
            this.cbxEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxEstado.Properties.ValueMember = "idEstado";
            this.cbxEstado.Properties.View = this.gridLookUpEdit1View;
            this.cbxEstado.Size = new System.Drawing.Size(147, 20);
            this.cbxEstado.TabIndex = 49;
            // 
            // clsEstadoBindingSource
            // 
            this.clsEstadoBindingSource.DataSource = typeof(clases.Seguridad.clsEstado);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coldescripcion});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // coldescripcion
            // 
            this.coldescripcion.Caption = "Descripcion";
            this.coldescripcion.FieldName = "descripcion";
            this.coldescripcion.Name = "coldescripcion";
            this.coldescripcion.Visible = true;
            this.coldescripcion.VisibleIndex = 0;
            // 
            // cbxResponsable
            // 
            this.cbxResponsable.Location = new System.Drawing.Point(108, 137);
            this.cbxResponsable.Name = "cbxResponsable";
            this.cbxResponsable.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxResponsable.Properties.DataSource = this.clsPersonaBindingSource;
            this.cbxResponsable.Properties.DisplayMember = "NombreRazonSocial";
            this.cbxResponsable.Properties.NullText = "";
            this.cbxResponsable.Properties.PopupSizeable = false;
            this.cbxResponsable.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxResponsable.Properties.ValueMember = "IdPersona";
            this.cbxResponsable.Properties.View = this.gridView1;
            this.cbxResponsable.Size = new System.Drawing.Size(150, 20);
            this.cbxResponsable.TabIndex = 53;
            // 
            // clsPersonaBindingSource
            // 
            this.clsPersonaBindingSource.DataSource = typeof(clases.RecursosHumanos.clsPersona);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cbxPercha
            // 
            this.cbxPercha.Location = new System.Drawing.Point(372, 22);
            this.cbxPercha.Name = "cbxPercha";
            this.cbxPercha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxPercha.Properties.DataSource = this.clsPerchaBindingSource;
            this.cbxPercha.Properties.DisplayMember = "descripcion";
            this.cbxPercha.Properties.NullText = "";
            this.cbxPercha.Properties.PopupSizeable = false;
            this.cbxPercha.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cbxPercha.Properties.ValueMember = "codigo";
            this.cbxPercha.Properties.View = this.gridView2;
            this.cbxPercha.Size = new System.Drawing.Size(146, 20);
            this.cbxPercha.TabIndex = 54;
            // 
            // clsPerchaBindingSource
            // 
            this.clsPerchaBindingSource.DataSource = typeof(clases.Inventario.clsPercha);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbodega,
            this.colcodigo,
            this.coldescripcion1,
            this.coldivisiones,
            this.colempresa,
            this.colestado});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colbodega
            // 
            this.colbodega.FieldName = "bodega";
            this.colbodega.Name = "colbodega";
            this.colbodega.Visible = true;
            this.colbodega.VisibleIndex = 0;
            // 
            // colcodigo
            // 
            this.colcodigo.FieldName = "codigo";
            this.colcodigo.Name = "colcodigo";
            this.colcodigo.Visible = true;
            this.colcodigo.VisibleIndex = 1;
            // 
            // coldescripcion1
            // 
            this.coldescripcion1.FieldName = "descripcion";
            this.coldescripcion1.Name = "coldescripcion1";
            this.coldescripcion1.Visible = true;
            this.coldescripcion1.VisibleIndex = 2;
            // 
            // coldivisiones
            // 
            this.coldivisiones.FieldName = "divisiones";
            this.coldivisiones.Name = "coldivisiones";
            this.coldivisiones.Visible = true;
            this.coldivisiones.VisibleIndex = 3;
            // 
            // colempresa
            // 
            this.colempresa.FieldName = "empresa";
            this.colempresa.Name = "colempresa";
            this.colempresa.Visible = true;
            this.colempresa.VisibleIndex = 4;
            // 
            // colestado
            // 
            this.colestado.FieldName = "estado";
            this.colestado.Name = "colestado";
            this.colestado.Visible = true;
            this.colestado.VisibleIndex = 5;
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 238);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmBodega";
            this.Text = "frmBodega";
            this.Load += new System.EventHandler(this.frmBodega_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsEstadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxResponsable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxPercha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPerchaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private DevExpress.XtraEditors.SimpleButton btnConsultaCodigo;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.TextEdit txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCapacidadm2;
        private System.Windows.Forms.Label lblCapacidadm2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblPercha;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private DevExpress.XtraEditors.GridLookUpEdit cbxEstado;
        private System.Windows.Forms.BindingSource clsEstadoBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion;
        private DevExpress.XtraEditors.GridLookUpEdit cbxResponsable;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GridLookUpEdit cbxPercha;
        private System.Windows.Forms.BindingSource clsPerchaBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource clsPersonaBindingSource;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn colbodega;
        private DevExpress.XtraGrid.Columns.GridColumn colcodigo;
        private DevExpress.XtraGrid.Columns.GridColumn coldescripcion1;
        private DevExpress.XtraGrid.Columns.GridColumn coldivisiones;
        private DevExpress.XtraGrid.Columns.GridColumn colempresa;
        private DevExpress.XtraGrid.Columns.GridColumn colestado;
    }
}