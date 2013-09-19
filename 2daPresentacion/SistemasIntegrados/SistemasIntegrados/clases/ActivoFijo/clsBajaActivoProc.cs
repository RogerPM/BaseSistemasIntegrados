using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsBajaActivoProc
    {
        public int codBajaActivo { get; set; }
        public int idActivoFijo { get; set; }
        public DateTime fecha { get; set; }
        //public int idgrupo { get; set; }
        //public int idsubgrupo { get; set; }
        public string estadoproceso { get; set; }
        public int Empresa { get; set; }
        public int IdMotivoBaja { get; set; }
        //public int idProveedor { get; set; }
        //public int IdCabeceraComprobante { get; set; }
        public string descripcion { get; set; }
        public string Observacion { get; set; }
        //public int idImagen { get; set; }

        public string _Usuario = "Kenia Landazuri";
        public string _Empresa = "TECA";



    }
}
