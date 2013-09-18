using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosNominaCab
    {
        public List<clsNominaCab> ConsultaNominaCab()
        {
            try
            {
                List<clsNominaCab> Lista = new List<clsNominaCab>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.NominaCab select w;
                foreach (var item in con)
                {
                    clsNominaCab clas = new clsNominaCab();
                    clas.NumNomina = item.NumNomina;
                    clas.Fecha = item.Fecha;
                    clas.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    clas.Periodo = item.Periodo;
                    clas.Total = Convert.ToDouble(item.Total);
                    clas.IdEstado = item.IdEstado;
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

        public Boolean Guardar(clsNominaCab nc)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    NominaCab nec = new NominaCab()
                    {

                        NumNomina = nc.NumNomina,
                        Fecha = nc.Fecha,
                        FechaModificacion = nc.FechaModificacion,
                        Periodo = nc.Periodo,
                        Total = Convert.ToDecimal(nc.Total),
                        IdEstado = nc.IdEstado,
                        IdEmpresa = nc.IdEmpresa,
                        Observacion = nc.Observacion,

                    };
                    ent.AddToNominaCab(nec);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsNominaCab nc)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.NominaCab where q.NumNomina == nc.NumNomina select q).First();
                x.NumNomina = nc.NumNomina;
                x.Fecha = nc.Fecha;
                x.FechaModificacion = nc.FechaModificacion;
                x.Periodo = nc.Periodo;
                x.Total = Convert.ToDecimal(nc.Total);
                x.IdEstado = nc.IdEstado;
                x.IdEmpresa = nc.IdEmpresa;
                x.Observacion = nc.Observacion;

                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsNominaCab nomc)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.NominaCab where q.NumNomina == nomc.NumNomina select q).First();
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
                int x = ((from a in ent.NominaCab select a.NumNomina).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }



        public clsDatosNominaCab()
        {

        }
    }
}
