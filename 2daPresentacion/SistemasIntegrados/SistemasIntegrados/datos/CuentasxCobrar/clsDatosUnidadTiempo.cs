using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosUnidadTiempo
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.UnidadTiempo select a.idUnidadTiempo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsUnidadTiempo> consultaUnidadTiempoGeneral()
        {
            try
            {
                List<clsUnidadTiempo> lista = new List<clsUnidadTiempo>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.UnidadTiempo select b;
                foreach (var item in con)
                {
                    clsUnidadTiempo UnidadTiempo = new clsUnidadTiempo();
                    UnidadTiempo.idEmpresa = item.idEmpresa;
                    UnidadTiempo.idUnidadTiempo = item.idUnidadTiempo;
                    UnidadTiempo.Descripcion = item.Descripcion;
                    UnidadTiempo.Estado = item.Estado;

                    lista.Add(UnidadTiempo);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean modificar(clsUnidadTiempo UnidadTiempo)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.UnidadTiempo where q.idUnidadTiempo == UnidadTiempo.idUnidadTiempo select q).First();

                x.idEmpresa = UnidadTiempo.idEmpresa; //Error no se puede convertit implicitamente int
                x.idUnidadTiempo = UnidadTiempo.idUnidadTiempo;
                x.Descripcion = UnidadTiempo.Descripcion;
                x.Estado = UnidadTiempo.Estado;

                ent.SaveChanges();
                return true;

            }

        }

        public Boolean guardar(clsUnidadTiempo UnidadTiempo)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    UnidadTiempo uni = new UnidadTiempo()
                    {
                        idEmpresa = UnidadTiempo.idEmpresa,
                        idUnidadTiempo = x,
                        Descripcion = UnidadTiempo.Descripcion,
                        Estado = UnidadTiempo.Estado,

                    };
                    ent.AddToUnidadTiempo(uni);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Boolean eliminar(clsUnidadTiempo UnidadTiempo)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.UnidadTiempo where q.idUnidadTiempo == UnidadTiempo.idUnidadTiempo select q).First();
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
