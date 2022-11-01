using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios
{
    public abstract class FabricaServicioAlquiler
    {
        public abstract IServicioAlquiler CrearServicioAlquiler();
    }
}
