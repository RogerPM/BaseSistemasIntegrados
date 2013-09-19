using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;

namespace datos.CuentasxCobrar
{
    public class clsDatosCuentaxCobrar
    {
        public List<clsCuentaxCobrar> consultaCuentaPorCobrarGeneral()
        {
            try
            {
                List<clsCuentaxCobrar> lista = new List<clsCuentaxCobrar>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.CuentaxCobrar select b;
                foreach (var item in con)
                {
                    clsCuentaxCobrar ctaxcobrar = new clsCuentaxCobrar();
                    ctaxcobrar.idEmpresa = item.idEmpresa;
                    ctaxcobrar.idUsuario = item.idUsuario;
                    ctaxcobrar.idCuentaxCobrar = item.idCuentaxCobrar;
                    ctaxcobrar.numero_comprobante = Convert.ToInt32(item.numero_comprobante);
                    ctaxcobrar.Modulo = item.Modulo;
                    ctaxcobrar.idNumeroFactura = item.idNumeroFactura;
                    ctaxcobrar.TotalCuotas = item.TotalCuotas;
                    ctaxcobrar.porcentaje_interes = Convert.ToInt32(item.porcentaje_interes);
                    ctaxcobrar.estado = item.estado;

                    lista.Add(ctaxcobrar);
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
