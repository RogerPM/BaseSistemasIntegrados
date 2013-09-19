using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsLiquidacion
    {
        public int IdLiquidacion { get; set; }
        public int IdOrdenTrabajo { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string NroPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEntrega { get; set; }     
        public decimal TotalTrabajos { get; set; }
        public decimal TotalRepuestos { get; set; }
        public decimal TotalOtros { get; set; }
        public decimal TotalPagar { get; set; }
        public int IdFormaPago { get; set; }
        public int? NumeroCuotaMensual { get; set; }
        public decimal? CuotaMensual { get; set; }
        public DateTime FechaInicialPago { get; set; }
        public DateTime FechaFinalPago { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }

        public clsLiquidacion()
        {

        }
    }
}
