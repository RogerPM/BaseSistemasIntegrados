using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Cuentasxpagar;
using datos.Cuentasxpagar;

namespace forms.Cuentasxpagar
{
    public partial class frmCuentasPorPagar : Form
    {
        //============================================================================================================================================================
        //===========================================================DECLARACION DE VARIABLES Y OBJETOS===============================================================
        //============================================================================================================================================================
        
        int error = 0, identificador = 0; // parametro para buscar mensaje; diferenciar entre empresa de servicio y proveedores de mercadería
        string msj = "", elemento = "Éxito"; //variables de datos a presentar en mensajes
        int tmp1 = 0, tmp2 = 0;
        string var1, var2;


        clsCuentaPorPagar CuentaPorPagar = new clsCuentaPorPagar();
        List<clsCuentaPorPagarDetalle> detalleDeuda = new List<clsCuentaPorPagarDetalle>();
        List<clsImpuestos> impuestos = new List<clsImpuestos>();


        clsCuentaPorPagarDAT CtaPorPag = new clsCuentaPorPagarDAT();
        datosImpuestos imp = new datosImpuestos();

        //============================================================================================================================================================
        //============================================================================================================================================================
        //============================================================================================================================================================

        public frmCuentasPorPagar()
        {
            InitializeComponent();
        }


        private void frmCuentasPorPagar_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.EditValue = DateTime.Today;
            identificador = 0;
            cbxImpuesto1.Properties.DataSource = imp.consulta();
            cbxImpuesto2.Properties.DataSource = imp.consulta();
            impuestos = imp.consulta();
            cbxFrecuencia.Properties.DataSource = CtaPorPag.ConsultaFrecuencia();
            txtNroCtaPag.Text = Convert.ToString(CtaPorPag.getSiguienteCtaPorPagar());

        }

        //====================================================================================================================================================
        //=========================================================DECLARACION DE MÉTODOS Y FUNCIONES=========================================================
        //====================================================================================================================================================
        
        private void Limpiar()
        {
            txtNroCtaPag.Text = null;
            cbxNroOrdenCompra = null;
            dtpFechaIngreso.EditValue = DateTime.Today;
            txtNroFactura.Text = null;
            dtpFechaTransaccion.EditValue = null;
            txtRucProveedor.Text = null;
            txtNombreProveedor.Text = null;
            txtMotivo.Text = null;
            txtDetalle.Text = null;
            txtSubTotal.Text = null;
            txtDescuento.Text = null;
            txtTotal.Text = null;
            rdbFormaPago.SelectedIndex = 1;
            txtValorEntrada.Text = null;
            txtDeuda.Text = null;
            txtNroLetras.Text = null;
            txtValorCadaLetra.Text = null;
        }



        int validaciones(int nroCtaPag, int nroOrdenCompra, DateTime fechaIngreso, int nroFactura, DateTime fechaTransaccion, string rucProveedor, string motivo,
            string detalle, decimal subTotal, decimal descuento, int impuesto1, int impuesto2, decimal total, decimal valorEntrada, decimal deuda,
            int nroLetras, double valorCadaLetra)
        {
            

            return error;
        }



        public void get()
        {
            if (error == 0)
            {
                CuentaPorPagar._NumCuentaPorPagar = Convert.ToInt32(txtNroCtaPag.Text);
                CuentaPorPagar._FechaIngreso = dtpFechaIngreso.DateTime;
                CuentaPorPagar._Factura = txtNroFactura.Text;
                CuentaPorPagar._FechaTransaccion = dtpFechaTransaccion.DateTime;
                if (identificador == 0)
                {
                    CuentaPorPagar._NumIngresoEgreso = Convert.ToInt32(cbxNroOrdenCompra.SelectedText);
                    CuentaPorPagar._IdProveedor = Convert.ToInt32(txtRucProveedor.Text);
                }
                else
                {
                    CuentaPorPagar._IdEmpresaServicio = txtRucProveedor.Text;
                }
                CuentaPorPagar._Motivo = txtMotivo.Text;
                CuentaPorPagar._Detalle = txtDetalle.Text;
                CuentaPorPagar._Subtotal = Convert.ToDecimal(txtSubTotal.Text);
                CuentaPorPagar._Descuento = Convert.ToDecimal(txtDescuento.Text);
                
            }
            else
            {
                error = 1;
                msj = "Error";
                Mensaje(error, msj, elemento);
            }
        }


