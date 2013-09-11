using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.CuentasxCobrar;
using clases.CuentasxCobrar;

namespace forms.CuentasxCobrar
{
    public partial class frm_CajaApertura : Form
    {
        public clsAperturaCaja objAperturaCaja = new clsAperturaCaja();
        int idEmpresa = 1;
        //int idEmpresa = clsVwUsuarioInformacion.idEmpresa;
        int idUsuario = 11;
        //int idUsuario = clsVwUsuarioInformacion.idUsuario;
        int idEstado = 1;
        String AccionBotonAplastado;

        public frm_CajaApertura()
        {
            InitializeComponent();
        }

        private void frm_CajaApertura_Load(object sender, EventArgs e)
        {

            /*CARGANDO CODIGO*/
            clsDatosAperturaCaja objDatosAperturaCaja = new clsDatosAperturaCaja();
            txtCodigo.Text = Convert.ToString(objDatosAperturaCaja.getIdSiguiente());
            txtUsuario.Text = Convert.ToString(idUsuario);

            /*CARGANDO EL DATAGRID DESDE LA BASE*/
            clsDatosMonetarioDetalle objDatosMonetarioDetalle = new clsDatosMonetarioDetalle();
            dgvApertura.DataSource = objDatosMonetarioDetalle.consultaMonetarioDetalleGeneral();

            /* AGREGANDO LAS COLUMNAS CANTIDAD Y SUBTOTAL*/
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            DataGridViewColumn colCantidad = new DataGridViewColumn();
            colCantidad.CellTemplate = cell;
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "Cantidad";
            colCantidad.Visible = true;
            colCantidad.Width = 60;
            dgvApertura.Columns.Insert(5, colCantidad);

            DataGridViewColumn colSubtotal = new DataGridViewColumn();
            colSubtotal.CellTemplate = cell;
            colSubtotal.HeaderText = "Subtotal";
            colSubtotal.Name = "Subtotal";
            colSubtotal.Visible = true;
            colSubtotal.Width = 60;
            dgvApertura.Columns.Insert(6, colSubtotal);

            /*OCULTANDO COLUNMAS*/
            dgvApertura.Columns[0].Visible = false;
            dgvApertura.Columns[1].Visible = false;
            dgvApertura.Columns[3].Visible = false;

            /*AJUSTANDO ANCHO DE COLUMNAS*/
            /*dgvApertura.Columns[2].Width = 150;*/
            dgvApertura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            /*ESTABLECIENDO LAS CABECERAS*/
            dgvApertura.Columns[0].HeaderText = "ID Empresa";
            dgvApertura.Columns[1].HeaderText = "ID Detalle Monetario";
            dgvApertura.Columns[2].HeaderText = "Descripcion";
            dgvApertura.Columns[3].HeaderText = "Valor";
            dgvApertura.Columns[4].HeaderText = "Estado";
            dgvApertura.Columns[5].HeaderText = "Cantidad";
            dgvApertura.Columns[6].HeaderText = "Subtotal";

            /*OCULTANDO LAS DE ESTADO INACTIVO*/
            for (int i = 0; i < dgvApertura.Rows.Count; i++)
            {
                if (Convert.ToString(dgvApertura.Rows[i].Cells[4].Value) == "I")
                {
                    dgvApertura.Rows[i].Visible = false;
                }
            }

            dgvApertura.CellValueChanged += new DataGridViewCellEventHandler(dgvApertura_CellValueChanged);
        }

        private void btnAperturar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clsDatosAperturaCaja objDatosAperturaCaja = new clsDatosAperturaCaja();
            clsMensaje objMensaje = new clsMensaje();
            string msgMonto = "Confirma que este es el monto de apertura correcto: " + txtMonto.Text;
            DialogResult ResultadoDialogo = MessageBox.Show(msgMonto, objMensaje.Titulo, MessageBoxButtons.YesNo);

            if (ResultadoDialogo == DialogResult.Yes)
            {

                if (this.Get())
                {
                    if (objDatosAperturaCaja.guardar(objAperturaCaja))
                    {
                        for (int i = 0; i < dgvApertura.Rows.Count; i++)
                        {
                            if (Convert.ToString(dgvApertura.Rows[i].Cells[4].Value) == "A")
                            {
                                clsDatosAperturaDet objDatosAperturaDet = new clsDatosAperturaDet();
                                clsAperturaDet objAperturaDet = new clsAperturaDet();
                                objAperturaDet.idEmpresa = idEmpresa;
                                objAperturaDet.idUsuario = idUsuario;
                                objAperturaDet.idAperturaCaja = objAperturaCaja.idAperturaCaja;
                                objAperturaDet.Denominacion = Convert.ToInt32(dgvApertura.Rows[i].Cells[1].Value);
                                objAperturaDet.Cantidad = Convert.ToInt32(dgvApertura.Rows[i].Cells[5].Value);
                                objAperturaDet.idEstado = idEstado;
                                objDatosAperturaDet.guardar(objAperturaDet);

                            }
                        }

                        MessageBox.Show(objMensaje.Guardar_ok, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show(objMensaje.Guardar_error, objMensaje.Titulo, MessageBoxButtons.OK);
                    }
                }
            }
            AccionBotonAplastado = "G";
        }

        public Boolean Get()
        {
            clsMensaje objMensaje = new clsMensaje();
            try
            {
                objAperturaCaja.idEmpresa = idEmpresa;
                objAperturaCaja.idUsuario = idUsuario;
                objAperturaCaja.idAperturaCaja = Convert.ToInt32(this.txtCodigo.Text);
                objAperturaCaja.Fecha = dtpFecha.Value;
                objAperturaCaja.FechaModificacion = dtpFecha.Value;
                objAperturaCaja.Monto = Convert.ToDecimal(this.txtMonto.Text);
                objAperturaCaja.idEstado = idEstado;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show(objMensaje.Valor_invalido, objMensaje.Titulo, MessageBoxButtons.OK);
                return false;
                throw;
            }

        }

        private void dgvApertura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculoSubtotal(dgvApertura.CurrentRow.Index);
            CalculoMonto();
        }

        public void CalculoSubtotal(int y)
        {
            decimal Subtotal = Convert.ToDecimal(dgvApertura.Rows[y].Cells[3].Value) * Convert.ToDecimal(dgvApertura.Rows[y].Cells[5].Value);
            dgvApertura.Rows[y].Cells[6].Value = Subtotal;
        }

        public void CalculoMonto()
        {
            decimal Monto = dgvApertura.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[6].Value));

            //mostramos la suma en el textbox y en la fila que agregamos 
            txtMonto.Text = Convert.ToString(Monto);
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AccionBotonAplastado = "S";
            this.Close();
        }
    }
}
