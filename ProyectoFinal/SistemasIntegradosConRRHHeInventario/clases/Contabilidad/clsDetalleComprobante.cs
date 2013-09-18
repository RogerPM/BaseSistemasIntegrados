using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsDetalleComprobante
    {
        public int IdEmpresa { get; set; }
        public decimal linea_comprobante { get; set; }
        public string cuenta { get; set; }
        public decimal debe { get; set; }
        public decimal haber { get; set; }
        public clsDetalleComprobante()
        {
        }
    }
}
