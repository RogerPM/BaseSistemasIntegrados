using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace clases.RecursosHumanos
{
    public class clsMaternidad
    {
        public int NumMaternidad { get; set; }
        public int IdEmpleado { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime FechaParto { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int IdEstado { get; set; }

        public clsMaternidad()
        {
        }

     }
}
