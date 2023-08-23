using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsisMed
{
    class ConexionBD
    {
        MySqlConnection conn = new MySqlConnection();

        static string server = "127.0.0.1";
        static string database = "asismed";
        static string user = "root";
        static string password = "";
        static string port = "3306";

        string conexionCompleta = "server=" + server
            + ";database=" + database
            + ";user=" + user
            + ";password=" + password
            + ";port=" + port;

        public MySqlConnection RealizarConexion() {
            try
            {

                conn.ConnectionString = conexionCompleta;
                conn.Open();

            }
            catch (MySqlException err){
                MessageBox.Show("Error con la conexión a la base de datos:" + err.ToString());
            }

            return conn;

        }
    }
}
