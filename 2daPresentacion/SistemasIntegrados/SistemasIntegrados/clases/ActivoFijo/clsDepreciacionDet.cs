using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsDepreciacionDet
    {
        public int idCabecera { get; set; }
        public int Codigo_SecuDepreciDet { get; set; }
        public int idActivoFijo { get; set; }
        public int Perido { get; set; }
        public int idEmpresa { get; set; }
        public double depreAnual { get; set; }
        public double depreAcumulada { get; set; }
        public double ValorNominal { get; set; }//Campo entreda de valor del Activo
        public double ValorActual { get; set; }//campo salida de valor del Activo



        public clsDepreciacionDet()
        {
            idEmpresa = 1;
        }
    }
}
