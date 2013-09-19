using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datTipoMaterial
    {

        public List<clsTipoMaterial> consulta()
        {

            try
            {
                List<clsTipoMaterial> lista = new List<clsTipoMaterial>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.TipoMaterial select w;
                foreach (var item in con)
                {
                    clsTipoMaterial clas = new clsTipoMaterial();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdTipoMaterial);
                    clas.descripcion = item.Descripcion;
                    // clas.usuario = Convert.ToInt32(item.IdUsuario);
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

        public Boolean guardar(clsTipoMaterial ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    TipoMaterial tm = new TipoMaterial();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdTipoMaterial = ctm.codigo;
                        tm.Descripcion = ctm.descripcion;
                        // IdUsuario = Convert.ToInt32(ctm.usuario),
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToTipoMaterial(tm);
                    te.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Mensaje = "ERROR" + e.InnerException + e.Message;
                //Console.WriteLine("ERROR" + e);
                return false;
            }
        }

        public Boolean modificar(clsTipoMaterial ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.TipoMaterial", "IdTipoMaterial", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    TipoMaterial TipoMaterial = (TipoMaterial)OBJ;
                    TipoMaterial.Descripcion = ctm.descripcion;
                    TipoMaterial.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);

                //var t = (from q in te.TipoMaterial where q.IdTipoMaterial == ctm.codigo && q.IdEmpresa == ctm.empresa select q).First();
                //t.IdEmpresa = Convert.ToInt32(ctm.empresa);
                //t.Descripcion = ctm.descripcion;
                //// t.IdUsuario = Convert.ToInt32(ctm.usuario);
                //t.IdEstado = Convert.ToInt32(ctm.estado);
                //te.SaveChanges();
            }
            return true;
        }

        public void eliminar(clsTipoMaterial ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.TipoMaterial where q.IdTipoMaterial == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.TipoMaterial  select a.IdTipoMaterial).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
    }
}
