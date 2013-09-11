using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad;

namespace datos.RecursosHumanos
{
    public class clsDatosTipoPrestamo
    {

        public List<clsTipoPrestamo> consultaTipoPrestamo()
        {
            try
            {

                List<clsTipoPrestamo> lista = new List<clsTipoPrestamo>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from w in ent.TipoPrestamo select w;
                foreach (var item in con)
                {
                    clsTipoPrestamo clas = new clsTipoPrestamo();
                    clas.IdTipoPrestamo = item.IdTipoPrestamo;
                    clas.Nombre = item.Nombre;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdEstado = item.IdEstado;
                    lista.Add(clas);

                }

                return lista;

            }

            catch (Exception)
            {
                return null;
            }
        }

        public void Modificar(clsTipoPrestamo Medio)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            { 
                var x = (from q in ent.TipoPrestamo where q.IdTipoPrestamo == Medio .IdTipoPrestamo select q).First ();

                x.Nombre = Medio.Nombre;
                x.IdEmpresa = Medio.IdEmpresa;
                x.IdEstado = Medio.IdEstado;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsTipoPrestamo Medio)
        {
            try
            {
                int id = getIdSiguiente();
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    TipoPrestamo pago = new TipoPrestamo()
                    {
                        IdTipoPrestamo = id,
                        Nombre = Medio.Nombre,
                        IdEmpresa = Medio.IdEmpresa,
                        IdEstado = Medio.IdEstado,
                    };
                    ent.AddToTipoPrestamo(pago);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean Eliminar(clsTipoPrestamo Medio)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    var x = (from q in ent.TipoPrestamo where q.IdTipoPrestamo == Medio.IdTipoPrestamo select q).First();
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
                int x = ((from a in ent.TipoPrestamo select a.IdTipoPrestamo).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }
    }
}
