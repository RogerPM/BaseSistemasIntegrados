using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datVwUsuarioInformacion
    {

        public bool ValidarCredenciales(string nick, string empresa, string pass)
        {
            //clsVwUsuarioInformacion user = new clsVwUsuarioInformacion();
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var con = (from w in ent.UsuarioInformacion where w.NombreUsuario == nick && w.NombreComercial == empresa select w).First();

                clsVwUsuarioInformacion.idUsuario = con.IdUsuario;
                clsVwUsuarioInformacion.nombreUsuario = con.NombreUsuario;
                clsVwUsuarioInformacion.contrasena = con.Contrasena;
                clsVwUsuarioInformacion.idEstado = Convert.ToInt32(con.IdEstado);
                clsVwUsuarioInformacion.descripcion = con.Descripcion;
                clsVwUsuarioInformacion.idEmpresa = con.IdEmpresa;
                clsVwUsuarioInformacion.nombreComercial = con.NombreComercial;
                clsVwUsuarioInformacion.razonSocial = con.RazonSocial;
                clsVwUsuarioInformacion.ruc = con.Ruc;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error datVwUsuarioInformacion: " + ex);
                return false;
            }
        }


    }
}
/*
create view Seguridad.UsuarioInformacion as
SELECT distinct usu.IdUsuario, usu.NombreUsuario, usu.Contrasena, usu.IdEstado, est.Descripcion, emp.IdEmpresa, emp.NombreComercial,
					emp.RazonSocial, emp.Ruc
FROM Seguridad.Usuario usu, Seguridad.Empresa emp, Seguridad.UsuarioPorEmpresa uxe, Seguridad.Estado est
WHERE uxe.IdEmpresa = emp.IdEmpresa
AND uxe.IdUsuario = usu.IdUsuario
AND usu.IdEstado = est.IdEstado
go


*/