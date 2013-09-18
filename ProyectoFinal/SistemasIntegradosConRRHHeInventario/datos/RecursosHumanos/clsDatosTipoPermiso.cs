using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosTipoPermiso
    {

        public List<clsTipoPermiso> ConsultaTipoPermiso()
        {
            try
            {
                List<clsTipoPermiso> Lista = new List<clsTipoPermiso>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.TipoPermiso select w;
                foreach (var item in con)
                {
                    clsTipoPermiso clas = new clsTipoPermiso();
                    clas.IdTipoPermiso = Convert.ToInt32(item.IdTipoPermiso);
                    clas.Descripcion = item.Descripcion;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdEstado = Convert.ToInt32(item.IdEstado);
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public Boolean Guardar(clsTipoPermiso tiPe)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    TipoPermiso tiP = new TipoPermiso()
                    {
                        IdTipoPermiso = tiPe.IdTipoPermiso,
                        Descripcion = tiPe.Descripcion,
                        IdEmpresa = tiPe.IdEmpresa,
                        IdEstado = tiPe.IdEstado,
                       
                    };
                    ent.AddToTipoPermiso(tiP);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
                return false;
            }

        }


        public void Modificar(clsTipoPermiso tiP)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.TipoPermiso where q.IdTipoPermiso == tiP.IdTipoPermiso select q).First();
                x.Descripcion = tiP.Descripcion;
                x.IdEmpresa = tiP.IdEmpresa;
                x.IdEstado = tiP.IdEstado;
                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsTipoPermiso tiP)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.TipoPermiso where q.IdTipoPermiso == tiP.IdTipoPermiso select q).First();
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
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int x = ((from a in ent.TipoPermiso select a.IdTipoPermiso).Max()) + 1;
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
