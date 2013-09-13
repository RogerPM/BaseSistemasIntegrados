using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class clsCuentaPorPagarDAT
    {
        CuentaPorPagar CtaXPag;
        ImpuestoCuenta ImpCta;
        DeudaDet DeuDet;
        FrecuenciaPago Frecuencia;


        public int getSiguienteCtaPorPagar()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.CuentaPorPagar select a.NumCuentaPorPagar).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }



        public List<clsFrecuencia> ConsultaFrecuencia()
        {

            try
            {
                List<clsFrecuencia> lista = new List<clsFrecuencia>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.FrecuenciaPago select w;
                foreach (var item in con)
                {
                    clsFrecuencia clas = new clsFrecuencia();
                    clas._IdFrecuenciaPago = item.IdFrecuenciaPago;
                    clas._Descripcion = item.Descripcion;
                    clas._FechaActual = item.FechaActual;
                    clas._Estado = item.Estado;
                    clas._IdUsuario = item.IdUsuario;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }


        public List<clsCuentaPorPagar> consulta()
        {

            try
            {
                List<clsCuentaPorPagar> lista = new List<clsCuentaPorPagar>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaPorPagar select w;
                foreach (var item in con)
                {
                    clsCuentaPorPagar clas = new clsCuentaPorPagar();
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._NumIngresoEgreso = Convert.ToInt32(item.NumIngresoEgreso);
                    clas._FechaIngreso = item.FechaIngreso;
                    clas._Factura = item.NumeroFactura;
                    clas._FechaTransaccion = item.FechaTransaccion;
                    clas._IdProveedor = Convert.ToInt32(item.IdProveedor);
                    clas._IdEmpresaServicio = item.IdEmpresaServicio;
                    clas._Motivo = item.Motivo;
                    clas._Detalle = item.Detalle;
                    clas._Subtotal = item.Subtotal;
                    clas._Descuento = item.Descuento;
                    clas._Total = item.Total;
                    clas._FormaPago = item.FormaPago;
                    clas._ValorEntrada = Convert.ToDecimal(item.ValorEntrada);
                    clas._NumeroLetra = Convert.ToInt32(item.NumeroLetra);
                    clas._IdFrecuencia = Convert.ToInt32(item.IdFrecuencia);
                    clas._ValorLetra = Convert.ToDecimal(item.ValorLetra);
                    clas._SaldoDeuda = Convert.ToDecimal(item.SaldoDeuda);
                    clas._IdUsuario = item.IdUsuario;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }


        public List<clsCuentaPorPagarDetalle> consultaDetalle()
        {

            try
            {
                List<clsCuentaPorPagarDetalle> lista = new List<clsCuentaPorPagarDetalle>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.DeudaDet select w;
                foreach (var item in con)
                {
                    clsCuentaPorPagarDetalle clas = new clsCuentaPorPagarDetalle();
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._NumCuentaPorPagarDetalle = Convert.ToInt32(item.NumDetalleDeuda);
                    clas._ValorLetra = Convert.ToDecimal(item.ValorLetra);
                    clas._FechaVencimiento = item.FechaVencimiento;
                    clas._Estado = item.Estado;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }


        public Boolean Guardar(clsCuentaPorPagar CuentaPorPagar)
        {
            return true;
        }



        public void Modificar(clsCuentaPorPagar CuentaPorPagar)
        {

        }



        public void Eliminar(clsCuentaPorPagar CuentaPorPagar)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.CuentaPorPagar where q.NumCuentaPorPagar == (CuentaPorPagar._NumCuentaPorPagar) select q).First();
                ent.DeleteObject(x);
                ent.SaveChanges();
            }
        }


        //=========================================================================================================================
        //============================================CONSULTA EMPRESA DE FRECUENCIA===============================================
        //=========================================================================================================================

        
    }
}
