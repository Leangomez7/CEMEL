using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMEL.Negocio.Entidades
{
    public class Sesion
    {
        private Usuario _user;
        private DateTime _loginDate;

        public Sesion (Usuario user){
            _user = user;
            _loginDate = DateTime.Now;
        }

        /// <summary>
        /// Devuelve el usuario de la sesión
        /// </summary>
        /// <returns></returns>
        public Usuario GetUsuario()
        {
            return _user;
        }

        /// <summary>
        /// Devuelve la fecha corta de la sesión
        /// </summary>
        /// <returns></returns>
        public string GetFecha()
        {
            return _loginDate.ToShortDateString();
        }
    }
}
