using System;
using System.ComponentModel;//Esto se ve en la utilizacion del Idispose
// a resource class that implements the IDisposable interface
// and the IDisposable.Dispose method.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using clases.Compras;
using clases.RecursosHumanos;
using datos.RecursosHumanos;
using datos.Compras;

namespace datos.ActivoFijo
{
    public  class clsClaseDatosBajaActivo
    {


        public List<clsPersona> consultaEspecial() //Esta operacion sera para ver cuales son los proveedores en la tabla persona
        {
            try
            {
                List<clsPersona> lista = new List<clsPersona>();

                CompraEntities aux = new CompraEntities();
                var auxi = from q in aux.Proveedor select q;
                foreach (var item in auxi)
                {
                    RecursosHumanosEntities ent = new RecursosHumanosEntities();
      
                        clsPersona perso = new clsPersona();
                        var x = (from a in ent.Persona where a.IdPersona == item.IdPersona select a).First();
                        perso.IdPersona = x.IdPersona;
                        perso.Identificacion = Convert.ToInt32(x.Identificacion);
                        perso.IdEmpresa = x.IdEmpresa;
                        perso.NombreRazonSocial = x.NombreRazonSocial;
                        perso.General = Convert.ToInt32(x.TelefonoGneral);
                        perso.mail = x.mail;  
                        lista.Add(perso);
                   
                }

                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public string getDescripcionSegunIdActivoFijo(int id)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.ActivoFijo where a.IdActivoFijo == id select a).First();
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
        public int getIdSegunDescripcionSegunIdActivoFijo(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.ActivoFijo where a.descripcion == descrip select a).First();
                    return x.IdActivoFijo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

    public List<clsBajaActivo>consulta()
    {
        try
            {
                List<clsBajaActivo> lista= new List<clsBajaActivo>();
                ActivoFijoEntities  ent = new ActivoFijoEntities ();
                var con = from w in ent.BajaActivo select w;
                
                foreach (var item in con)
                {
                    clsBajaActivo clas = new clsBajaActivo();
                    clas.Codigo       = item.idBajaActivo;
                    clas.ActivoFIjo   = Convert.ToInt32(item.IdActivoFIjo);
                    clas.Fecha        = Convert.ToDateTime(item.Fecha);                    
                    clas.IdEmpresa    = Convert.ToInt32(item.IdEmpresa);
                    clas.Descripcion  = item.Descripcion;
                    clas.Motivo       = Convert.ToInt32( item.IdMotivoBaja);
                    clas.Observacion  = item.Observacion;
                    clas.IdCabeceraComprobante = Convert.ToInt32(item.IdCabeceraComprobante);

                    lista.Add (clas);
                }
                return lista;

        }
            catch (Exception)
            {

                return null;
            }


        }
   

    public void modificar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities  ent = new ActivoFijoEntities())
        {
            var x = (from q in ent.BajaActivo where q.idBajaActivo == baja.Codigo select q).First();
            x.idBajaActivo = baja.Codigo;
            x.IdActivoFIjo = baja.ActivoFIjo;        
            x.Fecha        = baja.Fecha;
            x.IdEmpresa    = baja.IdEmpresa;
            x.Descripcion  = baja.Descripcion;
            x.IdMotivoBaja       = baja.Motivo;
            x.Observacion  = baja.Observacion;
            ent.SaveChanges();
        }
    }
 
    public void guardar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities ent = new ActivoFijoEntities())
        {
            BajaActivo baj = new BajaActivo()
            {
                idBajaActivo = baja.Codigo,
                IdActivoFIjo = baja.ActivoFIjo,
                Fecha        = baja.Fecha,
                IdEmpresa    = baja.IdEmpresa,
                Descripcion  = baja.Descripcion,
                IdMotivoBaja       = baja.Motivo,
             // IdCabeceraComprobante = baja.IdCabeceraComprobante,
                Observacion  = baja.Observacion,
            };
            ent.AddToBajaActivo(baj);
            ent.SaveChanges();
        }
    }

    public void eliminar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities ent = new ActivoFijoEntities())
        {
            //Hago un wehere por el primaryKey codigo
            var x = (from q in ent.BajaActivo where q.idBajaActivo == baja.Codigo select q).First();
            //Eliminar es muy parecido
            //Eliminar el registro que me trajpp el select
            ent.DeleteObject(x);
            ent.SaveChanges();
        }

    }

    }
}

