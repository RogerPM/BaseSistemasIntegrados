using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datUnidadMedida
    {
        public List<clsUnidadMedida> consulta()
        {

            try
            {
                List<clsUnidadMedida> lista = new List<clsUnidadMedida>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.UnidadMedida select w;
                foreach (var item in con)
                {
                    clsUnidadMedida clas = new clsUnidadMedida();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdUnidadMedida);
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

        public Boolean guardar(clsUnidadMedida ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    UnidadMedida tm = new UnidadMedida();
                    
                        tm.IdEmpresa  = Convert.ToInt32(ctm.empresa);
                        tm.IdUnidadMedida  = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToUnidadMedida(tm);
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

        public Boolean modificar(clsUnidadMedida ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.UnidadMedida", "IdUnidadMedida", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    UnidadMedida UnidadMedida = (UnidadMedida)OBJ;
                    UnidadMedida.Descripcion = ctm.descripcion;
                    UnidadMedida.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsUnidadMedida ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.UnidadMedida where q.IdUnidadMedida == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.UnidadMedida select a.IdUnidadMedida).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public object tm { get; set; }
    }
}
