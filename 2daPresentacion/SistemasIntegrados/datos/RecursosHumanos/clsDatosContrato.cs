using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases .RecursosHumanos;


namespace datos.RecursosHumanos
{
    public class clsDatosContrato
    {
        
        public List<clsContrato>ConsultContrato()
        {
            try
            {
                List<clsContrato> Lista = new List<clsContrato>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.Contrato  select w;
                foreach (var item in con)
                {
                    clsContrato  clas = new clsContrato();
                    clas .NumContrato =item .NumContrato ;
                    clas .IdPersona =item .IdPersona;
                    clas.IdTipoContrato=item .IdTipoContrato;
                    clas.IdCargo =item .IdCargo;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas .Fecha =item .Fecha ;
                    clas .FechaModificacion =Convert .ToDateTime ( item .FechaModificacion) ;
                    clas .Remuneracion =Convert .ToDouble  ( item .Remuneracion );
                    clas .IdJornada =item.IdJornada ;
                    clas .PeriodoPrueba  =Convert .ToInt32 ( item .PeriodoPrueba)  ;
                    clas .Discapacidad   =Convert .ToInt32 ( item .Discapacidad )  ;
                    clas.grado =Convert .ToInt32  (item.grado );
                    clas.TipoDiscapacidad =Convert .ToInt32 ( item .TipoDiscapacidad) ;
                    clas.Carnet =Convert .ToInt32 (item .Carnet );
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
        public int  ConsultContratoIdentificacion(int persona)
        {
            try
            {
                List<clsPersona > Lista = new List<clsPersona >();
                
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int Ident=0;
                var con = from p in ent.Persona
                          where p.IdPersona == persona
                          select p;
                foreach (var item in con)
                {
                    
                    Ident  = Convert.ToInt32(item.Identificacion);
                    
                }
                return Ident ;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public String  ConsultContratoNombre(int persona)
        {
            try
            {
                

                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                String nombre="";
                var con = from p in ent.Persona
                          where p.IdPersona == persona
                          select p;
                foreach (var item in con)
                {
                    
                    nombre  = item.NombreRazonSocial;
                   
                }
                return nombre ;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public String ConsultContratoApellido(int persona)
        {
            try
            {


                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                String apellido = "";
                var con = from p in ent.Persona
                          where p.IdPersona == persona
                          select p;
                foreach (var item in con)
                {

                    apellido  = item.Apellido ;

                }
                return apellido ;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DateTime  ConsultContratoFecha(int persona)
        {
            try
            {


                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                DateTime fecha = DateTime.Now;
                var con = from p in ent.Persona
                          where p.IdPersona == persona
                          select p;
                foreach (var item in con)
                {

                    fecha = Convert.ToDateTime(item.FechaNacimiento);

                }
                return fecha;
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }

        public string  ConsultaContratoGenero(int persona)
        {
            try
            {


                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                string  gen = "";
                var con = from p in ent.Persona
                          where p.IdPersona == persona
                          select p;
                foreach (var item in con)
                {

                    gen  = item .genero ;

                }
                return gen;
            }
            catch (Exception)
            {
                return null;
            }
        }
       
        public Boolean Guardar(clsContrato c)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    Contrato  con = new Contrato ()
                    {
                        NumContrato = c.NumContrato ,
                        IdPersona=c.IdPersona,
                        IdTipoContrato =c.IdTipoContrato ,
                        IdEmpresa= c.IdEmpresa,
                        IdCargo =c.IdCargo,
                        Fecha =c.Fecha ,
                        FechaModificacion =c.FechaModificacion ,
                        Remuneracion =Convert .ToDecimal  (c.Remuneracion) ,
                        IdJornada =c.IdJornada,
                        PeriodoPrueba =Convert .ToBoolean ( c.PeriodoPrueba),
                        Discapacidad =Convert.ToBoolean (  c.Discapacidad),
                        grado =c.grado,
                        TipoDiscapacidad =c.TipoDiscapacidad,
                        Carnet =c.Carnet ,
                        IdEstado=c.IdEstado,


	

                    };
                    ent.AddToContrato(con ) ;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsContrato co)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.Contrato  where q.NumContrato  == co.NumContrato  select q).First();
                        x.NumContrato = co.NumContrato;
                        x.IdPersona=co.IdPersona;
                        x.IdTipoContrato =co.IdTipoContrato;
                        x.IdCargo = co.IdCargo;
                        x.IdEmpresa= co.IdEmpresa;
                        x.Fecha =co.Fecha;
                        x.FechaModificacion =co.FechaModificacion;
                        x.Remuneracion =Convert .ToDecimal  (co.Remuneracion);
                        x.IdJornada =co.IdJornada;
                        x.PeriodoPrueba =Convert .ToBoolean ( co.PeriodoPrueba);
                        x.Discapacidad =Convert.ToBoolean (  co.Discapacidad);
                        x.grado =co.grado;
                        x.TipoDiscapacidad =co.TipoDiscapacidad;
                        x.Carnet =co.Carnet;
                        x.IdEstado = co.IdEstado;
               

                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsContrato  cont)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Contrato  where q.NumContrato  == cont.NumContrato  select q).First();
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
                int x = ((from a in ent.Contrato  select a.NumContrato ).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public clsDatosContrato()
        {

        }
    }
}
