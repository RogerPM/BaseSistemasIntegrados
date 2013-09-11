using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosMovimientoBancario
    {
        public List<clsMovimientobancario> consulta()
        {
            try
            {
                List<clsMovimientobancario> lista = new List<clsMovimientobancario>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.MovimientoBancario select w;
                foreach (var item in con)
                {
                    clsMovimientobancario mov = new clsMovimientobancario();
                    mov.idMovimientoBancario = item.idMovimientoBancario;
                    mov.NumeroDocumento = item.NumeroDocumento;
                    
                    mov.idEmpresa = item.idEmpresa;
                    mov.Observacion = item.Observacion;
                    mov.Fecha = item.Fecha;
                    mov.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                   //ojo cambiar xq usuario lo borrara seguridad
                    mov.idUsuario = item.idUsuario;
                    mov.Valor = item.Valor;

                    lista.Add(mov);

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

        public Boolean guardar(clsMovimientobancario movimiento)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    MovimientoBancario movban = new MovimientoBancario()
                    {
                        idMovimientoBancario = movimiento.idMovimientoBancario,
                        Observacion = movimiento.Observacion,
                        Fecha= movimiento.Fecha,
                        FechaModificacion= movimiento.FechaModificacion,
                        Valor = movimiento.Valor,
                        idEstado  = movimiento.idEstado,
                        idUsuario = movimiento.idUsuario,
                        idEmpresa = movimiento.idEmpresa,
                        idTransaccion= movimiento.idTransaccion,
                        idBanco= movimiento.idBanco,

                    };
                    ent.AddToMovimientoBancario(movban);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public Boolean anular(clsMovimientobancario movimiento)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.MovimientoBancario where q.idMovimientoBancario == movimiento.idMovimientoBancario select q).First();

                x.idMovimientoBancario = movimiento.idMovimientoBancario;
                x.idBanco = movimiento.idBanco;
                x.idEmpresa = movimiento.idEmpresa;
                x.NumeroDocumento = movimiento.NumeroDocumento;
                x.idUsuario = movimiento.idUsuario;
                x.idTransaccion = movimiento.idTransaccion;
                x.Observacion = movimiento.Observacion;
                x.Fecha = movimiento.Fecha;
                x.FechaModificacion = movimiento.FechaModificacion;
                x.Valor = movimiento.Valor;
                x.idEstado = 2;
                

                ent.SaveChanges();

                return true;
            }
        }

    }
}
