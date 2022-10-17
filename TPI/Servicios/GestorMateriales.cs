using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TPI.datos;
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

        public List<Material> ConsultarMaterialFiltro(String nombre, bool activo)
        {
            List<Material> lista = dao.GetByFilter(nombre, activo);
            return lista;
        }

        public int CrearMaterial(Material oMaterial)
        {
            return dao.Create(oMaterial);
        }

        public bool ValidarProveedor(int cod)
        {
            return dao.ValidateProv(cod);
        }
    }
}
