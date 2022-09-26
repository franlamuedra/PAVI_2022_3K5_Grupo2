using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TPI.datos
{
    class HelperDB
    {
        private static HelperDB instance;

        private string string_conexion;
        public HelperDB()
        {
            string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=Ferreteria_Industrial;Integrated Security=True";//acceso a BD
        }
        public static HelperDB GetInstance()
        {
            if (instance == null)
                instance = new HelperDB();
            return instance;
        }

        public DataTable ConsultaSQL(string strSql, Dictionary<string, object> prs = null)
        {

            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {

                dbConnection.ConnectionString = string_conexion;               
                dbConnection.Open();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public int EjecutarSQL(string strSql, Dictionary<string, object> prs = null)
        {
            // Se utiliza para sentencias SQL del tipo “Insert/Update/Delete”
            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            int rtdo = 0;

            // Try Catch Finally
            // Trata de ejecutar el código contenido dentro del bloque Try - Catch
            // Si hay error lo capta a través de una excepción
            // Si no hubo error
            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;

                //Agregamos a la colección de parámetros del comando los filtros recibidos
                if (prs != null)
                {
                    foreach (var item in prs)
                    {
                        cmd.Parameters.AddWithValue(item.Key, item.Value);
                    }
                }

                // Retorna el resultado de ejecutar el comando
                rtdo = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return rtdo;
        }

        public object ConsultaSQLScalar(string strSql)
        {
            SqlConnection dbConnection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            try
            {
                dbConnection.ConnectionString = string_conexion;
                dbConnection.Open();
                cmd.Connection = dbConnection;
                cmd.CommandType = CommandType.Text;
                // Establece la instrucción a ejecutar
                cmd.CommandText = strSql;
                return cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
        }

    }
}
