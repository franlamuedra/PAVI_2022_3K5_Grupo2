using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Herramienta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Codigo { get; set; }
        public int Codigo_Proveedor { get; set; }
        public int Vida_Util { get; set; }
        public bool Activo { get; set; }
        
        public Herramienta()
        {

        }
    }



}
