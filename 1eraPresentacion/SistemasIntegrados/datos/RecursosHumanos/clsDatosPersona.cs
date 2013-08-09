using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

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
                    clas.Identificacion = Convert.ToInt32(item.Identificacion);
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.NombreRazonSocial = item.NombreRazonSocial;
                    clas.Apellido = item.Apellido;
                    clas.FechaNacimiento = Convert.ToDateTime(item.FechaNacimiento);
                    clas.Genero = item.genero;
                    clas.TipoIdentificacion = item.TipoIdentificacion;
                    clas.Direccion = item.direccion;
                    clas.TelefonoGneral = Convert.ToInt32(item.TelefonoGneral);
                    clas.TelefonoMovil = Convert.ToInt32(item.TelefonoMovil);
                    clas.TelefonoCasa = Convert.ToInt32(item.TelefonoCasa);
                    clas.TelefonoOtros = Convert.ToInt32(item.TelefonoOtros);
                    clas.Mail = item.mail;
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
                        genero = pe.Genero,
                        TipoIdentificacion = pe.TipoIdentificacion,
                        direccion = pe.Direccion,
                        TelefonoGneral = pe.TelefonoGneral,
                        TelefonoMovil = pe.TelefonoMovil,
                        TelefonoCasa = pe.TelefonoCasa,
                        TelefonoOtros = pe.TelefonoOtros,
                        mail = pe.Mail,
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
                x.genero = pe.Genero;
                x.TipoIdentificacion = pe.TipoIdentificacion;
                x.direccion = pe.Direccion;
                x.TelefonoGneral = pe.TelefonoGneral;
                x.TelefonoMovil = pe.TelefonoMovil;
                x.TelefonoCasa = pe.TelefonoCasa;
                x.TelefonoOtros = pe.TelefonoOtros;
                x.mail = pe.Mail;
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
                pe.Genero = x.genero;
                pe.TipoIdentificacion = x.TipoIdentificacion;
                pe.Direccion = x.direccion;
                pe.TelefonoGneral = Convert.ToInt32(x.TelefonoGneral);
                pe.TelefonoMovil = Convert.ToInt32(x.TelefonoMovil);
                pe.TelefonoCasa = Convert.ToInt32(x.TelefonoCasa);
                pe.TelefonoOtros = Convert.ToInt32(x.TelefonoOtros);
                pe.Mail = x.mail;
                pe.IdEmpresa = x.IdEmpresa;
                x.IdEstado = pe.IdEstado;
                // x.IdFoto =pe.foto;
            }
        }


    }
}
