using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Seguridad;
using System.Data.Objects;

namespace datos.Seguridad
{
    public class datMenuPadre
    {
        public List<clsMenu> ConsultaMenuPadre()
        {
            try
            {
                List<clsMenu> Lst = new List<clsMenu>();
                TECAv8Entities oEnti = new TECAv8Entities();
                var Query = from q in oEnti.Menu
                            where q.IdPadre == null
                            select q;
                foreach (var item in Query)
                {
                    clsMenu Obj = new clsMenu();
                    Obj.IdMenu = item.IdMenu;
                    Obj.IdPadre = Convert.ToInt32(item.IdPadre);
                    Obj.Descripcion = item.Descripcion;
                    Obj.NombreFormulario = item.NombreFormulario;
                    Obj.NombreAssembly = item.NombreAssembly;
                    Lst.Add(Obj);
                }
                return Lst;
            }
            catch (Exception e) { return null; }
        }

        public List<clsMenu> ConsultaMenuModulo(int IdModulo,int IdEmpresa, String usuario, String Contraseña)
        {
            try
            {
                List<clsMenu> Lst = new List<clsMenu>();
                TECAv8Entities oEnti = new TECAv8Entities();
               //var Query = from q in oEnti.Menu
               //            where q.IdModulo == IdModulo
               //            select q;
               //foreach (var item in Query)
               //{
               //    clsMenu Obj = new clsMenu();
               //    Obj.IdMenu = item.IdMenu;
               //    Obj.IdMenuPadre = Convert.ToInt32(item.IdPadre);
               //    Obj.DescripcionMenu = item.Descripcion;

               //    Obj.NombreForm = item.NombreForm;
               //    Obj.NombreAssembly = item.NombreAssembly;
               //    Lst.Add(Obj);
               //}


               String query = "select a.* from Seguridad.Menu a "+
                               " inner join  menu_x_usuario b on a.IdMenu = b.IdMenu and b.IdModulo = "+IdModulo+ " "+
                               " where b.NombreUsuario = '"+usuario+"' and b.Contrasena = '"+Contraseña+"' and b.IdEmpresa = "+IdEmpresa;

               return oEnti.ExecuteStoreQuery<clsMenu>(query).ToList(); ;
            }
            catch (Exception e) { return null; }
        }

        public List<clsMenu> ConsultarMenu() 
        {
            using (TECAv8Entities entity = new TECAv8Entities())
            {
                return entity.ExecuteStoreQuery<clsMenu>("select * from Seguridad.Menu").ToList();
            }
        }
        
    }
}
