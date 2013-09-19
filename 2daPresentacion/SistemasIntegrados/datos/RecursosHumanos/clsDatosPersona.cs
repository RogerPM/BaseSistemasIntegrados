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


        public List<clsPersona> ConsultaPersona1(int band)
        {
            try
            {
                
                List<clsPersona> Lista = new List<clsPersona>();
                RecursosHumanosEntities  ent = new RecursosHumanosEntities ();
               
                if (band == 1) {
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
                }else 
                    {
                        if (band == 2)
                        {
                            var con = from p in ent.Persona
                                      join c in ent.Contrato on p.IdPersona equals c.IdPersona
                                      where p.IdPersona == c.IdPersona
                                      select new
                                      {
                                          IdPersona = p.IdPersona,
                                          Identificacion = p.Identificacion,
                                          IdEmpresa = p.IdEmpresa,
                                          IdTipoPersona = p.IdTipoPersona,
                                          NombreRazonSocial = p.NombreRazonSocial,
                                          Apellido = p.Apellido,
                                          FechaNacimiento = p.FechaNacimiento,
                                          genero = p.genero,
                                          TipoIdentificacion = p.TipoIdentificacion,
                                          direccion = p.direccion,
                                          General = p.TelefonoGneral,
                                          Movil = p.TelefonoMovil,
                                          Casa = p.TelefonoCasa,
                                          Otros = p.TelefonoOtros,
                                          mail = p.mail,
                                          IdEstado = p.IdEstado,
                                      };

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
                                clas.General = Convert.ToInt32(item.General);
                                clas.Movil = Convert.ToInt32(item.Movil);
                                clas.Casa = Convert.ToInt32(item.Casa);
                                clas.Otros = Convert.ToInt32(item.Otros);
                                clas.mail = item.mail;
                                clas.IdEstado = item.IdEstado;
                                Lista.Add(clas);

                            }
                        }
                        
                } 
              
                
                   
                
              
               
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<clsPersona> ConsultaPersona()
        {
            try
            {
                List<clsPersona> Lista = new List<clsPersona>();
                RecursosHumanosEntities  ent = new RecursosHumanosEntities ();

              
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

                var x = (from q in ent.Persona   where q.IdPersona   == pe.IdPersona   select q).First();
                x.IdPersona = pe.IdPersona;
                x.Identificacion =pe.Identificacion ;
                x.IdTipoPersona =pe.IdTipoPersona ;
                x.NombreRazonSocial =pe.NombreRazonSocial ;
                x.Apellido =pe.Apellido ;
                x.FechaNacimiento =pe.FechaNacimiento ;
                x.genero =pe.genero ;
                x.TipoIdentificacion =pe.TipoIdentificacion ;
                x.direccion =pe.direccion ;
                x.TelefonoGneral =pe.General ;
                x.TelefonoMovil =pe.Movil ;
                x.TelefonoCasa =pe.Casa ;
                x.TelefonoOtros =pe.Otros ;
                x.mail =pe.mail ;
               // x.IdEmpresa =pe.IdEmpresa ;
                x.IdEstado =pe.IdEstado ;
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
                var x = (from q in ent.Persona where q.IdPersona   == pe.IdPersona   select q).First();
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
                RecursosHumanosEntities  ent = new RecursosHumanosEntities ();
                int x = ((from a in ent.Persona  select a.IdPersona ).Max()) + 1;
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
