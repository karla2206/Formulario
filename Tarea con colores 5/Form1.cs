using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_con_colores_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void computadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Computadoras = new Form2 ();
            Computadoras.Show();
        }

      

        private void laptopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form laptops = new Form3();
            laptops.Show();

        }

        private void celularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Celulares = new Form4();
            Celulares.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formularioDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioDeVentas = new Form5();
            formularioDeVentas.Show();
        }

        private void katterineYeferineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AYUDA= new Form6();
            AYUDA.Show();
        }

        private void karlaBeatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    }

