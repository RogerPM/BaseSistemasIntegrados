using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsPersona
    {
        public int IdPersona { get; set; }
        public int Identificacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoPersona { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Direccion { get; set; }
        public int TelefonoGneral { get; set; }
        public int TelefonoMovil { get; set; }
        public int TelefonoCasa { get; set; }
        public int TelefonoOtros { get; set; }
        public string Mail { get; set; }
        public int IdEstado { get; set; }
        public int Foto { get; set; }


        public clsPersona() 
        { 
        
        }

    }
}
