using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Cuentasxpagar
{
    public class clsMsgCuentasPorPagar
    {
        public string mensajes(ref int n, string msj)
        {
            Console.Write(n);
            switch (n)
            {
                case 0:
                    msj = "Proceso realizado correctamente";
                    break;
                case 1:
                    msj = "No se ha podido responder a su requerimiento";
                    break;
                case 2:
                    msj = "El valor ingresado es inválido";
                    break;
                case 3:
                    msj = "La cuenta ya ha sido saldada";
                    break;
                case 4:
                    msj = "Efectivo insuciente para realizar pago";
                    break;
            }
            return msj;
        }
    }
}
