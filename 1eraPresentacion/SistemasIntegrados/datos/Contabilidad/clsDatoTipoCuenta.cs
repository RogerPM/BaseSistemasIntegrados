using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;

namespace datos.Contabilidad
{
    public class clsDatoTipoCuenta
    {

        public List<clsTipoCuenta> ConsultaTipoCuenta()
        {
            try
            {
                List<clsTipoCuenta> lista = new List<clsTipoCuenta>();

                EntitiesContabilidad entity = new EntitiesContabilidad();

                var tc = from tcuenta in entity.TipoCuenta select tcuenta;

                foreach (var item in tc)
                {
                    clsTipoCuenta ctipocuenta = new clsTipoCuenta();

                    ctipocuenta.IdTipoCuenta = Convert.ToInt32(item.IdTipoCuenta);
                    ctipocuenta.nombre = item.nombre;

                    lista.Add(ctipocuenta);
                }

                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        } 
    }
}
