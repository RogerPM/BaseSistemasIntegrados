using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsCargo
    {
        public int IdCargo { get; set; }
        public string Descripcion { get; set; }
        public double Sueldo { get; set; }
        public int IdEstado { get; set; }

        public clsCargo()
        {

        }
    }
}
