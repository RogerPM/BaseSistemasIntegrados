using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datos.Seguridad
{
    public class datHistorial
    {
        //obtener id siguiente para guardar sgte registro
        private int getIdSiguiente()
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                int x = ((from a in ent.Historial select a.IdHistorial).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public bool GuardarIS(int iduser, DateTime fechaIS) {
            try
            {
                int id = getIdSiguiente();
                using (TECAv8Entities ent=new TECAv8Entities())
                {
                    Historial historial = new Historial()
                    {
                        IdHistorial = id,
                        IdUsuario = iduser,
                        FechaInicioSesion = fechaIS
                    };
                    ent.AddToHistorial(historial);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }
    }
}
