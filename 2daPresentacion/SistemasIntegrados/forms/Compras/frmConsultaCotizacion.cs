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
    public partial class frmConsultaCotizacion : Form
    {

        public static int numero = 0;
        public static int id_empresa = 0;
        public static int estado = 0;


        public frmConsultaCotizacion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultaCotizacion_Load(object sender, EventArgs e)
        {
            datCotizaciones oDatCotizacion = new datCotizaciones();
            dtgCabeceraCotizacion.DataSource = oDatCotizacion.ConsultarCotizacionCab(frmPrincipalCompras.id_empresa);
        }

        private void dtgCabeceraCotizacion_Click(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(DatosCabeceraCot.SelectedRowsCount) >= 1)
            {
                datCotizaciones oDatCotizacion = new datCotizaciones();
                int numero = Convert.ToInt32(DatosCabeceraCot.GetFocusedRowCellValue(colNumero));
                int id_empresa = Convert.ToInt32(DatosCabeceraCot.GetFocusedRowCellValue(colidEmpresa));
                dtgDetalleCotizacion.DataSource = oDatCotizacion.DetalleCotizacionVista(numero, id_empresa);

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DatosCabeceraCot.SelectedRowsCount) >= 1)
            {
                numero = Convert.ToInt32(DatosCabeceraCot.GetFocusedRowCellValue(colNumero));
                id_empresa = Convert.ToInt32(DatosCabeceraCot.GetFocusedRowCellValue(colidEmpresa));
                estado = Convert.ToInt32(DatosCabeceraCot.GetFocusedRowCellValue(colidEstado));
            }
            Dispose();
        }
    }
}
