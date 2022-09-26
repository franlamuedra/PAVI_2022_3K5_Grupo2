using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public class MaterialDAO : IMaterialDAO
    {
        public int Create(Material nuevo)
        {
            throw new NotImplementedException();
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
                // int nroProv = int.Parse(row["Cod_Proveedor"].ToString());
                aux.ProveedorMa = row["Cod_Proveedor"].ToString();
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
    }
}
