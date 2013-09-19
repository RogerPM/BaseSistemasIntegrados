using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsConciliacionBancaria
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idConciliacionBancaria { get; set; }
        public int idBanco { get; set; }
        public int NumeroCuenta { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaConciliacion { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public decimal  TotalIngresos { get; set; }
        public decimal TotalEgresos { get; set; }
        public decimal Saldo { get; set; }
        public decimal  TotalConciliacion { get; set; }
        public int idEstado { get; set; }

        public clsConciliacionBancaria()
        {
        }
    }
}
