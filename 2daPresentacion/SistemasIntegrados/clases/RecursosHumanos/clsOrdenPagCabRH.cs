using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsOrdenPagCabRH
    {
          public int NumOrdenPago { get; set; }
          public DateTime FechaEmision { get; set; }
          public int IdPersona { get; set; }
          public int Estado { get; set; }
          public Decimal TotalPagar { get; set; }
          public Char TipoOrdenPago { get; set; }
          public int IdUsuario { get; set; }
          public int IdEmpresa { get; set; }
   

        public clsOrdenPagCabRH ()
	    {
                
	    }
    }
}
