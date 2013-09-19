using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsCobroDet
    {
        public int idCobro { get; set; }
        public int numero { get; set; }
        public int idBanco { get; set; }
        public int idMedioPago { get; set; }
        public decimal Valor { get; set; }
        public int NumeroDocumento { get; set; }
        public string Observacion { get; set; }
        public string idEstado { get; set; }
        public int idEmpresa { get; set; }
    }
}
