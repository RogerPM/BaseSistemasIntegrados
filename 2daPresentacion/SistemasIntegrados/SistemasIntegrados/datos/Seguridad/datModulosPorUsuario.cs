using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases;
using clases.Seguridad;
namespace datos.Seguridad
{
    public  class datModulosPorUsuario
    {
        public List<clsModuloR> ConsultaModulosUsuario(int IdEmpresa, String usuario, String Contraseña) 
        {
            try
            {
                List<clsModuloR> Lista = new List<clsModuloR>();
                TECAv8Entities Oent = new TECAv8Entities();
                string Querty = "SELECT a.IdEstado,a.IdModulo,a.Logo,a.Nombre from Seguridad.Modulo a  join "+
                                    "menu_x_usuario b on a.IdModulo = b.IdModulo " +
                                    "where b.NombreUsuario = '"+usuario+"' and b.Contrasena = '"+Contraseña+"' and b.IdEmpresa ="+IdEmpresa +" "+
                                    "Group By a.IdEstado,a.IdModulo,a.Logo,a.Nombre";
                return Lista = Oent.ExecuteStoreQuery<clsModuloR>(Querty).ToList();
            }
            catch (Exception)
            {

                return null;
            }
        }
     }
}
