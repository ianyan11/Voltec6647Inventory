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
    public partial class Cuanto : Form
    {

        public Cuanto()
        {
            InitializeComponent();
        }

        TomarHerramienta Therramienta = new TomarHerramienta();

        private void Cuanto_Load(object sender, EventArgs e)
        {
            Therramienta.Show();
            numericUpDown1.Maximum = Convert.ToInt16(Class1.CantidadStock);
            numericUpDown1.Minimum = 0;
            label1.Text = "¿Desea obtener la herramienta \"" + Class1.Herramienta + " \"?\n Cuanto de " + Class1.CantidadStock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor.servidor("SELECT * FROM Prestadas WHERE Herramienta='" + Class1.Herramienta + "' and Nombre ='" + Class1.Nombre + "'");
            if (Servidor.Dt.Rows.Count > 0)
            {
                DataRow row = Servidor.Dt.Rows[0];
                int Stock = Convert.ToInt32(row["CantidadStock"]);
                Servidor.servidor("UPDATE Prestadas SET CantidadStock='" + (Stock + numericUpDown1.Value) + "' WHERE Herramienta='" + Class1.Herramienta + "'and Nombre ='" + Class1.Nombre + "'");
            }
            else
            {
                Servidor.servidor("INSERT INTO Prestadas (Herramienta, CantidadStock, Imagen, Página, Descripción, Área, Cajón) SELECT * FROM Herramientas WHERE Herramienta='" + Class1.Herramienta + "'");  
                Servidor.servidor("UPDATE Prestadas SET Nombre='" + Class1.Nombre + "' WHERE Nombre IS NULL");
                Servidor.servidor("UPDATE Prestadas SET CantidadStock = '" + numericUpDown1.Value + "' WHERE Herramienta='" + Class1.Herramienta + "'and Nombre ='" + Class1.Nombre + "'");
            }
            if ((Convert.ToInt16(Class1.CantidadStock) - numericUpDown1.Value) != 0)
            {
                Servidor.servidor("UPDATE Herramientas SET CantidadStock ='" + (Convert.ToInt16(Class1.CantidadStock) - numericUpDown1.Value) + "' WHERE Herramienta='" + Class1.Herramienta + "'");
            }else{
                Servidor.servidor("DELETE FROM Herramientas WHERE Herramienta='" + Class1.Herramienta + "'");
            }
            TomarHerramienta herramienta = new TomarHerramienta();
            Therramienta.Close();
            herramienta.Show();
            //connection.Close();
            this.Close();
        } 
    }  
} 
