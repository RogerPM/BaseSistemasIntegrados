using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsEquipoMaquinariaMebles
    {

        public int idCodActivoFijo { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }
        public int idColor { get; set; }
        public double  carga { get; set; }
        public int AniosDepreciados { get; set; }
        public double DimenAncho { get; set; }
        public double DimenLargo { get; set; }
        public double DimenAlto { get; set; }
        public string  observacion { get; set; }



        public clsEquipoMaquinariaMebles()
        {
            
        }
    }
}
