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
                    IdPerfil = u.IdPrefil
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
                x.IdPerfil = u.IdPrefil;
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
        
    }
    public static class EntidadSeguridad
    {
        public static TECAv8Entities Seguridad = new TECAv8Entities();
    }
}
