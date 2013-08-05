using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosPrueba
    {

        public void  guardar(clsClasePrueba prueb)
        {
            using (PruebaEntities ent = new PruebaEntities())
            {
                AbPrueba pru = new AbPrueba()
                {
                    //codigo = prueb.codigo,
                    //nombre = prueb.nombre,
                    //descripcion = prueb.decripcion,
                  
                };
                pru.codigo = Convert.ToInt32(prueb.codigo);
                pru.nombre = prueb.nombre;
                pru.descripcion = prueb.decripcion;
                ent.AddToAbPrueba(pru);
                ent.SaveChanges();
            }
            
            //try
            //{
             
            //     return true;
            //}
            //catch (Exception)
            //{
                
            //    return false;
            //}
           


        }

    }
}
