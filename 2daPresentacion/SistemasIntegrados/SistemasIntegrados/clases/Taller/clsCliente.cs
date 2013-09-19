using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Taller
{
    public class clsCliente
    {
        public int IdPersona { get; set; }
        public string Identificacion { get; set; }
        public int IdTipoPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int TipoIdentificacion { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public int idEstado { get; set; }
        public int idEmpresa { get; set; }

        public clsCliente()
        {

        }
    }
}
