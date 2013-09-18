using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosTitulo
    {


        public List<clsTitulo> ConsultaTitulo()
        {

            try
            {
                List<clsTitulo> Lista = new List<clsTitulo>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Titulo select w;
                foreach (var item in con)
                {
                    clsTitulo clas = new clsTitulo();
                    clas.IdTitulo=item.IdTitulo;
                    clas.Nombre = item.Nombre;
                    clas.FechaInicio = item.FechaInicio;
                    clas.FechaFinal = item.FechaFinal;
                    clas.IdEstado = item.IdEstado;
                    clas.IdUniversidad = item.IdUniversidad;
                    clas.IdEmpresa = item.IdEmpresa;
                    
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

       
        public Boolean Guardar(clsTitulo ti)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    Titulo tit = new Titulo()
                    {
                        IdTitulo = ti.IdTitulo,
                        Nombre = ti.Nombre,
                        FechaInicio = ti.FechaInicio,
                        FechaFinal = ti.FechaFinal,
                        IdEstado = ti.IdEstado,
                        IdUniversidad = ti.IdUniversidad,
                        IdEmpresa = ti.IdEmpresa
                    };
                    ent.AddToTitulo(tit);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public void Modificar(clsTitulo ti)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.Titulo where q.IdTitulo == ti.IdTitulo select q).First();
                x.Nombre = ti.Nombre;
                x.FechaInicio=ti.FechaInicio;
                x.FechaFinal= ti.FechaFinal;
                x.IdEstado = ti.IdEstado;
                x.IdUniversidad=ti.IdUniversidad;
                x.IdEmpresa = ti.IdEmpresa;
                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsTitulo ti)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Titulo where q.IdTitulo == ti.IdTitulo select q).First();
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
                int x = ((from a in ent.Titulo select a.IdTitulo).Max()) + 1;
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
