using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsCuentaPorPagarDetalle
    {
        public int _IdEmpresa { get; set; }
        public int _NumCuentaPorPagar { get; set; }
        public int _NumCuentaPorPagarDetalle { get; set; }
        public decimal _ValorLetra { get; set; }
        public DateTime _FechaVencimiento { get; set; }
        public int _Estado { get; set; }
        public int? _numeroPagos { get; set; }
        public decimal? _totalPagar { get; set; }
        public bool? _AutorizarPago { get; set; }

        public clsCuentaPorPagarDetalle()
        {

        }
    }
}
