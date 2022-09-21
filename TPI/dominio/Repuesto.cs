using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Repuesto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public int Cantidad { get; set; }
        public Repuesto(string modelo, string marca, string tipo, int cantidad)
        {
            Modelo = modelo;
            Marca = marca;
            Tipo = tipo;
            Cantidad = cantidad;
        }   
    }
}
