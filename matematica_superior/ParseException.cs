using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica_superior
{
    class ParseException : Exception
    {
        private string message;
        private TipoDeError tipo;
        public ParseException(string message, TipoDeError tipo)
        {
            this.message = message;
            this.tipo = tipo;
        }
        public enum TipoDeError { ERROR_DE_PARSEO, ERROR_DE_PARSEO_BINOMIAL, ERROR_DE_PARSEO_POLAR, MAS_DE_UNA_COMA, TEXTO_VACIO };

        public string GetMessage()
        {
            switch (tipo)
            {
                case TipoDeError.ERROR_DE_PARSEO:
                    return "Los formatos aceptados son: (a,b) o [a,b] para las formas binomial y polar respectivamente";
                case TipoDeError.ERROR_DE_PARSEO_BINOMIAL:
                    return "La forma binomial es (a,b) donde a es la parte real, y b es la parte imaginaria";
                case TipoDeError.ERROR_DE_PARSEO_POLAR:
                    return "La forma polar es [a,b] donde a es el modulo, y b es el argumento";
                case TipoDeError.TEXTO_VACIO:
                    return "";
                case TipoDeError.MAS_DE_UNA_COMA:
                    return "El separador decimal es un punto \".\"";
                default:
                    return "Error desconocido";
            }
        }
    }
}

