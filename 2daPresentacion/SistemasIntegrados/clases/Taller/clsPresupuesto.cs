using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsPresupuesto
    {
        public int IdPresupuesto { get; set; }
        public int IdPersona { get; set; }
        public string Cliente { get; set; }
        public int IdArticulo { get; set; }
        public string NroPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Combustible { get; set; }
        public string Chasis { get; set; }
        public DateTime Fecha { get; set; }
        public int TotalTiempoTrabajo { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Iva { get; set; }
        public decimal TotalPresupuesto { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }

        public clsPresupuesto()
        {

        }
    }
}
