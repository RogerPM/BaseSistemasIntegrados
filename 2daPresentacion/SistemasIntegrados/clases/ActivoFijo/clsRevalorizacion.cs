using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsRevalorizacion
    {
        public int Codigo { get; set; }
        public int usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int _idActivoFijo { get; set; }
        public double valorActual { get; set; }
        public double valorRevalorizado { get; set; }
        public double valorResidual { get; set; }
        public string nomActivo { get; set; }

    }
}
