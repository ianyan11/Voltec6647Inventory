using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Voltec6647
{
    class Servidor
    {
        static DataTable dt;
        public static void servidor(String queryString) 
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\iande\Documents\Voltec6647\Voltec6647\Database.mdf;Integrated Security=True");
            SqlCommand command = new SqlCommand(queryString, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);

            command = new SqlCommand(queryString, connection);
            adap = new SqlDataAdapter(command);
            adap.Fill(dt);
            Servidor.Dt=dt;
        }
        public static DataTable Dt
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }
    }
}
