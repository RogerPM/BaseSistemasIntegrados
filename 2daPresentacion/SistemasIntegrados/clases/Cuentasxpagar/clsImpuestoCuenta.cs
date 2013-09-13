using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace clases.Cuentasxpagar
{
    public class clsImpuestoCuenta
    {
        public int _IdImpuesto { get; set; }
        public int _NumCuentaPorPagar { get; set; }
        public decimal _Valor { get; set; }
        public int _IdEmpresa { get; set; }

        public clsImpuestoCuenta()
        {

        }
    }
}
