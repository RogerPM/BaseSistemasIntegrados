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
    public partial class frmSolicitud : Form
    {
        clsMensajesCompras msj = new clsMensajesCompras();
        public List<clsSolicitudDet> listaSolicitudDet = new List<clsSolicitudDet>();
        public List<clsSolicitud_DetT> listaSolicitudDetNueva = new List<clsSolicitud_DetT>();
        clsSolicitud oSolicitud = new clsSolicitud();
        clsSolicitud_DetT oSolicitudDet = new clsSolicitud_DetT();
        datSolicitud odatSolicitud = new datSolicitud();
        public static int anterior = 0;

        public frmSolicitud()
        {
            InitializeComponent();
        }

        private void frmSolicitud_Load(object sender, EventArgs e)
        {
            datSolicitud oDatSolicitud = new datSolicitud();
            lblFecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            listaSolicitudDet = oDatSolicitud.Detalle_Solicitud(frmConsultaSolicitud.numero, frmConsultaSolicitud.id_empresa);
            habilitar(false);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            frmConsultaSolicitud f = new frmConsultaSolicitud();
            f.ShowDialog();

            datSolicitud oSolicitud = new datSolicitud();
            txtnumero.Text = frmConsultaSolicitud.numero.ToString();
            cmbDepartamento.SelectedIndex = frmConsultaSolicitud.departamento - 1;
            cmbTipoArticulo.SelectedIndex = frmConsultaSolicitud.tipo_articulo - 1;
            cmbEstado.SelectedIndex = frmConsultaSolicitud.estado - 1;

            listaSolicitudDet = oSolicitud.Detalle_Solicitud(frmConsultaSolicitud.numero, frmConsultaSolicitud.id_empresa);
            dtgDetalle.DataSource = oSolicitud.Detalle_Solicitud(frmConsultaSolicitud.numero,frmConsultaSolicitud.id_empresa);
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            cmbTipoArticulo.Enabled = false;
            frmConsultaArticulo f = new frmConsultaArticulo();
            frmConsultaArticulo.id_tipo_articulo = Convert.ToInt32(cmbTipoArticulo.SelectedIndex + 1);
            f.ShowDialog();

            //se llena el detalle con el articulo seleccionado
            //se cuenta la cantidad de líneas que hay en el griedview, se le aumenta en uno y se asigna el numero de línea
            int numero_linea = Detalle_datos.RowCount;
            listaSolicitudDet.Add(new clsSolicitudDet(frmConsultaSolicitud.numero, (numero_linea+1), frmConsultaArticulo.id_articulo, frmConsultaArticulo.nombre_articulo, 0, frmConsultaArticulo.id_empresa, frmConsultaArticulo.nombre_empresa));
            dtgDetalle.DataSource = listaSolicitudDet;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            //Este proceso se efectúa para guardar varios artículos de un detalle
            if (getValores())
            {
                if (btnBuscar.Enabled.Equals(false))
                {
                    //guardo la cabecera y el detalle
                    if (odatSolicitud.Guardar(oSolicitud) && odatSolicitud.GuardarDet(listaSolicitudDetNueva))
                    {
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        habilitar(false);
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
                    if (odatSolicitud.ModificarCabecera(oSolicitud) && odatSolicitud.ModificarDetalle(listaSolicitudDetNueva,anterior))
                    {
                        MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        btnModificar.Enabled = false;
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            habilitar(false);
        }

        public void habilitar(bool valor)
        {
            txtnumero.Enabled = valor;
            cmbDepartamento.Enabled = valor;
            cmbEstado.Enabled = valor;
            cmbTipoArticulo.Enabled = valor;
            btnAgregarArticulo.Enabled = valor;
            btnEliminarArticulos.Enabled = valor;
            dtgDetalle.Enabled = valor;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            txtnumero.Enabled = false;
            cmbTipoArticulo.Enabled = false;
            anterior = listaSolicitudDet.Count();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            datSolicitud o_datSolicitud = new datSolicitud();
            borrar();
            habilitar(true);
            //Se busca el último numero de la solicitud y se lo presenta
            int numero = o_datSolicitud.getIdSiguiente();
            txtnumero.Text = numero.ToString();
            //se bloquea el textbox para que no se pueda modificar
            txtnumero.Enabled = false;
            btnBuscar.Enabled = false;
            cmbEstado.SelectedIndex = 0;
            cmbEstado.Enabled = false;
            frmConsultaSolicitud.id_usuario = frmPrincipalCompras.id_usuario;
            frmConsultaSolicitud.id_empresa = frmPrincipalCompras.id_empresa;
        }


        public void borrar()
        {
            clsSolicitud Solicitud = new clsSolicitud();
            txtnumero.Text = "";
            cmbTipoArticulo.SelectedItem=null;
            cmbEstado.SelectedItem= null;
            cmbTipoArticulo.SelectedItem=null;
            listaSolicitudDet.Clear();
            dtgDetalle.DataSource = null;

        }

        public bool getValores()
        {
            if (txtnumero.Text == "" || txtnumero.Text == "0")
            {
               oSolicitud.Numero = 0;//PK
            }
            else
            {
                oSolicitud.Numero= Convert.ToInt32(txtnumero.Text);
            }
            if ((cmbDepartamento.SelectedItem == null) ||
                (cmbEstado.SelectedItem == null) ||
                (cmbTipoArticulo.SelectedItem == null))
            {
                return false;
            }

            //llenando valores de cabecera
            oSolicitud.Id_Empresa = frmConsultaSolicitud.id_empresa; ///esto nos tiene que dar seguridad
            oSolicitud.Id_Tipo_Articulo = cmbTipoArticulo.SelectedIndex +1;
            oSolicitud.Id_Usuario = frmConsultaSolicitud.id_usuario;  //esto nos lo da seguridad
            oSolicitud.Id_Departamento = cmbDepartamento.SelectedIndex + 1;
            oSolicitud.Id_Estado = cmbEstado.SelectedIndex + 1;

            //llenando valores de los detalles de la solicitud
            //int numero = Convert.ToInt32(txtnumero.Text);
            //int id_empresa = oSolicitud.Id_Empresa;
            //int linea = Convert.ToInt32(Detalle_datos.GetFocusedRowCellValue(collinea));
            //int id_articulo = Convert.ToInt32(Detalle_datos.GetFocusedRowCellValue(colid_articulo));
            //int cantidad = Convert.ToInt32(Detalle_datos.GetFocusedRowCellValue(colCantidad));
            //int linea = Convert.ToInt32(Detalle_datos.GetRowCellDisplayText(0, Detalle_datos.Columns.ColumnByName("colCantidad")));
            //int linea2 = Convert.ToInt32(Detalle_datos.GetRowCellDisplayText(1, Detalle_datos.Columns.ColumnByName("colCantidad")));

            // obteniendo los valores de un detalle
            // se crea una lista con los detalles ya que estos pueden ser uno o más
            int numero_linea = Detalle_datos.RowCount;
            int i = 0;
            while (i < numero_linea)
            {
                clsSolicitud_DetT e = new clsSolicitud_DetT();
                e.Numero = Convert.ToInt32(txtnumero.Text);
                e.Id_Empresa = oSolicitud.Id_Empresa;
                e.linea = Convert.ToInt32(Detalle_datos.GetRowCellDisplayText(i, Detalle_datos.Columns.ColumnByName("collinea")));
                e.Id_articulo = Convert.ToInt32(Detalle_datos.GetRowCellDisplayText(i, Detalle_datos.Columns.ColumnByName("colid_articulo")));
                e.cantidad = Convert.ToInt32(Detalle_datos.GetRowCellDisplayText(i, Detalle_datos.Columns.ColumnByName("colCantidad")));
                listaSolicitudDetNueva.Add(e);
                i++;
            }         
            return true;
        }

        private void btnEliminarArticulos_Click(object sender, EventArgs e)
        {
            //al momento de eliminar se debe capturar el id de la cabecera a la que pertenece 
            //y el numero de la linea para la eliminación de la base.

            int numero = Convert.ToInt16(txtnumero.Text);
            int linea = Convert.ToInt16(Detalle_datos.GetFocusedRowCellValue(collinea));
            Detalle_datos.DeleteSelectedRows();
        }

        private void dtgDetalle_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

    }
}
