using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using System.Data.SqlClient;
using System.Data;

namespace datos.RecursosHumanos
{
    public class clsDatosPersona
    {


        public List<clsPersona> ConsultaPersona()
        {
            try
            {
                List<clsPersona> Lista = new List<clsPersona>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Persona select w;
                foreach (var item in con)
                {
                    clsPersona clas = new clsPersona();
                    clas.IdPersona = item.IdPersona;
                    clas.Identificacion = Convert.ToInt64(item.Identificacion);
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdTipoPersona = item.IdTipoPersona;
                    clas.NombreRazonSocial = item.NombreRazonSocial;
                    clas.Apellido = item.Apellido;
                    clas.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
                    clas.genero = item.genero;
                    clas.TipoIdentificacion = item.TipoIdentificacion;
                    clas.direccion = item.direccion;
                    clas.General = Convert.ToInt32(item.TelefonoGneral);
                    clas.Movil = Convert.ToInt32(item.TelefonoMovil);
                    clas.Casa = Convert.ToInt32(item.TelefonoCasa);
                    clas.Otros = Convert.ToInt32(item.TelefonoOtros);
                    clas.mail = item.mail;
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



        public Boolean Guardar(clsPersona pe)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    Persona per = new Persona()
                    {
                        IdPersona = pe.IdPersona,
                        IdEmpresa = pe.IdEmpresa,
                        Identificacion = pe.Identificacion,
                        IdTipoPersona = pe.IdTipoPersona,
                        NombreRazonSocial = pe.NombreRazonSocial,
                        Apellido = pe.Apellido,
                        FechaNacimiento = pe.FechaNacimiento,
                        genero = pe.genero,
                        TipoIdentificacion = pe.TipoIdentificacion,
                        direccion = pe.direccion,
                        TelefonoGneral = pe.General,
                        TelefonoMovil = pe.Movil,
                        TelefonoCasa = pe.Casa,
                        TelefonoOtros = pe.Otros,
                        mail = pe.mail,

                        IdEstado = pe.IdEstado,
                        //IdFoto = pe.foto,





                    };
                    ent.AddToPersona(per);
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

                var x = (from q in ent.Persona where q.IdPersona == pe.IdPersona select q).First();
                x.IdPersona = pe.IdPersona;
                x.Identificacion = pe.Identificacion;
                x.IdTipoPersona = pe.IdTipoPersona;
                x.NombreRazonSocial = pe.NombreRazonSocial;
                x.Apellido = pe.Apellido;
                x.FechaNacimiento = pe.FechaNacimiento;
                x.genero = pe.genero;
                x.TipoIdentificacion = pe.TipoIdentificacion;
                x.direccion = pe.direccion;
                x.TelefonoGneral = pe.General;
                x.TelefonoMovil = pe.Movil;
                x.TelefonoCasa = pe.Casa;
                x.TelefonoOtros = pe.Otros;
                x.mail = pe.mail;
                // x.IdEmpresa =pe.IdEmpresa ;
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
                    var x = (from q in ent.Persona where q.IdPersona == pe.IdPersona select q).First();
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
                //agregado por Cuentas por pagar
        public void ConsultaEspecificaPersona(clsPersona pe)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.Persona where q.IdPersona == pe.IdPersona select q).First();
                pe.IdPersona = x.IdPersona;
                pe.Identificacion = Convert.ToInt32(x.Identificacion);
                pe.IdTipoPersona = x.IdTipoPersona;
                pe.NombreRazonSocial = x.NombreRazonSocial;
                pe.Apellido = x.Apellido;
                pe.FechaNacimiento = Convert.ToDateTime(x.FechaNacimiento);
                pe.genero = x.genero;
                pe.TipoIdentificacion = x.TipoIdentificacion;
                pe.direccion = x.direccion;
                pe.General = Convert.ToInt32(x.TelefonoGneral);
                pe.Movil = Convert.ToInt32(x.TelefonoMovil);
                pe.Casa = Convert.ToInt32(x.TelefonoCasa);
                pe.Otros = Convert.ToInt32(x.TelefonoOtros);
                pe.mail = x.mail;
                pe.IdEmpresa = x.IdEmpresa;
                x.IdEstado = pe.IdEstado;
                // x.IdFoto =pe.foto;
            }
        }


    }


    
}
