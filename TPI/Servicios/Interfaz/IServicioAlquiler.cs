using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI.Servicios.Interfaz
{
    public interface IServicioAlquiler
    {
        public int ProximoAlquiler();
        List<Herramienta> ObtenerHerramientas();
        List<Alquiler> ObtenerAlquileres(DateTime desde, DateTime hasta);
        bool CrearAlquiler(Alquiler oAlquiler);
        bool ModificarAlquiler(Alquiler oAlquiler);
        bool EliminarAlquiler(int nro);
        Alquiler ObtenerAlquilerPorNro(int nro);

        DataTable ObtenerReporteAlquiler(string marca);
    }
}
