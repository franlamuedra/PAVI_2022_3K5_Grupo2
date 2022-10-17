﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public DataTable ConsultaSQLSP(string sp, List<Parametro> values)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (Parametro oParametro in values)
                {
                    cmd.Parameters.AddWithValue(oParametro.Nombre, oParametro.Valor);
                }
            }
            dt.Load(cmd.ExecuteReader());
            cnn.Close();

            return dt;
        }
        
        public SqlConnection GetConnection()
        {
            return this.cnn;
        }
    }
    

}
