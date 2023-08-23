using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AsisMed
{
    class Modelos
    {
        internal bool insertarUsuario(Datos nUsuario)
        {

            ConexionBD objetoConexion = new ConexionBD();

            string InsertU = "INSERT INTO usuarios (usuario, contrasena, nombre, apellido_paterno, apellido_materno) VALUES (@usuario, @contrasenia, @nombre, @apePaterno, @apeMaterno)";
            MySqlCommand mySqlCommand = new MySqlCommand(InsertU, objetoConexion.RealizarConexion());
            mySqlCommand.Parameters.Add(new MySqlParameter("@usuario", nUsuario.User));
            mySqlCommand.Parameters.Add(new MySqlParameter("@contrasenia", nUsuario.Password));
            mySqlCommand.Parameters.Add(new MySqlParameter("@nombre", nUsuario.Name));
            mySqlCommand.Parameters.Add(new MySqlParameter("@apePaterno", nUsuario.FirstName));
            mySqlCommand.Parameters.Add(new MySqlParameter("@apeMaterno", nUsuario.LastName));

            return mySqlCommand.ExecuteNonQuery() > 0;

        }

        public bool validarUsuarioInsert(string usuario)
        {
            MySqlDataReader consultas;
            ConexionBD objetoConexion = new ConexionBD();

            string ValidarU = "SELECT id FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand mySqlCommand = new MySqlCommand(ValidarU, objetoConexion.RealizarConexion());
            mySqlCommand.Parameters.Add(new MySqlParameter("@usuario", usuario));
            consultas = mySqlCommand.ExecuteReader();

            if (consultas.HasRows)
            {
                return true;
            }
            else {
                return false;
            }

        }


        public Datos validarInicioSesion(string usuario)
        {
            MySqlDataReader consultarUsuario;
            ConexionBD objetoConexion = new ConexionBD();

            string ValidarU = "SELECT usuario, contrasena, nombre, apellido_paterno, apellido_materno FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand mySqlCommand = new MySqlCommand(ValidarU, objetoConexion.RealizarConexion());
            mySqlCommand.Parameters.Add(new MySqlParameter("@usuario", usuario));
            consultarUsuario = mySqlCommand.ExecuteReader();

            Datos datosUsuario = null;
            while (consultarUsuario.Read())
            {
                datosUsuario = new Datos();
                datosUsuario.User = consultarUsuario["usuario"].ToString();
                datosUsuario.Password = consultarUsuario["contrasena"].ToString();
                datosUsuario.Name = consultarUsuario["nombre"].ToString();
                datosUsuario.FirstName = consultarUsuario["apellido_paterno"].ToString();
                datosUsuario.LastName = consultarUsuario["apellido_materno"].ToString();
            }

            return datosUsuario;

        }

    }
}
