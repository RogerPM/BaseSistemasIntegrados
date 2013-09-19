using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using datos.Seguridad;
namespace forms.Seguridad
{
    public partial class frmConsultarUsuario : Form
    {
        #region Windows Form Codigo generado por el diseñador
        private DevExpress.XtraGrid.GridControl gcConsulta;
        private BindingSource clsUsuarioBindingSource;
        private IContainer components;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colContrasena;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdImagen;
        private DevExpress.XtraGrid.Columns.GridColumn colIdPerfil;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gcConsulta = new DevExpress.XtraGrid.GridControl();
            this.clsUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContrasena = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdImagen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdPerfil = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcConsulta
            // 
            this.gcConsulta.DataSource = this.clsUsuarioBindingSource;
            this.gcConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConsulta.Location = new System.Drawing.Point(0, 0);
            this.gcConsulta.MainView = this.gridView1;
            this.gcConsulta.Name = "gcConsulta";
            this.gcConsulta.Size = new System.Drawing.Size(423, 262);
            this.gcConsulta.TabIndex = 0;
            this.gcConsulta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // clsUsuarioBindingSource
            // 
            this.clsUsuarioBindingSource.DataSource = typeof(clases.Seguridad.clsUsuario);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colNombreUsuario,
            this.colContrasena,
            this.colIdEstado,
            this.colIdImagen,
            this.colIdPerfil});
            this.gridView1.GridControl = this.gcConsulta;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            // 
            // colNombreUsuario
            // 
            this.colNombreUsuario.FieldName = "NombreUsuario";
            this.colNombreUsuario.Name = "colNombreUsuario";
            this.colNombreUsuario.Visible = true;
            this.colNombreUsuario.VisibleIndex = 1;
            // 
            // colContrasena
            // 
            this.colContrasena.FieldName = "Contrasena";
            this.colContrasena.Name = "colContrasena";
            // 
            // colIdEstado
            // 
            this.colIdEstado.FieldName = "IdEstado";
            this.colIdEstado.Name = "colIdEstado";
            // 
            // colIdImagen
            // 
            this.colIdImagen.FieldName = "IdImagen";
            this.colIdImagen.Name = "colIdImagen";
            // 
            // colIdPerfil
            // 
            this.colIdPerfil.FieldName = "IdPerfil";
            this.colIdPerfil.Name = "colIdPerfil";
            // 
            // frmConsultarUsuario
            // 
            this.ClientSize = new System.Drawing.Size(423, 262);
            this.Controls.Add(this.gcConsulta);
            this.Name = "frmConsultarUsuario";
            this.Load += new System.EventHandler(this.frmConsultarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clsUsuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        public clsUsuario oUsuario=new clsUsuario();
        public frmConsultarUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }
        public void LlenarGrid()
        {
            try
            {
                datUsuario datUSu = new datUsuario();
                gcConsulta.DataSource = datUSu.ConsultarTodos();
            }
            catch (Exception)
            {
                MessageBox.Show("No Hay registros", "Información", MessageBoxButtons.OK);
            }
        }
        private clsUsuario getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsUsuario)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            oUsuario = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            Close();
        }
        
    }
}
