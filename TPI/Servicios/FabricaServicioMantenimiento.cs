using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios
{
    public abstract class FabricaServicioMantenimiento
    {
        public abstract IServicioMantenimiento CrearServicioMantenimiento();
    }
}
