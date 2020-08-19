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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Byte id = 0;
            if (domainUpDown1.Text.Equals("True"))
            {
                id = 1;
            }
            Servidor.servidor("INSERT INTO USUARIO (Nombre, Matricula, Correo, Teléfono, Contraseña, Admin) VALUES ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + id + "')");
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Close();
        }
    }
}
