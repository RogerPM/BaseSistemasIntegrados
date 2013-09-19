using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Facturacion
{
    public class clsClienteDefactura
    {
        public int IdEmpresa { get; set; }
        public int idUsuario { get; set; }
        public int IdNumeroCliente { get; set; }
        public int Identificacion { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public int Celular { get; set; }
        public string CorreoElectronico { get; set; }
        public int idEstado { get; set; }
        
        public clsClienteDefactura()
        {

        }
    }
}
