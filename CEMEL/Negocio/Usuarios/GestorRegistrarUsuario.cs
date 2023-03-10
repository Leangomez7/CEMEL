using CEMEL.Negocio.Entidades.Encriptacion;
using CEMEL.Negocio.Entidades.Validacion;
using CEMEL.Presentacion.Menu;
using CEMEL.Presentacion.Usuarios;
using System;
using System.Data;
using System.Windows.Forms;

namespace CEMEL.Negocio.Usuarios
{
    public static class GestorRegistrarUsuario
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
        public static void CargarUsuario(string usuario, string contra, string contra2, int perfil, string textoPerfil, PantallaRegistrarUsuario pantalla)
        {
            if (Validar(usuario, contra, contra2, perfil))
            {
                DataTable userTable = BuscarUsuario(usuario);
                if (userTable.Rows.Count == 0)
                {
                    RegistrarUsuario(usuario, contra, perfil, pantalla, textoPerfil);
                }
                else
                {
                    MessageBox.Show(String.Format("El usuario {0} ya existe.", usuario));
                }
            }
        }

        /// <summary>
        /// Inicia las primeras validaciones; valida que todos los textbox estén completos y que las contraseñas coincidan
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <param name="contra2"></param>
        /// <param name="perfil"></param>
        /// <returns>
        /// true: todos los textbox están completos y las contraseñas coinciden
        /// false: o algún textbox no está completo o las contraseñas no coinciden
        /// </returns>
        public static bool Validar(string usuario, string contra, string contra2, int perfil)
        {
            if (ValidarVacio(usuario, contra, contra2, perfil))
            {
                if (contra.Equals(contra2))
                {
                    if (usuario.Length <= 32)
                    {
                        return true;
                    }
                    MessageBox.Show("El nombre de usuario debe tener 32 caracteres como máximo.");
                    return false;
                }
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }
            MessageBox.Show("Por favor llene los campos.");
            return false;
        }

        /// <summary>
        /// Valida que se hayan completado todos los campos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <param name="contra2"></param>
        /// <param name="perfil"></param>
        /// <returns></returns>
        private static bool ValidarVacio(string usuario, string contra, string contra2, int perfil)
        {
            bool a = Validador.ValidarVacio(usuario);
            bool b = Validador.ValidarVacio(contra);
            bool c = Validador.ValidarVacio(contra2);
            bool d = Validador.ValidarComboVacio(perfil);
            return a && b && c && d;
        }

        /// <summary>
        /// Hace lo necesario para poder volver al menu principal
        /// </summary>
        /// <param name="pantalla"></param>
        public static void Volver(PantallaRegistrarUsuario pantalla)
        {
            PantallaMenu menu = new PantallaMenu(pantalla.GetSesion());
            pantalla.Volver(menu);
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
        /// Manda a registrar al usuario en la base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contra"></param>
        /// <param name="perfil"></param>
        /// <param name="pantalla"></param>
        private static void RegistrarUsuario(string usuario, string contra, int perfil, PantallaRegistrarUsuario pantalla, string textoPerfil)
        {
            string mensaje = String.Format("¿Está seguro que quiere cargar al usuario {0} con el perfil {1}?", usuario, textoPerfil);
            DialogResult result = MessageBox.Show(mensaje, "Confirmar carga de usuario", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                // Encripta la contraseña
                byte[] salt = Encriptador.GenerateSalt();
                byte[] contraHash = Encriptador.HashPassword(contra, salt, 600000);

                // Manda a registrar al usuario a la base de datos
                adUsuarios.CargarUsuarios(usuario, contraHash, salt, perfil);
                MessageBox.Show(String.Format("Se cargó al usuario {0} con el perfil {1} exitosamente.", usuario, textoPerfil), "Éxito");
                // Manda a volver al menu principal
                Volver(pantalla);
            }
        }
    }
}