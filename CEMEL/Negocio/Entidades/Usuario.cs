using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CEMEL.Negocio.Entidades
{
    public class Usuario
    {
        private string _username;
        private Perfil _perfil;

        public enum Perfil
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
        /// 2 : Perfil consultorio (la validación se efectúa en el gestor)
        /// </returns>
        private static Perfil SetPerfil(int perfil)
        {
            if (perfil == 0)
            {
                return Perfil.administrador;
            }
            else if (perfil == 1)
            {
                return Perfil.secretaria;
            }
            return Perfil.consultorio;
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
        public Perfil GetPerfil()
        {
            return _perfil;
        }
    }
}
