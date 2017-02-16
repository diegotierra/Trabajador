using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajador
{
    public partial class Form1 : Form
    {
        private Trabajador nuevoTrabajador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = (textBox1.Text);
            string apellido = (textBox2.Text);
            int edad = ((int)numericUpDown1.Value);

                nuevoTrabajador = new Trabajador();
                nuevoTrabajador.Nombre = nombre;
                nuevoTrabajador.Apellido = apellido;
                nuevoTrabajador.Edad = edad;

                MessageBox.Show("Trabajador creado.");
            
         }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nuevoTrabajador != null)
            {
                MessageBox.Show("Le quedan " +
                    nuevoTrabajador.CalculoAnyosJubilacion() + " años para jubilarse.");
            }
        }
    }
}
