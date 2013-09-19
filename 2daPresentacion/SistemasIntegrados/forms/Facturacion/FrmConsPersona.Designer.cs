namespace forms.Facturacion
{
    partial class FrmConsPersona
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
            this.gdPersona = new DevExpress.XtraGrid.GridControl();
            this.gvEmpleado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGeneral = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMovil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbConsultado = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gdPersona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleado)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gdPersona
            // 
            this.gdPersona.Location = new System.Drawing.Point(0, 28);
            this.gdPersona.MainView = this.gvEmpleado;
            this.gdPersona.Name = "gdPersona";
            this.gdPersona.Size = new System.Drawing.Size(658, 220);
            this.gdPersona.TabIndex = 29;
            this.gdPersona.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmpleado});
            this.gdPersona.Click += new System.EventHandler(this.gdPersona_Click);
            // 
            // gvEmpleado
            // 
            this.gvEmpleado.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colIdentificacion,
            this.colIdTipoPersona,
            this.colNombreRazonSocial,
            this.colApellido,
            this.colFechaNacimiento,
            this.colgenero,
            this.colTipoIdentificacion,
            this.coldireccion,
            this.colGeneral,
            this.colMovil,
            this.colCasa,
            this.colOtros,
            this.colmail,
            this.colIdEmpresa,
            this.colIdEstado,
            this.colfoto});
            this.gvEmpleado.GridControl = this.gdPersona;
            this.gvEmpleado.Name = "gvEmpleado";
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
            // colNombreRazonSocial
            // 
            this.colNombreRazonSocial.FieldName = "NombreRazonSocial";
            this.colNombreRazonSocial.Name = "colNombreRazonSocial";
            this.colNombreRazonSocial.Visible = true;
            this.colNombreRazonSocial.VisibleIndex = 1;
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
            // colgenero
            // 
            this.colgenero.FieldName = "genero";
            this.colgenero.Name = "colgenero";
            this.colgenero.Visible = true;
            this.colgenero.VisibleIndex = 4;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.FieldName = "TipoIdentificacion";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            // 
            // coldireccion
            // 
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 5;
            // 
            // colGeneral
            // 
            this.colGeneral.FieldName = "General";
            this.colGeneral.Name = "colGeneral";
            this.colGeneral.Visible = true;
            this.colGeneral.VisibleIndex = 6;
            // 
            // colMovil
            // 
            this.colMovil.FieldName = "Movil";
            this.colMovil.Name = "colMovil";
            this.colMovil.Visible = true;
            this.colMovil.VisibleIndex = 7;
            // 
            // colCasa
            // 
            this.colCasa.FieldName = "Casa";
            this.colCasa.Name = "colCasa";
            this.colCasa.Visible = true;
            this.colCasa.VisibleIndex = 8;
            // 
            // colOtros
            // 
            this.colOtros.FieldName = "Otros";
            this.colOtros.Name = "colOtros";
            this.colOtros.Visible = true;
            this.colOtros.VisibleIndex = 9;
            // 
            // colmail
            // 
            this.colmail.FieldName = "mail";
            this.colmail.Name = "colmail";
            this.colmail.Visible = true;
            this.colmail.VisibleIndex = 10;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colfoto
            // 
            this.colfoto.FieldName = "foto";
            this.colfoto.Name = "colfoto";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbConsultado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbConsultado
            // 
            this.tsbConsultado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsbConsultado.ForeColor = System.Drawing.Color.Black;
            this.tsbConsultado.Image = global::forms.Properties.Resources._24_aceptar;
            this.tsbConsultado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbConsultado.Name = "tsbConsultado";
            this.tsbConsultado.Size = new System.Drawing.Size(88, 22);
            this.tsbConsultado.Text = "Consultado";
            this.tsbConsultado.Click += new System.EventHandler(this.tsbConsultado_Click);
            // 
            // FrmConsPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 262);
            this.Controls.Add(this.gdPersona);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmConsPersona";
            this.Text = "FrmConsPersona";
            this.Load += new System.EventHandler(this.FrmConsPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdPersona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmpleado)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gdPersona;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colgenero;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colGeneral;
        private DevExpress.XtraGrid.Columns.GridColumn colMovil;
        private DevExpress.XtraGrid.Columns.GridColumn colCasa;
        private DevExpress.XtraGrid.Columns.GridColumn colOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colmail;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colfoto;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbConsultado;
    }
}