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
    public partial class ModUsuario : Form
    {
        public ModUsuario()
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
            Servidor.servidor("SELECT * FROM USUARIO WHERE Nombre='" + Class1.User + "'");
            DataRow row = Servidor.Dt.Rows[0];
            if ("True".Equals(Convert.ToString(row["Admin"])))
            {
                domainUpDown1.SelectedIndex = 0;

            }
            else
            {
                domainUpDown1.SelectedIndex = 1;
            }

            textBox1.AppendText(Class1.User);
            textBox2.AppendText(Convert.ToString(row["Matricula"]));
            textBox3.AppendText(Convert.ToString(row["Correo"]));
            textBox4.AppendText(Convert.ToString(row["Teléfono"]));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Servidor.servidor("UPDATE USUARIO SET Nombre='" + textBox1.Text +  "', Matricula='" + textBox2.Text + "', Correo='" + textBox3.Text + "', Teléfono='" + textBox4.Text + "', Admin='" + domainUpDown1.Text + "' WHERE Nombre='" + Class1.User + "'");
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Close();
        }
    }
}
