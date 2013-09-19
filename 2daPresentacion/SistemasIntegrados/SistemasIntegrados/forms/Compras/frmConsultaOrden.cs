using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using datos.Compras;

namespace forms.Compras
{
    public partial class frmConsultaOrden : Form
    {
        public static int numero = 0;
        public static int id_empresa = 0;
        public static int estado = 0;
        public static int id_proveedor = 0;
        public static string proveedor = "";
        
        public frmConsultaOrden()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmConsultaOrden_Load(object sender, EventArgs e)
        {
            datOrdenCompra odatOrden = new datOrdenCompra();
            dtgOrdenCab.DataSource = odatOrden.ConsultarOrdenCompraCab(frmPrincipalCompras.id_empresa);

         }

        private void dtgOrdenCab_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DatosOrdenCab.SelectedRowsCount) >= 1)
            {
                datOrdenCompra odatOrden = new datOrdenCompra();
                int numero = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colNumero));
                int id_empresa = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colidEmpresa));
                dtgOrdenDet.DataSource = odatOrden.DetalleOrdenCompra(numero, id_empresa);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DatosOrdenCab.SelectedRowsCount) >= 1)
            {
                numero = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colNumero));
                id_empresa = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colidEmpresa));
                estado = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colidEstado));
                id_proveedor = Convert.ToInt32(DatosOrdenCab.GetFocusedRowCellValue(colidProveedor));
                proveedor = Convert.ToString(DatosOrdenCab.GetFocusedRowCellValue(colProveedor));
                
            }
            Dispose();
        }
    }
}
