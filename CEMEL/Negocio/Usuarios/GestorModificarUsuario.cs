using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Entidades.Encriptacion;
using CEMEL.Negocio.Entidades.Validacion;
using CEMEL.Presentacion.Menu;
using CEMEL.Presentacion.Usuarios;
using System;
using System.Data;
using System.Windows.Forms;

namespace CEMEL.Negocio.Usuarios
{
    public static class GestorModificarUsuario
    {
        /// <summary>
        /// Controla el proceso de cargar usuarios
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <param name="contra2"></param>
        /// <param name="perfil"></param>
        /// <param name="textoPerfil"></param>
        /// <param name="pantalla"></param>
        public static void ModificarUsuario(string usuario, string contra, string contra2, int perfil, string textoPerfil, PantallaRegistrarUsuario pantalla)
        {
            if (GestorRegistrarUsuario.Validar(usuario, contra, contra2, perfil))
            {
                Usuario usu = pantalla.GetUsuario();
                string mensaje = String.Format("¿Está seguro que quiere modificar al usuario {0}? \n" +
                                               "\tLos cambios serán:\n" +
                                               "\tNombre de usuario:" +
                                               "\t{0} -> {1}" +
                                               "\tPerfil:" +
                                               "\t{2} -> {3}", usu.GetUsername(), usuario, usu.GetPerfil(), textoPerfil);
                DialogResult result = MessageBox.Show(mensaje, "Confirmar modificacion de usuario", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    ModificarUsuario(usuario, contra, perfil, pantalla, textoPerfil);
                }
            }
        }

        /// <summary>
        /// Manda a buscar al usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static Usuario BuscarUsuario(string usuario)
        {
            if (Validar(usuario))
            {
                DataTable userTable = adUsuarios.BuscarUsuario(usuario);
                if (userTable.Rows.Count == 1)
                {
                    string username = (string)userTable.Rows[0]["username"];
                    int profile = (int)userTable.Rows[0]["profile"];
                    return new Usuario(username, profile);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de usuario correctamente.");
                return null;
            }
        }

        /// <summary>
        /// Valida que el nombre de usuario ingresado sea válido
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>
        /// false: el nombre de usuario ingresado o está vacío o tiene más de 32 caracteres de largo
        /// true: el nombre de usuario ingresado es válido
        /// </returns>
        private static bool Validar(string usuario)
        {
            if (usuario.Length > 32 && Validador.ValidarVacio(usuario))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Hace lo necesario para poder volver al menu principal
        /// </summary>
        /// <param name="pantalla"></param>
        public static void Volver(PantallaModificarUsuario pantalla)
        {
            PantallaMenu menu = new PantallaMenu(pantalla.GetSesion());
            pantalla.Volver(menu);
        }

        /// <summary>
        /// Abre la modificacion del usuario
        /// </summary>
        /// <param name="pantalla"></param>
        public static void AbrirModificarUsuario(PantallaModificarUsuario pantalla)
        {
            Usuario usu = pantalla.GetUsuario();
            if (usu != null)
            {
                PantallaRegistrarUsuario mod = new PantallaRegistrarUsuario(pantalla.GetSesion(), usu);
                mod.Show();
                pantalla.Hide();
            }
            else
            {
                MessageBox.Show("No se ha encontrado al usuario.");
            }
        }

        /// <summary>
        /// Manda a registrar al usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <param name="perfil"></param>
        /// <param name="pantalla"></param>
        private static void ModificarUsuario(string usuario, string contra, int perfil, PantallaRegistrarUsuario pantalla, string textoPerfil)
        {
            // Encripta la contraseña
            byte[] salt = Encriptador.GenerateSalt();
            byte[] contraHash = Encriptador.HashPassword(contra, salt, 600000);

            // Manda a registrar al usuario a la base de datos
            adUsuarios.ModificarUsuarios(usuario, contraHash, salt, perfil);
            MessageBox.Show(String.Format("Se modificó al usuario {0} con el perfil {1} exitosamente.", usuario, textoPerfil), "Éxito");

            // Manda a volver al menu principal
            PantallaMenu menu = new PantallaMenu(pantalla.GetSesion());
            pantalla.Volver(menu);
        }
    }
}
