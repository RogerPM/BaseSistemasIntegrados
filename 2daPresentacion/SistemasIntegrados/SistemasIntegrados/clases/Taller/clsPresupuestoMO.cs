using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsPresupuestoMO
    {
        public int IdPresupuestoMO { get; set; }
        public int IdPresupuesto { get; set; }
        public int IdManoObra { get; set; }
        public int IdTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int NroHoras { get; set; }
        public decimal PrecioHora { get; set; }
        public decimal Total { get; set; }
        
        public clsPresupuestoMO()
        {
        } 
    } 
}
