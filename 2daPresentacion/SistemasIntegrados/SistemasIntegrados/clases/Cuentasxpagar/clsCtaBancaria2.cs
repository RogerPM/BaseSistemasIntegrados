using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsCtaBancaria2
    {
        public int _IdCuentaBancaria { get; set; }
        public int _IdBanco { get; set; }
        public string _TipoCuenta { get; set; }
        public string _NroCuenta { get; set; }
        public int _Empresa { get; set; }
        public int _IdEmpresaServicio { get; set; }

        public clsCtaBancaria2()
        {

        }

        public int getIdBanco()
        {
            return _IdBanco;
        }

        public string getTipoCuenta()
        {
            return _TipoCuenta;
        }

        public string getNroCuenta()
        {
            return _NroCuenta;
        }
    }
}