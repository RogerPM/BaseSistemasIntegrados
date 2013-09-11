using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
   public  class datosCuentaBancaria
    {
        public List<clsCuentaBancaria2> consulta()
        {

            try
            {
                List<clsCuentaBancaria2> lista = new List<clsCuentaBancaria2>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaBancaria2 select w;
                foreach (var item in con)
                {
                    clsCuentaBancaria2 clas = new clsCuentaBancaria2();
                    clas.Serie =item.Serie ;
                    clas.TipoCuenta =Convert.ToInt32  (item.TipoCuenta );
                    clas.NroCta = Convert.ToInt32  (item.NroCta);
                    clas.IdBanco = item.IdBanco;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdEmpresaServicio = item.IdEmpresaServicio;
                    
                    lista.Add(clas);
                  
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }
        }

        public List<clsCuentaBancaria2> consultaPorEmpresa(String idEmpresa)
        {

            try
            {clsCuentaBancaria2 clas = new clsCuentaBancaria2();
                List<clsCuentaBancaria2> lista = new List<clsCuentaBancaria2>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaBancaria2 select w;
                foreach (var item in con)
                {
                    if (idEmpresa == item.IdEmpresaServicio)
                    {
                        clas.Serie = item.Serie;
                        clas.TipoCuenta =Convert.ToInt32  ( item.TipoCuenta);
                        clas.NroCta = Convert.ToInt32 (item.NroCta);
                        clas.IdBanco = item.IdBanco;
                        clas.IdEmpresa = item.IdEmpresa;
                        clas.IdEmpresaServicio = item.IdEmpresaServicio;


                        lista.Add(clas);
                    }
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }
        }

        public void Modificar(clsCuentaBancaria2 Cuenta)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.CuentaBancaria2  where q.Serie  == Cuenta.Serie select q).First();

                x.TipoCuenta = Convert.ToString (Cuenta.TipoCuenta);
                x.NroCta = Convert.ToString (Cuenta.NroCta);
                x.IdBanco = Cuenta.IdBanco;
                x.IdEmpresa = Cuenta.IdEmpresa;
                x.IdEmpresaServicio = Cuenta.IdEmpresaServicio;
                ent.SaveChanges();
                 
            }
        }

        public Boolean Guardar(clsCuentaBancaria2  Cuenta)
        {
            try
            {
                
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    CuentaBancaria2 pago = new CuentaBancaria2()
                    {
                        Serie = Cuenta.Serie ,
                        TipoCuenta =Convert.ToString  (Cuenta .TipoCuenta),
                        NroCta  =Convert .ToString ( Cuenta.NroCta),//Frecuencia.FechaActual,
                        IdBanco = Cuenta.IdBanco,
                       IdEmpresa = Cuenta.IdEmpresa,
                       IdEmpresaServicio= Cuenta.IdEmpresaServicio,
                    };
                     
                    ent.AddToCuentaBancaria2(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean Eliminar(clsCuentaBancaria2  Cuenta)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.CuentaBancaria2 where q.Serie == Cuenta.Serie select q).First();

                    ent.DeleteObject(x);

                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
       
    }


}


