using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    abstract class NumeroComplejo
    {
        public abstract Polar GetPolar();
        public abstract Binomial GetBinomial();
        public abstract double GetModulo();
        public abstract double GetArgumento();
        public abstract double GetParteReal();
        public abstract double GetParteImaginaria();
        public abstract NumeroComplejo Sumar(NumeroComplejo numeroComplejo);
        public abstract NumeroComplejo Restar(NumeroComplejo numeroComplejo);
        public abstract NumeroComplejo Multiplicar(NumeroComplejo numeroComplejo);
        public abstract NumeroComplejo Dividir(NumeroComplejo numeroComplejo);
        public abstract NumeroComplejo Conjugado();
        public abstract NumeroComplejo MultiplicarPorTuPropioConjugado();
        public static NumeroComplejo Parsear(string ingreso)
        {
            ingreso = ingreso.Trim();
            if (ingreso.Length == 0 )
                throw new ParseException("", ParseException.TipoDeError.TEXTO_VACIO);
            if (ingreso[0] == '(')
            {
                return Binomial.ParsearBinomial(ingreso);
            } else if (ingreso[0] == '[')
            {
                return Polar.ParsearPolar(ingreso);
            } else
            {
                throw new ParseException("Formato incorrecto", ParseException.TipoDeError.ERROR_DE_PARSEO);
            }
        }
        public static NumeroComplejo Zero()
        {
            return new Binomial(0,0);
        }

        public abstract List<NumeroComplejo> ObtenerRaicesNaturales(int n);

        public abstract NumeroComplejo Potencia(int n);
        public abstract string GetNotacionFasorial();
    }
}
