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
    public partial class frmConsolidacionPedidos : Form
    {
        datConsolidacionPedido oDatCons_Pedido = new datConsolidacionPedido();
        clsMensajesCompras msj = new clsMensajesCompras();
        public List<clsSolicitudDet> listaSolicitudDet = new List<clsSolicitudDet>();
        public List<clsSolicitudDet> lista_Nueva = new List<clsSolicitudDet>();
        public List<clsSolicitudDet> lista_Ordenada = new List<clsSolicitudDet>();
        public List<clsConsolidacionPedidoDet> listaSolicitudDetNueva = new List<clsConsolidacionPedidoDet>();
        clsConsolidacionPedido oCons_Pedido = new clsConsolidacionPedido();
        public int veces = 0;

        //Datos que se necesita para una solicitud cambiarla de estado ativa a procesada
        //y no aparezca al momento de seleccionar una Solicitud
        //public int[]  numero_solicitud[6];
         public int[] numero_solicitud = new int[6];

        public frmConsolidacionPedidos()
        {
            InitializeComponent();
        }

        private void frmConsolidacionPedidos_Load(object sender, EventArgs e)
        {
            lblFecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            btnRevisarSolicitudes.Enabled = false;
            btnQuitarSolicitud.Enabled = false;
            cmbTipoArticulo.Enabled = false;
            cmbEstado.Enabled = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarPedido_Click(object sender, EventArgs e)
        {
            frmConsultaConsolidacionPedido f = new frmConsultaConsolidacionPedido();
            datConsolidacionPedido oDatPedido = new datConsolidacionPedido();
            f.ShowDialog();
            txtNumero.Text = frmConsultaConsolidacionPedido.numero.ToString();
            cmbTipoArticulo.SelectedIndex = frmConsultaConsolidacionPedido.tipo_articulo - 1;
            cmbEstado.SelectedIndex = frmConsultaConsolidacionPedido.estado - 1;
            dtgPedidoDetalle.DataSource = oDatPedido.DetallePedido(frmConsultaConsolidacionPedido.numero, frmConsultaConsolidacionPedido.id_empresa);
            txtNumero.Enabled = false;
            btnRevisarSolicitudes.Enabled = false;
            dtgPedidoDetalle.Enabled = false;

        }

        private void dtgPedidoDetalle_Click(object sender, EventArgs e)
        {

        }

        private void btnRevisarSolicitudes_Click(object sender, EventArgs e)
        {
            veces++;
            datSolicitud oDatSolicitud = new datSolicitud();
            clsSolicitudDet obj = new clsSolicitudDet();
            frmConsultaSolicitud f = new frmConsultaSolicitud();
            f.ShowDialog();
            cmbTipoArticulo.SelectedIndex = frmConsultaSolicitud.tipo_articulo - 1;
            listaSolicitudDet = oDatSolicitud.Detalle_Solicitud(frmConsultaSolicitud.numero, frmConsultaSolicitud.id_empresa);
            int cantidad = listaSolicitudDet.Count();
            int i = 0;
            while (i < cantidad)
            {
                obj = listaSolicitudDet[i];
                lista_Nueva.Add(obj);
                i++;

            }
            //Guardando los números de detalle de las solicitudes para consolidarlas
            clsSolicitudDet obj1 = new clsSolicitudDet();
            int j = 0;

            while (j < cantidad)
            {
                    numero_solicitud[j] = listaSolicitudDet[j].Numero;
                    j++;
            }
            
            //dtgPedidoDetalle.DataSource = oDatSolicitud.Detalle_Solicitud(frmConsultaSolicitud.numero, frmConsultaSolicitud.id_empresa);
            if (veces > 1)
            {
                OrdenarDetalle();
                dtgPedidoDetalle.DataSource = lista_Ordenada;
            }
            else
            {
                dtgPedidoDetalle.DataSource = lista_Nueva;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            datConsolidacionPedido oDatConsolidacionPedido = new datConsolidacionPedido();
            btnRevisarSolicitudes.Enabled = true;
            btnQuitarSolicitud.Enabled = true;
            txtNumero.Text = oDatConsolidacionPedido.getIdSiguiente().ToString();
            txtNumero.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            btnConsultarPedido.Enabled=false;

            frmConsultaSolicitud.id_usuario = frmPrincipalCompras.id_usuario;
            frmConsultaSolicitud.id_empresa = frmPrincipalCompras.id_empresa;

        }

        public bool getValores()
        {
            if (txtNumero.Text == "" || txtNumero.Text == "0")
            {
                oCons_Pedido.Numero = 0;//PK
            }
            else
            {
                oCons_Pedido.Numero = Convert.ToInt32(txtNumero.Text);
            }
            if ((cmbEstado.SelectedItem == null) ||
                (cmbTipoArticulo.SelectedItem == null))
            {
                return false;
            }
            
            //llenando valores de cabecera de Pedido
            oCons_Pedido.idEmpresa = frmPrincipalCompras.id_empresa; ///esto nos tiene que dar seguridad
            oCons_Pedido.idUsuario = frmPrincipalCompras.id_usuario; ///esto nos tiene que dar seguridad                                                                                ///
            oCons_Pedido.idTipoArticulo = cmbTipoArticulo.SelectedIndex + 1;
            oCons_Pedido.idEstado = cmbEstado.SelectedIndex + 1;  //esto nos lo da seguridad

            // obteniendo los valores de un detalle
            // se crea una lista con los detalles ya que estos pueden ser uno o más
            int numero_linea =DatosPedidoDetalle.RowCount;
            int i = 0;
            while (i < numero_linea)
            {
                clsConsolidacionPedidoDet e = new clsConsolidacionPedidoDet();
                e.Numero = Convert.ToInt32(txtNumero.Text);
                e.Id_Empresa = frmPrincipalCompras.id_empresa;
                e.linea = Convert.ToInt32(DatosPedidoDetalle.GetRowCellDisplayText(i, DatosPedidoDetalle.Columns.ColumnByName("collinea")));
                e.Id_articulo = Convert.ToInt32(DatosPedidoDetalle.GetRowCellDisplayText(i, DatosPedidoDetalle.Columns.ColumnByName("colid_articulo")));
                e.cantidad = Convert.ToInt32(DatosPedidoDetalle.GetRowCellDisplayText(i, DatosPedidoDetalle.Columns.ColumnByName("colCantidad")));
                listaSolicitudDetNueva.Add(e);
                i++;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Este proceso se efectúa para guardar varios artículos de un detalle
            if (getValores())
            {
                if (btnConsultarPedido.Enabled.Equals(false))
                {
                    //guardo la cabecera y el detalle
                    if (oDatCons_Pedido.Guardar(oCons_Pedido) && oDatCons_Pedido.GuardarDet(listaSolicitudDetNueva))
                    {
                        consolidar();
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //modifico la cabecera y el detalle
                    if (oDatCons_Pedido.ModificarCabeceraPedido(oCons_Pedido) && oDatCons_Pedido.ModificarDetallePedido(listaSolicitudDetNueva))
                    {
                        MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        btnModificar.Enabled = false;
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }



        public void borrar()
        {
            clsSolicitud Solicitud = new clsSolicitud();
            txtNumero.Text = "";
            cmbTipoArticulo.SelectedItem=null;
            cmbEstado.SelectedItem= null;
            listaSolicitudDet.Clear();
            dtgPedidoDetalle.DataSource = null;

        }

        public void consolidar()
        {
            //Aqui se consolidan las solicitudes que se escogieron para que no vuelvan a aparecer en la lista
            datSolicitud oDatSolicitud = new datSolicitud();
            int j = 0;
            int cantidad = lista_Nueva.Count();
            while (j < cantidad)
            {
                int numero = lista_Nueva[j].Numero;
                if (oDatSolicitud.ModificarEstado(numero))
                {
                    MessageBox.Show("Se consolido Correctamente las solicitudes Seleccionadas", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                j++;
            }
        }


        public void OrdenarDetalle()
        {
            clsSolicitudDet osolicitud_det = new clsSolicitudDet();
            int filas = 0;
            filas = lista_Nueva.Count();
            int i = 0;
            while (i < filas)
            {
                int numero = lista_Nueva[i].Numero;
                int id_articulo = lista_Nueva[i].id_articulo;
                string nombre_articulo = lista_Nueva[i].Articulo;
                int cantidad = lista_Nueva[i].Cantidad;
                int id_empresa = lista_Nueva[i].Id_empresa;
                string nombre_empresa = lista_Nueva[i].Empresa;
                //realizo el ingreso del detalle a una tabla de manera ordenada
                lista_Ordenada.Add(new clsSolicitudDet(numero, i+1, id_articulo, nombre_articulo, cantidad, id_empresa, nombre_empresa));
                i++;
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNumero.Enabled = true;
            cmbEstado.Enabled = true;
            dtgPedidoDetalle.Enabled = true;
        }
    }
}
