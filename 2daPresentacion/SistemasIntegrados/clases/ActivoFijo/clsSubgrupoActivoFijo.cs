using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace clases.ActivoFijo
{
   public  class clsSubgrupoActivoFijo
    {
        	

        public int Codigo { get; set; }
        public int Grupo { get; set; }
        public string descripcion { get; set; }
        public DateTime  Fecha { get; set; }
        public int IdEstado { get; set; }
        public String _EstadoProceso { get; set; }
        public int Empresa { get; set; }
        

        public clsSubgrupoActivoFijo()
        {

        }

       
    }
}
