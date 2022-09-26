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
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string ProveedorMa { get; set; }
        public bool Activo { get; set; }
        
        public Material()
        {

        }

        public Material(string nom, int cod, double cant, string uni, DateTime fecIng, string prov, bool activo)
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
