using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsCotizacionCab
    {
        public int Numero { get; set; }
        public int Id_Empresa { get; set; }
        public string Empresa { get; set; }
        public int Id_Tipo_Articulo { get; set; }
        public string Tipo_Artículo { get; set; }
        public int Id_Usuario { get; set; }
        public string Usuario { get; set; }
        public int Id_Departamento { get; set; }
        public string Departamento { get; set; }
        public DateTime Fecha { get; set; }
        public int Id_Estado { get; set; }
        public string Estado { get; set; }


        public clsCotizacionCab()
        {

        }
    }
}
