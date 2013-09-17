using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;
using clases.RecursosHumanos;

namespace datos.Cuentasxpagar
{
    public class datosPagoDetalle
    {
        public List<clsPagoDetalle> consulta()
        {

            try
            {
                List<clsPagoDetalle> lista = new List<clsPagoDetalle>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.PagoDet select w;
                foreach (var item in con)
                {
                    clsPagoDetalle clas = new clsPagoDetalle();
                    clas.NumLinea = item.NumLinea;
                    clas.IdMedioPago = item.IdMedioPago;
                    clas.Monto = (item.Monto);
                    clas.NumeroCuenta = item.NumeroCuenta;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdBanco = item.IdBanco;
                    clas.NumComprobante = item.NumComprobante;
                    // clas.NumComision =Convert.ToInt32 ( item.NumComision);
                    // clas.NumNominaCab =Convert.ToInt32 ( item.NumNominaCab);
                    clas.NumPago = item.NumPago;

                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
        public List<clsPagoDetalle> consultaNumPago(int NumPago)
        {

            try
            {
                List<clsPagoDetalle> lista = new List<clsPagoDetalle>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.PagoDet where w.NumPago == NumPago select w;
                foreach (var item in con)
                {
                    clsPagoDetalle clas = new clsPagoDetalle();
                    clas.NumLinea = item.NumLinea;
                    clas.IdMedioPago = item.IdMedioPago;
                    clas.Monto = (item.Monto);
                    clas.NumeroCuenta = item.NumeroCuenta;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdBanco = item.IdBanco;
                    clas.NumComprobante = item.NumComprobante;
                    // clas.NumComision =Convert.ToInt32 ( item.NumComision);
                    // clas.NumNominaCab =Convert.ToInt32 ( item.NumNominaCab);
                    clas.NumPago = item.NumPago;

                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
        public List<clsPagoDetalleDos> consultaNumPagoDos(int NumPago)
        {

            try
            {
                List<clsPagoDetalleDos> lista = new List<clsPagoDetalleDos>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.PagoDet where w.NumPago == NumPago select w;
                foreach (var item in con)
                {
                    clsPagoDetalleDos clas = new clsPagoDetalleDos();
                    clas.NumLinea = item.NumLinea;
                    clas.IdMedioPago = item.IdMedioPago;
                    clas.Monto = (item.Monto);
                    clas.NumeroCuenta = item.NumeroCuenta;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdBanco = item.IdBanco;
                    clas.NumComprobante = item.NumComprobante;
                    // clas.NumComision =Convert.ToInt32 ( item.NumComision);
                    clas.NumNominaCab = Convert.ToInt32(item.NumNominaCab);
                    clas.NumPago = item.NumPago;

                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public Boolean ConsultaNumeroDetalle(int numero)
        {

            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.PagoDet where q.NumPago == (numero) select q).First();
                    if (x.IdEmpresa >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;

            }

        }


        public decimal consultaTotal(int NumPago)
        {
            decimal Total = 0;
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoDet where w.NumOrdenCab == NumPago select w;

                foreach (var item in con)
                {
                    Total = Total + (item.TotalPagar);

                }

                return Total;
            }

            catch (Exception)
            {
                return Total;
            }

        }
        public decimal consultaTotalEmpleado(int NumPago)
        {
            decimal Total = 0;
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoEmpleadoDet where w.NumOrdenPago == NumPago select w;

                foreach (var item in con)
                {
                    Total = Total + (item.PagoNeto);

                }

                return Total;
            }

            catch (Exception)
            {
                return Total;
            }

        }
        

        public decimal consultaPagoDETALLE(int NumPago)
        {
            decimal valor = 0;
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.PagoDet where w.NumPago == NumPago select w;

                foreach (var item in con)
                {
                    valor = valor + (item.Monto);

                }

                return valor;
            }

            catch (Exception)
            {
                return valor;
            }

        }
        public void Modificar(clsPagoDetalle Det)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.PagoDet where q.NumPago == Det.NumPago select q).First();

                x.NumLinea = Det.NumLinea;
                x.IdMedioPago = Det.IdMedioPago;
                x.Monto = Det.Monto;
                x.IdEmpresa = Det.IdEmpresa;
                x.IdBanco = Det.IdBanco;
                x.NumComprobante = Det.NumComprobante;
                // x.NumComision = Det.NumComision;
                // x.NumNominaCab = Det.NumNominaCab;
                x.NumPago = Det.NumPago;

                ent.SaveChanges();

            }
        }


        public Boolean Guardar(clsPagoDetalle Det)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    PagoDet pago = new PagoDet()
                    {
                        NumLinea = id,
                        IdMedioPago = Det.IdMedioPago,
                        Monto = Det.Monto,
                        NumeroCuenta = Det.NumeroCuenta,
                        IdEmpresa = Det.IdEmpresa,
                        IdBanco = Det.IdBanco,
                        NumComprobante = Det.NumComprobante,
                        //  NumComision =Det.NumComision,
                        //   NumNominaCab=Det.NumNominaCab ,
                        NumPago = Det.NumPago,

                    };
                    ent.AddToPagoDet(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean GuardarDetalleNomina(clsPagoDetalleDos Det)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    PagoDet pago = new PagoDet()
                    {
                        NumLinea = id,
                        IdMedioPago = Det.IdMedioPago,
                        Monto = Det.Monto,
                        NumeroCuenta = Det.NumeroCuenta,
                        IdEmpresa = Det.IdEmpresa,
                        IdBanco = Det.IdBanco,
                        NumComprobante = Det.NumComprobante,
                        //  NumComision =Det.NumComision,
                        NumNominaCab = Det.NumNominaCab,
                        NumPago = Det.NumPago,

                    };
                    ent.AddToPagoDet(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public Boolean Eliminar(clsPagoDetalle Det)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.PagoDet where q.NumLinea == Det.NumLinea select q).First();

                    //   var y = (from q in ent.PagoDet where q.NumPago  == Det.NumPago select q).First();
                    ent.DeleteObject(x);

                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public int getIdSiguiente()
        {
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.PagoDet select a.NumLinea).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: datos " + e);
                return 1; //en caso de que no exista algun registro
            }

        }
        public List<clsOrdenPagoEmpleadoDet> ConsultaOrdenDetalleEmpleado(int numero)
        {
            try
            {
                List<clsOrdenPagoEmpleadoDet> lista = new List<clsOrdenPagoEmpleadoDet>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoEmpleadoDet where w.NumOrdenPago == numero select w;

                foreach (var item in con)
                {
                    clsOrdenPagoEmpleadoDet ord = new clsOrdenPagoEmpleadoDet();
                    ord.NumOrdenPago = item.NumOrdenPago;
                    ord.IdEmpresa = item.IdEmpresa;
                    ord.AutorizarPago = (item.AutorizarPago);
                    ord.Linea = item.Linea;
                    ord.IdPersona = item.IdPersona;
                    ord.SueldoTotal = Convert.ToDecimal(item.SueldoTotal);
                    ord.IngresoAdicional = Convert.ToDecimal(item.IngresoAdicional);
                    ord.DescuentoTotal = Convert.ToDecimal(item.DescuentoTotal);
                    ord.PagoNeto = item.PagoNeto;

                    lista.Add(ord);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

    }


}
