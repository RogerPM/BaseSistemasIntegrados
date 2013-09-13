using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.Cuentasxpagar;
using clases.Cuentasxpagar;
using clases.Seguridad;

namespace datos.Cuentasxpagar
{

    public class datosOrdenPagoDet
    {

        public List<clsOrdenPagoDet> Consulta()
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

        public void Modificar(clsOrdenPagoDet OrdenDet)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.OrdenPagoDet where q.NumOrdenCab == OrdenDet.NumOrdenPagoCab select q).First();

                x.NumLinea = OrdenDet.NumLinea;
                x.NumCuentaPorPagar = OrdenDet.NumCuentaPorPagar;
                x.NumDetalleDeuda = OrdenDet.NumDetalleDeuda;
                x.SaldoDeuda = OrdenDet.SaldoDeuda;
                x.NumeroPagosRealizar = OrdenDet.NumeroPagosRealizar;
                x.NumOrdenCab = OrdenDet.NumOrdenPagoCab;
                x.TotalPagar = OrdenDet.TotalPagar;
                x.IdEmpresa = OrdenDet.IdEmpresa;
                ent.SaveChanges();
            }
        }

        public Boolean Guardar(clsOrdenPagoDet OrdenDet)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    OrdenPagoDet pago = new OrdenPagoDet()
                    {
                        NumLinea = id,
                        NumCuentaPorPagar = OrdenDet.NumCuentaPorPagar,
                        NumDetalleDeuda = OrdenDet.NumDetalleDeuda,
                        SaldoDeuda = OrdenDet.SaldoDeuda,
                        NumeroPagosRealizar = OrdenDet.NumeroPagosRealizar,
                        NumOrdenCab = OrdenDet.NumOrdenPagoCab,
                        TotalPagar = OrdenDet.TotalPagar,
                        IdEmpresa = OrdenDet.IdEmpresa,

                    };
                    ent.AddToOrdenPagoDet(pago);
                    ent.SaveChanges();
                }

                return true;

            }

            catch (Exception)
            {
                return false;
            }
        }

        public Boolean Eliminar(clsOrdenPagoDet OrdenDet)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.OrdenPagoDet where q.NumLinea == OrdenDet.NumLinea select q).First();

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
                int x = ((from a in ent.OrdenPagoDet select a.NumLinea).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: datos " + e);
                return 1; //en caso de que no exista algun registro
            }

        }
    }

}
