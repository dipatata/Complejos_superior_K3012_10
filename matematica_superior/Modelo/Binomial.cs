using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    class Binomial : NumeroComplejo
    {
        private static Regex regexBinomial = new Regex("^\\(\\d+,\\d+\\)$");
        private float parteReal;
        private float parteImaginaria;

        public Binomial(float a, float b)
        {
            this.parteReal = a;
            this.parteImaginaria = b;
        }

        public static Binomial ParsearBinomial(string binomial)
        {
            if (!regexBinomial.IsMatch(binomial)) throw new ParseException("", ParseException.TipoDeError.ERROR_DE_PARSEO_BINOMIAL);
            int posicionComa = binomial.IndexOf(',');
            float parteReal = float.Parse(binomial.Substring(1, posicionComa-1));
            string parteImaginariaString = binomial.Substring(posicionComa + 1, binomial.Length - 2 - posicionComa);
            float parteImaginaria = float.Parse(parteImaginariaString);
            return new Binomial(parteReal, parteImaginaria);
        }

        public override Binomial GetBinomial()
        {
            return this;
        }

        public override Polar GetPolar()
        {
            return new Polar(GetModulo(), GetArgumento());
        }

        public override float GetArgumento()
        {
            if (parteReal != 0)
            {
                return CommonHelper.ClampAngulo(
                    Math.Atan(parteImaginaria / parteReal)
                );
            } else
            {
                return (parteImaginaria >= 0) ? CommonHelper.CUARTO_PI : CommonHelper.TRES_CUARTOS_PI;
            }
        }

        public override float GetModulo()
        {
            return (float) 
            Math.Sqrt(
                Math.Pow(parteReal, 2) + Math.Pow(parteImaginaria, 2)
            );
        }

        public override NumeroComplejo Sumar(NumeroComplejo numeroComplejo)
        {
            return new Binomial(this.parteReal + numeroComplejo.GetBinomial().parteReal, 
                this.parteImaginaria + numeroComplejo.GetBinomial().parteImaginaria);
        }

        public override NumeroComplejo Restar(NumeroComplejo numeroComplejo)
        {
            return new Binomial(this.parteReal - numeroComplejo.GetBinomial().parteReal,
                this.parteImaginaria - numeroComplejo.GetBinomial().parteImaginaria);
        }

        public override NumeroComplejo Multiplicar(NumeroComplejo numeroComplejo)
        {
            Binomial binomial = numeroComplejo.GetBinomial();
            return new Binomial(this.parteReal * binomial.parteReal - this.parteImaginaria * binomial.parteImaginaria, 
                this.parteReal * binomial.parteImaginaria + this.parteImaginaria * binomial.parteReal);
        }

        public override NumeroComplejo Dividir(NumeroComplejo numeroComplejo)
        {
            Binomial binomial = this.Multiplicar(numeroComplejo.Conjugado()).GetBinomial();
            binomial.parteReal /= numeroComplejo.MultiplicarPorTuPropioConjugado().GetParteReal();
            binomial.parteImaginaria /= numeroComplejo.MultiplicarPorTuPropioConjugado().GetParteReal();
            return binomial;
        }

        public override NumeroComplejo Conjugado()
        {
            return new Binomial(this.parteReal, -this.parteImaginaria);
        }

        public override NumeroComplejo MultiplicarPorTuPropioConjugado()
        {
            return new Binomial((float)(Math.Pow(parteReal, 2) + Math.Pow(parteImaginaria, 2)), 0);
        }

        public override float GetParteReal()
        {
            return parteReal;
        }

        public override float GetParteImaginaria()
        {
            return parteImaginaria;
        }

        public override string ToString()
        {
            return "("+CommonHelper.ClampFloat(parteReal)+","+ CommonHelper.ClampFloat(parteImaginaria) +")";
        }
    }
}
