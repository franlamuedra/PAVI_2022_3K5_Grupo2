using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class MantenimientoDAO : IMantenimientoDAO
    {
        public List<Herramienta> ObtenerHerramientas()
        {
            List<Herramienta> lst = new List<Herramienta>();
            string sp = "SP_Consultar_Herramientas";
            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, null);
            
            foreach (DataRow dr in dt.Rows)
            {
                int cod = int.Parse(dr["Cod_Herramienta"].ToString());
                int codProv = int.Parse(dr["Cod_Proveedor"].ToString());
                string marca = dr["Marca_Herramienta"].ToString();
                string modelo = dr["Modelo_Herramienta"].ToString();
                int vida = int.Parse(dr["Vida_Util"].ToString());
                bool activo = dr["Activo"].ToString().Equals("S");

                Herramienta aux = new Herramienta();
                aux.Codigo = cod;
                aux.Codigo_Proveedor = codProv;
                aux.Marca = marca;
                aux.Modelo = modelo;
                aux.Vida_Util = vida;
                aux.Activo = activo;
                lst.Add(aux);
            }

            return lst;
        }

        public bool Create(Mantenimiento oMantenimiento)
        {
            bool bol = true;
            SqlConnection cnn = HelperDB.GetInstance().GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_Insertar_Mantenimiento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cod", oMantenimiento.Numero_Mantenimiento);
                cmd.Parameters.AddWithValue("@nom", oMantenimiento.Nombre_Empleado);
                cmd.Parameters.AddWithValue("@cambio", oMantenimiento.Cambio);
                cmd.Parameters.AddWithValue("@fec", oMantenimiento.Fecha);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@num_man";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();
                
                t.Commit();
         
            }

            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                bol = false;

            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return bol;
        }

        public bool Update(Mantenimiento oMantenimiento)
        {
            bool bol = true;
            SqlConnection cnn = HelperDB.GetInstance().GetConnection();
            SqlTransaction t = null;
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = t;
                cmd.CommandText = "SP_Modificar_";
            }
            return bol;
        }

        public bool Delete(int nro)
        {
            return true;
        }
    }
}
