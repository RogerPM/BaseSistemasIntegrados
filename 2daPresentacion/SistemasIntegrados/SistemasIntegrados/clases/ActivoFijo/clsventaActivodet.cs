using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
   public class clsventaActivodet
    {
       public int idCabecera { get; set; }
       public int IdVentaGarageDet { get; set; }
       public int IdEmpresa { get; set; }
       public double cantidad { get; set; }
       public double ValorUnitario { get; set; }
       public double ValorTotal { get; set; }
       public double SubTotal { get; set; }
       public double Iva { get; set; }
       public double Total { get; set; }
       public int idCabeceracomprobante { get; set; }

        public clsventaActivodet()
        {
            IdEmpresa = 1;

        }
    }
}
