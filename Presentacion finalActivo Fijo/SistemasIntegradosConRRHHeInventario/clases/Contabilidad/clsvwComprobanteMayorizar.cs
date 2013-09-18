using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsvwComprobanteMayorizar
    {
        public int IdEmpresa { get; set; }
        public decimal numero_comprobante { get; set; }
        public DateTime fecha { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }
        public string glosa { get; set; }
        public bool check { get; set; }
        public clsvwComprobanteMayorizar()
        {

        }
    }
}
