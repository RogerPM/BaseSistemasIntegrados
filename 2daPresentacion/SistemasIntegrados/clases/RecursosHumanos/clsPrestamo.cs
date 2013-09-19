using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    
    public class clsPrestamo
    {
        public int IdPrestamo { get; set; }
        public int IdPersona { get; set; }
        public Int64  Identificacion{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaModificacion { get; set; }
        public Decimal Monto { get; set; }
        public Decimal Pago { get; set; }
        public Decimal Total { get; set; }
        public Decimal Interes { get; set; }
        public Decimal TotalPagado { get; set; }
        public int Periodos { get; set; }
        public int IdEstado { get; set; }
        public int IdEmpresa { get; set; }


        Decimal Valor;
        Decimal Valor1; 
        Decimal Valor2;
        Decimal Valor3;
        Decimal Valor4;
        Decimal  TMensual;
        Decimal Cuotas;
        Decimal tot;
        Decimal pot;
        Decimal tp;

        public Decimal TasaMensual(Decimal tasa, Decimal pres,int per)
        {
            Valor = tasa / 100;
            TMensual = Valor / 12;
            Valor1 = pres * TMensual;
            Valor2 = 1 + TMensual;
            Valor3 = Convert .ToDecimal( Math.Pow(Convert.ToDouble(Valor2), Convert.ToDouble(-(per))));
            Valor4 = 1 - Valor3;
            Cuotas =Valor1 /Valor4;
            return Cuotas ;
        }

        public Decimal Tot(int cuot, Decimal pag)
        {
            tot = pag * cuot;
            return tot;

        }
        public Decimal TotPag(Decimal tot,Decimal pag)
        {
            tp = tot + pag;
            return tp;

        }

        

        
        public clsPrestamo()
        {

        }
    }
}
