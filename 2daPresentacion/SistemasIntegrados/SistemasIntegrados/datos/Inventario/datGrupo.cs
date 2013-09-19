using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datGrupo
    {


        public List<clsGrupo> consulta()
        {
            try
            {
                List<clsGrupo> lista = new List<clsGrupo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Grupo select w;
                foreach (var item in con)
                {
                    clsGrupo clas = new clsGrupo();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdGrupo);
                    clas.descripcion = item.Descripcion;
                    clas.tipoarticulo = Convert.ToString(item.IdTipoArticulo);
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

        public Boolean guardar(clsGrupo ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Grupo tm = new Grupo();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdGrupo = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdTipoArticulo = Convert.ToInt32(ctm.tipoarticulo);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToGrupo(tm);
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

        public Boolean modificar(clsGrupo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Grupo", "IdGrupo", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Grupo Grupo = (Grupo)OBJ;
                    Grupo.Descripcion = ctm.descripcion;
                    Grupo.IdTipoArticulo = Convert.ToInt32(ctm.tipoarticulo);
                    Grupo.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }



        public void eliminar(clsGrupo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Grupo where q.IdGrupo == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Grupo  select a.IdGrupo).Max()) + 1;
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
