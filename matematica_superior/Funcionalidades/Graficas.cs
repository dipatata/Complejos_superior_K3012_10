using matematica_superior.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static matematica_superior.Operaciones;

namespace matematica_superior.Funcionalidades
{
    class Graficas
    {

        private readonly int initX = 350;
        private readonly int initY = 240;
        public readonly int ancho = 220;
        private readonly int dottedLineSegmentLength = 3;

        private float centroX;
        private float centroY;
        public int escala;
        System.Drawing.Pen lapizRojo = new System.Drawing.Pen(System.Drawing.Color.Red, 2);
        System.Drawing.Pen lapizNegro = new System.Drawing.Pen(System.Drawing.Color.Black, 1);
        System.Drawing.Pen lapizVerde = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 192, 0), 1);
        System.Drawing.Pen lapizAzul = new System.Drawing.Pen(System.Drawing.Color.FromArgb(0, 0, 192), 1);
        System.Drawing.Pen lapizPurpura = new System.Drawing.Pen(System.Drawing.Color.FromArgb(192, 0, 192), 1);
        System.Drawing.Pen lapizCremita = new System.Drawing.Pen(System.Drawing.Color.FromArgb(255, 192, 128), 1);


        public bool dibujarCortes = true;
        public bool dibujarEjes = true;
        public bool dibujarGuias = true;

        public Graficas(int escalaDefault)
        {
            centroX = initX + ancho / 2;
            centroY = initY + ancho / 2;
            escala = escalaDefault;
        }

        private void DibujarHorizontalDottedLine(Graphics g, NumeroComplejo Z)
        {
            double altura = centroY - Z.GetParteImaginaria() * escala;
            double x1 = centroX;
            double x2 = centroX + Z.GetParteReal() * escala;
            double miniLines = Math.Abs((x2 - x1) / dottedLineSegmentLength);
            int signo = x2 > x1 ? 1 : -1;
            for (int n = 0; n < miniLines; n += 2)
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

        public void DibujarLineasPunteadas(Graphics g, NumeroComplejo z)
        {
            if (!dibujarCortes) return;
            DibujarVerticalDottedLine(g, z);
            DibujarHorizontalDottedLine(g, z);
        }
        public void DibujarEjes(Graphics g)
        {
            if (dibujarEjes)
            {
                g.DrawEllipse(lapizRojo, initX, initY, ancho, ancho);
                g.DrawLine(lapizNegro, initX, initY + ancho / 2, initX + ancho, initY + ancho / 2);
                g.DrawLine(lapizNegro, initX + ancho / 2, initY, initX + ancho / 2, initY + ancho);
            }
        }
        public void DibujarGuias(Graphics g)
        {
            if (dibujarGuias)
            {
                for (int n = -(ancho / 2) / escala; n < (ancho / 2) / escala; n++)
                {
                    g.DrawLine(lapizNegro, centroX - 2, centroY - n * escala, centroX + 2, centroY - n * escala);
                    g.DrawLine(lapizNegro, centroX + n * escala, centroY - 2, centroX + n * escala, centroY + 2);
                }
            }
        }
        
        public void DibujarVector(Graphics g, NumeroComplejo Z, Colores colorr)
        {
            Pen lapiz = obtenerLapiz(colorr);
            g.DrawLine(lapiz, centroX, centroY, UbicacionXComplejo(Z), UbicacionYComplejo(Z));
        }

        public void DibujarRaices(Graphics g, List<NumeroComplejo> lista, Colores colorr)
        {
            int i = 0;
            NumeroComplejo unirCon=null;
            lista.ForEach((w) => {
                if (i == 0)
                {
                    unirCon = w;
                }
                else
                {
                    UnirDosPuntos(g, unirCon, w, colorr);
                    unirCon = w;
                }
                i++;
            });
            UnirDosPuntos(g, unirCon, lista[0], colorr);
        }

        private float UbicacionXComplejo(NumeroComplejo Z)
        {
            return (float)(centroX + Z.GetParteReal() * escala);
        }

        private float UbicacionYComplejo(NumeroComplejo Z)
        {
            return (float)(centroY - Z.GetParteImaginaria() * escala);
        }

        private void UnirDosPuntos(Graphics g, NumeroComplejo z1, NumeroComplejo z2, Colores colorr)
        {
            g.DrawLine(obtenerLapiz(colorr), UbicacionXComplejo(z1), UbicacionYComplejo(z1), UbicacionXComplejo(z2), UbicacionYComplejo(z2));
        }
        private Pen obtenerLapiz(Colores colorr)
        {
            switch(colorr)
            {
                case Colores.AZUL:
                    return lapizAzul;
                case Colores.PURPURA:
                    return lapizPurpura;
                case Colores.VERDE:
                    return lapizVerde;
                case Colores.ROJO:
                    return lapizRojo;
                case Colores.CREMITA:
                    return lapizCremita;
                default:
                    return lapizNegro;
            }
        }
    }
}
