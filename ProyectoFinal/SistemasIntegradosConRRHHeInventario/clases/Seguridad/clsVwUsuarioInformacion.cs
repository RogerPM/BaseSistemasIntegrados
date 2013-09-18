using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public static class clsVwUsuarioInformacion
    {
        public static int idUsuario { get; set; }
        public static string nombreUsuario { get; set; }
        public static string contrasena { get; set; }
        public static int idEstado { get; set; }
        public static string descripcion { get; set; }
        public static int idEmpresa { get; set; }
        public static string nombreComercial { get; set; }
        public static string razonSocial { get; set; }
        public static string ruc { get; set; }

       //public clsVwUsuarioInformacion() { }
    }
}

/*
use TECA
go
create view Seguridad.UsuarioInformacion as
SELECT distinct usu.IdUsuario, usu.NombreUsuario, usu.Contrasena, usu.IdEstado, est.Descripcion, emp.IdEmpresa, emp.NombreComercial,
					emp.RazonSocial, emp.Ruc
FROM Seguridad.Usuario usu, Seguridad.Empresa emp, Seguridad.UsuarioPorEmpresa uxe, Seguridad.Estado est
WHERE uxe.IdEmpresa = emp.IdEmpresa
AND uxe.IdUsuario = usu.IdUsuario
AND usu.IdEstado = est.IdEstado
go

*/