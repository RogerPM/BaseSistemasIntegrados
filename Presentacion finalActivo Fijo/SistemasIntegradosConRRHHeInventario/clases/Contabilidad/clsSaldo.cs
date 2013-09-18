using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsSaldo
    {
        public int IdEmpresa { get; set; }
        public string cuenta { get; set; }
        public DateTime fecha { get; set; }
        public decimal saldo_deudor { get; set; }
        public decimal saldo_acreedor { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaModificacion { get; set; }

        public clsSaldo()
        {

        }
    }
}
