using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;



using clases.Compras;
using System.IO;

namespace datos.Compras
{
    public class datSolicitud
    {
        public List<clsSolicitud> ConsultarSolicitudCab()
        {
            try
            {
                List<clsSolicitud> listaSolicitud = new List<clsSolicitud>();
                CompraEntities enti = new CompraEntities();
                //var con = from t in enti.SolicitudCab select t;
                var con = (from t in enti.SolicitudCab where t.idEstado == 1 || t.idEstado == 2 select t);
                foreach (var item in con)
                {
                    clsSolicitud e = new clsSolicitud();
                    e.Numero = Convert.ToInt32(item.Numero);
                    e.Id_Empresa = Convert.ToInt32(item.idEmpresa);
                    e.Empresa = Convert.ToString(item.Empresa);
                    e.Id_Tipo_Articulo = Convert.ToInt32(item.idtipoArticulo);
                    e.Tipo_Artículo = Convert.ToString(item.TipoArticulo);
                    e.Id_Usuario = Convert.ToInt32(item.IdUsuario);
                    e.Usuario = Convert.ToString(item.Usuario);
                    e.Id_Departamento = Convert.ToInt32(item.idDepartamento);
                    e.Departamento = Convert.ToString(item.Departamento);
                    e.Fecha = Convert.ToDateTime(item.Fecha);
                    e.Id_Estado = Convert.ToInt32(item.idEstado);
                    e.Estado = Convert.ToString(item.Estado);
                    listaSolicitud.Add(e);
                }
                return listaSolicitud;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datSolicitud: " + ex);
                return null;
            }
        }

        //Procedimiento que me devuelve una lista solo con las solicitudes que estan activas mas no procesadas
        public List<clsSolicitud> ConsultarSolicitudCabPro()
        {
            try
            {
                List<clsSolicitud> listaSolicitud = new List<clsSolicitud>();
                CompraEntities enti = new CompraEntities();
                var con = (from t in enti.SolicitudCab where t.idEstado == 1 || t.idEstado == 2 select t);
                foreach (var item in con)
                {
                    clsSolicitud e = new clsSolicitud();
                    e.Numero = Convert.ToInt32(item.Numero);
                    e.Id_Empresa = Convert.ToInt32(item.idEmpresa);
                    e.Empresa = Convert.ToString(item.Empresa);
                    e.Id_Tipo_Articulo = Convert.ToInt32(item.idtipoArticulo);
                    e.Tipo_Artículo = Convert.ToString(item.TipoArticulo);
                    e.Id_Usuario = Convert.ToInt32(item.IdUsuario);
                    e.Usuario = Convert.ToString(item.Usuario);
                    e.Id_Departamento = Convert.ToInt32(item.idDepartamento);
                    e.Departamento = Convert.ToString(item.Departamento);
                    e.Fecha = Convert.ToDateTime(item.Fecha);
                    e.Id_Estado = Convert.ToInt32(item.idEstado);
                    e.Estado = Convert.ToString(item.Estado);
                    listaSolicitud.Add(e);
                }
                return listaSolicitud;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datSolicitud: " + ex);
                return null;
            }
        }


