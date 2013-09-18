using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;
using datos.Inventario;

namespace datos.Inventario
{
    public class datBodega
    {
        public List<clsBodega> consulta()
        {
            try
            {
                List<clsBodega> lista = new List<clsBodega>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.Bodega select w;
                foreach (var item in con)
                {
                    clsBodega clas = new clsBodega();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.codigo = Convert.ToInt32(item.IdBodega);
                    clas.descripcion = item.Decripcion;
                    clas.capacidadm2 = Convert.ToInt32(item.Capacidadm2);
                    clas.responsable = Convert.ToString(item.IdResponsable);
                    clas.percha = Convert.ToString(item.IdPercha);
                    clas.direccion = item.Direccion;
                    clas.telefono = item.Telefono ;
                    clas.estado = Convert.ToString(item.IdEstado);
                    lista.Add(clas);

                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
                return null;
            }
        }


        public Boolean guardar(clsBodega ctm, ref string Mensaje)
        {
            try
            {
                using (INVENTARIOEntities te = new INVENTARIOEntities())
                {
                    Bodega tm = new Bodega();
                    
                       tm. IdEmpresa = Convert.ToInt32(ctm.empresa);
                        tm.IdBodega = ctm.codigo;
                        tm.Decripcion = ctm.descripcion;
                        tm.Capacidadm2 = ctm.capacidadm2;
                        tm.IdResponsable = Convert.ToInt32(ctm.responsable);
                        tm.IdPercha = Convert.ToInt32(ctm.percha);
                        tm.Direccion = ctm.direccion;
                        tm.Telefono = ctm.telefono;

                        tm.IdEstado = Convert.ToInt32(ctm.estado);
                    
                    te.AddToBodega(tm);
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


        public Boolean modificar(clsBodega ctm)
        {
            using (INVENTARIOEntities te = new INVENTARIOEntities())
            {
                EntityKey ekey = new EntityKey("INVENTARIOEntities.Bodega", "IdBodega", ctm.codigo);
                object OBJ = null;
                if (te.TryGetObjectByKey(ekey, out OBJ))
                {
                    Bodega Bodega = (Bodega)OBJ;
                    Bodega.Decripcion = ctm.descripcion;
                    Bodega.Capacidadm2 = ctm.capacidadm2;
                    Bodega.IdResponsable = Convert.ToInt32(ctm.responsable);
                    Bodega.IdPercha = Convert.ToInt32(ctm.percha);
                    Bodega.Direccion = ctm.direccion;
                    Bodega.Telefono = ctm.telefono;
                    Bodega.IdEstado = Convert.ToInt32(ctm.estado);


                }
                te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
            }
            return true;
        }

        //metodo que retorna el nombre de la empresa segun Id que se le envia
        public string ConsultarPorId(int id)
        {
            using (INVENTARIOEntities ent = new INVENTARIOEntities())
            {
                var x = (from a in ent.Empresa where a.IdEmpresa == id select a).First();
                return x.NombreComercial;
            }
        }

        public Boolean eliminar(clsBodega ctm)
        {
            try
            {

                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    var x = (from q in ent.Bodega  where q.IdBodega == ctm.IdBodega select q).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Bodega  select a.IdBodega ).Max()) + 1;
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
