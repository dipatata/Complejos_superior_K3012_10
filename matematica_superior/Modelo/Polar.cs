using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    class Polar : NumeroComplejo
    {
        private double modulo;
        private double argumento;
        private static Regex regexPolar = new Regex("^\\[\\d+,(\\d+|pi|pi\\/2|pi\\/4)\\]$");
        public Polar(double modulo, double argumento)
        {
            this.modulo = modulo;
            this.argumento = CommonHelper.ClampAngulo(argumento);
        }

        public static Polar ParsearPolar(string polar)
        {
            if (!regexPolar.IsMatch(polar)) throw new ParseException("", ParseException.TipoDeError.ERROR_DE_PARSEO_POLAR);
            int posicionComa = polar.IndexOf(',');
            double modulo = double.Parse(polar.Substring(1, posicionComa - 1));
            string argumentoStr = polar.Substring(posicionComa + 1, polar.Length - 2 - posicionComa);
            double argumento;
            if (argumentoStr.Equals("pi"))
            {
                argumento = Math.PI;
            }
            else if (argumentoStr.Equals("pi/2"))
            {
                argumento = Math.PI / 2;
            }
            else if (argumentoStr.Equals("pi/4"))
            {
                argumento = Math.PI / 4;
            }
            else
            {
                argumento = double.Parse(argumentoStr);
            }
            return new Polar(modulo, argumento);
        }

        public override Binomial GetBinomial()
        {
            return new Binomial(GetParteReal(), GetParteImaginaria());
        }

        public override double GetModulo()
        {
            return modulo;
        }

        public override Polar GetPolar()
        {
            return this;
        }

        public override NumeroComplejo Multiplicar(NumeroComplejo numeroComplejo)
        {
            Polar polar = numeroComplejo.GetPolar();
            return new Polar(this.modulo * polar.modulo, this.argumento + polar.argumento);
        }

        public override NumeroComplejo Restar(NumeroComplejo numeroComplejo)
        {
            return this.GetBinomial().Restar(numeroComplejo);
        }

        public override NumeroComplejo Sumar(NumeroComplejo numeroComplejo)
        {
            return this.GetBinomial().Sumar(numeroComplejo);
        }
        public override NumeroComplejo Dividir(NumeroComplejo numeroComplejo)
        {
            Polar polar = numeroComplejo.GetPolar();
            return new Polar(this.modulo / polar.modulo, this.argumento - polar.argumento);
        }
        public override NumeroComplejo Conjugado()
        {
            return new Polar(this.modulo, CommonHelper.DOS_PI - this.argumento);
        }
        public override NumeroComplejo MultiplicarPorTuPropioConjugado()
        {
            return this.Multiplicar(this.Conjugado());
        }

        public override double GetArgumento()
        {
            return argumento;
        }

        public override double GetParteReal()
        {
            return modulo * Math.Cos(argumento);
        }

        public override double GetParteImaginaria()
        {
            return modulo * Math.Sin(argumento);
        }
        public override string ToString()
        {
            return "[" + Math.Round(modulo, 5) + " , " + Math.Round(argumento,5) + "]";
        }
    }
}
