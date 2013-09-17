using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsEmpresaServicio
    {
        public string _IdEmpresaServicio { get; set; }
        public DateTime _FechaRegistro { get; set; }
        public string _RazonSocial { get; set; }
        public string _Direccion { get; set; }
        public string _Email { get; set; }
        public string _Website { get; set; }
        public int _Estado { get; set; }
        public int _TipoPersona { get; set; }
        public int _IdEmpresa { get; set; }
        public int _IdUsuario { get; set; }
        
        public List<clsDetalleTelefonoCXP> _DetalleTelefono { get; set; }
        public List<clsCtaBancaria2> _CuentaBancaria { get; set; }

        public clsEmpresaServicio()
        {

        }

       
    }
}