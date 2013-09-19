namespace forms.Taller
{
    partial class frmConsultarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarCliente));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSelec = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clsClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colidEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelec,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSelec
            // 
            this.btnSelec.Image = ((System.Drawing.Image)(resources.GetObject("btnSelec.Image")));
            this.btnSelec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelec.Name = "btnSelec";
            this.btnSelec.Size = new System.Drawing.Size(87, 22);
            this.btnSelec.Text = "Seleccionar";
            this.btnSelec.Click += new System.EventHandler(this.btnSelec_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(214, 22);
            this.toolStripLabel1.Text = "                                                                     ";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.clsClienteBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(799, 306);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colIdentificacion,
            this.colIdTipoPersona,
            this.colNombre,
            this.colApellido,
            this.colFechaNacimiento,
            this.colGenero,
            this.colTipoIdentificacion,
            this.colDireccion,
            this.colTelefono,
            this.colMail,
            this.colidEstado,
            this.colidEmpresa});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // clsClienteBindingSource
            // 
            this.clsClienteBindingSource.DataSource = typeof(clases.Taller.clsCliente);
            // 
            // colIdPersona
            // 
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.FieldName = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.Visible = true;
            this.colIdentificacion.VisibleIndex = 0;
            // 
            // colIdTipoPersona
            // 
            this.colIdTipoPersona.FieldName = "IdTipoPersona";
            this.colIdTipoPersona.Name = "colIdTipoPersona";
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colApellido
            // 
            this.colApellido.FieldName = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.Visible = true;
            this.colApellido.VisibleIndex = 2;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.FieldName = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Visible = true;
            this.colFechaNacimiento.VisibleIndex = 3;
            // 
            // colGenero
            // 
            this.colGenero.FieldName = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.Visible = true;
            this.colGenero.VisibleIndex = 4;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.FieldName = "TipoIdentificacion";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 6;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 7;
            // 
            // colidEstado
            // 
            this.colidEstado.FieldName = "idEstado";
            this.colidEstado.Name = "colidEstado";
            this.colidEstado.Visible = true;
            this.colidEstado.VisibleIndex = 8;
            // 
            // colidEmpresa
            // 
            this.colidEmpresa.FieldName = "idEmpresa";
            this.colidEmpresa.Name = "colidEmpresa";
            // 
            // frmConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 333);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmConsultarCliente";
            this.Text = "frmConsultarCliente";
            this.Load += new System.EventHandler(this.frmConsultarCliente_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSelec;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsClienteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colGenero;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colidEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colidEmpresa;
    }
}