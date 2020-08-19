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
    public partial class RegresarHeramienta : Form
    {
        public RegresarHeramienta()
        {
            InitializeComponent();
        }

        private void CopiarBase_Load(object sender, EventArgs e)
        {
            gridview_data();
        }

        public void gridview_data()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iande\Documents\Voltec6647\Voltec6647\Database.mdf;Integrated Security=True");
            connection.Open();

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Prestadas WHERE Nombre= '"+ Class1.Nombre +"'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Prestadas");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Prestadas";
            connection.Close();
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
            string id = dataGridView1.SelectedCells[1].Value.ToString();
            Class1.Herramienta = id;
            Servidor.servidor("SELECT * FROM Prestadas WHERE Herramienta='" + id + "'");
            DataRow row = Servidor.Dt.Rows[0];

            Class1.CantidadStock = Convert.ToString(row["CantidadStock"]);
            CuantoR cuanto = new CuantoR();
            cuanto.Show();
            this.Close();
        }
    }
}