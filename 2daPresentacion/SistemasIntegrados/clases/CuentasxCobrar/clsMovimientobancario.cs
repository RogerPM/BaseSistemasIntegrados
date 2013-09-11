using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsMovimientobancario
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idMovimientoBancario { get; set; }
        public int idTransaccion { get; set; }
        public int idBanco { get; set; }
        public int NumeroDocumento { get; set; }
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public decimal Valor { get; set; }
        public int idEstado { get; set; }


        public clsMovimientobancario()
        {
        }
    }
}
