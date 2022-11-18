using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Servicios.Implementacion;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios
{
    internal class FabricaServicioImpALq : FabricaServicioAlquiler
    {
        public override IServicioAlquiler CrearServicioAlquiler()
        {
            return new ServicioAlquiler();
        }
    }
}
