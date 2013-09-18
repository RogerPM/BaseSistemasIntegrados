using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datTipoChasis
    {
        public List<clsTipoChasis> consulta()
        {

            try
            {
                List<clsTipoChasis> lista = new List<clsTipoChasis>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Chasis select w;
                foreach (var item in con)
                {
                    clsTipoChasis clas = new clsTipoChasis();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdChasis);
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

        public Boolean guardar(clsTipoChasis ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Chasis tm = new Chasis();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdChasis = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToChasis(tm);
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

        public Boolean modificar(clsTipoChasis ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Chasis", "IdChasis", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Chasis Chasis = (Chasis)OBJ;
                    Chasis.Descripcion = ctm.descripcion;
                    Chasis.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsTipoChasis ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Chasis where q.IdChasis == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Chasis   select a.IdChasis).Max()) + 1;
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
