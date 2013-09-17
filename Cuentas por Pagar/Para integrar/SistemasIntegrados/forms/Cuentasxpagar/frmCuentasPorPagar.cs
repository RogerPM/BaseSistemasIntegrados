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
using System.Text.RegularExpressions;

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
        decimal Impuesto1, Impuesto2;


        clsCuentaPorPagar CuentaPorPagar = new clsCuentaPorPagar();
        
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
            txtNroCtaPag.Text = Convert.ToString(CtaPorPag.getSiguienteCtaPorPagar());
            //cbxNroOrdenCompra = null;
            dtpFechaIngreso.EditValue = DateTime.Today;
            txtNroFactura.Text = "";
            dtpFechaTransaccion.EditValue = DateTime.Today;
            txtRucProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtMotivo.Text = "";
            txtDetalle.Text = "";
            txtSubTotal.Text = "";
            txtDescuento.Text = "";
            //cbxImpuesto1 = null;
            //cbxImpuesto2 = null;
            txtTotal.Text = "";
            rdbFormaPago.SelectedIndex = 0;
            txtValorEntrada.Text = "";
            txtDeuda.Text = "";
            txtNroLetras.Text = "";
            //cbxFrecuencia = null;
            txtValorCadaLetra.Text = "";
        }



        private void CalcularTotal()
        {
            decimal a, b, f, var1, var2;
            int nat1 = 1, nat2 = 1;

            tmp1 = Convert.ToInt32(cbxImpuesto1.EditValue);
            tmp2 = Convert.ToInt32(cbxImpuesto2.EditValue);
            var1 = impuestos[tmp1 - 1].Porcentaje;
            var2 = impuestos[tmp2 - 1].Porcentaje;

            if (impuestos[tmp1 - 1].naturAcree == 1)
            {
                nat1 = (-1);
            }

            if (impuestos[tmp2 - 1].naturAcree == 1)
            {
                nat2 = (-1);
            }

            a = Convert.ToDecimal(txtSubTotal.Text);
            if (txtDescuento.Text != "")
                b = Convert.ToDecimal(txtDescuento.Text);
            else
                b = 0;
            Impuesto1 = ((a - b) * (var1 / 100)) * nat1;
            Impuesto2 = ((a - b) * (var2 / 100)) * nat2;

            f = (a - b) + Impuesto1 + Impuesto2;
            txtTotal.Text = Convert.ToString(Math.Round(f, 2));
        }



        private void CalcularDetalle()
        {
            decimal x, y;
            x = Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtValorEntrada.Text);
            y = x / Convert.ToInt32(txtNroLetras.Text);
            txtDeuda.Text = Convert.ToString(x);
            txtValorCadaLetra.Text = Convert.ToString(Math.Round(y, 2));
        }



        public void get()
        {
            if (error == 0)
            {
                CalcularTotal();
                if (rdbFormaPago.SelectedIndex == 1 && txtValorEntrada.Text != "" && txtNroLetras.Text != "")
                {
                    CalcularDetalle();
                }

                CuentaPorPagar._IdEmpresa = 1;
                CuentaPorPagar._IdUsuario = 11;
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
                if (!(string.IsNullOrEmpty(txtDescuento.Text)))
                    CuentaPorPagar._Descuento = Convert.ToDecimal(txtDescuento.Text);
                else
                {
                    Mensaje(3, msj, elemento);
                }
                List<clsImpuestoCuenta> impuList = new List<clsImpuestoCuenta>();
                for (int i = 0; i < 2; i++)
                {
                    clsImpuestoCuenta objImp = new clsImpuestoCuenta();
                    objImp._IdEmpresa = CuentaPorPagar._IdEmpresa;
                    objImp._NumCuentaPorPagar = Convert.ToInt32(txtNroCtaPag.Text);
                    if (i == 0 && !(String.IsNullOrEmpty(cbxImpuesto1.Text)))
                    {
                        objImp._IdImpuesto = Convert.ToInt32(cbxImpuesto1.EditValue);
                        objImp._Valor = Impuesto1;
                        impuList.Add(objImp);
                    }
                    else if (i == 1 && !(String.IsNullOrEmpty(cbxImpuesto2.Text)))
                    {
                        objImp._Valor = Impuesto2;
                        objImp._IdImpuesto = Convert.ToInt32(cbxImpuesto2.EditValue);
                        impuList.Add(objImp);
                    }
                }
                CuentaPorPagar._ImpuestoCuenta = impuList;
                CuentaPorPagar._Total = Convert.ToDecimal(txtTotal.Text);
                CuentaPorPagar._FormaPago = Convert.ToString(rdbFormaPago.SelectedIndex);
                if (CuentaPorPagar._FormaPago == Convert.ToString('1'))
                {
                    if (!(string.IsNullOrEmpty(txtValorEntrada.Text)))
                        CuentaPorPagar._ValorEntrada = Convert.ToDecimal(txtValorEntrada.Text);
                    else
                    {
                        error = 3;
                        elemento = "Valor de entrada";
                        Mensaje(error, msj, elemento);
                    }

                    if(!(string.IsNullOrEmpty(txtNroLetras.Text)))
                        CuentaPorPagar._NumeroLetra = Convert.ToInt32(txtNroLetras.Text);
                    else
                    {
                        error = 3;
                        elemento = "Número de letras";
                        Mensaje(error, msj, elemento);
                    }

                    int tmp;
                    if (cbxFrecuencia.EditValue!=null)
                    {
                        tmp = Convert.ToInt32(cbxFrecuencia.EditValue);
                        CuentaPorPagar._IdFrecuencia = tmp;
                        CuentaPorPagar._DetCredito = GenerarDetallePagos(tmp);
                    }
                    else
                    {
                        tmp = -1;
                        error = 3;
                        elemento = "Frecuencia de pagos";
                        Mensaje(error, msj, elemento);
                    }

                    if(!(string.IsNullOrEmpty(txtValorCadaLetra.Text)))
                        CuentaPorPagar._ValorLetra = Convert.ToDecimal(txtValorCadaLetra.Text);
                    else
                    {
                        error = 3;
                        elemento = "Valor de cada letra";
                        Mensaje(error, msj, elemento);
                    }
                }
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


        private List<clsCuentaPorPagarDetalle> GenerarDetallePagos(int tmp)
        {
            List<clsCuentaPorPagarDetalle> detalleDeuda = new List<clsCuentaPorPagarDetalle>();
            DateTime fechita = Convert.ToDateTime(dtpFechaTransaccion.EditValue);
            for (int i = 0; i < Convert.ToInt32(txtNroLetras.Text); i++)
            {
                clsCuentaPorPagarDetalle pago = new clsCuentaPorPagarDetalle();
                pago._IdEmpresa = 1;
                pago._NumCuentaPorPagar = Convert.ToInt32(txtNroCtaPag.Text);
                pago._NumCuentaPorPagarDetalle = i+1;
                pago._ValorLetra = Convert.ToDecimal(txtValorCadaLetra.Text);
                switch (tmp)
                {
                    case 1:
                        fechita = fechita.AddDays(1);
                        break;
                    case 2:
                        fechita = fechita.AddDays(7);
                        break;
                    case 3:
                        fechita = fechita.AddMonths(1);
                        break;
                    case 4:
                        fechita = fechita.AddMonths(6);
                        break;
                    case 5:
                        fechita = fechita.AddYears(1);
                        break;
                }
                pago._FechaVencimiento = fechita;
                pago._Estado = 1;
                detalleDeuda.Add(pago);
            }
            return detalleDeuda;
        }

        //====================================================================================================================================================
        //==============================================================PROGRAMACION DE CONTROLES=============================================================
        //====================================================================================================================================================

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            identificador = 1;
            if (cbxNroOrdenCompra.Enabled == true)
            {
                cbxNroOrdenCompra.Enabled = false;
            }
            Limpiar();
            gpbDocumento.Enabled = true;
            gpbDetValores.Enabled = true;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            get();
            if (CtaPorPag.Guardar0(CuentaPorPagar))
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
                Limpiar();
               // cbxNroOrdenCompra.Enabled = true;
                gpbDocumento.Enabled = false;
                gpbDetValores.Enabled = false;
                btnCalcularTotales.Enabled = false;
            }
        }

        private void tsbConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaCuentaPorPagar fr = new frmConsultaCuentaPorPagar();
            fr.ShowDialog();

            CuentaPorPagar = fr.ctaxpag;

            txtNroCtaPag.Text = Convert.ToString(CuentaPorPagar._NumCuentaPorPagar);
            dtpFechaIngreso.EditValue = CuentaPorPagar._FechaIngreso;
            txtNroFactura.Text = Convert.ToString(CuentaPorPagar._Factura);
            dtpFechaTransaccion.EditValue = CuentaPorPagar._FechaTransaccion;
            txtRucProveedor.Text = Convert.ToString(CuentaPorPagar._IdEmpresaServicio);
            txtMotivo.Text = CuentaPorPagar._Motivo;
            txtDetalle.Text = CuentaPorPagar._Detalle;

            //txtSubTotal.Text = Convert.ToString(CuentaPorPagar._Subtotal);
            //txtDescuento.Text = Convert.ToString(CuentaPorPagar._Descuento);
            //for (int i = 0; i < 2; i++)
            //{
            //    if (i == 0)
            //    {
            //        int a = CuentaPorPagar._ImpuestoCuenta[i]._IdImpuesto;
            //        cbxImpuesto1.EditValue = a;
            //    }
            //    else
            //    {
            //        cbxImpuesto2.EditValue = CuentaPorPagar._ImpuestoCuenta[i]._IdImpuesto;
            //    }
            //}

            txtTotal.Text = Convert.ToString(CuentaPorPagar._Total);

            if (CuentaPorPagar._FormaPago == Convert.ToString(1))
            {
                rdbFormaPago.EditValue = 1;
                txtValorEntrada.Text = Convert.ToString(CuentaPorPagar._ValorEntrada);
                txtDeuda.Text = Convert.ToString(CuentaPorPagar._SaldoDeuda);
                txtNroLetras.Text = Convert.ToString(CuentaPorPagar._NumeroLetra);
                txtValorCadaLetra.Text = Convert.ToString(CuentaPorPagar._ValorLetra);
            }
            else
            {
                rdbFormaPago.EditValue = 0;
            }
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
            cbxImpuesto2.Enabled = true;
            btnCalcularTotales.Enabled = true;
            tsbGuardar.Enabled = true;
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


            
        private void btnGenerarPagos_Click(object sender, EventArgs e)
        {
            tmp1 = Convert.ToInt32(cbxFrecuencia.EditValue);
            frmDetalleCuentasPorPagar detCtasxPag = new frmDetalleCuentasPorPagar(GenerarDetallePagos(tmp1));
            detCtasxPag.ShowDialog();
        }



        private void btnCalcularTotales_Click(object sender, EventArgs e)
        {
            CalcularTotal();
            if (rdbFormaPago.SelectedIndex == 1 && txtValorEntrada.Text != "" && txtNroLetras.Text != "")
            {
                CalcularDetalle();
            }
        }
    }
}
