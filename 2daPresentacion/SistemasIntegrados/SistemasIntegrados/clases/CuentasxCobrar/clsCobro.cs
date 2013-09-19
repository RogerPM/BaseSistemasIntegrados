using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsCobro
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idCobro { get; set; }
        public int idCuentaxCobrar { get; set; }
        public int idCabeceraComprobante { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public int NumeroCuota { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal Interes { get; set; }
        public decimal Mora { get; set; } 
        public decimal ValorPagado { get; set; }
        public decimal Saldo { get; set; }
        public string idEstado { get; set; }
    }
}
