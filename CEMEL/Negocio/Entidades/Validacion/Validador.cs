using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMEL.Negocio.Entidades.Validacion
{
    public static class Validador
    {
        public static bool ValidarVacio(string texto)
        {
            if (texto == String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
