using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosTrabajoDioarioDet
    {

        //¨**** CONSULTAR CUANDO SE DE CLICK EN EL BOTON BUSCAR
        public List<clsTrabajoDiarioDet> ConsultaTrabajoDiarioDet(int numTrabajo)
        {
            try
            {
                List<clsTrabajoDiarioDet> Lista = new List<clsTrabajoDiarioDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from t in ent.TrabajoDiarioDet
                          join p in ent.Persona on t.IdPersona equals p.IdPersona
                          where t.NumTrabajo == numTrabajo
                          orderby p.Apellido
                          select new
                          {
                              IdPersona = t.IdPersona,

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

                    clsTrabajoDiarioDet Trab = new clsTrabajoDiarioDet();

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


        //**** LLENAR EL GRID CONTROL CON LOS DATOS NECESARIOS
        public List<clsTrabajoDiarioDet> ConsultaTrabajoDet()
        {
            try
            {
                List<clsTrabajoDiarioDet> Lista = new List<clsTrabajoDiarioDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from w in ent.Persona select w;




                foreach (var item in con)
                {

                    clsTrabajoDiarioDet Trab = new clsTrabajoDiarioDet();
                    Trab.IdPersona = item.IdPersona;
                    Trab.Identificacion = Convert.ToInt64(item.Identificacion);
                    Trab.Apellido = item.Apellido;
                    Trab.Nombre = item.NombreRazonSocial;
                    //Trab.HoraEntrada1 = Convert.ToDateTime(item.HoraEntrada);
                    //Trab.HoraSalida2 = Convert.ToDateTime(item.HoraSalida);

                    Lista.Add(Trab);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public Boolean Guardar(clsTrabajoDiarioDet td)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {
                    td.HorasTrabajadas();
                    td.HorasExtrasxDia();

                    TrabajoDiarioDet trd = new TrabajoDiarioDet()

                    {

                        NumLinea = td.NumLinea,
                        NumTrabajo = td.NumTrabajo,
                        IdPersona = td.IdPersona,
                        HoraEntrada = td.HoraInicio,
                        HoraSalida = td.HoraSalida,
                        HoraTrabajada = td.HoraTrabajada,
                        HoraExtraM = td.HoraExtraM,
                        HoraExtraT = td.HoraExtraT,
                        HoraRango = td.HoraRango,
                        IdEmpresa = td.IdEmpresa,


                    };
                    ent.AddToTrabajoDiarioDet(trd);
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
                int x = ((from a in ent.TrabajoDiarioDet select a.NumLinea).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        public clsDatosTrabajoDioarioDet()
        {

        }
    }
}
