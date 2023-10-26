
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PryFrancoIE1
{
    internal class ClsvalidacionID
    {
         

        string rutaArchivo ;

        string connectionString ;

        public ClsvalidacionID()
        {
            rutaArchivo = @"../../Broker/sistemaBroker.accdb";
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + rutaArchivo;

        }


        public bool ValidarUsuario(string username, string password)
        {


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT User, Contrasena FROM Usuarios WHERE User = ?";  // Utiliza parámetros para prevenir inyección SQL

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

        
        public void CargarLogs(string Usuario ,DateTime Fecha,string Accion)
        {
            try
            {
               
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "INSERT INTO Logs (Usuario, FechaHora, Accion) VALUES (@Usuario, @Fecha, @Accion)";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Usuario", Usuario);
                        command.Parameters.AddWithValue("@Fecha", Fecha);
                        command.Parameters.AddWithValue("@Accion", Accion);
                        
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                //informar el error por pantalla
            }
        }


    }
}
