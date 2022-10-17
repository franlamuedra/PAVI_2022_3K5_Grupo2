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
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }

        public Proveedor(int codigo, string nom, string ap, int tel, string mail, string direccion)
        {
            Codigo = codigo;
            Nombre = nom;
            Apellido = ap;
            Telefono = tel;
            Mail = mail;
            Direccion = direccion;
        }
    }
}
