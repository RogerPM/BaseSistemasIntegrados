using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsOrdenTrabajoR
    {
        public int IdRepuesto { get; set; }
        public int IdOrdenTrabajo { get; set; }
        public int IdArticulo { get; set; }
        public string DescripcionRepuesto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal TotalRepuesto { get; set; }

        public clsOrdenTrabajoR()
        {
        } 
    }
}
