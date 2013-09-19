using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    class clsTomaFisica
    {
        public int? IdEmpresa { get; set; }
        public int? IdArticuloBodega { get; set; }
        public int? IdArticulo { get; set; }
        public int? IdPercha { get; set; }
        public int? Cantidad { get; set; }
        public bool? existencia { get; set; }


        public clsTomaFisica()
        {

        }
    }
}
