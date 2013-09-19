using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;

namespace datos.Inventario
{
    public class clsInventario
    {
        public List<clsTipoArticulo> consultaTipoArticulo()
        {
            try
            {
                List<clsTipoArticulo> lista = new List<clsTipoArticulo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.TipoArticulo select q;
                foreach (var item in sel)
                {
                    clsTipoArticulo clas = new clsTipoArticulo();
                    clas.codigo = item.IdTipoArticulo;
                    clas.descripcion = item.Descripcion;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsBodega> consultaBodega()
        {
            try
            {
                List<clsBodega> lista = new List<clsBodega>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.Bodega select q;
                foreach (var item in sel)
                {
                    clsBodega clas = new clsBodega();
                    clas.codigo = item.IdBodega;
                    clas.descripcion = item.Decripcion;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsLlegadaMercaderia> consultaOrdenCompra()
        {
            try
            {
                List<clsLlegadaMercaderia> lista = new List<clsLlegadaMercaderia>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.OrdenCompra select q;
                foreach (var item in sel)
                {
                    clsLlegadaMercaderia clas = new clsLlegadaMercaderia();
                    clas.IdOrdenCompra = item.IdOrdenCompra;
                    
                    clas.IdProveedor = item.idProveedor;
                    clas.Observacion = item.Observaciones;

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsMotivo> consultaMotivo()
        {
            try
            {
                List<clsMotivo> lista = new List<clsMotivo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.Motivo select q;
                foreach (var item in sel)
                {
                    clsMotivo clas = new clsMotivo();
                    clas.codigo = item.IdMotivo;
                    clas.descripcion = item.Descripcion;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public List<clsIngresoEgresoDET> consultaIEDetalle(int nroMov)
        {
            try
            {
                List<clsIngresoEgresoDET> lista = new List<clsIngresoEgresoDET>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.IngresoEgresoDet where q.NroMovimiento==nroMov select q;
                foreach (var item in sel)
                {
                    clsIngresoEgresoDET clas = new clsIngresoEgresoDET();
                    clas.articulo = Convert.ToInt32(item.IdArticulo);
                    clas.cantidadPedida = item.Cantidad;
                    clas.articulo = item.IdArticulo;
                    try
                    {
                        clas.NombrePercha = (from q in ent.Percha where q.IdPercha == item.IdPercha select q.Descripcion).First();
                        clas.NombreArticulo = (from q in ent.Articulo where q.IdArticulo == item.IdArticulo select q.Descripcion).First();
                    }
                    catch (Exception)
                    {
                    }
                    clas.percha = item.IdPercha;
                    clas.numero = item.numero;
                    clas.empresa = item.IdEmpresa;
                    clas.nroMovimiento = item.NroMovimiento;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsPercha> consultapercha()
        {
            try
            {
                List<clsPercha> lista = new List<clsPercha>();
                INVENTARIOEntities ent =new INVENTARIOEntities();
                var sel = from q in ent.Percha select q;
                foreach (var item in sel)
                {
                    clsPercha clas = new clsPercha();
                    clas.codigo = item.IdPercha;
                    clas.descripcion = item.Descripcion;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsArticulo> consultainventario()
        {
            try
            {
                List<clsArticulo> lista = new List<clsArticulo>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.Articulo select q;
                foreach (var item in sel)
                {
                    clsArticulo clas = new clsArticulo();
                    clas.IdArt = item.IdArticulo;
                    clas.DescArt = item.Descripcion;
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsTomaFisicaDET> consultaTomaFisicaDetalle()
        {
            try
            {
                List<clsTomaFisicaDET> lista = new List<clsTomaFisicaDET>();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.Articulo select q;
                foreach (var item in sel)
                {
                    clsTomaFisicaDET clas = new clsTomaFisicaDET();
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdArticulo = item.IdArticulo;
                    clas.ExistenciaSistema = Convert.ToInt32(item.CantidadActual);

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public clsLlegadaMercaderia consultaOrdencompra(int numero)
        {
            try
            {
                List<clsLlegadaMercaderiaDet> lista = new List<clsLlegadaMercaderiaDet>();
                clsLlegadaMercaderia clase=new clsLlegadaMercaderia();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.OrdenCompra
                          join w in ent.OrdenCompraDet on q.IdOrdenCompra equals w.Numero
                          where q.IdOrdenCompra==numero && w.Numero==numero
                          select new { q.IdOrdenCompra,q.idEmpresa,q.IdUsuario,q.Fecha,q.FechaModificacion,q.idProveedor,q.NumeroCotizacion,q.Observaciones,q.idEstado,w.Numero,w.Linea,w.IdArticulo,w.Cantidad ,w.Precio};
                var cab=sel.First();
                clase.IdOrdenCompra = cab.IdOrdenCompra;
                clase.IdProveedor = cab.idProveedor;
                clase.Observacion = cab.Observaciones;
               

                foreach (var item in sel)
                {
                    clsLlegadaMercaderiaDet clas = new clsLlegadaMercaderiaDet();
                    clas.IdEmpresa = item.idEmpresa;
                    clas.numero = item.Linea;
                    clas.IdArticulo = item.IdArticulo;
                    clas.CantidadPedida = item.Cantidad;
                    clas.Precio = item.Precio;
                    lista.Add(clas);
                }
                clase.detalle = lista;
                return clase;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public clsTomaFisicaCAB consultaTomaFisica(int numero)
        {
            try
            {
                List<clsTomaFisicaDET> lista = new List<clsTomaFisicaDET>();
                clsTomaFisicaCAB clase = new clsTomaFisicaCAB();
                INVENTARIOEntities ent = new INVENTARIOEntities();
                var sel = from q in ent.TomaFisicaCab
                          join w in ent.TomaFisicaDet on q.NroTomaFisica equals w.NroTomaFisica
                          where q.NroTomaFisica == numero && w.NroTomaFisica == numero
                          select new { 
                            q.IdEmpresa,
                            q.NroTomaFisica,
                            q.IdMotivo,
                            q.FechaTomaFisica,
                            q.FechaModificacion,
                            q.Usuario,
                            q.IdTipoArticulo,
                            q.IdBodega,
                            q.IdUsuario,
                            q.Auditor,
                            q.Observacion,
                            q.IdEstado,
                            //w.IdEmpresa,
                            //w.NroTomaFisica,
                            w.IdArticulo,
                            w.ExistenciaSistema,
                            w.ExistenciaFisica,
                            w.CantidadAjustada,
                            w.FechaAjuste
                          };
                var cab = sel.First();
                clase.IdEmpresa = Convert.ToInt32(cab.IdEmpresa);
                clase.NroTomaFisica = cab.NroTomaFisica;
                clase.IdMotivo = Convert.ToInt32(cab.IdMotivo);
                clase.FechaTomaFisica = Convert.ToDateTime(cab.FechaTomaFisica);
                clase.FechaModificacion = Convert.ToDateTime(cab.FechaModificacion);
                clase.Usuario = Convert.ToInt32(cab.Usuario);
                clase.IdTipoArticulo = Convert.ToInt32(cab.IdTipoArticulo);
                clase.IdBodega = Convert.ToInt32(cab.IdBodega);
                clase.IdUsuario = Convert.ToInt32(cab.IdUsuario);
                clase.Auditor = cab.Auditor;
                clase.Observacion = cab.Observacion;
                clase.IdEstado = Convert.ToInt32(cab.IdEstado);
                foreach (var item in sel)
                {
                    clsTomaFisicaDET clas = new clsTomaFisicaDET();
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.NroTomaFisica = item.NroTomaFisica;
                    clas.IdArticulo = item.IdArticulo;
                    clas.ExistenciaSistema = item.ExistenciaSistema;
                    clas.ExistenciaFisica = item.ExistenciaFisica;
                    clas.CantidadAjustada = item.CantidadAjustada;
                    clas.FechaAjuste = item.FechaAjuste;
                    lista.Add(clas);
                }
                clase.detalle = lista;
                return clase;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool guardarLLegada(clsLlegadaMercaderia dato) {
            try
            {
                INVENTARIOEntities enti = new INVENTARIOEntities();
                int numero = 0;
                try
                {
                    numero = (from q in enti.LlegadaMercaderiaCab where q.IdEmpresa == 1 select q.NroMovimiento).Max() + 1;
                }
                catch (Exception)
                {
                    numero = 1;
                }
                dato.NroMovimiento = numero;
                using (INVENTARIOEntities ent=new INVENTARIOEntities())
                {
                    LlegadaMercaderiaCab cab=new LlegadaMercaderiaCab(){
                    NroMovimiento=Convert.ToInt32(dato.NroMovimiento),
                    IdEmpresa=1,
                    //IdTipoMovimiento
                    //IdOrdenCompra=dato.IdOrdenCompra,
                    //IdProveedor
                    Factura=dato.Factura,
                    //FechaMovimiento
                    //IdMotivo
                    //IdBodega
                    //IdResponsable
                    Observacion=dato.Observacion
                    //IdUsuario
                    //IdEstado
                    };
                    ent.AddToLlegadaMercaderiaCab(cab);
                    ent.SaveChanges();

                    foreach (var item in dato.detalle)
	                {
                        LlegadaMercaderiaDet det=new LlegadaMercaderiaDet(){
                        IdEmpresa=1,
                        NroMovimiento=Convert.ToInt32(dato.NroMovimiento),
                        numero=Convert.ToInt32(item.numero),
                        IdArticulo=item.IdArticulo,
                        IdPercha=item.IdPercha,
                        CantidadPedida=item.CantidadPedida,
                        CantidadLlegada=item.CantidadLlegada,
                        Precio=item.Precio,
                        Subtotal=item.Subtotal,
                        ValorIVA=item.ValorIVA,
                        ValorTotal=item.ValorTotal

                        };
                        ent.AddToLlegadaMercaderiaDet(det);
                        ent.SaveChanges();
		 
	                }
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool guardarTomaFisica(ref clsTomaFisicaCAB dato)
        {
            try
            {
                INVENTARIOEntities enti = new INVENTARIOEntities();
                int numero = 0;
                try
                {
                    numero = (from q in enti.TomaFisicaCab where q.IdEmpresa == 1 select q.NroTomaFisica).Max() + 1;
                }
                catch (Exception)
                {
                    numero = 1;
                }
                dato.NroTomaFisica = numero;
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    TomaFisicaCab cab = new TomaFisicaCab()
                    {
                        NroTomaFisica = Convert.ToInt32(dato.NroTomaFisica),
                        IdEmpresa = 1,
                        IdMotivo = dato.IdMotivo,
                        FechaTomaFisica = dato.FechaTomaFisica,
                        FechaModificacion = dato.FechaModificacion,
                        Usuario = dato.Usuario,
                        IdTipoArticulo = dato.IdTipoArticulo,
                        IdBodega = dato.IdBodega,
                        Auditor = dato.Auditor,
                        Observacion = dato.Observacion,
                        IdEstado = dato.IdEstado

                    };
                    ent.AddToTomaFisicaCab(cab);
                    ent.SaveChanges();
                    int linea = 1;

                    foreach (var item in dato.detalle)
                    {
                        TomaFisicaDet det = new TomaFisicaDet()
                        {
                            IdEmpresa = 1,
                            linea = linea,
                            NroTomaFisica = dato.NroTomaFisica,
                            IdArticulo = item.IdArticulo,
                            ExistenciaSistema = item.ExistenciaSistema,
                            ExistenciaFisica = item.ExistenciaFisica,
                            CantidadAjustada = item.CantidadAjustada,
                            FechaAjuste = item.FechaAjuste
                        };
                        linea = linea + 1;
                        ent.AddToTomaFisicaDet(det);
                        ent.SaveChanges();

                    }
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool ModificarTomaFisica(clsTomaFisicaCAB dato)
        {
            try
            {
                INVENTARIOEntities enti = new INVENTARIOEntities();
                
                    var sel = (from q in enti.TomaFisicaDet where q.IdEmpresa == 1 && q.NroTomaFisica==dato.NroTomaFisica select q);
                    foreach (var item in sel)
                    {
                        enti.DeleteObject(item);
                    }
                    enti.SaveChanges();
                
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    int linea = 1;
                    foreach (var item in dato.detalle)
                    {
                        TomaFisicaDet det = new TomaFisicaDet()
                        {
                            IdEmpresa = 1,
                            linea =linea,
                            NroTomaFisica = dato.NroTomaFisica,
                            IdArticulo = item.IdArticulo,
                            ExistenciaSistema = item.ExistenciaSistema,
                            ExistenciaFisica = item.ExistenciaFisica,
                            CantidadAjustada = item.CantidadAjustada,
                            FechaAjuste = item.FechaAjuste	
                        };
                        linea = linea + 1;
                        ent.AddToTomaFisicaDet(det);
                        ent.SaveChanges();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
