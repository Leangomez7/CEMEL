using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Menu;
using CEMEL.Presentacion.Usuarios;
using System;
using System.Windows.Forms;

namespace CEMEL.Presentacion.Menu
{
    public partial class PantallaMenu : Form
    {
        private Sesion _sesion;

        public PantallaMenu(Sesion sesion)
        {
            InitializeComponent();
            _sesion = sesion;
            GestorMenu.DeterminarPermisos(_sesion.GetUsuario(), this);
        }

        /// <summary>
        /// Asigna los permisos de administrador en el Menu
        /// </summary>
        public void MenuAdministrador()
        {
            CargarUsuario();
        }

        /// <summary>
        /// Asigna los permisos de secretaría en el Menu
        /// </summary>
        public void MenuSecretaria()
        {
            CargarUsuario();
            tsmiEmpleados.Enabled = false;
            tsmiEstudios.Enabled = false;
            tsmiServicios.Enabled = false;
            tsmiConsultarUsuarios.Enabled = false;
        }

        /// <summary>
        /// Asigna los permisos de consultorio en el Menu
        /// </summary>
        public void MenuConsultorio()
        {
            CargarUsuario();
            tsmiEmpleados.Enabled = false;
            tsmiEstudios.Enabled = false;
            tsmiPacientes.Enabled = false;
            tsmiServicios.Enabled = false;
            tsmiConsultarUsuarios.Enabled = false;
        }

        /// <summary>
        /// Bloquea todas las opciones
        /// </summary>
        public void MenuSinPerfil()
        {
            tsmiEmpleados.Enabled = false;
            tsmiEstudios.Enabled = false;
            tsmiPacientes.Enabled = false;
            tsmiServicios.Enabled = false;
            tsmiListadoDePacientes.Enabled = false;
            tsmiConsultarUsuarios.Enabled = false;
        }

        /// <summary>
        /// Muestra en pantalla algunos datos del usuario
        /// </summary>
        private void CargarUsuario()
        {
            txtUsername.Text = "Nombre de usuario: " + _sesion.GetUsuario().GetUsername();
            txtPerfil.Text = "Usuario: " + _sesion.GetUsuario().GetPerfil();
            txtFecha.Text = "Fecha: " + _sesion.GetFecha();
        }

        /// <summary>
        /// Inicia el registro de un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRegistrarUsuario_Click(object sender, System.EventArgs e)
        {
            PantallaRegistrarUsuario pantalla = new PantallaRegistrarUsuario(GetSesion());
            pantalla.Show();
            Close();
        }

        /// <summary>
        /// Devuelve la sesión
        /// </summary>
        /// <returns></returns>
        private Sesion GetSesion()
        {
            return _sesion;
        }
    }
}