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

        private SqlConnection cnn;
        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
            string_conexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=Ferreteria_Industrial;Integrated Security=True";
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
            finally
            {
                if (dbConnection.State != ConnectionState.Closed)
                    dbConnection.Close();
            }
        }

        public int EjecutarSQL(string strSql, List<Parametro> lst)
        {
            int rafc = 0;
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = strSql;

            foreach (Parametro p in lst)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            rafc = cmd.ExecuteNonQuery();
            cnn.Close();

            return rafc;                    
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
