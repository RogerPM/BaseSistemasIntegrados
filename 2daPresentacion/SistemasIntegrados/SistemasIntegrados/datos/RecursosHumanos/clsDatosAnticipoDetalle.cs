using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.RecursosHumanos;

namespace datos.RecursosHumanos
{
    public class clsDatosAnticipoDetalle
    {


        //¨**** CONSULTAR CUANDO SE DE CLICK EN EL BOTON BUSCAR

        public List<clsAnticipoDetalle > ConsultaAnticipoDet(int numAnticipo)
        {
            try
            {
                List<clsAnticipoDetalle > Lista = new List<clsAnticipoDetalle >();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from ad in ent.AnticipoDet 
                          join p in ent.Persona on ad.IdPersona equals p.IdPersona
                          join c in ent.Contrato on ad.IdPersona equals c.IdPersona
                          where ad.NumAnticipo == numAnticipo
                          select new
                          {
                              pers = p.IdPersona,
                              nombre = p.NombreRazonSocial,
                              apellido = p.Apellido,
                              ident = p.Identificacion,
                              numlin = ad.NumLinea,
                              nuant = ad.NumAnticipo,
                              idp = ad.IdPersona,
                              snom =c.Remuneracion,
                              valiqu = ad.ValorLiquido,
                              idemp = ad.IdEmpresa,
                          };


                foreach (var item in con)
                {

                    clsAnticipoDetalle  Nom = new clsAnticipoDetalle ();
                    Nom.NumLinea = item.numlin;
                    Nom.NumAnticipo = item.nuant;
                    Nom.IdPersona = item.idp;
                    Nom.Nombre = item.nombre;
                    Nom.Apellido = item.apellido;
                    Nom.Identificacion = Convert.ToInt64(item.ident);
                    Nom.SueldoNominal = item.snom;
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

        public List<clsAnticipoDetalle > ConsultaAntDet()
        {
            try
            {

                List<clsAnticipoDetalle > Lista = new List<clsAnticipoDetalle >();
                RecursosHumanosEntities ent = new RecursosHumanosEntities();

                var con = from w in ent.Persona
                          join c in ent.Contrato on w.IdPersona equals c.IdPersona
                          where w.IdTipoPersona == 1
                          select w;

                foreach (var item in con)
                {

                    clsAnticipoDetalle  Nom = new clsAnticipoDetalle ();


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



       #region SueldoNominal

        public Decimal consultaSueldoN(int Persona)
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

    

    

        public Boolean Guardar(clsAnticipoDetalle  ad)
        {
            try
            {

                using (RecursosHumanosEntities ent = new RecursosHumanosEntities())
                {

                    AnticipoDet  nomd = new AnticipoDet  ()
                    {

                        NumLinea = ad.NumLinea,
                        NumAnticipo = ad.NumAnticipo ,
                        IdPersona = ad.IdPersona,

                        ValorLiquido =Convert .ToDecimal ( ad.ValorLiquido),
                        IdEmpresa = ad.IdEmpresa,

                    };
                    ent.AddToAnticipoDet (nomd);
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
                int x = ((from a in ent.AnticipoDet select a.NumLinea).Max());
                x = x + 1;
                
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
        public clsDatosAnticipoDetalle()
        {

        }
    }
}
