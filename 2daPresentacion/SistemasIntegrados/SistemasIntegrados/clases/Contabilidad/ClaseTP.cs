using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class ClaseTP
    {
        public TECAEntitiesCont dt = null;
        public List<clsTipoTransaccion> ListarTP(String @buscar)
        {
            //where c.modulo.ToString().Contains(buscar) && c.modulo.ToString().Equals(mod.IdModulo)
            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    List<clsTipoTransaccion> lista = new List<clsTipoTransaccion>();
                    var per = from c in this.dt.TipoTransaccion
                              from mod in this.dt.Modulo
                              where c.modulo.ToString().Contains(buscar) //&& c.modulo.ToString().Equals(mod.IdModulo)
                              select c;

                    foreach (var item in per)
                    {
                        clsTipoTransaccion ctipo = new clsTipoTransaccion();
                        clsModulo ctipo1 = new clsModulo();
                        ctipo.IdTransaccion = Convert.ToInt32(item.IdTransaccion);
                        ctipo.modulo = Convert.ToInt32(item.modulo);
                        ctipo.TipoDocumento = item.TipoDocumento;
                        ctipo.descripcion = item.descripcion;
                        ctipo.nombremodulo = ctipo1.Nombre;
                        lista.Add(ctipo);
                    }
                    //return per.ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }


    }
}
