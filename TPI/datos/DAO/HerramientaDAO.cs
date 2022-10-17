using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class HerramientaDAO : IHerramientaDAO
    {
        public int Create(Herramienta her)
        {
            string activo = "S";
            List<Parametro> parametros = new List<Parametro>();
            parametros.Add(new Parametro("@Cod_Prov", her.Codigo_Proveedor));
            parametros.Add(new Parametro("@Marca", her.Marca));
            parametros.Add(new Parametro("@Modelo", her.Modelo));
            parametros.Add(new Parametro("@Vida_Util", her.Vida_Util));
            parametros.Add(new Parametro("@Activo", activo));

            string insert = "INSERT INTO t_Herramientas VALUES (" + her.Codigo_Proveedor + ",'" + her.Marca + "','" + her.Modelo + "'," + her.Vida_Util + ",'" + activo + "')";

            int res = HelperDB.GetInstance().EjecutarSQL(insert, parametros);
            return res;
        }

        public List<Herramienta> GetByFilter(string marca, bool activo)
        {
            List<Herramienta> list = new List<Herramienta>();

            string query = "SELECT * FROM t_Herramientas WHERE 1=1";

            if (!string.IsNullOrEmpty(marca))
            {
                query += " AND Marca_Herramienta Like '%" + marca + "%'";
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
            parametros.Add(new Parametro("@Marca", marca));
            parametros.Add(new Parametro("@Activo", activo));

            DataTable resultado = HelperDB.GetInstance().ConsultaSQL(query, parametros);

            foreach (DataRow row in resultado.Rows)
            {
                Herramienta aux = new Herramienta();
                aux.Codigo = int.Parse(row["Cod_Herramienta"].ToString());
                aux.Codigo_Proveedor = int.Parse(row["Cod_Proveedor"].ToString());
                aux.Marca = row["Marca_Herramienta"].ToString();
                aux.Modelo = row["Modelo_Herramienta"].ToString();
                aux.Vida_Util = int.Parse(row["Vida_Util"].ToString());
                aux.Activo = row["Activo"].ToString().Equals("S");
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
