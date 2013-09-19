using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;

namespace datos.Contabilidad
{
    public class clsDatoER
    {

        public List<clsResultado> consulta(DateTime fecha) {
            try
            {
                
                EntitiesContabilidad2 ent = new EntitiesContabilidad2();
                List<clsResultado> lista = new List<clsResultado>();
                var sel = ent.reporteResultado(fecha);
                foreach (var item in sel)
                {
                    clsResultado clas = new clsResultado();
                    clas.Saldo = item.Saldo;
                    if (item.Codigo.Length > 22)
                    {
                        clas.Codigo = item.Codigo.Substring(0,20);

                    }
                    else
                    {
                        clas.Codigo = item.Codigo;
                    }
                    clas.Cuenta = item.Cuenta;
                    lista.Add(clas);
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
