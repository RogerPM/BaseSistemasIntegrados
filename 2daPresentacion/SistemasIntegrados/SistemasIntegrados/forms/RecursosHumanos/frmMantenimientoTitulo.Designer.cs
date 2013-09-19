namespace forms.RecursosHumanos
{
    partial class frmMantenimientoTitulo
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
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.lblCodigo = new DevExpress.XtraEditors.LabelControl();
            this.txtCodigo = new DevExpress.XtraEditors.TextEdit();
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.lblEstado = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaInicio = new DevExpress.XtraEditors.LabelControl();
            this.lblFechaFinal = new DevExpress.XtraEditors.LabelControl();
            this.deFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.deFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.lblUniversidad = new DevExpress.XtraEditors.LabelControl();
           
            this.gluUniversidad = new DevExpress.XtraEditors.GridLookUpEdit();
            this.clsUniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdUniversidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbeEstado = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).BeginInit();
          
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.gluUniversidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstado.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.tsMenu.Size = new System.Drawing.Size(320, 25);
            this.tsMenu.TabIndex = 23;
            this.tsMenu.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::forms.Properties.Resources.nuevo;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(62, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Image = global::forms.Properties.Resources.guardar;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Image = global::forms.Properties.Resources.modificar;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = global::forms.Properties.Resources.eliminar1;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Location = new System.Drawing.Point(55, 47);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(37, 13);
            this.lblCodigo.TabIndex = 35;
            this.lblCodigo.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(115, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(80, 20);
            this.txtCodigo.TabIndex = 33;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(51, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(41, 13);
            this.lblNombre.TabIndex = 98;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 97;
            // 
            // lblEstado
            // 
            this.lblEstado.Location = new System.Drawing.Point(55, 177);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(37, 13);
            this.lblEstado.TabIndex = 96;
            this.lblEstado.Text = "Estado:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.Location = new System.Drawing.Point(32, 99);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(61, 13);
            this.lblFechaInicio.TabIndex = 100;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.Location = new System.Drawing.Point(34, 125);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(58, 13);
            this.lblFechaFinal.TabIndex = 101;
            this.lblFechaFinal.Text = "Fecha Final:";
            // 
            // deFechaInicio
            // 
            this.deFechaInicio.EditValue = new System.DateTime(2013, 7, 27, 10, 49, 40, 317);
            this.deFechaInicio.Location = new System.Drawing.Point(115, 96);
            this.deFechaInicio.Name = "deFechaInicio";
            this.deFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaInicio.Size = new System.Drawing.Size(100, 20);
            this.deFechaInicio.TabIndex = 102;
            // 
            // deFechaFinal
            // 
            this.deFechaFinal.EditValue = new System.DateTime(2013, 7, 27, 10, 49, 40, 317);
            this.deFechaFinal.Location = new System.Drawing.Point(115, 122);
            this.deFechaFinal.Name = "deFechaFinal";
            this.deFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deFechaFinal.Size = new System.Drawing.Size(100, 20);
            this.deFechaFinal.TabIndex = 103;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::forms.Properties.Resources.consultar;
            this.btnBuscar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(201, 44);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblUniversidad
            // 
            this.lblUniversidad.Location = new System.Drawing.Point(32, 152);
            this.lblUniversidad.Name = "lblUniversidad";
            this.lblUniversidad.Size = new System.Drawing.Size(60, 13);
            this.lblUniversidad.TabIndex = 104;
            this.lblUniversidad.Text = "Universidad:";
            // 
            // gluUniversidad
            // 
            this.gluUniversidad.EditValue = "<Null>";
            this.gluUniversidad.Location = new System.Drawing.Point(115, 148);
            this.gluUniversidad.Name = "gluUniversidad";
            this.gluUniversidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gluUniversidad.Properties.DataSource = this.clsUniversidadBindingSource;
            this.gluUniversidad.Properties.DisplayMember = "Nombre";
            this.gluUniversidad.Properties.ValueMember = "IdUniversidad";
            this.gluUniversidad.Properties.View = this.gridView1;
            this.gluUniversidad.Size = new System.Drawing.Size(100, 20);
            this.gluUniversidad.TabIndex = 105;
            // 
            // clsUniversidadBindingSource
            // 
            this.clsUniversidadBindingSource.DataSource = typeof(clases.RecursosHumanos.clsUniversidad);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nombre,
            this.IdUniversidad});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Universidad";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // IdUniversidad
            // 
            this.IdUniversidad.Caption = "Codigo";
            this.IdUniversidad.FieldName = "IdUniversidad";
            this.IdUniversidad.Name = "IdUniversidad";
            this.IdUniversidad.Visible = true;
            this.IdUniversidad.VisibleIndex = 1;
            // 
            // cbeEstado
            // 
            this.cbeEstado.Location = new System.Drawing.Point(115, 175);
            this.cbeEstado.Name = "cbeEstado";
            this.cbeEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeEstado.Properties.Items.AddRange(new object[] {
            "Seleccione Estado",
            "Activo",
            "Inactivo"});
            this.cbeEstado.Size = new System.Drawing.Size(100, 20);
            this.cbeEstado.TabIndex = 106;
            // 
            // frmMantenimientoTitulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 231);
            this.Controls.Add(this.cbeEstado);
            this.Controls.Add(this.gluUniversidad);
            this.Controls.Add(this.lblUniversidad);
            this.Controls.Add(this.deFechaFinal);
            this.Controls.Add(this.deFechaInicio);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.lblFechaInicio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.tsMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 269);
            this.MinimumSize = new System.Drawing.Size(336, 269);
            this.Name = "frmMantenimientoTitulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Titulo";
            this.Load += new System.EventHandler(this.frmMantenimientoTitulo_Load);
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodigo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gluUniversidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUniversidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeEstado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripButton tsbModificar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private DevExpress.XtraEditors.LabelControl lblCodigo;
        private DevExpress.XtraEditors.TextEdit txtCodigo;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;
        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.TextEdit txtNombre;
        private DevExpress.XtraEditors.LabelControl lblEstado;
        private DevExpress.XtraEditors.LabelControl lblFechaInicio;
        private DevExpress.XtraEditors.LabelControl lblFechaFinal;
        private DevExpress.XtraEditors.DateEdit deFechaInicio;
        private DevExpress.XtraEditors.DateEdit deFechaFinal;
        private DevExpress.XtraEditors.LabelControl lblUniversidad;

        private DevExpress.XtraEditors.GridLookUpEdit gluUniversidad;
        private System.Windows.Forms.BindingSource clsUniversidadBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn IdUniversidad;
        private DevExpress.XtraEditors.ComboBoxEdit cbeEstado;
    }
}