using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace clases.Inventario
{
    public class clsrptIngreso
    {
        public List<clsIngresoEgresoCAB> listaCab { get; set; }
        public string Empresa { get; set; }
        public string usuario { get; set; }
        public clsrptIngreso()
        {
            Empresa = clsVwUsuarioInformacion.razonSocial;
            usuario = clsVwUsuarioInformacion.nombreUsuario;
        }
    }
}
