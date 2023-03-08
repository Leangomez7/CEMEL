using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Entidades.Encriptacion;
using CEMEL.Negocio.Entidades.Validacion;
using CEMEL.Negocio.Usuarios;
using CEMEL.Presentacion.Menu;
using System;
using System.Windows.Forms;

namespace CEMEL
{
    public partial class PantallaIniciarSesion : Form
    {
        public PantallaIniciarSesion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Inicia el proceso de iniciar sesión en el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            GestorIniciarSesion.IniciarSesion(txtUsername.Text, txtContrasenia.Text, this);
        }

        /// <summary>
        /// Abre el menu principal y cierra el inicio de sesión
        /// </summary>
        /// <param name="menu"></param>
        /// <param name="sesion"></param>
        public void AbrirMenu(PantallaMenu menu, Sesion sesion)
        {
            menu.Show();
            Hide();
        }
    }
}
