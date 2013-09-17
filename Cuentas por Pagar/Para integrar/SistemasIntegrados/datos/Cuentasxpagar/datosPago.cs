using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;
using clases.CuentasxCobrar;

namespace datos.Cuentasxpagar
{
    public class datosPago
    {

        public List<clsPago> consulta(int Empresa)
        {
            try
            {
                List<clsPago> lista = new List<clsPago>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.PagoCab where w.IdEmpresa == Empresa select w;
                foreach (var item in con)
                {
                    clsPago clas = new clsPago();
                    clas.NumPago = item.NumPago;
                    clas.FechaIngreso = item.FechaIngreso;
                    clas.NumOrdenPago = Convert.ToInt32(item.NumOrdenPago);

                    clas.TotalPagar = item.TotalPagar;
                    clas.IdUsuario = item.IdUsuario;
                    clas.IdEmpresa = item.IdEmpresa;
                    clas.IdEstado = item.Estado;
                    clas.NumComprobante = item.NumComprobante;
                    lista.Add(clas);

                }
                return lista;

            }
            catch (Exception)
            {
                return null;

            }

        }

        public void ModificarSaldo(int numero, decimal Saldo)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.CuentaBancaria where q.idCuentaBancaria == numero select q).First();


                x.Saldo = Saldo;

