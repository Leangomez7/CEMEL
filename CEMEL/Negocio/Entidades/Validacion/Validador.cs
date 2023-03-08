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

        /// <summary>
        /// Valida si se seleccionó algo de un combobox
        /// </summary>
        /// <param name="seleccion"></param>
        /// <returns>
        /// true: se seleccionó algo
        /// false: no se seleccionó nada
        /// </returns>
        public static bool ValidarComboVacio(int seleccion)
        {
            if (seleccion == -1)
            {
                return false;
            }
            return true;
        }
    }
}