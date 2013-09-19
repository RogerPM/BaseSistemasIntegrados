using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;


namespace datos.Contabilidad
{
    public class clsDatoLibroDiario
    {
        public List<clsvwlibrodiario> Consulta(DateTime _fechaini, DateTime _fechafin)
        {
            try
            {
                List<clsvwlibrodiario> lista = new List<clsvwlibrodiario>();
                
                EntitiesContabilidad2 ent = new EntitiesContabilidad2();
                var datos = from tt in ent.vwlibrodiario select tt;
                //var datos = from tt in ent.vwlibrodiario where (tt.fecha >= _fechaini && tt.fecha <= _fechafin ) select tt;

                foreach (var item in datos)
                {
                    clsvwlibrodiario clase = new clsvwlibrodiario();
                    if ((item.fecha) >= _fechaini && (item.fecha) <= _fechafin)
                        {
                        clase.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        clase.numero_comprobante = Convert.ToInt32(item.numero_comprobante);
                        clase.fecha = Convert.ToDateTime(item.fecha);
                        clase.glosa = item.glosa;
                        clase.cuenta = Convert.ToInt32(item.cuenta);
                        clase.nombre = item.nombre;
                        clase.debe = Convert.ToDecimal(item.debe);
                        clase.haber = Convert.ToDecimal(item.haber);
                        clase.tipoTransaccion = Convert.ToInt32(item.TipoTransaccion);
                        clase.nombreModulo = Convert.ToString(item.NombreModulo);
                        lista.Add(clase);
                        }
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
