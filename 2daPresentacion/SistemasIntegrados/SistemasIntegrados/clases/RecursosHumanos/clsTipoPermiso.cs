using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsTipoPermiso
    {
        public int IdTipoPermiso { get; set; }
        public string Descripcion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEstado { get; set; }

        public clsTipoPermiso()
        { 
        
        }
    }
}
