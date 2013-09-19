using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsAnticipoCabecera
    {
        public int NumAnticipo { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public double Total { get; set; }
        public int Porcentaje { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }
        public string Observacion { get; set; }


        
        public clsAnticipoCabecera()
        {

        }

    }
}