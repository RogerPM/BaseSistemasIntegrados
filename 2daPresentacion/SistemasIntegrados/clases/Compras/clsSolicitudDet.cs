using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Compras
{
    public class clsSolicitudDet
    {

        public int Numero { get; set; }
        public int linea { get; set; }
        public int id_articulo { get; set; }
        public string Articulo { get; set; }
        public int Cantidad { get; set; }
        public int Id_empresa { get; set; }
        public string Empresa { get; set; }


        public clsSolicitudDet()
        {

        }

        public clsSolicitudDet(int p, int p_2, int p_3, string p_4, int p_5, int p_6, string p_7)
        {
            // TODO: Complete member initialization
            this.Numero = p;
            this.linea= p_2;
            this.id_articulo = p_3;
            this.Articulo = p_4;
            this.Cantidad = p_5;
            this.Id_empresa = p_6;
            this.Empresa = p_7;
        }


    }
}
