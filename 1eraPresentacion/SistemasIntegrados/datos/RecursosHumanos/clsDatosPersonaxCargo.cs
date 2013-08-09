using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosPersonaxCargo
    {


        public List<clsPersonaxCargo > ConsultaPersonaxCargo()
        {
            try
            {
                List<clsPersonaxCargo> Lista = new List<clsPersonaxCargo>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.PersonaxCargo  select w;
                foreach (var item in con)
                {
                    clsPersonaxCargo clas = new clsPersonaxCargo();
                    clas.IdPersona = item.IdPersona;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas .IdCargo =item .IdCargo ;
                    clas .FechaIngreso =Convert.ToDateTime ( item .FechaIngreso );
                    clas .FechaModificacion =Convert .ToDateTime ( item .FechaModificacion) ;
                    clas.IdEstado =item .IdEstado ;
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public Boolean Guardar(clsPersonaxCargo peca)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    PersonaxCargo  pecar = new PersonaxCargo ()
                    {
                        IdPersona = peca.IdPersona,
                        IdEmpresa = peca.IdEmpresa,
                        IdCargo =peca .IdCargo,
                        FechaIngreso =  peca.FechaIngreso ,
                        FechaModificacion =peca .FechaModificacion ,
                        IdEstado = peca.IdEstado,
                   





                    };
                    ent.AddToPersonaxCargo(pecar);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsPersona pe)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.Persona where q.Identificacion == pe.Identificacion select q).First();
                x.IdPersona = pe.IdPersona;
                x.Identificacion = pe.Identificacion;
                x.IdTipoPersona = pe.IdTipoPersona;
                x.NombreRazonSocial = pe.NombreRazonSocial;
                x.Apellido = pe.Apellido;
                x.FechaNacimiento = pe.FechaNacimiento;
                x.genero = pe.Genero;
                x.TipoIdentificacion = pe.TipoIdentificacion;
                x.direccion = pe.Direccion;
                x.TelefonoGneral = pe.TelefonoGneral;
                x.TelefonoMovil = pe.TelefonoMovil;
                x.TelefonoCasa = pe.TelefonoCasa;
                x.TelefonoOtros = pe.TelefonoOtros;
                x.mail = pe.Mail;
                x.IdEmpresa = pe.IdEmpresa;
                x.IdEstado = pe.IdEstado;
                // x.IdFoto =pe.foto;

                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsPersona pe)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Persona where q.Identificacion == pe.Identificacion select q).First();
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





    }
}
