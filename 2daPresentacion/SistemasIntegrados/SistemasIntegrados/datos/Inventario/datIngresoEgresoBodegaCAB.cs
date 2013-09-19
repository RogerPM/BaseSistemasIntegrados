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
                   //clas.ordenCompra = Convert.ToInt32(item.IdOrdenCompra);
                   clas.motivo = Convert.ToInt32(item.IdMotivo);
                   try
                   {
                        clas.Nombrebodega = (from q in ent.Bodega where q.IdBodega == item.IdBodega select q.Decripcion).First();

                   }
                   catch (Exception)
                   {
                   }
                   clas.bodega = Convert.ToInt32(item.IdBodega);
                   clas.responsable = Convert.ToInt32(item.IdResponsable);
                   //clas.totalPagar = Convert.ToDecimal(item.TotalPagar);
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


       public Boolean guardar(ref clsIngresoEgresoCAB ctm, ref string Mensaje)
       {
           try
           {
               INVENTARIOEntities enti = new INVENTARIOEntities();
               int numero = 0;
               try
               {
                   numero = (from q in enti.IngresoEgresoCab where q.IdEmpresa == 1 select q.NroMovimiento).Max() + 1;
               }
               catch (Exception)
               {
                   numero = 1;
               }
               ctm.nroMovimiento = numero;
               using (INVENTARIOEntities te = new INVENTARIOEntities())
               {
                   IngresoEgresoCab tm = new IngresoEgresoCab()
                   {
                       IdEmpresa = Convert.ToInt32(ctm.empresa),
                       NroMovimiento = ctm.nroMovimiento,
                       IdTipoMovimiento = ctm.tipoMovimiento,
                       FechaMovimiento = ctm.fechaMovimiento,
                       //tm.IdOrdenCompra = ctm.ordenCompra;
                       IdMotivo = ctm.motivo,
                       IdBodega = ctm.bodega,
                       IdResponsable = ctm.responsable,
                       //tm.TotalPagar = ctm.totalPagar;
                       Observacion = ctm.observacion,
                       IdEstado = ctm.estado
                   };
                   te.AddToIngresoEgresoCab(tm);
                   te.SaveChanges();
                   int linea=1;
                   foreach (var item in ctm.detalle)
                   {
                       IngresoEgresoDet det = new IngresoEgresoDet() { 
                           IdEmpresa=1,
                            NroMovimiento=ctm.nroMovimiento,
                            numero=linea,
                            IdArticulo=item.articulo,
                            IdPercha=item.percha,
                            Cantidad=item.cantidadPedida
                       };
                       linea=linea+1;
                       te.AddToIngresoEgresoDet(det);
                   }
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


       public Boolean modificar(clsIngresoEgresoCAB ctm)
       {
           using (INVENTARIOEntities te = new INVENTARIOEntities())
           {
               EntityKey ekey = new EntityKey("TECAEntitieS.IngresoEgresoCab", "IdnroMovimiento", ctm.nroMovimiento);
               object OBJ = null;
               if (te.TryGetObjectByKey(ekey, out OBJ))
               {
                   IngresoEgresoCab IngEgCAB = (IngresoEgresoCab)OBJ;
                   IngEgCAB.IdTipoMovimiento = ctm.tipoMovimiento;
                   IngEgCAB.FechaMovimiento = ctm.fechaMovimiento;
                   //IngEgCAB.IdOrdenCompra = ctm.ordenCompra;
                   IngEgCAB.IdMotivo = ctm.motivo;
                   IngEgCAB.IdBodega = ctm.bodega;
                   IngEgCAB.IdResponsable = ctm.responsable;
                   //IngEgCAB.TotalPagar = ctm.totalPagar;
                   IngEgCAB.Observacion = ctm.observacion;
                   IngEgCAB.IdEstado = Convert.ToInt32(ctm.estado);
               }
               te.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
           }
           return true;
       }

       public string ConsultarPorId(int id)
       {
           using (INVENTARIOEntities ent = new INVENTARIOEntities())
           {
               var x = (from a in ent.Empresa where a.IdEmpresa == id select a).First();
               return x.NombreComercial;
           }
       }
               



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
