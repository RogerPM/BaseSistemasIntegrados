using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsBodega
    {
        public int empresa { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int capacidadm2 { get; set; }
        public string responsable { get; set; }
        public string percha { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string estado { get; set; }
        public clsBodega() { }

        public int IdBodega { get; set; }
    }
}



