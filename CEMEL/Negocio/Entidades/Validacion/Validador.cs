using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEMEL.Negocio.Entidades.Validacion
{
    public static class Validador
    {
        /// <summary>
        /// Valida si una cadena recibida está vacía
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>
        /// true: la cadena no está vacía
        /// false: la cadena está vacía
        /// </returns>
        public static bool ValidarVacio(string texto)
        {
            if (texto == "")
            {
                return false;
            }
            return true;
        }
    }
}