        //metodo que retorna el detalle de una solicitud según su cabecera
        public List<clsSolicitudDet> Detalle_Solicitud(int numero_detalle, int id_empresa)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    List<clsSolicitudDet> listaSolicitudDet = new List<clsSolicitudDet>();
                    var x = (from a in ent.SolicitudDetalle  where a.numero == numero_detalle && a.idEmpresa == id_empresa select a);
                    foreach (var item in x)
                    {
                        clsSolicitudDet e = new clsSolicitudDet();
                        e.Numero = Convert.ToInt32(item.numero);
                        e.linea = Convert.ToInt32(item.Linea);
                        e.id_articulo = Convert.ToInt32(item.idArticulo);
                        e.Articulo = Convert.ToString(item.Articulo);
                        e.Cantidad = Convert.ToInt32(item.Cantidad);
                        e.Id_empresa = Convert.ToInt32(item.idEmpresa);
                        e.Empresa = Convert.ToString(item.Empresa);
                        listaSolicitudDet.Add(e);
                    }
                    return listaSolicitudDet;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        public bool Guardar(clsSolicitud e)
        {
            try
            {
                int id = getIdSiguiente();
                e.Numero = id;
                using (CompraEntities ent = new CompraEntities())
                { 
                  //se instancia el entity para poder usar los nombres de las tablas
                  Solicitud   solicitudcab = new Solicitud()
                    {
                        Numero = e.Numero,
                        idEmpresa = e.Id_Empresa,
                        IdTipoArticulo = e.Id_Tipo_Articulo,
                        IdUsuario = e.Id_Usuario,
                        idDepartamento = e.Id_Departamento,
                        idEstado = e.Id_Estado
                    };

                    ent.AddToSolicitud(solicitudcab);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar la cabecera de solicitud: " + ex);
                return false;
            }
        }

        public bool GuardarDet(List<clsSolicitud_DetT> lista_detalle)
        {
            try
            {
                clsSolicitud_DetT e = new clsSolicitud_DetT();
                int id = getIdSiguiente();
                e.Numero = id - 1;
                using (CompraEntities ent = new CompraEntities())
                { //se instancia el entity para poder usar los nombres de las tablas

                    //se hace el ingreso de cada detalle que existe en la lista
                    int cantidad = lista_detalle.Count();
                    int i = 0;
                    while(i < cantidad)
                    {
                        e = lista_detalle[i];
                        SolicitudDet solicitud_detalle = new SolicitudDet()
                        {
                            Numero = e.Numero,
                            idEmpresa = e.Id_Empresa,
                            Linea = e.linea,
                            idArticulo = e.Id_articulo,
                            Cantidad = e.cantidad
                        };

                        ent.AddToSolicitudDet(solicitud_detalle);
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


        public bool ModificarCabecera(clsSolicitud e)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Solicitud where a.Numero == e.Numero select a).First();
                    x.Numero = e.Numero;
                    x.idEmpresa = e.Id_Empresa;
                    x.IdTipoArticulo = e.Id_Tipo_Articulo;
                    x.IdUsuario = e.Id_Usuario;
                    x.idDepartamento = e.Id_Departamento;
                    x.idEstado = e.Id_Estado;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de Modificar la Solicitud: " + ex);
                return false;
            }
        }

        public bool ModificarDetalle(List<clsSolicitud_DetT> lista_detalle, int lista_anterior)
        {
            try
            {
                int cantidad_anterior = lista_anterior;
                int cantidad_nueva = lista_detalle.Count();
                clsSolicitud_DetT e = new clsSolicitud_DetT();

                //esto es para verificar si se aumento un nuevo artículo a la lista, en este caso seaumento artículos
                if (cantidad_nueva > cantidad_anterior)
                {
                    using (CompraEntities ent = new CompraEntities())
                    {
                        //se realiza el ingreso del nuevo detalle
                        int cantidad = lista_detalle.Count();
                        int i = cantidad_nueva - 1;
                        while (cantidad_nueva > cantidad_anterior)
                        {
                            e = lista_detalle[i];
                            SolicitudDet solicitud_detalle = new SolicitudDet()
                            {
                                Numero = e.Numero,
                                idEmpresa = e.Id_Empresa,
                                Linea = e.linea,
                                idArticulo = e.Id_articulo,
                                Cantidad = e.cantidad
                            };

                            ent.AddToSolicitudDet(solicitud_detalle);
                            ent.SaveChanges();
                            i--;
                            cantidad_nueva--;
                        }
                    }

                    //se modifica si los anteriores registros
                    using (CompraEntities ent = new CompraEntities())
                    {
                        int i = 0;
                        while (i < cantidad_anterior)
                        {
                            e = lista_detalle[i];
                            //busca por PK el primero que encuentre lo coge
                            var x = (from a in ent.SolicitudDet where a.Numero == e.Numero && a.Linea == e.linea select a).First();
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
                else
                {

                    using (CompraEntities ent = new CompraEntities())
                    {
                        int cantidad = lista_detalle.Count();
                        int i = 0;
                        while (i < cantidad)
                        {
                            e = lista_detalle[i];
                            //busca por PK el primero que encuentre lo coge
                            var x = (from a in ent.SolicitudDet where a.Numero == e.Numero && a.Linea == e.linea select a).First();
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
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de Modificar el detalle de la Solicitud: " + ex);
                return false;
            }
        }



        public bool ModificarEstado(int numero)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Solicitud where a.Numero == numero select a).First();
                    x.idEstado = 3;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al momento de Modificar Estado la Solicitud: " + ex);
                return false;
            }
        }

        //obtener id siguiente de la tabla Cabecera de la Solicitud
        public int getIdSiguiente()
        {
            try
            {
                CompraEntities ent = new CompraEntities();
                int x = ((from a in ent.Solicitud select a.Numero).Max()) + 1;
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
