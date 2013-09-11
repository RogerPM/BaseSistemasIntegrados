using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsOrdenPagoDetalle
    {
        public int NumLinea { get; set; }
        public int NumCuentaPorPagar { get; set; }
        public int NumDetalleDeuda { get; set; }
        public decimal SaldoDeuda { get; set; }
        public int NumeroPagosRealizar { get; set; }
        public int NumOrdenCab { get; set; }
        public decimal TotalPagar { get; set; }
        public int IdEmpresa { get; set; }
  
        public clsOrdenPagoDetalle()
        {

        }

    }
}
