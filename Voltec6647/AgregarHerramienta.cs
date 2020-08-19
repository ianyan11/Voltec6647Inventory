using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Voltec6647
{
    public partial class AgregarHerramienta : Form
    {
        public AgregarHerramienta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarHerramienta modificarHerramienta = new ModificarHerramienta();
            modificarHerramienta.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servidor.servidor("INSERT INTO Herramientas (Herramienta, CantidadStock, Página, Descripción, Área, Cajón) VALUES ('" + textBox1.Text + "', '" + numericUpDown1.Text + "', '" + textBox2.Text + "', '" + richTextBox1.Text + "', '" + domainUpDown1.Text + "', '" + textBox3.Text + "')");
            ModificarHerramienta modificarHerramienta = new ModificarHerramienta();
            modificarHerramienta.Show();
            this.Close();
        }
    }
}
