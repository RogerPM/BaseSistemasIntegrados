using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;

namespace datos.Inventario
{
   public class datTipoMovimiento
    {
       public List<clsTipoMovimiento> consulta()
       {

           try
           {
               List<clsTipoMovimiento> lista = new List<clsTipoMovimiento>();
               INVENTARIOEntities ent = new INVENTARIOEntities();
               var con = from w in ent.TipoMovimiento select w;
               foreach (var item in con)
               {
                   clsTipoMovimiento clas = new clsTipoMovimiento();
                   clas.empresa = Convert.ToInt32(item.IdEmpresa);
                   clas.codigo = Convert.ToInt32(item.IdTipoMovimiento);
                   clas.descripcion = item.Descripcion;
                   clas.estado = Convert.ToString(item.IdEstado);
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
