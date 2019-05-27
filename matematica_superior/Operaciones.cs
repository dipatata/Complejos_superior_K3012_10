using matematica_superior.Funcionalidades;
using matematica_superior.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;

namespace matematica_superior
{
    public partial class Operaciones : Form
    {
        private NumeroComplejo Z1;
        private NumeroComplejo Z2;
        private NumeroComplejo Z3;
        public bool graficarZ1;
        public bool graficarZ2;
        public bool graficarZ3;
        public bool graficarRadicacion;
        public bool graficarPotenciacion;
        private List<NumeroComplejo> raicesNaturales;
        private int numeroNatural;
        private bool resultadoEnFormaPolar = true;
        private bool numeroNaturalIngresado = false;
        private int defaultEscala = 10;

        private Graficas graficas;

        private bool basicas;
        private bool primitivas;
        private TipoOperacion ultimaOperacion;

        public Operaciones(bool flagBasicas, bool flagPrimitivas)
        {
            InitializeComponent();
            errorZ1Label.Text = "";
            errorZ2Label.Text = "";
            basicas = flagBasicas;
            primitivas = flagPrimitivas;
            graficas = new Graficas(defaultEscala);
            if (!basicas)
            {
                botonSuma.Visible = false;
                botonResta.Visible = false;
                botonDiv.Visible = false;
                botonMult.Visible = false;
                n2Label.Visible = false;
                n2LabelColor.Visible = false;
                n2Text.Visible = false;
                errorZ2Label.Visible = false;
                resultadoLabel.Visible = false;
                resultadoColor.Visible = false;
                raicesPrimitivasButton.Visible = false;
                listaPrimitivas.Visible = false;
                this.Text = "Operaciones Avanzadas";
            } else
            {
                ultimaOperacion = TipoOperacion.BASICAS;
                nLabel.Visible = false;
                nText.Visible = false;
                potenciaButton.Visible = false;
                radicacionButton.Visible = false;
                listaPrimitivas.Visible = false;
                listaRaices.Visible = false;
                raicesPrimitivasButton.Visible = false;
            }
            if (primitivas)
            {
                listaRaices.Visible = false;
                potenciaButton.Visible = false;
                radicacionButton.Visible = false;
                n1Label.Visible = false;
                n1LabelColor.Visible = false;
                n1Text.Visible = false;
                raicesPrimitivasButton.Visible = true;
                listaPrimitivas.Visible = true;
                listaPrimitivas.View = View.Details;
                listaPrimitivas.Columns.Add("Raices", 120);
                listaPrimitivas.Columns.Add("Primitiva", 70);
                groupBox3.Size = new Size(293, 230);
                this.Text = "Raices primitivas";
            }
        }

