using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datTipoCombustible
    {
        public List<clsTipoCombustible> consulta()
        {

            try
            {
                List<clsTipoCombustible> lista = new List<clsTipoCombustible>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.TipoCombustible select w;
                foreach (var item in con)
                {
                    clsTipoCombustible clas = new clsTipoCombustible();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdTipoCombustible);
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

        public Boolean guardar(clsTipoCombustible ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    TipoCombustible tm = new TipoCombustible();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdTipoCombustible = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.codigo);
                    
                    te.AddToTipoCombustible(tm);
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

        public Boolean modificar(clsTipoCombustible ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.TipoCombustible", "IdTipoCombustible", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    TipoCombustible TipoCombustible = (TipoCombustible)OBJ;
                    TipoCombustible.Descripcion = ctm.descripcion;
                    TipoCombustible.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsTipoCombustible ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.TipoCombustible where q.IdTipoCombustible == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.TipoCombustible  select a.IdTipoCombustible).Max()) + 1;
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
