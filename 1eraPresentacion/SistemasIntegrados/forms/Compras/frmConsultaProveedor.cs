using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using datos.Compras;
using clases.Compras;




namespace forms.Compras
{
    public partial class frmConsultaProveedor : Form
    {

        public static string nombre_proveedor = "";
        public static string nombre_proveedorempresa = "";
        public static int id_proveedor;
        public static int id_persona;
        public static int id_empresa;
        public static int id_tipo_articulo;
        public static int id_estado;


        public frmConsultaProveedor()
        {
            InitializeComponent();
        }
        
        private void frmConsultaProveedor_Load(object sender, EventArgs e)
        {
            datProveedor oProveedor = new datProveedor();
            dtgProveedor.DataSource = oProveedor.ConsultarProveedorDescripcion();
        }


        

        
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dtgProveedor_Click_1(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(ProveedorDatos.SelectedRowsCount) >= 1)
            {
                nombre_proveedor = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colnombrerazonsocial));
                nombre_proveedorempresa = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colrazonsocial));
                id_proveedor = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidProveedor));
                id_empresa = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidEmpresa));
                id_tipo_articulo = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidTipoArticulo));
                id_estado = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colEstado));
            }
            Dispose();
        }





    }
}
