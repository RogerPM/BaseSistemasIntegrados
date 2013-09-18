using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosMaternidad
    {

        public List<clsMaternidad> ConsultaMaternidad()
        {

            try
            {
                List<clsMaternidad> Lista = new List<clsMaternidad>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Maternidad select w;
                foreach (var item in con)
                {
                    clsMaternidad clas = new clsMaternidad();

                    clas.NumMaternidad = item.NumMaternidad;
                    clas.IdEmpleado = item.IdEmpleado;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.FechaParto = item.FechaParto;
                    clas.FechaInicio = item.FechaInicio;
                    clas.FechaFin = item.FechaFin;
                    clas.FechaModificacion = Convert.ToDateTime( item.FechaModificacion);
                    clas.IdEstado = item.IdEstado;
                    

                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        
        public Boolean Guardar(clsMaternidad ma)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    Maternidad mat = new Maternidad()
                    {
                        NumMaternidad = ma.NumMaternidad,
                        IdEmpleado = ma.IdEmpleado,
                        IdEmpresa = ma.IdEmpresa,
                        FechaParto = ma.FechaParto,
                        FechaInicio = ma.FechaInicio,
                        FechaFin = ma.FechaFin,
                        FechaModificacion= ma.FechaModificacion,
                        IdEstado = ma.IdEstado
                    };
                    ent.AddToMaternidad(mat);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Modificar(clsMaternidad ma)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.Maternidad where q.NumMaternidad == ma.NumMaternidad select q).First();
                x.IdEmpleado = ma.IdEmpleado;
                x.IdEmpresa = ma.IdEmpresa;
                x.FechaParto = ma.FechaParto;
                x.FechaInicio = ma.FechaInicio;
                x.FechaFin = ma.FechaFin;
                x.FechaModificacion = ma.FechaModificacion;
                x.IdEstado = ma.IdEstado;
                ent.SaveChanges();
            }
        }

        public Boolean Eliminar(clsMaternidad ma)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Maternidad where q.NumMaternidad == ma.NumMaternidad select q).First();
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
                int x = ((from a in ent.Maternidad select a.NumMaternidad).Max()) + 1;
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
