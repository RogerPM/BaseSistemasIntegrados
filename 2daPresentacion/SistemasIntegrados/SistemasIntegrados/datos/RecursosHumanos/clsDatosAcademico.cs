using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosAcademico
    {
        public List<clsAcademico>ConsultaAcademico()
        {
            try
            {
                List<clsAcademico> Lista = new List<clsAcademico>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Academico  select w;
                foreach (var item in con)
                {
                    clsAcademico clas = new clsAcademico();
                    clas .IdAcademico =item .IdAcademico ;
                    clas.IdPersona = item.IdPersona;
                    clas.IdTitulo = item.IdTitulo;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdUniversidad =item.IdUniversidad ;
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



        public Boolean Guardar(clsAcademico a)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    
                    Academico  aca = new Academico ()
                    {
                        IdAcademico =a.IdAcademico,
                        IdPersona = a.IdPersona,
                        IdTitulo =a.IdTitulo,
                        IdEmpresa = a.IdEmpresa,
                        IdUniversidad =a.IdUniversidad,
                        IdEstado = a.IdEstado,
                        

                    };
                    ent.AddToAcademico (aca);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsAcademico ac)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.Academico  where q.IdPersona  == ac.IdPersona  select q).First();
                x.IdAcademico = ac.IdAcademico;
                x.IdPersona = ac.IdPersona;
                x.IdTitulo =ac.IdTitulo;
                x.IdEmpresa = ac.IdEmpresa;
                x.IdUniversidad = ac.IdUniversidad;
                x.IdEstado = ac.IdEstado;
                                
                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsAcademico acad)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Academico   where q.IdPersona  == acad.IdPersona  select q).First();
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
                int x = ((from a in ent.Academico  select a.IdAcademico).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public clsDatosAcademico()
        {
            
        }
    }
}
