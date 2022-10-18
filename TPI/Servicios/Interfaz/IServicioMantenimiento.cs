using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.Servicios.Interfaz
{
    public interface IServicioMantenimiento
    {
        public int ProximoMantenimiento();
        List<Herramienta> ObtenerHerramientas();
        List<Mantenimiento> ObtenerMantenimientos(DateTime desde, DateTime hasta, string empl);
        bool CrearMantenimiento(Mantenimiento oMantenimiento);
        bool ModificarMantenimiento(Mantenimiento oMantenimiento);
        bool EliminarMantenimiento(int nro);
        Mantenimiento ObtenerMantenimientoPorNro(int nro);

    }
}
