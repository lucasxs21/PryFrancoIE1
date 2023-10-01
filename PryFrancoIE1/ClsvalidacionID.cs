using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PryFrancoIE1
{
    internal class ClsvalidacionID
    {
        private string usuarioValido = "Admin"; // Define el nombre de usuario válido
        private string contraseñaValida = "Admin"; // Define la contraseña válida

        public bool ValidarUsuario(string username, string password)
        {
            return username == usuarioValido && password == contraseñaValida;
        }

    }
}
