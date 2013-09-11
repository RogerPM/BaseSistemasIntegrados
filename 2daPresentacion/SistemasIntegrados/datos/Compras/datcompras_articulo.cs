using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;
using System.IO;

namespace datos.Compras
{
    public class datcompras_articulo
    {
        //metodo que retorna una lista con la cantidad de articulos que pertenecen a un grupo
        public List<clscompras_articulos> ListarArticulos(int grupo)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clscompras_articulos> lista_articulo = new List<clscompras_articulos>();
                    var x = (from a in ent.Articulo_Vista where a.IdGrupo == grupo select a);
                    foreach (var item in x)
                    {
                        clscompras_articulos e = new clscompras_articulos();
                        e.idarticulo = Convert.ToInt32(item.IdArticulo);
                        e.descripcion = Convert.ToString(item.Descripcion);
                        e.cantidad_actual = Convert.ToInt32(item.CantidadActual);
                        e.id_tipoarticulo = Convert.ToInt32(item.IdTipoArticulo);
                        e.tipo_articulo = Convert.ToString(item.TipoArticulo);
                        e.id_grupo = Convert.ToInt32(item.IdGrupo);
                        e.grupo = Convert.ToString(item.Grupo);
                        e.id_empresa = Convert.ToInt32(item.IdEmpresa);
                        e.NombreComercial = Convert.ToString(item.NombreComercial);
                        e.id_estado = Convert.ToInt32(item.IdEstado);
                        e.estado = Convert.ToString(item.Estado);
                        lista_articulo.Add(e);
                    }
                    return lista_articulo;
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
