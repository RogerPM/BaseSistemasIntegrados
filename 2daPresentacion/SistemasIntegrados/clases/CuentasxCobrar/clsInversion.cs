using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsInversion
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idInversion { get; set; }
        public int idEntidad { get; set; }
        public int idTipoInversion { get; set; }
        public int Tiempo { get; set; }
        public int idUnidadTiempo { get; set; }
        public int idBanco { get; set; }            
        public decimal Valor { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal Ganancia { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string idEstado { get; set; }

        public clsInversion()
        {
        }

    }
}
