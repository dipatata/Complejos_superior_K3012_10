using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematica_superior.Modelo
{
    class CommonHelper
    {
        public static readonly double PI = (float)Math.PI;
        public static readonly double DOS_PI = (float)Math.PI * 2;
        public static readonly double MEDIO_PI = (float)(Math.PI / 2);
        public static readonly double CUARTO_PI = (float)(Math.PI / 4);
        public static readonly double TRES_CUARTOS_PI = (float)(Math.PI * (3 / 4));
        private static Regex NUMEROS_NATURALES_REGEX = new Regex("^([123456789])(\\d)*$");
        private static Regex NUMEROS_DECIMAL_SIN_CERO_REGEX = new Regex("((^(\\-)?\\d+\\.\\d{1,5}$)|(^(\\-)?([123456789])+\\d*$))");
        private static Regex NUMEROS_DECIMAL_CON_CERO_REGEX = new Regex("((^(\\-)?\\d+\\.\\d{1,5}$)|(^(\\-)?([1234567890])+\\d*$))");
        public static double ClampAngulo(double angulo)
        {
            if (angulo < 0)
            {
                return ClampAngulo(angulo + DOS_PI);
            }
            return (float)angulo % DOS_PI;
        }
        public static int Cuadrante(double parteReal, double parteImaginaria)
        {
            if (parteReal >= 0)
            {
                if (parteImaginaria >= 0)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
            else
            {
                if (parteImaginaria >= 0)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
        public static int Mcd(int num1, int num2)
        {
            int mcd = 0;
            int a = Math.Max(num1, num2);
            int b = Math.Min(num1, num2);
            if (b==0)
            {
                return a;
            }
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);
            return mcd;
        }

        public static void LimitarTextFieldNumerosNaturales(TextBox text)
        {
            if (!NUMEROS_NATURALES_REGEX.IsMatch(text.Text) && text.Text.Length > 0)
            {
                text.Text = text.Text.Substring(0, text.Text.Length - 1);
            }
        }
        public static bool NumeroDecimalRegex(string text)
        {
            return NUMEROS_DECIMAL_SIN_CERO_REGEX.IsMatch(text);
        }
        public static bool NumeroDecimalRegexConCero(string text)
        {
            return NUMEROS_DECIMAL_CON_CERO_REGEX.IsMatch(text);
        }
        public static string EliminarEspacios(string cadena)
        {
            return cadena.Replace(" ", "");
        }
    }
 }
