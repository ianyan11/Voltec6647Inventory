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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mat = Matricula.Text;
            String contra = Contraseña.Text;
            Boolean sino = CompararContra.comparar(mat, contra);//Recibe los valores de la contraseña y la matricula y lo compara para ver si coinciden
            if (sino)
            {
                if (Class1.Admin) {
                    introAdmin intro = new introAdmin();
                    intro.Show();
                    this.Hide();
                }
                else
                {
                    introNoAdmin intro = new introNoAdmin();
                    intro.Show();
                    this.Hide();
                }
            }
        }

        private void Matricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }//Esto nos permite a no tener que picarle al boton de Log-in necesariamente, sino que tambien funcione con la tecla enter
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
    }
}
