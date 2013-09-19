using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsResultado
    {
        public string Codigo { get; set; }
        public string Cuenta { get; set; }
        public decimal? Saldo { get; set; }

        public clsResultado()
        {
            Saldo = 0;
            Codigo = "";
            Cuenta = "";
        }
    }
}
