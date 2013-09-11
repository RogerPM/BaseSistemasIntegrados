using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsConsolidacionPedidoVista
    {
        public int Numero { get; set; }
        public int idTipoArticulo { get; set; }
        public string TipoArticulo { get; set; }
        public DateTime Fecha { get; set; }
        public int idEmpresa { get; set; }  
        public string Empresa { get; set; }
        public int idUsuario { get; set; }
        public string Usuario { get; set; }
        public int idEstado { get; set; }
        public string Estado { get; set; }
        
        public clsConsolidacionPedidoVista()
        {

        }
    
    }
}
