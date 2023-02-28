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

        public Usuario GetUsuario()
        {
            return _user;
        }
    }
}
