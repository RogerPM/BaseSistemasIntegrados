using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsCotizacionDetalle_Vista
    {
        public int Numero { get; set; }
        public int linea { get; set; }
        public int Pedido { get; set; }
        public int idTipoArticulo { get; set; }
        public string TipoArticulo { get; set;}
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }

        public clsCotizacionDetalle_Vista()
        {

        }
    }
}
