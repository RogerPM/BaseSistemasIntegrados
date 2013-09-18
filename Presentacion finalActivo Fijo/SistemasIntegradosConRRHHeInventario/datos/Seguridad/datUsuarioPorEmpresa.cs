using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;
using System.Data;

namespace datos.Seguridad
{
    public class datUsuarioPorEmpresa
    {
        public static bool GuardarEmpresa(clsUsuarioPorEmpresa uxp)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                UsuarioPorEmpresa usuarioempresa = new UsuarioPorEmpresa()
                {
                    IdUsuario = uxp.IdUsuario,
                    IdEmpresa = uxp.IdEmpresa
                };
                ent.AddToUsuarioPorEmpresa(usuarioempresa);
                ent.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!" + ex);
                return false;
            }
        }
        public static bool EliminarEmpresa(clsUsuario u)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var x = (from a in ent.UsuarioPorEmpresa where a.IdUsuario == u.IdUsuario select a).First();
                ent.DeleteObject(x);
                ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
