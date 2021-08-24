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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha aceptado los terminos de este formulario", "Mensaje con botòn Aceptar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha aceptado o cancelado los terminos de este formulario", "Mensaje con botòn Aceptar/Cancelar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha aceptado o rechazado los terminos de este formulario", "Mensaje con botòn Si/No");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha presionado el botòn de exclamaciòn", "Mensaje con botòn Exclamaciòn ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha presionado el botòn de interrogaciòn", "Mensaje con botòn Interrogaciòn");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha presionado el botòn de Error", "Mensaje con botòn de Error");
        }
    }
}
