using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.dominio;

namespace TPI
{
    public class Material
    {
        public string Nombre { get; set; }
        public int Codigo { get; set; }
        public float Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string FechaIngreso { get; set; }
        public int ProveedorMa { get; set; }
        public bool Activo { get; set; }
        
        public Material()
        {

        }

        public Material(string nom, int cod, float cant, string uni, string fecIng, int prov, bool activo)
        {
            Codigo = cod;
            Nombre = nom;
            Cantidad = cant;
            UnidadMedida = uni;
            FechaIngreso = fecIng;
            ProveedorMa = prov;
            Activo = activo;
        }
    }
}
