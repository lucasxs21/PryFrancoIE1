using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;

namespace PryFrancoIE1
{
    internal class ClsvalidacionID
    {
        private string usuarioValido = "Admin"; // Define el nombre de usuario válido
        private string contraseñaValida = "Admin"; // Define la contraseña válida

        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SistemaBroker.accdb;";

        public bool ValidarUsuario(string username, string password)
        {


            // Cadena de conexión 
            //string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SistemaBroker.accdb;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT User, Contrasena FROM User WHERE usuario = ?";  // Utiliza parámetros para prevenir inyección SQL

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.Add(new OleDbParameter("User", username));

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string usuarioEnBaseDeDatos = reader["User"].ToString();
                                string contraseñaEnBaseDeDatos = reader["Contrasena"].ToString();

                                return usuarioEnBaseDeDatos == username && contraseñaEnBaseDeDatos == password;
                            }
                            else
                            {
                                return false; // El usuario no existe en la base de datos
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores, puedes registrar el error o mostrar un mensaje de error.
                    return false;
                }
            }
        }



        public static string Usuario { get; set; }

        
        


    }
}
