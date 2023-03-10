using CEMEL.Negocio.Entidades;
using CEMEL.Negocio.Usuarios;
using CEMEL.Presentacion.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEMEL.Presentacion.Usuarios
{
    public partial class PantallaRegistrarUsuario : Form
    {
        private Sesion _sesion;
        private Usuario _usuario;
        public PantallaRegistrarUsuario(Sesion sesion)
        {
            InitializeComponent();
            CargarComboBox();
            _sesion = sesion;
            btnModificarUsuario.Enabled = false;
            lblTitulo.Text = "Registrar usuario";
        }

        public PantallaRegistrarUsuario(Sesion sesion, Usuario usuario)
        {
            InitializeComponent();
            CargarComboBox();
            _sesion = sesion;
            _usuario = usuario;
            txtUsuario.Text = usuario.GetUsername();
            cmbPerfiles.SelectedIndex = usuario.GetNumeroPerfil();
            btnCargarUsuario.Enabled = false;
            lblTitulo.Text = "Modificar usuario";
        }

        /// <summary>
        /// Inicia el proceso de cargar un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarUsuario_Click(object sender, EventArgs e)
        {
            GestorRegistrarUsuario.CargarUsuario(txtUsuario.Text, txtContra.Text, txtRepetirContra.Text, cmbPerfiles.SelectedIndex, cmbPerfiles.SelectedItem.ToString(), this);
        }

        /// <summary>
        /// Pide volver al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GestorRegistrarUsuario.Volver(this);
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
        /// Devuelve la Usuario
        /// </summary>
        /// <returns></returns>
        public Usuario GetUsuario()
        {
            return _usuario;
        }

        /// <summary>
        /// Carga los items del comboBox
        /// </summary>
        private void CargarComboBox()
        {
            cmbPerfiles.Items.Add("Administrador");
            cmbPerfiles.Items.Add("Secretaría");
            cmbPerfiles.Items.Add("Consultorio");
        }

        /// <summary>
        /// Inicia la modificación de un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            GestorModificarUsuario.ModificarUsuario(txtUsuario.Text, txtContra.Text, txtRepetirContra.Text, cmbPerfiles.SelectedIndex, cmbPerfiles.SelectedItem.ToString(), this);
        }
    }
}
