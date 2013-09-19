using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;
using clases.Contabilidad;
using clases.CuentasxCobrar;

namespace datos.Taller
{
    public class datLiquidacion
    {
        //obtener id siguiente
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Liquidacion select a.IdLiquidacion).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }


        public List<clsLiquidacion> Consultar()
        {
            try
            {
                List<clsLiquidacion> liquidacion = new List<clsLiquidacion>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Liquidacion from x in ent.OrdenTrabajo where w.IdOrdenTrabajo == x.IdOrdenTrabajo select w;
                foreach (var item in con)
                {
                    clsLiquidacion e = new clsLiquidacion();
                    e.IdLiquidacion = item.IdLiquidacion;
                    e.IdOrdenTrabajo = item.IdOrdenTrabajo;
                    e.Cliente = item.OrdenTrabajo.Persona.NombreRazonSocial + " " + item.OrdenTrabajo.Persona.Apellido;
                    e.Fecha = item.Fecha;
                    e.NroPlaca = item.OrdenTrabajo.Articulo.NroPlaca;
                    e.Marca = item.OrdenTrabajo.Articulo.Marca.Descripcion;
                    e.Modelo = item.OrdenTrabajo.Articulo.Modelo.Descripcion;
                    e.Color = item.OrdenTrabajo.Articulo.Color.Descripcion;
                    e.FechaIngreso = item.OrdenTrabajo.FechaIngreso;
                    e.FechaEntrega = item.OrdenTrabajo.FechaEntrega;
                    e.TotalTrabajos = item.OrdenTrabajo.TotalTrabajos;
                    e.TotalRepuestos = item.OrdenTrabajo.TotalRepuestos;
                    e.TotalOtros = item.OrdenTrabajo.TotalOtros;
                    e.TotalPagar = item.TotalPagar;
                    e.IdFormaPago = item.IdFormaPago;
                    e.NumeroCuotaMensual = item.NumeroCuotaMensual;
                    e.CuotaMensual = item.CuotaMensual;
                    e.FechaInicialPago = item.FechaInicialPago;
                    e.FechaFinalPago = item.FechaFinalPago;
                    e.Observacion = item.Observacion;
                    e.IdEstado = item.IdEstado;
                    e.IdEmpresa = item.IdEmpresa;
                    liquidacion.Add(e);
                }
                return liquidacion;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datLiquidacion: " + ex);
                return null;
            }
        }


        public bool Guardar(clsLiquidacion e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdLiquidacion = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Liquidacion liquidacion = new Liquidacion()
                    {
                        IdLiquidacion = e.IdLiquidacion,
                        IdOrdenTrabajo = e.IdOrdenTrabajo,
                        Fecha = e.Fecha,
                        TotalPagar = e.TotalPagar,
                        IdFormaPago = e.IdFormaPago,
                        NumeroCuotaMensual = e.NumeroCuotaMensual,
                        CuotaMensual = e.CuotaMensual,
                        FechaInicialPago = e.FechaInicialPago,
                        FechaFinalPago = e.FechaFinalPago,
                        Observacion = e.Observacion,
                        IdEstado = e.IdEstado,
                        IdEmpresa = e.IdEmpresa
                    };
                    ent.AddToLiquidacion(liquidacion);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }


        public bool Modificar(clsLiquidacion e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Liquidacion where a.IdLiquidacion == e.IdLiquidacion select a).First();
                    x.IdLiquidacion = e.IdLiquidacion;
                    x.IdOrdenTrabajo = e.IdOrdenTrabajo;
                    x.Fecha = e.Fecha;
                    x.TotalPagar = e.TotalPagar;
                    x.IdFormaPago = e.IdFormaPago;
                    x.NumeroCuotaMensual = e.NumeroCuotaMensual;
                    x.CuotaMensual = e.CuotaMensual;
                    x.FechaInicialPago = e.FechaInicialPago;
                    x.FechaFinalPago = e.FechaFinalPago;
                    x.Observacion = e.Observacion;
                    x.IdEstado = e.IdEstado;
                    x.IdEmpresa = e.IdEmpresa;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }
        }


        public bool Eliminar(clsLiquidacion e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Liquidacion where a.IdLiquidacion == e.IdLiquidacion select a).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

            }
        }


        //para consultar todos
        public List<clsFormaPago> ConsultarFormaPago()
        {
            try
            {
                List<clsFormaPago> listaformapago = new List<clsFormaPago>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.FormaPago select w;
                foreach (var item in con)
                {
                    clsFormaPago e = new clsFormaPago();
                    e.IdFormaPago = item.IdFormaPago;
                    e.Descripcion = item.Descripcion;
                    e.idEstado = item.idEstado;
                    listaformapago.Add(e);
                }
                return listaformapago;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }


        //PARA GUARDAR ASIENTOS CONTABLES

        //obtener id siguiente
        public decimal getIdSiguienteCabComprobante()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                decimal x = ((from a in ent.CabeceraComprobante select a.numero_comprobante).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public bool GuardarCabecera(clsCabeceraComprobante e)
        {
            try
            {
                decimal id = getIdSiguienteCabComprobante();
                e.numero_comprobante = id;
                using (TallerEntities ent = new TallerEntities())
                {
                    CabeceraComprobante cabeceracomprobante = new CabeceraComprobante()
                    {
                        IdEmpresa = e.IdEmpresa,
                        numero_comprobante = e.numero_comprobante,
                        fecha = e.fecha,
                        glosa = e.glosa,
                        periodo_contable = e.periodo_contable,
                        periodo_contable_IdAFiscal = e.periodo_contable_IdAFiscal,
                        IdUsuario = e.IdUsuario,
                        FechaModificacion = e.fecha,
                        TipoTransaccion = e.TipoTransaccion
                    };
                    ent.AddToCabeceraComprobante(cabeceracomprobante);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool GuardarDetalleComprobante(clsCabeceraComprobante e, clsDetalleComprobante d)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                     DetalleComprobante detallecomprobante = new DetalleComprobante()
                     {
                            IdEmpresa = d.IdEmpresa,
                            cabecera_comprobante = e.numero_comprobante,
                            linea_comprobante = d.linea_comprobante,
                            cuenta = d.cuenta,
                            debe = d.debe,
                            haber = d.haber
                     };
                     ent.AddToDetalleComprobante(detallecomprobante);
                     ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }


        //PARA REALIZAR EL COBRO

        //obtener id siguiente
        public int getIdSiguienteCuentaxCobrar()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.CuentaxCobrar select a.idCuentaxCobrar).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }


        public bool GuardarCuentaxCobrar(clsCuentaxCobrar e)
        {
            try
            {
                int id = getIdSiguienteCuentaxCobrar();
                e.idCuentaxCobrar = id;
                using (TallerEntities ent = new TallerEntities())
                {
                    CuentaxCobrar cuentaxCobrar = new CuentaxCobrar()
                    {
                        idEmpresa = e.idEmpresa,
	                    idUsuario = e.idUsuario,
	                    idCuentaxCobrar = e.idCuentaxCobrar,
	                    numero_comprobante = e.numero_comprobante,
                        idNumeroFactura = e.idNumeroFactura,
	                    Modulo = e.Modulo,
	                    TotalCuotas = e.TotalCuotas,
	                    porcentaje_interes = e.porcentaje_interes,
                        estado = e.estado
                    };
                    ent.AddToCuentaxCobrar(cuentaxCobrar);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        public bool GuardarCuentaxCobrarDet(clsCuentaxCobrarDet e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    CuentaxCobrarDet cuentaxcobrardet = new CuentaxCobrarDet()
                    {	
	                    idCuentaxCobrar = e.idCuentaxCobrar,
	                    Numero = e.Numero,			
	                    numero_cuota = e.numero_cuota,	
	                    valor_cuota = e.valor_cuota,	
	                    valor_interes = e.valor_interes,		
	                    valor_mora = e.valor_mora,			
	                    fecha_cobro = e.fecha_cobro,		
	                    fecha_vencimiento = e.fecha_vencimiento,	
	                    FechaModificacion = e.FechaModificacion,
                        estado = e.estado
                    };
                    ent.AddToCuentaxCobrarDet(cuentaxcobrardet);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }

        //PARA EL PROPIETARIO
        public string getDescripcionSegunIdPersona(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Persona where a.IdPersona == id select a).First();
                    return x.NombreRazonSocial + " " + x.Apellido;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        //PARA LA FORMA DE PAGO
        public string getDescripcionSegunIdFormaPago(int id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.FormaPago where a.IdFormaPago == id select a).First();
                    return x.Descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        public int getIdSegunDescripcionFormaPago(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.FormaPago where a.Descripcion == descrip select a).First();
                    return x.IdFormaPago; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }
    }
}
