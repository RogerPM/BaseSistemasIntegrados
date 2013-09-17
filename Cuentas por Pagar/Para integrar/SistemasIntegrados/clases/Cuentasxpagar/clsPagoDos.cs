using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsPagoDos
    {
        public int NumPago { get; set; }
        public DateTime FechaIngreso { get; set; }
        // public int NumOrdenPago { get; set; }
        public decimal TotalPagar { get; set; }
        public int IdUsuario { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEstado { get; set; }
        public decimal NumComprobante { get; set; }

        public clsPagoDos()
        {

        }
    }
}
