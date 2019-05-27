using matematica_superior.Funcionalidades;
using matematica_superior.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematica_superior
{
    public partial class Fasores : Form
    {
        private Graficas graficas;
        private bool amplitudIngresada_a = false;
        private bool frecuenciaIngresada_a = false;
        private bool faseIngresada_a = false;
        private bool amplitudIngresada_b = false;
        private bool frecuenciaIngresada_b = false;
        private bool faseIngresada_b = false;
        private bool esCoseno_a = true;
        private bool esCoseno_b = true;
        private bool esCoseno_suma = true;
        private Sinusoidal sinusoidal_a;
        private Sinusoidal sinusoidal_b;
        private Sinusoidal sinusoidal_suma;

        private bool graficar_a = false;
        private bool graficar_b = false;
        private bool graficar_suma = false;

        private bool habilitado_a = false;
        private bool habilitado_b = false;
        private bool habilitado_suma = false;

        public Fasores()
        {
            InitializeComponent();
            graficas = new Graficas(20);
            fasorLabel_a.Text = "";
            fasorLabel_b.Text = "";
            labelFuncion_a.Text = "";
            labelFunction_b.Text = "";
            labelFuncion_suma.Text = "";
            fasorLabel_suma.Text = "";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;
            escalaLabel.Text = (graficas.escala).ToString();
            graficas.DibujarEjesSinusoidal(g);
            if (graficar_a && habilitado_a)
            {
                graficas.DibujarSinusoidal(g, sinusoidal_a, Operaciones.Colores.BORDO);
            }
            if (graficar_b && habilitado_b)
            {
                graficas.DibujarSinusoidal(g, sinusoidal_b, Operaciones.Colores.AZUL);
            }
            if (graficar_suma && graficar_b && graficar_a && habilitado_suma)
            {
                graficas.DibujarSinusoidal(g, sinusoidal_suma, Operaciones.Colores.PURPURA);
            }
        }

        private void amplitudText_a_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegex(amplitudText_a.Text))
            {
                amplitudIngresada_a = true;
                amplitudLabel_a.ForeColor = Color.Black;
                ArmarSinusoidal_a();
            } else
            {
                amplitudIngresada_a = false;
                graficar_a = false;
                amplitudLabel_a.ForeColor = Color.Red;
            }
        }

        private void faseText_a_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegexConCero(faseText_a.Text))
            {
                faseIngresada_a = true;
                faseLabel_a.ForeColor = Color.Black;
                ArmarSinusoidal_a();
            }
            else
            {
                faseIngresada_a = false;
                graficar_a = false;
                faseLabel_a.ForeColor = Color.Red;
            }
        }

        private void frecuenciaText_a_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegex(frecuenciaText_a.Text))
            {
                frecuenciaIngresada_a = true;
                frecuenciaLabel_a.ForeColor = Color.Black;
                ArmarSinusoidal_a();
            }
            else
            {
                frecuenciaIngresada_a = false;
                graficar_a = false;
                frecuenciaLabel_a.ForeColor = Color.Red;
            }
        }

        private void amplitudText_b_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegex(amplitudText_b.Text))
            {
                amplitudIngresada_b = true;
                amplitudLabel_b.ForeColor = Color.Black;
                ArmarSinusoidal_b();
            }
            else
            {
                amplitudIngresada_b = false;
                graficar_b = false;
                amplitudLabel_b.ForeColor = Color.Red;
            }
        }

        private void faseText_b_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegex(faseText_b.Text))
            {
                faseIngresada_b = true;
                faseLabel_b.ForeColor = Color.Black;
                ArmarSinusoidal_b();
            }
            else
            {
                faseIngresada_b = false;
                graficar_b = false;
                faseLabel_b.ForeColor = Color.Red;
            }
        }

        private void frecuenciaText_b_TextChanged(object sender, EventArgs e)
        {
            if (CommonHelper.NumeroDecimalRegex(frecuenciaText_b.Text))
            {
                frecuenciaIngresada_b = true;
                frecuenciaLabel_b.ForeColor = Color.Black;
                ArmarSinusoidal_b();
            }
            else
            {
                frecuenciaIngresada_b = false;
                graficar_b = false;
                frecuenciaLabel_b.ForeColor = Color.Red;
            }
        }

        private void ArmarSinusoidal_a()
        {
            if (frecuenciaIngresada_a && faseIngresada_a && amplitudIngresada_a)
            {
                sinusoidal_a = new Sinusoidal(
                    float.Parse(frecuenciaText_a.Text),
                    float.Parse(faseText_a.Text),
                    float.Parse(amplitudText_a.Text),
                    esCoseno_a
                );
                mostrarFuncion_a();
            }
        }
        private void ArmarSinusoidal_b()
        {
            if (frecuenciaIngresada_b && faseIngresada_b && amplitudIngresada_b)
            {
                sinusoidal_b = new Sinusoidal(
                    float.Parse(frecuenciaText_b.Text),
                    float.Parse(faseText_b.Text),
                    float.Parse(amplitudText_b.Text),
                    esCoseno_b
                );
                mostrarFuncion_b();
            }
        }

        private void cosenoOption_a_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_a = cosenoOption_a.Checked;
            ArmarSinusoidal_a();
        }

        private void senoOption_a_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_a = !senoOption_a.Checked;
            ArmarSinusoidal_a();
        }

        private void cosenoOption_b_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_b = cosenoOption_b.Checked;
            ArmarSinusoidal_b();
        }

        private void senoOption_b_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_b = !senoOption_b.Checked;
            ArmarSinusoidal_b();
        }

        private void mostrarFuncion_a()
        {
            if (sinusoidal_a == null) return;
            labelFuncion_a.Text = sinusoidal_a.ToString();
            fasorLabel_a.Text = sinusoidal_a.GetFasor().GetNotacionFasorial();
            graficar_a = true;
            Refresh();
        }
        private void mostrarFuncion_b()
        {
            if (sinusoidal_b == null) return;
            labelFunction_b.Text = sinusoidal_b.ToString();
            fasorLabel_b.Text = sinusoidal_b.GetFasor().GetNotacionFasorial();
            graficar_b = true;
            Refresh();
        }
        private void mostrarFuncion_suma()
        {
            if (sinusoidal_suma == null) return;
            if (esCoseno_suma)
            {
                labelFuncion_suma.Text = sinusoidal_suma.ToString();
            } else
            {
                labelFuncion_suma.Text = sinusoidal_suma.GetFuncionSeno();
            }
            graficar_suma = true;
            fasorLabel_suma.Text = sinusoidal_suma.GetFasor().GetNotacionFasorial();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (amplitudIngresada_a && frecuenciaIngresada_a && faseIngresada_a && 
                amplitudIngresada_b && frecuenciaIngresada_b && faseIngresada_b)
            {
                if (sinusoidal_a.PuedenSumarse(sinusoidal_b))
                {
                    errorLabel.Visible = false;
                    sinusoidal_suma = sinusoidal_a.Sumar(sinusoidal_b);
                    mostrarFuncion_suma();
                } else
                {
                    errorLabel.Visible = true;
                }
            }
        }

        private void resultadoCosenoOption_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_suma = resultadoCosenoOption.Checked;
            mostrarFuncion_suma();
        }

        private void resultadoSenoOption_CheckedChanged(object sender, EventArgs e)
        {
            esCoseno_suma = !resultadoSenoOption.Checked;
            mostrarFuncion_suma();
        }

        private void masEscalaLabel_Click(object sender, EventArgs e)
        {
            graficas.escala++;
            Refresh();
        }

        private void menosEscalaLabel_Click(object sender, EventArgs e)
        {
            graficas.escala--;
            Refresh();
        }

        private void check_a_CheckedChanged(object sender, EventArgs e)
        {
            habilitado_a = check_a.Checked;
            Refresh();
        }

        private void check_b_CheckedChanged(object sender, EventArgs e)
        {
            habilitado_b = check_b.Checked;
            Refresh();
        }

        private void check_suma_CheckedChanged(object sender, EventArgs e)
        {
            habilitado_suma = check_suma.Checked;
            Refresh();
        }
    }
}
