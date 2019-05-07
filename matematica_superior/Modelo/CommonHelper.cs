using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    class CommonHelper
    {
        public static readonly float PI = (float) Math.PI;
        public static readonly float DOS_PI = (float) Math.PI * 2;
        public static readonly float MEDIO_PI = (float) (Math.PI / 2);
        public static readonly float CUARTO_PI = (float)(Math.PI / 4);
        public static readonly float TRES_CUARTOS_PI = (float)(Math.PI * (3/4));
        public static float ClampAngulo(float angulo)
        {
            if (angulo<0)
            {
                return ClampAngulo(angulo + DOS_PI);
            }
            return angulo % DOS_PI;
        }

        public static float ClampAngulo(double angulo)
        {
            if (angulo < 0)
            {
                return ClampAngulo(angulo + DOS_PI);
            }
            return (float) angulo % DOS_PI;
        }
    }
}
