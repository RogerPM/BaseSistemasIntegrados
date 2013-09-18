using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsBajaActivo
    {
        public int       Codigo { get; set; }
        public int       ActivoFIjo { get; set; }
        public int       Grupo { get; set; }
        public int       Subgrupo { get; set; }
        public DateTime  Fecha { get; set; }
        public int       IdEstado { get; set; }
        public int       IdEmpresa { get; set; }
        public string    Descripcion { get; set; }
        public int    Motivo { get; set; }
        public int       Proveedor { get; set; }
        public int IdCabeceraComprobante { get; set; }
        public string    Observacion { get; set; }
        
        


        public clsBajaActivo()
        {

        }


    }
}
