using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public class clsUsuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdEstado { get; set; }
        public int IdImagen { get; set; }
        public int IdPrefil { get; set; }
        public clsUsuario() { }
    }
}
