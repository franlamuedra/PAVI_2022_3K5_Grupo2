using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public interface IProveedorDAO
    {
        List<Proveedor> GetByFilter(string nombre, bool activo);
        int Create(Proveedor prov);
    }
}
