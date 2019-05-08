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
        //Variables iniciales de los vectores
        private int initX = 310;
        private int initY = 210;
        private int ancho = 220;
        private int centroX;
        private int centroY;
        private int defaultEscala = 10;
        private int escala = 10;
        private int dottedLineSegmentLength = 3;
        System.Drawing.Pen lapizRojo = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
        System.Drawing.Pen lapizNegro = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
        System.Drawing.Pen lapizVerde = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 192, 0), 1);
        System.Drawing.Pen lapizAzul = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 0, 192), 1);
        System.Drawing.Pen lapizPurpura = new System.Drawing.Pen(System.Drawing.Color.FromArgb(192, 0, 192), 1);
        private bool graficarZ1 = false;
        private bool graficarZ2 = false;
        private bool graficarZ3 = false;
        private bool dibujarGuias = true;
        private bool dibujarCortes = true;

        public OperacionesBasicas()
        {
            InitializeComponent();
            errorZ1Label.Text = "";
            errorZ2Label.Text = "";
            centroX = initX + ancho / 2;
            centroY = initY + ancho / 2;
        }

        private void n1Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z1 = NumeroComplejo.Parsear(this.n1Text.Text);
                graficarZ1 = true;
                errorZ1Label.Text = "";
                escala = defaultEscala;
                this.Refresh();

            } catch(ParseException p)
            {
                errorZ1Label.Text = p.GetMessage();
                Z1 = NumeroComplejo.Zero();
                graficarZ1 = false;
            }
        }

        private void n2Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z2 = NumeroComplejo.Parsear(this.n2Text.Text);
                graficarZ2 = true;
                errorZ2Label.Text = "";
                escala = defaultEscala;
                this.Refresh();
            }
            catch (ParseException p)
            {
                errorZ2Label.Text = p.GetMessage();
                Z2 = NumeroComplejo.Zero();
                graficarZ2 = false;
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
                escala = defaultEscala;
                if (resultadoEnFormaPolar)
                {
                    resultadoLabel.Text = Z3.GetPolar().ToString();
                }
                else
                {
                    resultadoLabel.Text = Z3.GetBinomial().ToString();
                }
                graficarZ3 = true;
                this.Refresh();
            } else
            {
                graficarZ3 = false;
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

        protected override void OnPaint(PaintEventArgs e)
        {
            actualizarEscala();
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;
 
            //Ejes y circunferencia
            g.DrawEllipse(lapizRojo, initX, initY, ancho, ancho);
            g.DrawLine(lapizNegro, initX, initY + ancho / 2, initX + ancho, initY + ancho / 2);
            g.DrawLine(lapizNegro, initX + ancho / 2, initY, initX + ancho / 2, initY + ancho);

            if (dibujarGuias)
            {
                DibujarGuias(g);
            }

            if (graficarZ1)
            {
                DibujarHorizontalDottedLine(g, Z1);
                DibujarVerticalDottedLine(g, Z1);
                g.DrawLine(lapizAzul, centroX, centroY, (float)(centroX + Z1.GetParteReal() * escala), (float)(centroY - Z1.GetParteImaginaria() * escala));
            }
            if (graficarZ2)
            {
                DibujarHorizontalDottedLine(g, Z2);
                DibujarVerticalDottedLine(g, Z2);
                g.DrawLine(lapizVerde, centroX, centroY, (float)(centroX + Z2.GetParteReal() * escala), (float)(centroY - Z2.GetParteImaginaria() * escala));
            }
            if (graficarZ3)
            {
                DibujarHorizontalDottedLine(g, Z3);
                DibujarVerticalDottedLine(g, Z3);
                g.DrawLine(lapizPurpura, centroX, centroY, (float)(centroX + Z3.GetParteReal() * escala), (float)(centroY - Z3.GetParteImaginaria() * escala));
            }
        }

        private void actualizarEscala()
        {
            if (graficarZ1 && !(Z1.GetModulo() * escala < ancho / 2))
            {
                escala--;
                actualizarEscala();
            }
            if (graficarZ2 &&  !(Z2.GetModulo() * escala < ancho / 2))
            {
                escala--;
                actualizarEscala();
            }
            if (graficarZ3 &&  !(Z3.GetModulo() * escala < ancho / 2))
            {
                escala--;
                actualizarEscala();
            }
            if (escala < 1) escala = 1;
            this.escalaLabel.Text = escala.ToString();
        }

        private void DibujarGuias(Graphics g)
        {
            for (int n=-(ancho / 2) / escala; n<(ancho/2) / escala; n++)
            {
                g.DrawLine(lapizNegro, centroX - 2, centroY - n * escala, centroX + 2, centroY - n * escala);
                g.DrawLine(lapizNegro, centroX + n * escala, centroY - 2, centroX + n * escala, centroY + 2);
            }
        }

        private void dibujarGuiasBox_CheckedChanged(object sender, EventArgs e)
        {
            dibujarGuias = dibujarGuiasBox.Checked;
            this.Refresh();
        }

        private void DibujarHorizontalDottedLine(Graphics g, NumeroComplejo Z)
        {
            if (!dibujarCortes) return;
            double altura = centroY - Z.GetParteImaginaria() * escala;
            double x1 = centroX;
            double x2 = centroX + Z.GetParteReal() * escala;
            double miniLines = Math.Abs((x2 - x1) / dottedLineSegmentLength);
            int signo = x2 > x1 ? 1 : -1;
            for (int n = 0;n<miniLines;n+=2)
            {
                g.DrawLine(lapizNegro,
                    (float)x1 + n * dottedLineSegmentLength * signo,
                    (float)altura,
                    (float)x1 + (n + 1) * dottedLineSegmentLength * signo,
                    (float)altura);
            }
        }

        private void DibujarVerticalDottedLine(Graphics g, NumeroComplejo Z)
        {
            if (!dibujarCortes) return;
            double anchura = centroX + Z.GetParteReal() * escala;
            double y1 = centroY;
            double y2 = centroY - Z.GetParteImaginaria() * escala;
            double miniLines = Math.Abs((y2 - y1) / dottedLineSegmentLength);
            int signo = y2 > y1 ? 1 : -1;
            for (int n = 0; n < miniLines; n += 2)
            {
                g.DrawLine(lapizNegro,
                    (float)anchura,
                    (float)y1 + n * dottedLineSegmentLength * signo,
                    (float)anchura,
                    (float)y1 + (n + 1) * dottedLineSegmentLength * signo);
            }
        }

        private void cortesBox_CheckedChanged(object sender, EventArgs e)
        {
            dibujarCortes = cortesBox.Checked;
            this.Refresh();
        }
    }
}
