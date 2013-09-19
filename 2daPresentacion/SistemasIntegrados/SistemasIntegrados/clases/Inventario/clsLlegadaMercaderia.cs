using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsLlegadaMercaderia
    {
        public int? IdEmpresa { get; set; }
        public int? NroMovimiento { get; set; }
        public int? IdTipoMovimiento { get; set; }
        public int? IdOrdenCompra { get; set; }
        public int? IdProveedor { get; set; }
        public decimal? Factura { get; set; }
        public DateTime? FechaMovimiento { get; set; }
        public int? IdMotivo { get; set; }
        public int? IdBodega { get; set; }
        public int? IdResponsable { get; set; }
        public string Observacion { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEstado { get; set; }
        public List<clsLlegadaMercaderiaDet> detalle { get; set; }
        public clsLlegadaMercaderia ()	
        {	
        }
	
    }
}
