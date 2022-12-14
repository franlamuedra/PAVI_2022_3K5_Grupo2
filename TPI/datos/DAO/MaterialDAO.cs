using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;
using TPI.datos;

namespace TPI.datos.DAO
{
    public class MaterialDAO : IMaterialDAO
    {   
        public int Create(Material mat)
        {
            string activo = "S";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", mat.Nombre));
            parametros.Add(new Parametro("@Cantidad", mat.Cantidad));
            parametros.Add(new Parametro("@Unidad_Medida", mat.UnidadMedida));
            parametros.Add(new Parametro("@Cod_Proveedor", mat.ProveedorMa));
            parametros.Add(new Parametro("@Fecha_Ingreso", mat.FechaIngreso));    
            parametros.Add(new Parametro("@Activo", activo));

            string insert = "INSERT INTO t_Materiales VALUES ('" + mat.Nombre + "'," + mat.Cantidad + ",'" + mat.UnidadMedida + "'," + mat.ProveedorMa + ",'" + mat.FechaIngreso + "','" + activo + "')";

            int res = HelperDB.GetInstance().EjecutarSQL(insert, parametros);
            return res;
        }


        public List<Material> GetByFilter(string nombre, bool activo)
        {
            List<Material> list = new List<Material>();

            string query = "SELECT * FROM t_Materiales WHERE 1=1";

            if (!string.IsNullOrEmpty(nombre))
            {
                query += " AND Nombre Like '%" + nombre + "%'";
            }
            if (activo)
            {
                query += " AND Activo = 'S'";
            }
            else
            {
                query += " AND Activo = 'N'";
            }

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", nombre));
            parametros.Add(new Parametro("@Activo", activo));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                Material aux = new Material();
                aux.Nombre = row["Nombre"].ToString();
                aux.Codigo = int.Parse(row["Codigo_Material"].ToString());
                aux.UnidadMedida = row["Unidad_Medida"].ToString();
                aux.Cantidad = float.Parse(row["Cantidad"].ToString());
                aux.FechaIngreso = row["Fecha_Ingreso"].ToString();
                aux.Activo = row["Activo"].ToString().Equals("S");
                aux.ProveedorMa = int.Parse(row["Cod_Proveedor"].ToString());
                list.Add(aux);                            

            }

            return list;
        }

        public bool ValidateProv(int cod)
        {
            string query = "SELECT * FROM t_Proveedores WHERE Cod_Proveedor = " + cod + "";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Codigo", cod));
            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);
            if (resultado.Rows.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

    }
}
