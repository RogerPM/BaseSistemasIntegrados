using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using clases.Inventario;
using clases.Compras;

namespace datos.Inventario
{
    public class datOrdenCompraDET
    {
        public List<clsOrdenCompraDET> consulta()
        {
            try
            {

                List<clsOrdenCompraDET> lista = new List<clsOrdenCompraDET>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var con = from w in ent.OrdenCompraDet select w;
                foreach (var item in con)
                {
                    clsOrdenCompraDET clas = new clsOrdenCompraDET();
                    clas.numero = Convert.ToInt32(item.Numero);
                    clas.empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.linea = Convert.ToInt32(item.Linea);
                    clas.articulo = Convert.ToInt32(item.IdArticulo);
                    clas.cantidad = item.Cantidad;
                    clas.precio = Convert.ToDecimal(item.Precio);
                    lista.Add(clas);
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
