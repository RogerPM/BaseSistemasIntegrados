using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datTipoArticulo
    {
        public List<clsTipoArticulo> consulta()
        {

            try
            {
                List<clsTipoArticulo> lista = new List<clsTipoArticulo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.TipoArticulo select w;
                foreach (var item in con)
                {
                    clsTipoArticulo clas = new clsTipoArticulo();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdTipoArticulo);
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

        public Boolean guardar(clsTipoArticulo ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    TipoArticulo tm = new TipoArticulo();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdTipoArticulo = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToTipoArticulo(tm);
                    te.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                Mensaje = "ERROR" + e.InnerException + e.Message;
                //System.Windows.Forms.MessageBox.Show("error al guardar" + e);
                return false;
            }
        }

        public Boolean modificar(clsTipoArticulo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.TipoArticulo", "IdTipoArticulo", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    TipoArticulo TipoArticulo = (TipoArticulo)OBJ;
                    TipoArticulo.Descripcion = ctm.descripcion;
                    TipoArticulo.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsTipoArticulo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.TipoArticulo where q.IdTipoArticulo == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

      
    }
}
