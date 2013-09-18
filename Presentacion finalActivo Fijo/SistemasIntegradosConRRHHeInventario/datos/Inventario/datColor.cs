using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datColor
    {
        public List<clsColor> consulta()
        {

            try
            {
                List<clsColor> lista = new List<clsColor>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Color select w;
                foreach (var item in con)
                {
                    clsColor clas = new clsColor();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdColor);
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

        public Boolean guardar(clsColor ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Color tm = new Color();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdColor = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado );
                    
                    te.AddToColor(tm);
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

        public Boolean modificar(clsColor ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Color", "IdColor", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Color Color = (Color)OBJ;
                    Color.Descripcion = ctm.descripcion;
                    Color.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsColor ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Color where q.IdColor == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Color  select a.IdColor).Max()) + 1;
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