                ent.SaveChanges();

            }
        }
        public void ModificarEstadoOrden(int numero)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.OrdenPagoCab where q.NumOrdenPago == numero select q).First();


                x.Estado = 2;

                ent.SaveChanges();

            }
        }
        

        public void Modificar(clsPago Pago)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.PagoCab where q.NumPago == Pago.NumPago select q).First();
                x.NumPago = Pago.NumPago;
                x.FechaIngreso = Pago.FechaIngreso;
                x.NumOrdenPago = Pago.NumOrdenPago;

                x.TotalPagar = Pago.TotalPagar;
                x.IdUsuario = Pago.IdUsuario;
                x.IdEmpresa = Pago.IdEmpresa;
                x.Estado = Pago.IdEstado;
                x.NumComprobante = Pago.NumComprobante;
                ent.SaveChanges();

            }

        }
        public Boolean Guardar(clsPago Pago)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    PagoCab otro = new PagoCab()
                    {
                        NumPago = id,
                        FechaIngreso = Pago.FechaIngreso,
                        NumOrdenPago = Pago.NumOrdenPago,

                        TotalPagar = Pago.TotalPagar,
                        IdUsuario = Pago.IdUsuario,
                        IdEmpresa = Pago.IdEmpresa,
                        Estado = Pago.IdEstado,
                        NumComprobante = Pago.NumComprobante,
                    };
                    ent.AddToPagoCab(otro);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



        }
        public Boolean GuardarNomina(clsPagoDos Pago)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    PagoCab otro = new PagoCab()
                    {
                        NumPago = id,
                        FechaIngreso = Pago.FechaIngreso,
                        TotalPagar = Pago.TotalPagar,
                        IdUsuario = Pago.IdUsuario,
                        IdEmpresa = Pago.IdEmpresa,
                        Estado = Pago.IdEstado,
                        NumComprobante = Pago.NumComprobante,
                    };
                    ent.AddToPagoCab(otro);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }



        }
        public Boolean Eliminar(clsPago Pag)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.PagoCab where q.NumPago == Pag.NumPago select q).First();

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
        public Boolean EliminarEstado(clsPago Pag)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.PagoCab where q.NumPago == Pag.NumPago select q).First();

                    x.Estado = Pag.IdEstado;


                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        decimal saldito = 0;
        public decimal ConsultaSaldo(int cuenta)
        {

            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.CuentaBancaria where q.idCuentaBancaria == (cuenta) select q).First();


                    saldito = (x.Saldo);


                }

            }
            catch (Exception ex)
            {
                return saldito;

            }
            return saldito;
        }
        string Nombre = "nada";
        public string ConsultaNombre(int idPersona)
        {

            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.Persona where q.IdPersona == (idPersona) select q).First();


                    Nombre = (x.NombreRazonSocial) + x.Apellido;


                }

            }
            catch (Exception ex)
            {
                return Nombre;

            }
            return Nombre;
        }
        public Boolean ConsultaVerificaOrdenPagada(int numero)
        {

            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.PagoCab where q.NumOrdenPago == (numero) select q).First();
                    if (x.IdEmpresa >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public List<clsMedioPago> consultaMedio()
        {
            try
            {
                List<clsMedioPago> lista = new List<clsMedioPago>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.MedioPago select w;
                foreach (var item in con)
                {
                    clsMedioPago med = new clsMedioPago();
                    med.IdMedioPago = item.IdMedioPago;
                    med.Descripcion = item.Descripcion;
                    med.FechaRegistro = item.fechaRegistro;
                    med.Estado = item.Estado;
                    med.IdEmpresa = item.IdEmpresa;
                    med.IdUsuario = item.IdUsuario;
                    lista.Add(med);
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
        public List<clsOrdenPagoCab> ConsultaOrden(int idempresa, string tipo)
        {
            try
            {
                List<clsOrdenPagoCab> lista = new List<clsOrdenPagoCab>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoCab where w.IdEmpresa == idempresa & w.Estado == 1 & w.TipoOrdenPago == tipo select w;
                foreach (var item in con)
                {
                    clsOrdenPagoCab ord = new clsOrdenPagoCab();
                    ord.NumOrdenPago = item.NumOrdenPago;
                    ord.fechadeEmision = item.fechadeEmision;
                    ord.IdPersona = Convert.ToInt32(item.IdPersona);
                    ord.Estado = item.Estado;
                    ord.TotalPagar = item.TotalPagar;
                    ord.TipoOrdenPago = Convert.ToChar(item.TipoOrdenPago);
                    ord.IdUsuario = item.IdUsuario;
                    ord.IdEmpresa = item.IdEmpresa;
                    lista.Add(ord);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
        public List<clsBanco> ConsultaBanco()
        {
            try
            {
                List<clsBanco> lista = new List<clsBanco>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.Banco select w;
                foreach (var item in con)
                {
                    clsBanco ord = new clsBanco();
                    ord.idEmpresa = item.idEmpresa;
                    ord.idBanco = item.idBanco;
                    ord.Nombre = (item.Nombre);
                    ord.Estado = Convert.ToChar(item.Estado);
                    lista.Add(ord);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public List<clsOrdenPagoDet> ConsultaOrdenDetalle(int numero)
        {
            try
            {
                List<clsOrdenPagoDet> lista = new List<clsOrdenPagoDet>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.OrdenPagoDet where w.NumOrdenCab == numero select w;

                foreach (var item in con)
                {
                    clsOrdenPagoDet ord = new clsOrdenPagoDet();
                    ord.NumLinea = item.NumLinea;
                    ord.NumCuentaPorPagar = item.NumCuentaPorPagar;
                    ord.NumDetalleDeuda = (item.NumDetalleDeuda);
                    ord.SaldoDeuda = item.SaldoDeuda;
                    ord.NumeroPagosRealizar = item.NumeroPagosRealizar;
                    ord.NumOrdenPagoCab = (item.NumOrdenCab);
                    ord.TotalPagar = item.TotalPagar;
                    ord.IdEmpresa = item.IdEmpresa;

                    lista.Add(ord);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public List<clsCuentaBancaria> ConsultaCuentaBancaria(int Empresa)
        {
            try
            {
                List<clsCuentaBancaria> lista = new List<clsCuentaBancaria>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaBancaria where w.idEmpresa == (Empresa) select w;
                foreach (var item in con)
                {
                    clsCuentaBancaria ord = new clsCuentaBancaria();
                    ord.idEmpresa = item.idEmpresa;
                    ord.idCuentaBancaria = item.idCuentaBancaria;
                    ord.idBanco = (item.idBanco);
                    ord.idTitular = Convert.ToInt32(item.idTitular);
                    ord.NumeroCuenta = item.NumeroCuenta;
                    ord.TipoCuenta = (item.TipoCuenta);
                    ord.Saldo = item.Saldo;
                    ord.Estado = Convert.ToChar(item.Estado);

                    lista.Add(ord);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
        public int getIdSiguiente()
        {
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.PagoCab select a.NumPago).Max()) + 1;

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

