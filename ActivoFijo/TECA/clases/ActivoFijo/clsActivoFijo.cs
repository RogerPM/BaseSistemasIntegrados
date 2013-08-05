using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public  class clsActivoFijo
    {
        public int Codigo { get; set; }
        public int Empresa { get; set; }
        public int departamento { get; set; }
        public int responsable { get; set; }
        public int usuario { get; set; }
        public int tipo { get; set; }
        public int grupo { get; set; }
        public int subgrupo { get; set; }
        public int articulo { get; set; }
        public string descripcion { get; set; }
        public float valor_nominal { get; set; }
        public float valor_residual { get; set; }
        public float valor_actualserie { get; set; }
        public int codigo_barra { get; set; }
        public int serie { get; set; }
        public int marca { get; set; }
        public DateTime fecha_deprecioacion { get; set; }
        public int ano_vidautil { get; set; }
        public int estado { get; set; }
        public DateTime fecha_registro { get; set; }

        public clsActivoFijo()
        {


        }


    }
}
