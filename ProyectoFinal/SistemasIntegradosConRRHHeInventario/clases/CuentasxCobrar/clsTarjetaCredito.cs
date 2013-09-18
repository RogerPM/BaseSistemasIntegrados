using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace clases.CuentasxCobrar
{
    public class clsTarjetaCredito
    {
        public int idEmpresa { get; set; }//cambiar empresa id empresa
        public int idTarjeta { get; set; }
        public string Descripcion { get; set; }
        public int idBanco { get; set; }  
        public string Estado { get; set; }

        public clsTarjetaCredito()
        {
        }
    }
}
