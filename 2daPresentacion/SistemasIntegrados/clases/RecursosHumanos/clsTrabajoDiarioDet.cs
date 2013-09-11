using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsTrabajoDiarioDet
    {
        public int NumLinea { get; set; }
        public int NumTrabajo { get; set; }
        public int IdPersona { get; set; }
        public Int64 Identificacion { get; set; }
        public int Cedula { get; set; }
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
        public int IdEmpresa { get; set; }


        int Hora = 24;
        int HoraLaborable = 8;
        DateTime HoraS;
        DateTime HoraE;
        int HoraSa;

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
            HoraTrabajada = HoraSa - HoraE.Hour;



        }
        public void HorasExtrasxDia()
        {
            HoraS = Convert.ToDateTime(HoraSalida);


            if (HoraTrabajada > 8)
            {
                if (HoraSa > Hora)
                {
                    HoraExtraT = HoraSa - Hora;
                    HoraExtraM = (HoraTrabajada - HoraLaborable) - HoraExtraT;
                    HoraRango = HoraTrabajada - HoraExtraM - HoraExtraT;
                }
                else
                {
                    HoraExtraM = HoraTrabajada - HoraLaborable;
                    HoraExtraT = 0;
                    HoraRango = HoraTrabajada - HoraExtraM;

                }

            }
            else
            {

                HoraExtraM = 0;
                HoraExtraT = 0;
                HoraRango = 0;
            }


        }



        public clsTrabajoDiarioDet()
        {

        }
    }
}
