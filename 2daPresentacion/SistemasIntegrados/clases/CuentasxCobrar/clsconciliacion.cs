using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    
    public class clsconciliacion
    {
        public int Idconciliacion { get; set; }
        public string Tipo { get; set; }
        public DateTime fecha { get; set; }
        public int Valor { get; set; }

        public clsconciliacion()
        {
        }
    }
}
