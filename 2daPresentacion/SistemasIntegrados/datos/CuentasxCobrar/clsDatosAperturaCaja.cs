using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosAperturaCaja
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.AperturaCaja select a.idAperturaCaja).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsAperturaCaja> consultaAperturaCajaGeneral()
        {
            try
            {
                List<clsAperturaCaja> lista = new List<clsAperturaCaja>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.AperturaCaja select b;
                foreach (var item in con)
                {
                    clsAperturaCaja AperturaCaja = new clsAperturaCaja();
                    AperturaCaja.idEmpresa = item.idEmpresa;
                    AperturaCaja.idUsuario = item.idUsuario;
                    AperturaCaja.idAperturaCaja = item.idAperturaCaja;
                    AperturaCaja.Fecha = item.Fecha;
                    AperturaCaja.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    AperturaCaja.Monto = item.Monto;
                    AperturaCaja.idEstado = item.idEstado;

                    lista.Add(AperturaCaja);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void consultaAperturaCajaEspecifica(clsAperturaCaja AperturaCaja)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.AperturaCaja where q.idAperturaCaja == AperturaCaja.idAperturaCaja select q).First();

                AperturaCaja.idEmpresa = x.idEmpresa;
                AperturaCaja.idUsuario = x.idUsuario;
                AperturaCaja.idAperturaCaja = x.idAperturaCaja;
                AperturaCaja.Fecha = x.Fecha;
                AperturaCaja.FechaModificacion = Convert.ToDateTime(x.FechaModificacion);
                AperturaCaja.Monto = x.Monto;
                AperturaCaja.idEstado = x.idEstado;
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

        public Boolean modificar(clsAperturaCaja AperturaCaja)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.AperturaCaja where q.idAperturaCaja == AperturaCaja.idAperturaCaja select q).First();

                x.idEmpresa = AperturaCaja.idEmpresa;
                x.idUsuario = AperturaCaja.idUsuario;
                x.idAperturaCaja = AperturaCaja.idAperturaCaja;
                x.Fecha = AperturaCaja.Fecha;
                x.FechaModificacion = AperturaCaja.FechaModificacion;
                x.Monto = AperturaCaja.Monto;
                x.idEstado = AperturaCaja.idEstado;

                ent.SaveChanges();
                return true;

            }

        }

        public Boolean guardar(clsAperturaCaja AperturaCaja)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    AperturaCaja ape = new AperturaCaja()
                    {
                        idEmpresa = AperturaCaja.idEmpresa,
                        idUsuario = AperturaCaja.idUsuario,
                        idAperturaCaja = x,
                        Fecha = AperturaCaja.Fecha,
                        FechaModificacion = AperturaCaja.FechaModificacion,
                        Monto = AperturaCaja.Monto,
                        idEstado = AperturaCaja.idEstado,

                    };
                    ent.AddToAperturaCaja(ape);
                    ent.SaveChanges();
                    AperturaCaja.idAperturaCaja = x;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error "+ ex);

                return false;
            }
        }

        public Boolean eliminar(clsAperturaCaja AperturaCaja)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.AperturaCaja where q.idAperturaCaja == AperturaCaja.idAperturaCaja select q).First();
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
