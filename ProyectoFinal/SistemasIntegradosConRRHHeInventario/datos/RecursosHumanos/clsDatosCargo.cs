using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;
using clases.Seguridad; 

namespace datos.RecursosHumanos
{
    public class clsDatosCargo
    {
        public List<clsCargo> ConsultaCargo()
        {
            try
            {
                List<clsCargo> lista = new List<clsCargo>();
                RecursosHumanosEntities  ent = new RecursosHumanosEntities ();
                var con = from w in ent.Cargo  select w;
                foreach (var item in con)
                {
                    clsCargo clas = new clsCargo();
                    clas.IdCargo = item.IdCargo;
                    clas.Descripcion = item.Descripcion;
                    clas.Sueldo  = Convert.ToDouble(item.Sueldo);
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

        public void Modificar(clsCargo M)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {
                var x = (from q in ent.Cargo  where q.IdCargo == M.IdCargo select q).First();

                x.Descripcion = M.Descripcion;
                x.Sueldo  = Convert.ToDecimal(M.Sueldo) ;
                x.IdEstado = M.IdEstado;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsCargo M)
        {
            try
            {
                int id = getIdSiguiente();
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    Cargo  p = new Cargo()
                    {
                        IdCargo = id,
                        Descripcion = M.Descripcion,
                        Sueldo = Convert.ToDecimal(M.Sueldo), 
                        IdEstado = M.IdEstado,
                        

                    };
                    ent.AddToCargo(p);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }

        public Boolean Eliminar(clsCargo M)
        {
            try
            {
                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    var x = (from q in ent.Cargo  where q.IdCargo == M.IdCargo select q).First();

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
                int x = ((from a in ent.Cargo select a.IdCargo).Max()) + 1;

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
