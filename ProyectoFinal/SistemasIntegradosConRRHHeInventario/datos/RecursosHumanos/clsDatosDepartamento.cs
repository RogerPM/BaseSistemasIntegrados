using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosDepartamento
    {
        public List<clsDepartamento>ConsultaDepartamento() 
        {
            try 
            {
                List<clsDepartamento> Lista = new List<clsDepartamento>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Departamento select w;
                foreach (var item in con)
                {
                    clsDepartamento clas = new clsDepartamento();
                    clas.IdDepartamento = Convert.ToInt32(item.IdDepartamento);
                    clas.Descripcion = item.Descripcion;
                    clas.IdEstado = Convert.ToInt32(item.IdEstado);
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch(Exception)
            {
                return null;
            }
        }

        

        public Boolean Guardar(clsDepartamento dep) 
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    Departamento depar = new Departamento()
                        {
                            IdDepartamento = dep.IdDepartamento,
                            Descripcion = dep.Descripcion,
                            IdEstado = dep.IdEstado
                        };

                    ent.AddToDepartamento(depar);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Modificar(clsDepartamento dep) 
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            { 
                var x = (from q in ent.Departamento where q.IdDepartamento==dep.IdDepartamento select q).First();
                x.Descripcion = dep.Descripcion;
                x.IdEstado = dep.IdEstado;
                ent.SaveChanges();

            }
        }

              

        public Boolean Eliminar(clsDepartamento dep)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Departamento where q.IdDepartamento == dep.IdDepartamento select q).First();
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
                int x = ((from a in ent.Departamento select a.IdDepartamento).Max()) + 1;
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
