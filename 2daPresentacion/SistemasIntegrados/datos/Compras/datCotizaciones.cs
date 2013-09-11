using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;
namespace datos.Compras
{
    public class datCotizaciones
    {
        /*
        public List<clsCotizacionCabecera_Vista> ConsultarCotizacionCab(int tipoarticulo, int idempresa)
        {
            try
            {
                List<clsConsolidacionPedidoVista> listaPedido = new List<clsConsolidacionPedidoVista>();
                CompraEntities enti = new CompraEntities();


                var con = from t in enti.PedidoCabecera_Vista where t.idTipoArticulo == tipoarticulo && t.idEmpresa == idempresa && t.idEstado == 1 select t;

                foreach (var item in con)
                {
                    clsConsolidacionPedidoVista e = new clsConsolidacionPedidoVista();
                    e.Numero = Convert.ToInt32(item.Numero);
                    e.idEmpresa = Convert.ToInt32(item.idEmpresa);
                    e.Empresa = Convert.ToString(item.Empresa);
                    e.idTipoArticulo = Convert.ToInt32(item.idTipoArticulo);
                    e.TipoArticulo = Convert.ToString(item.TipoArticulo);
                    e.idUsuario = Convert.ToInt32(item.idUsuario);
                    e.Usuario = Convert.ToString(item.Usuario);
                    e.Fecha = Convert.ToDateTime(item.Fecha);
                    e.idEstado = Convert.ToInt32(item.idEstado);
                    e.Estado = Convert.ToString(item.Estado);
                    listaPedido.Add(e);
                }
                return listaPedido;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datPedido: " + ex);
                return null;
            }
        }
        **/
        public List<clsCotizacionCabecera_Vista> ConsultarCotizacionCab(int idempresa)
        {
            try
            {
                List<clsCotizacionCabecera_Vista> listaCotizacionCab = new List<clsCotizacionCabecera_Vista>();
                CompraEntities enti = new CompraEntities();


                var con = from t in enti.CotizacionCab_Vista where t.idEmpresa == idempresa && t.idEstado == 1 select t;

                foreach (var item in con)
                {
                    clsCotizacionCabecera_Vista e = new clsCotizacionCabecera_Vista();
                    e.Numero = Convert.ToInt32(item.Numero);
                    e.idEmpresa = Convert.ToInt32(item.idEmpresa);
                    e.Empresa = Convert.ToString(item.Empresa);
                    e.idProveedor = Convert.ToInt32(item.idproveedor);
                    e.Proveedor = Convert.ToString(item.Proveedor);
                    e.idUsuario = Convert.ToInt32(item.IdUsuario);
                    e.Usuario = Convert.ToString(item.Usuario);
                    e.Fecha = Convert.ToDateTime(item.Fecha);
                    e.idEstado = Convert.ToInt32(item.idEstado);
                    e.Estado = Convert.ToString(item.Estado);
                    listaCotizacionCab.Add(e);
                }
                return listaCotizacionCab;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datPedido: " + ex);
                return null;
            }
        }

        //metodo que retorna el detalle de una pedido según su cabecera
        public List<clsCotizacionDetalle_Vista> DetalleCotizacionVista(int NumeroDetalle, int idEmpresa)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clsCotizacionDetalle_Vista> listaCotizacionDet = new List<clsCotizacionDetalle_Vista>();
                    var x = (from a in ent.CotizacionDetalle_Vista where a.Numero == NumeroDetalle && a.idEmpresa == idEmpresa select a);
                    foreach (var item in x)
                    {
                        clsCotizacionDetalle_Vista e = new clsCotizacionDetalle_Vista();
                        e.Numero = Convert.ToInt32(item.Numero);
                        e.linea = Convert.ToInt32(item.Linea);
                        e.Pedido  = Convert.ToInt32(item.NumeroPedido);
                        e.idTipoArticulo = Convert.ToInt32(item.idTipoArticulo);
                        e.TipoArticulo = Convert.ToString(item.TipoArticulo);
                        e.idUsuario = Convert.ToInt32(item.idUsuario);
                        e.Usuario = Convert.ToString(item.NombreUsuario);
                        e.Fecha = Convert.ToDateTime(item.Fecha);
                        e.IdEmpresa = Convert.ToInt32(item.idEmpresa);
                        e.Empresa = Convert.ToString(item.Empresa);
                        listaCotizacionDet.Add(e);
                    }
                    return listaCotizacionDet;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        //Guardando los datos de la Cabecera
        public bool Guardar(clsCotizacionCabecera_Vista e)
        {
            try
            {
                int id = getIdSiguiente();
                e.Numero = id;
                using (CompraEntities ent = new CompraEntities())
                {
                    //se instancia el entity para poder usar los nombres de las tablas
                    Cotizacion cotizacioncab = new Cotizacion()
                    {
                        Numero = e.Numero,
                        idEmpresa = e.idEmpresa,
                        IdUsuario = e.idUsuario,
                        idProveedor = e.idProveedor,
                        idEstado = e.idEstado
                    };

                    ent.AddToCotizacion(cotizacioncab);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la cabecera de cotización: " + ex);
                return false;
            }
        }

        
        //Guardar el Detalle de la Cotizacion.
        public bool GuardarDet(List<clsCotizacionDetalle_Vista> lista_detalle)
        {
            try
            {
                clsCotizacionDetalle_Vista e = new clsCotizacionDetalle_Vista();
                using (CompraEntities ent = new CompraEntities())
                { //se instancia el entity para poder usar los nombres de las tablas

                    //se hace el ingreso de cada detalle que existe en la lista
                    int cantidad = lista_detalle.Count();
                    int i = 0;
                    while (i < cantidad)
                    {
                        e = lista_detalle[i];
                        CotizacionDet cotizacion_detalle = new CotizacionDet()
                        {
                            Numero = e.Numero,
                            idEmpresa = e.IdEmpresa,
                            Linea = e.linea,
                            NumeroPedido = e.Pedido,
                        };

                        ent.AddToCotizacionDet(cotizacion_detalle);
                        ent.SaveChanges();
                        i++;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el detalle de la Cotización: " + ex);
                return false;
            }
        }


        //obtener id siguiente de la tabla Cabecera de una Cotización
        public int getIdSiguiente()
        {
            try
            {
                CompraEntities ent = new CompraEntities();
                int x = ((from a in ent.Cotizacion select a.Numero).Max()) + 1;
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
