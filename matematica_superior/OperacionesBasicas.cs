using matematica_superior.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;

namespace matematica_superior
{
    public partial class OperacionesBasicas : Form
    {
        private NumeroComplejo Z1;
        private NumeroComplejo Z2;
        private NumeroComplejo Z3;
        private bool resultadoEnFormaPolar = true;
        public OperacionesBasicas()
        {
            InitializeComponent();
            errorZ1Label.Text = "";
            errorZ2Label.Text = "";
        }

        private void n1Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z1 = NumeroComplejo.Parsear(this.n1Text.Text);
                errorZ1Label.Text = "";

            } catch(ParseException p)
            {
                errorZ1Label.Text = p.GetMessage();
                Z1 = NumeroComplejo.Zero();
            }
        }

        private void n2Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z2 = NumeroComplejo.Parsear(this.n2Text.Text);
                errorZ2Label.Text = "";
            }
            catch (ParseException p)
            {
                errorZ2Label.Text = p.GetMessage();
                Z2 = NumeroComplejo.Zero();
            }
        }

        private void botonSuma_Click(object sender, EventArgs e)
        {
            if (abortarSiZ1Z2SonNulos()) return;
            Z3 = Z1.Sumar(Z2);
            mostrarResultado();
        }

        private void polarOption_CheckedChanged(object sender, EventArgs e)
        {
            resultadoEnFormaPolar = true;
            mostrarResultado();
        }

        private void binomialButton_CheckedChanged(object sender, EventArgs e)
        {
            resultadoEnFormaPolar = false;
            mostrarResultado();
        }

        private void mostrarResultado()
        {
            if (Z3 != null)
            {
                if (resultadoEnFormaPolar)
                {
                    resultadoLabel.Text = Z3.GetPolar().ToString();
                }
                else
                {
                    resultadoLabel.Text = Z3.GetBinomial().ToString();
                }
            }
        }

        private void botonResta_Click(object sender, EventArgs e)
        {
            if (abortarSiZ1Z2SonNulos()) return;
            Z3 = Z1.Restar(Z2);
            mostrarResultado();
        }

        private void botonMult_Click(object sender, EventArgs e)
        {
            if (abortarSiZ1Z2SonNulos()) return;
            Z3 = Z1.Multiplicar(Z2);
            mostrarResultado();
        }

        private void botonDiv_Click(object sender, EventArgs e)
        {
            if (abortarSiZ1Z2SonNulos()) return;
            Z3 = Z1.Dividir(Z2);
            mostrarResultado();
        }

        private bool abortarSiZ1Z2SonNulos()
        {
            return (Z1 == null || Z2 == null);
        }
    }
}
