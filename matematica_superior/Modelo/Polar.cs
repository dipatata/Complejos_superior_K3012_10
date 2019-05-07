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
        private float modulo;
        private float argumento;
        private static Regex regexPolar = new Regex("^\\[\\d+,\\d+\\]$");
        public Polar(float modulo, float argumento)
        {
            this.modulo = modulo;
            this.argumento = CommonHelper.ClampAngulo(argumento);
        }

        public static Polar ParsearPolar(string polar)
        {
            if (!regexPolar.IsMatch(polar)) throw new ParseException("", ParseException.TipoDeError.ERROR_DE_PARSEO_POLAR);
            int posicionComa = polar.IndexOf(',');
            float modulo = float.Parse(polar.Substring(1, posicionComa - 1));
            float argumento = float.Parse(polar.Substring(posicionComa + 1, polar.Length - 2 - posicionComa));
            return new Polar(modulo, argumento);
        }

        public override Binomial GetBinomial()
        {
            return new Binomial(GetParteReal(), GetParteImaginaria());
        }

        public override float GetModulo()
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

        public override float GetArgumento()
        {
            return argumento;
        }

        public override float GetParteReal()
        {
            return modulo * (float)Math.Cos(argumento);
        }

        public override float GetParteImaginaria()
        {
            return modulo * (float)Math.Sin(argumento);
        }
        public override string ToString()
        {
            return "[" + modulo + "," + argumento + "]";
        }
    }
}
