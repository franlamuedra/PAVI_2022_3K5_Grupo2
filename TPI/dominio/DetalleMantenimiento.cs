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
        public int Cantidad { get; set; }
        
        public DetalleMantenimiento(Herramienta h, int cant)
        {
            Herramienta = h;
            Cantidad = cant;
        }
    }
}
