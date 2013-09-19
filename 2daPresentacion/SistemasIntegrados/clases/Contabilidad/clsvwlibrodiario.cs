using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsvwlibrodiario
    {
        public int IdEmpresa { get; set; }
        public decimal numero_comprobante { get; set; }
        public DateTime fecha { get; set; }
        public string glosa { get; set; }
        public int cuenta { get; set; }
        public string nombre { get; set; }
        public int? tipoTransaccion { get; set; }
        public string nombreModulo { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }

        public clsvwlibrodiario()
        {

        }
    }
}
