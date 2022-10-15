using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Mantenimiento
    {
        public int Numero_Mantenimiento { get; set; }
        public int Codigo_Herramienta { get; set; }
        public string Fecha { get; set; }
        public int Codigo_Empleado { get; set; }
        public string Cambio { get; set; }

        public Mantenimiento()
        {

        }
    }
}
