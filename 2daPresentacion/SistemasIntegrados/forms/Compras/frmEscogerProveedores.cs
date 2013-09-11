using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using clases.Compras;
using datos.Compras;

namespace forms.Compras
{
    public partial class frmEscogerProveedores : Form
    {

        public List<clsProveedorDescripcion> escogido = new List<clsProveedorDescripcion>();
        public string proveedor1 = "";
        public string proveedor2 = "";
        public string proveedor3 = "";
        public int id_proveedor1 = 0;
        public int id_proveedor2 = 0;
        public int id_proveedor3 = 0;

        public frmEscogerProveedores()
        {
            InitializeComponent();
        }

        private void frmEscogerProveedores_Load(object sender, EventArgs e)
        {
            datProveedor oProveedor = new datProveedor();
            dtgProveedor.DataSource = oProveedor.ConsultarProveedorDescripcion();
        }

        /* private void dtgProveedor_Click(object sender, EventArgs e)
        {
            int proveedor = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidProveedor));
            int persona = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidPersona));
            string razon_social = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colnombrerazonsocial));
            int empresa = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidEmpresa));
            string noempresa = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colrazonsocial));
            int tipoArticulo = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidTipoArticulo));
            string descripcion = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(coldescripcion));
            int estado = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colEstado));


            escogido.Add(new clsProveedorDescripcion(proveedor,persona,razon_social,empresa,noempresa,tipoArticulo,descripcion,estado));

            //clsProveedorDescripcion escogido = new clsProveedorDescripcion();

            //escogido.idP
            dtgescogido.DataSource = escogido;
        }*/


        private void btnCargar_Click(object sender, EventArgs e)
        {
            proveedor1 = Convert.ToString(escogidoDatos.GetRowCellDisplayText(0, escogidoDatos.Columns.ColumnByName("colnombrerazonsocial")));
            proveedor2 = Convert.ToString(escogidoDatos.GetRowCellDisplayText(1, escogidoDatos.Columns.ColumnByName("colnombrerazonsocial")));
            proveedor3 = Convert.ToString(escogidoDatos.GetRowCellDisplayText(2, escogidoDatos.Columns.ColumnByName("colnombrerazonsocial")));
            id_proveedor1 = Convert.ToInt32(escogidoDatos.GetRowCellDisplayText(0, escogidoDatos.Columns.ColumnByName("colidProveedor")));
            id_proveedor2 = Convert.ToInt32(escogidoDatos.GetRowCellDisplayText(1, escogidoDatos.Columns.ColumnByName("colidProveedor")));
            id_proveedor3 = Convert.ToInt32(escogidoDatos.GetRowCellDisplayText(2, escogidoDatos.Columns.ColumnByName("colidProveedor")));

            Dispose();
        }

        private void ProveedorDatos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int proveedor = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidProveedor));
            int persona = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidPersona));
            string razon_social = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colnombrerazonsocial));
            int empresa = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidEmpresa));
            string noempresa = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(colrazonsocial));
            int tipoArticulo = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colidTipoArticulo));
            string descripcion = Convert.ToString(ProveedorDatos.GetFocusedRowCellValue(coldescripcion));
            int estado = Convert.ToInt32(ProveedorDatos.GetFocusedRowCellValue(colEstado));


            escogido.Add(new clsProveedorDescripcion(proveedor, persona, razon_social, empresa, noempresa, tipoArticulo, descripcion, estado));

            //clsProveedorDescripcion escogido = new clsProveedorDescripcion();

            //escogido.idP
            dtgescogido.DataSource = escogido;
        }

    }
}
