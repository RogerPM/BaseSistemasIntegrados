using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosCierreCaja
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.CierreCaja select a.idCierreCaja).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsCierreCaja> consultaCierreCajaGeneral()
        {
            try
            {
                List<clsCierreCaja> lista = new List<clsCierreCaja>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.CierreCaja select b;
                foreach (var item in con)
                {
                    clsCierreCaja CierreCaja = new clsCierreCaja();
                    CierreCaja.idEmpresa = item.idEmpresa;
                    CierreCaja.idUsuario = item.idUsuario;
                    CierreCaja.idCierreCaja = item.idCierreCaja;
                    CierreCaja.FechaCierre = item.FechaCierre;
                    CierreCaja.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    CierreCaja.MontoApertura = item.MontoApertura;
                    CierreCaja.TotalDeposito= item.TotalDeposito;
                    CierreCaja.TotalTransferencia = item.TotalTransferencia;
                    CierreCaja.TotalCheque = item.TotalCheque;
                    CierreCaja.TotalBoucher = item.TotalBoucher;
                    CierreCaja.TotalEfectivo = item.TotalEfectivo;
                    CierreCaja.TotalRecaudado = item.TotalRecaudado; 
                    CierreCaja.idEstado = item.idEstado;

                    lista.Add(CierreCaja);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void consultaCierreCajaEspecifica(clsCierreCaja CierreCaja)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.CierreCaja where q.idCierreCaja == CierreCaja.idCierreCaja select q).First();

                CierreCaja.idEmpresa = x.idEmpresa;
                CierreCaja.idUsuario = x.idUsuario;
                CierreCaja.idCierreCaja = x.idCierreCaja;
                CierreCaja.FechaCierre = x.FechaCierre;
                CierreCaja.FechaModificacion = Convert.ToDateTime(x.FechaModificacion);
                CierreCaja.MontoApertura = x.MontoApertura;
                CierreCaja.TotalDeposito = x.TotalDeposito;
                CierreCaja.TotalTransferencia = x.TotalTransferencia;
                CierreCaja.TotalCheque = x.TotalCheque;
                CierreCaja.TotalBoucher = x.TotalBoucher;
                CierreCaja.TotalEfectivo = x.TotalEfectivo;
                CierreCaja.idEstado = x.idEstado;
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

        public Boolean modificar(clsCierreCaja CierreCaja)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.CierreCaja where q.idCierreCaja == CierreCaja.idCierreCaja select q).First();

                x.idEmpresa = CierreCaja.idEmpresa;
                x.idUsuario = CierreCaja.idUsuario;
                x.idCierreCaja = CierreCaja.idCierreCaja;
                x.FechaCierre = CierreCaja.FechaCierre;
                x.FechaModificacion = CierreCaja.FechaModificacion;
                x.MontoApertura = CierreCaja.MontoApertura;
                x.TotalDeposito=CierreCaja.TotalDeposito;
                x.TotalTransferencia=CierreCaja.TotalTransferencia;
                x.TotalCheque=CierreCaja.TotalCheque;
                x.TotalBoucher=CierreCaja.TotalBoucher;
                x.TotalEfectivo=CierreCaja.TotalEfectivo;
                x.idEstado = CierreCaja.idEstado;

                ent.SaveChanges();
                return true;

            }

        }

        public Boolean consultaCerrada(DateTime FechaHoy, int idUsuario)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {

                var x = (from q in ent.CierreCaja where q.FechaCierre == FechaHoy.Date && q.idUsuario == idUsuario select q);
                if (x.Count() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Boolean guardar(clsCierreCaja CierreCaja)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    int x = this.getIdSiguiente();
                    CierreCaja cie = new CierreCaja()
                    {
                        idEmpresa = CierreCaja.idEmpresa,
                        idUsuario = CierreCaja.idUsuario,
                        idCierreCaja = x,
                        FechaCierre = CierreCaja.FechaCierre,
                        FechaModificacion = CierreCaja.FechaModificacion,
                        MontoApertura = CierreCaja.MontoApertura,
                        TotalDeposito = CierreCaja.TotalDeposito,
                        TotalTransferencia = CierreCaja.TotalTransferencia,
                        TotalCheque = CierreCaja.TotalCheque,
                        TotalBoucher = CierreCaja.TotalBoucher,
                        TotalEfectivo =CierreCaja.TotalEfectivo,
                        idEstado = CierreCaja.idEstado,

                    };
                    ent.AddToCierreCaja(cie);
                    ent.SaveChanges();
                    CierreCaja.idCierreCaja = x;
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean eliminar(clsCierreCaja CierreCaja)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.CierreCaja where q.idCierreCaja == CierreCaja.idCierreCaja select q).First();
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





        public List<clsGridCierreCaja> CerrarCaja()
        {
            try
            {
                List<clsGridCierreCaja> lista = new List<clsGridCierreCaja>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.MedioPago select b;
                foreach (var item in con)
                {
                    string NombreCampo="";
                    decimal Total=0;
                    try
                    {
                        NombreCampo=item.Descripcion;
                        CuentasPorCobrarEntities ent2 = new CuentasPorCobrarEntities();
                        var con2 = from c in ent2.CobroDet where c.idMedioPago == item.IdMedioPago select c;
                        foreach (var item2 in con2)
                        {
                            Total = Total + item2.Valor;
                        }
                    }
                    catch 
                    {
                        Total = Total + 0;
                    }
 
                    clsGridCierreCaja GridCierreCaja = new clsGridCierreCaja();
                    GridCierreCaja.NombreCampo = NombreCampo;
                    GridCierreCaja.Total = Total;

                    lista.Add(GridCierreCaja);
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
