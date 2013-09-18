using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
   public  class datIngresoEgresoBodegaCAB
    {

       public List<clsIngresoEgresoCAB> consulta()
       {
           try
           {
               List<clsIngresoEgresoCAB> lista = new List<clsIngresoEgresoCAB>();
               INVENTARIOEntities ent = new INVENTARIOEntities();
               var con = from w in ent.IngresoEgresoCab select w;
               foreach (var item in con)
               {
                   clsIngresoEgresoCAB clas = new clsIngresoEgresoCAB();
                   clas.empresa = Convert.ToInt32(item.IdEmpresa);
                   clas.nroMovimiento = Convert.ToInt32(item.NroMovimiento);
                   clas.tipoMovimiento = Convert.ToInt32(item.IdTipoMovimiento);
                   clas.fechaMovimiento = Convert.ToDateTime(item.FechaMovimiento);
                   clas.ordenCompra = Convert.ToInt32(item.IdOrdenCompra);
                   clas.motivo = Convert.ToInt32(item.IdMotivo);
                   clas.bodega = Convert.ToInt32(item.IdBodega);
                   clas.responsable = Convert.ToInt32(item.IdResponsable);
                   clas.totalPagar = Convert.ToDecimal (item.TotalPagar);
                   clas.observacion = item.Observacion;
                   clas.estado = Convert.ToInt32(item.IdEstado);
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


       public Boolean guardar(clsIngresoEgresoCAB ctm, ref string Mensaje)
       {
           try
           {
               using (INVENTARIOEntities te = new INVENTARIOEntities())
               {
                   IngresoEgresoCab tm = new IngresoEgresoCab();
                   tm.IdEmpresa = Convert.ToInt32(ctm.empresa);
                   tm.NroMovimiento = ctm.nroMovimiento;
                   tm.IdTipoMovimiento = ctm.tipoMovimiento;
                   tm.FechaMovimiento = ctm.fechaMovimiento;
                   tm.IdOrdenCompra = ctm.ordenCompra;
                   tm.IdMotivo = ctm.motivo;
                   tm.IdBodega = ctm.bodega;
                   tm.IdResponsable = ctm.responsable;
                   tm.TotalPagar = ctm.totalPagar;
                   tm.Observacion = ctm.observacion;
                   tm.IdEstado = ctm.estado;

                   te.AddToIngresoEgresoCab(tm);
                   te.SaveChanges();

               }
               return true;
           }
           catch (Exception e)
           {

               Mensaje = "ERROR" + e.InnerException + e.Message;
               //System.Windows.Forms.MessageBox.Show("error al guardar" + e);
               return false;
           }
       }


       public Boolean modificar(clsIngresoEgresoCAB  ctm)
       {
           using (INVENTARIOEntities te = new INVENTARIOEntities())
           {
               EntityKey ekey = new EntityKey("TECAEntitieS.IngresoEgresoCab", "IdnroMovimiento", ctm.nroMovimiento);
               object OBJ = null;
               if (te.TryGetObjectByKey(ekey, out OBJ))
               {
                   IngresoEgresoCab  IngEgCAB = (IngresoEgresoCab )OBJ;
                   IngEgCAB.IdTipoMovimiento  = ctm.tipoMovimiento ;
                   IngEgCAB.FechaMovimiento = ctm.fechaMovimiento;
                   IngEgCAB.IdOrdenCompra = ctm.ordenCompra;
                   IngEgCAB.IdMotivo = ctm.motivo;
                   IngEgCAB.IdBodega = ctm.bodega;
                   IngEgCAB.IdResponsable = ctm.responsable;
                   IngEgCAB.TotalPagar = ctm.totalPagar;
                   IngEgCAB.Observacion = ctm.observacion;
                   IngEgCAB.IdEstado = Convert.ToInt32(ctm.estado);
                 }
               te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
           }
           return true;
       }

       //public string ConsultarPorId(int id)
       //{
       //    using (INVENTARIOEntities ent = new INVENTARIOEntities())
       //    {
       //        var x = (from a in ent.Empresa where a.IdEmpresa == id select a).First();
       //        return x.NombreComercial;
       //    }
       //}
               



       public int getIdSiguiente()
       {
           try
           {
               INVENTARIOEntities ent = new INVENTARIOEntities();
               int x = ((from a in ent.IngresoEgresoCab   select a.NroMovimiento ).Max()) + 1;
               return x;
           }
           catch (Exception e)
           {
               Console.WriteLine("Error: " + e);
               return 1; //en caso de que no exista algun registro
           }
       }
    }
}
