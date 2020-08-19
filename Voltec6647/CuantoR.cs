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
    public partial class CuantoR : Form
    {

        public CuantoR()
        {
            InitializeComponent();
        }
        TomarHerramienta Rherramienta = new TomarHerramienta();

        private void Cuanto_Load(object sender, EventArgs e)
        {
            Rherramienta.Show();
            numericUpDown1.Maximum = Convert.ToInt16(Class1.CantidadStock);
            numericUpDown1.Minimum = 0;
            label1.Text = "¿Desea devolver la herramienta \"" + Class1.Herramienta + " \"?\n Cuanto de " + Class1.CantidadStock;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Servidor.servidor("SELECT * FROM Herramientas WHERE Herramienta='" + Class1.Herramienta + "'");
            if (Servidor.Dt.Rows.Count > 0)
            {
                DataRow row = Servidor.Dt.Rows[0];
                int Stock = Convert.ToInt32(row["CantidadStock"]);
                Servidor.servidor("UPDATE Herramientas SET CantidadStock='" + (Stock + numericUpDown1.Value) + "' WHERE Herramienta='" + Class1.Herramienta + "'");
            }else{
                Servidor.servidor("INSERT INTO Herramientas (Herramienta, CantidadStock, Imagen, Página, Descripción, Área, Cajón) SELECT Herramienta, CantidadStock, Imagen, Página, Descripción, Área, Cajón FROM Prestadas WHERE Herramienta='" + Class1.Herramienta + "'and Nombre ='" + Class1.Nombre + "'");
                Servidor.servidor("UPDATE Herramientas SET CantidadStock = '" + numericUpDown1.Value + "' WHERE Herramienta='" + Class1.Herramienta + "'");
            }

            if ((Convert.ToInt16(Class1.CantidadStock) - numericUpDown1.Value) != 0)
            {
                Servidor.servidor("UPDATE Prestadas SET CantidadStock ='" + (Convert.ToInt16(Class1.CantidadStock) - numericUpDown1.Value) + "' WHERE Herramienta='" + Class1.Herramienta + "'and Nombre ='" + Class1.Nombre + "'");
            }else{
                Servidor.servidor("DELETE FROM Prestadas WHERE Herramienta='" + Class1.Herramienta + "'and Nombre ='" + Class1.Nombre + "'");
            }
            RegresarHeramienta herramienta = new RegresarHeramienta();
            herramienta.Show();
            Rherramienta.Close();
            this.Close();
        }
    }
}
