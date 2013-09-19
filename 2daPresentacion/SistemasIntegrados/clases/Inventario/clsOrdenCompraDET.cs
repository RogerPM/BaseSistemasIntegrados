using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsOrdenCompraDET
    {
        public int numero { get; set; }
        public int empresa { get; set; }
        public int linea { get; set; }
        public int articulo { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }

        public clsOrdenCompraDET() { }
    }
}
