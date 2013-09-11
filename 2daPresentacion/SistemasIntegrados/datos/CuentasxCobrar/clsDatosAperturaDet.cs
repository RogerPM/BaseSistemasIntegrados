using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosAperturaDet
    {
        public int getIdSiguiente(clsAperturaDet AperturaDet)
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.AperturaDet where a.idAperturaCaja == AperturaDet.idAperturaCaja select a.Numero).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsAperturaDet> consultaAperturaDetGeneral()
        {
            try
            {
                List<clsAperturaDet> lista = new List<clsAperturaDet>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.AperturaDet select b;
                foreach (var item in con)
                {
                    clsAperturaDet AperturaDet = new clsAperturaDet();
                    AperturaDet.idEmpresa = item.idEmpresa;
                    AperturaDet.idUsuario = item.IdUsuario;
                    AperturaDet.idAperturaCaja = item.idAperturaCaja;
                    AperturaDet.Numero = item.Numero;
                    AperturaDet.Denominacion = item.Denominacion;
                    AperturaDet.Cantidad = item.Cantidad;
                    AperturaDet.idEstado = item.idEstado;
                    lista.Add(AperturaDet);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Boolean guardar(clsAperturaDet AperturaDet)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente(AperturaDet);
                    AperturaDet ape = new AperturaDet()
                    {
                        idEmpresa = AperturaDet.idEmpresa,
                        IdUsuario = AperturaDet.idUsuario,
                        idAperturaCaja = AperturaDet.idAperturaCaja,
                        Numero = x,
                        Denominacion = AperturaDet.Denominacion,
                        Cantidad = AperturaDet.Cantidad,
                        idEstado = AperturaDet.idEstado,

                    };
                    ent.AddToAperturaDet(ape);
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
