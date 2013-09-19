using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;

namespace datos.Taller
{
    public class datCliente
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Persona select a.IdPersona).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        //para consultar todos
        public List<clsCliente> Consultar()
        {
            try
            {
                List<clsCliente> listaCliente = new List<clsCliente>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Persona select w;
                foreach (var item in con)
                {
                    clsCliente e = new clsCliente();
                    e.IdPersona = item.IdPersona;
                    e.Identificacion = item.Identificacion;
                    e.IdTipoPersona = item.IdTipoPersona;
                    e.Nombre = item.NombreRazonSocial;
                    e.Apellido = item.Apellido;
                    e.FechaNacimiento = item.FechaNacimiento;
                    e.Genero = item.Genero;
                    e.TipoIdentificacion = item.TipoIdentificacion;
                    e.Direccion = item.Direccion;
                    e.Telefono = item.Telefono;
                    e.Mail = item.Mail;
                    e.idEstado = item.IdEstado;
                    e.idEmpresa = item.IdEmpresa;
                    listaCliente.Add(e);
                }
                return listaCliente;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }

        public bool Guardar(clsCliente e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdPersona = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Persona persona = new Persona()
                    {
                        IdPersona = e.IdPersona,
                        Identificacion = e.Identificacion,
                        IdTipoPersona = e.IdTipoPersona,
                        NombreRazonSocial = e.Nombre,
                        Apellido = e.Apellido,
                        FechaNacimiento = e.FechaNacimiento,
                        Genero = e.Genero,
                        TipoIdentificacion = e.TipoIdentificacion,
                        Direccion = e.Direccion,
                        Telefono = e.Telefono,
                        Mail = e.Mail,
                        IdEstado = e.idEstado,
                        IdEmpresa = e.idEmpresa
                    };
                    ent.AddToPersona(persona);
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

        public bool Modificar(clsCliente e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Persona where a.IdPersona == e.IdPersona select a).First();
                        x.Identificacion = e.Identificacion;
                        x.IdTipoPersona = e.IdTipoPersona;
                        x.NombreRazonSocial = e.Nombre;
                        x.Apellido = e.Apellido;
                        x.FechaNacimiento = e.FechaNacimiento;
                        x.Genero = e.Genero;
                        x.TipoIdentificacion = e.TipoIdentificacion;
                        x.Direccion = e.Direccion;
                        x.Telefono = e.Telefono;
                        x.Mail = e.Mail;
                        x.IdEstado = e.idEstado;
                        x.IdEmpresa = e.idEmpresa;
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

        public bool Eliminar(clsCliente e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Persona where a.IdPersona == e.IdPersona select a).First();
                    ent.DeleteObject(x);//elimina el registro
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



        public List<clsTipoIdentificacion> ConsultarTipoIdentificacion()
        {
            try
            {
                List<clsTipoIdentificacion> listatipoidentificacion = new List<clsTipoIdentificacion>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.TipoIdentificacion select w;
                foreach (var item in con)
                {
                    clsTipoIdentificacion e = new clsTipoIdentificacion();
                    e.IdTipoIdentificacion = item.IdTipoIdentificacion;
                    e.Descripcion = item.descripcion;
                    e.IdEstado = item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    listatipoidentificacion.Add(e);
                }
                return listatipoidentificacion;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }



        public List<clsTipoPersona> ConsultarTipoPersona()
        {
            try
            {
                List<clsTipoPersona> listatipopersona = new List<clsTipoPersona>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.TipoPersona select w;
                foreach (var item in con)
                {
                    clsTipoPersona e = new clsTipoPersona();
                    e.IdTipoPersona = item.IdTipoPersona;
                    e.Descripcion = item.Descripcion;
                    e.IdEstado = item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    listatipopersona.Add(e);
                }
                return listatipopersona;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }



        //PARA EL TIPO PERSONA
        public string getDescripcionSegunIdTipoPersona(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoPersona where a.IdTipoPersona == id select a).First();
                    return x.Descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        //metodo que retorna el Id de un estado segun su descripcion
        public int getIdSegunDescripcionTipoPersona(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoPersona where a.Descripcion == descrip select a).First();
                    return x.IdTipoPersona; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



        //PARA EL TIPO IDENTIFICACION
        public string getDescripcionSegunIdTipoIdentificacion(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoIdentificacion where a.IdTipoIdentificacion == id select a).First();
                    return x.descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }


        //metodo que retorna el Id de un estado segun su descripcion
        public int getIdSegunDescripcionTipoIdentificacion(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoIdentificacion where a.descripcion == descrip select a).First();
                    return x.IdTipoIdentificacion; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }
    }
}
