using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class ProveedorDAO : IProveedorDAO
    {
        public int Create(Proveedor prov)
        {
            string activo = "S";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Nombre", prov.Nombre));
            parametros.Add(new Parametro("@Telefono", prov.Telefono));
            parametros.Add(new Parametro("@Mail", prov.Mail));
            parametros.Add(new Parametro("@Direccion", prov.Direccion));
            parametros.Add(new Parametro("@Activo", prov.Activo));
            string insert = "INSERT INTO t_Proveedores VALUES (@Nombre, @Telefono, @Mail, @Direccion,'" + activo + "')";

            int res = HelperDB.GetInstance().EjecutarSQL(insert, parametros);
            return res;
        }


        public List<Proveedor> GetByFilter(string nombre, bool activo)
        {
            List<Proveedor> list = new List<Proveedor>();

            string query = "SELECT * FROM t_Proveedores WHERE 1=1";

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
                Proveedor aux = new Proveedor();
                aux.Codigo = int.Parse(row["Cod_Proveedor"].ToString());
                aux.Nombre = row["Nombre"].ToString();
                aux.Telefono = row["Telefono"].ToString();
                aux.Mail = row["Mail"].ToString();
                aux.Direccion = row["Direccion"].ToString();
                aux.Activo = row["Activo"].ToString().Equals("S");
                list.Add(aux);

            }

            return list;
        }
    }
}