        private void n1Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Z1 = NumeroComplejo.Parsear(this.n1Text.Text);
                graficarZ1 = true;
                errorZ1Label.Text = "";
                graficas.escala = defaultEscala;
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
                graficas.escala = defaultEscala;
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
            graficas.escala = defaultEscala;
            if (ultimaOperacion.Equals(TipoOperacion.BASICAS))
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
                    graficarZ3 = true;
                    this.Refresh();
                } else
                {
                    graficarZ3 = false;
                }
            }
            else if(TipoOperacion.RADICACION.Equals(ultimaOperacion))
            {
                listaRaices.Items.Clear();
                raicesNaturales.ForEach((raiz) => {
                    if (resultadoEnFormaPolar)
                    {
                        listaRaices.Items.Add(raiz.GetPolar().ToString());
                    }
                    else
                    {
                        listaRaices.Items.Add(raiz.GetBinomial().ToString());
                    }
                });
                graficarRadicacion = true;
                graficarPotenciacion = false;
                graficarZ3 = false;
                this.Refresh();
            } else if(TipoOperacion.POTENCIA.Equals(ultimaOperacion))
            {
                listaRaices.Items.Clear();
                if (resultadoEnFormaPolar)
                {
                    listaRaices.Items.Add(Z3.GetPolar().ToString());

                } else
                {
                    listaRaices.Items.Add(Z3.GetBinomial().ToString());
                }
                graficarRadicacion = false;
                graficarPotenciacion = true;
                graficarZ3 = true;
                this.Refresh();
            }
            else if (TipoOperacion.PRIMITIVAS.Equals(ultimaOperacion))
            {
                listaPrimitivas.Items.Clear();
                int i = 0;
                raicesNaturales.ForEach((raiz) => {
                    string elemento = null;

                    if (resultadoEnFormaPolar)
                    {
                        elemento = raiz.GetPolar().ToString();
                    }
                    else
                    {
                        elemento = raiz.GetBinomial().ToString();
                    }
                    string esPrimitiva = null;
                    if (!(CommonHelper.Mcd(numeroNatural, i) == 1))
                    {
                        esPrimitiva = "No";
                    } else
                    {
                        esPrimitiva = "Si";
                    }
                    listaPrimitivas.Items.Add(
                        new System.Windows.Forms.ListViewItem(
                            new string[] {elemento, esPrimitiva }));
                    i++;
                });
                graficarRadicacion = true;
                graficarPotenciacion = false;
                graficarZ3 = false;
                graficarZ1 = true;
                this.Refresh();
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
            base.OnPaint(e);
            Graphics g;
            g = e.Graphics;
            actualizarEscala();

            graficas.DibujarEjes(g);
            graficas.DibujarGuias(g);

            if (graficarZ1)
            {
                graficas.DibujarLineasPunteadas(g, Z1);
                graficas.DibujarVector(g, Z1, Colores.AZUL);
            }
            if (graficarZ2)
            {
                graficas.DibujarLineasPunteadas(g, Z2);
                graficas.DibujarVector(g, Z2, Colores.VERDE);
            }
            if (graficarZ3)
            {
                graficas.DibujarLineasPunteadas(g, Z3);
                graficas.DibujarVector(g, Z3, Colores.PURPURA);
            }
            if (graficarRadicacion)
            {
                graficas.DibujarRaices(g, raicesNaturales, Colores.ROJO);
            }
        }

        private void actualizarEscala()
        {
            if (
                graficarZ1 && !(Z1.GetModulo() * graficas.escala < graficas.ancho / 2) ||
                graficarZ2 && !(Z2.GetModulo() * graficas.escala < graficas.ancho / 2) ||
                graficarZ3 && !(Z3.GetModulo() * graficas.escala < graficas.ancho / 2)
                )
            {
                graficas.escala--;
                actualizarEscala();
            }
            if (graficas.escala < 1) graficas.escala = 1;
            if (graficas.escala == 1)
            {
                menosEscalaLabel.Visible = false;
                dibujarGuiasBox.Checked = false;
                dibujarGuiasBox.Enabled = false;
            } else
            {
                dibujarGuiasBox.Enabled = true;
                menosEscalaLabel.Visible = true;
            }
            this.escalaLabel.Text = graficas.escala.ToString();
        }

        private void dibujarGuiasBox_CheckedChanged(object sender, EventArgs e)
        {
            graficas.dibujarGuias = dibujarGuiasBox.Checked;
            this.Refresh();
        }

        private void cortesBox_CheckedChanged(object sender, EventArgs e)
        {
            graficas.dibujarCortes = cortesBox.Checked;
            this.Refresh();
        }

        private void dibujarEjesCheck_CheckedChanged(object sender, EventArgs e)
        {
            graficas.dibujarEjes = dibujarEjesCheck.Checked;
            this.Refresh();
        }

        private void masEscalaLabel_Click(object sender, EventArgs e)
        {
            graficas.escala++;
            this.Refresh();
        }

        private void menosEscalaLabel_Click(object sender, EventArgs e)
        {
            if (graficas.escala > 1)
            {
                graficas.escala--;
                this.Refresh();
            }
        }

        private void nText_TextChanged(object sender, EventArgs e)
        {
            CommonHelper.LimitarTextFieldNumerosNaturales(nText);
            if (nText.Text.Length > 0)
            {
                numeroNatural = int.Parse(nText.Text);
                numeroNaturalIngresado = true;
            }
            else
            {
                numeroNaturalIngresado = false;
            }
        }

        private void radicacionButton_Click(object sender, EventArgs e)
        {
            if (numeroNaturalIngresado && graficarZ1)
            {
                raicesNaturales = Z1.ObtenerRaicesNaturales(numeroNatural);
                ultimaOperacion = TipoOperacion.RADICACION;
                mostrarResultado();
            }
        }
        enum TipoOperacion
        {
            BASICAS, RADICACION, POTENCIA, PRIMITIVAS
        };

        public enum Colores
        {
            PURPURA, AZUL, VERDE, CREMITA, ROJO, BORDO
        };

        private void potenciaButton_Click(object sender, EventArgs e)
        {
            if (numeroNaturalIngresado && graficarZ1)
            {
                Z3 = Z1.Potencia(numeroNatural);
                ultimaOperacion = TipoOperacion.POTENCIA;
                mostrarResultado();
            }
        }

        private void raicesPrimitivasButton_Click(object sender, EventArgs e)
        {
            if (numeroNaturalIngresado)
            {
                ultimaOperacion = TipoOperacion.PRIMITIVAS;
                Z1 = new Binomial(1, 0);
                raicesNaturales = Z1.ObtenerRaicesNaturales(numeroNatural);
                mostrarResultado();
            }
        }

        private void escalaLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
