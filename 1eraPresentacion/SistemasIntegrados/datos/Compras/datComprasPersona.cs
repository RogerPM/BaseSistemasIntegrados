using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;

namespace datos.Compras
{
    public class datComprasPersona
    {
        public List<clsComprasPersona> ConsultarPersona()
        {
            try
            {
                List<clsComprasPersona> listaPersona = new List<clsComprasPersona>();
                CompraEntities enti = new CompraEntities();
                var con = from t in enti.Persona select t;
                foreach (var item in con)
                {
                    clsComprasPersona e = new clsComprasPersona();
                    e.IdPersona = Convert.ToInt32(item.IdPersona);
                    e.Identificacion = Convert.ToString(item.Identificacion);
                    e.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                    e.IdTipoPersona = Convert.ToInt32(item.IdTipoPersona);
                    e.NombreRazonSocial = (item.NombreRazonSocial);
                    e.Apellido = (item.NombreRazonSocial);
                    e.TipoIdentificacion = Convert.ToInt32(item.TipoIdentificacion);
                    e.mail = (item.mail);
                    e.IdEstado = Convert.ToInt32(item.IdEstado);
                    listaPersona.Add(e);
                }
                return listaPersona;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datProveedor: " + ex);
                return null;
            }
        }
    }
}
