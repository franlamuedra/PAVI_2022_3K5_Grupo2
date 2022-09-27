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
            string strSql = "INSERT INTO Materiales (Nombre, Codigo_Material, Cantidad, Unidad_Medida, Cod_Proveedor, Fecha_Ingreso, Activo)" +
                "VALUES ('" + mat.Nombre + "'," + mat.Codigo + "," + mat.Cantidad + ",'" + mat.UnidadMedida + "'," + mat.ProveedorMa + "," + mat.FechaIngreso + "," + mat.Activo + ")";        

            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", mat.Nombre));
            parametros.Add(new Parametro("@Codigo_Material", mat.Codigo));
            parametros.Add(new Parametro("@Cantidad", mat.Cantidad));
            parametros.Add(new Parametro("@Unidad_Medida", mat.UnidadMedida));
            parametros.Add(new Parametro("@Fecha_Ingreso", mat.FechaIngreso));
            parametros.Add(new Parametro("@Cod_Proveedor", mat.ProveedorMa));
            parametros.Add(new Parametro("@Fecha_Ingreso", mat.FechaIngreso));

            int res = HelperDB.GetInstance().EjecutarSQL(strSql, parametros);
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
                query += " AND @Activo = 'S'";
            }
            else
            {
                query += " AND @Activo = 'N'";
            }

            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombre);
            parametros.Add("activo", activo);

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                Material aux = new Material();
                aux.Nombre = row["Nombre"].ToString();
                aux.UnidadMedida = row["Unidad_Medida"].ToString();
                aux.Cantidad = double.Parse(row["Cantidad"].ToString());
                aux.FechaIngreso = DateTime.Parse(row["Fecha_Ingreso"].ToString());
                aux.Activo = row["Activo"].ToString().Equals("S");
                //int nroProv = int.Parse(row["Cod_Proveedor"].ToString());
                //aux.ProveedorMa = row["Cod_Proveedor"].ToString();
                list.Add(aux);

                /*string queryProv = "Select * From Proveedores Where Cod_Proveedor = @nroProv";
                parametros.Add("nroProv", nroProv);
                DataTable resProv = HelperDB.GetInstance().ConsultaSQL(queryProv, parametros);
                foreach (DataRow filaProv in resProv.Rows)
                {
                    Proveedor prov = new Proveedor();
                    prov.Telefono = int.Parse(filaProv["Telefono"].ToString());
                    prov.Nombre = filaProv["Nombre"].ToString();
                    prov.Mail = filaProv["Mail"].ToString();
                    prov.Direccion = filaProv["Direccion"].ToString();
                    // aux.ProveedorMa = prov;
                }*/               
                

            }


            return list;

        }

        public List<Material> GetMaterialByFilters(Dictionary<string, object> parametros)
        {
            var strSql = string.Concat("" +
                "Select Mat.Codigo_Material, " +
                "       Mat.Nombre, " +
                "       Mat.Cantidad, " +
                "       Mat.Unidad_Medida, " +
                "       Mat.Cod_Proveedor, " +
                "       Pr.Nombre as Proveedor, " +
                "       Mat.Fecha_Ingreso, " +
                "       Mat.Activo " +
                "From Materiales as Mat " +
                "Left Join Proveedores as Pr ON Pr.Cod_Proveedor = Mat.Cod_Proveedor " +
                "Where 1=1 ");

            if (parametros.ContainsKey("Nombre"))
                strSql += "And (Mat.Nombre like '%@Nombre%') ";

            if (parametros.ContainsKey("Activo"))
                strSql += "And (Mat.Activo like '@Activo') ";

            strSql += "Order by Mat.Codigo_Material Desc";

            List<Material> resultado = new List<Material>();

            DataTable dt = HelperDB.GetInstance().ConsultaSQL(strSql, parametros);

            foreach (DataRow row in dt.Rows)
            {
                resultado.Add(MappingMaterial(row));
            }

            return resultado;
        }

        private Material MappingMaterial(DataRow row)
        {
            Material oMaterial = new Material();
            oMaterial.Codigo = Convert.ToInt32(row["Codigo_Material"].ToString());
            oMaterial.Cantidad = Convert.ToDouble(row["Cantidad"].ToString());

            if (row["Activo"].ToString() == "S")
                oMaterial.Activo = true;
            else
                oMaterial.Activo = false;

            oMaterial.UnidadMedida = row["Unidad_Medida"].ToString();
            oMaterial.FechaIngreso = Convert.ToDateTime(row["Fecha_Ingreso"].ToString());
            oMaterial.Nombre = row["Nombre"].ToString();

            Proveedor prov = new();
            prov.Codigo = 2;
            oMaterial.ProveedorMa = prov.Codigo; 

           /* oMaterial.ProveedorMa = new Proveedor();
            oMaterial.ProveedorMa.Codigo = Convert.ToInt32(row["Cod_Proveedor"].ToString());
            oMaterial.ProveedorMa.Telefono = Convert.ToInt32(row["Telefono"].ToString());
            oMaterial.ProveedorMa.Mail = row["Mail"].ToString();
            oMaterial.ProveedorMa.Direccion = row["Direccion"].ToString();
            oMaterial.ProveedorMa.Nombre = row["Nombre"].ToString();*/

            return oMaterial;
        }
    }
}
