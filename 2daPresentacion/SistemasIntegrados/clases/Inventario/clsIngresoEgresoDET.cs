using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsIngresoEgresoDET
    {
        public int empresa { get; set; }
        public int nroMovimiento { get; set; }
        public int numero { get; set; }
        public int tipoArticulo { get; set; }
        public int grupo { get; set; }
        public int articulo { get; set; }
        public int percha { get; set; }
        public int cantidadPedida { get; set; }
        public int cantidadLlegada { get; set; }
        public int costo { get; set; }
        public int subTotal { get; set; }
        public int valorIVA { get; set; }
        public int valorTotal { get; set; }
        public clsIngresoEgresoDET() { }
    }
}
