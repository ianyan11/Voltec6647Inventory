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
    public partial class ModHerramienta : Form
    {
        public ModHerramienta()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ModHerramienta_Load(object sender, EventArgs e)
        {
            Servidor.servidor("SELECT * FROM Herramientas WHERE Herramienta='" + Class1.Herramienta + "'");
            DataRow row = Servidor.Dt.Rows[0];

            if ("Eléctrica".Equals(Convert.ToString(row["Área"])))
            {
                domainUpDown1.SelectedIndex = 0;

            } else if ("Mecánica".Equals(Convert.ToString(row["Área"])))
            {
                domainUpDown1.SelectedIndex = 1;
            }
            else
            {
                domainUpDown1.SelectedIndex = 2;
            }
            textBox1.AppendText(Class1.Herramienta);
            richTextBox1.AppendText(Convert.ToString(row["Descripción"]));
            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = Convert.ToInt32(row["CantidadStock"]);
            textBox2.AppendText(Convert.ToString(row["página"]));
            textBox3.AppendText(Convert.ToString(row["cajón"]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarHerramienta modificarHerramienta = new ModificarHerramienta();
            modificarHerramienta.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servidor.servidor("UPDATE Herramientas SET Herramienta='" + textBox1.Text + "', CantidadStock='" + numericUpDown1.Text + "', Página='" + textBox2.Text + "', Descripción='" + richTextBox1.Text + "', Área='" + domainUpDown1.Text + "', Cajón='" + textBox3.Text + "' WHERE Herramienta='" + Class1.Herramienta + "'");
            ModificarHerramienta modificarHerramienta = new ModificarHerramienta();
            modificarHerramienta.Show();
            this.Close();
        }
    }
}
