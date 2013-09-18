using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;

namespace datos.Inventario
{
   public  class datTransferenciaBodegaDET
    {
       public List<clsTransfereciaBodegaDET > consulta()
       {
           try
           {
               List<clsTransfereciaBodegaDET > lista = new List<clsTransfereciaBodegaDET >();
               INVENTARIOEntities ent = new INVENTARIOEntities();
               var con = from w in ent.TransferenciaBodegaDet select w;
               foreach (var item in con)
               {
                   clsTransfereciaBodegaDET  clas = new clsTransfereciaBodegaDET() ;
                   clas.empresa = Convert.ToInt32(item.IdEmpresa);
                   clas.nroTransferencia = Convert.ToInt32(item.NroTransferencia);
                   //clas.numero = Convert.ToInt32(item.Numero );
                   clas.cantidadTrasladada = Convert.ToInt32(item.CantidadTrasladada);
                   clas.articulo = Convert.ToInt32(item.Articulo);
                   //clas.articulo = Convert.ToInt32(item.Estado);
                                 
                   lista.Add(clas);

               }
               return lista;
           }
           catch (Exception ex)
           {
               Console.WriteLine("Error : " + ex);
               return null;
           }
       }


     
     
    }
}
