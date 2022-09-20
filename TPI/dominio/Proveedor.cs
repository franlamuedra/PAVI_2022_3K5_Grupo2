using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.dominio
{
    public class Proveedor
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }

        public Proveedor()
        {

        }

        public Proveedor(int cod, string nom, int tel, string mail, string direccion)
        {
            Codigo = cod;
            Nombre = nom;
            Telefono = tel;
            Mail = mail;
            Direccion = direccion;
        }
    }
}
