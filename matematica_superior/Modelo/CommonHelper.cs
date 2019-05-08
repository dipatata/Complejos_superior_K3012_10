using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    class CommonHelper
    {
        public static readonly double PI = (float) Math.PI;
        public static readonly double DOS_PI = (float) Math.PI * 2;
        public static readonly double MEDIO_PI = (float) (Math.PI / 2);
        public static readonly double CUARTO_PI = (float)(Math.PI / 4);
        public static readonly double TRES_CUARTOS_PI = (float)(Math.PI * (3/4));

        public static double ClampAngulo(double angulo)
        {
            if (angulo < 0)
            {
                return ClampAngulo(angulo + DOS_PI);
            }
            return (float) angulo % DOS_PI;
        }
        public static int Cuadrante(double parteReal, double parteImaginaria)
        {
            if (parteReal>=0)
            {
                if (parteImaginaria >= 0)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            } else
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
    }
}
