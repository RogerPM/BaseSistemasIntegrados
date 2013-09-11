using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace clases.CuentasxCobrar
{
    public class clsMonetarioDetalle
    {
        public int idEmpresa { get; set; }//cambiar empresa id empresa
        public int idDetalleMonetario { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; } // en la base es tipo dato money
        public string Estado { get; set; }// clsEstado idEstado


        public clsMonetarioDetalle()
        {
        }
    }
}
