using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;


namespace datos.Inventario
{
    public class datPercha
    {
        public List<clsPercha> consulta()
        {
            try
            {
                List<clsPercha> lista = new List<clsPercha>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Percha select w;
                foreach (var item in con)
                {
                    clsPercha clas = new clsPercha();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdPercha);
                    clas.descripcion = Convert.ToString(item.Descripcion);
                    clas.divisiones = Convert.ToInt32(item.Nro_Divisiones );
                    clas.estado = Convert.ToString(item.IdEstado);
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }

        private string descripcion(string p)
        {
            throw new NotImplementedException();
        }

        public Boolean guardar(clsPercha ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Percha tm = new Percha();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdPercha = ctm.codigo;
                        tm.Descripcion = ctm.descripcion;
                        tm.Nro_Divisiones = ctm.divisiones;
                        tm.IdBodega = Convert.ToInt32(ctm.bodega);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToPercha(tm);
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

        public Boolean modificar(clsPercha ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Percha", "IdPercha", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Percha Percha = (Percha)OBJ;
                    Percha.Descripcion = ctm.descripcion;
                    Percha.Nro_Divisiones = ctm.divisiones;
                    Percha.IdBodega = Convert.ToInt32(ctm.bodega);
                    Percha.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsPercha ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.Percha where q.IdPercha == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Percha  select a.IdPercha).Max()) + 1;
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
