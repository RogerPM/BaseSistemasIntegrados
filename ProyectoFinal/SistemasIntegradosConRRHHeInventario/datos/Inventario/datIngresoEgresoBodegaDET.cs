using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;


namespace datos.Inventario
{
    public class datIngresoEgresoDET 
    {

        public List<clsIngresoEgresoDET> consulta()
        {
            try
            {

                List<clsIngresoEgresoDET> lista = new List<clsIngresoEgresoDET>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.IngresoEgresoDet select w;
                foreach (var item in con)
                {
                    clsIngresoEgresoDET clas = new clsIngresoEgresoDET();
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.nroMovimiento = Convert.ToInt32(item.NroMovimiento);
                    clas.numero = Convert.ToInt32(item.numero);
                    clas.tipoArticulo = Convert.ToInt32(item.IdTipoArticulo);
                    clas.articulo = Convert.ToInt32(item.IdArticulo);
                    clas.percha = Convert.ToInt32(item.IdPercha);
                    clas.grupo = Convert.ToInt32(item.IdGrupo);
                    clas.cantidadLlegada = Convert.ToInt32(item.CantidadLlegada);
                    clas.cantidadPedida = Convert.ToInt32(item.CantidadPedida);
                    clas.costo = Convert.ToInt32(item.Costo);
                    clas.subTotal = Convert.ToInt32(item.Subtotal);
                    clas.valorIVA = Convert.ToInt32(item.ValorIVA);
                    clas.valorTotal = Convert.ToInt32(item.ValorTotal);
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