using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{ 
    public class clsCuentaxCobrar
    {   //cabecera
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idCuentaxCobrar { get; set; }
        public int numero_comprobante { get; set; }
        public int Modulo { get; set; }
        public int idNumeroFactura { get; set; }
        public int TotalCuotas { get; set; }
        public int porcentaje_interes { get; set; }
        public string estado { get; set; } 
    }
}
