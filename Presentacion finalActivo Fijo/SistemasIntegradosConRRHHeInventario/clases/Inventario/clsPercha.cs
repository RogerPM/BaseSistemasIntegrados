using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsPercha
    {
        public int empresa { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int divisiones { get; set; }
        public string bodega { get; set; }
        public string estado { get; set; }

        public clsPercha() { }
    }
}
