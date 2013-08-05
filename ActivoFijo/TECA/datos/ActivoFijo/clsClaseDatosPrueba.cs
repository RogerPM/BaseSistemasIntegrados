using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosPrueba
    {

        public Boolean   guardar(clsClasePrueba prueb)
        {
            
            try
            {
                using (PruebaEntities ent = new PruebaEntities())
                {
                    AbPrueba pru = new AbPrueba()
                    {
                        //codigo = prueb.codigo,
                        //nombre = prueb.nombre,
                        //descripcion = prueb.decripcion,
                        codigo = Convert.ToInt32(prueb.codigo),
                        nombre = prueb.nombre,
                        descripcion = prueb.decripcion,
                    };

                    ent.AddToAbPrueba(pru);
                    ent.SaveChanges();
                }


                 return true;
            }
            catch (Exception)
            {

                return false;
            }
           


        }

    }
}
