using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Camion
    {
        public int Patente { get; set; }
        public string Marca { get; set; }
        public int Año_Modelo { get; set; }
        public int Capacidad { get; set; }
        public Camion(int patente, string marca, int año_Modelo, int capacidad)
        {
            Patente = patente;
            Marca = marca;
            Año_Modelo = año_Modelo;
            Capacidad = capacidad;
        }
    }
}
