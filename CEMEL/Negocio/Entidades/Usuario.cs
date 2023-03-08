using System.ComponentModel;

namespace CEMEL.Negocio.Entidades
{
    public class Usuario
    {
        private string _username;
        private EPerfil _perfil;

        public enum EPerfil
        {
            administrador,
            secretaria,
            consultorio
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="username"></param>
        /// <param name="perfil"></param>
        public Usuario(string username, int perfil)
        {
            _username = username;
            _perfil = SetPerfil(perfil);
        }

        /// <summary>
        /// Asigna el perfil según un número recibido
        /// </summary>
        /// <param name="perfil"></param>
        /// <returns>
        /// 0 : Perfil administrador
        /// 1 : Perfil secretaría
        /// 2 : Perfil consultorio 
        /// No puede venir otro numero porque la base de datos no lo permite
        /// </returns>
        private static EPerfil SetPerfil(int perfil)
        {
            if (perfil == 0)
            {
                return EPerfil.administrador;
            }
            else if (perfil == 1)
            {
                return EPerfil.secretaria;
            }
            return EPerfil.consultorio;
        }

        /// <summary>
        /// Devuelve el nombre del usuario
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return _username;
        }

        /// <summary>
        /// Devuelve el perfil del usuario
        /// </summary>
        /// <returns></returns>
        public EPerfil GetPerfil()
        {
            return _perfil;
        }
    }
}
