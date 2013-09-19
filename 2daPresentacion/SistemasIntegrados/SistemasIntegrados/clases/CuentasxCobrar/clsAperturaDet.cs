using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsAperturaDet
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idAperturaCaja { get; set; }
        public int Numero { get; set; }
        public int Denominacion { get; set; }
        public int Cantidad { get; set; }
        public int idEstado { get; set; }

        public clsAperturaDet()
        {
            
        }
    }
}
