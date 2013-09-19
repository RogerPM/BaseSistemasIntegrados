using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsContrato
    {

        public int NumContrato { get; set; }
        public int IdPersona { get; set; }
        
        public int IdTipoContrato { get; set; }
        public int IdCargo { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Double  Remuneracion { get; set; }
        public int IdJornada { get; set; }
        public int  PeriodoPrueba { get; set; }
        public int Discapacidad { get; set; }
        public int grado { get; set; }
        public int TipoDiscapacidad { get; set; }
        public int Carnet { get; set; }	
        public int IdEstado { get; set; }
        public int Identificacion { get; set; }
	
        public clsContrato()
        {

        }
    }
}
