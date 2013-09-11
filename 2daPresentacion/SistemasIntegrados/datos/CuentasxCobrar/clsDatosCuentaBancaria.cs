using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosCuentaBancaria
    {


        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.CuentaBancaria select a.idBanco).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<ObjetoGenerico> consultaCuentaBancariaGeneralINNER()
        {
            try
            {
                List<ObjetoGenerico> lista = new List<ObjetoGenerico>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();


                var con = from t1 in ent.CuentaBancaria
                          join t2 in ent.Banco on t1.idBanco equals t2.idBanco
                          join t3 in ent.Persona on t1.idTitular equals t3.IdPersona
                          select new { t1.idEmpresa, t1.idCuentaBancaria, t2.Nombre,  
                              t3.NombreRazonSocial, t3.Apellido, t1.NumeroCuenta, t1.TipoCuenta, 
                              t1.Saldo, t1.Estado }
                    
                    
                    /*from b in ent.CuentaBancaria select b*/;
                foreach (var item in con)
                {
                    ObjetoGenerico CuentaBancaria = new ObjetoGenerico();
                    CuentaBancaria.Campo1 = Convert.ToString(item.idEmpresa);
                    CuentaBancaria.Campo2 = Convert.ToString(item.idCuentaBancaria);
                    CuentaBancaria.Campo3 = Convert.ToString(item.Nombre);
                    CuentaBancaria.Campo4 = Convert.ToString(item.NombreRazonSocial + " " + item.Apellido);
                    CuentaBancaria.Campo5 = Convert.ToString(item.NumeroCuenta);
                    CuentaBancaria.Campo6 = Convert.ToString(item.TipoCuenta);
                    CuentaBancaria.Campo7 = Convert.ToString(item.Saldo);
                    CuentaBancaria.Campo8 = Convert.ToString(item.Estado);

                    lista.Add(CuentaBancaria);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ConsultaCuentaBancariaEspecifica (clsCuentaBancaria CBancaria)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.CuentaBancaria where q.idCuentaBancaria == CBancaria.idCuentaBancaria select q).First();

                CBancaria.idEmpresa= x.idEmpresa; //Error no se puede convertit implicitamente int
                CBancaria.idCuentaBancaria=x.idCuentaBancaria;
                CBancaria.idBanco=x.idBanco;
                CBancaria.idTitular=Convert.ToInt32 (x.idTitular);
                CBancaria.NumeroCuenta=x.NumeroCuenta ;
                CBancaria.TipoCuenta=x.TipoCuenta;
                CBancaria.Saldo=x.Saldo;
                CBancaria.Estado=x.Estado;
            }

        }

        public void ConsultaPersonaEspecifica(ref String[] strPersona)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                int idPersona = Convert.ToInt32(strPersona[0]);
                var x = (from q in ent.Persona where q.Identificacion == idPersona select q).First();

                strPersona[0] = Convert.ToString(x.Identificacion); //Error no se puede convertit implicitamente int
                strPersona[1] = x.NombreRazonSocial + " " + x.Apellido;
            }

        }

        public List<clsCuentaBancaria> consultaCuentaBancariaGeneral()
        {
            try
            {
                List<clsCuentaBancaria> lista = new List<clsCuentaBancaria>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.CuentaBancaria select b;
                foreach (var item in con)
                {
                    clsCuentaBancaria CuentaBancaria = new clsCuentaBancaria();
                    CuentaBancaria.idEmpresa = item.idEmpresa;
                    CuentaBancaria.idCuentaBancaria = item.idCuentaBancaria;
                    CuentaBancaria.idBanco = item.idBanco;
                    CuentaBancaria.idTitular = Convert.ToInt32 (item.idTitular);
                    CuentaBancaria.NumeroCuenta = item.NumeroCuenta;
                    CuentaBancaria.TipoCuenta = item.TipoCuenta;
                    CuentaBancaria.Saldo = item.Saldo;
                    CuentaBancaria.Estado = item.Estado;

                    lista.Add(CuentaBancaria);
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

        public Boolean modificar(clsCuentaBancaria CBancaria)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.CuentaBancaria where q.idCuentaBancaria == CBancaria.idCuentaBancaria select q).First();

                x.idEmpresa = CBancaria.idEmpresa; //Error no se puede convertit implicitamente int
                x.idCuentaBancaria = CBancaria.idCuentaBancaria;
                x.idBanco = CBancaria.idBanco;
                x.idTitular = CBancaria.idTitular;
                x.NumeroCuenta = CBancaria.NumeroCuenta;
                x.TipoCuenta = CBancaria.TipoCuenta;
                x.Saldo = CBancaria.Saldo;
                x.Estado = CBancaria.Estado;
                ent.SaveChanges();
                return true;

            }

        }

        public Boolean guardar(clsCuentaBancaria CuentaBancaria)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    CuentaBancaria Cban = new CuentaBancaria ()
                    {
                        idEmpresa = CuentaBancaria.idEmpresa,
                        idCuentaBancaria=x,
                        idBanco = CuentaBancaria.idBanco,
                        idTitular = CuentaBancaria.idTitular,
                        NumeroCuenta = CuentaBancaria.NumeroCuenta,
                        TipoCuenta  = CuentaBancaria.TipoCuenta,
                        Saldo = CuentaBancaria.Saldo,
                        Estado = CuentaBancaria.Estado,

                    };
                    ent.AddToCuentaBancaria(Cban);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean eliminar(clsCuentaBancaria CuentaBancaria)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.CuentaBancaria where q.idCuentaBancaria == CuentaBancaria.idCuentaBancaria select q).First();
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
