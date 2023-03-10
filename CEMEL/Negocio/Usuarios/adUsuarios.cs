using Shopping_Buy_All.ABMS.AccesoADatos;
using System;
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
            return AccesoADatos.Consultar(String.Format("GetUsuarios {0}", username));
        }

        /// <summary>
        /// Manda a cargar un usuario en la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="profile"></param>
        public static void CargarUsuarios(string username, byte[] password, byte[] salt, int profile)
        {
            string queryStmt = String.Format("CargarUsuario {0}, @contra, @sal, {1}", username, profile);
            CrearComando(queryStmt, password, salt);
        }

        /// <summary>
        /// Manda a modificar un usuario de la base de datos
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        /// <param name="profile"></param>
        public static void ModificarUsuarios(string username, byte[] password, byte[] salt, int profile)
        {
            string queryStmt = String.Format("ModificarUsuario {0}, @contra, @sal, {1}", username, profile);
            CrearComando(queryStmt, password, salt);
        }

        /// <summary>
        /// Manda a cargar o modificar usuarios en la base de datos
        /// </summary>
        /// <param name="consulta"></param>
        /// <param name="password"></param>
        /// <param name="salt"></param>
        private static void CrearComando(string consulta, byte[] password, byte[] salt)
        {
            using (SqlCommand _cmd = new SqlCommand(consulta))
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
