using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsOrdenPagoEmpleadoDetalle
    {
        public int NumOrdenPago { get; set; }
        public int IdEmpresa { get; set; }
        public int Linea { get; set; }
        public int IdPersona { get; set; }
        public Decimal SueldoTotal { get; set; }
        public Decimal IngresosAdicional { get; set; }
        public Decimal DescuentoTotal { get; set; }
        public Decimal PagoNeto { get; set; }

        public clsOrdenPagoEmpleadoDetalle()
        {

        }
    }
}
