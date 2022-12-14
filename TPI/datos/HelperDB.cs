using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;
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

        public int ConsultaEscalarSQL(string spNombre, string pOutNombre)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }

        public int EjecutarSQLSP(string sp, List<Parametro> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                SqlCommand cmd = new SqlCommand();
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Transaction = t;

                if (values != null)
                {
                    foreach (Parametro param in values)
                    {
                        cmd.Parameters.AddWithValue(param.Nombre, param.Valor);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }

            return afectadas;
        }

       public Herramienta ObtenerHerramientaPorId(string id)
       {    
            Herramienta her = new Herramienta();
            try
            {
                SqlCommand cmd = new SqlCommand();
                
                string consulta = "SELECT * FROM t_Herramientas WHERE Cod_Herramienta LIKE @id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    her.Marca = dr["Marca_Herramienta"].ToString();
                    her.Modelo = dr["Modelo_Herramienta"].ToString();

                }
                cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            return her;
       }
        public DataTable ObtenerMantenimientos()
        {            
            Herramienta her = new Herramienta();
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select h.Cod_Herramienta as 'Cod Herramienta' , h.Marca_Herramienta as 'Marca Herramienta', h.Modelo_Herramienta as 'Modelo Herramienta',d.Cambios, m.Fecha " +
                    "from t_Herramientas h " +
                    "inner join t_Detalles_Mantenimiento d on h.Cod_Herramienta = d.Codigo_Herramienta" +
                    "inner join t_Mantenimientos m on d.Numero_Mantenimiento = m.Numero_Mantenimiento";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cnn.Open();
                cmd.Connection = cnn;

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
                cnn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                cnn.Close();
            }
        }
    }
    

}
