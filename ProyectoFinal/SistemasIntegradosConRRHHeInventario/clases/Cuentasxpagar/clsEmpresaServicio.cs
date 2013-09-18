using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsEmpresaServicio
    {
        public string  IdEmpresaServicio{get;set;}
        public DateTime fechaRegistro {get;set;}
        public string RazonSocial{get;set;}
        public string Direccion {get;set;}
        public string email {get;set;}
        public string webpage{get;set;}
        public int Estado {get;set;}
        public int IdTipoPersona {get;set;}
        public int IdEmpresa {get;set;}
        public int IdUsuario {get;set;}

        public clsEmpresaServicio()
        {
        }


    }
}
	