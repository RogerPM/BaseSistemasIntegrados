using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace clases.RecursosHumanos
{
    public class clsTitulo
    {

        public int IdTitulo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal{ get; set; }
        public int IdEstado { get; set; }
        public int IdUniversidad { get; set; }
        public int IdEmpresa { get; set; }

        public clsTitulo()
        {
        
        }

      

    }
}
