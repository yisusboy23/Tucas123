using Practica1.BSS;
using Practica1.MODELOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.VISTA.ComputadoraVista
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        ComputadoraBSS bss = new ComputadoraBSS();
        private void button1_Click(object sender, EventArgs e)
        {
            Computadora c = new Computadora();
            c.Nombre = textBox1.Text;
            c.Descripcion = textBox2.Text;
            c.Precio = Convert.ToInt32(textBox3.Text);
            c.FechaFabricacion = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(c);
            MessageBox.Show("Se guardo correctamente El Usuario");
        }
    }
}
