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
    public partial class introNoAdmin : Form
    {
        public introNoAdmin()
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
            RegresarHeramienta regresarHeramienta = new RegresarHeramienta();
            regresarHeramienta.Show();
            this.Close();
        }
        public void cerrar()
        {

        }
    }
}
