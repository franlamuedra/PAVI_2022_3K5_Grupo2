using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Herramienta
    {
        public string Marca_Herramienta { get; set; }
        public string Modelo_Herramienta { get; set; }
        public Tipo_Herramienta Tipo_Herramienta { get; set; }
        public Proveedor Proveedor_Herramienta { get; set; }

    }
}
sqlConnection