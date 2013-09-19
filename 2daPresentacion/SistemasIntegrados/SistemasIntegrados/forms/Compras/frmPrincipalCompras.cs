using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forms.Compras
{
    public partial class frmPrincipalCompras : Form
    {
        public static int id_empresa = 1;
        public static int id_usuario = 117;
        public static int idEmpresa = 1;
        public static int idUsuario = 117;


        public frmPrincipalCompras()
        {
            InitializeComponent();
        }

        private void mniProveedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProveedor f = new frmProveedor();
            f.ShowDialog();
        }

        private void frmPrincipalCompras_Load(object sender, EventArgs e)
        {
            
        }

        private void mniSolicitud_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSolicitud F = new frmSolicitud();
            F.ShowDialog();
        }

        private void mniConsolidar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmConsolidacionPedidos f = new frmConsolidacionPedidos();
            f.ShowDialog();
        }


        private void btnCotizacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCotizacion f = new frmCotizacion();
            f.ShowDialog();
        }

        private void mniOrdenCompra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOrdencompra f = new frmOrdencompra();
            f.ShowDialog();
        }

        private void mniEntregaProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
