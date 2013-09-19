using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsPersonaCXC
    {
        public int IdPersona { get; set; }
        public decimal  Identificacion { get; set; }
        public int IdTipoPersona { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Apellido { get; set; }
        public DateTime  FechaNacimiento { get; set; }
        public string  genero { get; set; }
        public int TipoIdentificacion { get; set; }
        public string  direccion { get; set; }
        public decimal General { get; set; }
        public decimal Movil { get; set; }
        public decimal Casa { get; set; }
        public decimal Otros { get; set; }
        public string mail { get; set; }
        public int IdEmpresa { get; set; }
        public int IdEstado { get; set; }
        public int  foto { get; set; }
        //public DateTime  HoraEntrada { get; set; }
        //public DateTime  HoraSalida { get; set; }
         public clsPersonaCXC()
        {
            
        }
        
    }
}
