using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;

namespace datos.Taller
{
    public class datOrdenTrabajo
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.OrdenTrabajo select a.IdOrdenTrabajo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public int getIdSiguienteOTR()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Repuestos select a.IdRepuestos).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public int getIdSiguienteOTROS()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Otros select a.IdOtros).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }


        public List<clsOrdenTrabajo> Consultar()
        {
            try
            {
                List<clsOrdenTrabajo> ordentrabajo = new List<clsOrdenTrabajo>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.OrdenTrabajo select w;
                foreach (var item in con)
                {
                    clsOrdenTrabajo e = new clsOrdenTrabajo();
                    e.IdOrdenTrabajo = item.IdOrdenTrabajo;
                    e.IdPresupuesto = item.IdPresupuesto;
                    e.IdPersona = item.IdPersona;
                    e.Cliente = item.Persona.NombreRazonSocial + " " + item.Persona.Apellido;
                    e.IdArticulo = item.IdArticulo;
                    e.NroPlaca = item.Articulo.NroPlaca;
                    e.Marca = item.Articulo.Marca.Descripcion;
                    e.Modelo = item.Articulo.Modelo.Descripcion;
                    e.Color = item.Articulo.Color.Descripcion;
                    e.Chasis = item.Articulo.Chasis.Descripcion;
                    e.Kilometraje = item.Kilometraje;
                    e.Combustible = item.Articulo.TipoCombustible.Descripcion;
                    e.Deposito = item.Deposito;
                    e.FechaRecepcion = item.FechaRecepcion;
                    e.InicioReparacion = item.InicioReparacion;
                    e.FechaIngreso = item.FechaIngreso;
                    e.FechaEntrega = item.FechaEntrega;
                    e.IvaTrabajos = item.IvaTrabajos;
                    e.TotalTrabajos = item.TotalTrabajos;
                    e.IvaRepuestos = item.IvaRepuestos;
                    e.TotalRepuestos = item.TotalRepuestos;
                    e.IvaOtros = item.IvaOtros;
                    e.TotalOtros = item.TotalOtros;
                    e.Observacion = item.Observacion;
                    e.IdEstado = item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    ordentrabajo.Add(e);
                }
                return ordentrabajo;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datOrdenTrabajo: " + ex);
                return null;
            }
        }


        public List<clsPresupuestoMO> ConsultarPresupuestoMO(int IdPresupuesto)
        {
            try
            {
                List<clsPresupuestoMO> listapresupuestomo = new List<clsPresupuestoMO>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.PresupuestoxManoObra where w.IdPresupuesto == IdPresupuesto select w;
                foreach (var item in con)
                {
                    clsPresupuestoMO e = new clsPresupuestoMO();
                    e.IdPresupuestoMO = item.IdPresupuestoMO;
                    e.IdPresupuesto = item.IdPresupuesto;
                    e.IdManoObra = item.IdManoObra;
                    e.IdTrabajo = item.IdTrabajo;
                    e.Descripcion = item.ManoObra.TipoTrabajo.Descripcion;
                    e.PrecioHora = item.PrecioHora;
                    e.NroHoras = item.Horas;
                    e.Total = item.Total;
                    listapresupuestomo.Add(e);
                }
                return listapresupuestomo;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datPresupuestoMO: " + ex);
                return null;
            }
        }


        public List<clsOrdenTrabajoR> ConsultarRepuesto(int IdOrdenTrabajo)
        {
            try
            {
                List<clsOrdenTrabajoR> listarepuesto = new List<clsOrdenTrabajoR>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Repuestos where w.IdOrdenTrabajo == IdOrdenTrabajo select w;
                foreach (var item in con)
                {
                    clsOrdenTrabajoR e = new clsOrdenTrabajoR();
                    e.IdRepuesto = item.IdRepuestos;
                    e.IdOrdenTrabajo = item.IdOrdenTrabajo;
                    e.IdArticulo = item.IdArticulo;
                    e.DescripcionRepuesto = item.Articulo.Descripcion;
                    e.Cantidad = item.Cantidad;
                    e.PrecioUnitario = item.PrecioUnitario;
                    e.TotalRepuesto = item.Total;
                    listarepuesto.Add(e);
                }
                return listarepuesto;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datPresupuestoMO: " + ex);
                return null;
            }
        }


        public List<clsOtros> ConsultarOtros(int IdOrdenTrabajo)
        {
            try
            {
                List<clsOtros> listaotros = new List<clsOtros>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Otros where w.IdOrdenTrabajo == IdOrdenTrabajo select w;
                foreach (var item in con)
                {
                    clsOtros e = new clsOtros();
                    e.IdOtros = item.IdOtros;
                    e.IdOrdenTrabajo = item.IdOrdenTrabajo;
                    e.DescripcionOtros = item.Descripcion;
                    e.Precio = item.Precio;
                    listaotros.Add(e);
                }
                return listaotros;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datOtros: " + ex);
                return null;
            }
        }



        public bool Guardar(clsOrdenTrabajo e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdOrdenTrabajo = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    OrdenTrabajo ordentrabajo = new OrdenTrabajo()
                    {
                        IdOrdenTrabajo = e.IdOrdenTrabajo,
                        IdPresupuesto = e.IdPresupuesto,
                        IdPersona = e.IdPersona,
                        IdArticulo = e.IdArticulo,
                        Kilometraje = e.Kilometraje,
                        Deposito = e.Deposito,
                        FechaRecepcion = e.FechaRecepcion,
                        InicioReparacion = e.InicioReparacion,
                        FechaIngreso = e.FechaIngreso,
                        FechaEntrega = e.FechaEntrega,
                        IvaTrabajos = e.IvaTrabajos,
                        TotalTrabajos = e.TotalTrabajos,
                        IvaRepuestos = e.IvaRepuestos,
                        TotalRepuestos = e.TotalRepuestos,
                        IvaOtros = e.IvaOtros,
                        TotalOtros = e.TotalOtros,
                        Observacion = e.Observacion,
                        IdEstado = e.IdEstado,
                        IdEmpresa = e.IdEmpresa
                    };
                    ent.AddToOrdenTrabajo(ordentrabajo);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }


        public bool GuardarRepuestos(clsOrdenTrabajoR e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Repuestos repuestos = new Repuestos()
                    {
                        IdRepuestos = e.IdRepuesto,
                        IdOrdenTrabajo = e.IdOrdenTrabajo,
                        IdArticulo = e.IdArticulo,
                        Cantidad = e.Cantidad,
                        PrecioUnitario = e.PrecioUnitario,
                        Total = e.TotalRepuesto
                    };
                    ent.AddToRepuestos(repuestos);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }


        public bool GuardarOtros(clsOtros e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Otros otros = new Otros()
                    {
                        IdOtros = e.IdOtros,
                        IdOrdenTrabajo = e.IdOrdenTrabajo,
                        Descripcion = e.DescripcionOtros,
                        Precio = e.Precio
                    };
                    ent.AddToOtros(otros);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }



        public bool Modificar(clsOrdenTrabajo e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.OrdenTrabajo where a.IdOrdenTrabajo == e.IdOrdenTrabajo select a).First();
                    x.IdOrdenTrabajo = e.IdOrdenTrabajo;
                    x.IdPresupuesto = e.IdPresupuesto;
                    x.IdPersona = e.IdPersona;
                    x.IdArticulo = e.IdArticulo;
                    x.Kilometraje = e.Kilometraje;
                    x.Deposito = e.Deposito;
                    x.FechaRecepcion = e.FechaRecepcion;
                    x.InicioReparacion = e.InicioReparacion;
                    x.FechaIngreso = e.FechaIngreso;
                    x.FechaEntrega = e.FechaEntrega;
                    x.IvaTrabajos = e.IvaTrabajos;
                    x.TotalTrabajos = e.TotalTrabajos;
                    x.IvaRepuestos = e.IvaRepuestos;
                    x.TotalRepuestos = e.TotalRepuestos;
                    x.IvaOtros = e.IvaOtros;
                    x.TotalOtros = e.TotalOtros;
                    x.Observacion = e.Observacion;
                    x.IdEstado = e.IdEstado;
                    x.IdEmpresa = e.IdEmpresa;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }


        public bool ModificarRepuesto(clsOrdenTrabajoR e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Repuestos where a.IdOrdenTrabajo == e.IdOrdenTrabajo select a).First();
                    x.IdRepuestos = e.IdRepuesto;
                    x.IdOrdenTrabajo = e.IdOrdenTrabajo;
                    x.IdArticulo = e.IdArticulo;
                    x.Cantidad = e.Cantidad;
                    x.PrecioUnitario = e.PrecioUnitario;
                    x.Total = e.TotalRepuesto;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }



        public bool ModificarOtros(clsOtros e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Otros where a.IdOrdenTrabajo == e.IdOrdenTrabajo select a).First();
                    x.IdOtros = e.IdOtros;
                    x.IdOrdenTrabajo = e.IdOrdenTrabajo;
                    x.Descripcion = e.DescripcionOtros;
                    x.Precio = e.Precio;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }


        public bool Eliminar(clsOrdenTrabajo e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.OrdenTrabajo where a.IdOrdenTrabajo == e.IdOrdenTrabajo select a).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

            }
        }

        public bool EliminarRepuesto(clsOrdenTrabajoR e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    ent.ExecuteStoreCommand("DELETE FROM Taller.Repuestos WHERE IdOrdenTrabajo = {0}", e.IdOrdenTrabajo);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

            }
        }

        public bool EliminarOtros(clsOtros e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    ent.ExecuteStoreCommand("DELETE FROM Taller.Otros WHERE IdOrdenTrabajo = {0}", e.IdOrdenTrabajo);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

            }
        }



        //metodo que retorna el Id de un cliente segun su descripcion
        public int getIdSegunDescripcionPersona(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Persona where a.NombreRazonSocial + " " + a.Apellido == descrip select a).First();
                    return x.IdPersona; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


        //PARA EL PROPIETARIO
        public string getDescripcionSegunIdPersona(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Persona where a.IdPersona == id select a).First();
                    return x.NombreRazonSocial + " " + x.Apellido;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        //PARA EL REPUESTO
        public string getDescripcionSegunIdArticulo(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Articulo where a.IdArticulo == id select a).First();
                    return x.Descripcion;
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
