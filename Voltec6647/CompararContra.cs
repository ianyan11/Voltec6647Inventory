using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Voltec6647
{
    class CompararContra
    {
        public static Boolean comparar(String Matricula, String contraForms)
        {
            Boolean comp = false;
            Servidor.servidor("SELECT Contraseña FROM USUARIO WHERE Matricula='" + Convert.ToString(Matricula) + "'");  
            if (Servidor.Dt.Rows.Count > 0)//Si el usuario coincide significa que dt tiene va taner almenos un valor
            {
                DataRow row = Servidor.Dt.Rows[0];
                String contraseña = Convert.ToString(row["Contraseña"]);//Convierte a string la contraseña la fila 0 de dt donde la columna es igual a "Contraseña"

                contraseña = contraseña.Replace(" ", string.Empty);//quita espacios
                if (contraseña.Equals(contraForms))
                {
                    Servidor.servidor("SELECT * FROM USUARIO WHERE Matricula='" + Convert.ToString(Matricula) + "'");
                    row = Servidor.Dt.Rows[0];
                    Class1.Nombre = Convert.ToString(row["Nombre"]);
                    Class1.Admin = Convert.ToBoolean(row["Admin"]);

                    comp = true;
                }else{
                    MessageBox.Show("La contraseña es incorrecta");
                }
            }else{
                MessageBox.Show("El usuario no existe");
            }
            return (comp);
        }
    }
}
