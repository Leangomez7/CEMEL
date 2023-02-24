using CEMEL.Negocio.Entidades.Validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEMEL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (ValidarVacio())
            {

            }
            else
            {
                MessageBox.Show("Por favor llene los campos");
            }
        }

        /// <summary>
        /// Valida que 
        /// </summary>
        /// <returns></returns>
        private bool ValidarVacio()
        {
            bool a = Validador.ValidarVacio(txtUsername.Text);
            bool b = Validador.ValidarVacio(txtUsername.Text);
            return a && b;
        }
    }
}
