using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosNominaDet
    {


        //¨**** CONSULTAR CUANDO SE DE CLICK EN EL BOTON BUSCAR

        public List<clsNominaDet> ConsultaNominaDet(int numNomina)
        {
            try
            {
                List<clsNominaDet> Lista = new List<clsNominaDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from nd in ent.NominaDet
                          join p in ent.Persona on nd.IdPersona equals p.IdPersona
                          where nd.NumNomina == numNomina
                          select new
                          {
                              pers = p.IdPersona,
                              nombre = p.NombreRazonSocial,
                              apellido = p.Apellido,
                              ident = p.Identificacion,
                              numlin = nd.NumLinea,
                              numn = nd.NumNomina,
                              idp = nd.IdPersona,
                              snom = nd.SueldoNominal,
                              sgan = nd.SueldoGanado,
                              iess = nd.Iess,
                              pres = nd.Prestamo,
                              anti = nd.Anticipo,
                              valiqu = nd.ValorLiquido,
                              idemp = nd.IdEmpresa,
                          };


                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();
                    Nom.NumLinea = item.numlin;
                    Nom.NumNomina = item.numn;
                    Nom.IdPersona = item.idp;
                    Nom.Nombre = item.nombre;
                    Nom.Apellido = item.apellido;
                    Nom.Identificacion = Convert.ToInt64(item.ident);
                    Nom.SueldoNominal = item.snom;
                    Nom.SueldGanado = Convert.ToDecimal(item.sgan);
                    Nom.Iess = Convert.ToDecimal(item.iess);
                    Nom.PrestamoPago = Convert.ToDecimal(item.pres);
                    Nom.Anticipo = Convert.ToDecimal(item.anti);
                    Nom.ValorLiquido = Convert.ToDecimal(item.valiqu);
                    Nom.IdEmpresa = item.idemp;


                    Lista.Add(Nom);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //**** LLENAR EL GRID CONTROL CON LOS DATOS NECESARIOS

        public List<clsNominaDet> ConsultaNomDet()
        {
            try
            {

                List<clsNominaDet> Lista = new List<clsNominaDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from w in ent.Persona
                          join c in ent.Contrato on w.IdPersona equals c.IdPersona
                          where w.IdTipoPersona == 1
                          select w;

                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.IdPersona = item.IdPersona;
                    Nom.Identificacion = Convert.ToInt32(item.Identificacion);
                    Nom.Apellido = item.Apellido;
                    Nom.Nombre = item.NombreRazonSocial;

                    Lista.Add(Nom);

                }
                return Lista;
            }
            catch (Exception)
            {
                return null;
            }
        }



        #region Horas100%

        public int consultaHorasT(int Persona)
        {
            try
            {

                List<clsNominaDet> Lista = new List<clsNominaDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int sumaHorasEstrasT = 0;

                var con = from t in ent.TrabajoDiarioDet

                          where t.IdPersona == Persona


                          select new
                          {
                              HorasExtrasT = t.HoraExtraT,

                          };

                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.HorasExtrasT = Convert.ToInt32(item.HorasExtrasT);
                    sumaHorasEstrasT = sumaHorasEstrasT + Nom.HorasExtrasT;



                    Lista.Add(Nom);

                }
                return sumaHorasEstrasT;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion


        #region Horas50%

        public int consultaHorasM(int Persona)
        {
            try
            {

                List<clsNominaDet> Lista = new List<clsNominaDet>();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int sumaHorasEstrasM = 0;

                var con = from t in ent.TrabajoDiarioDet
                          where t.IdPersona == Persona

                          select new
                          {
                              HorasExtrasM = t.HoraExtraM,

                          };



                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.HorasExtrasM = Convert.ToInt32(item.HorasExtrasM);
                    sumaHorasEstrasM = sumaHorasEstrasM + Nom.HorasExtrasM;



                    Lista.Add(Nom);

                }
                return sumaHorasEstrasM;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion

        #region HorasRango

        public int consultaHorasR(int Persona)
        {
            try
            {


                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int sumaHorasRango = 0;

                var con = from t in ent.TrabajoDiarioDet
                          where t.IdPersona == Persona

                          select new
                          {
                              HorasR = t.HoraRango,

                          };



                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.HorasRango = Convert.ToInt32(item.HorasR);
                    sumaHorasRango = sumaHorasRango + Nom.HorasRango;


                }
                return sumaHorasRango;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion

        #region SueldoNominal

        public Decimal consultaSueldoN(int Persona, Decimal Tothe)
        {
            try
            {


                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                Decimal sn = 0;
                var con = from c in ent.Contrato
                          where c.IdPersona == Persona

                          select new
                          {
                              Remuneracion = c.Remuneracion,

                          };



                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.SueldoNominal = Convert.ToInt32(item.Remuneracion);
                    sn = Nom.SueldoNominal;


                }
                return sn;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion

        #region Anticipo

        public Decimal consultaAnticipo(int Persona)
        {
            try
            {

                Decimal ant = 0;
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from a in ent.AnticipoCab
                          where a.IdEmpleado == Persona

                          select new
                          {
                              Anticipo = a.Total,

                          };



                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.Anticipo = Convert.ToInt32(item.Anticipo);
                    ant = Nom.Anticipo;


                }
                return ant;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion

        #region Prestamo

        public Decimal consultaPrestamo(int Persona)
        {
            try
            {

                Decimal pres = 0;
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                var con = from p in ent.Prestamo
                          where p.IdPersona == Persona

                          select new
                          {
                              Prestamo = p.Pago,

                          };



                foreach (var item in con)
                {

                    clsNominaDet Nom = new clsNominaDet();


                    Nom.PrestamoPago = Convert.ToInt32(item.Prestamo);
                    pres = Nom.PrestamoPago;


                }
                return pres;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        # endregion

        public Boolean Guardar(clsNominaDet nd)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    NominaDet nomd = new NominaDet()
                    {

                        NumLinea = nd.NumLinea,
                        NumNomina = nd.NumNomina,
                        IdPersona = nd.IdPersona,

                        SueldoNominal = nd.SueldoNominal,
                        SueldoGanado = Convert.ToDecimal(nd.SueldGanado),
                        Iess = Convert.ToDecimal(nd.Iess),
                        Prestamo = Convert.ToDecimal(nd.PrestamoPago),
                        Anticipo = Convert.ToDecimal(nd.Anticipo),
                        ValorLiquido = Convert.ToDecimal(nd.ValorLiquido),
                        IdEmpresa = nd.IdEmpresa,

                    };
                    ent.AddToNominaDet(nomd);
                    ent.SaveChanges();


                }
                return true;
            }


            catch (Exception)
            {
                return false;
            }
        }

        public void Modificar(clsNominaCab nc)
        {
            using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
            {

                var x = (from q in ent.NominaCab where q.NumNomina == nc.NumNomina select q).First();
                x.NumNomina = nc.NumNomina;
                x.Fecha = nc.Fecha;
                x.FechaModificacion = nc.FechaModificacion;
                x.Periodo = nc.Periodo;
                x.Total = nc.Periodo;
                x.IdEstado = nc.IdEstado;
                x.IdEmpresa = nc.IdEmpresa;
                x.Observacion = nc.Observacion;


                ent.SaveChanges();

            }
        }
        public int getIdSiguiente()
        {
            try
            {
                RecursosHumanosEntities ent = new RecursosHumanosEntities();
                int x = ((from a in ent.NominaDet select a.NumLinea).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        public clsDatosNominaDet()
        {

        }
    }
}
