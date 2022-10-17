using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.datos.DAO;
using TPI.dominio;

namespace TPI.Servicios
{
    public class GestorProveedores
    {
        private IProveedorDAO dao;

        public GestorProveedores()
        {
            dao = new ProveedorDAO();
        }

        public List<Proveedor> ConsultarProveedorFiltro(String nombre, bool activo)
        {
            List<Proveedor> lista = dao.GetByFilter(nombre, activo);
            return lista;
        }

        public int CrearProveedor(Proveedor oProveedor)
        {
            return dao.Create(oProveedor);
        }
    }
}
