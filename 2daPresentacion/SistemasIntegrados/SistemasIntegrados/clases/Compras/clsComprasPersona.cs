using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsComprasPersona
    {
        public int IdPersona { get; set; }
        public string Identificacion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoPersona { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string genero { get; set; }
        public int TipoIdentificacion { get; set; }
        public string direccion { get; set; }
        public int General { get; set; }
        public int Movil { get; set; }
        public int Casa { get; set; }
        public int Otros { get; set; }
        public string mail { get; set; }
        public int IdEstado { get; set; }


        public clsComprasPersona()
        {

        }

    }
}