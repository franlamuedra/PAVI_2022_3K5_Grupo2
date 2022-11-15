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
    internal class AlquilerDAO : IAlquilerDAO
    {
        public bool Create(Alquiler oAlquiler)
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
                cmd.CommandText = "SP_Insertar_Alquiler";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dir", oAlquiler.Direccion);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@num_alq";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int numMant = (int)pOut.Value;

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleAlquiler item in oAlquiler.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_Insert_Detalle2", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@num_alq", numMant);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@cod_herramienta", item.Herramienta.Codigo);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
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

        public bool Delete(int nro)
        {
            string sp = "SP_Eliminar_Alquiler";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_alq", nro));
            int afectadas = HelperDB.GetInstance().EjecutarSQLSP(sp, lst);
            return afectadas > 0;
        }

        public List<Alquiler> GetAlquilerByFilter(DateTime desde, DateTime hasta)
        {
            List<Alquiler> mants = new List<Alquiler>();
            string sp = "SP_Consultar_Alquileres";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@desde", desde));
            lst.Add(new Parametro("@hasta", hasta));
            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Alquiler mant = new Alquiler();
                mant.Numero_Alquiler = int.Parse(row["Numero_Alquiler"].ToString());
                mant.Fecha_Entrega = DateTime.Parse(row["Fecha_Entrega"].ToString());
                mant.Fecha_Devolucion = DateTime.Parse(row["Fecha_Devolucion"].ToString());
                mant.Direccion = row["Direccion"].ToString();
                mants.Add(mant);
            }

            return mants;
        }

        public Alquiler GetAlquilerPorNro(int nro)
        {
            Alquiler oAlquiler = new Alquiler();
            string sp = "SP_Consultar_Detalles_Alquiler";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_alq", nro));

            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            bool primero = true;

            foreach (DataRow row in dt.Rows)
            {
                if (primero)
                {
                    oAlquiler.Fecha_Entrega = DateTime.Parse(row["Fecha_Entrega"].ToString());
                    oAlquiler.Fecha_Entrega = DateTime.Parse(row["Fecha_Devolucion"].ToString());
                    oAlquiler.Direccion = row["Direccion"].ToString();
                    primero = false;
                }

                int cod = int.Parse(row["Cod_Herramienta"].ToString());
                Herramienta h = new Herramienta(cod);
                DetalleAlquiler detalle = new DetalleAlquiler(h);
                oAlquiler.AgregarDetalle(detalle);
            }
            return oAlquiler;
        }

        public DataTable GetReport(string modelo)
        {
            string sp = "SP_Reporte_Alquileres";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@marca", modelo));
            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            return dt;
        }
    

        public List<Herramienta> GetHerramientas()
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

                Herramienta aux = new Herramienta(cod, marca, modelo, vida, codProv, activo);
                lst.Add(aux);
            }

            return lst;
        }


        public int NextAlquiler()
        {
            string sp = "SP_Proximo_Alquiler";
            return HelperDB.GetInstance().ConsultaEscalarSQL(sp, "@next");    
            
        }

        public bool Update(Alquiler oAlquiler)
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
                cmd.CommandText = "SP_Modificar_Alquiler";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dir", oAlquiler.Direccion);
                cmd.Parameters.AddWithValue("@num_alq", oAlquiler.Numero_Alquiler);
                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleAlquiler item in oAlquiler.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_Insert_Detalle2", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@num_alq", oAlquiler.Numero_Alquiler);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("cod_herramienta", item.Herramienta.Codigo);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
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
    }
}
