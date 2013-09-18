using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsPeriodoContable
    {

        public int IdEmpresa { get; set; }
        public int IdPeriodoContable { get; set; }
        public int IdAFiscal  { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdEstado { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaModificacion { get; set; }

        public clsPeriodoContable()
        {
        }
    }
}
