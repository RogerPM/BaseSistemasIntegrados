using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsOrdenPagoDet
    {
        public int NumLinea { get; set; }
        public int NumCuentaPorPagar { get; set; }
        public int NumDetalleDeuda { get; set; }
        public Decimal SaldoDeuda { get; set; }
        public int NumeroPagosRealizar { get; set; }
        public int NumOrdenPagoCab { get; set; }
        public Decimal TotalPagar { get; set; }
        public int IdEmpresa { get; set; }
        public bool AutorizarPago { get; set; }
        
        public clsOrdenPagoDet()
        {
        }
    }
}