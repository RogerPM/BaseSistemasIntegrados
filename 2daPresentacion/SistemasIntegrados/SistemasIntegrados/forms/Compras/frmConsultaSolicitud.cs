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
    public partial class frmConsultaSolicitud : Form
    {
        public static int numero = 0;
        public static int id_empresa = 0;
        public static int id_usuario = 0;
        public static int tipo_articulo = 0;
        public static int departamento = 0;
        public static int estado = 0;



        public frmConsultaSolicitud()
        {
            InitializeComponent();
        }

        private void frmConsultaSolicitud_Load(object sender, EventArgs e)
        {
            datSolicitud oSolicitud = new datSolicitud();
            dtgSolCab.DataSource = oSolicitud.ConsultarSolicitudCab();
        }

        /*private void dtgSolCab_Click_1(object sender, EventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(SolCabDatos.SelectedRowsCount) >= 1)
            {
                datSolicitud oSolicitud = new datSolicitud();
                int numero = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colNumero));
                int id_empresa = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Empresa));
                dtgSolDet.DataSource = oSolicitud.Detalle_Solicitud(numero, id_empresa);

            }
        }*/

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(SolCabDatos.SelectedRowsCount) >= 1)
            {
                numero = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colNumero));
                tipo_articulo = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Tipo_Articulo));
                departamento = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Departamento));
                estado = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Estado));
                id_empresa = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Empresa));
                id_usuario = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Usuario));
            }
            Dispose();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolCabDatos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //PRIMERO DEBEMOS DE VERIFICAR SI EXISTEN ELEMENTOS EN NUESTRO DATAGRIDVIEW
            if (Convert.ToInt32(SolCabDatos.SelectedRowsCount) >= 1)
            {
                datSolicitud oSolicitud = new datSolicitud();
                int numero = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colNumero));
                int id_empresa = Convert.ToInt32(SolCabDatos.GetFocusedRowCellValue(colId_Empresa));
                dtgSolDet.DataSource = oSolicitud.Detalle_Solicitud(numero, id_empresa);

            }
        }

    }
}
