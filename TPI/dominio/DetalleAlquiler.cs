using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class DetalleAlquiler
    {
        public Herramienta Herramienta { get; set; }
        
        public DetalleAlquiler(Herramienta h)
        {
            Herramienta = h;
        }
    }
}
