using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;

namespace datos.CuentasxCobrar
{
    public class clsDatosInversion
    {
        CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();

        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.Inversion select a.idInversion).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        
        public Boolean guardar(clsInversion Inversion)
             {
                 try
                 {
                     using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                     {
                         int x = this.getIdSiguiente();
                         Inversion inversion = new Inversion()
                         {
                             idEmpresa = Inversion.idEmpresa,
                             idUsuario = Inversion.idUsuario,
                             idInversion = x,
                             idEntidad = Inversion.idEntidad,
                             idTipoInversion = Inversion.idTipoInversion,
                             Tiempo = Inversion.Tiempo,
                             idUnidadTiempo = Inversion.idUnidadTiempo,
                             idBanco = Inversion.idBanco,
                             Valor = Inversion.Valor,
                             Porcentaje = Inversion.Porcentaje,
                             Ganancia = Inversion.Ganancia,
                             Fecha = Inversion.Fecha,
                             FechaModificacion = Inversion.FechaModificacion,
                             FechaInicio = Inversion.FechaInicio,
                             FechaFinal = Inversion.FechaFinal,
                             idEstado = Inversion.idEstado,
                         };
                         ent.AddToInversion(inversion);
                         ent.SaveChanges();

                     }
                     return true;
                 }
                 catch (Exception)
                 {

                     return false;
                 }
             }

        public List<clsInversion> consultaInversionGeneral()
        {
            try
            {
                List<clsInversion> lista = new List<clsInversion>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from b in ent.Inversion select b;
                foreach (var item in con)
                {
                    clsInversion inversion = new clsInversion();
                    inversion.idEmpresa = item.idEmpresa;
                    inversion.idUsuario = item.idUsuario;
                    inversion.idInversion = item.idInversion;
                    inversion.idEntidad = item.idEntidad;
                    inversion.idTipoInversion = item.idTipoInversion;
                    inversion.Tiempo = item.Tiempo;
                    inversion.idUnidadTiempo = item.idUnidadTiempo;
                    inversion.idBanco = Convert.ToInt32(item.idBanco);
                    inversion.Valor = item.Valor;
                    inversion.Porcentaje = item.Porcentaje;
                    inversion.Ganancia = Convert.ToDecimal(item.Ganancia);
                    inversion.Fecha = item.Fecha;
                    inversion.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                    inversion.FechaInicio = item.FechaInicio;
                    inversion.FechaFinal = item.FechaFinal;
                    inversion.idEstado = item.idEstado;

                    lista.Add(inversion);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ConsultaPersonaEspecifica(ref String[] strPersona)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                int idPersona = Convert.ToInt32(strPersona[0]);
                var x = (from q in ent.Persona where q.Identificacion == idPersona select q).First();

                strPersona[0] = Convert.ToString(x.Identificacion); //Error no se puede convertit implicitamente int
                strPersona[1] = x.NombreRazonSocial + " " + x.Apellido;
            }

        }

        public void ConsultaInversionEspecifica(clsInversion inversion)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.Inversion where q.idInversion == inversion.idInversion select q).First();

                inversion.idEmpresa = x.idEmpresa; //Error no se puede convertit implicitamente int
                inversion.idUsuario = x.idUsuario;
                inversion.idInversion = x.idInversion;
                inversion.idEntidad = x.idEntidad;
                inversion.idTipoInversion = x.idTipoInversion;
                inversion.Tiempo = x.Tiempo;
                inversion.idUnidadTiempo = x.idUnidadTiempo;
                inversion.idBanco = Convert.ToInt32(x.idBanco);
                inversion.Valor = x.Valor;
                inversion.Porcentaje = x.Porcentaje;
                inversion.Ganancia = Convert.ToDecimal(x.Ganancia);
                inversion.Fecha = x.Fecha;
                inversion.FechaModificacion = Convert.ToDateTime(x.FechaModificacion);
                inversion.FechaInicio = x.FechaInicio;
                inversion.FechaFinal = x.FechaFinal;
                inversion.idEstado = x.idEstado;
            }
        }
     }
}
