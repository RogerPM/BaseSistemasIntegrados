namespace forms.Seguridad
{
    partial class frmConsultaGeneral
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
            this.gcConsulta = new DevExpress.XtraGrid.GridControl();
            this.clsPersonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEmpresa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdTipoPersona = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreRazonSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGenero = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipoIdentificacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoGneral = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoMovil = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoCasa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonoOtros = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcConsulta
            // 
            this.gcConsulta.DataSource = this.clsPersonaBindingSource;
            this.gcConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConsulta.Location = new System.Drawing.Point(0, 0);
            this.gcConsulta.MainView = this.gridView1;
            this.gcConsulta.Name = "gcConsulta";
            this.gcConsulta.Size = new System.Drawing.Size(714, 255);
            this.gcConsulta.TabIndex = 8;
            this.gcConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsPersonaBindingSource
            // 
            this.clsPersonaBindingSource.DataSource = typeof(clases.RecursosHumanos.clsPersona);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdPersona,
            this.colIdentificacion,
            this.colIdEmpresa,
            this.colIdTipoPersona,
            this.colNombreRazonSocial,
            this.colApellido,
            this.colFechaNacimiento,
            this.colGenero,
            this.colTipoIdentificacion,
            this.colDireccion,
            this.colTelefonoGneral,
            this.colTelefonoMovil,
            this.colTelefonoCasa,
            this.colTelefonoOtros,
            this.colMail,
            this.colIdEstado});
            this.gridView1.GridControl = this.gcConsulta;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.Click += new System.EventHandler(this.gridView1_Click);
            // 
            // colIdPersona
            // 
            this.colIdPersona.Caption = "Código";
            this.colIdPersona.FieldName = "IdPersona";
            this.colIdPersona.Name = "colIdPersona";
            this.colIdPersona.Visible = true;
            this.colIdPersona.VisibleIndex = 0;
            this.colIdPersona.Width = 76;
            // 
            // colIdentificacion
            // 
            this.colIdentificacion.FieldName = "Identificacion";
            this.colIdentificacion.Name = "colIdentificacion";
            this.colIdentificacion.Width = 80;
            // 
            // colIdEmpresa
            // 
            this.colIdEmpresa.FieldName = "IdEmpresa";
            this.colIdEmpresa.Name = "colIdEmpresa";
            this.colIdEmpresa.Width = 71;
            // 
            // colIdTipoPersona
            // 
            this.colIdTipoPersona.FieldName = "IdTipoPersona";
            this.colIdTipoPersona.Name = "colIdTipoPersona";
            this.colIdTipoPersona.Width = 90;
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
            this.colApellido.Width = 85;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.FieldName = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Visible = true;
            this.colFechaNacimiento.VisibleIndex = 3;
            this.colFechaNacimiento.Width = 94;
            // 
            // colGenero
            // 
            this.colGenero.FieldName = "Genero";
            this.colGenero.Name = "colGenero";
            this.colGenero.Visible = true;
            this.colGenero.VisibleIndex = 4;
            this.colGenero.Width = 55;
            // 
            // colTipoIdentificacion
            // 
            this.colTipoIdentificacion.FieldName = "TipoIdentificacion";
            this.colTipoIdentificacion.Name = "colTipoIdentificacion";
            this.colTipoIdentificacion.Visible = true;
            this.colTipoIdentificacion.VisibleIndex = 5;
            this.colTipoIdentificacion.Width = 45;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 6;
            this.colDireccion.Width = 77;
            // 
            // colTelefonoGneral
            // 
            this.colTelefonoGneral.FieldName = "TelefonoGneral";
            this.colTelefonoGneral.Name = "colTelefonoGneral";
            this.colTelefonoGneral.Visible = true;
            this.colTelefonoGneral.VisibleIndex = 7;
            this.colTelefonoGneral.Width = 47;
            // 
            // colTelefonoMovil
            // 
            this.colTelefonoMovil.FieldName = "TelefonoMovil";
            this.colTelefonoMovil.Name = "colTelefonoMovil";
            this.colTelefonoMovil.Width = 27;
            // 
            // colTelefonoCasa
            // 
            this.colTelefonoCasa.FieldName = "TelefonoCasa";
            this.colTelefonoCasa.Name = "colTelefonoCasa";
            this.colTelefonoCasa.Width = 27;
            // 
            // colTelefonoOtros
            // 
            this.colTelefonoOtros.FieldName = "TelefonoOtros";
            this.colTelefonoOtros.Name = "colTelefonoOtros";
            this.colTelefonoOtros.Width = 27;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 8;
            this.colMail.Width = 118;
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            this.colIdEstado.Visible = true;
            this.colIdEstado.VisibleIndex = 9;
            this.colIdEstado.Width = 24;
            // 
            // frmConsultaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 255);
            this.Controls.Add(this.gcConsulta);
            this.Name = "frmConsultaGeneral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta General";
            this.Load += new System.EventHandler(this.frmConsultaGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsPersonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcConsulta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource clsPersonaBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpresa;
        private DevExpress.XtraGrid.Columns.GridColumn colIdTipoPersona;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreRazonSocial;
        private DevExpress.XtraGrid.Columns.GridColumn colApellido;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colGenero;
        private DevExpress.XtraGrid.Columns.GridColumn colTipoIdentificacion;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoGneral;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoMovil;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoCasa;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonoOtros;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
    }
}