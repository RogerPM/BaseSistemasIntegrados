using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;

namespace datos.Inventario
{
    public class clsClaseDatosGrupo
    {

        public List<clsGrupoAF> consultaGrupo()
        {
            try
            {
                List<clsGrupoAF> lista = new List<clsGrupoAF>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Grupo select w;

                foreach (var item in con)
                {
                    clsGrupoAF clas = new clsGrupoAF();
                    clas.CodGrupo = item.IdGrupo;
                    clas.Descripcion = item.Descripcion;

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
