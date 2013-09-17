using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsDetalleTelefono
    {
        public int _IdTelefono { get; set; }
        public int _numTelefono { get; set; }
        public int _TipoTelefono { get; set; }


        public clsDetalleTelefono ()
	    {

	    }
        
        public int getNumTelefono()
        {
            return _numTelefono;
        }

        public int getTipoTelefono()
        {
            return _TipoTelefono;
        }
        
    }
}