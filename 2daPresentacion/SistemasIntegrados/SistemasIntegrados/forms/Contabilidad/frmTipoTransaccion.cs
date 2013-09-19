using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Contabilidad;
using datos.Contabilidad;
using System.Data.SqlClient;

namespace forms.Contabilidad
{
    public partial class frmTipoTransaccion : Form
    {
        #region "Distributed by security team 3/3"
        private void Seguridad()
        {
            toolStripButton1.Visible = frmPrincipal.Lectura;
            btnGuardar.Visible = frmPrincipal.Escritura;
            btnModificar.Visible = frmPrincipal.Escritura;
            btnEliminar.Visible = frmPrincipal.Eliminacion;
        }
        #endregion
        public frmTipoTransaccion()
        {
            InitializeComponent();
        }
        /*
        ClaseTP addTP = new ClaseTP();
        //NModeloAsiento addModeloAsientoG = new NModeloAsiento();
        private void ListarTP()
        {
            try
            {
                this.dtgrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                this.dtgrid.DataSource = this.addTP.ListarTP(this.cmbModulo.Text);
                this.dtgrid.Columns[0].HeaderText = "Transaccion";
                this.dtgrid.Columns[1].HeaderText = "Modulo";
                this.dtgrid.Columns[2].HeaderText = "Tipo de Documentos";
                this.dtgrid.Columns[2].Width = 100;
                this.dtgrid.Columns[3].HeaderText = "Descripcion";
                

            }
            catch (Exception)
            {


            }
        }
        */
        public void llenacombobox()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = @"Data Source=(local);Initial Catalog=TECA;Integrated Security=True";
            //código para llenar el comboBox
            DataSet ds = new DataSet();
            //indicamos la consulta en SQL
            SqlDataAdapter da = new SqlDataAdapter("SELECT Nombre FROM Seguridad.Modulo ", conexion);
            //se indica el nombre de la tabla
            da.Fill(ds, "Seguridad.Modulo");
            cmbModulo.DataSource = ds.Tables[0].DefaultView;
            //se especifica el campo de la tabla
            cmbModulo.ValueMember = "Nombre";
        }
        




        //METODOS
        private void frmTipoTransaccion_Load(object sender, EventArgs e)
        {
            
            llenacombobox();
            //this.ListarTP();
            Seguridad();
        }

        
        //METODO PARA LLENAR EL GRIDCONTROL
        
        public void consultar()
        {
            clsDatoTipoTransaccion clas = new clsDatoTipoTransaccion();
            //gridControl1.DataSource = clas.Consulta(Convert.ToInt32(cmbModulo));
            //gridControl1.DataSource = clas.Consulta(Convert.ToInt32(1));
            gridControl1.DataSource = clas.Consulta();
        }
        
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            consultar();
        }



        clsTipoTransaccion clasper = new clsTipoTransaccion();
        public void get()
        {
            clasper.IdTransaccion = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdTransaccion));
            clasper.modulo = Convert.ToInt32(cmbModulo.SelectedIndex+1);
            clasper.TipoDocumento = Convert.ToString(gridView1.GetFocusedRowCellValue(colTipoDocumento));
            clasper.descripcion = Convert.ToString(gridView1.GetFocusedRowCellValue(coldescripcion));

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {   
            
            frmMantenimientoTipoTransaccion frm = new frmMantenimientoTipoTransaccion();
            get();
            frm.clas = clasper;
            frm.accion = "M";
            frm.ShowDialog();
            MessageBox.Show("Transacción modificada con exito");
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            frmMantenimientoTipoTransaccion frm = new frmMantenimientoTipoTransaccion();
            //get();
            frm.clas = clasper;
            frm.accion = "G";
            frm.ShowDialog();
            MessageBox.Show("Transacción creada con exito");
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            frmMantenimientoTipoTransaccion frm = new frmMantenimientoTipoTransaccion();
            get();
            frm.clas = clasper;
            frm.accion = "E";
            frm.ShowDialog();
            MessageBox.Show("Transacción eliminada con exito");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //var vari = from q in (List<clsTipoTransaccion>)clsTipoTransaccionBindingSource3.DataSource where q.nombremodulo == cmbModulo.Text select q;
                clsDatoTipoTransaccion clas = new clsDatoTipoTransaccion();
                //gridControl1.DataSource = clas.Consulta(Convert.ToInt32(cmbModulo));
                //gridControl1.DataSource = clas.Consulta(Convert.ToInt32(1));
                gridControl1.DataSource = (clas.Consulta().Where(q => q.nombremodulo == cmbModulo.Text)).ToList();
            }
            catch (Exception)
            {
            }
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        }


    }
}

