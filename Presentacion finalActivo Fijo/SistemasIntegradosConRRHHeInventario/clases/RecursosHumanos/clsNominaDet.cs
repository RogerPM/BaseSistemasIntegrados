using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsNominaDet
    {
        public int NumLinea { get; set; }
        public int NumNomina { get; set; }
        public int IdPersona { get; set; }
        public Int64 Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int HorasTrabajadas { get; set; }
        public int HorasExtrasM { get; set; }
        public int HorasExtrasT { get; set; }
        public int HorasRango { get; set; }
        public DateTime FechaUltimaNomina { get; set; }
        public DateTime FechaContrato { get; set; }
        public DateTime FechaNomina { get; set; }
        public int TotalHorasRango { get; set; }
        public int TotalHorasExtrasM { get; set; }
        public int TotalHorasExtrasT { get; set; }
        public Decimal TotHorasExtras { get; set; }
        public Decimal ValorHorasExtras { get; set; }
        public Decimal SueldoNominal { get; set; }
        public Decimal TotalIngresos { get; set; }
        public Decimal SueldGanado { get; set; }
        public int DiasTrabajados { get; set; }
        public Decimal Iess { get; set; }
        public int IdRubro { get; set; }
        //public float PorcentajeIess { get; set; }
        public int IdPrestamo { get; set; }
        public Decimal PrestamoPago { get; set; }
        public int IdAnticipo { get; set; }
        public Decimal Anticipo { get; set; }
        public Decimal TotalDescuento { get; set; }
        public Decimal ValorLiquido { get; set; }
        public int IdEmpresa { get; set; }


        int HorasLaborables = 240;
        Decimal suelxHora;
        Decimal valor;
        Double PorcentajeIess = 9.35;
        Decimal Suelgan;


        /*public void FechaNomina()
        {

            //if (FechaUltimaNomina== )
           /* {
                FechaUltimaNomina = FechaContrato;

            }
            else
            {*/
        /*FechaUltimaNomina = FechaContrato;
       // }

    }*/



        public Decimal TotalHorasExtras(int sumT, int sumM)
        {
            TotHorasExtras = Convert.ToDecimal((sumM * 1.5) + (sumT * 2));
            return TotHorasExtras;
        }

        public Decimal ValHorasExtras(Decimal sn, Decimal Tothe)
        {
            ValorHorasExtras = ((sn / HorasLaborables) * Tothe);
            return ValorHorasExtras;
        }



        public Decimal SGanado(Decimal snom, Decimal Tothr)
        {
            suelxHora = snom / HorasLaborables;
            Suelgan = (suelxHora * Tothr);
            return Suelgan;

        }
        public Decimal Ingresos(Decimal sg, Decimal vhe)
        {
            TotalIngresos = sg + vhe;
            return TotalIngresos;

        }
        public Decimal Seguro(Decimal ing)
        {
            valor = Convert.ToDecimal(PorcentajeIess / 100);
            Iess = ing * valor;
            return Iess;

        }
        public Decimal TotDescuento(Decimal iess, Decimal antic, Decimal prespag)
        {
            TotalDescuento = iess + antic + prespag;
            return TotalDescuento;

        }
        public Decimal Liquido(Decimal ing, Decimal des)
        {
            ValorLiquido = ing - des;
            return ValorLiquido;

        }


        public clsNominaDet()
        {

        }

        public decimal SueldoGanado(int sumR)
        {
            throw new NotImplementedException();
        }
    }
}
