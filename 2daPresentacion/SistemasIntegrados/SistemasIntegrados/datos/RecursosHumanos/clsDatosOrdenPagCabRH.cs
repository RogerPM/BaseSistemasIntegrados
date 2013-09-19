using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosOrdenPagCabRH
    {
        public Boolean Guardar(clsOrdenPagCabRH o)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    OrdenPagoCab  ord = new OrdenPagoCab ()
                    {
                        NumOrdenPago =o.NumOrdenPago,
                        fechadeEmision =o.FechaEmision ,
                        IdPersona=o.IdPersona ,
                        Estado =o.Estado,
                        TotalPagar =o.TotalPagar ,
                        TipoOrdenPago =Convert .ToString ( o.TipoOrdenPago) ,
                        IdUsuario =o.IdUsuario,
                        IdEmpresa=o.IdEmpresa ,
                        
                    };
                    ent.AddToOrdenPagoCab (ord);
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
                int x = ((from a in ent.OrdenPagoCab  select a.NumOrdenPago ).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        public clsDatosOrdenPagCabRH()
        {

        }
    }
}
