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
        public int Codigo { get; set; }
        // public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Proveedor ProveedorMa { get; set; }
        
        public Material()
        {

        }

        public Material(int cod, double cant, string uni, DateTime fecIng, Proveedor prov)
        {
            Codigo = cod;
            // Nombre = nom; atributo no creado en DB
            Cantidad = cant;
            UnidadMedida = uni;
            FechaIngreso = fecIng;
            ProveedorMa = prov;
        }
    }
}
