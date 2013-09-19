using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsTomaFisicaCAB
    {
        public int IdEmpresa { get; set; }
        public int NroTomaFisica { get; set; }
        public int IdMotivo { get; set; }
        public DateTime FechaTomaFisica { get; set; }
        public DateTime FechaModificacion { get; set; }
        public decimal Usuario { get; set; }
        public int IdTipoArticulo { get; set; }
        public int IdBodega { get; set; }
        public int IdUsuario { get; set; }
        public string Auditor { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public List<clsTomaFisicaDET> detalle { get; set; }
        public clsTomaFisicaCAB()
        {

        }
	
        

    }
}
