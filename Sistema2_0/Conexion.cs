using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema2_0
{
    class Conexion
    {
        public static MySqlConnection conex()
        {

            string cadenaConexion = "Database=sistemacisco; DataSource=localhost; uid=root; pwd=Sinhue2001;";
            MySqlConnection connection = new MySqlConnection(cadenaConexion);

            try
            {
                return connection;
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message + e.StackTrace + "Tienes un pedo");
                return null;
            }
        }

    }
}
