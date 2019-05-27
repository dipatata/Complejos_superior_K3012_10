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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void formaPolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Operaciones(true, false).Show();
        }

        private void operacionesAvanzadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Operaciones(false, false).Show();
        }

        private void raicesPrimitivasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Operaciones(false, true).Show();
        }

        private void fasoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Fasores().Show();
        }
    }
}
