using Shopping_Buy_All.ABMS.AccesoADatos;
using System.Data;
using System.Data.SqlClient;

namespace CEMEL.Negocio.Usuarios
{
    public static class adUsuarios
    {
        /// <summary>
        /// Busca un usuario por nombre en la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static DataTable BuscarUsuario(string username)
        {
            return AccesoADatos.Consultar(string.Format("GetUsuarios {0}", username));
        }

        /// <summary>
        /// Carga un usuario en la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="profile"></param>
        public static void CargarUsuarios(string username, byte[] password, byte[] salt, int profile)
        {
            string queryStmt = string.Format("CargarUsuario {0}, @contra, @sal, {1}", username, profile);
            using (SqlCommand _cmd = new SqlCommand(queryStmt))
            {
                SqlParameter param = _cmd.Parameters.Add("@contra", SqlDbType.Binary);
                SqlParameter param2 = _cmd.Parameters.Add("@sal", SqlDbType.Binary);
                param.Value = password;
                param2.Value = salt;
                AccesoADatos.ModificarDB(_cmd);
            }
        }
    }
}
