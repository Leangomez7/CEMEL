using CEMEL.Negocio.Entidades;
using CEMEL.Presentacion.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEMEL.Negocio.Menu
{
    public static class GestorMenu
    {
        /// <summary>
        /// Según el perfil del usuario determina las opciones que estarán habilitadas
        /// </summary>
        /// <param name="usuario"></param>
        public static void DeterminarPermisos(Usuario usuario, PantallaMenu pantalla)
        {
            if (usuario.GetPerfil() == Usuario.EPerfil.consultorio)
            {
                pantalla.MenuConsultorio();
            }
            else if (usuario.GetPerfil() == Usuario.EPerfil.secretaria)
            {
                pantalla.MenuSecretaria();
            }
            else if (usuario.GetPerfil() == Usuario.EPerfil.administrador)
            {
                pantalla.MenuAdministrador();
            }
            else
            {
                MessageBox.Show("No ha iniciado sesión con ningún perfil válido.");
                pantalla.MenuSinPerfil();
            }
        }
    }
}