        void Mensaje(int error, string msj, string elemento)
        {
            clsMsgCuentasPorPagar Mensaje = new clsMsgCuentasPorPagar();
            MessageBox.Show(Mensaje.mensajes(ref error, msj), elemento, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void GenerarDetallePagos()
        {
            DateTime fechita = Convert.ToDateTime(dtpFechaTransaccion.EditValue);
            for (int i = 0; i < Convert.ToInt32(txtNroLetras.Text); i++)
            {
                clsCuentaPorPagarDetalle pago = new clsCuentaPorPagarDetalle();
                pago._IdEmpresa = 1;
                pago._NumCuentaPorPagar = Convert.ToInt32(txtNroCtaPag.Text);
                pago._NumCuentaPorPagarDetalle = i+1;
                pago._ValorLetra = Convert.ToDecimal(txtValorCadaLetra.Text);
                fechita.AddMonths(1);
                pago._FechaVencimiento = fechita.AddMonths(1);
                pago._Estado = 1;
                detalleDeuda.Add(pago);
            }
            //return detalleDeuda;
        }

        //====================================================================================================================================================
        //==============================================================PROGRAMACION DE CONTROLES=============================================================
        //====================================================================================================================================================

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            identificador = 1;
            cbxNroOrdenCompra.Enabled = false;
            gpbDocumento.Enabled = true;
            gpbDetValores.Enabled = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            get();
            if (CtaPorPag.Guardar(CuentaPorPagar))
            {
                Mensaje(error, msj, elemento);
                Limpiar();
            }
            else
            {
                error = 1;
                msj = "Error";
                Mensaje(error, msj, elemento);
            }
            if (identificador == 1)
            {
                identificador = 0;
                cbxNroOrdenCompra.Enabled = false;
                gpbDocumento.Enabled = false;
                gpbDetValores.Enabled = false;
            }
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {

        }

        private void tsbModificar_Click(object sender, EventArgs e)
        {

        }

        private void tsbAnular_Click(object sender, EventArgs e)
        {

        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            clsEmpresaServicio clas = new clsEmpresaServicio();
            frmConsultas fre = new frmConsultas();
            fre.ShowDialog();
            clas = fre.GetSelection();
            txtRucProveedor.Text = clas._IdEmpresaServicio;
            txtNombreProveedor.Text = clas._RazonSocial;
        }



        private void txtSubTotal_EditValueChanged(object sender, EventArgs e)
        {
            txtTotal.Text = txtSubTotal.Text;
            txtDescuento.Enabled = true;
            cbxImpuesto1.Enabled = true;
        }

        decimal local;

        private void cbxImpuesto1_EditValueChanged(object sender, EventArgs e)
        {
            tmp1 = Convert.ToInt32(cbxImpuesto1.EditValue);
            var1 = Convert.ToString(sluImpuesto1.GetFocusedRowCellValue(colDescripcion));
            decimal var, a, b, c;
            var = impuestos[tmp1-1].Porcentaje;
            a = Convert.ToDecimal(txtSubTotal.Text);
            if(txtDescuento.Text != "")
                b = Convert.ToDecimal(txtDescuento.Text);
            else
                b=0;
            c = (a-b)*(var/100);
            txtImpuesto1.Text = Convert.ToString(Math.Round(c));
            cbxImpuesto2.Enabled = true;
        }

        private void cbxImpuesto2_EditValueChanged(object sender, EventArgs e)
        {
            tmp2 = Convert.ToInt32(cbxImpuesto2.EditValue);
            var2 = Convert.ToString(sluImpuesto2.GetFocusedRowCellValue(colDescripcion1));
            if (tmp1 == tmp2)
            {
                MessageBox.Show("Error, no se puede repetir impuesto", "Impuesto sobreasignado");
            }
            else
            {
                decimal var, a, b, c;
                var = impuestos[tmp2 - 1].Porcentaje;
                a = Convert.ToDecimal(txtSubTotal.Text);
                if (txtDescuento.Text != "")
                    b = Convert.ToDecimal(txtDescuento.Text);
                else
                    b = 0;
                c = (a - b) * (var / 100);
                txtImpuesto2.Text = Convert.ToString(Math.Round(c));
            }
        }


        private void txtImpuesto1_EditValueChanged(object sender, EventArgs e)
        {
            decimal a, b, c, d, f;
            a = Convert.ToDecimal(txtSubTotal.Text);
            if (!(string.IsNullOrWhiteSpace(txtDescuento.Text)))
                b = Convert.ToDecimal(txtDescuento.Text);
            else
                b = 0;
            c = Convert.ToDecimal(txtImpuesto1.Text);
            f = a - (b + c);
            txtTotal.Text = Convert.ToString(Math.Round(f));
        }
        

        private void txtImpuesto2_EditValueChanged(object sender, EventArgs e)
        {
            decimal a, b, c, d, f;
            a = Convert.ToDecimal(txtSubTotal.Text);
            if (!(string.IsNullOrWhiteSpace(txtDescuento.Text)))
                b = Convert.ToDecimal(txtDescuento.Text);
            else
                b = 0;
            c = Convert.ToDecimal(txtImpuesto1.Text);
            d = Convert.ToDecimal(txtImpuesto2.Text);
            f = a - (b + c + d);
            txtTotal.Text = Convert.ToString(Math.Round(f));
        }



        private void rdbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbFormaPago.SelectedIndex == 1)
            {
                gpbDetCredito.Enabled = true;
                btnGenerarPagos.Enabled = true;
            }
            else
            {
                gpbDetCredito.Enabled = false;
                txtValorEntrada.Text = "";
                cbxFrecuencia.Text = "";
                txtDeuda.Text = "";
                txtNroLetras.Text = "";
                txtValorCadaLetra.Text = "";
                btnGenerarPagos.Enabled = false;
            }
        }



        

        private void txtValorEntrada_EditValueChanged(object sender, EventArgs e)
        {
            if(txtValorEntrada.Text != "" & txtTotal.Text != "")
            {
                decimal tmp = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtValorEntrada.Text);
                txtDeuda.Text = Convert.ToString(Math.Round(tmp, 2));
            }
        }

        

        private void txtNroLetras_EditValueChanged(object sender, EventArgs e)
        {
            if (txtDeuda.Text != "" & txtNroLetras.Text != "")
            {
                decimal tmp = Convert.ToDecimal(txtDeuda.Text) / Convert.ToInt32(txtNroLetras.Text);
                txtValorCadaLetra.Text = Convert.ToString(Math.Round(tmp, 2));
            }
        }

        private void btnGenerarPagos_Click(object sender, EventArgs e)
        {
            GenerarDetallePagos();
            frmDetalleCuentasPorPagar detCtasxPag = new frmDetalleCuentasPorPagar(detalleDeuda);
            detCtasxPag.ShowDialog();
        }


        

        
    }
}
