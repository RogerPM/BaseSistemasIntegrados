using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using datos.Taller;
using clases.Taller;

namespace datos.Taller
{
    public class datManoObra
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.ManoObra select a.IdManoObra).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }


        //para consultar todos
        public List<clsManoObra> Consultar()
        {
            try
            {
                List<clsManoObra> listamanodeobra = new List<clsManoObra>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.ManoObra select w;
                foreach (var item in con)
                {
                    clsManoObra e = new clsManoObra();
                    e.IdManoObra = item.IdManoObra;
                    e.IdTipoTrabajo = item.IdTipoTrabajo;
                    e.Descripcion = item.TipoTrabajo.Descripcion;
                    e.PrecioHora = item.PrecioHora;
                    e.NroHoras = item.Horas;
                    e.Total = item.Total;
                    e.Observacion = item.Observacion;
                    e.IdEstado = item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    listamanodeobra.Add(e);
                }
                return listamanodeobra;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }

        public bool Guardar(clsManoObra e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdManoObra = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    ManoObra manodeobra = new ManoObra()
                    {
                        IdManoObra = e.IdManoObra,
                        IdTipoTrabajo = e.IdTipoTrabajo,
                        PrecioHora = e.PrecioHora,
                        Horas = e.NroHoras,
                        Total = e.Total,
                        Observacion = e.Observacion,
                        IdEstado = e.IdEstado,
                        IdEmpresa = e.IdEmpresa
                    };
                    ent.AddToManoObra(manodeobra);
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


        public bool Modificar(clsManoObra e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.ManoObra where a.IdManoObra == e.IdManoObra select a).First();
                    x.IdTipoTrabajo = e.IdTipoTrabajo;
                    x.PrecioHora = e.PrecioHora;
                    x.Horas = e.NroHoras;
                    x.Total = e.Total;
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



        public bool Eliminar(clsManoObra e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.ManoObra where a.IdManoObra == e.IdManoObra select a).First();
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



        //PARA EL TIPO MATERIAL
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


        //metodo que retorna el Id de un estado segun su descripcion
        public int getIdSegunDescripcionManoObra(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoTrabajo where a.Descripcion == descrip select a).First();
                    return x.IdTipoTrabajo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
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
