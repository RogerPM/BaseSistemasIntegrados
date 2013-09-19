using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsOrdenTrabajo
    {
        public int IdOrdenTrabajo { get; set; }
        public int IdPresupuesto { get; set; }
        public int IdPersona { get; set; }
        public string Cliente { get; set; }
        public int IdArticulo { get; set; }
        public string NroPlaca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Chasis { get; set; }
        public int Kilometraje { get; set; }
        public string Combustible { get; set; }
        public int Deposito { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime InicioReparacion { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal IvaTrabajos { get; set; }
        public decimal TotalTrabajos { get; set; }
        public decimal IvaRepuestos { get; set; }
        public decimal TotalRepuestos { get; set; }
        public decimal IvaOtros { get; set; }
        public decimal TotalOtros { get; set; }
        public string Observacion { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }

        public clsOrdenTrabajo()
        {

        }
    }
}
