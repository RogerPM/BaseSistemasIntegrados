using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.Cuentasxpagar;
using clases.Seguridad;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class datosOrdenPagoCab
    {
        int identificador;

        public List<clsOrdenPagoDet> ConsultaOrdenPagoDet()
        {
            try
            {
                List<clsOrdenPagoDet> lista = new List<clsOrdenPagoDet>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoDet select w;
                foreach (var item in con)
                {
                    clsOrdenPagoDet clase = new clsOrdenPagoDet();
                    clase.NumLinea = item.NumLinea;
                    clase.NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clase.NumDetalleDeuda = item.NumDetalleDeuda;
                    clase.SaldoDeuda = item.SaldoDeuda;
                    clase.NumeroPagosRealizar = item.NumeroPagosRealizar;
                    clase.NumOrdenPagoCab = item.NumOrdenCab;
                    clase.TotalPagar = item.TotalPagar;
                    clase.IdEmpresa = item.IdEmpresa;

                    lista.Add(clase);
                }
                return lista;
            }

            catch (Exception)
            {
                return null;
            }
        }

        public List<clsOrdenPagoCab> consulta()
        {
            try
            {
                List<clsOrdenPagoCab> lista = new List<clsOrdenPagoCab>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoCab select w;
                foreach (var item in con)
                {
                    clsOrdenPagoCab clase = new clsOrdenPagoCab();
                    clase.NumOrdenPago = item.NumOrdenPago;
                    clase.fechadeEmision = item.fechadeEmision;
                    clase.IdPersona = Convert.ToInt32(item.IdPersona);
                    clase.Estado = item.Estado;
                    clase.TotalPagar = item.TotalPagar;
                    clase.TipoOrdenPago = item.TipoOrdenPago;
                    clase.IdUsuario = item.IdUsuario;
                    clase.IdEmpresa = item.IdEmpresa;
                    lista.Add(clase);

                }
                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public void Modificar(clsOrdenPagoCab OrdPagoCab)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.OrdenPagoCab where q.NumOrdenPago == OrdPagoCab.NumOrdenPago select q).First();
                x.NumOrdenPago = OrdPagoCab.NumOrdenPago;
                x.fechadeEmision = OrdPagoCab.fechadeEmision;
                x.IdPersona = OrdPagoCab.IdPersona;
                x.Estado = OrdPagoCab.Estado;
                x.TotalPagar = OrdPagoCab.TotalPagar;
                x.TipoOrdenPago = OrdPagoCab.TipoOrdenPago;
                x.IdUsuario = OrdPagoCab.IdUsuario;
                x.IdEmpresa = OrdPagoCab.IdEmpresa;
                ent.SaveChanges();
            }
        }

        public Boolean Guardar(clsOrdenPagoCab OrdPagoCab)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    OrdenPagoCab otro = new OrdenPagoCab()
                    {
                        NumOrdenPago = id,
                        fechadeEmision = OrdPagoCab.fechadeEmision,
                        IdPersona = OrdPagoCab.IdPersona,
                        Estado = OrdPagoCab.Estado,
                        TotalPagar = OrdPagoCab.TotalPagar,
                        TipoOrdenPago = OrdPagoCab.TipoOrdenPago,
                        IdUsuario = OrdPagoCab.IdUsuario,
                        IdEmpresa = OrdPagoCab.IdEmpresa,
                    };
                    ent.AddToOrdenPagoCab(otro);
                    ent.SaveChanges();
                }
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }

        public Boolean Eliminar(clsOrdenPagoCab OrdPago)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.OrdenPagoCab where q.NumOrdenPago == OrdPago.NumOrdenPago select q).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int getIdSiguiente()
        {
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.OrdenPagoCab select a.NumOrdenPago).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }


        }

        decimal saldoTotal;
        public decimal ConsultaSaldo()
        {
            try
            {

                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    saldoTotal = (from q in ent.CuentaBancaria select q.Saldo).Sum();
                }
                return Convert.ToDecimal(saldoTotal);

            }
            catch (Exception ex)
            {
                return 0;

            }
        }
    }
}