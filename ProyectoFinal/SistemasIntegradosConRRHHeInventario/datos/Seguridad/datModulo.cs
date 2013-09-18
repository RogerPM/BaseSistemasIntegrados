using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datModulo
    {
        public List<clsModulo> ConsultaModulos()
        {
            try
            {
                List<clsModulo> Lista = new List<clsModulo>();
                TECAv8Entities ent = new TECAv8Entities();


                string consulta = "select * from Seguridad.Modulo";
                return Lista = ent.ExecuteStoreQuery<clsModulo>(consulta).ToList();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }


        }
    }
}
