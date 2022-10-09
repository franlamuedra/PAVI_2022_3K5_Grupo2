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

        private SqlConnection cnn;
        public HelperDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
            
        }
        public static HelperDB GetInstance()
        {
            if (instance == null)
                instance = new HelperDB();
            return instance;
        }
        
        public DataTable ConsultaSQL(string strSql, List<Parametro> lst = null)
        {

            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSql;

            if (lst != null && lst.Count > 0)
            {
                foreach (Parametro p in lst)
                {
                    cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
                }
            }

            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            return tabla;
            
        }

<<<<<<< HEAD
        public int EjecutarSQL(string strSql, Dictionary <string, object> prs = null)
=======
        public int EjecutarSQL(string strSql, List<Parametro> lst)
>>>>>>> e645161c7e8a9bb7fd501e394bbd042efd580aa7
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
        

    }
    

}
