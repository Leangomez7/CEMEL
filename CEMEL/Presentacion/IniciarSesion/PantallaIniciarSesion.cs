using CEMEL.Negocio.Entidades.Validacion;
using CEMEL.Negocio.Usuarios;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CEMEL
{
    public partial class PantallaIniciarSesion : Form
    {
        public PantallaIniciarSesion()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            GestorIniciarSesion.IniciarSesion(txtUsername.Text, txtContrasenia.Text, this);
        }
    }
}
