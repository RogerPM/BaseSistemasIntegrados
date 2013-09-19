using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsTomaFisicaDET
    {
        public int? IdEmpresa { get; set; }
        public int? NroTomaFisica { get; set; }
        public int? linea { get; set; }
        public int? IdArticulo { get; set; }
        public int? ExistenciaSistema { get; set; }
        public int? ExistenciaFisica { get; set; }
        public int? CantidadAjustada { get; set; }
        public bool? check { get; set; }
        public DateTime? FechaAjuste { get; set; }

        public clsTomaFisicaDET()
	    {
            FechaAjuste = DateTime.Now;
            check = false;
	    }
    }
}
