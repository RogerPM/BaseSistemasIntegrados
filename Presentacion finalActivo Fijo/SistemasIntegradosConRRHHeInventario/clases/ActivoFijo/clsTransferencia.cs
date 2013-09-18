using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsTransferencia
    {
        public int codTransferencia { get; set; }
        public int idActivoFijo { get; set; }
        public DateTime fecha { get; set; }
        public int EmpresaFutura { get; set; }
        public int ResponsableFuturo { get; set; }
        public int BodegaFuturo { get; set; }
        public int Departamento { get; set; }
        public string Observaciones { get; set; }
        public string estadoproceso { get; set; }
        //Estas variables son por el momento hasta que seguridad pase sus datos
        public string _Usuario = "Kenia Landazuri";
        public string _Empresa = "TECA";

        public clsTransferencia()
        {


        }


    }
}
