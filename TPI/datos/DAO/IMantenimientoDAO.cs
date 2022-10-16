using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.datos.DAO
{
    public interface IMantenimientoDAO
    {
        List<Herramienta> GetHerramientas();
        bool Create(Mantenimiento oMantenimiento);
        bool Update(Mantenimiento oMantenimiento);
        bool Delete(int nro);
        List<Mantenimiento> GetMantenimientoByFilter(string fecha, string empl);

    }
}
