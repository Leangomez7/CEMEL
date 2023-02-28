using Shopping_Buy_All.ABMS.AccesoADatos;
using System.Data;

namespace CEMEL.Negocio.Usuarios
{
    public static class adUsuarios
    {
        public static DataTable BuscarUsuario(string username)
        {
            return AccesoADatos.Consultar("GetUsuarios " + username);
        }
    }
}
