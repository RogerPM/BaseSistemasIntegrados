using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class clsCuentaPorPagarDAT
    {
        CuentaPorPagar CtaXPag;
        ImpuestoCuenta ImpCta;
        DeudaDet DeuDet;
        FrecuenciaPago Frecuencia;

        public int getSiguienteCtaPorPagar()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.CuentaPorPagar select a.NumCuentaPorPagar).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        public int getNumDetCtaxPag()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.DeudaDet select a.NumDetalleDeuda).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        public List<clsFrecuencia> ConsultaFrecuencia()
        {

            try
            {
                List<clsFrecuencia> lista = new List<clsFrecuencia>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.FrecuenciaPago select w;
                foreach (var item in con)
                {
                    clsFrecuencia clas = new clsFrecuencia();
                    clas._IdFrecuenciaPago = item.IdFrecuenciaPago;
                    clas._Descripcion = item.Descripcion;
                    clas._FechaActual = item.FechaActual;
                    clas._Estado = item.Estado;
                    clas._IdUsuario = item.IdUsuario;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public List<clsCuentaPorPagar> consulta()
        {

            try
            {
                List<clsCuentaPorPagar> lista = new List<clsCuentaPorPagar>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.CuentaPorPagar select w;
                foreach (var item in con)
                {
                    clsCuentaPorPagar clas = new clsCuentaPorPagar();
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._NumIngresoEgreso = Convert.ToInt32(item.NumIngresoEgreso);
                    clas._FechaIngreso = item.FechaIngreso;
                    clas._Factura = item.NumeroFactura;
                    clas._FechaTransaccion = item.FechaTransaccion;
                    clas._IdProveedor = Convert.ToInt32(item.IdProveedor);
                    clas._IdEmpresaServicio = item.IdEmpresaServicio;
                    clas._Motivo = item.Motivo;
                    clas._Detalle = item.Detalle;
                    clas._Subtotal = item.Subtotal;
                    clas._Descuento = Convert.ToDecimal(item.Descuento);
                    clas._Total = item.Total;
                    clas._FormaPago = item.FormaPago;
                    clas._ValorEntrada = Convert.ToDecimal(item.ValorEntrada);
                    clas._NumeroLetra = Convert.ToInt32(item.NumeroLetra);
                    clas._IdFrecuencia = Convert.ToInt32(item.IdFrecuencia);
                    clas._ValorLetra = Convert.ToDecimal(item.ValorLetra);
                    clas._SaldoDeuda = Convert.ToDecimal(item.SaldoDeuda);
                    clas._IdUsuario = item.IdUsuario;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }


        public List<clsCuentaPorPagarDetalle> consultaDetalle(int ind)
        {

            try
            {
                List<clsCuentaPorPagarDetalle> lista = new List<clsCuentaPorPagarDetalle>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.DeudaDet where w.NumCuentaPorPagar == ind select w;
                foreach (var item in con)
                {
                    clsCuentaPorPagarDetalle clas = new clsCuentaPorPagarDetalle();
                    clas._IdEmpresa = item.IdEmpresa;
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._NumCuentaPorPagarDetalle = item.NumDetalleDeuda;
                    clas._ValorLetra = item.ValorLetra;
                    clas._FechaVencimiento = item.FechaVencimiento;
                    clas._Estado = item.Estado;
                    lista.Add(clas);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<clsCuentaPorPagarDetalle> consultaDetalle2()
        {

            try
            {
                List<clsCuentaPorPagarDetalle> lista = new List<clsCuentaPorPagarDetalle>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.DeudaDet select w;
                foreach (var item in con)
                {
                    clsCuentaPorPagarDetalle clas = new clsCuentaPorPagarDetalle();
                    clas._IdEmpresa = item.IdEmpresa;
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._NumCuentaPorPagarDetalle = item.NumDetalleDeuda;
                    clas._ValorLetra = item.ValorLetra;
                    clas._FechaVencimiento = item.FechaVencimiento;
                    clas._Estado = item.Estado;
                    lista.Add(clas);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<clsImpuestoCuenta> consultaImpuesto(int a)
        {
            try
            {
                List<clsImpuestoCuenta> lista = new List<clsImpuestoCuenta>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.ImpuestoCuenta where w.NumCuentaPorPagar == a select w;
                foreach (var item in con)
                {
                    clsImpuestoCuenta clas = new clsImpuestoCuenta();
                    clas._NumCuentaPorPagar = item.NumCuentaPorPagar;
                    clas._IdImpuesto = item.IdImpuesto;
                    clas._IdEmpresa = item.IdEmpresa;
                    clas._Valor = Convert.ToDecimal(item.Impuesto);
                    lista.Add(clas);
                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public Boolean Guardar0(clsCuentaPorPagar CuentaPorPagar)
        {
            Boolean a = false;
            if (CuentaPorPagar._IdProveedor == 0)
            {
                if (CuentaPorPagar._FormaPago == Convert.ToString('0'))
                {
                    if (CuentaPorPagar._Descuento == 0)
                    {
                        a = Guardar4(CuentaPorPagar);
                    }
                    else
                    {
                        a = Guardar3(CuentaPorPagar);
                    }
                }
                else if (CuentaPorPagar._FormaPago == Convert.ToString('1'))
                {
                    if (CuentaPorPagar._Descuento == 0)
                    {
                        a = Guardar2(CuentaPorPagar);
                    }
                    else
                    {
                        a = Guardar1(CuentaPorPagar);
                    }
                }
            }
            else
            {
                if (CuentaPorPagar._FormaPago == Convert.ToString('0'))
                {
                    if (CuentaPorPagar._Descuento == 0)
                    {
                        a = Guardar8(CuentaPorPagar);
                    }
                    else
                    {
                        a = Guardar7(CuentaPorPagar);
                    }
                }
                else if (CuentaPorPagar._FormaPago == Convert.ToString('1'))
                {
                    if (CuentaPorPagar._Descuento == 0)
                    {
                        a = Guardar6(CuentaPorPagar);
                    }
                    else
                    {
                        a = Guardar5(CuentaPorPagar);
                    }
                }
            }
            return a;
        }


        public Boolean Guardar1(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdEmpresaServicio = CuentaPorPagar._IdEmpresaServicio,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Descuento = CuentaPorPagar._Descuento,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        ValorEntrada = CuentaPorPagar._ValorEntrada,
                        NumeroLetra = CuentaPorPagar._NumeroLetra,
                        IdFrecuencia = CuentaPorPagar._IdFrecuencia,
                        ValorLetra = CuentaPorPagar._ValorLetra,
                        SaldoDeuda = CuentaPorPagar._SaldoDeuda,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarDetCtaPorPagar(CuentaPorPagar._DetCredito);

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        public Boolean Guardar2(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdEmpresaServicio = CuentaPorPagar._IdEmpresaServicio,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        ValorEntrada = CuentaPorPagar._ValorEntrada,
                        NumeroLetra = CuentaPorPagar._NumeroLetra,
                        IdFrecuencia = CuentaPorPagar._IdFrecuencia,
                        ValorLetra = CuentaPorPagar._ValorLetra,
                        SaldoDeuda = CuentaPorPagar._SaldoDeuda,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarDetCtaPorPagar(CuentaPorPagar._DetCredito);

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        public Boolean Guardar3(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdEmpresaServicio = CuentaPorPagar._IdEmpresaServicio,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Descuento = CuentaPorPagar._Descuento,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public Boolean Guardar4(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdEmpresaServicio = CuentaPorPagar._IdEmpresaServicio,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public Boolean Guardar5(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        NumIngresoEgreso = CuentaPorPagar._NumIngresoEgreso,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdProveedor = CuentaPorPagar._IdProveedor,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Descuento = CuentaPorPagar._Descuento,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        ValorEntrada = CuentaPorPagar._ValorEntrada,
                        NumeroLetra = CuentaPorPagar._NumeroLetra,
                        IdFrecuencia = CuentaPorPagar._IdFrecuencia,
                        ValorLetra = CuentaPorPagar._ValorLetra,
                        SaldoDeuda = CuentaPorPagar._SaldoDeuda,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarDetCtaPorPagar(CuentaPorPagar._DetCredito);

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        public Boolean Guardar6(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        NumIngresoEgreso = CuentaPorPagar._NumIngresoEgreso,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdProveedor = CuentaPorPagar._IdProveedor,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        ValorEntrada = CuentaPorPagar._ValorEntrada,
                        NumeroLetra = CuentaPorPagar._NumeroLetra,
                        IdFrecuencia = CuentaPorPagar._IdFrecuencia,
                        ValorLetra = CuentaPorPagar._ValorLetra,
                        SaldoDeuda = CuentaPorPagar._SaldoDeuda,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarDetCtaPorPagar(CuentaPorPagar._DetCredito);

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        public Boolean Guardar7(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        NumIngresoEgreso = CuentaPorPagar._NumIngresoEgreso,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdProveedor = CuentaPorPagar._IdProveedor,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Descuento = CuentaPorPagar._Descuento,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        public Boolean Guardar8(clsCuentaPorPagar CuentaPorPagar)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    CtaXPag = new CuentaPorPagar()
                    {
                        NumCuentaPorPagar = CuentaPorPagar._NumCuentaPorPagar,
                        NumIngresoEgreso = CuentaPorPagar._NumIngresoEgreso,
                        FechaIngreso = CuentaPorPagar._FechaIngreso,
                        NumeroFactura = CuentaPorPagar._Factura,
                        FechaTransaccion = CuentaPorPagar._FechaTransaccion,
                        IdProveedor = CuentaPorPagar._IdProveedor,
                        Motivo = CuentaPorPagar._Motivo,
                        Detalle = CuentaPorPagar._Detalle,
                        Subtotal = CuentaPorPagar._Subtotal,
                        Total = CuentaPorPagar._Total,
                        FormaPago = CuentaPorPagar._FormaPago,
                        IdUsuario = CuentaPorPagar._IdUsuario,
                        IdEmpresa = CuentaPorPagar._IdEmpresa,
                    };
                    ent.AddToCuentaPorPagar(CtaXPag);
                    ent.SaveChanges();

                    GuardarImpuestos(CuentaPorPagar._ImpuestoCuenta);
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }


        private Boolean GuardarDetCtaPorPagar(List<clsCuentaPorPagarDetalle> a)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    int aux = a.Count;
                    List<clsCuentaPorPagarDetalle> Detalle = a;
                    for (int i = 0; i < aux; i++)
                    {
                        int NumDetCtaxPag = getNumDetCtaxPag();
                        DeuDet = new DeudaDet()
                        {
                            IdEmpresa = Detalle[i]._IdEmpresa,
                            NumCuentaPorPagar = Detalle[i]._NumCuentaPorPagar,
                            NumDetalleDeuda = NumDetCtaxPag,
                            ValorLetra = Detalle[i]._ValorLetra,
                            FechaVencimiento = Detalle[i]._FechaVencimiento,
                            Estado = Detalle[i]._Estado,
                        };
                        ent.AddToDeudaDet(DeuDet);
                        ent.SaveChanges();
                    }
                    //ent.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        private Boolean GuardarImpuestos(List<clsImpuestoCuenta> a)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    int aux = a.Count;
                    List<clsImpuestoCuenta> Impuestito = a;
                    for (int i = 0; i < aux; i++)
                    {
                        ImpCta = new ImpuestoCuenta()
                        {
                            IdEmpresa = Impuestito[i]._IdEmpresa,
                            NumCuentaPorPagar = Impuestito[i]._NumCuentaPorPagar,
                            Valor = Impuestito[i]._Valor,
                            IdImpuesto = Impuestito[i]._IdImpuesto,
                        };
                        ent.AddToImpuestoCuenta(ImpCta);
                        ent.SaveChanges();
                    }
                    //ent.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }



        public void Modificar(clsCuentaPorPagar CuentaPorPagar)
        {

        }



        public void Eliminar(clsCuentaPorPagar CuentaPorPagar)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.CuentaPorPagar where q.NumCuentaPorPagar == (CuentaPorPagar._NumCuentaPorPagar) select q).First();
                ent.DeleteObject(x);
                ent.SaveChanges();
            }
        }


        //=========================================================================================================================
        //================================================CONSULTA DE FRECUENCIA===================================================
        //=========================================================================================================================

        
    }
}
