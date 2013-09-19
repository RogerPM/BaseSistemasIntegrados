using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsCierreCaja
    {
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int idCierreCaja { get; set; }
        public DateTime FechaCierre { get; set; }
        public DateTime FechaModificacion { get; set; }
        public decimal MontoApertura { get; set; }
        public decimal TotalDeposito { get; set; }
        public decimal TotalTransferencia { get; set; }
        public decimal TotalCheque { get; set; }
        public decimal TotalBoucher { get; set; }
        public decimal TotalEfectivo { get; set; }
        public decimal TotalRecaudado { get; set; }
        public int idEstado { get; set; }

        public clsCierreCaja()
        {
                
        }

    }
}
