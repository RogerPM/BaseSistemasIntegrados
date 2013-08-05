using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario ;

namespace datos.Inventario
{
    public class clsClaseDatosGrupo
    {

        public List<clsGrupo> consultaGrupo()
        {
            try
            {
                List<clsGrupo> lista = new List<clsGrupo >();
                InventarioEntities  ent = new InventarioEntities ();
                var con = from w in ent.Grupo  select w;

                foreach (var item in con)
                {
                    clsGrupo clas = new clsGrupo ();
                    clas.CodGrupo = item.IdGrupo;
                    clas.Descripcion= item.Descripcion;

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
