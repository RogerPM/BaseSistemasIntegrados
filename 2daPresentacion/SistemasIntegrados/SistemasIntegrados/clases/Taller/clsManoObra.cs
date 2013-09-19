using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsManoObra
    {
        public int IdManoObra { get; set; }
        public int IdTipoTrabajo { get; set; }
        public string Descripcion { get; set; }
        public int NroHoras { get; set; }
        public decimal PrecioHora { get; set; }
        public decimal Total { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }

        public clsManoObra()
        {

        }
    }
    
}
