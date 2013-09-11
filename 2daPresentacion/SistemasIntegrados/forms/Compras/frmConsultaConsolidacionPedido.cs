using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using datos.Compras;
using clases.Compras;

namespace forms.Compras
{
    public partial class frmConsultaConsolidacionPedido : Form
    {
        public static int numero = 0;
        public static int id_empresa = 0;
        public static int tipo_articulo = 0;
        public static int departamento = 0;
        public static int estado = 0;


        public frmConsultaConsolidacionPedido()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaConsolidacionPedido_Load(object sender, EventArgs e)
        {
            datConsolidacionPedido odatPedido = new datConsolidacionPedido();
            dtgCabeceraPedido.DataSource = odatPedido.ConsultarPedidoCabGeneral(frmPrincipalCompras.idEmpresa);
        }


        private void dtgCabeceraPedido_Click_1(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(datosCabPedido.SelectedRowsCount) >= 1)
            {
                datConsolidacionPedido oDatPedido = new datConsolidacionPedido();
                int numero = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(colNumero));
                int idEmpresa = frmPrincipalCompras.idEmpresa;
                dtgDetallePedido.DataSource = oDatPedido.DetallePedido(numero, idEmpresa);

            }
        }

        private void btnCargar_Click_1(object sender, EventArgs e)
        {
            if (Convert.ToInt32(datosCabPedido.SelectedRowsCount) >= 1)
            {
                numero = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(colNumero));
                tipo_articulo = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(colidTipoArticulo));
                //departamento = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(col));
                estado = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(colidEstado));
                id_empresa = Convert.ToInt32(datosCabPedido.GetFocusedRowCellValue(colidEmpresa));
            }
            Dispose();
        }

    }
}
