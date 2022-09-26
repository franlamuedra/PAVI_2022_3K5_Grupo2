using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.datos.DAO;

namespace TPI.Servicios
{
    public class GestorMateriales
    {
        private IMaterialDAO dao;

        public GestorMateriales()
        {
            dao = new MaterialDAO();
        }

        public List<Material> ConsultarMaterialFiltro(Dictionary<string, object> parametros)
        {
            List<Material> lista = dao.GetMaterialByFilters(parametros);
            return lista;
        }

        public int CrearMaterial(Material oMaterial)
        {
            return dao.Create(oMaterial);
        }
    }
}
