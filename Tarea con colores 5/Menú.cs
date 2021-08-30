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
    public partial class Menú : Form
    {
        public Menú()
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
            MessageBox.Show("Muchas gracias por visitarnos, lo esperamos pronto", "EMPRESA ELECTRIC",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk );
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
           
        }

        private void karlaBeatrizToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                Form AYUDA = new Form6();
                AYUDA.Show();
            }
        }

        private void enQuePodemosAyudarteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ayudas = new Form7();
           ayudas.Show();
        }
    }
    }

