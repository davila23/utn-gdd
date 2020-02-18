using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrbaHotel.Sistema
{
    class Inicio
    {
        SQLConnector connection;
        public Inicio(SQLConnector connectionInstance)
        {
            this.connection = connectionInstance;
        }
        public UsuarioLogueado login(string nombreDeUsuario, string contraseña)
        {
            string queryLogin = "declare @alfa numeric(1,0) exec HOTEL_CUATRIVAGOS.login_usuario '" + nombreDeUsuario + "','" + this.SHA256Encripta(contraseña) + "',@alfa out select @alfa";
            switch (Convert.ToInt32(connection.executeQueryEscalar(queryLogin)))
            {
                case 0:
                    return new UsuarioLogueado(nombreDeUsuario, contraseña, connection);
                case 1:
                    throw new Exception("usuario inhabilitado");
                case 2:
                    throw new Exception("usuario dado de baja");
                case 3:
                    throw new Exception("contraseña incorrecta");
                case 4:
                    throw new Exception("El usuario no existe");
            }
            return null;
        }

        public string SHA256Encripta(string input)
        {
            SHA256Managed provider = new SHA256Managed();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }
    }
}
