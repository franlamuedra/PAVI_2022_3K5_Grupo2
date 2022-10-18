using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class DetalleMantenimiento
    {
        public Herramienta Herramienta { get; set; }
        public string Cambios { get; set; }
        
        public DetalleMantenimiento(Herramienta h, string cam)
        {
            Herramienta = h;
            Cambios = cam;
        }
    }
}
