using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datos.Inventario
{
    public class clsClaseDatosBodega
    {
        public int idEmpresa { get; set; }
        public int idBodega { get; set; }
        public string Descripcion { get; set; }
        public int capacidad { get; set; }
        public int Responsable { get; set; }
        public int percha { get; set; }
        public string Dictionary { get; set; }
        public string telefono { get; set; }
        public int idEstado { get; set; }


        public clsClaseDatosBodega()
        {

        }
    }
}
