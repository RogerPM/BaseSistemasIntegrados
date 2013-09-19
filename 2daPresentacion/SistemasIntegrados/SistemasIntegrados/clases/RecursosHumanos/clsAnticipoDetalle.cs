using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.RecursosHumanos
{
    public class clsAnticipoDetalle
    {
        public int NumLinea { get; set; }
        public int NumAnticipo { get; set; }
        public int IdPersona { get; set; }
        public Int64 Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Decimal SueldoNominal { get; set; }
        public Decimal ValorLiquido { get; set; }
        public int IdEmpresa { get; set; }

        Decimal porcen;

        
        public Decimal Liquido(Decimal sn, Decimal por)
        {
            porcen = por / 100;
            ValorLiquido = sn * porcen  ;
            return ValorLiquido;

        }


        public clsAnticipoDetalle()
        {

        }

        
    }
}
