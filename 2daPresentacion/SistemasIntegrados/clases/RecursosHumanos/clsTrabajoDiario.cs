using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsTrabajoDiario
    {
         public int NumTrabajo { get; set; }
         public DateTime  FechaDesde { get; set; }
         public DateTime FechaHasta { get; set; }
         public int IdEstado { get; set; }
         public int IdEmpresa { get; set; }
         public string Observacion { get; set; }
         public int IdPersona { get; set; }
         public Int64 Identificacion { get; set; }
         public string Apellido { get; set; }
         public string Nombre { get; set; }
         public string HoraInicio { get; set; }
         public string HoraSalida { get; set; }
         public DateTime HoraEntrada1 { get; set; }
         public DateTime HoraSalida2 { get; set; }
         public int HoraTrabajada { get; set; }
         public int HoraExtraM { get; set; }
         public int HoraExtraT { get; set; }
         public int HoraRango { get; set; }
         public int dia { get; set; }


         int Hora = 24;
         int HoraLaborable = 8;
         DateTime HoraS;
         DateTime HoraE;
         DateTime FechaD;
         DateTime FechaH;
         int HoraSa;

         public void Dias()
         {

             FechaD  = Convert.ToDateTime(FechaDesde );
             FechaH = Convert.ToDateTime(FechaHasta );
             

             

             // Difference in days, hours, and minutes.
             TimeSpan ts = FechaH  - FechaD ;
             dia = ts.Days;

            



         }

         public void HorasTrabajadas()
         {

             HoraS = Convert.ToDateTime(HoraSalida);
             HoraE = Convert.ToDateTime(HoraInicio);
             if (HoraS.Hour < HoraE.Hour)
             {
                 HoraSa = Hora + HoraS.Hour;

             }
             else
             {
                 HoraSa = HoraS.Hour;
             }
             HoraTrabajada = HoraSa - HoraE.Hour ;



         }
         public void HorasExtrasxDia()
         {
             HoraS = Convert.ToDateTime(HoraSalida);


             if (HoraTrabajada > 8)
             {
                 if (HoraSa > Hora)
                 {
                     HoraExtraT = (HoraSa - Hora)*dia;
                     HoraExtraM = ((HoraTrabajada - HoraLaborable) - HoraExtraT)*dia;
                     HoraRango =( HoraTrabajada - HoraExtraM/dia- HoraExtraT/dia)*dia ;
                 }
                 else
                 {
                     HoraExtraM = (HoraTrabajada - HoraLaborable)*dia ;
                     HoraExtraT = 0;
                     HoraRango = (HoraTrabajada - HoraExtraM/dia)*dia ;

                 }

             }
             else
             {

                 HoraExtraM = 0;
                 HoraExtraT = 0;
                 HoraRango = HoraTrabajada*dia;
             }


         }

        public clsTrabajoDiario ()
	    {

	    }
    }
}
