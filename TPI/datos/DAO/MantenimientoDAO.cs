using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class MantenimientoDAO : IMantenimientoDAO
    {
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
                cmd.Parameters.AddWithValue("@nom", oMantenimiento.Nombre_Empleado);

                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@num_man";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int numMant = (int)pOut.Value;

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleMantenimiento item in oMantenimiento.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_Insert_Detalle", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@num_man", numMant);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@cod_herramienta", item.Herramienta.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cambios", item.Cambios);
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
                cmd.CommandText = "SP_Modificar_Mantenimiento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nom", oMantenimiento.Nombre_Empleado);
                cmd.Parameters.AddWithValue("@num_man", oMantenimiento.Numero_Mantenimiento);
                cmd.ExecuteNonQuery();

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleMantenimiento item in oMantenimiento.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_Insert_Detalle", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@num_man", oMantenimiento.Numero_Mantenimiento);                  
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("cod_herramienta", item.Herramienta.Codigo);
                    cmdDetalle.Parameters.AddWithValue("@cambios", item.Cambios);
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
            string sp = "SP_Eliminar_Mantenimiento";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_man", nro));
            int afectadas = HelperDB.GetInstance().EjecutarSQLSP(sp, lst);
            return afectadas > 0;
        }
        public List<Mantenimiento> GetMantenimientoByFilter(DateTime desde, DateTime hasta, string empl)
        {
            List<Mantenimiento> mants = new List<Mantenimiento>();
            string sp = "SP_Consultar_Mantenimientos";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@desde", desde));
            lst.Add(new Parametro("@hasta", hasta));
            lst.Add(new Parametro("@empl", empl));
            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);

            foreach (DataRow row in dt.Rows)
            {
                Mantenimiento mant = new Mantenimiento();
                mant.Numero_Mantenimiento = int.Parse(row["Numero_Mantenimiento"].ToString());
                mant.Fecha = DateTime.Parse(row["Fecha"].ToString());
                mant.Nombre_Empleado = row["Nombre_Empleado"].ToString();
                mants.Add(mant);
            }

            return mants;
        }

        public int NextMantenimiento()
        {
            string sp = "SP_Proximo_Numero";
            return HelperDB.GetInstance().ConsultaEscalarSQL(sp, "@next");
        }

        public Mantenimiento GetMantenimientoPorNro(int nro)
        {
            Mantenimiento oMantenimiento = new Mantenimiento();
            string sp = "SP_Consultar_Detalles_Mantenimiento";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@num_man", nro));

            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            bool primero = true;

            foreach (DataRow row in dt.Rows)
            {
                if (primero)
                {
                    oMantenimiento.Fecha = DateTime.Parse(row["Fecha"].ToString());
                    oMantenimiento.Nombre_Empleado = row["Nombre_Empleado"].ToString();
                    primero = false;
                }

                int cod = int.Parse(row["Cod_Herramienta"].ToString());
                Herramienta h = new Herramienta(cod);
                string cambios = row["Cambios"].ToString();
                DetalleMantenimiento detalle = new DetalleMantenimiento(h, cambios);
                oMantenimiento.AgregarDetalle(detalle);
            }
            return oMantenimiento;
        }

        public DataTable GetReport(string modelo)
        {
            string sp = "SP_Reporte_Mantenimientos";
            List<Parametro> lst = new List<Parametro>();
            lst.Add(new Parametro("@modelo", modelo));
            DataTable dt = HelperDB.GetInstance().ConsultaSQLSP(sp, lst);
            return dt;
        }
    }
}
