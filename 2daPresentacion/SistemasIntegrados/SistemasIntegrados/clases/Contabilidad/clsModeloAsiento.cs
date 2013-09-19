using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    class clsModeloAsiento
    {
        public int IdEmpresa { get; set; }
        public int modulo { get; set; }
        public string modulonombre { get; set; }
        public int idTransaccion { get; set; }
        public int secuencia  { get; set; }
        public string descripcion { get; set; }
        public int debe { get; set; }
        public int haber { get; set; }
        public int IdEstado { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaModificacion { get; set; }
        public clsModeloAsiento()
        {
        }
    }
}
