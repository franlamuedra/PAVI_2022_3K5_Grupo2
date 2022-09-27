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

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", mat.Nombre));
            parametros.Add(new Parametro("@Codigo_Material", mat.Codigo));
            parametros.Add(new Parametro("@Cantidad", mat.Cantidad));
            parametros.Add(new Parametro("@Unidad_Medida", mat.UnidadMedida));
            parametros.Add(new Parametro("@Activo", mat.Activo));
            parametros.Add(new Parametro("@Cod_Proveedor", mat.ProveedorMa));
            parametros.Add(new Parametro("@Fecha_Ingreso", mat.FechaIngreso));

            string insert = "INSERT INTO Materiales VALUES ('" + mat.Nombre + "','" + mat.Codigo + "'," + mat.Cantidad + ",'" + mat.UnidadMedida + "','" + mat.ProveedorMa + "','" + mat.FechaIngreso + "')";

            int res = HelperDB.GetInstance().EjecutarSQL(insert, parametros);
            return res;
        }


        public List<Material> GetByFilter(string nombre, bool activo)
        {
            List<Material> list = new List<Material>();

            string query = "SELECT * FROM Materiales WHERE 1=1";

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
                aux.Cantidad = double.Parse(row["Cantidad"].ToString());
                aux.FechaIngreso = row["Fecha_Ingreso"].ToString();
                aux.Activo = row["Activo"].ToString().Equals("S");
                aux.ProveedorMa = row["Cod_Proveedor"].ToString();
                list.Add(aux);                            

            }

            return list;
        }

    }
}
