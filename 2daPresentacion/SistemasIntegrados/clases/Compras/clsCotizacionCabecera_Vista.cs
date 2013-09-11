using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsCotizacionCabecera_Vista
    {
        public int Numero { get; set; }
        public int idProveedor { get; set; }
        public string Proveedor { get; set; }
        public DateTime Fecha { get; set; }
        public int idEmpresa { get; set; }  
        public string Empresa { get; set; }
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public int idEstado { get; set; }
        public string Estado { get; set; }
        public string Ruta { get; set; }
        public clsCotizacionCabecera_Vista()
        {

        }
    }
}
