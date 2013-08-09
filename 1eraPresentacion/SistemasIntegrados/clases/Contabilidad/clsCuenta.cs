using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clsCuenta
    {

        
        public int IdEmpresa { get; set; }
        public string IdCuenta { get; set; }
        public string codigo_padre { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal IdNivelCuenta { get; set; }
        public decimal IdTipoCuenta { get; set; }
        public string naturaleza_cuenta { get; set; }
        public int IdUsuario{ get; set; }
        public DateTime FechaModficacion { get; set; }
        public decimal digitos { get; set; }
        
        
 
        public clsCuenta ()
	{



	}

    }
}

