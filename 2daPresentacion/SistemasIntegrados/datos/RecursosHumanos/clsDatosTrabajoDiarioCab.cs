using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosTrabajoDiarioCab
    {
        public List<clsTrabajoDiarioCab> ConsultaTrabajoDiarioCab()
        {
            try
            {
                List<clsTrabajoDiarioCab> Lista = new List<clsTrabajoDiarioCab>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.TrabajoDiarioCab select w;
                foreach (var item in con)
                {
                    clsTrabajoDiarioCab clas = new clsTrabajoDiarioCab();
                    clas.NumTrabajo = item.NumTrabajo;
                    clas.Fecha = item.Fecha;

                    clas.IdEstado = item.IdEstado;
                    clas.IdEmpresa = item.IdEstado;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.Observacion = item.Observacion;

                    Lista.Add(clas);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean Guardar(clsTrabajoDiarioCab tc)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    TrabajoDiarioCab trc = new TrabajoDiarioCab()
                    {
                        NumTrabajo = tc.NumTrabajo,
                        Fecha = tc.Fecha,

                        IdEstado = tc.IdEstado,
                        IdEmpresa = tc.IdEmpresa,
                        Observacion = tc.Observacion,

                    };
                    ent.AddToTrabajoDiarioCab(trc);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsTrabajoDiarioCab tdc)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.TrabajoDiarioCab where q.NumTrabajo == tdc.NumTrabajo select q).First();
                x.NumTrabajo = tdc.NumTrabajo;
                x.Fecha = tdc.Fecha;

                x.IdEstado = tdc.IdEstado;
                x.IdEmpresa = tdc.IdEmpresa;
                x.Observacion = tdc.Observacion;


                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsTrabajoDiarioCab tdrc)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.TrabajoDiarioCab where q.NumTrabajo == tdrc.NumTrabajo select q).First();
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
                int x = ((from a in ent.TrabajoDiarioCab select a.NumTrabajo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public clsDatosTrabajoDiarioCab()
        {

        }
    }
}
