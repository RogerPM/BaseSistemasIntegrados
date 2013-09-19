using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsOrdenPagoEmpleadoDet
    {
        public int NumOrdenPago { get; set; }
        public int IdEmpresa { get; set; }
        public bool AutorizarPago { get; set; }
        public int Linea { get; set; }
        public int IdPersona { get; set; }
        public decimal SueldoTotal { get; set; }
        public decimal IngresoAdicional { get; set; }
        public decimal DescuentoTotal { get; set; }
        public decimal PagoNeto { get; set; }

        public clsOrdenPagoEmpleadoDet()
        {
        }
    }
}
