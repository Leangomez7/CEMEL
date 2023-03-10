using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Usuarios;
using CEMEL.Presentacion.Menu;
using System;
using System.Windows.Forms;

namespace CEMEL.Presentacion.Usuarios
{
    public partial class PantallaModificarUsuario : Form
    {
        private Sesion _sesion;
        private Usuario _usuario;

        public PantallaModificarUsuario(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
        }

        /// <summary>
        /// Pide buscar un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _usuario = GestorModificarUsuario.BuscarUsuario(txtUsername.Text);
            GestorModificarUsuario.AbrirModificarUsuario(this);
        }

        /// <summary>
        /// Pide volver al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GestorModificarUsuario.Volver(this);
        }

        /// <summary>
        /// Vuelve al menu principal
        /// </summary>
        public void Volver(PantallaMenu menu)
        {
            menu.Show();
            Hide();
        }

        /// <summary>
        /// Devuelve la Sesión
        /// </summary>
        /// <returns></returns>
        public Sesion GetSesion()
        {
            return _sesion;
        }

        /// <summary>
        /// Devuelve el Usuario
        /// </summary>
        /// <returns></returns>
        public Usuario GetUsuario()
        {
            return _usuario;
        }
    }
}
