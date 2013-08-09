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
        public frmTipoTransaccion()
        {
            InitializeComponent();
        }


        public void llenacombobox()
        {
            //se declara una variable de tipo SqlConnection
            SqlConnection conexion = new SqlConnection();
            //se indica la cadena de conexion
            conexion.ConnectionString = @"Data Source=(local);Initial Catalog=TECAv8;Integrated Security=True";
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
            //
            llenacombobox();

        }
        //METODO PARA LLENAR EL GRIDCONTROL
        public void consultar()
        {
            clsDatoTipoTransaccion clas = new clsDatoTipoTransaccion();
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
            //clasper.modulo = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colmodulo));
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
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoTransaccion frm = new frmMantenimientoTipoTransaccion();
            get();
            frm.clas = clasper;
            frm.accion = "G";
            frm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            frmMantenimientoTipoTransaccion frm = new frmMantenimientoTipoTransaccion();
            get();
            frm.clas = clasper;
            frm.accion = "E";
            frm.ShowDialog();
            //
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}

