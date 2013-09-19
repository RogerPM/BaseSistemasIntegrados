using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{   //detalle cuenta por cobrar
    public class clsCuentaxCobrarDet
    {
        public int idCuentaxCobrar { get; set; }
        public int Numero { get; set; }
        public int numero_cuota { get; set; }
        public decimal valor_cuota { get; set; }
        public decimal valor_interes { get; set; }
        public decimal valor_mora { get; set; }
        public DateTime fecha_cobro { get; set; }
        public DateTime fecha_vencimiento { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string estado { get; set; }
    }
}
