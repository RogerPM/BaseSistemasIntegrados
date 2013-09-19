using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosTrabajoDiario
    {
        public List<clsTrabajoDiario> ConsultaTrabajoDiario()
        {
            try
            {
                List<clsTrabajoDiario> Lista = new List<clsTrabajoDiario>();
                RecursosHumanosEntities  ent = new RecursosHumanosEntities();

                var con = from t in ent.TrabajoDiario
                          join p in ent.Persona on t.IdPersna equals p.IdPersona
                          select new
                          {
                              IdPersona = t.IdPersna,
                              numero = t.NumTrabajo,
                              observacion = t.Observacion,
                              desde = t.FechaDesde,
                              hasta = t.FechaHasta,
                              Cedula = p.Identificacion,
                              Nombre = p.NombreRazonSocial,
                              Apellido = p.Apellido,
                              HoraEntrada = t.HoraEntrada,
                              HoraSalida = t.HoraSalida,
                              HoraTrabajada = t.HoraTrabajada,
                              HoraExtraM = t.HoraExtraM,
                              HoraExtraT = t.HoraExtraT,
                              HoraRango = t.HoraRango
                          };



                foreach (var item in con)
                {

                    clsTrabajoDiario Trab = new clsTrabajoDiario();
                    Trab.NumTrabajo = item.numero;
                    Trab.Observacion = item.observacion;
                    Trab.FechaDesde = item.desde;
                    Trab.FechaHasta = item.hasta;
                    Trab.Identificacion = Convert.ToInt64(item.Cedula);
                    Trab.Apellido = item.Apellido;
                    Trab.Nombre = item.Nombre;
                    Trab.HoraEntrada1 = Convert.ToDateTime(item.HoraEntrada);
                    Trab.HoraSalida2 = Convert.ToDateTime(item.HoraSalida);
                    Trab.HoraTrabajada = item.HoraTrabajada;
                    Trab.HoraExtraM = Convert.ToInt32(item.HoraExtraM);
                    Trab.HoraExtraT = Convert.ToInt32(item.HoraExtraT);
                    Trab.HoraRango = item.HoraRango;

                    Lista.Add(Trab);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }



        public Boolean Guardar(clsTrabajoDiario td)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    td.Dias();
                    td.HorasTrabajadas();
                    td.HorasExtrasxDia();
                   

                    TrabajoDiario trd = new TrabajoDiario()

                    {


                        NumTrabajo = td.NumTrabajo,
                        Observacion = td.Observacion,
                        FechaDesde = td.FechaDesde,
                        FechaHasta = td.FechaHasta,
                        IdPersna = td.IdPersona,
                        HoraEntrada = td.HoraInicio,
                        HoraSalida = td.HoraSalida,
                        HoraTrabajada = td.HoraTrabajada,
                        HoraExtraM = td.HoraExtraM,
                        HoraExtraT = td.HoraExtraT,
                        HoraRango = td.HoraRango,
                        IdEmpresa = td.IdEmpresa,
                        NDias=td .dia,

                    };
                    ent.AddToTrabajoDiario(trd);
                    ent.SaveChanges();


                }
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int x = ((from a in ent.TrabajoDiario select a.NumTrabajo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        
        public clsDatosTrabajoDiario()
        {

        }
    }
}
