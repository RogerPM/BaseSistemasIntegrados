using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;
namespace datos.Contabilidad
{
    public class clsDatoComprobante 
    {
        public Boolean GuardarCabecera(ref clsCabeceraComprobante dato) {
            try
            {
                if (dato.Detalle.Sum(q => q.debe) != dato.Detalle.Sum(q => q.haber))
	            {
                    return false;
	            }
                EntitiesContabilidad2 enti =new EntitiesContabilidad2();
                decimal numero=0;
                try
                {
                    numero = (from q in enti.CabeceraComprobante where q.IdEmpresa==1 select q.numero_comprobante).Max()+1;
                }
                catch (Exception)
                {
                    numero = 1;
                }
                dato.numero_comprobante = numero;
                using (EntitiesContabilidad2 ent =new EntitiesContabilidad2())
                {
                    CabeceraComprobante cab = new CabeceraComprobante() { 
                    IdEmpresa=dato.IdEmpresa,
                    numero_comprobante=numero,
                    fecha=dato.fecha,
                    glosa=dato.glosa,
                    TipoTransaccion = (dato.TipoTransaccion==0)?null:dato.TipoTransaccion,

                    periodo_contable = Convert.ToDecimal((from q in ent.PeriodoContable where q.FechaInicio < DateTime.Now && q.FechaFin > DateTime.Now select q.IdPeriodoContable).First()),
                    periodo_contable_IdAFiscal = DateTime.Now.Year,
                    //periodo_contable
                    //periodo_contable_IdAFiscal
                    //IdUsuario
                    //FechaModificacion


                    
                    };
                    ent.AddToCabeceraComprobante(cab);
                    ent.SaveChanges();
                }
                GuardarDetalle(dato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        
        
        private Boolean GuardarDetalle(clsCabeceraComprobante dato)
        {
            try
            {
                int secuencia=0;
                foreach (var item in dato.Detalle)
	            {
                    secuencia = secuencia + 1;
                    using (EntitiesContabilidad2 ent = new EntitiesContabilidad2())
                {
                    DetalleComprobante det = new DetalleComprobante()
                    {
                        IdEmpresa= dato.IdEmpresa,
                        cabecera_comprobante=dato.numero_comprobante,
                        linea_comprobante=secuencia,
                        cuenta=item.cuenta,
                        debe=item.debe,
                        haber=item.haber
                    };
                    ent.AddToDetalleComprobante(det);
                    ent.SaveChanges();
                }
		 
	            }
                
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public clsCabeceraComprobante consultaComprobante(decimal NumeroCom, int idEmpresa) {
            try
            {
                clsCabeceraComprobante cabecera = new clsCabeceraComprobante();
                EntitiesContabilidad2 ent = new EntitiesContabilidad2();
                var cab = (from q in ent.CabeceraComprobante where q.IdEmpresa == idEmpresa && q.numero_comprobante == NumeroCom select q).First();
                cabecera.fecha = Convert.ToDateTime(cab.fecha);
                cabecera.glosa = cab.glosa;
                cabecera.IdEmpresa = cab.IdEmpresa;
                cabecera.TipoTransaccion = (cab.TipoTransaccion==null) ? 0 : cab.TipoTransaccion;
                cabecera.numero_comprobante = cab.numero_comprobante;
                cabecera.periodo_contable = Convert.ToDecimal(cab.periodo_contable);
                cabecera.periodo_contable_IdAFiscal = Convert.ToDecimal(cab.periodo_contable_IdAFiscal);
                ////////////////////////////////
                var det = (from q in ent.DetalleComprobante where q.IdEmpresa == idEmpresa && q.cabecera_comprobante == NumeroCom select q);
                List<clsDetalleComprobante> lista = new List<clsDetalleComprobante>();                
                foreach (var item in det)
                {
                    clsDetalleComprobante detalle = new clsDetalleComprobante();
                    detalle.cuenta = item.cuenta;
                    detalle.debe = item.debe;
                    detalle.haber = item.haber;
                    detalle.linea_comprobante = item.linea_comprobante;
                    lista.Add(detalle);
                }
                cabecera.Detalle = lista;
                return cabecera;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean RevertirC(decimal NumeroCom, int idEmpresa,ref decimal  NumComRevert)
        {
            try
            {
                clsCabeceraComprobante dato = new clsCabeceraComprobante();
                dato=consultaComprobante(NumeroCom, idEmpresa);
                if (dato.Detalle.Sum(q => q.debe) != dato.Detalle.Sum(q => q.haber))
                {
                    return false;
                }
                EntitiesContabilidad2 enti = new EntitiesContabilidad2();
                decimal numero = 0;
                try
                {
                    numero = (from q in enti.CabeceraComprobante where q.IdEmpresa == 1 select q.numero_comprobante).Max()+1;
                }
                catch (Exception)
                {
                    numero = 1;
                }
                using (EntitiesContabilidad2 ent = new EntitiesContabilidad2())
                {
                    CabeceraComprobante cab = new CabeceraComprobante()
                    {
                        IdEmpresa = dato.IdEmpresa,
                        numero_comprobante = numero,
                        fecha = dato.fecha,
                        glosa = "Reverso del Comprobante # "+Convert.ToString(dato.numero_comprobante)+" => "+dato.glosa
                        //periodo_contable
                        //periodo_contable_IdAFiscal
                        //IdUsuario
                        //FechaModificacion



                    };
                    dato.numero_comprobante = numero;
                    ent.AddToCabeceraComprobante(cab);
                    ent.SaveChanges();
                    NumComRevert = numero;
                }
                RevertirD(dato);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private Boolean RevertirD(clsCabeceraComprobante dato)
        {
            try
            {
                int secuencia = 0;
                foreach (var item in dato.Detalle)
                {
                    secuencia = secuencia + 1;
                    using (EntitiesContabilidad2 ent = new EntitiesContabilidad2())
                    {
                        DetalleComprobante det = new DetalleComprobante()
                        {
                            IdEmpresa = dato.IdEmpresa,
                            cabecera_comprobante = dato.numero_comprobante,
                            linea_comprobante = secuencia,
                            cuenta = item.cuenta,
                            debe = item.haber,
                            haber = item.debe
                        };
                        ent.AddToDetalleComprobante(det);
                        ent.SaveChanges();
                    }

                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<clsConsultaComprobante> ListaCom()
        {
            try
            {
                EntitiesContabilidad2 ent = new EntitiesContabilidad2();
                var sel = from q in ent.CabeceraComprobante
                          join w in ent.DetalleComprobante on q.numero_comprobante equals w.cabecera_comprobante 
                          where q.IdEmpresa == w.IdEmpresa
                          select new { q.IdEmpresa,q.numero_comprobante,q.glosa,q.fecha ,w.debe,w.haber};
                var sel2 = from q in sel
                           group q by new { q.numero_comprobante, q.glosa,q.fecha,q.IdEmpresa } into g
                           select new { g.Key.numero_comprobante, g.Key.IdEmpresa, g.Key.glosa, g.Key.fecha, debe = g.Sum(r => r.debe), haber = g.Sum(r => r.debe) };
                List<clsConsultaComprobante> lista = new List<clsConsultaComprobante>();

                foreach (var item in sel2)
                {
                    clsConsultaComprobante clase = new clsConsultaComprobante();
                    clase.IdEmpresa = item.IdEmpresa;
                    clase.glosa = item.glosa;
                    clase.numero_comprobante = item.numero_comprobante;
                    clase.fecha = item.fecha;
                    clase.haber = item.haber;
                    clase.debe = item.debe;
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
