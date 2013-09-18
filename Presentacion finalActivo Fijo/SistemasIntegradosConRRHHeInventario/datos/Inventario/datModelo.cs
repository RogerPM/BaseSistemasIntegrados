using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datModelo
    {

        public List<clsModelo> consulta()
        {

            try
            {
                List<clsModelo> lista = new List<clsModelo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Modelo select w;
                foreach (var item in con)
                {
                    clsModelo clas = new clsModelo();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdModelo);
                    clas.descripcion = item.Descripcion;
                    clas.marca = Convert.ToString(item.IdMarca);
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

        public Boolean guardar(clsModelo ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Modelo tm = new Modelo();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdModelo = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdMarca = Convert.ToInt32(ctm.marca);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToModelo(tm);
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

        public Boolean modificar(clsModelo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Modelo", "IdModelo", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Modelo Modelo = (Modelo)OBJ;
                    Modelo.Descripcion = ctm.descripcion;
                    Modelo.IdMarca = Convert.ToInt32(ctm.marca);
                    Modelo.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsModelo ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Modelo where q.IdModelo == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Modelo select a.IdModelo).Max()) + 1;
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
