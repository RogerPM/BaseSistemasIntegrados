using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;
namespace datos.Seguridad
{
    public class datVwUsuarioPermisos
    {
        public List<clsVwUsuarioPermisos> LeerPermisos(int idUsuario)
        {
            try
            {
                List<clsVwUsuarioPermisos> listaPermisos = new List<clsVwUsuarioPermisos>();
                TECAv8Entities ent = new TECAv8Entities();
                var con = from w in ent.UsuariodPermisos where w.IdUsuario==idUsuario select w;
               // var con = from w in ent.UsuarioPermisos select w;
               // var con = from w in ent.UsuarioPermisos select w;
               // var con = from w in ent.UsuarioPermisos select w; 
                foreach (var item in con) //se cae xq es version antigua no tiene sector
                {
                    clsVwUsuarioPermisos p = new clsVwUsuarioPermisos();
                    p.idUsuario = item.IdUsuario;
                    p.nombreUsuario = item.NombreUsuario;
                    p.perfil = item.Descripcion;
                    p.idModulo = item.IdModulo; 
                    p.nombre = item.Nombre;
                    p.nombreFormulario = item.NombreFormulario;
                    p.lectura = item.Lectura;
                    p.escritura = item.Escritura;
                    p.eliminacion = item.Eliminacion;
                    //p.descripcion = item.Descripcion;
                    listaPermisos.Add(p);
                }
                return listaPermisos;
                //var ee = from w in listaEmpresa select w;   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }

    }
}
/*
create view Seguridad.UsuariodPermisos as
SELECT distinct ROW_NUMBER() OVER(ORDER BY Seguridad.Usuario.IdUsuario) AS id,Seguridad.Usuario.IdUsuario, Seguridad.Usuario.NombreUsuario, Seguridad.Perfil.Descripcion, Seguridad.Modulo.IdModulo, Seguridad.Modulo.Nombre, Seguridad.Menu.NombreFormulario, 
                      Seguridad.Permiso.Lectura, Seguridad.Permiso.Escritura, Seguridad.Permiso.Eliminacion
FROM         Seguridad.Perfil INNER JOIN
                      Seguridad.Permiso ON Seguridad.Perfil.IdPerfil = Seguridad.Permiso.IdPerfil INNER JOIN
                      Seguridad.Modulo ON Seguridad.Permiso.IdModulo = Seguridad.Modulo.IdModulo INNER JOIN
                      Seguridad.Menu ON Seguridad.Permiso.IdMenu = Seguridad.Menu.IdMenu AND Seguridad.Modulo.IdModulo = Seguridad.Menu.IdModulo INNER JOIN
                      Seguridad.Usuario ON Seguridad.Perfil.IdPerfil = Seguridad.Usuario.IdPerfil
go    
 
*/
