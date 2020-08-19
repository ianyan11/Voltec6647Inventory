using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voltec6647
{
    public partial class introAdmin : Form
    {
        public introAdmin()
        {
            InitializeComponent();
        }

        private void CerrarSesion(object sender, EventArgs e)
        {            
            Login inicio = new Login();
            inicio.Show();
            this.Close();
        }
        private void TomarH(object sender, EventArgs e)
        {
            TomarHerramienta Therramienta = new TomarHerramienta();
            Therramienta.Show();
            this.Close();
        }
        private void DevolverHerramienta(object sender, EventArgs e)
        {
            RegresarHeramienta regresarHerramienta = new RegresarHeramienta();
            regresarHerramienta.Show();
            this.Close();
        }
        public void cerrar()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ModificarHerramienta modificarHerramienta = new ModificarHerramienta();
            modificarHerramienta.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Show();
            this.Close();
        }
    }
}
