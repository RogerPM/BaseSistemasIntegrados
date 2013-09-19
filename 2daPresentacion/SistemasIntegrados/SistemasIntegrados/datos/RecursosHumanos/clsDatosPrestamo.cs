using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosPrestamo
    {
        public List<clsPrestamo> ConsultPrestamo()
        {
            try
            {
                List<clsPrestamo> Lista = new List<clsPrestamo >();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from p in ent.Prestamo
                          join per in ent.Persona on p.IdPersona equals per.IdPersona
                          where p.IdPersona ==per .IdPersona 
                          select new { 
                                         IdPrestamo=p.IdPrestamo ,
                                         IdPersona=p.IdPersona ,
                                         Cedula=per.Identificacion  ,
                                         Nombre=per .NombreRazonSocial ,
                                         Apellido=per .Apellido ,
                                         Fecha =p.FechaModificacion ,
                                         Monto=p.Monto ,
                                         Pago=p.Pago ,
                                         Interes=p.Interes ,
                                         Total=p.Total ,
                                         Periodos=p.Periodos ,
                                         TotalPagado=p.TotalPagado ,
                                         IdEstado=p.IdEstado ,
                                         IdEmpresa=p.IdEmpresa 
                          };
                foreach (var item in con)
                {
                    clsPrestamo  clas = new clsPrestamo();
                    clas.IdPrestamo = item.IdPrestamo ;
                    clas .IdPersona =item .IdPersona ;
                    clas.Identificacion =Convert .ToInt64 ( item.Cedula);
                    clas.Nombre = item.Nombre;
                    clas.Apellido = item.Apellido;
                    clas .FechaModificacion =Convert .ToDateTime ( item.Fecha);
                    clas .Monto =item .Monto;
                    clas .Pago =item .Pago ;
                    clas .Interes =item.Interes ;
                    clas .Total =item .Total ;
                    clas.Periodos =item .Periodos ;
                    clas.TotalPagado = item.TotalPagado;
                    clas .IdEstado =item .IdEstado ;
                    clas.IdEmpresa = item.IdEmpresa;


                    Lista.Add(clas);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public Decimal  ConsultTotalPagado(int IdPersona)
        {
          
            try
            {
               // List<clsPrestamo> Lista = new List<clsPrestamo>();
                Decimal Totpag=0;
                
                
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
               

                var con = from p in ent.Prestamo
                          where p.IdPersona == IdPersona 
                          select new
                          {
                              
                              TotalPagado = p.TotalPagado,
                             
                          };
                foreach (var item in con)
                {
                    clsPrestamo clas = new clsPrestamo();
                   
                    clas.TotalPagado = item.TotalPagado;
                    
                    Totpag = item.TotalPagado;

                    

                }
                return Totpag ;
            }
            catch (Exception)
            {
                return 0;
            }
        }
       

       
        public Boolean Guardar(clsPrestamo p)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                   Prestamo  pre = new Prestamo()
                    {
                        IdPrestamo  = p.IdPrestamo ,
                        IdPersona = p.IdPersona,
                        FechaModificacion = p.FechaModificacion ,
                        Monto =p.Monto ,
                        Pago =p.Pago ,
                        Interes =p.Interes,
                        Total =p.Total,
                        Periodos =p.Periodos ,
                        TotalPagado =p.TotalPagado ,
                        IdEmpresa = p.IdEmpresa,
                        IdEstado = p.IdEstado,

                    };
                    ent.AddToPrestamo (pre );
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsPrestamo pr)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.Prestamo  where q.IdPrestamo  == pr.IdPrestamo  select q).First();
                x.IdPrestamo  = pr .IdPrestamo ;
                x.IdPersona =pr .IdPersona; 
                x. FechaModificacion = pr.FechaModificacion;
                x.Monto =pr.Monto;
                x.Pago =pr.Pago ;
                x.Interes =pr.Interes;
                x.Total =pr.Total;
                x.Periodos =pr.Periodos ;
                x.TotalPagado =pr.TotalPagado;
                x.IdEmpresa = pr.IdEmpresa;
                x.IdEstado = pr.IdEstado;
                ent.SaveChanges();

            }
        }

        public void ModificarTotalPago(int idper,Decimal tp)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                int   id;
                try
                {

                    var con = from p in ent.Prestamo
                              where p.IdPersona == idper
                              select new{
                                    idpersona=p.IdPersona 
                              };
                    foreach (var item in con)
                {
                    

                    

                }
                  //  if (id != null ){
                        var x = (from q in ent.Prestamo where q.IdPersona == idper select q).First();

                        clsPrestamo pr = new clsPrestamo();

                        x.TotalPagado = tp;

                        ent.SaveChanges();
                    }

                   

                
                catch (Exception)
                {
                    
                    
                }
               

            }
        }

      /*  public Boolean Eliminar(clsContrato cont)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.Contrato where q.NumContrato == cont.NumContrato select q).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }*/

        public int getIdSiguiente()
        {
            try
            {
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int x = ((from a in ent.Prestamo  select a.IdPrestamo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        public clsDatosPrestamo()
        {

        }
    }
}
