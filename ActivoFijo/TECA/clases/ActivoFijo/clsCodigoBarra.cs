using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsCodigoBarra
    {
        public int Codigo { get; set; }
        public decimal ancho { get; set; }
        public decimal alto { get; set; }
        public DateTime  fecha { get; set; }
        public DateTime  fecha_seteoDesde { get; set; }
        public DateTime  fecha_seteoHasta { get; set; }
        public decimal   margen_superior { get; set; }
        public decimal   margen_inferior { get; set; }
        public bool      sentido_Lectura { get; set; }
        public int Idformato { get; set; }
        public int IdImagen { get; set; }
        
	   

        public clsCodigoBarra ()
	    {

	    }

    }
}
