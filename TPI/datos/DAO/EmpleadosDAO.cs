using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;
using System.Reflection.Metadata;

namespace TPI.datos.DAO
{
    public class EmpleadosDAO
    {
        public static DataTable ObtenerListadoPersonasReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Cod_Empleado,Nombre, Apellido, Documento, Direccion, Telefono FROM Empleados";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool AgregarEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Empleado (Nombre, Apellido, Telefono, Documento, Direccion) VALUES(@Nombre, @Apellido, @Telefono, @Documento, @Direccion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", emp.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", emp.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@Documento", emp.Documento);
                cmd.Parameters.AddWithValue("@Direccion", emp.Direccion);
                
                
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }
        public static Empleado ObtenerEmpleado(int dni)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleado p = new Empleado();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Empleados where Documento like @dni";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@dni", dni);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.Nombre = dr["Nombre"].ToString();
                    p.Apellido = dr["Apellido"].ToString();             
                    p.Documento = int.Parse(dr["Documento"].ToString());
                    p.Direccion = dr["Direccion"].ToString();
                    p.Telefono = (int)dr["Telefono"];                    
                }

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return p;
        }
    }
}
