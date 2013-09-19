using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using datos.Inventario;


namespace datos.Inventario
{
    public class datIngresoEgresoDET 
    {

        //public List<clsIngresoEgresoDET> consulta()
        //{
        //    try
        //    {

        //        List<clsIngresoEgresoDET> lista = new List<clsIngresoEgresoDET>();
        //        INVENTARIOEntities ent = new INVENTARIOEntities();
        //        var con = from w in ent.IngresoEgresoDet select w;
        //        foreach (var item in con)
        //        {
        //            clsIngresoEgresoDET clas = new clsIngresoEgresoDET();
        //            clas.empresa = Convert.ToInt32(item.IdEmpresa);
        //            clas.nroMovimiento = Convert.ToInt32(item.NroMovimiento);
        //            clas.numero = Convert.ToInt32(item.numero);
        //            clas.articulo = Convert.ToInt32(item.IdArticulo);
        //            clas.percha = Convert.ToInt32(item.IdPercha);
        //            clas.cantidadLlegada = Convert.ToInt32(item.CantidadLlegada);
        //            clas.cantidadPedida = Convert.ToInt32(item.CantidadPedida);
        //            clas.costo = Convert.ToInt32(item.Costo);
        //            clas.subTotal = Convert.ToDecimal (item.Subtotal);
        //            clas.valorIVA = Convert.ToDecimal(item.ValorIVA);
        //            clas.valorTotal = Convert.ToDecimal(item.ValorTotal);
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


        //public Boolean GuardarDet(clsIngresoEgresoDET  ingeg, ref string msg)
        //{
        //    try
        //    {
        //        using (INVENTARIOEntities detIngEg = new INVENTARIOEntities())
        //        {
        //            IngresoEgresoDet ingeg1 = new IngresoEgresoDet();
        //            {
        //                ingeg1.IdEmpresa = ingeg.empresa;
        //                ingeg1.NroMovimiento = ingeg.nroMovimiento;
        //                ingeg1.numero = ingeg.numero;
        //                if (ingeg.articulo != 0)
        //                    ingeg1.IdArticulo = ingeg.articulo;
        //                if (ingeg.articulo != 0)
        //                    ingeg1.IdPercha = ingeg.percha;
        //                if (ingeg.cantidadPedida != 0)
        //                    ingeg1.CantidadPedida = ingeg.cantidadPedida;
        //                if (ingeg.cantidadLlegada != 0)
        //                    ingeg1.CantidadLlegada = ingeg.cantidadLlegada;
        //                if (ingeg.costo != 0)
        //                    ingeg1.Costo = ingeg.costo;
        //                if (ingeg.subTotal != 0)
        //                    ingeg1.Subtotal = ingeg.subTotal;
        //                if (ingeg.valorIVA != 0)
        //                    ingeg1.ValorIVA = ingeg.valorIVA;
        //                if (ingeg.valorTotal != 0)
        //                    ingeg1.ValorTotal = ingeg.valorTotal;
        //            }
        //            detIngEg.AddToIngresoEgresoDet(ingeg1);
        //            detIngEg.SaveChanges();
        //        }
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        msg = "ERROR : " + e.InnerException + e.Message;
        //        return false;
        //    }
        //}

    }

   
}