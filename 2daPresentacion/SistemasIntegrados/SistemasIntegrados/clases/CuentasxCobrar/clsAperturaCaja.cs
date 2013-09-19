using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsAperturaCaja
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idAperturaCaja { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public decimal Monto { get; set; }
        public int idEstado { get; set; }

        public clsAperturaCaja()
        {
            
        }
    }
}
