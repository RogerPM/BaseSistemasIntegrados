using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsArticulo
    {
        public int IdEmpresa { get; set; }
        public int IdArticulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaProduccion { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public int CantidadActual { get; set; }
        public int? IdUnidadMedida { get; set; }
        //public int IdTipoArticulo { get; set; }
        public int IdGrupo { get; set; }
        public int? IdChasis { get; set; }
        public int? IdTipoMotor { get; set; }
        public int? NroPlaca { get; set; }
        public int? IdTipoCombustible { get; set; }
        public int? IdColor { get; set; }
        public int? IdMarca { get; set; }
        public int? IdModelo { get; set; }
        public int? IdTipoMaterial { get; set; }
        public string Observacion { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEstado { get; set; }
    }
}
