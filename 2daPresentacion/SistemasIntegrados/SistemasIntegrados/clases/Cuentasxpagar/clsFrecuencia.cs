using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsFrecuencia
    {
        public int _IdEmpresa { get; set; }
        public int _IdFrecuenciaPago { get; set; }
        public string _Descripcion { get; set; }
        public DateTime _FechaActual { get; set; }
        public int _Estado { get; set; }
        public int _IdUsuario { get; set; }

        public clsFrecuencia()
        {

        }
    }
}
