using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosPersonaxTitulo
    {
        public List<clsPersonaxTitulo> ConsultaPersonaxTitulo()
        {
            try
            {
                List<clsPersonaxTitulo> Lista = new List<clsPersonaxTitulo>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.PersonaxTitulo select w;
                foreach (var item in con)
                {
                    clsPersonaxTitulo clas = new clsPersonaxTitulo();
                    clas.IdTitulo = item.IdTitulo;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdPersona = item.IdPersona;
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



        public Boolean Guardar(clsPersonaxTitulo peti)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    PersonaxTitulo petit = new PersonaxTitulo()
                    {
                        IdTitulo = peti.IdTitulo,
                        IdEmpresa = peti.IdEmpresa,
                        IdPersona = peti.IdPersona,
                        IdEstado = peti.IdEstado,


                    };
                    ent.AddToPersonaxTitulo(petit);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsPersonaxTitulo pt)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.PersonaxTitulo where q.IdPersona == pt.IdPersona select q).First();
                x.IdTitulo = pt.IdTitulo;
                x.IdEmpresa = pt.IdEmpresa;
                x.IdPersona = pt.IdPersona;
                x.IdEstado = pt.IdEstado;

                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsPersonaxTitulo pti)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.PersonaxTitulo where q.IdPersona == pti.IdPersona select q).First();
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
                int x = ((from a in ent.Persona select a.IdPersona).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public clsDatosPersonaxTitulo()
        {

        }
    }
}
