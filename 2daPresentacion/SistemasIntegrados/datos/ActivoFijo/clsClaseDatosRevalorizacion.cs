using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosRevalorizacion
    {
        #region"Funiciones de Programa"

        public int getSiguiente()
        {
            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.revalorizacion  select a.IdRevalorizacion).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        #endregion



        #region"Operaciones Basicas"

       


        public List<clsRevalorizacion> consulta()
        {
            try
            {
                List<clsRevalorizacion> lista = new List<clsRevalorizacion>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.revalorizacion select w;

                foreach (var item in con)
                {
                    var x = (from a in ent.ActivoFijo  where a.IdActivoFijo == item.IdActivoFijo select a).First();

                    clsRevalorizacion  reval = new clsRevalorizacion();
                        reval.Codigo =Convert.ToInt32 (item.IdRevalorizacion);
                        //reval.usuario=Convert.ToInt32 (item.IdUsuario);
                        reval.Fecha=Convert.ToDateTime(  item.Fecha );
                        reval.nomActivo =Convert.ToString (x.descripcion);
                        reval.ValoAdquisicion = Convert.ToDouble(item.ValorAtual  );
                        reval.valorRevalorizado  = Convert.ToDouble(item.ValorRevalorizado);
                        reval.valorResidual = Convert.ToDouble(item.ValorResidual);

                    lista.Add(reval );
                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Boolean modificar(clsRevalorizacion reval)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.revalorizacion  where q.IdRevalorizacion  == reval.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdRevalorizacion = reval.Codigo;
                        x.IdUsuario  = reval.usuario;
                        x.Fecha = reval.Fecha;
                        x.IdActivoFijo = reval._idActivoFijo;
                        x.ValorAtual  = Convert.ToInt32(reval.ValoAdquisicion);
                        x.ValorRevalorizado = Convert.ToInt32(reval.valorRevalorizado);
                        x.ValorResidual = Convert.ToInt32(reval.valorResidual);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }
        public Boolean guardar(clsRevalorizacion  reval)
        {
            try
            {
                int id = getSiguiente();
                reval.Codigo = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    revalorizacion revalor = new revalorizacion()
                    {
                        IdRevalorizacion = reval.Codigo,
                        IdUsuario  = reval.usuario,
                        Fecha = reval.Fecha,
                        IdActivoFijo = reval._idActivoFijo ,
                        ValorAtual  = Convert.ToInt32(reval.ValoAdquisicion),
                        ValorRevalorizado = Convert.ToInt32(reval.valorRevalorizado),
                        ValorResidual = Convert.ToInt32 (reval.valorResidual),
                    };

                    ent.AddTorevalorizacion(revalor);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


        public Boolean eliminar(clsRevalorizacion reval)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Hago un wehere por el primaryKey codigo
                    var x = (from q in ent.revalorizacion where q.IdRevalorizacion == reval.Codigo select q).First();
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


        #endregion

    }
}
