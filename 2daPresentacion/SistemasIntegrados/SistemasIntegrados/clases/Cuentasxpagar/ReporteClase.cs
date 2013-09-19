using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class ReporteClase
    {
        public List<clsPago> pagocab { get; set; }
        public List<clsPagoDetalle> pagodet { get; set; }

        public string NombreEmpresa { get; set; }

        public ReporteClase()
        {

        }
    }
}
