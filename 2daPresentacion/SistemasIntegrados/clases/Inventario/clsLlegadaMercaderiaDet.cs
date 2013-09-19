using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsLlegadaMercaderiaDet
    {
        public int? IdEmpresa { get; set; }
        public int? NroMovimiento { get; set; }
        public int? numero { get; set; }
        public int? IdArticulo { get; set; }
        public string Articulo { get; set; }
        public int? IdPercha { get; set; }
        public string Percha { get; set; }
        public int? CantidadPedida { get; set; }
        public int? CantidadLlegada { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? ValorIVA { get; set; }
        public decimal? ValorTotal { get; set; }

        public clsLlegadaMercaderiaDet ()	{}
	
    }
}
