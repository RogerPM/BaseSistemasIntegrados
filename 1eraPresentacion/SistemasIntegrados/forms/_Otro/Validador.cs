using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
namespace forms._Otro
{
    public class Validador
    {
        private static string titulo = "Error de Entrada";
        public static string Titulo { get { return titulo; } set { titulo = value; } }
        public static bool EstaPresente(Control control)
        {
            if (control.GetType().ToString() == "System.Windows.Forms.TextBox")
            {
                TextBox cajadeTexto = (TextBox)control;
                if (cajadeTexto.Text == "")
                {
                    MessageBox.Show(cajadeTexto.Tag + " es un campo requerido.", Titulo);
                    cajadeTexto.Focus();
                    return false;
                }
            }
            else if (control.GetType().ToString() == "System.Windows.Froms.ComboBox")
            {
                ComboBox cuadroCombinado = (ComboBox)control;
                if (cuadroCombinado.SelectedIndex == -1)
                {
                    MessageBox.Show(cuadroCombinado.Tag + " es un campo requerido.", "Error de Entrada");
                    cuadroCombinado.Focus();
                    return false;
                }
            }
            return true;
        }
        public static bool EsDecimal(TextBox cajadeTexto)
        {
            try
            {
                Convert.ToDecimal(cajadeTexto.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(cajadeTexto.Tag + " debe ser un número decimal.", Titulo);
                cajadeTexto.Focus();
                return false;
            }
        }
        public static bool EsEntero(TextBox cajadeTexto)
        {
            try
            {
                Convert.ToInt32(cajadeTexto.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(cajadeTexto.Tag + " Debe ser un entero.", Titulo);
                cajadeTexto.Focus();
                return false;
            }
        }
        public static bool EstaDentrodelRango(TextBox cajadeTexto, decimal min, decimal max)
        {
            decimal numero = Convert.ToDecimal(cajadeTexto.Text);
            if (numero < min || numero > max)
            {
                MessageBox.Show(cajadeTexto.Tag + " debe estar entre " + min
                    + " y " + max + ".", Titulo);
                cajadeTexto.Focus();
                return false;
            }
            return true;
        }
        public static bool ContraseñaValidad(TextBox cajadeTexto)
        {

            bool tieneLetrasMayusculas = false;
            bool tieneLetrasMinusculas = false;
            bool tieneNumeros = false;
            bool tieneCaracteresEspeciales = false;
            foreach (char c in cajadeTexto.Text)
            {
                if (char.IsUpper(c)) tieneLetrasMayusculas = true;
                else if (char.IsLower(c)) tieneLetrasMinusculas = true;
                else if (char.IsDigit(c)) tieneNumeros = true;
                else if (Regex.IsMatch(c.ToString(), @"[!#$%&'()*+,-.:;<=>?@[\\\]{}^_`|~]")) tieneCaracteresEspeciales = true;
            }
            bool isValido = tieneLetrasMayusculas
                && tieneLetrasMinusculas
                && tieneNumeros
                && tieneCaracteresEspeciales;
            return isValido;
        }
        public static string encriptar(TextBox cajadeTexto)
        {
            SHA1CryptoServiceProvider elProveedor = new SHA1CryptoServiceProvider();
            byte[] vectoBytes = System.Text.Encoding.UTF8.GetBytes(cajadeTexto.Text);
            byte[] inArray = elProveedor.ComputeHash(vectoBytes);
            elProveedor.Clear();
            return Convert.ToBase64String(inArray);
        }
    }
}
