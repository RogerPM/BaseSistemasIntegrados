using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsCabeceraComprobante
    {
        public int IdEmpresa { get; set; }
        public decimal numero_comprobante { get; set; }
        public DateTime fecha { get; set; }
        public string glosa { get; set; }
        public decimal periodo_contable { get; set; }
        public decimal periodo_contable_IdAFiscal { get; set; }
        public int IdUsuario { get; set; }
        public int? TipoTransaccion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public List<clsDetalleComprobante> Detalle { get; set; }
        public clsCabeceraComprobante()
        {
        }
    }
}
