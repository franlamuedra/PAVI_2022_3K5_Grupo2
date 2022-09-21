using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Composicion
    {
        public Material Material { get; set; }
        public Material Material_Componente { get; set; }
        public int Porcentaje { get; set; }
        public Composicion(Material material, Material material_Componente, int porcentaje)
        {
            Material = material;
            Material_Componente = material_Componente;
            Porcentaje = porcentaje;
        }
    }
}
