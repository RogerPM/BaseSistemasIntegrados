using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace clases.Contabilidad
{
    public class clsRPTEstadoResultado
    {
        public List<clsResultado> lista { get; set; }
        public string Usuario { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime fecha { get; set; }
        public clsRPTEstadoResultado()
        {
            NombreEmpresa = clsVwUsuarioInformacion.razonSocial;
            fecha = DateTime.Now;
            Usuario = clsVwUsuarioInformacion.nombreUsuario;
        }
    }
}
