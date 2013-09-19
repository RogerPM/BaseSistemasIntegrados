using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosUniversidad
    {

        public List<clsUniversidad> ConsultaUniversidad()
        {
            try
            {
                List<clsUniversidad> Lista = new List<clsUniversidad>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Universidad select w;
                foreach (var item in con)
                {
                    clsUniversidad clas = new clsUniversidad();
                    clas.IdUniversidad = item.IdUniversidad;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.Nombre = item.Nombre;
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        

        public Boolean Guardar(clsUniversidad un)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    Universidad uni = new Universidad()
                    {
                        IdUniversidad = un.IdUniversidad,
                        IdEmpresa=un.IdEmpresa,
                        Nombre = un.Nombre,
                    };
                    ent.AddToUniversidad(uni);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Modificar(clsUniversidad un)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.Universidad where q.IdUniversidad == un.IdUniversidad select q).First();
                x.IdEmpresa = un.IdEmpresa;
                x.Nombre = un.Nombre;
                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsUniversidad un)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Universidad where q.IdUniversidad == un.IdUniversidad select q).First();
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
                int x = ((from a in ent.Universidad select a.IdUniversidad).Max()) + 1;
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
