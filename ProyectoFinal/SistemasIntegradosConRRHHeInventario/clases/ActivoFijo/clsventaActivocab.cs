using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
   public class clsventaActivocab
    {
       public int Codigo_SecuventaactivoCab { get; set; }
       public int IdUsuario { get; set; }
       public string NombreCliente { get; set; }
       public string Direccion { get; set; }
       public int Identificador { get; set; }
       public DateTime Fecha { get; set; }
       public DateTime fechaModificacion { get; set; }
       public string Telefono { get; set; }
       public int IdFormaPagoMedioPago { get; set; }
       public double CantidadEfectivo { get; set; }
       public double CantidadTransferencia { get; set; }
       public double CantidadDeposito { get; set; }
       public double CantidadCheque { get; set; }
       public int EstadoProceso { get; set; }

    



       //Estas variables son por el momento hasta que seguridad pase sus datos
       public string _Usuario = "Kenia Landazuri";
       public string _Empresa = "TECA";
    }
}
