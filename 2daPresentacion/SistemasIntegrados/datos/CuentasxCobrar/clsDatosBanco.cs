using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosBanco
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.Banco select a.idBanco).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsBanco> consultaBancoGeneral()
        {
            try
            {
                List<clsBanco> lista = new List<clsBanco>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.Banco select b;
                foreach (var item in con)
                {
                    clsBanco Banco = new clsBanco();
                    Banco.idEmpresa = item.idEmpresa;
                    Banco.idBanco = item.idBanco;
                    Banco.Nombre = item.Nombre;
                    Banco.Estado = item.Estado;

                    lista.Add(Banco);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void consultaBancoEspecifica(clsBanco Banco)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.Banco where q.idBanco == Banco.idBanco select q).First();

                Banco.idEmpresa = x.idEmpresa; //Error no se puede convertit implicitamente int
                Banco.idBanco = x.idBanco;
                Banco.Nombre = x.Nombre;
                Banco.Estado = x.Estado;
            }

        }

        public List<clsEstado> consultaEstado()
        {

            try
            {
                List<clsEstado> lista = new List<clsEstado>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.Estado select w;
                foreach (var item in con)
                {
                    clsEstado est = new clsEstado();

                    est.idEstado = item.IdEstado;
                    est.descripcion = item.Descripcion;

                    lista.Add(est);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public Boolean modificar(clsBanco Banco)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.Banco where q.idBanco == Banco.idBanco select q).First();

                x.idEmpresa = Banco.idEmpresa; //Error no se puede convertit implicitamente int
                x.idBanco = Banco.idBanco;
                x.Nombre = Banco.Nombre;
                x.Estado = Banco.Estado;
                              
                ent.SaveChanges();
                return true;

            }

        }

        public Boolean guardar(clsBanco Banco)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    Banco ban = new Banco()
                    {
                        idEmpresa = Banco.idEmpresa,
                        idBanco = x,
                        Nombre = Banco.Nombre,
                        Estado = Banco.Estado,

                    };
                    ent.AddToBanco(ban);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public Boolean eliminar(clsBanco Banco)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.Banco where q.idBanco == Banco.idBanco select q).First();
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
