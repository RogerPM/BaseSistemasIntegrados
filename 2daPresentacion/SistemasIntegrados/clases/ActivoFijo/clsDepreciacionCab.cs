using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsDepreciacionCab
    {
        public int Codigo_SecuDepreciCab { get; set; }
        public int idEmpresa { get; set; }
        public int idUsuario { get; set; }
        public String _EstadoProceso { get; set; }
        public DateTime fecharegistro { get; set; }
        public DateTime fechaModificacion { get; set; }
        public string observacion { get; set; }

        //Estas variables son por el momento hasta que seguridad pase sus datos
        public string _Usuario = "Edwin Estacio Bermeo";
        public string _Empresa = "TECA";


        public clsDepreciacionCab()
        {
            idEmpresa = 1;
            idUsuario = 1; _EstadoProceso = "Activo";
        }
    }
}
