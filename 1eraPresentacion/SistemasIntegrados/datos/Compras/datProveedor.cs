using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.Compras;
using System.IO;


namespace datos.Compras
{
    public class datProveedor
    {

        public List<clsProveedor> ConsultarProveedor()
        {
            try
            {
                List<clsProveedor> listaProveedor = new List<clsProveedor>();
                CompraEntities  enti = new CompraEntities ();
                var con = from t in enti.Proveedor select t;
                foreach (var item in con)
                {
                    clsProveedor e = new clsProveedor();
                    e.idProveedor = Convert.ToInt32 (item.IdProveedor);
                    e.idEmpresa = Convert.ToInt32(item.IdEmpresa);
                    e.idPersona = Convert.ToInt32 (item.IdPersona);
                    e.idArticulo = Convert.ToInt32 (item.IdTipoArticulo) ;
                    e.idEstado = Convert.ToInt32 (item.Estado);
                    listaProveedor.Add(e);
                }
                return listaProveedor;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datProveedor: " + ex);
                return null;
            }
        }

        public List<clsProveedorDescripcion> ConsultarProveedorDescripcion()
        {
            try
            {
                List<clsProveedorDescripcion > listaProveedorDesc = new List<clsProveedorDescripcion>();
                CompraEntities enti = new CompraEntities();
                var con = from t in enti.ProveedorDescripcion select t;
                foreach (var item in con)
                {
                    clsProveedorDescripcion e = new clsProveedorDescripcion();
                    e.idProveedor = item.IdProveedor;
                    e.idPersona = item.IdPersona;
                    e.nombrerazonsocial= item.NombreRazonSocial;
                    e.idEmpresa = item.IdEmpresa;
                    e.razonsocial = item.RazonSocial;
                    e.idTipoArticulo = item.IdTipoArticulo;
                    e.descripcion = item.Descripcion;
                    e.Estado = Convert.ToInt32(item.Estado);
                   
                    listaProveedorDesc.Add(e);
                }
                return listaProveedorDesc;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datProveedor: " + ex);
                return null;
            }
        }

        public bool Guardar(clsProveedor e)
        {
            try
            {
                int id = getIdSiguiente();
                e.idProveedor = id;
                using (CompraEntities  ent = new CompraEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Proveedor provee = new Proveedor ()
                    {
                        IdProveedor = e.idProveedor,
                        IdEmpresa = e.idEmpresa,
                        IdPersona  = e.idPersona,
                        IdTipoArticulo  = e.idArticulo,
                        Estado = e.idEstado
                    };
                    
                    ent.AddToProveedor (provee);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                return false;
            }
        }


        public bool Modificar(clsProveedor e)
        {
            try
            {
                using (CompraEntities ent = new CompraEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Proveedor where a.IdProveedor == e.idProveedor select a).First();
                    x.IdEmpresa = e.idEmpresa;
                    x.IdPersona = e.idPersona;
                    x.IdTipoArticulo = e.idArticulo;
                    x.Estado = e.idEstado;
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

        //obtener id siguiente de la tabla proveedor
        public int getIdSiguiente()
        {
            try
            {
                CompraEntities  ent = new CompraEntities ();
                int x = ((from a in ent.Proveedor  select a.IdProveedor).Max()) + 1;
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
