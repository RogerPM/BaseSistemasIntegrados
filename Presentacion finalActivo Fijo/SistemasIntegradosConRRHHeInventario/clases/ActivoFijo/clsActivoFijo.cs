using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public  class clsActivoFijo
    {
        public int Codigo { get; set; }
        public int Cantidad { get; set; }
        public int Empresa { get; set; }
        public int departamento { get; set; }
        public int responsable { get; set; }
        public int ArtBodega { get; set; }
        public int usuario { get; set; }        
        public int tipo { get; set; }
        public int grupo { get; set; }
        public int subgrupo { get; set; }
        public int articulo { get; set; }
        public int proveedor { get; set; }
        public string descripcion { get; set; }
        public double valor_nominal { get; set; }//Vendria hacer el costo
        public double  ValorAdquisicion { get; set; }//vendria hacer el costo con cual se compro el Activo
        public double valor_residual { get; set; }
        public double valor_actualserie { get; set; }//Vendria hacer el valor de la adquisicion
        public int codigo_barra { get; set; }
        public String _EstadoProceso { get; set; }
        public DateTime Fecha_Adquisicion { get; set; }
        public int ano_vidautil { get; set; }
        public int estado { get; set; }
        public DateTime fecha_registro { get; set; }

        //Estas variables son por el momento hasta que seguridad pase sus datos
        public string _Usuario = "Edwin Estacio Bermeo";
        public string _Empresa = "TECA";

        public clsActivoFijo()
        {
            Empresa = 1;
            usuario = 1;
            estado = 1;

            tipo = 4;
            _EstadoProceso = "Activo";
        }

        //Varialbes de Años deprecibles y sus procentajes
        public double PorcentajeDepciable_Vehiculos= 0.20;
        public int aniosDepreciable_Vehiculos = 5;
        public double PorcentajeDepciable_Maquinarias= 0.10;
        public int aniosDepreciable_Maquinarias= 10;
        public double PorcentajeDepciable_EquiposCompu = 0.33;
        public int aniosDepreciable_EquiposCompu = 3;
        public double PorcentajeDepciable_MueblesEnseres = 0.10;
        public int aniosDepreciable_MueblesEnseres = 10;
        public double PorcentajeDepciable_Edificios = 0.5;
        public int aniosDepreciable_Edificios = 20;
    }
}
