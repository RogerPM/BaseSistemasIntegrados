using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsTipoTransaccion
    {

        public int IdTransaccion { get; set; }
        public int modulo { get; set; }
        public string TipoDocumento { get; set; }
        public string descripcion { get; set; }



        public clsTipoTransaccion()
        {
        }
    }
}
