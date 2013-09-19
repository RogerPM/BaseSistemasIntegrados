using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsPersona
    {
        public int IdPersona { get; set; }
        public Int64  Identificacion { get; set; }
        public int IdTipoPersona { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Apellido { get; set; }
        public DateTime  FechaNacimiento { get; set; }
        public string  genero { get; set; }
        public int TipoIdentificacion { get; set; }
        public string  direccion { get; set; }
        public int General { get; set; }
        public int Movil { get; set; }
        public int Casa { get; set; }
        public int Otros { get; set; }
        public string mail { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEstado { get; set; }
        public int  foto { get; set; }
        //public DateTime  HoraEntrada { get; set; }
        //public DateTime  HoraSalida { get; set; }
         public clsPersona()
        {
            
        }
        
    }
}
