using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Entidades.Encriptacion;
using CEMEL.Negocio.Entidades.Validacion;
using CEMEL.Presentacion.Menu;
using System;
using System.Data;
using System.Runtime;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CEMEL.Negocio.Usuarios
{
    public static class GestorIniciarSesion
    {
        /// <summary>
        /// Coordina el inicio del sesión
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="pantalla"></param>
        public static void IniciarSesion(string username, string password, PantallaIniciarSesion pantalla)
        {
            if (ValidarVacio(username, password))
            {
                DataTable userTable = BuscarUsuario(username);
                if (userTable.Rows.Count > 0)
                {
                    AbrirMenu(password, userTable, pantalla);
                }
                else
                {
                    MessageBox.Show(String.Format("No se encontró al usuario {0}.", username));
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos.");
            }
        }

        /// <summary>
        /// Valida que los campos usuario y contraseña tengan texto no vacío
        /// </summary>
        /// <returns>
        /// true : si ninguno de los campos está vacío
        /// false : si alguno de los campos está vacío
        /// </returns>
        private static bool ValidarVacio(string user, string passsword)
        {
            bool a = Validador.ValidarVacio(user);
            bool b = Validador.ValidarVacio(passsword);
            return a && b;
        }

        /// <summary>
        /// Busca al usuario en la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private static DataTable BuscarUsuario(string username)
        {
            return adUsuarios.BuscarUsuario(username);
        }

        /// <summary>
        /// Valida si la contraseña es válida
        /// </summary>
        /// <param name="passwordSis"></param>
        /// <param name="userTable"></param>
        /// <returns>
        /// true : las contraseñas coinciden
        /// false : las contraseñas no coinciden
        /// </returns>
        private static bool ValidarContrasenia(string passwordSis, DataTable userTable)
        {
            byte[] salt = (byte[])userTable.Rows[0]["salt"];
            byte[] passwordDB = (byte[])userTable.Rows[0]["password"];

            byte[] encriptedPassword = Encriptador.HashPassword(passwordSis, salt, 600000);

            if (Encriptador.CompareByteArrays(encriptedPassword, passwordDB))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Si la contraseña es correcta hace todo lo necesario para poder abrir el menu principal
        /// </summary>
        /// <param name="password"></param>
        /// <param name="userTable"></param>
        /// <param name="pantalla"></param>
        private static void AbrirMenu(string password, DataTable userTable, PantallaIniciarSesion pantalla)
        {
            if (ValidarContrasenia(password, userTable))
            {
                // Crea el usuario
                string username = (string)userTable.Rows[0]["username"];
                int profile = (int)userTable.Rows[0]["profile"];
                Usuario user = new Usuario(username, profile);

                // Crea la sesión
                Sesion sesion = new Sesion(user);

                // Crea el menu
                PantallaMenu menu = new PantallaMenu(sesion);

                // Cierra el inicio de sesión y abre el menu
                pantalla.AbrirMenu(menu, sesion);
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta.");
            }
        }
    }
}
