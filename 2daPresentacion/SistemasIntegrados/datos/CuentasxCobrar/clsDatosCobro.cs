using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Cuentasxpagar;

namespace datos.CuentasxCobrar
{
    public class clsDatosCobro
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.Cobro select a.idCobro).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public Boolean guardar(clsCobro cobro)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    int x = this.getIdSiguiente();
                    Cobro entcobro = new Cobro()
                    {
                        idEmpresa =1,// cobro.idEmpresa,
                        idUsuario = 1, //cobro.idUsuario,
                        idCobro = cobro.idCobro,
                        idCabeceraComprobante = cobro.idCabeceraComprobante,
                        Fecha = cobro.Fecha,
                        FechaModificacion = cobro.FechaModificacion,
                        NumeroCuota = cobro.NumeroCuota,
                        ValorCuota = cobro.ValorCuota,
                        Interes = cobro.Interes,
                        Mora = cobro.Mora,
                        ValorPagado = cobro.ValorPagado,
                        Saldo = cobro.Saldo,
                        idEstado = cobro.idEstado,
                    };
                    ent.AddToCobro(entcobro);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        int idCliente = 0;
        public int ConsultaIdFactura(int factura)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    var x = (from q in ent.Factura where q.IdNumeroFactura == factura select q).First();
                    idCliente = Convert.ToInt32(x.IdNumeroCliente);
                }
            }
            catch (Exception)
            {
                return idCliente;
            }
            return idCliente;
        }

        string nombre = "";
        public string ConsultaIdCliente(int cliente)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    var x = (from q in ent.ClienteDefactura where q.IdNumeroCliente == cliente select q).First();
                    nombre = x.NombreRazonSocial + " " + x.Apellido;
                }
            }
            catch (Exception)
            {
                return nombre;
            }
            return nombre;
        }

        int ordenTrabajo = 0;
        public int ConsultaIdFacturaTaller(int factura)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    var x = (from q in ent.Liquidacion where q.IdLiquidacion == factura select q).First();
                    ordenTrabajo = Convert.ToInt32(x.IdOrdenTrabajo);
                }
            }
            catch (Exception)
            {
                return ordenTrabajo;
            }
            return ordenTrabajo;
        }

        public int ConsultaClienteTaller(int orden)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    var x = (from q in ent.OrdenTrabajo where q.IdOrdenTrabajo == orden select q).First();
                    idCliente = x.IdPersona;
                }
            }
            catch (Exception)
            {
                return idCliente;
            }
            return idCliente;
        }


        public string ConsultaNombreTaller(int cliente)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    var x = (from q in ent.Persona where q.IdPersona == cliente select q).First();
                    nombre = x.NombreRazonSocial + " " + x.Apellido;
                }
            }
            catch (Exception)
            {
                return nombre;
            }
            return nombre;
        }
        
        public List<clsMedioPago> consultaMedioPago()
        {

            try
            {
                List<clsMedioPago> lista = new List<clsMedioPago>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.MedioPago select w;
                foreach (var item in con)
                {
                    clsMedioPago medio = new clsMedioPago();

                    medio.IdMedioPago = item.IdMedioPago;
                    medio.Descripcion = item.Descripcion;
                    medio.FechaRegistro = item.fechaRegistro;
                    medio.Estado = item.Estado;
                    medio.IdEmpresa = item.IdEmpresa;
                    medio.IdUsuario = item.IdUsuario;

                    lista.Add(medio);
        
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public int getNumero()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.CobroDet select a.numero).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public Boolean guardarDetalle(clsCobroDet cobroDet)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    int x = this.getNumero();
                    CobroDet coDet = new CobroDet()
                    {
                       idCobro = cobroDet.idCobro,
                       numero = x,
                       idBanco = cobroDet.idBanco,
                       idMedioPago = cobroDet.idMedioPago,
                       Valor = cobroDet.Valor,
                       NumeroDocumento = cobroDet.NumeroDocumento,
                       Observacion = cobroDet.Observacion,
                       idEstado = cobroDet.idEstado,
                       idEmpresa = cobroDet.idEmpresa,

                    };
                    ent.AddToCobroDet(coDet);
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