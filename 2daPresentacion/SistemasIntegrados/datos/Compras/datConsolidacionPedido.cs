using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;

namespace datos.Compras
{
    public class datConsolidacionPedido
    {
        
        public List<clsConsolidacionPedidoVista> ConsultarPedidoCabEspecifica(int numero)
        {
            try
            {
                List<clsConsolidacionPedidoVista> listaPedido = new List<clsConsolidacionPedidoVista>();
                CompraEntities enti = new CompraEntities();


                var con = from t in enti.PedidoCabecera_Vista where t.Numero == numero select t;

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

        public List<clsConsolidacionPedidoVista> ConsultarPedidoCabGeneral(int idempresa)
        {
            try
            {
                List<clsConsolidacionPedidoVista> listaPedido = new List<clsConsolidacionPedidoVista>();
                CompraEntities enti = new CompraEntities();


                var con = from t in enti.PedidoCabecera_Vista where t.idEmpresa == idempresa && t.idEstado ==1 select t;

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

        //metodo que retorna el detalle de una pedido según su cabecera
        public List<clsConsolidacionPedidoDetalleVista> DetallePedido(int NumeroDetalle, int idEmpresa)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clsConsolidacionPedidoDetalleVista> listaPedidoDet = new List<clsConsolidacionPedidoDetalleVista>();
                    var x = (from a in ent.PedidoDetalle_Vista where a.numero == NumeroDetalle && a.idEmpresa == idEmpresa select a);
                    foreach (var item in x)
                    {
                        clsConsolidacionPedidoDetalleVista e = new clsConsolidacionPedidoDetalleVista();
                        e.Numero = Convert.ToInt32(item.numero);
                        e.linea = Convert.ToInt32(item.Linea);
                        e.id_articulo = Convert.ToInt32(item.idArticulo);
                        e.Articulo = Convert.ToString(item.Articulo);
                        e.Cantidad = Convert.ToInt32(item.Cantidad);
                        e.Id_empresa = Convert.ToInt32(item.idEmpresa);
                        e.Empresa = Convert.ToString(item.Empresa);
                        listaPedidoDet.Add(e);
                    }
                    return listaPedidoDet;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        //GUARDAR DETALLE Y CABECERA DE UN PEDIDO
        public bool Guardar(clsConsolidacionPedido e)
        {
            try
            {
                int id = getIdSiguiente();
                e.Numero = id;
                using (CompraEntities ent = new CompraEntities())
                {
                    //se instancia el entity para poder usar los nombres de las tablas
                    Pedido pedidocab = new Pedido()
                    {
                        Numero = e.Numero,
                        idEmpresa = e.idEmpresa,
                        idUsuario = e.idUsuario,
                        idTipoArticulo = e.idTipoArticulo,
                        idEstado = e.idEstado
                    };

                    ent.AddToPedido(pedidocab);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la cabecera de Pedido: " + ex);
                return false;
            }
        }

        public bool GuardarDet(List<clsConsolidacionPedidoDet> lista_detalle)
        {
            try
            {
                clsConsolidacionPedidoDet e = new clsConsolidacionPedidoDet();
                int id = getIdSiguiente();
                e.Numero = id - 1;
                using (CompraEntities ent = new CompraEntities())
                { //se instancia el entity para poder usar los nombres de las tablas

                    //se hace el ingreso de cada detalle que existe en la lista
                    int cantidad = lista_detalle.Count();
                    int i = 0;
                    while (i < cantidad)
                    {
                        e = lista_detalle[i];
                        PedidoDet pedido_detalle = new PedidoDet()
                        {
                            Numero = e.Numero,
                            idEmpresa = e.Id_Empresa,
                            Linea = e.linea,
                            idArticulo = e.Id_articulo,
                            Cantidad = e.cantidad
                        };

                        ent.AddToPedidoDet(pedido_detalle);
                        ent.SaveChanges();
                        i++;
                    }

                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar el detalle de la Solicitud: " + ex);
                return false;
            }
        }


        //Proceso que modifica la cabecera del Pedido
        public bool ModificarCabeceraPedido(clsConsolidacionPedido e)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Pedido where a.Numero == e.Numero select a).First();
                    x.Numero = e.Numero;
                    x.idEmpresa = e.idEmpresa;
                    x.idUsuario = e.idUsuario;
                    x.idTipoArticulo = e.idTipoArticulo;
                    x.idEstado = e.idEstado;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de Modificar la Cabecera de Pedido: " + ex);
                return false;
            }
        }


        //Modificar el detalle de Pedido
        public bool ModificarDetallePedido(List<clsConsolidacionPedidoDet> lista_detalle)
        {
            try
            {
                clsConsolidacionPedidoDet e = new clsConsolidacionPedidoDet();

                using (CompraEntities ent = new CompraEntities())
                {
                    int cantidad = lista_detalle.Count();
                    int i = 0;
                    while (i < cantidad)
                    {
                        e = lista_detalle[i];
                        //busca por PK el primero que encuentre lo coge
                        var x = (from a in ent.PedidoDet where a.Numero == e.Numero && a.Linea == e.linea select a).First();
                        x.Numero = e.Numero;
                        x.idEmpresa = e.Id_Empresa;
                        x.Linea = e.linea;
                        x.idArticulo = e.Id_articulo;
                        x.Cantidad = e.cantidad;
                        ent.SaveChanges();
                        i++;
                    }
                }
                return true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de Modificar el detalle del Pedido: " + ex);
                return false;
            }
        }

        //obtener id siguiente de la tabla Cabecera de la Consolidación de Pedido
        public int getIdSiguiente()
        {
            try
            {
                CompraEntities ent = new CompraEntities();
                int x = ((from a in ent.Pedido select a.Numero).Max()) + 1;
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
