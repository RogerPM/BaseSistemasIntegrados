using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosCargoxDepartamento
    {


        public List<clsCargoxDepartamento> ConsultaCargoxDepartamento()
        {
            try
            {
                List<clsCargoxDepartamento> Lista = new List<clsCargoxDepartamento>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.CargoxDepartamento  select w;
                foreach (var item in con)
                {
                    clsCargoxDepartamento clas = new clsCargoxDepartamento();
                    clas.IdDepartamento = item.IdDepartamento;
                    clas.IdCargo = item.IdCargo;
                    clas.FechaCreación  = Convert.ToDateTime(item.FechaCreacion );
                    clas.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
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



        public Boolean Guardar(clsCargoxDepartamento cade)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    CargoxDepartamento  cadep = new CargoxDepartamento ()
                    {
                        IdDepartamento =cade .IdDepartamento ,
                        IdCargo = cade.IdCargo,
                        FechaCreacion = cade.FechaCreación ,
                        FechaModificacion = cade.FechaModificacion,
                        IdEstado = cade.IdEstado,






                    };
                    ent.AddToCargoxDepartamento(cadep);
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
                x.genero = pe.genero ;
                x.TipoIdentificacion = pe.TipoIdentificacion;
                x.direccion = pe.direccion ;
                x.TelefonoGneral = pe.General ;
                x.TelefonoMovil = pe.Movil ;
                x.TelefonoCasa = pe.Casa ;
                x.TelefonoOtros = pe.Otros ;
                x.mail = pe.mail ;
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
