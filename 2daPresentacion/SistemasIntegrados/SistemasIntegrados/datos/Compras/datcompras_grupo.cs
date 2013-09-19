using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;
using System.IO;

namespace datos.Compras
{
    public class datcompras_grupo
    {
        //metodo que retorna una lista con la cantidad de grupo que pertenecen a un id de artículo
        public List<clscompras_grupo> ListarGrupos(int tipoarticulo)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clscompras_grupo> listagrupo = new List<clscompras_grupo>();
                    var x = (from a in ent.Grupo where a.IdTipoArticulo == tipoarticulo select a);
                    foreach (var item in x)
                    {
                        clscompras_grupo e = new clscompras_grupo();
                        e.idEmpresa = Convert.ToInt32(item.IdEmpresa);
                        e.idGrupo = Convert.ToInt32(item.IdGrupo);
                        e.descripcion = Convert.ToString(item.Descripcion);
                        e.id_tipo_articulo = Convert.ToInt32(item.IdTipoArticulo);
                        e.idEstado = Convert.ToInt32(item.IdEstado);
                        listagrupo.Add(e);
                    }
                    return listagrupo;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        public List<clscompras_grupo> ListarSubGrupos(int tipoarticulo)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clscompras_grupo> listagrupo = new List<clscompras_grupo>();
                    var x = (from a in ent.Grupo where a.IdTipoArticulo == tipoarticulo select a);
                    foreach (var item in x)
                    {
                        clscompras_grupo e = new clscompras_grupo();
                        e.idEmpresa = Convert.ToInt32(item.IdEmpresa);
                        e.idGrupo = Convert.ToInt32(item.IdGrupo);
                        e.descripcion = Convert.ToString(item.Descripcion);
                        e.id_tipo_articulo = Convert.ToInt32(item.IdTipoArticulo);
                        e.idEstado = Convert.ToInt32(item.IdEstado);
                        listagrupo.Add(e);
                    }
                    return listagrupo;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }
    }
}
