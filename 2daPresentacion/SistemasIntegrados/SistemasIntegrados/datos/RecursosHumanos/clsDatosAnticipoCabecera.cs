using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosAnticipoCabecera
    {
        public List<clsAnticipoCabecera > CoinsultaAnticipoCab()
        {
            try
            {
                List<clsAnticipoCabecera > Lista = new List<clsAnticipoCabecera >();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.AnticipoCab  select w;
                foreach (var item in con)
                {
                    clsAnticipoCabecera  clas = new clsAnticipoCabecera ();
                    clas.NumAnticipo = item.NumAnticipo;
                    clas.Fecha = item.Fecha;
                    clas.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    clas.Porcentaje  = item.Porcentaje ;
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

        public Boolean Guardar(clsAnticipoCabecera  ac)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    AnticipoCab  anc = new AnticipoCab ()
                    {

                        NumAnticipo = ac.NumAnticipo,
                        Fecha = ac.Fecha,
                        FechaModificacion = ac.FechaModificacion,
                        Porcentaje = ac.Porcentaje,
                        Total = Convert.ToDecimal(ac.Total),
                        IdEstado = ac.IdEstado,
                        IdEmpresa = ac.IdEmpresa,
                        Observacion = ac.Observacion,

                    };
                    ent.AddToAnticipoCab (anc );
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Modificar(clsAnticipoCabecera  ac)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.AnticipoCab   where q.NumAnticipo == ac.NumAnticipo select q).First();
                x.NumAnticipo = ac .NumAnticipo ;
                x.Fecha = ac.Fecha;
                x.FechaModificacion = ac.FechaModificacion;
                x.Porcentaje = ac.Porcentaje ;
                x.Total = Convert.ToDecimal(ac.Total);
                x.IdEstado = ac.IdEstado;
                x.IdEmpresa = ac.IdEmpresa;
                x.Observacion = ac.Observacion;

                ent.SaveChanges();

            }
        }

        public Boolean Eliminar(clsAnticipoCabecera  ac)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.AnticipoCab  where q.NumAnticipo == ac.NumAnticipo select q).First();
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
                int x = ((from a in ent.AnticipoCab  select a.NumAnticipo ).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }



        public clsDatosAnticipoCabecera()
        {

        }
    }
}
