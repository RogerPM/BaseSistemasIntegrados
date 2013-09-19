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
    public partial class frmOrdencompra : Form
    {
        public static int idOrden = 0;
        public static int id_empresa = 0;
        public static int numerocotizacion=0;

        
        public frmOrdencompra()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            datOrdenCompra oDatOrden = new datOrdenCompra();
            frmConsultaOrden f = new frmConsultaOrden();
            f.ShowDialog();

            txtNumero.Text = frmConsultaOrden.numero.ToString();
            txtProveedor.Text = frmConsultaOrden.proveedor.ToString();
            cmbEstado.SelectedIndex = frmConsultaOrden.estado - 1;
            cmbEstado.Enabled = false;
            dtgOrdenDet.DataSource = oDatOrden.DetalleOrdenCompra(frmConsultaOrden.numero, frmConsultaOrden.id_empresa);
            //btnRevisarCotizaciones.Enabled = false;
            txtProveedor.Enabled = false;
            lblProveedor.Visible = true;
            txtProveedor.Visible = true;
        }

        private void frmOrdencompra_Load(object sender, EventArgs e)
        {
            lblFecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            lblProveedor.Visible = false;
            txtProveedor.Visible = false;
            txtNumero.Enabled = false;
            cmbEstado.Enabled = false;
            //btnRevisarCotizaciones.Enabled = false;

        }

        private void btnRevisarCotizaciones_Click(object sender, EventArgs e)
        {
            datOrdenCompra oDatOrden = new datOrdenCompra();
            frmConsultaCotizacion F = new frmConsultaCotizacion();
            F.ShowDialog();
            
            idOrden= Convert.ToInt32(txtNumero.Text);
            id_empresa= frmPrincipalCompras.id_empresa;
            numerocotizacion= frmConsultaCotizacion.numero;

            dtgOrdenDet.DataSource = oDatOrden.DetalleOrdenCompraConAticulo(idOrden,id_empresa,numerocotizacion);
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            datOrdenCompra oDatOrden = new datOrdenCompra();
            btnConsultarPedido.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            DatosOrdenDet.Columns.Clear();
            txtNumero.Text = oDatOrden.getIdSiguiente().ToString();
            //btnRevisarCotizaciones.Enabled = true;

        }
    }
}
