using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.CuentasxCobrar
{
    public class clsCuentaBancaria
    {
        public int idEmpresa { get; set; }
        public int idCuentaBancaria { get; set; }
	    public int idBanco { get; set; }
        public int idTitular { get; set; }
        public int NumeroCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public decimal Saldo { get; set; }
        public string Estado { get; set; }

        public clsCuentaBancaria()
        {
        }


    }
}
