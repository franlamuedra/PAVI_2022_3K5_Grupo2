using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    internal class Empleado
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public int Documento { get; set; }
        public string Direccion { get; set; }
        public Empleado(int codigo, string nombre, int telefono, int documento, string direccion)
        {
            Codigo = codigo;
            Nombre = nombre;
            Telefono = telefono;
            Documento = documento;
            Direccion = direccion;
        }
    }
}
