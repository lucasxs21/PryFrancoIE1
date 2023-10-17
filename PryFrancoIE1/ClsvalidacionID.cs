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



        public bool ValidarUsuario(string username, string password)
        {
            

            // Cadena de conexión 
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SistemaBroker.accdb;";

            // Crear una conexión 
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para seleccionar usuarios y contraseñas de la tabla "User"
                    string query = "SELECT usuario, contraseña FROM User";

                    // Crear un comando SQL
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Ejecutar la consulta y obtener un lector de datos
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            // Iterar a través de los registros y mostrar usuarios y contraseñas
                            while (reader.Read())
                            {
                                string usuario = reader["usuario"].ToString();
                                string contraseña = reader["contraseña"].ToString();

                                return username == usuario && password == contraseña;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    
                }

            }
        }
        public static string Usuario { get; set; }


    }
}
