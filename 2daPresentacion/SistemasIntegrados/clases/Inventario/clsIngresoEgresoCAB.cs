using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsIngresoEgresoCAB
    {
        public int empresa { get; set; }
        public int nroMovimiento { get; set; }
        public int tipoMovimiento { get; set; }
        public DateTime fechaMovimiento { get; set; }
        public int ordenCompra { get; set; }
        public int motivo { get; set; }
        public int bodega { get; set; }
        public String Nombrebodega { get; set; }
        public int responsable { get; set; }
        public decimal  totalPagar { get; set; }
        public string observacion { get; set; }
        //public int usuario { get; set; }
        public int estado { get; set; }
        public List<clsIngresoEgresoDET> detalle { get; set; }
        public clsIngresoEgresoCAB() { }
    }
}
