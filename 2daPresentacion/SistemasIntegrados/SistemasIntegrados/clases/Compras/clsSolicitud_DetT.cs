using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

///es la clase de la tabla de detalle no de la vista entiende!!!
namespace clases.Compras
{
    public class clsSolicitud_DetT
    {
        public int Numero { get; set; }
        public int Id_Empresa { get; set; }
        public int linea { get; set; }
        public int Id_articulo { get; set; }
        public int cantidad { get; set; }


        public clsSolicitud_DetT()
        {

        }
    }
}
