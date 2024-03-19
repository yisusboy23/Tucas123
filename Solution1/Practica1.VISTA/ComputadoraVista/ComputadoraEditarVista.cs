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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica1.VISTA.ComputadoraVista
{
    public partial class ComputadoraEditarVista : Form
    {
        int idx = 0;
        Computadora c = new Computadora();
        ComputadoraBSS bss = new ComputadoraBSS();
        public ComputadoraEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void ComputadoraEditarVista_Load(object sender, EventArgs e)
        {
            c = bss.ObtenerComputadoraIdBss(idx);
            textBox1.Text = c.Nombre;
            textBox2.Text = c.Descripcion;
            textBox3.Text = c.Precio.ToString();
            dateTimePicker1.Value = c.FechaFabricacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Nombre = textBox1.Text;
            c.Descripcion = textBox2.Text;
            c.Precio = Convert.ToDecimal(textBox3.Text);
            c.FechaFabricacion = dateTimePicker1.Value;

            bss.EditarComputadoraBss(c);
            MessageBox.Show("Datos Actualizados");
        }
    }
}
