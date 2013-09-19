using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clscompras_articulos
    {
        public int idarticulo { get; set; }
        public string descripcion { get; set; }
        public int cantidad_actual { get; set; }
        public int id_tipoarticulo { get; set; }
        public string tipo_articulo { get; set; }
        public int id_grupo { get; set; }
        public string grupo { get; set; }
        public int id_empresa { get; set; }
        public string NombreComercial { get; set; }
        public int id_estado { get; set; }
        public string estado { get; set; }
       
        
        public clscompras_articulos()
        {

        }
    }
}
