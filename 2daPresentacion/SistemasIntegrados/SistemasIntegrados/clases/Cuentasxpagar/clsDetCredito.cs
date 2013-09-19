using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsDetCredito
    {
        private int _IdEmpresa { get; set; }
        private int _NumCuentaPorPagar { get; set; }
        private int _NumDetalleDeuda { get; set; }
        private decimal _ValorLetra { get; set; }
        private DateTime _FechaVencimiento { get; set; }
        private int _Estado { get; set; }

        public clsDetCredito()
        {

        }
    }
}
