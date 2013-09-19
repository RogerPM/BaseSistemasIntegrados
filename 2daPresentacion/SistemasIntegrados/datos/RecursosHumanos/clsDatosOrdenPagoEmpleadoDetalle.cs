using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosOrdenPagoEmpleadoDetalle
    {
        public Boolean Guardar(clsOrdenPagoEmpleadoDetalle  oe)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    OrdenPagoEmpleadoDet  ordem = new OrdenPagoEmpleadoDet ()
                    {
                        NumOrdenPago = oe.NumOrdenPago ,
                        IdEmpresa =oe.IdEmpresa ,
                        Linea =oe .Linea ,
                        IdPersona=oe.IdPersona ,
                        SueldoTotal =oe .SueldoTotal ,
                        IngresoAdicional =oe .IngresosAdicional ,
                        DescuentoTotal =oe .DescuentoTotal ,
                        PagoNeto =oe .PagoNeto ,
                        AutorizarPago =true ,
                        

                    };
                    ent.AddToOrdenPagoEmpleadoDet (ordem );
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
                int x = ((from a in ent.OrdenPagoEmpleadoDet  select a.Linea ).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
               
                
                return 1; //en caso de que no exista algun registro
            }
        }

        public clsDatosOrdenPagoEmpleadoDetalle()
        {

        }
    }
}
