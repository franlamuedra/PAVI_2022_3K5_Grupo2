using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class ProveedoresDAO
    {
        public static bool AgregarProveedor(Proveedor pro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Proveedores (Nombre, Apellido, Direccion, Telefono, Mail) VALUES(@nombre, @apellido, @direccion, @mail)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", pro.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pro.Apellido);
                cmd.Parameters.AddWithValue("@mail", pro.Telefono);
                cmd.Parameters.AddWithValue("@direccion", pro.Mail);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);                
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

        public static Proveedor ObtenerProveedor(string codigo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Proveedor p = new Proveedor();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Proveedores where Codigo like @codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.Nombre = dr["Nombre"].ToString();
                    p.Apellido = dr["Apellido"].ToString();
                    p.Direccion = dr["Direccion"].ToString();
                    p.Telefono = (int)dr["Telefono"];
                    p.Mail = dr["Mail"].ToString();
                    
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

        public static bool ActualizarProveedor(Proveedor pro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Proveedores SET Codigo = @codigo, Nombre = @nombre, Apellido = @apellido, Direccion = @direccion, Telefono = @telefono, Mail = @mail WHERE Codigo like @codigo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", pro.Codigo);
                cmd.Parameters.AddWithValue("@nombre", pro.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pro.Apellido);
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@mail", pro.Mail);
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

        public static bool EliminarProveedor(Proveedor pro)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaDB"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;

            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "DELETE FROM Proveedores WHERE Codigo = @codigo AND Nombre = @nombre AND Apellido = @apellido AND Direccion = @direccion AND Telefono = @telefono AND Mail = @mail";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codigo", pro.Codigo);
                cmd.Parameters.AddWithValue("@nombre", pro.Nombre);
                cmd.Parameters.AddWithValue("@apellido", pro.Apellido);
                cmd.Parameters.AddWithValue("@direccion", pro.Direccion);
                cmd.Parameters.AddWithValue("@telefono", pro.Telefono);
                cmd.Parameters.AddWithValue("@mail", pro.Mail);
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
    }
}
