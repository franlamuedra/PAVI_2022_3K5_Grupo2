using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Herramienta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Tipo_Herramienta Tipo { get; set; }
        public Proveedor Proveedor { get; set; }
        public int Vida_Util { get; set; }
        public Herramienta(string marca, string mod, Tipo_Herramienta tipo, Proveedor prov, int vid)
        {
            Marca = marca;
            Modelo = mod;
            Tipo = tipo;
            Proveedor = prov;
            Vida_Util = vid;
        }
    }
}
