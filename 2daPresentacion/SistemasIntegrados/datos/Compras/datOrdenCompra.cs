using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;

namespace datos.Compras
{
    public class datOrdenCompra
    {

        public List<clsOrdenCompraCabecera_Vista> ConsultarOrdenCompraCab()
        {
            try
            {
                List<clsOrdenCompraCabecera_Vista> listaOrdenCab = new List<clsOrdenCompraCabecera_Vista>();
                CompraEntities enti = new CompraEntities();


                var con = from t in enti.OrdenCompraCab_Vista select t;

                foreach (var item in con)
                {
                    clsOrdenCompraCabecera_Vista e = new clsOrdenCompraCabecera_Vista();
                    e.Numero = Convert.ToInt32(item.IdOrdenCompra);
                    e.idEmpresa = Convert.ToInt32(item.idEmpresa);
                    e.Empresa = Convert.ToString(item.NombreComercial);
                    e.idProveedor = Convert.ToInt32(item.idProveedor);
                    e.Proveedor = Convert.ToString(item.Proveedor);
                    e.idUsuario = Convert.ToInt32(item.IdUsuario);
                    e.Usuario = Convert.ToString(item.NombreUsuario);
                    e.Fecha = Convert.ToDateTime(item.Fecha);
                    e.idEstado = Convert.ToInt32(item.idEstado);
                    e.Estado = Convert.ToString(item.Estado);
                    listaOrdenCab.Add(e);
                }
                return listaOrdenCab;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datPedido: " + ex);
                return null;
            }
        }


        public List<clsOrdenCompraDetalle_Vista> DetalleOrdenCompra(int NumeroDetalle, int idEmpresa)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clsOrdenCompraDetalle_Vista> listaOrdenDet = new List<clsOrdenCompraDetalle_Vista>();
                    var x = (from a in ent.OrdenCompraDetalle_Vista where a.Numero == NumeroDetalle && a.IdEmpresa == idEmpresa select a);
                    foreach (var item in x)
                    {
                        clsOrdenCompraDetalle_Vista e = new clsOrdenCompraDetalle_Vista();
                        e.Numero = Convert.ToInt32(item.Numero);
                        e.linea = Convert.ToInt32(item.Linea);
                        e.id_articulo = Convert.ToInt32(item.IdArticulo);
                        e.Articulo = Convert.ToString(item.Articulo);
                        e.Cantidad = Convert.ToInt32(item.Cantidad);
                        e.Id_empresa = Convert.ToInt32(item.IdEmpresa);
                        e.Empresa = Convert.ToString(item.NombreComercial);
                        listaOrdenDet.Add(e);
                    }
                    return listaOrdenDet;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }



    }
}
