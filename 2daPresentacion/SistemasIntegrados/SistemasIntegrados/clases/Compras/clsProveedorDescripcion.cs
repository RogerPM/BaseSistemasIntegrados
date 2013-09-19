using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsProveedorDescripcion
    {
        


        public int idProveedor { get; set; }
        public int idPersona { get; set; }
        public string nombrerazonsocial { get; set; }
        public int idEmpresa { get; set; }  
        public string razonsocial { get; set; }
        public int idTipoArticulo { get; set; }
        public string descripcion { get; set; }
        public int Estado { get; set; }
        
        public clsProveedorDescripcion()
        {

        }

        public clsProveedorDescripcion(int p1, int p2, string p3, int p4, string p5, int p6, string p7, int p8)
        {
            // TODO: Complete member initialization
            this.idProveedor = p1;
            this.idPersona = p2;
            this.nombrerazonsocial = p3;
            this.idEmpresa = p4;
            this.razonsocial = p5;
            this.idTipoArticulo = p6;
            this.descripcion = p7;
            this.Estado = p8;
        }

 
    }
}
