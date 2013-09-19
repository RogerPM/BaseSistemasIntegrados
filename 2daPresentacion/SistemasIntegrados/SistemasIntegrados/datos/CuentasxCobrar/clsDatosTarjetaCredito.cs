using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;

namespace datos.CuentasxCobrar
{
    public class clsDatosTarjetaCredito
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.TarjetaCredito select a.idTarjeta).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<ObjetoGenerico> consultaTarjetaCreditoGeneralINNER()
        {
            try
            {
                List<ObjetoGenerico> lista = new List<ObjetoGenerico>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();


                var con = from t1 in ent.TarjetaCredito
                          join t2 in ent.Banco on t1.idBanco equals t2.idBanco
                          select new
                          {
                              t1.idEmpresa,
                              t1.idTarjeta,
                              t1.descripcion,
                              t2.Nombre,
                              t1.Estado
                          }


                    /*from b in ent.CuentaBancaria select b*/;
                foreach (var item in con)
                {
                    ObjetoGenerico TarjetaCredito = new ObjetoGenerico();
                    TarjetaCredito.Campo1 = Convert.ToString(item.idEmpresa);
                    TarjetaCredito.Campo2 = Convert.ToString(item.idTarjeta);
                    TarjetaCredito.Campo3 = Convert.ToString(item.descripcion);
                    TarjetaCredito.Campo4 = Convert.ToString(item.Nombre);
                    TarjetaCredito.Campo8 = Convert.ToString(item.Estado);

                    lista.Add(TarjetaCredito);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ConsultaTarjetaCreditoEspecifica(clsTarjetaCredito TarjetaCredito)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.TarjetaCredito where q.idTarjeta == TarjetaCredito.idTarjeta select q).First();

                TarjetaCredito.idEmpresa = Convert.ToInt32(x.idEmpresa); //Error no se puede convertit implicitamente int
                TarjetaCredito.idTarjeta = Convert.ToInt32(x.idTarjeta);
                TarjetaCredito.Descripcion = x.descripcion;
                TarjetaCredito.idBanco = Convert.ToInt32(x.idBanco);
                TarjetaCredito.Estado = x.Estado;
            }

        }

        public List<clsTarjetaCredito> consultaTarjetaCreditoGeneral()
        {
            try
            {
                List<clsTarjetaCredito> lista = new List<clsTarjetaCredito>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.TarjetaCredito select b;
                foreach (var item in con)
                {
                    clsTarjetaCredito TarjetaCredito = new clsTarjetaCredito();
                    TarjetaCredito.idEmpresa = item.idEmpresa;
                    TarjetaCredito.idTarjeta = item.idTarjeta;
                    TarjetaCredito.Descripcion = item.descripcion;
                    TarjetaCredito.idBanco = item.idBanco;
                    TarjetaCredito.Estado = item.Estado;

                    lista.Add(TarjetaCredito);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean modificar(clsTarjetaCredito TarjetaCredito)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.TarjetaCredito where q.idTarjeta == TarjetaCredito.idTarjeta select q).First();

                x.idEmpresa = TarjetaCredito.idEmpresa; //Error no se puede convertit implicitamente int
                x.idTarjeta = TarjetaCredito.idTarjeta;
                x.descripcion = TarjetaCredito.Descripcion;
                x.idBanco = TarjetaCredito.idBanco;
                x.Estado = TarjetaCredito.Estado;
                ent.SaveChanges();
                return true;

            }

        }

        public Boolean guardar(clsTarjetaCredito TarjetaCredito)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    TarjetaCredito TCre = new TarjetaCredito()
                    {
                        idEmpresa = TarjetaCredito.idEmpresa,
                        idTarjeta = x,
                        descripcion = TarjetaCredito.Descripcion,
                        idBanco = TarjetaCredito.idBanco,
                        Estado = TarjetaCredito.Estado,

                    };
                    ent.AddToTarjetaCredito(TCre);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean eliminar(clsTarjetaCredito TarjetaCredito)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.TarjetaCredito where q.idTarjeta == TarjetaCredito.idTarjeta select q).First();
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
