using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;

namespace datos.Inventario
{
    public class datTransferenciaBodegaCAB
    {
        //public List<clsTransferenciaBodegaCAB > consulta()
        //{
        //    try
        //    {
        //        List<clsTransferenciaBodegaCAB> lista = new List<clsTransferenciaBodegaCAB>();
        //        INVENTARIOEntities ent = new INVENTARIOEntities();
        //        var con = from w in ent.TransferenciaBodegaCab  select w;
        //        foreach (var item in con)
        //        {
        //            clsTransferenciaBodegaCAB clas = new clsTransferenciaBodegaCAB();
        //            clas.empresa = Convert.ToInt32(item.IdEmpresa);
        //            clas.nroTransferencia  = Convert.ToInt32(item.NroTransferencia  );
        //            clas.fecha = Convert.ToString(item.Fecha);
        //            clas.bodegaOrigen = Convert.ToInt32(item.IdBodegaOrigen );
        //            clas.bodegaDestino = Convert.ToInt32(item.IdBodegaDestino );
        //            clas.motivo = Convert.ToInt32(item.IdMotivo);
        //            clas.observacion = item.Observacion;

                   
        //            lista.Add(clas);

        //        }
        //        return lista;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error : " + ex);
        //        return null;
        //    }
        //}
    }
}
