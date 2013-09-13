using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsImpuestos
    {
        public DateTime FechaRegistro { get; set; }
        public int IdImpuesto { get; set; }
        public string Descripcion { get; set; }
        public decimal Porcentaje { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }

        public clsImpuestos()
        {

        }
    }
}
