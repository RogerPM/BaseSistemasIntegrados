using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;
using clases.Cuentasxpagar;
using datos.CuentasxCobrar;

namespace datos.CuentasxCobrar
{
    public class ClsDatosCobroLis
    {

        public List<clsPago> consultaPago()
        {
            try
            {
                List<clsPago> lista = new List<clsPago>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.PagoCab select w;
                foreach (var item in con)
                {
                    clsPago pago = new clsPago();
                    pago.NumPago = item.NumPago;
                    pago.FechaIngreso = item.FechaIngreso;
                    pago.TotalPagar = Convert.ToInt32(item.TotalPagar);
                    lista.Add(pago);

                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<clsCobro> consultacobro()
        {
            try
            {
                List<clsCobro> lista = new List<clsCobro>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.Cobro select w;
                foreach (var item in con)
                {
                    clsCobro cobro = new clsCobro();
                    cobro.idCobro = item.idCobro;
                    cobro.Fecha = item.Fecha;
                    cobro.ValorPagado = item.ValorPagado;
                    lista.Add(cobro);

                }
                return lista;

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
