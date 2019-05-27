using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematica_superior.Modelo
{
    class Sinusoidal
    {
        private double frecuencia;
        private double fase;
        private double amplitud;
        private bool coseno;

        public Sinusoidal(double frecuencia, double fase, double amplitud, bool coseno)
        {
            this.frecuencia = frecuencia;
            this.fase = fase;
            this.amplitud = amplitud;
            this.coseno = coseno;
        }
        public Sinusoidal(NumeroComplejo fasor, double frecuencia)
        {
            this.frecuencia = frecuencia;
            this.coseno = true;
            this.amplitud = fasor.GetModulo();
            this.fase = fasor.GetArgumento();
        }

        public bool PuedenSumarse(Sinusoidal s)
        {
            return (s.frecuencia == this.frecuencia);
        }

        public Sinusoidal Sumar(Sinusoidal s)
        {
            return new Sinusoidal(this.GetFasor().Sumar(s.GetFasor()), s.frecuencia);
        }

        public NumeroComplejo GetFasor()
        {
            if (coseno && amplitud < 0)
            {
                return new Polar(-amplitud, fase + CommonHelper.PI);
            } else if(!coseno && amplitud > 0)
            {
                return new Polar(amplitud, fase - CommonHelper.MEDIO_PI);
            } else if(!coseno && amplitud < 0)
            {
                return new Polar(-amplitud, fase + CommonHelper.MEDIO_PI);
            } else
            {
                return new Polar(amplitud, fase);
            }
        }
        
        public override string ToString()
        {
            if (coseno)
            {
                return Math.Round(amplitud, 5) + " cos (" + "2π" + Math.Round(frecuencia, 5) + "t + " + Math.Round(fase, 5) +")";
            } else
            {
                return Math.Round(amplitud, 5) + " sin (" + "2π" + Math.Round(frecuencia, 5) + "t + " + Math.Round(fase, 5) + ")";
            }
        }

        public string GetFuncionSeno()
        {
            return Math.Round(amplitud, 5) + " sin (" + "2π" + Math.Round(frecuencia, 5) + "t + " + Math.Round(fase + CommonHelper.MEDIO_PI, 5) + ")";
        }
    }
}
