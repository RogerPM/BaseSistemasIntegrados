using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsCuentaPorPagar
    {
        public int _NumCuentaPorPagar { get; set; }
        public int _NumIngresoEgreso { get; set; }
        public DateTime _FechaIngreso { get; set; }
        public string _Factura { get; set; }
        public DateTime _FechaTransaccion { get; set; }
        public int _IdProveedor { get; set; }
        public string _IdEmpresaServicio { get; set; }
        public string _Motivo { get; set; }
        public string _Detalle { get; set; }
        public decimal _Subtotal { get; set; }
        public decimal _Descuento { get; set; }
        public decimal _Total { get; set; }
        public string _FormaPago { get; set; }
        public decimal _ValorEntrada { get; set; }
        public int _NumeroLetra { get; set; }
        public int _IdFrecuencia { get; set; }
        public decimal _ValorLetra { get; set; }
        public decimal _SaldoDeuda { get; set; }
        public int _IdUsuario { get; set; }
        public int _IdEmpresa { get; set; }
        public List<clsDetCredito> _DetCredito { get; set; }
        public List<clsImpuestoCuenta> _ImpuestoCuenta { get; set; }

        public clsCuentaPorPagar()
        {

        }
    }
}
