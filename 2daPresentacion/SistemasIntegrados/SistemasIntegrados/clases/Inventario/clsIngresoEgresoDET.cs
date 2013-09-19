using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsIngresoEgresoDET
    {
        public int? empresa { get; set; }
        public int? nroMovimiento { get; set; }
        public int? numero { get; set; }
        public int? articulo { get; set; }
        public string NombreArticulo { get; set; }
        public int? percha { get; set; }
        public string NombrePercha { get; set; }
        public int? cantidadPedida { get; set; }
        public int? cantidadLlegada { get; set; }
        public int? costo { get; set; }
        public decimal? subTotal { get; set; }
        public decimal? valorIVA { get; set; }
        public decimal? valorTotal { get; set; }
        public clsIngresoEgresoDET() { }
    }
}
