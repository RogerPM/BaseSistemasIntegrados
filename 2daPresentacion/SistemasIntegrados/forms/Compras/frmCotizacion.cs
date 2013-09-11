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
    public partial class frmCotizacion : Form
    {
        clsMensajesCompras msj = new clsMensajesCompras();

        List<clsCotizacionDetalle_Vista> detalle = new List<clsCotizacionDetalle_Vista>();
        List<clsCotizacionDetalle_Vista> detalle1 = new List<clsCotizacionDetalle_Vista>();
        List<clsCotizacionDetalle_Vista> detalle2 = new List<clsCotizacionDetalle_Vista>();

        clsCotizacionCabecera_Vista oCotizacionCab = new clsCotizacionCabecera_Vista();
        clsCotizacionCabecera_Vista oCotizacionCab1 = new clsCotizacionCabecera_Vista();
        clsCotizacionCabecera_Vista oCotizacionCab2 = new clsCotizacionCabecera_Vista();
        datCotizaciones oDatCotizacion = new datCotizaciones();
        public int id_proveedor1 = 0;
        public int id_proveedor2 = 0;
        public int id_proveedor3 = 0;


        public frmCotizacion()
        {
            InitializeComponent();
        }

        private void frmCotizacion_Load(object sender, EventArgs e)
        {
            lblFecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            btnQuitarPedido.Enabled = false;
            btnRevisarPedidos.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            datCotizaciones oDatCotizacion = new datCotizaciones();
            frmConsultaCotizacion f = new frmConsultaCotizacion();
            f.ShowDialog();


            txtNumero.Text = frmConsultaCotizacion.numero.ToString();
            cmbEstado.SelectedIndex = frmConsultaCotizacion.estado - 1;
            cmbEstado.Enabled = false;
            dtgCotizacionDet.DataSource = oDatCotizacion.DetalleCotizacionVista(frmConsultaCotizacion.numero,frmConsultaCotizacion.id_empresa);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            frmEscogerProveedores f = new frmEscogerProveedores();
            f.ShowDialog();

            txtProveedor1.Text = f.proveedor1;
            txtProveedor2.Text = f.proveedor2;
            txtProveedor3.Text = f.proveedor3;
            id_proveedor1 = f.id_proveedor1;
            id_proveedor2 = f.id_proveedor2;
            id_proveedor3 = f.id_proveedor3;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La cotización fue enviada con éxito a los tres proveedores", "ENVIAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            datCotizaciones oDatCotización = new  datCotizaciones();
            txtNumero.Text = oDatCotización.getIdSiguiente().ToString();
            txtNumero.Enabled = false;
            btnConsultarPedido.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            btnRevisarPedidos.Enabled = true;

        }

        private void btnRevisarPedidos_Click(object sender, EventArgs e)
        {
            frmConsultaConsolidacionPedido f = new frmConsultaConsolidacionPedido();
            f.ShowDialog();


            //aqui se muestra el pedido que se escoge para guardar la nueva cotización
            datConsolidacionPedido odatPedido = new datConsolidacionPedido();
            dtgCotizacionDet.DataSource = odatPedido.ConsultarPedidoCabEspecifica(frmConsultaConsolidacionPedido.numero);
        }


        public bool getValores()
        {
            if (txtNumero.Text == "" || txtNumero.Text == "0")
            {
                oCotizacionCab.Numero = 0;//PK
            }
            else
            {
                oCotizacionCab.Numero = Convert.ToInt32(txtNumero.Text);
            }
            if ((cmbEstado.SelectedItem == null) ||
                (txtProveedor1.Text == "") || (txtProveedor2.Text == "") || (txtProveedor3.Text == ""))
            {
                return false;
            }

            //COTIZACION A 1 PROVEEDOR
            //llenando valores de cabecera  de la Cotizacion1
            oCotizacionCab.Numero = Convert.ToInt32(txtNumero.Text); 
            oCotizacionCab.idEmpresa = frmPrincipalCompras.id_empresa; 
            oCotizacionCab.idUsuario = frmPrincipalCompras.id_usuario;  //esto nos lo da seguridad
            oCotizacionCab.idProveedor = id_proveedor1;
            oCotizacionCab.idEstado = cmbEstado.SelectedIndex + 1;

            //llenando valores de cabecera  de la Cotizacion2
            oCotizacionCab1.Numero = Convert.ToInt32(txtNumero.Text) +1;
            oCotizacionCab1.idEmpresa = frmPrincipalCompras.id_empresa;
            oCotizacionCab1.idUsuario = frmPrincipalCompras.id_usuario;  //esto nos lo da seguridad
            oCotizacionCab1.idProveedor = id_proveedor2;
            oCotizacionCab1.idEstado = cmbEstado.SelectedIndex + 1;

            //llenando valores de cabecera  de la Cotizacion3
            oCotizacionCab2.Numero = Convert.ToInt32(txtNumero.Text) +2;
            oCotizacionCab2.idEmpresa = frmPrincipalCompras.id_empresa;
            oCotizacionCab2.idUsuario = frmPrincipalCompras.id_usuario;  //esto nos lo da seguridad
            oCotizacionCab2.idProveedor = id_proveedor3;
            oCotizacionCab2.idEstado = cmbEstado.SelectedIndex + 1;


            // obteniendo los valores de un detalle
            //se crea una lista con los detalles ya que estos pueden ser uno o más
            int numero_linea = detalleCotDatos.RowCount;
            int i = 0;
            while (i < numero_linea)
            {
                clsCotizacionDetalle_Vista e = new clsCotizacionDetalle_Vista();
                e.Numero = Convert.ToInt32(txtNumero.Text);
                e.IdEmpresa = frmPrincipalCompras.id_empresa;
                //e.linea = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(i, detalleCotDatos.Columns.ColumnByName("collinea")));
                e.linea = 1;
                e.Pedido = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(i, detalleCotDatos.Columns.ColumnByName("colNumero")));
                detalle.Add(e);
                i++;
            }

            // obteniendo los valores de un detalle1
            //se crea una lista con los detalles ya que estos pueden ser uno o más
            int numero = detalleCotDatos.RowCount;
            int j = 0;
            while (j < numero)
            {
                clsCotizacionDetalle_Vista e = new clsCotizacionDetalle_Vista();
                e.Numero = Convert.ToInt32(txtNumero.Text) + 1;
                e.IdEmpresa = frmPrincipalCompras.id_empresa;
                //e.linea = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(j, detalleCotDatos.Columns.ColumnByName("collinea")));
                e.linea = 1;
                e.Pedido = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(j, detalleCotDatos.Columns.ColumnByName("colNumero")));
                detalle.Add(e);
                j++;
            }

            // obteniendo los valores de un detalle1m
            //se crea una lista con los detalles ya que estos pueden ser uno o más
            int linea = detalleCotDatos.RowCount;
            int m = 0;
            while (m< linea)
            {
                clsCotizacionDetalle_Vista e = new clsCotizacionDetalle_Vista();
                e.Numero = Convert.ToInt32(txtNumero.Text) + 2;
                e.IdEmpresa = frmPrincipalCompras.id_empresa;
                //e.linea = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(m, detalleCotDatos.Columns.ColumnByName("collinea")));
                e.linea = 1;
                e.Pedido = Convert.ToInt32(detalleCotDatos.GetRowCellDisplayText(m, detalleCotDatos.Columns.ColumnByName("colNumero")));
                detalle.Add(e);
                m++;
            }
            return true;
        }
        


        private void btnaceptar_Click(object sender, EventArgs e)
        {
            //Este proceso se efectúa para guardadr la cadecera de las cotizaciones
            if (getValores())
            {
                if (btnConsultarPedido.Enabled.Equals(false))
                {
                    //guardo la cabecera y el detalle
                    if (oDatCotizacion.Guardar(oCotizacionCab) && oDatCotizacion.Guardar(oCotizacionCab) && oDatCotizacion.Guardar(oCotizacionCab) &&  
                        oDatCotizacion.GuardarDet(detalle) && oDatCotizacion.GuardarDet(detalle1) && oDatCotizacion.GuardarDet(detalle2))
                    {
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
