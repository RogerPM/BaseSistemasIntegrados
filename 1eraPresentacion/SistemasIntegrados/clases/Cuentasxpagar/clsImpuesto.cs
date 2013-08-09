using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsImpuesto
    {
         public int IdImpuesto { get; set; }
       public string Descripcion { get; set; }
        public double Porcentaje { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public clsImpuesto()
        {

        }
    }
}
