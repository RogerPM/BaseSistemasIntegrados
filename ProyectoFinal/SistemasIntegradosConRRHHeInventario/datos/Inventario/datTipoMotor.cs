using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datTipoMotor
    {

        public List<clsTipoMotor> consulta()
        {
            try
            {
                List<clsTipoMotor> lista = new List<clsTipoMotor>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.TipoMotor select w;
                foreach (var item in con)
                {
                    clsTipoMotor clas = new clsTipoMotor();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdTipoMotor);
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

        public Boolean guardar(clsTipoMotor ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    TipoMotor tm = new TipoMotor();
                    
                        tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdTipoMotor = Convert.ToInt32(ctm.codigo);
                        tm.Descripcion = Convert.ToString(ctm.descripcion);
                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToTipoMotor(tm);
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


        public Boolean modificar(clsTipoMotor ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.TipoMotor", "IdTipoMotor", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    TipoMotor Motor = (TipoMotor)OBJ;
                    Motor.Descripcion = ctm.descripcion;
                    Motor.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        public void eliminar(clsTipoMotor ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                var t = (from q in te.TipoMotor where q.IdTipoMotor == ctm.codigo select q).First();
                te.DeleteObject(t);
                te.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.TipoMotor  select a.IdTipoMotor).Max()) + 1;
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
