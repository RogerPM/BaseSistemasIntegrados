using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using System.IO;

namespace datos.ActivoFijo
{
    public class datosmotivobaja
    {
        public string getDescripcionSegunIdActivoFijo(int id)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {

                    var x = (from a in ent.MotivoBaja where a.IdMotivoBaja == id select a).First();
                    return x.descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null; //en caso de que no exista algun registro
            }
        }

        public int getIdSegunDescripcionSegunIdc(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.MotivoBaja where a.descripcion == descrip select a).First();
                    return x.IdMotivoBaja; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

        public int getSiguiente()
        {
            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.MotivoBaja select a.IdMotivoBaja).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }







        public List<clsMotivoBaja> Consultar()
        {
            try
            {
                List<clsMotivoBaja> listaMotivoBaja = new List<clsMotivoBaja>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.MotivoBaja select w;
                foreach (var item in con) //se cae xq es version antigua no tiene sector
                {
                    clsMotivoBaja e = new clsMotivoBaja();
                    e.idMotivoBaja = item.IdMotivoBaja;
                    e.descripcion = item.descripcion;
                    e.idEstado = Convert.ToInt32(item.Idestado);
                    listaMotivoBaja.Add(e);
                }
                return listaMotivoBaja;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datosmotivobaja: " + ex);
                return null;
            }

        }



        public Boolean guardar(clsMotivoBaja motivobaja)
        {
            try
            {
                int id = getSiguiente();
                motivobaja.idMotivoBaja = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    MotivoBaja Sub = new MotivoBaja()
                    {
                        IdMotivoBaja = motivobaja.idMotivoBaja,
                        Idestado = motivobaja.idEstado,
                        descripcion = motivobaja.descripcion,
                        

                    };

                    ent.AddToMotivoBaja(Sub);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }







        public Boolean modificar(clsMotivoBaja motivoBaja)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.MotivoBaja where q.IdMotivoBaja == motivoBaja.idMotivoBaja select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                    x.IdMotivoBaja = motivoBaja.idMotivoBaja;
                    x.descripcion = motivoBaja.descripcion;
                    x.Idestado = motivoBaja.idEstado;
                   
                    // x.EstadoProceso = SubActivo._EstadoProceso;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

        public Boolean eliminar(clsMotivoBaja motivoBaja)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Hago un wehere por el primaryKey codigo
                    var x = (from q in ent.MotivoBaja where q.IdMotivoBaja == motivoBaja.idMotivoBaja select q).First();
                    //Eliminar es muy parecido
                    //Eliminar el registro que me trajpp el select
                    ent.DeleteObject(x);
                    ent.SaveChanges();
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






