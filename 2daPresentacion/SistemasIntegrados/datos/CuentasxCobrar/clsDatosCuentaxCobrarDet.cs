using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;

namespace datos.CuentasxCobrar
{
    public class clsDatosCuentaxCobrarDet
    {
        public List<clsCuentaxCobrarDet> consultaCuentaPorCobrarDetalleGeneral()
        {
            try
            {
                List<clsCuentaxCobrarDet> lista = new List<clsCuentaxCobrarDet>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.CuentaxCobrarDet select b;
                foreach (var item in con)
                {
                    clsCuentaxCobrarDet ctaxcobrarDet = new clsCuentaxCobrarDet();
                    ctaxcobrarDet.idCuentaxCobrar = item.idCuentaxCobrar;
                    ctaxcobrarDet.Numero = item.Numero;
                    ctaxcobrarDet.numero_cuota = item.numero_cuota;
                    ctaxcobrarDet.valor_cuota = item.valor_cuota;
                    ctaxcobrarDet.valor_interes = item.valor_interes;
                    ctaxcobrarDet.valor_mora = item.valor_mora;
                    ctaxcobrarDet.fecha_cobro = item.fecha_cobro;
                    ctaxcobrarDet.fecha_vencimiento = item.fecha_vencimiento;
                    ctaxcobrarDet.FechaModificacion= Convert.ToDateTime(item.FechaModificacion);
                    ctaxcobrarDet.estado = item.estado;

                    lista.Add(ctaxcobrarDet);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<clsCuentaxCobrarDet> consultaCuentaPorCobrarDetalleEspecifica(int id)
        {
            try
            {
                List<clsCuentaxCobrarDet> lista = new List<clsCuentaxCobrarDet>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.CuentaxCobrarDet where b.idCuentaxCobrar == id select b;
                foreach (var item in con)
                {
                    clsCuentaxCobrarDet ctaxcobrarDet = new clsCuentaxCobrarDet();
                    ctaxcobrarDet.idCuentaxCobrar = item.idCuentaxCobrar;
                    ctaxcobrarDet.Numero = item.Numero;
                    ctaxcobrarDet.numero_cuota = item.numero_cuota;
                    ctaxcobrarDet.valor_cuota = item.valor_cuota;
                    ctaxcobrarDet.valor_interes = item.valor_interes;
                    ctaxcobrarDet.valor_mora = item.valor_mora;
                    ctaxcobrarDet.fecha_cobro = item.fecha_cobro;
                    ctaxcobrarDet.fecha_vencimiento = item.fecha_vencimiento;
                    ctaxcobrarDet.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    ctaxcobrarDet.estado = item.estado;

                    lista.Add(ctaxcobrarDet);
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
