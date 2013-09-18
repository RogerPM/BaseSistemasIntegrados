using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsTerreno
    {
        public int idCodActivoFijo { get; set; }
        public string  direccion { get; set; }
        public string  observacion { get; set; }
        public string CodigoCatrastal { get; set; }
        public double dimenAncho { get; set; }
        public double dimenLargo { get; set; }
        public DateTime fechaLegalizacion { get; set; }


        public clsTerreno()
        {

        }
    }
}
