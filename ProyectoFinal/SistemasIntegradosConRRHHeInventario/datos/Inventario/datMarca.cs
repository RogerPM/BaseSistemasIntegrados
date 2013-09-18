using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datMarca
    {
        public List<clsMarca> consulta()
        {
            try
            {
                List<clsMarca> lista = new List<clsMarca>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Marca select w;
                foreach (var item in con)
                {
                    clsMarca clas = new clsMarca();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdMarca);
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

        public Boolean guardar(clsMarca ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Marca tm = new Marca();
                  
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdMarca = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToMarca(tm);
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


        public Boolean modificar(clsMarca ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Marca", "IdMarca", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Marca Marca = (Marca)OBJ;
                    Marca.Descripcion = ctm.descripcion;
                    Marca.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsMarca ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Marca where q.IdMarca == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Marca select a.IdMarca).Max()) + 1;
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
