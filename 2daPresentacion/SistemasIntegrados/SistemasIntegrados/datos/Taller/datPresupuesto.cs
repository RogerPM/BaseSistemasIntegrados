using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;
using System.IO;

namespace datos.Taller
{
    public class datPresupuesto
    {
        //obtener id siguiente
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Presupuesto select a.IdPresupuesto).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }


        //obtener id siguiente
        public int getIdSiguientePMO()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.PresupuestoxManoObra select a.IdPresupuestoMO).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }




        public List<clsPresupuesto> Consultar()
        {
            try
            {
                List<clsPresupuesto> listapresupuesto = new List<clsPresupuesto>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Presupuesto from x in ent.Articulo where w.IdPersona == x.IdPersona orderby w.IdPresupuesto select w;
                foreach (var item in con)
                {
                    clsPresupuesto e = new clsPresupuesto();
                    e.IdPresupuesto = item.IdPresupuesto;
                    e.IdPersona = item.IdPersona;
                    e.Cliente = item.Persona.NombreRazonSocial + " " + item.Persona.Apellido;
                    e.IdArticulo = item.IdArticulo;
                    e.NroPlaca = item.Articulo.NroPlaca;
                    e.Marca = item.Articulo.Marca.Descripcion;
                    e.Modelo = item.Articulo.Modelo.Descripcion;
                    e.Color = item.Articulo.Color.Descripcion;
                    e.Combustible = item.Articulo.TipoCombustible.Descripcion;
                    e.Chasis = item.Articulo.Chasis.Descripcion;
                    e.Fecha = item.Fecha;
                    e.TotalTiempoTrabajo = item.TotalTiempoTrabajo;
                    e.Subtotal = item.Subtotal;
                    e.Iva = item.Iva;
                    e.TotalPresupuesto = item.TotalPresupuesto;
                    e.Observacion = item.Observacion;
                    e.IdEstado= item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    listapresupuesto.Add(e);
                }
                return listapresupuesto;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datCliente: " + ex);
                return null;
            }
        }



        public List<clsConsultaClienteP> ConsultarCliente()
        {
            try
            {
                List<clsConsultaClienteP> listacliente = new List<clsConsultaClienteP>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Articulo from x in ent.Persona where w.IdPersona == x.IdPersona select w; 
                foreach (var item in con)
                {
                    clsConsultaClienteP e = new clsConsultaClienteP();
                    e.IdPersona = item.Persona.IdPersona;
                    e.Identificacion = item.Persona.Identificacion;
                    e.IdArticulo = item.IdArticulo;
                    e.Nombre = item.Persona.NombreRazonSocial;
                    e.Apellido = item.Persona.Apellido;
                    e.NroPlaca = item.NroPlaca;
                    e.Marca = item.Marca.Descripcion;
                    e.Modelo = item.Modelo.Descripcion;
                    listacliente.Add(e);
                }
                return listacliente;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datCliente: " + ex);
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



        public bool Guardar(clsPresupuesto e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdPresupuesto = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Presupuesto presupuesto = new Presupuesto()
                    {
                        IdPresupuesto = e.IdPresupuesto,
                        IdPersona = e.IdPersona,
                        IdArticulo = e.IdArticulo,
                        Fecha = e.Fecha,
                        TotalTiempoTrabajo = e.TotalTiempoTrabajo,
                        Subtotal = e.Subtotal,
                        Iva = e.Iva,
                        TotalPresupuesto = e.TotalPresupuesto,
                        Observacion = e.Observacion,
                        IdEstado = e.IdEstado,
                        IdEmpresa = e.IdEmpresa
                    };
                    ent.AddToPresupuesto(presupuesto);
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


        public bool Modificar(clsPresupuesto e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Presupuesto where a.IdPresupuesto == e.IdPresupuesto select a).First();
                    x.IdPresupuesto = e.IdPresupuesto;
                    x.IdPersona = e.IdPersona;
                    x.IdArticulo = e.IdArticulo;
                    x.Fecha = e.Fecha;
                    x.TotalTiempoTrabajo = e.TotalTiempoTrabajo;
                    x.Subtotal = e.Subtotal;
                    x.Iva = e.Iva;
                    x.TotalPresupuesto = e.TotalPresupuesto;
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



        public bool GuardarTrabajos(clsPresupuestoMO e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    PresupuestoxManoObra presupuestomo = new PresupuestoxManoObra()
                    {
                        IdPresupuestoMO = e.IdPresupuestoMO,
                        IdPresupuesto = e.IdPresupuesto,
                        IdManoObra = e.IdManoObra,
                        IdTrabajo = e.IdTrabajo,
                        PrecioHora = e.PrecioHora,
                        Horas = e.NroHoras,
                        Total = e.Total,
                    };
                    ent.AddToPresupuestoxManoObra(presupuestomo);
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



        public bool ModificarTrabajo(clsPresupuestoMO e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.PresupuestoxManoObra where a.IdPresupuesto == e.IdPresupuesto select a).First();
                    x.IdPresupuestoMO = e.IdPresupuestoMO;
                    x.IdPresupuesto = e.IdPresupuesto;
                    x.IdManoObra = e.IdManoObra;
                    x.IdTrabajo = e.IdTrabajo;
                    x.PrecioHora = e.PrecioHora;
                    x.Horas = e.NroHoras;
                    x.Total = e.Total;
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



        public bool Eliminar(clsPresupuesto e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Presupuesto where a.IdPresupuesto == e.IdPresupuesto select a).First();
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

        public bool EliminarTrabajo(clsPresupuestoMO e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    ent.ExecuteStoreCommand("DELETE FROM Taller.PresupuestoxManoObra WHERE IdPresupuesto = {0}", e.IdPresupuesto);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

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


        //metodo que retorna el Id de un estado segun su descripcion
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

        //PARA EL TIPO TRABAJO
        public string getDescripcionSegunIdTipoTrabajo(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoTrabajo where a.IdTipoTrabajo == id select a).First();
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
