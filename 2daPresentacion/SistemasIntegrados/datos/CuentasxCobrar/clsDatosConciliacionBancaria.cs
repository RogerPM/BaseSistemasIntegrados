using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosConciliacionBancaria
    {
        public List<clsConciliacionBancaria> consulta()
        {
            try
            {
                List<clsConciliacionBancaria> lista = new List<clsConciliacionBancaria>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.ConciliacionBancaria select w;
                foreach (var item in con)
                {
                    clsConciliacionBancaria conb = new clsConciliacionBancaria();
                    conb.idConciliacionBancaria = item.idConciliacionBancaria;
                    conb.idEmpresa = item.idEmpresa;
                    conb.idBanco = item.idBanco;
                    conb.FechaConciliacion = Convert.ToDateTime(item.FechaConciliacion);
                    conb.FechaModificacion = Convert.ToDateTime(item.idConciliacionBancaria);
                    conb.FechaDesde = Convert.ToDateTime(item.idConciliacionBancaria);
                    conb.FechaHasta = Convert.ToDateTime(item.idConciliacionBancaria);
                    conb.Saldo = item.idConciliacionBancaria;
                    conb.TotalEgresos = item.idConciliacionBancaria;
                    conb.TotalIngresos = item.idConciliacionBancaria;

                    conb.TotalConciliacion = item.idConciliacionBancaria;
                    conb.idEstado = item.idConciliacionBancaria;
                    conb.idUsuario = item.idConciliacionBancaria;

                    lista.Add(conb);


                }
                return lista;
            }
            catch (Exception)
            {
                
                return null;
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

        public Boolean guardar(clsConciliacionBancaria conciliaban)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    
                    ConciliacionBancaria conban = new ConciliacionBancaria()
                    {
                        idEmpresa = conciliaban.idEmpresa,
                        idUsuario = conciliaban.idUsuario,
                        idConciliacionBancaria = getSiguiente(),
                        idBanco = conciliaban.idBanco,
                        NumeroCuenta= conciliaban.NumeroCuenta,
                        FechaModificacion = conciliaban.FechaModificacion,
                        FechaConciliacion=conciliaban.FechaConciliacion,
                        FechaDesde = conciliaban.FechaDesde,
                        FechaHasta = conciliaban.FechaHasta,
                        TotalIngresos = conciliaban.TotalIngresos,
                        TotalEgresos = conciliaban.TotalEgresos,
                        Saldo = conciliaban.Saldo,
                        TotalConciliacion = conciliaban.TotalConciliacion,
                        idEstado = conciliaban.idEstado,
                                          

                    };
                    ent.AddToConciliacionBancaria(conban);
                    ent.SaveChanges();


                }
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }

        public clsPagodet consultitaBanco(int num)
        {

            try
            {
                clsPagodet lista = new clsPagodet();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.PagoDet where w.NumPago ==num select w;
                foreach (var item in con)
                {
                    clsPagodet est = new clsPagodet();

                    est.NumeroCuenta = item.NumeroCuenta;
                    est.IdBanco = item.IdBanco ;

                    return (est);

                }

                return (lista) ;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public Boolean anular(clsConciliacionBancaria conciliaban)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.ConciliacionBancaria where q.idConciliacionBancaria == conciliaban.idConciliacionBancaria select q).First();

                x.idConciliacionBancaria = conciliaban.idConciliacionBancaria;
                x.idBanco = conciliaban.idBanco;
                x.idEmpresa = conciliaban.idEmpresa;
                x.NumeroCuenta = conciliaban.NumeroCuenta;
                x.idUsuario = conciliaban.idUsuario;
                x.FechaConciliacion = conciliaban.FechaConciliacion;
                x.FechaModificacion = conciliaban.FechaModificacion;
                x.FechaDesde = conciliaban.FechaDesde;
                x.FechaHasta = conciliaban.FechaHasta;
                x.Saldo = conciliaban.Saldo;
                x.TotalEgresos = conciliaban.TotalEgresos;
                x.TotalIngresos = conciliaban.TotalIngresos;
                x.TotalConciliacion = conciliaban.TotalConciliacion;

                x.idEstado = 2;


                ent.SaveChanges();

                return true;
            }
        }


        public int getSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.ConciliacionBancaria select a.idConciliacionBancaria).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {

                Console.WriteLine("error: " + e);
                return 1; //encaso de que no exista ningun registro
            }
        }


    }
}
