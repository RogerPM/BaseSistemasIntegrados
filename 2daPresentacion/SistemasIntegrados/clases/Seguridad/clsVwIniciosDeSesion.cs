using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public class clsVwIniciosDeSesion
    {
        public int idHistorial { get; set; }
        public int idUsuario { get; set; }
        public string nombreUsuario { get; set; }
        public string descripcion { get; set; }//nombre del perfil q tiene asignado
        public DateTime fechaIS { get; set; }
        
        public clsVwIniciosDeSesion() { }
    }
}
/*
create view Seguridad.IniciosDeSesion as
select h.IdHistorial, h.IdUsuario, u.NombreUsuario, p.Descripcion, h.FechaInicioSesion
from Seguridad.Historial h, Seguridad.Usuario u, Seguridad.Perfil p
where h.IdUsuario=u.IdUsuario
and u.IdPerfil=p.IdPerfil

*/