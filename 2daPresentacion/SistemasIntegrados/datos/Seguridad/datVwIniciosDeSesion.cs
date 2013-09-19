using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace datos.Seguridad
{
    public static class datVwIniciosDeSesion
    {       
        public static List<clsVwIniciosDeSesion> ConsultarTodos() {
            try
            {
                List<clsVwIniciosDeSesion> listaSesiones = new List<clsVwIniciosDeSesion>();
                TECAv8Entities ent = new TECAv8Entities();
                var query=from a in ent.IniciosDeSesion select a;
                foreach (var item in query)
	            {
                    clsVwIniciosDeSesion i=new clsVwIniciosDeSesion();
                    i.idHistorial = item.IdHistorial;
                    i.idUsuario = item.IdUsuario;
                    i.nombreUsuario = item.NombreUsuario;
                    i.descripcion = item.Descripcion;
                    i.fechaIS = item.FechaInicioSesion;
                    listaSesiones.Add(i);
            	}
                return listaSesiones;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null;
            }
        }

        public static List<clsVwIniciosDeSesion> ConsultarxIdUsuario(int iduser)
        {
            try
            {
                List<clsVwIniciosDeSesion> listaSesiones = new List<clsVwIniciosDeSesion>();
                TECAv8Entities ent = new TECAv8Entities();
                var query = from a in ent.IniciosDeSesion where a.IdUsuario==iduser select a;
                foreach (var item in query)
                {
                    clsVwIniciosDeSesion i = new clsVwIniciosDeSesion();
                    i.idHistorial = item.IdHistorial;
                    i.idUsuario = item.IdUsuario;
                    i.nombreUsuario = item.NombreUsuario;
                    i.descripcion = item.Descripcion;
                    i.fechaIS = item.FechaInicioSesion;
                    listaSesiones.Add(i);
                }
                return listaSesiones;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null;
            }
        }

        public static List<clsVwIniciosDeSesion> ConsultarxNickUsuario(string nick)
        {
            try
            {
                List<clsVwIniciosDeSesion> listaSesiones = new List<clsVwIniciosDeSesion>();
                TECAv8Entities ent = new TECAv8Entities();
                var query = from a in ent.IniciosDeSesion where a.NombreUsuario == nick select a;
                foreach (var item in query)
                {
                    clsVwIniciosDeSesion i = new clsVwIniciosDeSesion();
                    i.idHistorial = item.IdHistorial;
                    i.idUsuario = item.IdUsuario;
                    i.nombreUsuario = item.NombreUsuario;
                    i.descripcion = item.Descripcion;
                    i.fechaIS = item.FechaInicioSesion;
                    listaSesiones.Add(i);
                }
                return listaSesiones;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
                return null;
            }
        }
    }
}
