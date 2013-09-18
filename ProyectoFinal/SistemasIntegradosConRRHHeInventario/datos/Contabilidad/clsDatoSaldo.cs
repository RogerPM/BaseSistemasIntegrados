using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;

namespace datos.Contabilidad
{
    public class clsDatoSaldo
    {
        public Boolean insert(List<clsvwComprobanteMayorizar> lista)
        {
            try
            {
                using (EntitiesContabilidad2 ent =new EntitiesContabilidad2())
                {
                    foreach (var item in lista)
                    {
                        var s =from q in ent.DetalleComprobante where q.IdEmpresa==item.IdEmpresa && q.cabecera_comprobante==item.numero_comprobante select q;
                        foreach (var item2 in s)
	                    {
                            try
                            {
                                EntitiesContabilidad2 ent2 = new EntitiesContabilidad2();
                                DateTime fecha=(from q in ent2.PeriodoContable where q.FechaInicio < item.fecha && q.FechaFin > item.fecha select q.FechaFin).First();
                                if ((from q in ent.Saldo where q.fecha == fecha select q).Count() > 0)
                                {
                                    var saldo = (from q in ent2.Saldo where q.fecha == fecha && q.cuenta == item2.cuenta select q).First();
                                    saldo.saldo_deudor = saldo.saldo_deudor + item2.debe;
                                    saldo.saldo_acreedor = saldo.saldo_acreedor + item2.haber;
                                    ent2.SaveChanges();
                                }
                                else {
                                    Saldo sald = new Saldo()
                                    {
                                        IdEmpresa = 1,
                                        cuenta = item2.cuenta,
                                        //esta fecha debe ser la fechafinal del periodo
                                        fecha = Convert.ToDateTime((from q in ent.PeriodoContable where q.FechaInicio < item.fecha && q.FechaFin > item.fecha select q.FechaFin).First()),
                                        //el debe y el haber se debe acumular segun la cuenta y la fecha del periodo si ya existe en la base
                                        saldo_deudor = item2.debe,
                                        saldo_acreedor = item2.haber,
                                        IdUsuario = 1,
                                        FechaModificacion = DateTime.Now
                                    };
                                    ent.AddToSaldo(sald);
                                }
                            }
                            catch (Exception)
                            {
                                Saldo sald = new Saldo()
                                {
                                    IdEmpresa = 1,
                                    cuenta = item2.cuenta,
                                    //esta fecha debe ser la fechafinal del periodo
                                    fecha = Convert.ToDateTime((from q in ent.PeriodoContable where q.FechaInicio < item.fecha && q.FechaFin > item.fecha select q.FechaFin).First()),
                                    //el debe y el haber se debe acumular segun la cuenta y la fecha del periodo si ya existe en la base
                                    saldo_deudor = item2.debe,
                                    saldo_acreedor = item2.haber,
                                    IdUsuario = 1,
                                    FechaModificacion = DateTime.Now
                                };
                                ent.AddToSaldo(sald);
                            }
                            
	                    }
                        SaldoxComprobante xc = new SaldoxComprobante()
                        {
                            IdEmpresa=1,
                            numero_comprobante=item.numero_comprobante
                        };
                        ent.AddToSaldoxComprobante(xc);
                    }

                    ent.SaveChanges();                
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<clsvwComprobanteMayorizar> select(DateTime desde,DateTime hasta){
            try
            {
                List<clsvwComprobanteMayorizar> lista = new List<clsvwComprobanteMayorizar>();
                EntitiesContabilidad2 ent = new EntitiesContabilidad2();
                var s = from q in ent.vwComprobanteMayorizar where q.IdEmpresa == 1 && q.fecha >= desde && q.fecha <= hasta select q;
                foreach (var item in s)
                {
                    clsvwComprobanteMayorizar clase = new clsvwComprobanteMayorizar();
                    clase.debe = Convert.ToDecimal(item.debe);
                    clase.fecha = item.fecha;
                    clase.haber = Convert.ToDecimal(item.haber);
                    clase.IdEmpresa = item.IdEmpresa;
                    clase.glosa = item.glosa;
                    clase.numero_comprobante = item.numero_comprobante;
                    lista.Add(clase);
                }

                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        
        }

    }
}
