using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsGridDepreciacion
    {
        public int  Periodo { get; set; }
        public double   DepreciacionAnual { get; set; }
        public double  DepreciacionAcumulada { get; set; }
        public double total { get; set; }

        public DateTime _Perido { get; set; }
         


        public clsGridDepreciacion()
        {

        }
    }
}
