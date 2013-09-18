using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using clases.Seguridad;
using System.Data;
namespace datos.Seguridad
{
    public class datUsuario
    {
        public static bool Guardar(clsUsuario u)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();                
                Usuario usuario = new Usuario()
                {
                    IdUsuario = u.IdUsuario,
                    NombreUsuario = u.NombreUsuario,
                    Contrasena = u.Contrasena,
                    IdEstado = u.IdEstado,
                    IdImagen = u.IdImagen,
                    IdPerfil = u.IdPerfil
                };
                ent.AddToUsuario(usuario);
                ent.SaveChanges();                
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error!" + ex);
                return false;
            }
        }
        public static bool Modificar(clsUsuario u)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var x = (from a in ent.Usuario where a.IdUsuario == u.IdUsuario select a).First();
                x.NombreUsuario = u.NombreUsuario;
                x.Contrasena = u.Contrasena;
                x.IdEstado = u.IdEstado;
                //x.IdImagen = u.IdImagen;
                x.IdPerfil = u.IdPerfil;
                ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool ModificaruSUARIO(Usuario u)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var x = (from a in ent.Usuario where a.IdUsuario == u.IdUsuario select a).First();
                x.NombreUsuario = u.NombreUsuario;
                x.Contrasena = u.Contrasena;
                x.IdEstado = u.IdEstado;

                x.IdPerfil = u.IdPerfil;
                ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool CambiarClave(clsUsuario u, string nuevaClave)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var x = (from a in ent.Usuario where a.NombreUsuario == u.NombreUsuario && a.Contrasena == u.Contrasena select a).First();
                x.Contrasena = nuevaClave;
                ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static bool Eliminar(clsUsuario u)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                var x = (from a in ent.Usuario where a.IdUsuario == u.IdUsuario select a).First();
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
        public static bool ConsultarPorId(int id)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                    {
                        var x = (from a in ent.Usuario where a.IdUsuario == id select a).First();                
                    }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        #region "funcional usando linq-entity"
        public List<clsUsuario> ConsultarTodos()
        {
            try
            {
                List<clsUsuario> listaUsu = new List<clsUsuario>();
                TECAv8Entities ent = new TECAv8Entities();
                var c = from a in ent.Usuario select a;
                foreach (var item in c)
                {
                    clsUsuario u = new clsUsuario();
                    u.IdUsuario = item.IdUsuario;
                    u.NombreUsuario = item.NombreUsuario;
                    u.Contrasena = item.Contrasena;
                    u.IdEstado = Convert.ToInt32(item.IdEstado);
                    u.IdImagen = Convert.ToInt32(item.IdImagen);
                    u.IdPerfil = Convert.ToInt32(item.IdPerfil);
                    listaUsu.Add(u);
                }
                return listaUsu;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }
 
        #endregion
       
        #region "No lo hizo Castro.. no sirve o no va aqui o no respeta formato"
        public void ConsultarEmpresas(System.Windows.Forms.ListBox lst) {
            try
            {
                var NombreEmpresa=from empresa in EntidadSeguridad.Seguridad.Empresa
                                  orderby empresa.NombreComercial
                                  select empresa;
                foreach (var item in NombreEmpresa)
                {
                    lst.Items.Add(item.NombreComercial);
                }
                //lst.DataSource = NombreEmpresa;
                //lst.DisplayMember = "NombreComercial";
                //lst.ValueMember = "NombreComercial";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex   );
                throw;
            } 
        }


        
        public Boolean VerificarUsuarioClave(string usuario , string clave, ref int IdUsuario)
        {
            try
            {
                using (TECAv8Entities oent = new TECAv8Entities())
                {

                    var Consulta = from q in oent.Usuario
                                   where q.NombreUsuario == usuario && q.Contrasena == clave
                                   select q;
                    if (Consulta.ToList().Count() >= 1)
                    {
                        IdUsuario = Consulta.First().IdUsuario;
                        return true;
                    }
                    else
                        return false;
                }             
            }
            catch (Exception)
            {

                return false;
            }
        }
        public Boolean VerficarUsuarioPorEmpresa(int IdEmpresa,int IdUsuario) 
        {
            using (TECAv8Entities oent = new TECAv8Entities())
            {
                var Consulta = from q in oent.UsuarioPorEmpresa
                               where q.IdUsuario == IdUsuario && q.IdEmpresa == IdEmpresa
                               select q;
                if (Consulta.ToList().Count() >= 1)
                    return true;
                else
                    return false;
            }
            return true;
        }
        public List<Usuario> ConsultarUsuarios ()
        {
            using (TECAv8Entities entity = new TECAv8Entities())
            {
                return entity.ExecuteStoreQuery<Usuario>("Select * from Seguridad.Usuario").ToList();
            }
        }

        
    }
        #endregion

    public static class EntidadSeguridad
    {
        public static TECAv8Entities Seguridad = new TECAv8Entities();
    }
}
