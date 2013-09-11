using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
   public  class clsOrdenPago
    {
       public int NumOrdenPago { get; set; }
       public DateTime fechadeEmision { get; set; }
       public int IdPersona { get; set; }
       public int IdEstado { get; set; }
       public decimal TotalPagar {get; set;}
       public char TipoOrdenPago {get;set;}
       public int IdUsuario{get;set;}
       public int IdEmpresa {get; set;}

      public clsOrdenPago ()
      {
      }


    }
}
