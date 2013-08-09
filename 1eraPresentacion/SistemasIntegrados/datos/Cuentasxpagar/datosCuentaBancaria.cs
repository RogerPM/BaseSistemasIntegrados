using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
   public  class datosCuentaBancaria
    {
        public List<clsCuentaBancaria> consulta()
        {

            try
            {
                List<clsCuentaBancaria> lista = new List<clsCuentaBancaria>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaBancaria select w;
                foreach (var item in con)
                {
                    clsCuentaBancaria clas = new clsCuentaBancaria();
                    clas.Serie = item.Serie;
                    clas.TipoCuenta = item.TipoCuenta;
                    clas.NroCta = (item.NroCta);
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

        public List<clsCuentaBancaria> consultaPorEmpresa(String idEmpresa)
        {

            try
            {clsCuentaBancaria clas = new clsCuentaBancaria();
                List<clsCuentaBancaria> lista = new List<clsCuentaBancaria>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaBancaria select w;
                foreach (var item in con)
                {
                    if (idEmpresa == item.IdEmpresaServicio)
                    {
                        clas.Serie = item.Serie;
                        clas.TipoCuenta = item.TipoCuenta;
                        clas.NroCta = (item.NroCta);
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

        public void Modificar(clsCuentaBancaria Cuenta)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.CuentaBancaria  where q.Serie  == Cuenta.Serie select q).First();

                x.TipoCuenta = Cuenta.TipoCuenta;
                x.NroCta = Cuenta.NroCta;
                x.IdBanco = Cuenta.IdBanco;
                x.IdEmpresa = Cuenta.IdEmpresa;
                x.IdEmpresaServicio = Cuenta.IdEmpresaServicio;
                ent.SaveChanges();
                 
            }
        }

        public Boolean Guardar(clsCuentaBancaria  Cuenta)
        {
            try
            {
                
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    CuentaBancaria pago = new CuentaBancaria()
                    {
                        Serie = Cuenta.Serie ,
                        TipoCuenta = Cuenta .TipoCuenta,
                        NroCta  = Cuenta.NroCta,//Frecuencia.FechaActual,
                        IdBanco = Cuenta.IdBanco,
                       IdEmpresa = Cuenta.IdEmpresa,
                       IdEmpresaServicio= Cuenta.IdEmpresaServicio,
                    };
                     
                    ent.AddToCuentaBancaria(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean Eliminar(clsCuentaBancaria  Cuenta)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.CuentaBancaria where q.Serie == Cuenta.Serie select q).First();

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


