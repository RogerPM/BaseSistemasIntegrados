using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;
using System.IO;

namespace datos.Taller
{
    public class datTiposTrabajos
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.TipoTrabajo select a.IdTipoTrabajo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        //para consultar todos
        public List<clsTiposTrabajos> Consultar()
        {
            try
            {
                List<clsTiposTrabajos> listaTipoTrabajo = new List<clsTiposTrabajos>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.TipoTrabajo select w;
                foreach (var item in con)
                {
                    clsTiposTrabajos e = new clsTiposTrabajos();
                    e.idTipoTrabajo = item.IdTipoTrabajo;
                    e.Descripcion = item.Descripcion;
                    e.Observacion = item.Observación;
                    e.idEstado = Convert.ToInt32(item.IdEstado);
                    listaTipoTrabajo.Add(e);
                }
                return listaTipoTrabajo;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }

        public bool Guardar(clsTiposTrabajos e)
        {
            try
            {
                int id = getIdSiguiente();
                e.idTipoTrabajo = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    TipoTrabajo tipotrabajo = new TipoTrabajo()
                    {
                        IdTipoTrabajo = e.idTipoTrabajo,
                        Descripcion = e.Descripcion,
                        Observación = e.Observacion,
                        IdEstado = e.idEstado
                    };
                    ent.AddToTipoTrabajo(tipotrabajo);
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

        public bool Modificar(clsTiposTrabajos e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.TipoTrabajo where a.IdTipoTrabajo == e.idTipoTrabajo select a).First();
                    x.Descripcion = e.Descripcion;
                    x.Observación = e.Observacion;
                    x.IdEstado = e.idEstado;
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

        public bool Eliminar(clsTiposTrabajos e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.TipoTrabajo where a.IdTipoTrabajo == e.idTipoTrabajo select a).First();
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
    }
}
