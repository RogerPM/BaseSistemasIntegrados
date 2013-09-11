using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public class clsVwUsuarioPermisos
    {
        public int idUsuario { get; set; } //usuario q inicio sesion
        public string nombreUsuario { get; set; } //q inicio sesion
        public string perfil { get; set; } //nombre del perfil
        public int idModulo { get; set; } // modulo q ingreso
        public string nombre { get; set; } //nombre del modulo
        public string nombreFormulario { get; set; } //nombre del frm
        public bool lectura { get; set; } //permiso 1 o 0
        public bool escritura { get; set; }
        public bool eliminacion { get; set; }
        public string descripcion { get; set; } //del estado del usuario

        public clsVwUsuarioPermisos() { }
    }
}

/*
 * transact SQL
 *  use TECA
 *  go
create view Seguridad.UsuarioPermisos as
SELECT Seguridad.Usuario.IdUsuario, Seguridad.Usuario.NombreUsuario, Seguridad.Perfil.Descripcion, Seguridad.Modulo.IdModulo, Seguridad.Modulo.Nombre, Seguridad.Menu.NombreFormulario, 
                      Seguridad.Permiso.Lectura, Seguridad.Permiso.Escritura, Seguridad.Permiso.Eliminacion
FROM         Seguridad.Perfil INNER JOIN
                      Seguridad.Permiso ON Seguridad.Perfil.IdPerfil = Seguridad.Permiso.IdPerfil INNER JOIN
                      Seguridad.Modulo ON Seguridad.Permiso.IdModulo = Seguridad.Modulo.IdModulo INNER JOIN
                      Seguridad.Menu ON Seguridad.Permiso.IdMenu = Seguridad.Menu.IdMenu AND Seguridad.Modulo.IdModulo = Seguridad.Menu.IdModulo INNER JOIN
                      Seguridad.Usuario ON Seguridad.Perfil.IdPerfil = Seguridad.Usuario.IdPerfil


 * 
 */
