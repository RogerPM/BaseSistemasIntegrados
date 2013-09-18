using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsEdificio
    {
        public int idCodActivoFijo { get; set; }
        public DateTime fechaConstruccion { get; set; }
        public string  codCatrastal { get; set; }
        public int NumPisos { get; set; }
        public int AniosDepreciados { get; set; }
        public string  ubicacion { get; set; }
        public double DimenAncho { get; set; }
        public double DimenLargo { get; set; }
        public string observacion { get; set; }

        public clsEdificio()
        {

        }
    }
}
