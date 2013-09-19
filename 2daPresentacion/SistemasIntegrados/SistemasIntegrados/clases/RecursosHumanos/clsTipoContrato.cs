using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsTipoContrato
    {
        public int IdTipoContrato { get; set; }
        public string Descripcion { get; set; }
        public string Periodo { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEstado { get; set; }

        public clsTipoContrato()
        {

        }
    }
}
