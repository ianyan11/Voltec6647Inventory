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
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();
        }

        private void CopiarBase_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseDataSet2.USUARIO' Puede moverla o quitarla según sea necesario.
            this.uSUARIOTableAdapter.Fill(this.databaseDataSet2.USUARIO);
            gridview_data();
        }
        public void gridview_data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iande\Documents\Voltec6647\Voltec6647\Database.mdf;Integrated Security=True");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USUARIO", connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "USUARIO");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "USUARIO";
            connection.Close();
            //Actualiza los datos de la tabla
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Class1.Admin)
            {
                introAdmin intro = new introAdmin();
                intro.Show();
                this.Close();
            }
            else
            {
                introNoAdmin intro = new introNoAdmin();
                intro.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedCells[0].Value.ToString();
            Class1.User = id;
            ModUsuario Mod = new ModUsuario();
            Mod.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AgregarUsuario AgU = new AgregarUsuario();
            AgU.Show();
            this.Close();
        }
    }
}
