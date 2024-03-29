﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Input;

namespace Shopping_Buy_All.ABMS.AccesoADatos
{
    public static class AccesoADatos
    {
        public enum TipoConexion
        {
            simple,
            transaccion
        }
        public enum TipoEstado
        {
            correcto,
            error,
            sinTransaccion
        }

        private static SqlConnection conexion = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlTransaction transaccion;
        private static TipoConexion tipoConexion = TipoConexion.simple;
        private static TipoEstado tipoEstado = TipoEstado.sinTransaccion;

        public static string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBaseDatos"];

        /// <summary>
        /// Para iniciar una transacción
        /// </summary>
        public static void IniciarTransaccion()
        {
            tipoConexion = TipoConexion.transaccion;
            tipoEstado = TipoEstado.correcto;
        }

        /// <summary>
        /// Permite finalizar una transacción 
        /// </summary>
        /// <returns></returns>
        public static TipoEstado FinalizarTransaccion()
        {
            if (tipoConexion == TipoConexion.simple)
            {
                return TipoEstado.sinTransaccion;
            }
            if (tipoEstado == TipoEstado.correcto)
            {
                // final exitoso
                transaccion.Commit();
            }
            else
            {
                // final no exitoso
                transaccion.Rollback();
            }
            // establece el tipo de conexion simple para poder desconectarse utilizando Desconectar()
            tipoConexion = TipoConexion.simple;

            // desconecta el programa de la DB
            Desconectar();

            // devuelve el estado con el que finalizó la transacción
            return tipoEstado;
        }

        /// <summary>
        /// Para conectarse a la DB
        /// </summary>
        public static void Conectar()
        {
            // valida que la conexión esté cerrada
            if (conexion.State == ConnectionState.Closed)
            {
                // asigna la cadena de conexión
                conexion.ConnectionString = cadenaConexion;
                try
                {
                    // abre la conexion con la BD
                    conexion.Open();
                }
                catch (Exception ex)
                {
                    // mensaje de error que se emite cuando se produjo un error en la conexión
                    MessageBox.Show("Hubo un error en la Base de Datos\n Con el comando: \nconexion.Open()\nEl error en la base de datos:\n" + ex.Message);
                    // establece el estado de error
                    tipoEstado = TipoEstado.error;
                    return;
                }
                // asigna la conexión al comando command
                command.Connection = conexion;
                // asigna el tipo de comando
                command.CommandType = CommandType.Text;
                if (tipoConexion == TipoConexion.transaccion)
                {
                    transaccion = conexion.BeginTransaction();
                    command.Transaction = transaccion;
                }
            }
        }

        /// <summary>
        /// Para desconectarse de la DB
        /// </summary>
        public static void Desconectar()
        {
            // cierra la conexion si es simple
            if (tipoConexion == TipoConexion.simple)
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Para hacerle consultas a la DB 
        /// </summary>
        /// <returns></returns>
        public static DataTable Consultar(string comando)
        {
            // abre la conexion a la DB
            Conectar();
            // establece el comando como la consulta a realizar
            command.CommandText = comando;
            // crea la tabla donde se cargaran los datos recuperados de la DB
            DataTable tabla = new DataTable();

            try
            {
                tabla.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                // mensaje de error que aparece cuando hubo un error con la consulta
                MessageBox.Show("Hubo un error en la Base de Datos\n Con el comando: \n" + comando + "\nEl error en la base de datos:\n" + ex.Message);
                // establece el estado de error
                tipoEstado = TipoEstado.error;
                // desconecta de la DB
                Desconectar();
                return tabla;
            }
            Desconectar();
            return tabla;
        }

        /// <summary>
        /// Se encarga de insertar, modificar y borrar registros de la DB partiendo de un String
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public static TipoEstado ModificarDB(string comando)
        {
            Conectar();
            command.CommandText = comando;
            try
            {
                // ejecuta la consulta
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // mensaje de error que aparece cuando hubo un error con la consulta
                MessageBox.Show("Hubo un error en la Base de Datos\n Con el comando: \n" + comando + "\nEl error en la base de datos:\n" + ex.Message);
                // establece el estado de error
                tipoEstado = TipoEstado.error;
                return tipoEstado;
            }
            Desconectar();
            return tipoEstado;
        }

        /// <summary>
        /// Se encarga de insertar, modificar y borrar registros de la DB partiendo de un SqlCommand
        /// </summary>
        /// <param name="comando"></param>
        /// <returns></returns>
        public static TipoEstado ModificarDB(SqlCommand comando)
        {
            Conectar();
            command = comando;
            command.Connection = conexion;
            try
            {
                // ejecuta la consulta
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // mensaje de error que aparece cuando hubo un error con la consulta
                MessageBox.Show("Hubo un error en la Base de Datos\n Con el comando: \n" + comando + "\nEl error en la base de datos:\n" + ex.Message);
                // establece el estado de error
                tipoEstado = TipoEstado.error;
                return tipoEstado;
            }
            Desconectar();
            return tipoEstado;
        }
    }
}
