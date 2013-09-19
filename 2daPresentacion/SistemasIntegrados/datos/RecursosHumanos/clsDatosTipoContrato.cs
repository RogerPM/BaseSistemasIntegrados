using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;


namespace datos.RecursosHumanos
{
    public class clsDatosTipoContrato
    {
        public List<clsTipoContrato> ConsultaTipoContrato()
        {
            try
            {
                List<clsTipoContrato> Lista = new List<clsTipoContrato>();
                RecursosHumanosEntities  ent = new RecursosHumanosEntities();
                var con = from w in ent.TipoContrato  select w;
                foreach (var item in con)
                {
                    clsTipoContrato clas = new clsTipoContrato();
                    clas.IdTipoContrato = item.IdTipoContrato;
                    clas.Descripcion  = item.Descripcion ;
                    clas.Periodo  = item.Periodo ;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdEstado = item.IdEstado;
                    
                    Lista.Add(clas);
                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean Guardar(clsTipoContrato  tc)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    TipoContrato tp = new TipoContrato()
                    {
                        IdTipoContrato = tc.IdTipoContrato,
                        Descripcion = tc.Descripcion,
                        Periodo = tc.Periodo, 
                        IdEmpresa = tc.IdEmpresa,
                        IdEstado = tc.IdEstado, 
                    };
                    ent.AddToTipoContrato(tp);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Modificar(clsTipoContrato un)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.TipoContrato  where q.IdTipoContrato  == un.IdTipoContrato  select q).First();
                x.Descripcion = un.Descripcion;
                x.Periodo = un.Periodo;
                x.IdEmpresa = un.IdEmpresa;
                x.IdEstado  = un.IdEstado ;
                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsTipoContrato un)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.TipoContrato  where q.IdTipoContrato  == un.IdTipoContrato  select q).First();
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

        public int getIdSiguiente()
        {
            try
            {
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int x = ((from a in ent.TipoContrato  select a.IdTipoContrato ).Max()) + 1;
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
