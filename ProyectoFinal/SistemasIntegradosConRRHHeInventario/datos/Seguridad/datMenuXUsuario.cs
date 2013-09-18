using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.TECAv8Entities;

namespace datos.Seguridad
{
    public class datMenuXUsuario
    {
        public List<clsMenuXUsuario> ConsultaGeneral(int IdEmpresa, string NombreUsuario, string Contrasenia)
        {
            try
            {
                List<clsMenuXUsuario> Lst = new List<clsMenuXUsuario>();
                TECAv8Entities oEnti = new TECAv8Entities();
                var Query = from q in oEnti.Menu_X_Usuario
                            where q.IdEmpresa == IdEmpresa && q.NombreUsuario == NombreUsuario && q.Contrasena == Contrasenia
                            select q;
                foreach (var item in Query)
                {
                    clsMenuXUsuario Obj = new clsMenuXUsuario();
                    Obj.IdEmpresa = item.IdEmpresa;
                    Obj.NombreUsuario = item.NombreUsuario;
                    Obj.Contrasena = item.Contrasena;
                    Obj.IdMenu = item.IdMenu;
                    Obj.IdModulo = item.IdModulo;
                    Obj.IdPadre = item.IdPadre;
                    Obj.Descripcion = item.Descripcion;
                    Obj.NombreFormulario = item.NombreFormulario;
                    Obj.NombreAssembly = item.NombreAssembly;
                    Obj.IdEstado = item.IdEstado;
                    Obj.IdPerfil = item.IdPerfil;
                    Obj.IdPermiso = item.IdPermiso;
                    Obj.Expr1 = item.Expr1;
                    Obj.Expr2 = item.Expr2;
                    Obj.Lectura = item.Lectura;
                    Obj.Escritura = item.Escritura;
                    Obj.Eliminacion = item.Eliminacion;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception e) { return null; }
        }
    }
}
