using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Facturacion
{
    public class clsFactura
    {
        public int IdEmpresa { get; set; }
        public int cabecera_comprobante { get; set; }
        public int idUsuario { get; set;}
        public int IdNumeroFactura {get; set;}
        public int IdNumeroCotizacion {get; set;}
        public int IdPromocion { get; set; }
        public int IdFormaPago { get; set; }
        public int IdNumeroCliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal ValorEntrada { get; set; }
        public int NumeroCuotaMensual { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal Ice { get; set; }
        public decimal Descuento { get; set; }
        public decimal TotalPagar { get; set; }
        public int idEstado { get; set; }

        public clsFactura()
        {
        }
    }
}
