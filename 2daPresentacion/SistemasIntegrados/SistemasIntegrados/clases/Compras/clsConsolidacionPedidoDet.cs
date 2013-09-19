using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsConsolidacionPedidoDet
    {

        public int Numero { get; set; }
        public int Id_Empresa { get; set; }
        public int linea { get; set; }
        public int Id_articulo { get; set; }
        public int cantidad { get; set; }


        public clsConsolidacionPedidoDet()
        {

        }
    }
}
