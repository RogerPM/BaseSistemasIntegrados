using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public class clsRptAccesoUsuarios
    {
        public int idHistorial { get; set; }
        public string nombreUsuario { get; set; }
        public string perfil { get; set; }
        public int cantidad { get; set; }
        public DateTime fechUltimoInicio { get; set; }

        public clsRptAccesoUsuarios(){    }
    }
}
