using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Servicios.Implementacion;
using TPI.Servicios.Interfaz;

namespace TPI.Servicios
{
    internal class FabricaServicioImp : FabricaServicioMantenimiento
    {
        public override IServicioMantenimiento CrearServicioMantenimiento()
        {
            return new ServicioMantenimiento();
        }
    }
}
